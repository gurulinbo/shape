using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shape
{
    internal class Trapezoid : Shape
    {
        private double _r;
        private double _g;
        private double _h;
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
        
        public double h
        {
            get { return _h; }
            set { _h = value; }
        }
        public Trapezoid(double userR, double userR2, double userR3)
        {
            this.r = userR;
            this.g = userR2;
            this.h = userR3;
            CountArea();
            
        }

        
        public override double CountArea()
        {
            this.area = (this.r + this.g)*h/2;
            return this.area;
            throw new NotImplementedException();
        }

        public override double CountPerimeter()
        {
            
            throw new NotImplementedException();
        }
    }
}
