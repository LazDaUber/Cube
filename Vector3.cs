using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cube {
    public class Vector3 {
        public Vector3() : this(0,0,0) { }
        public Vector3(double x, double y, double z) { 
            X = x;
            Y = y;
            Z = z;
        }
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
    }
}
