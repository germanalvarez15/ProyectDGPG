using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class destruccionAlColisionarLibro : MonoBehaviour {

	// Use this for initialization
	Image librologohud;
	public Color nombreColor; 
	void Start () {
		librologohud = GameObject.Find ("LibroLogo").GetComponent<Image> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision destruyoLibro){
		if (destruyoLibro.gameObject.tag == "Player") {
			Destroy (gameObject);
			librologohud.color = nombreColor;
		}
	}
}
