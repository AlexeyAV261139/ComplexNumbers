﻿namespace ComplexNumbers
{
    internal class ComplexNumbers
    {
		private double realNumberA, realNumberB, imaginagyNumberDegree;

		public double RealNumberA
		{
			get { return realNumberA; }
			set { realNumberA = value; }
		}
		
		public double RealNumberB
		{
			get { return realNumberB; }
			set { realNumberB = value; }
		}
		 		
		public double ImaginaryNumberDegree
		{
			get { return imaginagyNumberDegree; }
			set { imaginagyNumberDegree = value; }
		}

		public ComplexNumbers(double realNumberA, double realNumberB)
		{ RealNumberA = realNumberA; RealNumberB = realNumberB; }

        public override string ToString()
        {
            return $"{realNumberA} + {realNumberB}i";
        }
		public string Summ(double realNumC, double realNumD)
		{
			return $"{this.realNumberA + realNumC} + {this.realNumberB + realNumD}i";
		}
		public string Difference(double realNumC, double realNumD)
		{
			return $"{this.realNumberA - realNumC} + {this.realNumberB - realNumD}i";

		}

    }
}
