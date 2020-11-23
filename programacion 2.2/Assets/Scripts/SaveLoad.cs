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
        //Debug.Log(_path);
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
            Debug.Log(data.level);
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
        var data = new DataToSave();
        data.level = 1;


        StreamWriter file = File.CreateText(_path);
        string json = JsonUtility.ToJson(data, true);

        file.Write(json);
        file.Close();
    }
}
