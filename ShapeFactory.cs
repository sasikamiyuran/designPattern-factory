namespace FactoryDesignPatterDemo
{
    public class ShapeFactory
    {
        public IShape getShape(string shapeTyep)
        {
            if (shapeTyep == null)
            {
                return null;
            }

            if (shapeTyep == "Rectangle")
            {
                return new Rectangle();
            }
            else if (shapeTyep == "Square")
            {
                return new Square();
            }
            else if (shapeTyep == "Circle")
            {
                return new Circle();
            }
            return null;
        }
    }
}
