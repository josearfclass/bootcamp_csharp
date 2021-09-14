namespace IteratorPattern
{
    public class Shape
    {
        public int Id { set; get; }
        public string Name { set; get; }

        public Shape(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public override string ToString()
        {
            return "ID: "+this.Id+" Shape: "+this.Name;
        }
    }
}