using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlmaMadre : MonoBehaviour
{
  public PlayerControler2D player;

  public GameObject Puerta;

  

      void OnTriggerEnter2D(Collider2D obj){
        if(obj.tag=="Player"){
            Puerta.SetActive(false);
            Debug.Log("hola");
            Destroy(gameObject);

            gameObject.SetActive(false);
        }
    }
    
}
