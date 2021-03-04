using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cargarAsyncObj : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        cargarAsync obj = GameObject.FindWithTag("CargaASYNC").GetComponent<cargarAsync>();

        obj.cargarAsyncFunc();

    }


}
