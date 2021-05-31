using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SETAANIM : MonoBehaviour
{
  public PlayerControler2D player;
  private Animator anim;

     private  void Start()
    {
        {
            anim=GetComponent<Animator>();
          
        }
    }

  

      void OnTriggerEnter2D(Collider2D obj){
        if(obj.tag=="Player"){
             
              anim.SetBool("Sjump", true);     
            
        }else{
             anim.SetBool("Sjump", false);
        }
    }
    
}