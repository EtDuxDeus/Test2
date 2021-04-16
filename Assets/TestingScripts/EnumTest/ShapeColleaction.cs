/*using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ShapeColleaction : IEnumerable
{
    private Shape[] shapes;
    public ShapeColleaction(Shape[] shapeArray)
    {
        shapes = new Shape[shapeArray.Length];
        for (int i = 0; i < shapeArray.Length; i++)
        {
            shapes[i] = shapeArray[i];
        }
    }
    public IEnumerator GetEnumerator()
    {
        return shapes.GetEnumerator();
    }
}
*/