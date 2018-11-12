using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoShoot : MonoBehaviour {

	public GameObject Shotprefabs;
	public float TimeToShoot;
	private bool _cdShoot;

	private float _TimeShoot;

	// Use this for initialization
	void Start () {
		_cdShoot = true;
		
	}
	
	// Update is called once per frame
	void Update () {
		TimerComparation();
		if (_cdShoot)
		{
			GameObject bullet = (GameObject)Instantiate(
		Shotprefabs,
		transform.position,
		transform.rotation);

			bullet.transform.localScale += new Vector3(3f, 3f, 3f);


			// Add velocity to the bullet
			bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 100;

			// Destroy the bullet after 2 seconds
			Destroy(bullet, 3.0f);

			_TimeShoot = Time.time + TimeToShoot;
			_cdShoot = false;
		}
		
	}

	private void TimerComparation()
	{
		float timeNow = Time.time;
		if(timeNow >= _TimeShoot){
			_cdShoot = true;
		}
	}

	}
