using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shape
{
    internal class Triangle: Shape
    {
        private double _a;
        public double a
        {
            get { return _a; }
            set { _a = value; }
        }
        private double _b;
        public double b
        {
            get { return _b; }
            set { _b = value; }
        }
        private double _c;
        public double c
        {
            get { return _c; }
            set { _c = value; }
        }
        private double _h;
        public double h
        {
            get { return _h; }
            set { _h = value; }
        }
        private double _low;
        public double low
        {
            get { return _low; }
            set { _low = value; }
        }
        public Triangle(double userR,double userR2)
        {
            this.low = userR;
            this.h = userR2;
            CountArea();
            
        }
        public Triangle(double userR1, double UserR,double acer)
        {
            this.a = userR1;
            this.b = UserR;
            this.c = acer;

            CountPerimeter();
        }
        public override double CountPerimeter()
        {
            this.perimeter = this.a+this.b+this.c;
            return this.perimeter;
            throw new NotImplementedException();
        }
        public override double CountArea()
        {
            this.area = (this.low * this.h) /2;
            return this.area;
            throw new NotImplementedException();
        }
    }
}
