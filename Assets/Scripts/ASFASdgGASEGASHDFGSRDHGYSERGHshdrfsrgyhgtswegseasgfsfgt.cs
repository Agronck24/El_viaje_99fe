using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ASFASdgGASEGASHDFGSRDHGYSERGHshdrfsrgyhgtswegseasgfsfgt : MonoBehaviour
{

    public float moveSpeed;

    public Rigidbody2D rb;

    public bool arbol;

    private Vector2 moveDirection;

    private float moveY;

    private float moveX;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ProcessInputs();
    }

    void FixedUpdate()
    {
        Move();
    }


    void ProcessInputs()
    {
         moveX = Input.GetAxisRaw("Horizontal");
        
        moveY = Input.GetAxisRaw("Vertical");
        
         
        moveDirection = new Vector2(moveX, moveY);
    }



     private void Move()
    {
        rb.velocity = new Vector2 (moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);
    }

    void OnTriggerStay2D(Collider2D obj){
        if(obj.tag=="Arbol"){
             
             arbol=true;
             rb.gravityScale=10;
           
            
        
    
    }else{
        arbol=false;
        rb.gravityScale=40;
    }
     }

    void OnTriggerExit2D(Collider2D obj){
        if(obj.tag=="Arbol"){
             moveY = Input.GetAxisRaw("Vertical");
             arbol=false;
           
            
        }
    
    }

     void OnCollisionStay2D(Collision2D col)
    {
        if(col.collider.tag=="suelo"){
            rb.gravityScale=10;
           
        }
    }

     void OnCollisionEnter2D(Collision2D col)
    {
        if(col.collider.tag=="suelo"){
            
        }
    }
     
}
