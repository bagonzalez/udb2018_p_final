using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cambioEsc3 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("hola we colision");
       
            SceneManager.LoadScene("escenaTres");
        
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("hola we colision");

        if (other.name == "Sack_b")
        {
            SceneManager.LoadScene("escenaTres");
        }
    }
}
