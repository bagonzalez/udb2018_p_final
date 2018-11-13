using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class personaje : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Cube (7)")
        {
            SceneManager.LoadScene("escenaDos");
        }
        if(other.name == "Sack_b")
        {
            SceneManager.LoadScene("escenaTres");
        }
        if (other.name == "Cylinder")
        {
            SceneManager.LoadScene("fin");
        }
    }
}
