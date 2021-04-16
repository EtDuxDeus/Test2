using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IEnumerableTestScript : MonoBehaviour
{
    Shape[] shapeArray = new Shape[4];
        
    private void Awake()
    {
        shapeArray[0] = new Shape("Square", 5);
        shapeArray[1] = new Shape("Circle", 10);
        shapeArray[2] = new Shape("Triangle", 7);
        shapeArray[3] = new Shape("Rhomb", 12);
    }
    // Start is called before the first frame update
    void Start()
    {
        foreach(Shape s in shapeArray)
        {
            Debug.Log(s.shapeName + " " + s.area);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
