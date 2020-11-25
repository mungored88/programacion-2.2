using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : Enemy
{
    public Transform bulletTransform;
    public float speed = 10f;

    private void Awake()
    {
        bulletTransform = this.GetComponent<Transform>();

    }

    void Update()
    {
        bulletTransform.position += bulletTransform.right * -speed * Time.deltaTime;
    }

}
