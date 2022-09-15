using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;
using File = System.IO.File;

namespace GeneratorRandomNames
{
    public class NamesParser
    {
        public readonly string[] NamesMans = File.ReadAllLines("Мужские отформатированные.txt");
        public readonly string[] NamesWomens = File.ReadAllLines("Женские отформатированные.txt");
        public NamesParser()
        {

        }
        public string[] getManNames(int count)
        {
            Random rand = new Random();
            HashSet<string> namesSet = new HashSet<string>();

            while (namesSet.Count != count)
                namesSet.Add(NamesMans[rand.Next(NamesMans.Length)]);

            return namesSet.ToArray();
        }
        public string[] getWomenNames(int count)
        {
            Random rand = new Random();
            HashSet<string> namesSet = new HashSet<string>();

            while (namesSet.Count != count)
                namesSet.Add(NamesWomens[rand.Next(NamesWomens.Length)]);

            return namesSet.ToArray();
        }
        public string[] getAllNames(int count)
        {
            Random rand = new Random();
            List<string> namesSet = NamesMans.Concat(NamesWomens).ToList();
            List<string> namesSet2 = new List<string>();

            while (namesSet2.Count != count)
                namesSet2.Add(namesSet[rand.Next(namesSet.Count)]);

            return namesSet2.ToArray();
        }
    }
}
