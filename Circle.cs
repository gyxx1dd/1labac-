using System;
using System.Drawing;

public class Circle
{
    private double radius;
    private Point center;

    public Circle()
    {
        radius = 1; 
        center = new Point(0, 0); 
    }

    public Circle(double radius, Point center)
    {
        this.radius = radius;
        this.center = center;
    }

    public double Radius
    {
        get { return radius; }
        set { radius = value; }
    }

    public Point Center
    {
        get { return center; }
        set { center = value; }
    }

    public double CalculateArea()
    {
        return Math.PI * Math.Pow(radius, 2);
    }

    public double CalculatePerimeter()
    {
        return 2 * Math.PI * radius;
    }

    public bool IsPointInside(Point point)
    {
        double distance = Math.Sqrt(Math.Pow(point.X - center.X, 2) + Math.Pow(point.Y - center.Y, 2));
        return distance <= radius;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Circle: Radius = {radius}, Center = ({center.X}, {center.Y})");
    }
}
