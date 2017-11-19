using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class personajeScript : MonoBehaviour {

	// Use this for initialization
	Text pedirAyuda;
//	Text aceptaPrueba;
	public int ganar = 0;
	void Start () {
		pedirAyuda = GameObject.Find ("Ayuda").GetComponent<Text> ();
//		aceptaPrueba = GameObject.Find ("Prueba").GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (ganar == 3) {
			pedirAyuda.enabled = true;

//			SceneManager.LoadScene ("ganaste");
		}
	}

	void OnCollisionEnter(Collision sumaPruebas){
		if (sumaPruebas.gameObject.tag == "prueba") {
			ganar += 1;
		}

	}


	void OnTriggerStay(Collider ayudas){
		if((ayudas.gameObject.tag == "tab")&&(ganar == 3) && (Input.GetKeyDown( KeyCode.Tab))){
			SceneManager.LoadScene ("ganaste");
		}
	}


}
