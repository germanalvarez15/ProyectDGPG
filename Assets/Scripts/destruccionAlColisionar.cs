using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class destruccionAlColisionar : MonoBehaviour {

	// Use this for initialization
	Image walkietalkielogohud;
	public Color nombreColor; 
	void Start () {
		walkietalkielogohud = GameObject.Find ("WalkieTalkieLogo").GetComponent<Image> ();
	}

	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision destruyo){
		if (destruyo.gameObject.tag == "Player") {
			Destroy (gameObject);
			walkietalkielogohud.color = nombreColor;


		}
	}
}
