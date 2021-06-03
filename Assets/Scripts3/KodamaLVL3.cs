using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KodamaLVL3 : MonoBehaviour
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

            anim.SetBool("SpeakLVL3", true);
            text.SetActive(true);
            Destroy(gameObject, 10);

        }
        else
        {
            anim.SetBool("SpeakLVL3", false);
        }
    }
}
