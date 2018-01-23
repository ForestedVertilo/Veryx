using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgMove : MonoBehaviour {
 private Rigidbody2D _rigidbody;
 public Vector2 speed = new Vector2(2, 2);
    private Vector2 movement;
	// Use this for initialization
	void Start () {
		
		_rigidbody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
	float inputx = Input.GetAxis("Horizontal");
	if(script.Control)
       movement = new Vector2(speed.x * inputx, _rigidbody.velocity.y);
	else movement = new Vector2(0,0);
    _rigidbody.velocity = movement;
	}
}
