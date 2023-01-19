using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_08 {

    public abstract class Shape {

        // abstract method
        public abstract decimal Surface();

    }


    public abstract class Circle : Shape {

        public abstract decimal Perimeter();


        //public override decimal Surface() {

        //    return 0;
        //}
    }


    public class FotisCircle : Circle {

        public override decimal Perimeter() {

            return 0;
        }

        public override decimal Surface() {

            return 0;
        }
    }


}
