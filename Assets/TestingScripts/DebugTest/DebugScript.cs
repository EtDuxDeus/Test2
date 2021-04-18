using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugScript : MonoBehaviour
{
    // Start is called before the first frame update

    void Start()
    {
        int[] mas = new int[10];
        for(int i = 0; i < mas.Length; i++)
        {
            mas[i] = Random.Range(-100, 100);
            Debug.Log(mas[i]);
            if(i == 5)
            {
                Debug.Log("Stopped");
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
