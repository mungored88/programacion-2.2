using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key : MonoBehaviour
{
    [SerializeField] private KeyType keytype;
    public enum KeyType 
    {
        red,
        yellow,
        blue,
        green
    }
    public KeyType GetKeyType()
    {
        return keytype;
    }
}
