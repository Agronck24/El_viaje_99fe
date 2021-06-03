using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kodama2Tuto : MonoBehaviour
{
    public PlayerControler2D player;
    private Animator anim;

    public GameObject text;
    private void Start()
    {
        {
            anim = GetComponent<Animator>();

        }
    }

    void OnTriggerEnter2D(Collider2D obj)
    {
        if (obj.tag == "Player")
        {

            anim.SetBool("RunTuto", true);
            text.SetActive(true);
            Destroy(gameObject, 7f);

        }
        else
        {
            anim.SetBool("RunTuto", false);

        }

    }


}
