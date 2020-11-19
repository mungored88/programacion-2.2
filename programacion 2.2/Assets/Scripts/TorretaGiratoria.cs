using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorretaGiratoria : Torreta
{

    public Transform character;
    public float rotationSpeed = 10f;

    void Start()
    {
        Shoot();
        character = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    void Update()
    {
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(character.position - transform.position), rotationSpeed * Time.deltaTime);
    }


}
