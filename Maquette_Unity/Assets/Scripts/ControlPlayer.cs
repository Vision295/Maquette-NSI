using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPlayer : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput; 
    public float speed = 0.1f;
    public float jumpHeight = 1.0f;
    private Rigidbody rigid;
    public float jumpH;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        jumpH = 5.0f;
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * verticalInput * speed);
        transform.Translate(Vector3.right * horizontalInput * speed);
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigid.AddForce(Vector3.up * jumpH, ForceMode.VelocityChange);
        }
    }
}
