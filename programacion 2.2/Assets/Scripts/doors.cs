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
        
        gameObject.SetActive(false);
    }
}
