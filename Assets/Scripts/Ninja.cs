using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ninja : MonoBehaviour
{
    public GameObject[] stance;
    public float wait;
    int i;
    int size;
    bool flag;
    // Start is called before the first frame update
    void Start()
    {
        i = 0;
        size = stance.Length;
        stance[0].SetActive(true);
        flag = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (flag == true)
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                LeftAttack();
            }

            if (Input.GetKeyDown(KeyCode.D))
            {
                RightAttack();
            }

        }
    }

    IEnumerator attack()
    {
        flag = false;
        stance[0].SetActive(false);
        stance[i].SetActive(true);
        yield return new WaitForSeconds(wait);
        stance[i].SetActive(false);
        stance[0].SetActive(true);
        flag = true;
    }

    public void LeftAttack()
    {
        i = 1;
        StartCoroutine("attack");
    }

    public void RightAttack()
    {
        i = 2;
        StartCoroutine("attack");
    }
}
