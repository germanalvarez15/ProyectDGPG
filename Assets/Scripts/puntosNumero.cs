using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class puntosNumero : MonoBehaviour {

	public float numero;
	public Text texto;
	// Use this for initialization
	void Start () {
		numero = 40f;
	}
	
	// Update is called once per frame
	void Update () {
		texto.text = numero.ToString ();
	}
}
