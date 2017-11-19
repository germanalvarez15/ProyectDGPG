using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class pasarNivel : MonoBehaviour {

	string shooterProyecto;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void pasar(string shooterProyecto){
		SceneManager.LoadScene(shooterProyecto);
	}
}
