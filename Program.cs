using System;
using System.IO;
using System.Text.RegularExpressions;

namespace question2
{
    class Program
    {
        static void Main(string[] args)
        {
            string html = File.ReadAllText("/Users/anthonykruger/OneDrive/Richfield/year_3/semester_2/PROG742/" +
                                           "assignments/assignment_2/question2/Covid-19.html");
            string[] toPrint = new []{StripHtml(html)};
            File.WriteAllLines("/Users/anthonykruger/OneDrive/Richfield/year_3/semester_2/PROG742/assignments/" +
                               "assignment_2/question2/Covid-21.html", toPrint);
        }
        public static string StripHtml(string input)
        {
            string toReturn = Regex.Replace(input, "<.*?>", String.Empty);
            toReturn = Regex.Replace(toReturn, "!H", "!\nH");
            toReturn = Regex.Replace(toReturn, "eC", "e\nC");
            toReturn = Regex.Replace(toReturn, "sA", "s\nA");
            return toReturn;
        }
    }
}