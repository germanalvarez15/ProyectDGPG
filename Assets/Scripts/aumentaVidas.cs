using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class aumentaVidas : MonoBehaviour {

	// Use this for initialization
	Slider lasvidas;
	void Start () {
		lasvidas = GameObject.Find ("BarraVidas").GetComponent<Slider> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter (Collision aumento){
		if (aumento.gameObject.tag == "Player") {
			lasvidas.value += 0.09f;
			Destroy (gameObject);
		}
		
	}
}
