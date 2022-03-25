using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NonCut : MonoBehaviour
{
    public GameObject go;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= -7.0f)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (gameObject.tag == "Bomb")
        {
            Instantiate(go, transform.position, new Quaternion());
            Destroy(gameObject);
        }
        GameObject.Find("NonCutHit").GetComponent<DisplayCross>().crossDisplay();
    }
}
