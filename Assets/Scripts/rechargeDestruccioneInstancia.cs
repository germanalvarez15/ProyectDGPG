using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rechargeDestruccioneInstancia : MonoBehaviour {

	// Use this for initialization
	public int timer;
	public float cronometro;

	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		cronometro += Time.deltaTime;
		cronometro = 0;
		timer++;
		if (timer == 20) {
			gameObject.SetActive(true);
		}
	}
}
