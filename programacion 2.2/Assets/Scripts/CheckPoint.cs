using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CheckPoint : MonoBehaviour
{

    [SerializeField] public CheckPointOBJ lastCheck;

    private void Awake()
    {
        lastCheck = new CheckPointOBJ();
    }
    public CheckPointOBJ getLastCheckPoint()
    {
        Debug.Log(lastCheck.lastCheckPos);
        Debug.Log(lastCheck.lastCheckRot);
        return lastCheck;
    }

    public void setCheckPoint(Transform tran)
    {
        Debug.Log(tran.position);
        Debug.Log(tran.rotation);
        lastCheck.lastCheckPos = tran.position;
        lastCheck.lastCheckRot = tran.rotation;
    }
}
[Serializable]
public class CheckPointOBJ
{
    [SerializeField] public Vector3 lastCheckPos;
    [SerializeField] public Quaternion lastCheckRot;
}

