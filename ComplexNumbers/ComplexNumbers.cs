namespace ComplexNumbers
{
    internal class ComplexNumbers
    {
		private double realNumberA;

		public double RealNumberA
		{
			get { return realNumberA; }
			set { realNumberA = value; }
		}

		private double realNumberB;

		public double RealNumberB
		{
			get { return realNumberB; }
			set { realNumberB = value; }
		}
		 

		private double imaginagyNumberDegree;

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
		public string Summ(double realNumA, double realNumB)
		{
			return $"{this.realNumberA + realNumA} + {this.realNumberB + realNumB}i";
		}

    }
}
