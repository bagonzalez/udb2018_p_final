using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controlador : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void cambiarEscena(string nombre)
    {
        print("pasar a la siguiente escena" + nombre);
        SceneManager.LoadScene(nombre);
    }

    public void Salir()
    {
        print("salir del juego");
        Application.Quit();
    }

}
