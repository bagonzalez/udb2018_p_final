using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controlador1 : MonoBehaviour
{

    // Use this for initialization
    public void CambiarEscena(string nombre)
    {
        print("Cambiando a la escena " + nombre);
        SceneManager.LoadScene("SampleScene");
    }

}

