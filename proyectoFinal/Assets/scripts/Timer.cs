using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {

    public float maxTime = 60.0f;

    private float countdown = 0.0f;

    void Start () {
        countdown = maxTime;
		
	}
	
	void Update () {
        countdown -= Time.deltaTime;
            if (countdown <= 0)
        {
            Coin.coinsCount = 0;
            SceneManager.LoadScene("escena2");

        }
    }
}
