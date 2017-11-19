using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class puntosNumeroDisponibles : MonoBehaviour {
	public float numero;
	public Text texto;
	// Use this for initialization
	void Start () {
		numero = 20f;
	}

	// Update is called once per frame
	void Update () {
		texto.text = numero.ToString ();
	}
}
