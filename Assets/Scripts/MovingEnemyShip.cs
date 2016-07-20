using UnityEngine;
using System.Collections;
//nigga ahole
public class MovingEnemyShip : MonoBehaviour {

	private Rigidbody rigid;
	private AudioSource audioSource ;

	public float fireRate;
	private float nextFire = 0.5f;
	public float speed;

	public GameObject shot;
	public Transform shotCreation;

	// Use this for initialization
	void Start () {
		rigid = GetComponent<Rigidbody> ();
		audioSource = GetComponent<AudioSource >();
		rigid.velocity = Vector3.forward * speed;
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time > nextFire) {
			nextFire = Time.time + fireRate;
			Debug.Log (nextFire);
	
			GameObject clone = 
				Instantiate (shot, shotCreation.position, shotCreation.rotation) as GameObject;
			//Debug.Log (clone);
			audioSource.Play ();
			Destroy(clone, 2f);
			//Debug.Log ("i ma shooting");
		}
	}
}
