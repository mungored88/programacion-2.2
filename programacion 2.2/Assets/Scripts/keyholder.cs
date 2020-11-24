using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyholder : MonoBehaviour
{
    private List<key.KeyType> keyList;
    private void Awake()
    {
        keyList = new List<key.KeyType>();
    }
    public void AddKey(key.KeyType keyType)
    {
        //Debug.Log("agarro llave " + keyType);
        keyList.Add(keyType);
    }
    public void removeKey(key.KeyType key)
    {
        keyList.Remove(key);
    }
    public bool ContainKey(key.KeyType keytype)
    {
        return keyList.Contains(keytype);
    }
    private void OnTriggerEnter(Collider collider)
    {
        key key = collider.GetComponent<key>();
        if(key!=null)
        {
            AddKey(key.GetKeyType());
            Destroy(key.gameObject);
        }
        doors keyDoor = collider.GetComponent<doors>();
        if (keyDoor!=null)
        {
            if(ContainKey(keyDoor.GetKeyType()))
            {
                removeKey(keyDoor.GetKeyType());
                keyDoor.OpenDoor();
            }
        }
    }
}
