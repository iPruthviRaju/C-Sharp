using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rough
{
    class Program
    {
        static void Main(string[] args)
        {
            var precedingList = new List<CustomField>
            {
                new CustomField() { Name = "common1", Value = "precedingList-v1" },
                new CustomField() { Name = "common2", Value = "precedingList-v2" },
                new CustomField() { Name = "common3", Value = null },
                new CustomField() { Name = "v4", Value = "precedingList-v4" },
                new CustomField() { Name = "v7", Value = "precedingList-v7" },
                new CustomField() { Name = "v7", Value = null }
            };

            var nextList = new List<CustomField>
            {
                new CustomField() { Name = "common1", Value = "nextList-v1" },
                new CustomField() { Name = "common2", Value = "nextList-v2" },
                new CustomField() { Name = "common3", Value = "nextList-v3" },
                new CustomField() { Name = "v5", Value = "nextList-v5" },
                new CustomField() { Name = "v6", Value = "nextList-v6" },
                new CustomField() { Name = "v7", Value = "nextList-v7" }
            };

            var result = MergeCustomFields(precedingList: precedingList, nextList: nextList);

            result.ForEach(m => Console.WriteLine($"{m.Name} - {m.Value}"));
            Console.Read();
        }

        public static List<CustomField> MergeCustomFields(List<CustomField> precedingList, List<CustomField> nextList)
        {
            precedingList = precedingList == null ? new List<CustomField>() : precedingList;
            nextList = nextList == null ? new List<CustomField>() : nextList;

            var merged = new List<CustomField>(precedingList);

            merged.RemoveAll(preceding => nextList.Any(next => next.Name == preceding.Name) && preceding.Value == null);

            merged.AddRange(nextList.Where(next => merged.All(preceding => preceding.Name != next.Name)));

            return merged;
        }
    }

    public class CustomField
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }
}
