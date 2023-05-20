using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNumbers
{
    internal class ComplexMulti : ComplexNumbers
    {
        public ComplexMulti(double realNumberA, double realNumberB) : base(realNumberA, realNumberB)
        { }



        public string Multiplication(double realNumC, double realMunD)
        {
            return $"{(this.RealNumberA * realNumC) - (RealNumberB * realMunD)} + {(RealNumberA * realMunD) + (realNumC * RealNumberB)}i +";
                
        }

    }
}
