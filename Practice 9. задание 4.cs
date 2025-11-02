using System;

class Circle
{

    private double radius;

    public double Radius

    {

        get { return radius; }
        set

        {
            if (value > 0)
                radius = value;
            else

            {
                Console.WriteLine("Ошибка: радиус должен быть больше 0.");
                radius = 0;

            }
        }
    }

    public Circle(double radius)

    {

        Radius = radius;

    }

    public void GetArea()

    {

        double area = Math.PI * radius * radius;
        Console.WriteLine($"Площадь круга: {area:F2}");

    }
}

class Program
{
    static void Main(string[] args)
    {

        Circle circle1 = new Circle(5);
        circle1.GetArea();

        Circle circle2 = new Circle(-2); 

    }
}