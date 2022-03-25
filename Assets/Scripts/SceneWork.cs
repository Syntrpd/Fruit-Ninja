using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneWork : MonoBehaviour
{
    public void changeScene(string changeTo)
    {
        Debug.Log("CLick");
        Time.timeScale = 1;
        SceneManager.LoadScene(changeTo);
    }

    public void quit()
    {
        Application.Quit();
    }

    public void resume(string changeTo)
    {
        Debug.Log("CLick");
        Time.timeScale = 0;
        SceneManager.LoadScene(changeTo,LoadSceneMode.Additive);
    }

    public void close(string scene) 
    {
        Time.timeScale = 1;
        SceneManager.UnloadSceneAsync(scene);
    }
}
