using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class DisplayCross : MonoBehaviour
{
    public GameObject cross;
    public float wait;
    public SceneWork sw;
    public AudioSource src;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator showingCross()
    {
        Instantiate(cross, new Vector3(0, 0, 0), new Quaternion(0, 0, 0, 0));
        GameObject.Find("FruitSpawner").SetActive(false);
        GameObject.Find("Ninja").SetActive(false);
        //Instantiate(cross, new Vector3(0, 0, 0), new Quaternion(0, 0, 0,0));
        yield return new WaitForSeconds(wait);
        sw.changeScene("Exit");
        
    }
    public void crossDisplay()
    {
        src.Play();
        StartCoroutine("showingCross");
    }
}
