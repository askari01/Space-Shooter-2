using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour {

	private Rigidbody rigid;
	public float speed;
	// Use this for initialization
	void Start () {
		rigid = GetComponent<Rigidbody> ();
		rigid.velocity = transform.forward * speed;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
