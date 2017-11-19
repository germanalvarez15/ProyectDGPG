using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class destruccionAlColisionarMaletin : MonoBehaviour {

	// Use this for initialization
	Image maletinlogohud;
	public Color nombreColor; 
	void Start () {
		maletinlogohud = GameObject.Find ("MaletinLogo").GetComponent<Image> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision destruyoMaletin){
		if (destruyoMaletin.gameObject.tag == "Player") {
			Destroy (gameObject);
			maletinlogohud.color = nombreColor;
		}
	}
}
