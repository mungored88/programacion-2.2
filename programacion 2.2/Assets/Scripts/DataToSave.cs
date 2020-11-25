using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class DataToSave 
{
    public CheckPointOBJ checkPoint;
    public int lifes;
    public Llaves llaves;
}

[Serializable]
public class Llaves
{
    public int roja = 0;
    public int azul = 0;
    public int verde = 0;
    public int amarilla = 0;
}
