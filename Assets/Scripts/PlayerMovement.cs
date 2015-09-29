using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float jumpForce;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKeyDown ("space")) {
			GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpForce));
			//transform.Translate(new Vector3 (0, 5, 0));
		}
	}
}
