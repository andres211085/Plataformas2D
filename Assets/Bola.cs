using UnityEngine;
using System.Collections;

public class Bola : MonoBehaviour {

	Rigidbody2D rb2d;

	float jump=1.5f;


	void Start () {
	
		rb2d = GetComponent<Rigidbody2D>();


	}
	

	void Update () {
	


	}

	void FixedUpdate(){
		if(Input.GetButton("Jump")){	
			Debug.Log("Jump");
			rb2d.AddForce (new Vector2(0,jump));
			//Rigidbody2D.AddForce (new Vector2(0,jump));
		}
	}
}
