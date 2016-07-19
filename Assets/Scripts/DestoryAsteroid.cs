using UnityEngine;
using System.Collections;

public class DestoryAsteroid : MonoBehaviour {

	public float lifetime;
	// Use this for initialization
	void Start () {
		Debug.Log (this.gameObject);
		Destroy (gameObject, lifetime);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
