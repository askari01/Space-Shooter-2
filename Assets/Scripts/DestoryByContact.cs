using UnityEngine;
using System.Collections;

public class DestoryByContact : MonoBehaviour {

	//private Rigidbody rigid;
	public GameObject explosion;
	public GameObject playerExplosion;
	public int scoreValue;
	public GameController gameController;
	public GameObject gameControllerObject;

	void OnTriggerEnter(Collider other) {
		Debug.Log (other);
		//GameObject asteroid =
		Instantiate (explosion, transform.position, transform.rotation); //as GameObject;
		GameObject player =
		Instantiate (playerExplosion, other.transform.position, other.transform.rotation) as GameObject;
		Destroy (other.gameObject);
		Destroy (gameObject);
		//Destroy (player, 1f);
		gameController.addScore (scoreValue);
	}

	// Use this for initialization
	void Start () {
		
		//Debug.Log ("Hello");
		//Rigidbody rigid = GetComponent<Rigidbody> ();
		GameObject gameControllerObject = GameObject.FindGameObjectWithTag("GameController");
		if (gameControllerObject != null) {
			gameController = gameControllerObject.GetComponent<GameController> ();
		} else {
			Debug.Log ("can not find game controller");
		}

	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log ("update");

	}
}
