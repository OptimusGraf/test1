namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
    interface IFigureArea
    {
        public double GetArea();
    }
    class Circle : IFigureArea
    {
        double radious;
        Circle(double r)
        {
            radious = r;
        }
        public double GetArea()
        {
            return Math.PI * radious * radious;
        }
    }
    class Triangle : IFigureArea
    {
        double a; //стороны треугольника
        double b;
        double c;
        Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public double GetArea()
        {
            double p = a + b + c;
            p /= 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
        public bool IsTriangleRight()
        {
            return (a * a + b * b == c * c) || (a * a + c * c == b * b) || (c * c + b * b == a * a);
        }
    }
}
