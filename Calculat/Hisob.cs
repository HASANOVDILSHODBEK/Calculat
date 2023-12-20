
using _1.Properties;
using System.Numerics;

namespace Calculat
{
    public class Hisoblash <Generic>: ICalculatorinterface<Generic>
        where Generic : INumber<Generic>
    {
        public Generic boluv(Generic a, Generic b)
        {
            return a / b;

        }

        public Generic kopay(Generic a, Generic b)
        {

            return a * b;
        }

        public Generic mius(Generic a, Generic b)
        {
            return a - b;
        }

        public Generic plus(Generic a, Generic b)
        {
            return a + b;
        }

    }
}
