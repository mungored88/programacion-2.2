using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAttack : MonoBehaviour
{
    public Transform player;
    public float distanceToFollow;
    public float distanceToFire;
    public float distanceToPunch;
    public float shootSpeed = 2f;
    public int DamageAttack;
    public float rotationSpeed = 100f;

    public GameObject fireball;
    public Transform fireballOrigin;


    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Disparar());
    }

    void Update()
    {
        Quaternion rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(player.position - transform.position), rotationSpeed * Time.deltaTime);
        rotation.z = 0;
        rotation.x = 0;
        this.transform.rotation = rotation;

    }

    IEnumerator Disparar()
    {
        while (true) { 
        yield return new WaitForSeconds(shootSpeed);

        GameObject bulletInstance = Instantiate(fireball);
        bulletInstance.transform.forward = fireballOrigin.right;
        bulletInstance.transform.position = fireballOrigin.position;
        }
    }
}
