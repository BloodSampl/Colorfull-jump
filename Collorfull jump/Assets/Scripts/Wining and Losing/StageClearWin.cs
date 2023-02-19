using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageClearWin : MonoBehaviour
{
    [SerializeField] ColorManager colorManager;

    private void Update()
    {
        StageClear();
    }

    private void StageClear()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        Scene sceneToCompare = SceneManager.GetSceneByName("Level2");
        if (colorManager.GetColorList().Count == 0 && currentScene != sceneToCompare)
        {
            SceneManager.LoadScene("Level 1 Score Screen");
        }
        else if (colorManager.GetColorList().Count == 0 && currentScene == sceneToCompare)
        {
            SceneManager.LoadScene("GameCleared");
        }
    }
}
