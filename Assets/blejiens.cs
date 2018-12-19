using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blejiens : MonoBehaviour
{


    public GameObject objekts;

    void Start()
    {
        StartCoroutine(instObj());
    }

    IEnumerator instObj()
    {
        while (true)
        {
            Instantiate(objekts, new Vector3(Random.Range(-0.001f, 0.002f), 0f, Random.Range(-0.002f, 0.002f)), Quaternion.identity);
            yield return new WaitForSeconds(5);
        }
    }
}