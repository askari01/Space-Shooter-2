using UnityEngine;
using System.Collections;

public class RandomRotator : MonoBehaviour {
	
	private Rigidbody rigid;
	public float tumble;

	// Use this for initialization
	void Start () {
		rigid = GetComponent<Rigidbody> ();
		rigid.angularVelocity = Random.insideUnitSphere * tumble;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
