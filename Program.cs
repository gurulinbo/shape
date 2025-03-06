// See https://aka.ms/new-console-template for more information
using shape;

//Shape myshape = new Shape();

Shape mycircle1 = new Circle(5.4);
Shape mycircle2 = new Circle(2.5);
Shape myrectangle = new Rectangle(2,5);
Shape myrectangle2 = new Rectangle(2,10);
Shape myTriangle = new Triangle(2,5);
Shape myTriangle2 = new Triangle(2,5,9);



Console.WriteLine("mycircile1:" + mycircle1.area.ToString() + " mycircile2:" + mycircle2.area.ToString());
Console.WriteLine(msg);
Console.WriteLine("myrectangle:" + myrectangle.area.ToString());
Console.WriteLine("myTriangle:" + myTriangle.area.ToString());
Console.WriteLine("myrectangle:" + myrectangle2.perimeter.ToString());
Console.WriteLine("myTriangle2:"  + myTriangle2.perimeter.ToString());
string msg = "";

if (mycircle1.CompareTo(mycircle2) == 0)
    msg = "一樣";

if (mycircle1.CompareTo(mycircle2) > 0)
    msg = "1號大";

if (mycircle1.CompareTo(mycircle2) < 0)
    msg = "2號大";

