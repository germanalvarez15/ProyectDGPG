using UnityEngine;
using System.Collections;

public class disparo : MonoBehaviour {

	// Use this for initialization
	public puntosNumero d;
	public puntosNumeroDisponibles dis;
	public bool desactivoDisparo = true;
	RaycastShootComplete fueraDisparo;

	void Start () {
		d = GameObject.Find ("BalasRecarga").GetComponent<puntosNumero> ();
		dis = GameObject.Find ("BalasDisponibles").GetComponent<puntosNumeroDisponibles> ();
		fueraDisparo = GameObject.Find ("Gun").GetComponent<RaycastShootComplete> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		
		if (Input.GetButtonDown ("Fire1")) {


			if (desactivoDisparo == true) {
				dis.numero -= 1;
				if (dis.numero <= 0) {
					dis.numero += 20;
					d.numero -= 20;

				}
			}
			if ((dis.numero <= 20) && (d.numero == -20)) {
				dis.numero = 0.0f;
				d.numero = 0.0f;
				desactivoDisparo = false;
				fueraDisparo.enabled = false;
			} else {
				desactivoDisparo = true;
				fueraDisparo.enabled = true;
			}
				

//			if (desactivoDisparo == true) {
//				if (dis.numero <= 0) {
//					d.numero -= 20;
//					dis.numero += 20;
//				}
//				if ((d.numero == 20) && (dis.numero == 20)) {
//					dis.numero += 20;
//					d.numero -= 20;
//
//				}
//			}

		}
	}
}
//			if ((d.numero == 0) && (dis.numero == 0) && (desactivoDisparo == true)) {
//					dis.numero = 0;
//					d.numero = 0;
//				desactivoDisparo = false;
//			}


