using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pasarAlMenu : MonoBehaviour {

	string pasaMenu;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void irAMenu(string pasaMenu){
		SceneManager.LoadScene (pasaMenu);
	}
}
