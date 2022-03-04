using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp3
{
    internal abstract class Series
    {
        public abstract double Action(double a0,double step,double j);
        public abstract double Sum(double a0,double an,double n);
        public abstract string Print();
    }
    internal class Linear : Series /////////////////
    {
        public override double Sum(double a0, double an, double n)
        {
            return (n + 1) * (a0 + an);
        }

        public override string Print()
        {
            return " ";
        }

        public override double Action(double a0,double d,double j)
        {
            return a0 + j * d;                         
        }
    }
    internal class Exponential : Series ///////////////////////////
    {

        public override double Sum(double a0, double an,double r)
        {
            return (a0 - an * r) / (1 - r);
        }

        public override string Print()
        {
            return " ";
        }

        public override double Action(double a0, double r,double j)
        {
            return a0*Math.Pow(r,j);
        }
    }
}
