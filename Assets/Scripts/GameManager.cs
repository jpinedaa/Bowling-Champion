using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour {

	private List <int> rolls = new List<int> ();
    private List<int> rolls2 = new List<int>();
    public int turn = 0;
    public int turn2 = 0;
    private PinSetter pinSetter;
	private Ball ball;
	private ScoreDisplay[] scoreDisplay;
   // private ScoreDisplay scoreDisplay2;

    // Use this for initialization
    void Start () {
		pinSetter = GameObject.FindObjectOfType<PinSetter> ();
		ball = GameObject.FindObjectOfType<Ball> ();
        scoreDisplay = new ScoreDisplay[2];
		scoreDisplay = GameObject.FindObjectsOfType<ScoreDisplay> ();
      //  scoreDisplay[1] = GameObject.FindObjectOfType<ScoreDisplay>();
    }
	
	public void Bowl (int pinFall) {
        if (turn == 0)
        {
            if (turn2 == 0)
            {
                if(pinFall==10)
                {
                    turn = 1;
                }else turn2 = 1;
         
            }
            else
            {
                turn = 1;
                turn2 = 0;
            }
            try
            {
                rolls.Add(pinFall);
                ball.Reset();
                //  turns++;
                pinSetter.PerformAction(ActionMasterOld.NextAction(rolls));
            }
            catch
            {
                if (turn == 18)
                {

                }
                Debug.LogWarning("Something went wrong in Bowl()");
            }

            try
            {
                scoreDisplay[0].FillRolls(rolls);
                scoreDisplay[0].FillFrames(ScoreMaster.ScoreCumulative(rolls));

            }
            catch
            {
                Debug.LogWarning("FillRollCard failed");
            }
        } else
        {
            if (turn2 == 0)
            {
                if (pinFall == 10)
                {
                    turn = 0;
                }
                else turn2 = 1;

            }
            else
            {
                turn = 0;
                turn2 = 0;
            }
            try
            {
                rolls2.Add(pinFall);
                ball.Reset();
                //  turns++;
                pinSetter.PerformAction(ActionMasterOld.NextAction(rolls2));
            }
            catch
            {
                if (turn == 18)
                {

                }
                Debug.LogWarning("Something went wrong in Bowl()");
            }

            try
            {
                scoreDisplay[1].FillRolls(rolls2);
                scoreDisplay[1].FillFrames(ScoreMaster.ScoreCumulative(rolls2));

            }
            catch
            {
                Debug.LogWarning("FillRollCard failed");
            }

        }
	}
}
