using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishScene : MonoBehaviour {

	public string token;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter(Collider other)
	{
		if(other.name == "FPSController")
		{			
			StaticClass.CrossSceneInformation = token;
			SceneManager.LoadScene("MainMenu");
		}
	}
}
