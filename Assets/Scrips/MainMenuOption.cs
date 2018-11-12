using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuOption : MonoBehaviour {

	private string token;
	public GameObject nivel2;
	public GameObject nivel3;

	// Use this for initialization
	void Start () {
		 token = StaticClass.CrossSceneInformation;
		Cursor.visible = true;
	}
	
	// Update is called once per frame
	void Update () {
		if(token == "AA" || token == "A")
		{
			nivel2.SetActive(true);
		}

		if(token == "AA")
		{
			nivel3.SetActive(true);
		}
	}

	public void Nivel1()
	{
		SceneManager.LoadScene("Scene1");
	}

	public void Nivel2()
	{
		SceneManager.LoadScene("Scene2");
	}

	public void Nivel3()
	{
		SceneManager.LoadScene("Scene3");
	}

}
