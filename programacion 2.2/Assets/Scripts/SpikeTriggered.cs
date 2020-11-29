using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeTriggered : Spike
{
    public Animator anim;

    protected override void OnTriggerEnter(Collider other)
    {
        anim.SetTrigger("EnterPlayer");
    }
}
