using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poder2 : MonoBehaviour
{
  public PlayerControler2D player;
  public static bool dashPause = false;

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
             
             player.poder2=true;
             dashMenu.SetActive(true);
           Time.timeScale = 0f;
           dashPause = true;
           
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
