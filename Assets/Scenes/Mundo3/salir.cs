using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class salir : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "sierra")
        {
            SceneManager.LoadScene("JuegoTerminado");
        }
    }
}
