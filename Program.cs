// See https://aka.ms/new-console-template for more information
using System;
using shape;

//Shape myshape = new Shape();

Shape mycircle1 = new Circle(6.2);
Shape mycircle2 = new Circle(2.5);
Shape myrectangle = new Rectangle(9,8);
Shape myrectangle2 = new Rectangle(2,10);
Shape myTriangle = new Triangle(9,5);
Shape myTriangle2 = new Triangle(2,5,9);
Shape myTrapezoid1 = new Trapezoid(10,5,4);



Console.WriteLine("mycircile1:" + mycircle1.area.ToString());
Console.WriteLine(" mycircile2:" + mycircle2.area.ToString());
string msg = "";
Console.WriteLine("myrectangle:" + myrectangle.area.ToString());
Console.WriteLine("myTriangle:" + myTriangle.area.ToString());
Console.WriteLine("myrectangle:" + myrectangle2.perimeter.ToString());
Console.WriteLine("myTriangle2:"  + myTriangle2.perimeter.ToString());
Console.WriteLine("myTrapezoid1:" + myTrapezoid1.area.ToString());

if (mycircle1.area.CompareTo(myTriangle.area) > 0)
{
    if (myTrapezoid1.area.CompareTo(mycircle1.area) > 0)
        Console.WriteLine("梯形 > 圓形 > 三角形");
    else if (myTrapezoid1.area.CompareTo(mycircle1.area) == 0)
        Console.WriteLine("梯形 = 圓形 > 三角形");
    else if (myTriangle.area.CompareTo(myTrapezoid1.area) > 0)
        Console.WriteLine("圓形 > 梯形 > 三角形");
    else Console.WriteLine("圓形 > 三角形 > 梯形");
}
else if (mycircle1.area.CompareTo(myTriangle.area) < 0)

    if (myTrapezoid1.area.CompareTo(myTriangle.area) > 0)
        Console.WriteLine("梯形 > 三角形 > 圓形");
    else if (myTrapezoid1.area.CompareTo(mycircle1.area) == 0)
        Console.WriteLine("梯形 = 三角形 > 圓形");
    else if (myTriangle.area.CompareTo(myTrapezoid1.area) > 0)
        Console.WriteLine("三角形 > 梯形 > 圓形");
    else Console.WriteLine("三角形 > 圓形 > 梯形");
else
{
    if (myTrapezoid1.area.CompareTo(mycircle1.area) > 0)
        Console.WriteLine("梯形 > 圓形 = 三角形");
    else if (myTrapezoid1.area.CompareTo(mycircle1.area) < 0)
        Console.WriteLine("圓形 = 三角形 > 梯形");
    else Console.WriteLine("圓形 = 三角形 = 梯形");
    
}
Console.WriteLine(msg);
