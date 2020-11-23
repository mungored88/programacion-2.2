using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class DataToSave 
{
    public int level;
    public Checkpoint checkPoint;
    public int lifes;
    public Data2 data;
}

[Serializable]
public class Data2
{
    public int a;
    public float b;
}

public class Checkpoint
{
    public float X;
    public float Y;
    public float Z;
}



//var time = DateTime.Now;
//print(time);
//var json = JsonUtility.ToJson((JsonDateTime)time);
//print(json);
//DateTime timeFromJson = JsonUtility.FromJson<JsonDateTime>(json);
//print(timeFromJson);