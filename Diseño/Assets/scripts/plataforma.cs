using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plataforma : MonoBehaviour {

    public GameObject[] local;
    public int destinofinal = 0;
    public float velocidad = 10;
    public bool invertido;
    public bool reiniciar;

    int localactual = 0;
    bool invertir = false;

	// Use this for initialization
	void Start () {
        if(destinofinal < local.Length)
        {
            localactual = destinofinal;
        }
        else
        {
            localactual = 0;
        }
        if(invertido == true)
        {
            invertir = !invertir;
        }
		
	}
	
	// Update is called once per frame
	void Update () {
        if(invertir == false)
        {
            if(Vector3.Distance(transform.position,local[localactual].transform.position) < 0.1f)
            {
                if(localactual < local.Length -1)
                {
                    localactual++;
                }
                else
                {
                    if(reiniciar == true)
                    {
                        localactual = 0;
                    }
                    else
                    {
                        invertir = true;
                    }
                }
            }
            transform.position = Vector3.MoveTowards(transform.position, local[localactual].transform.position, velocidad*Time.deltaTime);
        }
        else
        {
            if (Vector3.Distance(transform.position, local[localactual].transform.position) < 0.1f)
            {
                if (localactual > 0)
                {
                    localactual--;
                }
                else
                {
                    if (reiniciar == true)
                    {
                        localactual = local.Length -1;
                    }
                    else
                    {
                        invertir = false;
                    }
                }
            }
            transform.position = Vector3.MoveTowards(transform.position, local[localactual].transform.position, velocidad * Time.deltaTime);

        }
    }
		
	}

