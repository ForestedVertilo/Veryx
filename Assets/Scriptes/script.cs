using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class script : MonoBehaviour {

    public static int cherryCount = -1;
    public static bool isLose;
    public int NeedScores;
    public static bool Control;
    public UnityEngine.UI.Text scoresText;
    private Rigidbody2D _rigidbody;
    public Vector2 speed = new Vector2(1, 1);
    private Vector2 movement;
    private Animator _animator;
    public bool isGround;
    // Use this for initialization
    void Start () {
        _rigidbody = GetComponent<Rigidbody2D>();
       _animator = GetComponent<Animator>();
       Control = true;
       isLose = false;
       cherryCount = NeedScores;
	}
	
	// Update is called once per frame
	void Update () {
        float inputx = Input.GetAxis("Horizontal");
        
       movement = new Vector2(speed.x * inputx, _rigidbody.velocity.y);
       if(Control)
        Camera.main.transform.position = new Vector3(transform.position.x - Vector3.forward.x * 10,0,transform.position.z - Vector3.forward.z * 10);
       if (Input.GetAxis("Horizontal") != 0 && isGround)
           {
               _animator.SetBool("isWalking", true);
            }
        else _animator.SetBool(name: "isWalking", value: false);
        Fliper();
        scoresText.text = "Scores: " + cherryCount;
        _rigidbody.velocity = movement;
        
    }
    void Fliper()
    {
        if (Input.GetAxis("Horizontal") < 0)
        {
            GetComponent<SpriteRenderer>().flipX = true;
        }
        else if (Input.GetAxis("Horizontal") > 0)
        {
            GetComponent<SpriteRenderer>().flipX = false;
        }
    }
    private void OnCollisionStay2D(Collision2D collision)
    {  
    if (collision.gameObject.tag == "Platform" )

       {
           _animator.SetBool("isJump", false);
           isGround = true;
       }
    
   }
    private void OnTriggerEnter2D (Collider2D collider)
    { 
        if(collider.gameObject.tag == "spikes")
        {
            _animator.SetBool("isHurt", true);
            Control = false;
            
            _rigidbody.AddForce(new Vector2(0, 6f), ForceMode2D.Impulse);
            NewMethod();
            isLose = true;
            Destroy(collider);
            
        }
    }

    private static void NewMethod()
    {
        new WaitForSeconds(1);
    }

    private void FixedUpdate()
    {
        if (isGround && (Input.GetKey(KeyCode.W)))
        {
            
            _rigidbody.AddForce(new Vector2(0,1.5f), ForceMode2D.Impulse);
            _animator.SetBool("isJump", true);
            isGround = false;
            
        }
    }
}
