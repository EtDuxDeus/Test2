using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class CubeAveliableCoordinates<T>
{
    private T[] arr = new T[10];
        
        public T this[int i]
        {
        get { return arr[i]; }
        set { arr[i] = value; }
     }

}