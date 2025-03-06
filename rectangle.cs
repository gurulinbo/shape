using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shape
{
    internal class Rectangle:Shape
    {
        private double _r;
        private double _g;
        public double r
        {
            get { return _r; }
            set { _r = value; }
        }
        public double g 
        {
            get { return _g; }
            set { _g = value; }
        }
        public Rectangle(double userR, double userR2)
        {
            this.r = userR;
            this.g = userR2;
            CountArea();
            CountPerimeter();
        }

        public override double CountPerimeter()
        {
            this.perimeter = 2 * (this.r + this.g);
            return this.perimeter;
            throw new NotImplementedException();
        }
        public override double CountArea()
        {
            this.area = this.r * this.g;
            return this.area;
            throw new NotImplementedException();
        }
    }
}
    


