using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterJump : MonoBehaviour {
    public bool grounded = false;
	private Rigidbody rb;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (Input.GetButtonDown ("Jump") && !grounded) {
			rb.linearVelocity = new Vector3(0F,5F,0F);
            grounded = true;
		}
	}

    private void OnCollisionStay(Collision collision) {
        grounded = false;
    }
}
