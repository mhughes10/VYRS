using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Camera cam;
    public float check;
    public cameraFallowplayer cFPlayer;
    [SerializeField] private bool facing;
     public bool isGrounded;
    public float jumpHeight = 20;
    public Rigidbody2D player;
    public float walkSpeed;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    public Transform groundCheck;
    [SerializeField] private bool isMoving;
    public float size;
    public float sizeYOff;
    public float smoothTime = .3f;
    public float yVelocity = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        isMoving = false;
        facing = false;

        sizeYOff = 4 + --size;
    }

    private void FixedUpdate()
    {

        cam = Camera.main;

       
        
            cam.GetComponent<Camera>().orthographicSize = Mathf.SmoothDamp(cam.GetComponent<Camera>().orthographicSize, Mathf.Clamp( --size, -10f, -.7f), ref yVelocity,smoothTime );

            size = -transform.position.y ;


       


        cam.GetComponent<cameraFallowplayer>().yOff = Mathf.Clamp(--size, 3, -.7f);
       

        



        //cFPlayer.zOff = transform.position.z + cFPlayer.zOff;

        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
    }

    // Update is called once per frame
    void Update()
    {
        isMoving = false;
        playerMovement();
        PlayerFacing();
        Anim();

        transform.localScale = transform.localScale;
        //if (isGrounded == false & walkSpeed != 1)
        //{
        //    walkSpeed -= 1f;
        // }

        // if (isGrounded == true)
        // {
        //    walkSpeed = 30;
        //}
    }
    
    void playerMovement()
    {
        if (Input.GetKey(KeyCode.D))
        {
            player.AddForce(transform.right * walkSpeed);
            isMoving = true;
        }

        if (Input.GetKey(KeyCode.A))
        {
            player.AddForce(transform.right * -walkSpeed);
            isMoving = true;
        }

        if (Input.GetKeyDown(KeyCode.W) && isGrounded)
        {
            player.AddForce(transform.up * jumpHeight);
        }

    }

   void PlayerFacing()
    {
        if (Input.GetKey(KeyCode.A))
        {
            facing = true;
        }

        if (Input.GetKey(KeyCode.D))
        {
            facing = false;
        }

        if (facing == false)
        {
            transform.localScale = new Vector3(0.1157221f, 0.1157221f, 0.1157221f);
        }

        if (facing == true)
        {
            transform.localScale = new Vector3(-0.1157221f, 0.1157221f, 0.1157221f);
        }

    }

    void Anim()
    {
        if (isMoving == true)
        {
            GetComponent<Animator>().Play("demoWalkAnim");
        }

        if (isMoving == false)
        {
            GetComponent<Animator>().Play("idleAnim");
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Pages"))
        {
            Destroy(other.gameObject);
        }
    }
}
            

