using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoalsionButton : MonoBehaviour {

	public GameObject Plataforma;
	private float positionEnable;
	public float positionDisable;

	private bool _CDPlataforma;
	private float _TimePlataform;

	// Use this for initialization
	void Start () {
		positionEnable = Plataforma.transform.position.y;
		Plataforma.transform.Translate(0,positionDisable,0);
		
	}
	
	// Update is called once per frame
	void Update () {
		TimerComparation();

		if (_CDPlataforma)
		{
			float actualiposition = Plataforma.transform.position.y;
			if(actualiposition < positionEnable)
			{
				Plataforma.transform.Translate(0, 2, 0);
			}
		}
		else
		{
			float actualiposition = Plataforma.transform.position.y;
			if (actualiposition > positionDisable)
			{
				Plataforma.transform.Translate(0, -2, 0);
			}
		}
		
	}

	private void OnTriggerEnter(Collider other)
	{
		_CDPlataforma = true;
		_TimePlataform = Time.time + 10;
	}

	private void TimerComparation()
	{
		float timeNow = Time.time;
		if(timeNow >= _TimePlataform)
		{
			_CDPlataforma = false;
		}

	}
}
