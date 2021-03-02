using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activacionDeTanke : MonoBehaviour
{

    public Camera camera;
    protected virtual void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("BorrarPlayer");//Player.GetComponent<PlayerController>().recibirDaño();
            GetComponent<TankController>().enabled = true;
            GetComponent<ShootWithTank>().enabled = true;
        }
    }
}
