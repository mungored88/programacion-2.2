using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : Enemy
{
    public Animator anim;
    private void OnTriggerEnter(Collider other)
    {
        anim.SetTrigger("EnterPlayer");
        if (other.gameObject.tag == "Player")
        {
            StartCoroutine(hacerDaño());
        }
    }
}

