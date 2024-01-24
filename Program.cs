using System.Data;

namespace resrved_words_freq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] keywords = {
                "abstract", "as", "base", "bool", "break", "byte", "case", "catch", "char", "checked",
                "class", "const", "continue", "decimal", "default", "delegate", "do", "double", "else", "enum",
                "event", "explicit", "extern", "false", "finally", "fixed", "float", "for", "foreach", "goto",
                "if", "implicit", "in", "int", "interface", "internal", "is", "lock", "long", "namespace", "new",
                "null", "object", "operator", "out", "override", "params", "private", "protected", "public",
                "readonly", "ref", "return", "sbyte", "sealed", "short", "sizeof", "stackalloc", "static",
                "string", "struct", "switch", "this", "throw", "true", "try", "typeof", "uint", "ulong",
                "unchecked", "unsafe", "ushort", "using", "virtual", "void", "volatile", "while"
            };

            string fname = "data.txt";
            string lines = String.Join(" ",File.ReadAllLines(fname));
            SortedDictionary<string, int> dict = new SortedDictionary<string, int>();
            
            foreach (string key in keywords)
            {
                if (lines.Contains(key))
                {
                    string[] arr = lines.Split(" :;{}[].\t\n?,".ToCharArray());

                    int count = Array.FindAll(arr, x => x == key).Length;
                    dict.Add(key, count);
                }
            }

            Console.WriteLine("\t\tWord:\t\t\tCount:");
            foreach (var item in dict)
            {
                Console.WriteLine($"\t\t{item.Key}\t\t\t{item.Value}");
            }


        }
    }
}