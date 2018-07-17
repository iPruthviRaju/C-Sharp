using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0003_IsVsAs
{
    class Program
    {
        static void Main(string[] args)
        {
            //IS Operator:

            //The IS operator checks whether the type of an given object is compatible with the new object type.It returns boolean type value: true if given object is compatible with new one, else false.In this way IS operator help you to do safe type casting.

            //How to do it..

            Object obj = new Object(); // Creates a new Object obj
                                       // checking compatibility of obj object with other type
            Boolean b1 = (obj is Object); // b1 is set to true.
            Boolean b2 = (obj is Employee); // The cast fails: no exception is thrown, but b2 is set to false.
                                            //we can also use it 
            if (obj is Employee)
            {
                Employee emp = (Employee)obj;
                // TO DO:
            }

            //Note:
            //If the reference of the given object is null, the IS operator will return false since there is no object available to check its type.

            //In this way, CLR is checking the obj object type twice.First time with in the if condition and if it is true, with in the if block.Actually this way affect the performance since each and every time CLR will walk the inheritance hierarchy, checking each base type against the specified type(Employee).To avoid this we have AS operator.

            //AS Operator:

            //The AS operator also checks whether the type of an given object is compatible with the new object type.It returns non - null if given object is compatible with new one, else null.In this way AS operator help you to do safe type casting.The above code can be re - written by using AS operator in a better way.

            //How to do it..

            Object obj2 = new Object(); // Creates a new Object obj
                                        // checking compatibility of obj object with other type
            Employee emp = obj2 as Employee; // The cast fails: no exception is thrown, but emp is set to null.
            if (emp != null)
            {
                // TO:DO
            }

            //Note:
            //If the reference of the given object is null, the AS operator will return NULL since there is no object available to check its type.

            //AS operator performs only reference conversions, nullable conversions, and boxing conversions.This operator cannot perform other conversions like as user - defined conversions.

            //In this way, CLR is checking the obj object type only one time.Hence AS operator provide good performance over IS operator. Now if you want to use emp object then it will throw NullReferenceException as given below.
            Object obj3 = new Object();
            Employee emp2 = obj3 as Employee; // try to Cast obj to an Employee
                                              // The above cast fails: no exception is thrown, but emp is set to null.
            emp2.ToString(); // Accessing emp throws a NullReferenceException.

        }
    }

    internal class Employee
    {
        public long ID { get; set; }
        public string Name { get; set; }
    }
}
