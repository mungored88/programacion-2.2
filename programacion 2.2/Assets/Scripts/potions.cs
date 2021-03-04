using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class potions : MonoBehaviour
{
    public abstract void DarStats(Collider Player);
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag != "Player") return;
        DarStats(other);
        Destroy(this.gameObject);
    }
}
