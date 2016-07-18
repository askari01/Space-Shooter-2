using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	private Rigidbody rigid;
	public float speed;
	public float tilt;
	public float resistance;

	public GameObject shot;
	public Transform shotSpawn;

	public float fireRate;
	private float nextFire = 0.5f;

	public Boundry bound;

	void Start (){
		rigid = GetComponent<Rigidbody> ();
	}

	void Update (){
		if (Input.GetButton("Fire1") && Time.time > nextFire) {
			nextFire = Time.time + fireRate;
			GameObject clone = 
			Instantiate (shot, shotSpawn.position, shotSpawn.rotation) as GameObject;
			Destroy(clone, 1f);
		}
	}

	void FixedUpdate (){
		// Getting axis
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		//
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		Debug.Log (movement);
		rigid.velocity = movement * speed;

		rigid.position = new Vector3 (
			Mathf.Clamp(rigid.position.x, bound.xMin, bound.xMax),
			0.0f,
			Mathf.Clamp(rigid.position.z, bound.zMin, bound.zMax)
		);

		// there is no friction on space - yawar bhai
		rigid.rotation = Quaternion.Euler (new Vector3 (0.0f , 0.0f, rigid.velocity.x * -tilt));
	}
}

[System.Serializable]
public class Boundry {
	public float xMin;
	public float xMax;
	public float zMin;
	public float zMax;
}
 