using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombaLoca : Enemy
{
    private SphereCollider collider;
    private Animator anim;

    [SerializeField] private float distanciaParaCorrer;
    [SerializeField] private float distanciaParaExplotar;
    [SerializeField] private float runSpeed;

    private bool _exploto = false;


    void Awake()
    {
        collider = GetComponent<SphereCollider>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        Vector3 lookAtPos = Player.transform.position;
        transform.LookAt(lookAtPos);

        distanceToPlayer = Vector3.Distance(transform.position, Player.transform.position);

        if (distanceToPlayer <= distanciaParaCorrer && !_exploto)
        {
            correrHaciaPlayer();
            anim.SetBool("walk", true);
        }
        else
        {
            anim.SetBool("walk", false);
        }
        
        if(distanceToPlayer <= distanciaParaExplotar && !_exploto)
        {
            anim.SetBool("walk", false);
            _exploto = true;
            anim.SetTrigger("attack01");

            StartCoroutine(hacerDañoEnSegundos(1));
            
        }

    }



    void correrHaciaPlayer()
    {
        transform.position += transform.forward * runSpeed * Time.deltaTime;
    }
}
