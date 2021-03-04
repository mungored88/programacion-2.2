using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class cargarAsync : MonoBehaviour
{
    public int nivelACargar;
    public string nivelACargarS;



    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
   
    void OnLevelWasLoaded(int level)
    {
        string active = SceneManager.GetActiveScene().name;
        if (active == "LoadingScene") return;

        try { nivelACargar = int.Parse(active.Split()[2]); }
        catch { }
        nivelACargar += 1;

    }
    IEnumerator LoadLevelAsync()
    {

        switch(nivelACargar){
            case 1:
                nivelACargarS = "01 Level 1";
                break;
            case 2:
                nivelACargarS = "02 Level 2";
                break;
            case 3:
                nivelACargarS = "03 Level 3";
                break;
            case 4:
                nivelACargarS = "04 BossLevel 4";
                break;
        }

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(nivelACargarS);
        asyncLoad.allowSceneActivation = true;
        yield return null;


        /*while(asyncLoad.progress < 0.9f)
        {
            yield return null;
        }

        while (true) { 
            if (Input.anyKeyDown)
            {
              asyncLoad.allowSceneActivation = true;
                break;
            }
            yield return null;

        }*/
    }

    public void cargarAsyncFunc()
    {
        StartCoroutine(LoadLevelAsync());
    }






}
