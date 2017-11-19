using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cantidadPruebas : MonoBehaviour {

	// Use this for initialization
	public Text pruebas;
	public int acumulador=0;

	void Start () {
		pruebas = GetComponent<Text> ();
	
	}
	
	// Update is called once per frame
	void Update () {

		pruebas.text = acumulador.ToString();
		
	}
}
