using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtributesTest : MonoBehaviour
{
    [HideInInspector]
    public float hiden;

    [Range(1,10)]
    public float scale;
    Vector3 temp;
    // Start is called before the first frame update
    private void Awake()
    {
        temp = transform.localScale;
        scale = temp.x;
        
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        temp.x = scale;
        temp.y = scale;
        temp.z = scale;
        transform.localScale = temp;
    }
}
