using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SetDiff : MonoBehaviour
{
    public void difficulty(float val)
    {
        PlayerPrefs.SetFloat("InitDifficulty", val);
        SceneManager.LoadScene("MainScene");
    }
}
