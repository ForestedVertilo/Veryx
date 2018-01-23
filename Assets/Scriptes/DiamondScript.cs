using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondScript : MonoBehaviour {
private Animator _animator;
	// Use this for initialization
	void Start () {
		
       _animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	 private void OnTriggerEnter2D (Collider2D collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            _animator.SetBool("isLost", true);
            script.cherryCount-=2;
			 NewMethod();
            Destroy(this);
        }

    }
	 private static void NewMethod()
    {
        new WaitForSeconds(1);
    }
}
