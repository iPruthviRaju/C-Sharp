///----------------------------------------------------------------------
/// <File>Program</File>
/// <Author>Pruthvi</Author>
/// <Date>August 7th, 2018</Date>
/// <Summary></Summary>
///-----------------------------------------------------------------------
namespace Yield
{
    using System.Collections.Generic;

    public class MathComponents
    {
        public IEnumerable<int> Power(int number, int exponent)
        {
            int result = 1;

            for(int i = 0; i < exponent; i++)
            {
                result = result * number;
                yield return result;
            }
        }
    }
}
