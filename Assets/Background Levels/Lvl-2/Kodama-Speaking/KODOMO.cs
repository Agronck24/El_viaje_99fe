using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KODOMO : MonoBehaviour
{
  public PlayerControler2D player;
  private Animator anim;

  public GameObject text;

     private  void Start()
    {
        {
            anim=GetComponent<Animator>();
          
        }
    } 

      void OnTriggerEnter2D(Collider2D obj){
        if(obj.tag=="Player"){
             
              anim.SetBool("SPIK", true);    
              text.SetActive(true); 
            
        }else{
             anim.SetBool("SPIK", false);
        }
    }
    





}