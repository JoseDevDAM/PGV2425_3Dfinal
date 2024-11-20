using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{

    public float speed = 5f;

    private Rigidbody rb;

    public float playerSpeed;
    public float jumpForce;

    public bool onGround;
    public bool jump;




    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");

        float moveVertical = Input.GetAxis("Vertical");
        
        Vector3 movement = new Vector3(moveHorizontal * speed, rb.velocity.y, moveVertical*speed);  
        
        rb.velocity = movement;


        jump = Input.GetKeyDown(KeyCode.Space);

        if (jump && onGround)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            onGround = false;
        }
    
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            onGround = true;
        }
    }
    


}
