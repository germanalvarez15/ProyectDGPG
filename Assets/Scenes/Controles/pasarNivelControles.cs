using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pasarNivelControles : MonoBehaviour {
	string controles;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void pasar(string controles){
		SceneManager.LoadScene(controles);
	}
}
