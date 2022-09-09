namespace Day10_empWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilder Dmart = new EmpWageBuilder("Dmart", 20, 2, 10);
            EmpWageBuilder Reliance = new EmpWageBuilder("Reliance", 10, 4, 20);
            Dmart.ComputeWage();
            Console.WriteLine(Dmart.ToString());
            Reliance.ComputeWage();
            Console.WriteLine(Reliance.ToString());
        }
    }
}