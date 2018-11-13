using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {

    public static int coinsCount = 0; //

	
	void Start () {
        Coin.coinsCount++; //aumenta de 1 en 1 las monedas que se vayan agregando al terreno		
	}
	
	
	void Update () {
		
	}

    private void OnTriggerEnter(Collider collider)
    {
        if(collider.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }


    private void OnDestroy()
    {
        Coin.coinsCount--; //disminuirá cada vez que encuentre una moneda

        if(Coin.coinsCount <= 0)
        {
            Debug.Log("HAS GANADO :D");
        }
    }
}
