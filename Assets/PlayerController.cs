using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public GameObject fireBall;
	public GameObject fireBomb;
	//public Transform shotSpawn;

	private float nextFire;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButton ("Fire1") && Time.time > nextFire) {
			Instantiate (fireBall, Input.mousePosition);
			nextFire = Time.time + 0.25f;
		}
	}
}
