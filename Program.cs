using System;

public class Circle
{
    public double Radius { get; set; }
    public string Color { get; set; }

    public Circle(double radius, string color)
    {
        Radius = radius;
        Color = color;
    }

    public double GetArea()
    {
        return Math.PI * Radius * Radius;
    }

    public override string ToString()
    {
        return $"Circle: Radius = {Radius}, Color = {Color}, Area = {GetArea()}";
    }
}

public class Cylinder : Circle
{
    public double Height { get; set; }

    public Cylinder(double radius, string color, double height)
        : base(radius, color)
    {
        Height = height;
    }

    public double GetVolume()
    {
        return GetArea() * Height;
    }

    public override string ToString()
    {
        return $"Cylinder: Radius = {Radius}, Color = {Color}, Height = {Height}, Volume = {GetVolume()}";
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Circle circle = new Circle(5.0, "Red");
        Console.WriteLine(circle.ToString());

        Cylinder cylinder = new Cylinder(3.0, "Blue", 10.0);
        Console.WriteLine(cylinder.ToString());
    }
}