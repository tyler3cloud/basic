namespace Add.Core.Service
{
    public interface IService
    {
        int Add(int firstAddend, int secondAddend);
        double Add (double firstAddend, double secondAddend);
        decimal Add (decimal firstAddend, decimal secondAddend);
    }

    public class Service : IService
    {
        public int Add(int firstAddend, int secondAddend)
        {
            return firstAddend + secondAddend;
        }

        public double Add(double firstAddend, double secondAddend)
        {
            return firstAddend + secondAddend;
        }

        public decimal Add(decimal firstAddend, decimal secondAddend)
        {
            return firstAddend + secondAddend;
        }
    }
}

