using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReferenceTest : MonoBehaviour
{

    // Start is called before the first frame update
    void Awake()
    {
    }
    void Start()
    {
        int a = 5;
        Debug.Log(a);
        Calc(ref a);
        Debug.Log(a);
        int i;
        OutCalc(out i);
        Debug.Log(i);
    }

    public void Calc(ref int a)
    {
        a += 10;
    }
    
    public void OutCalc(out int i)
    {
        i = 77;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
