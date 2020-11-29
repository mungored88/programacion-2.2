using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Transform bulletTransform;
    public float speed = 10f;

    private void Start()
    {
        bulletTransform = this.GetComponent<Transform>();
    }

    void FixedUpdate()
    {
        bulletTransform.position += bulletTransform.right * -speed * Time.deltaTime;
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<PlayerController>().recibirDaño();
        }
        Destroy(this.gameObject);
    }

}
