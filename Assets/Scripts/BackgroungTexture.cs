using UnityEngine;
using System.Collections;

public class BackgroungTexture : MonoBehaviour {

	public Renderer rend;
	public float scrollSpeed = 0.1F;

	// Use this for initialization
	void Start () {
		rend = gameObject.GetComponent<Renderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		float offset = Time.time * scrollSpeed;
		rend.material.mainTextureOffset = new Vector2(0, offset);
	}
}
