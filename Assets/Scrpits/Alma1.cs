﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alma1 : MonoBehaviour
{
  public PlayerControler2D player;
  public Mov Animalito;

  

      void OnTriggerEnter2D(Collider2D obj){
        if(obj.tag=="Player"){
             
             player.TAlma1=true;
           
            gameObject.SetActive(false);
        }
    }
    
}

