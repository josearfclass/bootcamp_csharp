using System;

namespace IteratorPattern
{
    public class ShapeIterator : Iterator<Shape>
    {
        private Shape[] shapes;
        public int position = 0;

        public ShapeIterator(Shape[] shape)
        {
            this.shapes  =  shape;
        }

        public bool HasNext()
        {
            return (position) < this.shapes.Length;
        }
        
        public Shape Next()
        {
            Shape shap = this.shapes[position];
            position++;
            return shap;
        }
        
        public void Remove()
        {
            if (this.shapes[this.position-1] != null)
            {
                this.shapes[this.position - 1] = null;
            }
            
            Shape[] shapes_tmp = new Shape[this.shapes.Length - 1];
            int index = 0;
            for (int i = 0; i < shapes_tmp.Length; i++)
            {
                if (this.shapes[i] != null)
                {
                    shapes_tmp[index] = this.shapes[i];
                    index++;
                }
            }

            this.shapes = shapes_tmp;
            this.position--;
        }
    }
}