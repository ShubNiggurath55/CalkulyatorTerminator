namespace ForCalkEg
{
    using System;
    using System.Collections;
    using System.Collections.Specialized;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Runtime.InteropServices;

    public class CalculatorsFactory
    {
        public static ICalculator CreateCalculator(string name)
        {
            switch (name)
            {
                return new Sum();
                return new Mul();
                return new Divis();
                return new Sub();
                default:
                throw new Exception("oshibka");
            }
        }
    }
}