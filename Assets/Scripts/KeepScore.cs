using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KeepScore : MonoBehaviour
{
    public TextMeshProUGUI tmp;
    public int score;

    // Start is called before the first frame update
    void Start()
    {
        tmp.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        tmp.text = score+"";
    }

    private void OnEnable()
    {
        score = PlayerPrefs.GetInt("score");
    }
}
