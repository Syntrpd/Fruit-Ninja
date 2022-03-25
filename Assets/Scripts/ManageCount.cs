using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ManageCount : MonoBehaviour
{
    public int count;
    public int score;
    public string[] captions;

    public TextMeshProUGUI tmp;
    public TextMeshProUGUI scoreDisp;
    public TextMeshProUGUI captionDisp;

    public bool captn;
    // Start is called before the first frame update
    void Start()
    {
        tmp.text = "";
        tmp.text =""+ count;
        score = 0;
        scoreDisp.text = "";
        captn = true;
        captionDisp.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        tmp.text =""+count;
        if (count <= 0)
            GameObject.Find("NonCutHit").GetComponent<DisplayCross>().crossDisplay();

        if ((((score % 2000) == 0) && (score != 0)) && (captn == true))
        {
            scoreDisp.text = "";
            captn = false;
            StartCoroutine("ShowCaption");
        }
        else if(captn==true)
            scoreDisp.text = "" + score;
    }

    IEnumerator ShowCaption()
    {
        int pos = Random.Range(0, captions.Length);
        captionDisp.text = captions[pos];
        yield return new WaitForSeconds(1.5f);
        captn = true;
        captionDisp.text = "";
    }

    private void OnDisable()
    {
        PlayerPrefs.SetInt("score", score);
    }
}
