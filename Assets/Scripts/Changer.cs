using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Changer : MonoBehaviour
{
    public GameObject[] go;
    public float time;
    public int scr;
    int i;
    int size;
    // Start is called before the first frame update
    void Start()
    {
        i = 0;
    }

    // Update is called once per frame
    void Update()
    {
        size = go.Length;
        if (i < size)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                go[i].SetActive(false);
                i++;
                StartCoroutine("chng");
                go[i].SetActive(true);
            }
        }

        if (transform.position.y <= -7)
        {
            Destroy(gameObject);
            if(i==0)
                GameObject.Find("CountManager").GetComponent<ManageCount>().count--;
        }
        
    }

    IEnumerator chng()
    {
        go[i].SetActive(true);
        yield return new WaitForSeconds(time);
        go[i].SetActive(false);
        i=3;
        go[i].SetActive(true);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject.Find("CountManager").GetComponent<ManageCount>().score += scr;
        go[i].SetActive(false);
        if (transform.position.x < 0)
            i = 2;
        else
            i = 1;
        StartCoroutine("chng");
        go[i].SetActive(true);
    }
}
