using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camswitch : MonoBehaviour
{
   public bool cam;
     private Animator anim;

     public PlayerControler2D playercam;
 private  void Start()
    {
        {
            anim=GetComponent<Animator>();
          
        }
    }
    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && playercam.cam==true){
            
            anim.SetBool("AAA", true);
        }
        if(Input.GetKeyDown(KeyCode.F) && playercam.cam==true){
            
            anim.SetBool("AAA", false);
        }
    }
}
