using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class mainMenu : MonoBehaviour {
    
	// Use this for initialization
	void Start () {
		
	}
	public void LoadLv1()
    { 
        Application.LoadLevel(1);
        
    }
    public void LoadLv2()
    {
        Application.LoadLevel(2);

    }
    public void LoadLv3()
    {
        Application.LoadLevel(3);

    }
    public void LoadLv4()
    {
        Application.LoadLevel(4);

    }
    public void LoadLv5()
    {
        Application.LoadLevel(5);

    }
    public void LoadLv6()
    {
        Application.LoadLevel(6);

    }

    public void LoadExit()
    {
        Application.Quit();

    }
    // Update is called once per frame
    void Update () {
		
	}
}
