using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alma4 : MonoBehaviour
{
  public PlayerControler2D player;

  

  public PuzzleAlmas Puzzle;

  

      void OnTriggerEnter2D(Collider2D obj){
        if(obj.tag=="Player"){
             
            Puzzle.TAlma4=true;
           
            gameObject.SetActive(false);
        }
    }
    
}
