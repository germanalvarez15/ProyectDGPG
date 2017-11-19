using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShootableBox : MonoBehaviour {

	//The box's current health point total
	public Animator animPer;
	public int currentHealth = 3;
	Slider vidas;
	UnityEngine.AI.NavMeshAgent desact;


	void Start(){
		animPer = GetComponent<Animator> ();
		desact= GetComponent<UnityEngine.AI.NavMeshAgent>();
		vidas = GameObject.Find ("BarraVidas").GetComponent<Slider> ();

	}

	void Update(){
		if (vidas.value <= 0) {
			SceneManager.LoadScene ("perdiste");
		} 
	}

	public void Damage(int damageAmount)
	{
		//subtract damage amount when Damage function is called
		currentHealth -= damageAmount;

		//Check if health has fallen below zero
		if (currentHealth <= 0) 
		{
			//if health has fallen below zero, deactivate it 
//			gameObject.SetActive (false);
			animPer.SetBool("muerte",true);
			Destroy(gameObject,5f);
			desact.Stop ();

		}
	}
	void OnCollisionEnter(Collision activoAtaque){
		if (activoAtaque.gameObject.tag == "Player") {
			animPer.SetBool ("ataque", true);
			vidas.value -= 0.03f;

		} 
		else {
			animPer.SetBool ("ataque", false);
			animPer.SetBool ("caminar", true);
		}


	}

}
