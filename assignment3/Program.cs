namespace _2025_3_6_assignment_3
{

    public interface Shape 
    {
        bool Judgment();
        double GetArea();
    }

    public class Rectangle:Shape
    {
        private  double width;
        private double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
       public bool Judgment() {
            if (width != height) return true;
            return false;
        }
       public double  GetArea()
        {  if(Judgment())
            return width * height;
            return -1;
        }
    }

    public class Square:Shape
    {
        private double width;
        private double height;
        public Square(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
        public bool Judgment()
        {
            if (width != height) return false;
            return true;
        }
        public double GetArea()
        {  if(Judgment())
            return width * height;
            return -1;
        }
    }

    public class Triangle : Shape
    {
        private double side1;
        private double side2;
        private double side3;
       public Triangle(double side1, double side2, double side3)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }
    
        public bool Judgment()
        {
            if (side1 + side2 <= side3) return false;
            if(side1+side3<= side2) return false;
            if (side2 + side3 <= side1) return false;
            return true;
        }
        public double GetArea()
        { if (Judgment())
            {
                double perimeter = (side1 + side2 + side3) / 2;
                // 计算面积
                double area = Math.Sqrt(perimeter * (perimeter - side1) * (perimeter - side2) * (perimeter - side3));
                return area;
            }

            return -1;
        }

    }

    public class ShapeFactory 
    {
      private Random random= new Random();  
        public List<Shape> CreateShape(int number)
        {   List<Shape> shapeList = new List<Shape>();
            for (int i = 0; i < number; i++)
            {
                int type = random.Next(1, 4);
                switch (type)
                {
                    case 1:
                        {
                            double length = random.NextDouble() * 10;
                            double width = random.NextDouble() * 10;
                            shapeList.Add(new Rectangle(length, width));
                            break;
                        }
                    case 2:
                        {
                            double side = random.NextDouble() * 10;
                            shapeList.Add(new Square(side, side));
                            break;
                        }
                    case 3:
                        {
                            double side1 = random.NextDouble() * 10;
                            double side2 = random.NextDouble() * 10;
                            double side3 = random.NextDouble() * 10;
                            shapeList.Add(new Triangle(side1, side2, side3));
                            break;

                        }
                    default:
                        {
                            Console.WriteLine("NO this figure");
                            break;
                        }
                }
            }
            return shapeList;

        }

    }



    internal class Program
    {
        static void Main(string[] args)
        {
        ShapeFactory factory = new ShapeFactory();
        List<Shape> shapes = factory.CreateShape(10);
        for(int i=0;i<10;i++)
            {
                Console.WriteLine(shapes[i].GetArea().ToString());
            }
        }
    }
}