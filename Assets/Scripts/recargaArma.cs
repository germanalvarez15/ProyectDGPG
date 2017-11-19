using UnityEngine;
using System.Collections;

public class recargaArma : MonoBehaviour {

	// Use this for initialization
//	public GameObject recarga1;
//	public GameObject recarga2;
//	public GameObject recarga3;
	disparo sumaTiro;
	void Start () {
		sumaTiro = GameObject.Find ("Gun").GetComponent<disparo> ();
//		recarga1 = GetComponent<BoxCollider> ();
//		recarga2 = GetComponent<BoxCollider> ();
//		recarga3 = GetComponent<BoxCollider> ();

	}
	
	// Update is called once per frame
	void Update () {
		if (sumaTiro.d.numero >= 40) {
			sumaTiro.d.numero = 40;
			GetComponent<Collider> ().enabled = false;
		} else {
			GetComponent<Collider> ().enabled = true;
		}
	}
	 void OnCollisionEnter(Collision recarga){
		if (recarga.gameObject.tag == "Player") {
			Debug.Log ("Recarga hecha");
			Destroy (gameObject);
			sumaTiro.d.numero += 20;
	
		
		
		}
	
	
	}
}
