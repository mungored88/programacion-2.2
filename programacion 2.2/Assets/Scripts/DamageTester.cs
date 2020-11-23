using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageTester : MonoBehaviour
{
    public GameObject damageTesterObj;
    public IEnumerator damageTesterNumerator() {
        damageTesterObj.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        damageTesterObj.SetActive(false);
        yield break;
    }

    internal void daño()
    {
        StartCoroutine(damageTesterNumerator());
    }
}
