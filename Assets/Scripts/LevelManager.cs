using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public void LoadLevel(string name)
    {
        Debug.Log("Level load requested for: " + name);
        SceneManager.LoadScene(name);
    }

    public void QuitRequest()
    {
        Debug.Log("Quit requested");
        /*  - Caveats for Application.Quit()
            - gs works great if building for PC and Console
            - does not work on web build
            - application should not quit itself on mobile
        */
        Application.Quit();
    }
}
