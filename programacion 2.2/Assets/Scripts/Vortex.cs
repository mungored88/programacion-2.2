using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Vortex : MonoBehaviour
{

    public string scene;
    public AudioSource vortex;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, 100 * Time.deltaTime, 0));
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("00 menu");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        vortex.Play(0);
        if (other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(scene);
        }
    }
}
