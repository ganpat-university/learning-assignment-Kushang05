using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometric_Shape_Calc
{
    public class Run
    { 
        public static void Calculate()
        {
            Circle cir = new Circle(10);
            Console.WriteLine(" Circle ");
            Console.WriteLine("Circumference = {0}  Area = {1}", cir.Peremeter, cir.Area());

            Square objs = new Square(10);
            Console.WriteLine(" Square ");
            Console.WriteLine("Peremeter = {0}  Area = {1}", objs.Peremeter, objs.Area());

            Rectangle objr = new Rectangle(30,10);
            Console.WriteLine(" Rectangle ");
            Console.WriteLine("Peremeter = {0}  Area = {1}", objr.Peremeter, objr.Area());

            Triangle objt = new Triangle(20,10 ,10, 22, 20);
            Console.WriteLine(" Square ");
            Console.WriteLine("Peremeter = {0}  Area = {1}", objt.Peremeter, objt.Area());
        }
        abstract class Shape
        {
            abstract public decimal Peremeter { get;}
            abstract public decimal Area(); 
        }
    
        class Circle : Shape
        {
            private int radius;
            public decimal cir = 6.28318530718M;

            public Circle(int radius)
            {
                this.radius = radius;

            }

            public override decimal Peremeter
            {
                get {
                    return cir* this.radius ;
                }
            }

            public override decimal Area()
            {
                return cir * this.radius * this.radius;
            }
        }
    
        abstract class Quadrilateral :Shape
        {
            protected int side1, side2, side3, side4;

            public override decimal Peremeter
            {
                get
                {
                    return this.side1 + this.side2 * +this.side3 * +this.side4 ;
                }
            }

            public abstract override decimal Area();
        
        }

        class Triangle : Shape
        {
            private int breath, height, side1,side2, side3;

            public Triangle(int breath, int height , int side1, int side2 ,int side3)
            {
                this.breath = breath;
                this.height = height;
                this.side1 = side1;
                this.side2 = side2;
                this.side3 = side3;
             
            }

            public override decimal Peremeter
            {
                get
                {
                    return this.side1 + this.side2 + this.side3;
                }
            }
            public override decimal Area()
            {
                return (this.height * this.breath)/2;
            }
        }

            class Square : Quadrilateral
            {
                public Square(int side)
                {
                    base.side1=base.side2=base.side3=base.side4=side;
                }
                public override decimal Area()
                {
                    return base.side1 * base.side2;
                }

            }

        class Rectangle : Quadrilateral
        {

            public Rectangle(int lenght, int breath)
            {
                base.side1 = base.side3 = lenght;
                base.side2 = base.side4 = breath;
            }
            public override decimal Area()
            {
                return base.side3 * base.side4;
            }

        }
    }
}
