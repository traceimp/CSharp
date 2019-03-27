using System;

namespace StatementLamda
{
    class Program
    {
        delegate string Concatenate(string[] args);

        static void Main(string[] args)
        {
            Concatenate concat =
                (arr) =>
                {
                    string result = "";
                    foreach (string s in arr)
                        result += s;

                    return result;
                };

            Console.WriteLine(concat(args));
        }
    }
}
