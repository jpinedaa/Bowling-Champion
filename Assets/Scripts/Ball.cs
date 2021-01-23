using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Ball : MonoBehaviour {
	public Vector3 launchVeclocity;
	public bool inPlay = false;
    public GameObject turn;
	private Vector3 ballStartPos;
	private Rigidbody rigidBody;
	private AudioSource audioSource;
    public Text turnText;
    public int turnValue = 0;

	// Use this for initialization
	void Start () {
        turn = GameObject.Find("CurrentTurn");
        turnText = turn.GetComponent<Text>();
        turnValue = 0;
		rigidBody = GetComponent<Rigidbody>();
		rigidBody.useGravity = false;
		ballStartPos = transform.position;
	}
	
	public void Launch (Vector3 velocity)
	{
        turnValue++;
        turnText.text = "Turn: " + turnValue;
		inPlay = true;
		rigidBody.useGravity = true;
		rigidBody.velocity = velocity;

		audioSource = GetComponent<AudioSource> ();
		audioSource.Play ();
	}

	public void Reset () {
		inPlay = false;
		transform.position = ballStartPos;
		transform.rotation = Quaternion.identity;
		rigidBody.velocity = Vector3.zero;
		rigidBody.angularVelocity = Vector3.zero;
		rigidBody.useGravity = false;
	}
}
