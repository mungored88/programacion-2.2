using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{

    protected GameObject Player;
    [SerializeField] protected float distanceToPlayer;
    [SerializeField] protected float attackDistance;


    private void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }



    public IEnumerator hacerDaño()
    {

        yield return new WaitForSeconds(1);
        if (distanceToPlayer <= attackDistance)
        {
            Player.GetComponent<PlayerController>().recibirDaño();
        }
        yield return null;
    }

}
