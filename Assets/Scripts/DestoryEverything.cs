using UnityEngine;
using System.Collections;

public class DestoryEverything : MonoBehaviour {

//	void onCollisionEnter(Collider other){
//		//Destroy (other.gameObject);
//		//Destroy (gameObject);
//		Destroy (other.gameObject);
//	}

	void onTriggerEnter (Collider other){
		//Destroy (other.gameObject);
		Destroy (other.gameObject);
	}

	// Use this for initialization
	void Start () {
		Debug.Log ("Hello");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
