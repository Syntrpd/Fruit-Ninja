using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Countdown : MonoBehaviour
{
    public TextMeshProUGUI tmp;

    int t;

    public void Awake()
    {
        t = 3;
        Time.timeScale = 0;
        StartCoroutine("count");
        
    }

    IEnumerator count()
    {
        while (t > 0)
        {
            tmp.text = t + "";
            yield return new WaitForSecondsRealtime(1);
            t--;
        }

        tmp.text = "PLAY";
        yield return new WaitForSecondsRealtime(1);
        tmp.text = "";
        Time.timeScale = 1;
    }
}
