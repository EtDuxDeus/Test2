using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coroutine : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        IEnumerator num;
        num = TestCoroutine();
        StartCoroutine(num);   
    }

    IEnumerator TestCoroutine()
    {
        Debug.Log("Start is done");
        yield return null;
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
