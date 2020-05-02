using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak2
{
    class Zadatak2
    {
        public static double Op2Numb(string operacija, double broj1, double broj2)
        {


            switch (operacija)
            {
                case "+":
                    return Add(broj1, broj2);
                case "-":
                    return Substract(broj1, broj2);

                case "*":
                    return Multply(broj1, broj2);

                case "/":
                    return Divide(broj1, broj2);
                default:
                    return 0;

            }

        }
        public static double Add(double broj1, double broj2)
        {
            return broj1 + broj2;
        }

        public static double Substract(double broj1, double broj2)
        {
            if (broj2 > broj1)
            {
                return broj2 - broj1;
            }
            else
            {
                return broj1 - broj2;
            }

        }

        public static double Multply(double broj1, double broj2)
        {
            return broj1 * broj2;
        }
        public static double Divide(double broj1, double broj2)
        {
            if (broj2 > broj1)
            {
                return broj2 / broj1;
            }
            else
            {
                return broj1 / broj2;
            }

        }

    }
}
