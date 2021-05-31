using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    // Start is called before the first frame update
public bool Cambio;
    public void changeToScene(int changeToScene){
        SceneManager.LoadScene(1);
    }
 
   void OnTriggerEnter2D(Collider2D obj){
        if(obj.tag=="Player"){
            Debug.Log("hola");
            Cambio=true;
        }
    }
   
}
