using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarPoder1 : MonoBehaviour
{
   public static bool dashPause = false;
    public PlayerControler2D kitsune;

     public GameObject dashMenu;

       void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(dashPause)
            {
                Resume();
            }
        }
    }

 

     void OnTriggerEnter2D(Collider2D obj){
        if(obj.tag=="Player"){
           dashMenu.SetActive(true);
           Time.timeScale = 0f;
           dashPause = true;
          
           kitsune.poder1=true;
           gameObject.SetActive(false);
            

        }
     }  
      public void Resume ()
    {
        dashMenu.SetActive(false);
        Time.timeScale = 1f;
        dashPause = false;
    }


     
     
}
