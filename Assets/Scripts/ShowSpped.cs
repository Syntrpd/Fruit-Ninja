using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShowSpped : MonoBehaviour
{
    public TextMeshProUGUI tmp;
    public ManageCount mc;

    string str= "Fruits will come faster now";
    //bool disp1;
    bool disp2;
    // Start is called before the first frame update
    void Start()
    {
        tmp.text = "";
        str = "Fruits will come faster now";
        //disp1 = false;
        disp2 = false;
    }

    // Update is called once per frame
    void Update()
    {
        /*if ((mc.score>=1200)&&(disp1 == false))
        {
            disp1 = true;
            StartCoroutine("stopShow");
        }*/

        if ((mc.score>=2000)&&(disp2 == false))
        {
            disp2 = true;
            StartCoroutine("stopShow");
        }
    }

    IEnumerator stopShow()
    {
        tmp.text = str;
        yield return new WaitForSeconds(1);
        tmp.text = "";

    }
}
