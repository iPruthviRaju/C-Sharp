///----------------------------------------------------------------------
/// <File>Program</File>
/// <Author>Pruthvi</Author>
/// <Date>August 8th, 2018</Date>
/// <Summary></Summary>
///-----------------------------------------------------------------------

namespace StringUtil
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {

            List<Person> list1 = new List<Person>() { new Person() { Name = "test", Field = "1" } };
            list1 = null;
            List<Person> list2 = new List<Person>() { new Person() { Name = "test", Field = "2" } };
            list2 = null;

            var result = MergeCustomFields(list1, list2);
            var stringUtil = StringUtil.Instance;

            string svc = "Pruthvi, Avinash , something ";
            var svcList = svc.Split(',').Select(m => m.Trim()).ToList();

            var input = "hi How are you doing?()!_-#$%^^&&**";

            var output = stringUtil.GetOnlyAlphanumeric(input);

            Console.WriteLine($"Alphanumerics : {output}");

            if (output == "hiHowareyoudoing")
            {
                Console.WriteLine("true");
            }

            Console.ReadLine();
        }

        public class Person
        {
            public string Name { get; set; }
            public string Field { get; set; }
        }

        private static List<Person> MergeCustomFields(List<Person> precedingList, List<Person> nextList)
        {
            precedingList = precedingList == null ? new List<Person>() : precedingList;
            nextList = nextList == null ? new List<Person>() : nextList;

            var merged = new List<Person>(precedingList);
            merged.AddRange(nextList.Where(p2 => precedingList.All(p1 => p1.Name != p2.Name)));

            return merged;
        }
    }
}
