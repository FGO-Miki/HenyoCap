using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackTo : MonoBehaviour
{
    public void GoBackToMainMenu()
    {
        SceneManager.LoadSceneAsync("MainMenu");
    }

    public void GoBackToStorySelect()
    {
        SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene());
        SceneManager.LoadSceneAsync("StorySelect");
    }

}
