using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawn : MonoBehaviour {

    [SerializeField]

    private Transform player;

    [SerializeField]
    private Transform respawnPoint;

    private void OnTriggerEnter(Collider other)
    {
        player.transform.position = respawnPoint.transform.position;
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
