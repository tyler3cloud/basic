namespace Subtract.Core.Service
{
    public interface IService
    {
        int Subtract(int minuend, int subtrahend);
        double Subtract(double minuend, double subtrahend);
        decimal Subtract(decimal minuend, decimal subtrahend);
    }

    public class Service : IService
    {
        public int Subtract(int minuend, int subtrahend)
        {
            return minuend - subtrahend;
        }
        public double Subtract(double minuend, double subtrahend)
        {
            return minuend - subtrahend;
        }
        public decimal Subtract(decimal minuend, decimal subtrahend)
        {
            return minuend - subtrahend;
        }
    }
}

