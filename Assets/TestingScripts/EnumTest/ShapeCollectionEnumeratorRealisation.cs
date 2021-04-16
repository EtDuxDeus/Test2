using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.TestingScripts.EnumTest
{
    class ShapeCollectionEnumeratorRealisation:IEnumerable
    {
        private Shape[] shapes;

        public ShapeCollectionEnumeratorRealisation(Shape[] shapeArray)
        {
            shapes = new Shape[ shapeArray.Length];
            for(int i =0; i < shapeArray.Length; i++)
            {
                shapes[i] = shapeArray[i];
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }

        public ShapeEnum GetEnumerator()
        {
            return new ShapeEnum(shapes);
        }
    }
}
