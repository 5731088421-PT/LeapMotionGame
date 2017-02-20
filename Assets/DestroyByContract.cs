using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContract : MonoBehaviour {
	
	void OnTriggerEnter(Collider other) 
	{
		Destroy(gameObject);
		Destroy(other.gameObject);

	}
}
