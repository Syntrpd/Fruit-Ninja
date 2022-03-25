using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    
    public float spawnBeginRange;
    public float spawnEndRange;
    public ManageCount mc;

    public GameObject[] objs;

    int size;
    float wait;
    bool flag;
    //float temp;
    // Start is called before the first frame update
    void Start()
    {
        wait = PlayerPrefs.GetFloat("InitDifficulty");
        flag = false;
        size = objs.Length;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //if (mc.score >= 1200)
            //wait = 0.7f;
        if (mc.score >= 2000)
            wait = 0.6f;
        if (flag == false)
        {
            StartCoroutine("pause");
        }
    }

    IEnumerator pause()
    {
        flag = true;
        float temp = Random.Range(-spawnBeginRange, spawnBeginRange);
        Debug.Log("I enter" + Time.time);
        if ((temp <= (-spawnEndRange)) || (temp >= spawnEndRange))
        {
            int pos = (int)(Random.Range(0, size));
            Instantiate(objs[pos], new Vector3(temp, 6.0f, 0), new Quaternion());
            Debug.Log("Spawned " + Time.time);
            yield return new WaitForSeconds(wait);
            Debug.Log("After wait2" + Time.time);;
        }
        flag = false;
    }
}
