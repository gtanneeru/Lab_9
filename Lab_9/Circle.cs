using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9
{
    public class Circle

    {
        static int countOfObjects = 0;
        double radius = 3;
        double pi = Math.PI;

        public Circle(double radius)
        {
            countOfObjects++;
        }
               
    public static int getObjectCount()
        {
            return countOfObjects;
        }


     public double getCircumference()
        {
            double circumference = 2 * pi * radius;

            return circumference;
        }

    
    public String getFormatedCircumference()
        {
          double circumference  = getCircumference();

          return formatNumber(circumference);

        }


    public double getArea()
        {
            double area = pi * radius * radius;
            return area;
        }


      public String getFormatedArea()
        {
              return formatNumber(getArea());
                     
        }


    private string formatNumber (double x)
        {
         string common = String.Format("{0:0.00}",x );

            return common;
        }

    }
}
