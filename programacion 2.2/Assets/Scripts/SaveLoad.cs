﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using UnityEngine.SceneManagement;


[Serializable]
public class SaveLoad : MonoBehaviour
{
   
    public string _path;
    private string _SAVEPATH = "/Save.json";

    private int nivel;
    void Awake()
    {
        //_path = Application.streamingAssetsPath + _SAVEPATH;
        _path = Application.persistentDataPath + _SAVEPATH;
        //Debug.Log(Application.persistentDataPath);
    }

    private void Start()
    {
        SaveFile();
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

        try
        {
            String active = SceneManager.GetActiveScene().name;
            nivel = int.Parse(active.Split()[2]);
        }
        catch
        {
            nivel = 1;
        }
        finally
        {
            data.nivelesDesbloqueados = nivel;
        }

        DataToSave dataLoaded = LoadFile();
        //no guarda si es nivel menor ya que reemplazaria
        //los niveles desbloqueados
        if(dataLoaded.nivelesDesbloqueados > nivel) return;

 


        StreamWriter file = File.CreateText(_path);
        string json = JsonUtility.ToJson(data, true);

        file.Write(json);
        file.Close();
    }
}
