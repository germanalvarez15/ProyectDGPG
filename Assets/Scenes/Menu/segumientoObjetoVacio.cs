using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class segumientoObjetoVacio : MonoBehaviour {

	public Transform jugador;
	UnityEngine.AI.NavMeshAgent nav;
	// Use this for initialization
	void Start () {
		nav = GetComponent<UnityEngine.AI.NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {
		nav.SetDestination(jugador.position);
	}
}
