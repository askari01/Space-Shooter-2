using UnityEngine;
using System.Collections;

public class MovingEnemyShip : MonoBehaviour {

	private Rigidbody rigid;
	public float fireRate;
	private float nextFire = 0.5f;
	public float speed;

	public GameObject shot;
	public Transform shotSpawn;

	// Use this for initialization
	void Start () {
		rigid = GetComponent<Rigidbody> ();
		rigid.velocity = transform.forward * speed;
	}
	
	// Update is called once per frame
	void Update () {
		nextFire = Time.time + fireRate;

		GameObject clone = 
			Instantiate (shot, shotSpawn.position, shotSpawn.rotation) as GameObject;
		//audioSource.Play ();
		Destroy(clone, 1f);
	}
}
