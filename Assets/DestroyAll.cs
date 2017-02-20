using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAll : MonoBehaviour {

	private GameObject[] list;

	// Use this for initialization
	void Start () {
		StartCoroutine(Example());

	}

	IEnumerator Example() {
		
		yield return new WaitForSeconds(1);
		list = GameObject.FindGameObjectsWithTag ("Enemy");
		StartCoroutine(Example());
		for (int i = 0; i < list.Length; i++) {
			Destroy (list [i]);

			yield return new WaitForSeconds(0.1f);
		}
	}
	// Update is called once per frame
	void Update () {
		



	}
}
