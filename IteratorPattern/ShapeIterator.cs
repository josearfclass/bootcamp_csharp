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
            return (position + 1) < this.shapes.Length;
        }
        
        public Shape Next()
        {
            Shape shap = this.shapes[position];
            position++;
            return shap;
        }
        
        public void Remove()
        {
            shapes[position] = new Shape(0, "");
            position--;
        }
    }
}