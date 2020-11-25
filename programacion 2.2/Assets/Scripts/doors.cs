using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doors : MonoBehaviour
{
    [SerializeField] private key.KeyType keytype;
    public AudioSource doorsound;
    public key.KeyType GetKeyType()
    {
        return keytype;
    }
    public void OpenDoor()
    {
        doorsound.Play(0);
        StartCoroutine(abrirPuerta());
    }

    public IEnumerator abrirPuerta()
    {
        yield return new WaitForSeconds(0.5f);
        gameObject.SetActive(false);
    }
}
