using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

[Serializable]
public class SaveLoad : MonoBehaviour
{
   
    public string _path;
    private string _SAVEPATH = "/Save.json";
    void Start()
    {
        _path = Application.streamingAssetsPath + _SAVEPATH;
        //_path = Application.persistentDataPath + _SAVEPATH;
        DontDestroyOnLoad(this.gameObject);
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.F2))
        {
            SaveFile();
        }
        if (Input.GetKeyDown(KeyCode.F3))
        {
            DataToSave data = LoadFile();
        }

    }

    public DataToSave LoadFile()
    {
        if (!File.Exists(_path))
        {
            SaveFile();
        }

        string data = File.ReadAllText(_path);
        return JsonUtility.FromJson<DataToSave>(data);
    }

    public void SaveFile()
    {
        //Defaults
        CheckPointOBJ checkpoint = new CheckPointOBJ();
        int lifes = 5;
        Llaves llaves = new Llaves();

        var data = new DataToSave();

        try
        {
            GameObject player = GameObject.FindGameObjectWithTag("Player");
            PlayerController p_cont = player.GetComponent<PlayerController>();
            checkpoint = p_cont.checkpoint.lastCheck;
            lifes = p_cont.vidas;
        }
        finally
        {
            data.lifes = lifes;
            data.checkPoint = checkpoint;
            data.llaves = llaves;
        }

      
        StreamWriter file = File.CreateText(_path);
        string json = JsonUtility.ToJson(data, true);

        file.Write(json);
        file.Close();
    }
}
