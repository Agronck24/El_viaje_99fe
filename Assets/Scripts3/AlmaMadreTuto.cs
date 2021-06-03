using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlmaMadreTuto : MonoBehaviour
{
    public PlayerControler2D player;


    void OnTriggerEnter2D(Collider2D obj)
    {
        if (obj.tag == "Player")
        {
            Destroy(gameObject, 0.3f);
        }
    }
}
