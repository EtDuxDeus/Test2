using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.TestingScripts.EnumTest
{
    class ShapeEnum: IEnumerator
    {
        public Shape[] shapes;

        int pos = -1;

        public ShapeEnum(Shape[] array)
        {
            shapes = array;
        }

        public bool MoveNext()
        {
            pos++;
            return (pos < shapes.Length);
        }

        public void Reset()
        {
            pos = -1;
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public Shape Current
        {
            get
            {
                try
                {
                    return shapes[pos];
                }
                catch(IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }
}
