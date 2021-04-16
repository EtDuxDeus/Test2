using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndexerScript : MonoBehaviour
{
    CubeAveliableCoordinates<float[]> coordinatesCollection = new CubeAveliableCoordinates<float[]>();
    private void Awake()
    { 
        for(int i = 0; i < 10; i++)
        {
            float[] temp = { Random.Range(-10, 10), Random.Range(-10, 10), Random.Range(-10, 10) };
            coordinatesCollection[i] = temp;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
           for(int i = 0; i <10; i++)
        {
           float[] temp = coordinatesCollection[i];
           Debug.Log(temp[0] + " " + temp[1]+" " + temp[2]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
