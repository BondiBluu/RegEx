using System.Text.RegularExpressions;

namespace RegEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ways to initialize
            Regex regex = new Regex(@"\d{3}-\d{2}-\d{4}");
            string pattern = @"\d{3}-\d{2}-\d{4}";
            Regex regex1 = new Regex(pattern);

            string text = "My SSN is 123-45-6789";

            //matching the regex pattern with string text
            MatchCollection matches = regex.Matches(text);

            Console.WriteLine("Matches: " + matches.Count);

            string text2 = "My SSNs are 123-45-6789, 222-33-4567, 888-43-5675";

            Console.WriteLine("Matches: " + regex.Matches(text2).Count);
        }
    }
}
