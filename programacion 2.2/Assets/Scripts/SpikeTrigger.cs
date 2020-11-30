using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeTrigger : Spike
{

    public Animator anim;

    private void OnTriggerEnter(Collider other)
    {
        anim.SetTrigger("EnterPlayer");
     }

}
