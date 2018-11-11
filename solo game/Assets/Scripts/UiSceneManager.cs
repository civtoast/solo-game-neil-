using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UiSceneManager : MonoBehaviour
{
    /// <summary>
    /// this switches scenes when you press a button
    /// </summary>
    public Button buttonChangeScene;
    public Button quit;
    public string sceneName;

    // Use this for initialization
    void Start()
    {
        
        buttonChangeScene.onClick.AddListener(ChangeSceneToSettings);
        quit.onClick.AddListener(Leveapk);

        
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("MainMenu");
            print("switch");
        }
    }

    void ChangeSceneToSettings()
    {
        print("Load new UI scene ");
        SceneManager.LoadScene(sceneName);
    }
    void Leveapk()
    {
        Application.Quit();
    }
}

  
