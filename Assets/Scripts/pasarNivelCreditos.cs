using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class pasarNivelCreditos : MonoBehaviour {

	// Use this for initialization
	string creditos;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void pasarACreditos(string creditos){
		SceneManager.LoadScene (creditos);
	}
}
