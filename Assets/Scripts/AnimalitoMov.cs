using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AnimalitoMov : MonoBehaviour
{
  public float  moveSpeed = 5f;

  public Rigidbody2D rb;

  public bool arbol;

  public bool posession; 

  Vector2 movement;

  public GameObject Fantasma;

  public bool pose;


     private Animator anim;

     private float horizontal = 0.0f;
     private float vertical = 0.0f;

     public bool ground;


  void Start()
  {
    anim=GetComponent<Animator>();  
  }
    
    void Update()
    {
        if(Input.GetKey(KeyCode.E) && pose==true){ 
            Debug.Log("dada");
            posession=true;
                }
        
        if(posession==true){
        movement.x = Input.GetAxisRaw("Horizontal");
      


        if(arbol==false){movement.y = 0;
        
        
        }else{movement.y = Input.GetAxisRaw("Vertical");}    
        }else{
            
        }


        if(posession==true && pose==true){
            
            Fantasma.SetActive(false);
            }
       
       
        if(Input.GetKey(KeyCode.F)){
            posession=false;
            Fantasma.SetActive(true);
        }

         if(Input.GetButton("Horizontal")&& ground==true && posession==true)
        {
           
           
             anim.SetBool("WALK", true);
           
        }else{
            anim.SetBool("WALK", false);
        }

        if(arbol==false && ground==false){
            anim.SetBool("fly", true);
        }else{
            anim.SetBool("fly", false);
        }
      horizontal = movement.x > 0.01f ? movement.x : movement.x <-0.01f ? 1 : 0;
      vertical = movement.y > 0.01f ? movement.y : movement.y <-0.01f ? 1 : 0;

      if(movement.x < -0.01f)
      {
          gameObject.transform.localScale = new Vector3 (0.5f,0.5f,0.5f);
      }
      if(movement.x > -0.01f){
          gameObject.transform.localScale = new Vector3 (-0.5f,0.5f,0.5f);
      }

    }

    void FixedUpdate()
    {
      rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);  
    }

   
    void OnTriggerEnter2D(Collider2D obj){
        if(obj.tag=="Arbol"){
           
             arbol=true;
             
            }

            if(obj.tag=="Player"){
        pose=true;
                }

      
    }

     void OnTriggerStay2D(Collider2D obj){
        if(obj.tag=="Arbol"){
             movement.y = Input.GetAxisRaw("Vertical");
             arbol=true;
              
              
        if(obj.tag=="Player"){
        pose=true;
       
                }
            }

        }
             
    
    

    void OnTriggerExit2D(Collider2D obj){
        if(obj.tag=="Arbol"){
             
             arbol=false;
             
           
            
        }

         if(obj.tag=="Player"){
        pose=false;
       
                }
            

    
    }

     void OnCollisionStay2D(Collision2D col)
    {
        if(col.collider.tag=="suelo"){
            ground=true;
            
        }
    }

     void OnCollisionEnter2D(Collision2D col)
    {
        if(col.collider.tag=="suelo"){
            ground=true;
           
            
        }
    }

     void OnCollisionExit2D(Collision2D col)
    {
        if(col.collider.tag=="suelo"){
            ground=false;
           
            
        }
    }
     

    
}
