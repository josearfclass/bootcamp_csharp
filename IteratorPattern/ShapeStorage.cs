namespace IteratorPattern
{
    public class ShapeStorage
    {
        private Shape[] shapes = new Shape[5];
        private int index = 0;
        
        public void AddShape(string shape)
        {
            shapes[index] = new Shape(index, shape);
            index++;
        }

        public Shape[] GetShapes()
        {
            return shapes;
        }
    }
}