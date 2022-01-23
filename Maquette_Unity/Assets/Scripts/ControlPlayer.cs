using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPlayer : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput; 
    public float speed = 0.1f;
    private Rigidbody rigid;
    private float jumpHeight;
    public bool touchGround;
    private bool jumpInput;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        jumpHeight = 5.0f;
    }


    void PreUpdate()
    {
        jumpInput = Input.GetKeyDown(KeyCode.Space);
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        if (Input.GetKeyDown(KeyCode.Space) && touchGround)
        {
            rigid.AddForce(Vector3.up * jumpHeight, ForceMode.VelocityChange);
            touchGround = false;
        }
        transform.Translate(Vector3.forward * verticalInput * speed);
        transform.Translate(Vector3.right * horizontalInput * speed);       
    }

    private void OnCollisionExit(Collision other)
    {
        touchGround = false;
    }
    private void OnCollisionStay(Collision collision)
    {
        touchGround = true;
    }
}
