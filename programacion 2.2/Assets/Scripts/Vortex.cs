using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Vortex : MonoBehaviour
{

    public string scene;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, 100 * Time.deltaTime, 0));
    }

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(scene);
        }
    }
}
