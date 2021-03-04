using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speedPot : potions
{
    public int spd;
    public override void DarStats(Collider other)
    {
       // other.gameObject.GetComponent<PlayerController>().GetSpeed(this.spd);

    }
}
