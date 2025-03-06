using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shape
{
    public class Circle : Shape
    {
        private double _r;
        public double r
        {
            get { return _r; }
            set { _r = value; }
        }
        public Circle(double userR) { 
           this.r= userR;
            CountArea();
        }
        public override double CountPerimeter()
        {
            this.perimeter = 2*this.r*3.141516;
            return this.perimeter;
            throw new NotImplementedException();
        }
        public override double CountArea()
        {
            this.area=this.r * this.r * 3.141516; 
            return this.area;
            throw new NotImplementedException();
        }
    }
}
