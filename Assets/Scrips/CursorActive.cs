using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CursorActive : MonoBehaviour {

	public Button Ok;
	public GameObject alert;

	// Use this for initialization
	void Start () {
		Cursor.visible = true;
		Ok.onClick.AddListener(Destruir);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Destruir()
	{
		alert.SetActive(false);
		Cursor.visible = false;
	}
}
