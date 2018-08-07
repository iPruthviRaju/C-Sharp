///----------------------------------------------------------------------
/// <File>Program</File>
/// <Author>Pruthvi</Author>
/// <Date>August 7th, 2018</Date>
/// <Summary></Summary>
///-----------------------------------------------------------------------
namespace Sample
{
    using Yield;
    class Program
    {
        static void Main(string[] args)
        {
            MathComponents mathComponent = new MathComponents();
            foreach (int i in mathComponent.Power(2, 8))
            {
                System.Console.WriteLine($"{i}");
            }
            System.Console.ReadLine();
        }
    }
}
