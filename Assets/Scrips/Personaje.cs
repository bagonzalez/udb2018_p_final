using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Personaje : MonoBehaviour {

	private int _lives;
	private int _mana;
	public Transform SpawnPosition;

	//Canvas
	public RectTransform BarMana;
	public Text Vidas;
	public Text ShowPlataform;
	public Text ShowRock;
	public Text ManaPorcent;

	//canvas Alert

	//Shot
	public GameObject bulletPrefab;
	public Transform bulletSpawn;
	private bool _CDBullet;
	private float TimeCDBullet;

	//BaseRock
	public GameObject RockBasePrefabs;
	public Transform RockBaseSpawn;
	private bool _CDRockBase;
	private float _TimeRockBase;

	// Use this for initialization
	void Start () {
		_lives = 3;
		_mana = 70;

		_CDBullet = true;
		_CDRockBase = true;
	}
	
	// Update is called once per frame
	void Update () {
		TimerComparation();	
		
		if(_lives < 0){
			SceneManager.LoadScene("MainMenu");
		}

		Vidas.text = _lives.ToString();
		Vector2 manaStatus = new Vector2(_mana, 85);
		BarMana.sizeDelta = manaStatus;
		ManaPorcent.text = _mana.ToString();

		//Show status
		if (_mana < 10)
		{
			ShowPlataform.color = new Color32(244, 244, 244, 50);
		}
		if (_mana < 5)
		{
			ShowRock.color = new Color32(244, 244, 244, 50);
		}

		//Shot
		if (Input.GetMouseButton(0))
		{
			int total = _mana - 5;
			if (_CDBullet && total >= 0)
			{
				Fire();
			}
		}

		// "BaseRock"
		if (Input.GetKey(KeyCode.LeftControl))
		{
			int total = _mana - 10;
			if (_CDRockBase && total >= 0)
			{				
				GameObject rockBase = (GameObject)Instantiate(
					RockBasePrefabs,
					RockBaseSpawn.position,
					Quaternion.identity);
				_TimeRockBase = Time.time + 1;
				//TimeCDBaseRock = Time.time + 1;
				_CDRockBase = false;				
				_mana -= 10;

				Destroy(rockBase, 10.0f);
			}
		}

	}

	private void OnTriggerEnter(Collider other)
	{
		if(other.name == "zoneMana")
		{
			_mana = 100;			
		}

		if(other.name == "EnemyRock(Clone)C")
		{
			
			transform.position = SpawnPosition.position;
			transform.rotation = SpawnPosition.rotation;
			_lives -= 1;
			_mana = 70;
		}

		if (other.name == "aguaColider")
		{
			
			transform.position = SpawnPosition.position;
			transform.rotation = SpawnPosition.rotation;
			_lives -= 1;
			_mana = 70;
		}


	}

	void Fire()
	{
		Vector3 position = new Vector3(0, 0, 1);
		// Create the Rock from the Rock Prefab

		GameObject bullet = (GameObject)Instantiate(
		bulletPrefab,
		bulletSpawn.position,
		bulletSpawn.rotation);

		// Add velocity to the bullet
		bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 50;

		// Destroy the bullet after 2 seconds
		Destroy(bullet, 5.0f);

		//CDContoller
		TimeCDBullet = Time.time + 1;
		_CDBullet = false;
		_mana -= 5;
	}

	private void TimerComparation()
	{
		float timeNow = Time.time;
		Debug.Log("Time" + timeNow);

		if (timeNow >= TimeCDBullet)
		{
			_CDBullet = true;
			ShowRock.color = new Color(244f, 244f, 244f, 255f);
		}

		if (timeNow >= _TimeRockBase)
		{
			_CDRockBase = true;
			ShowPlataform.color = new Color(244f, 244f, 244f, 255f);
		}
	}
}
