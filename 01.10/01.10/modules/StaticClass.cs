using System;
using System.Collections.Generic;
using System.Text;

namespace _01._10.modules
{
    public static class StaticClass
    {
        public static string Path { get; set; }
        public static string Text { get; set; }
        public static void WriteLine()
        {
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(Path, false))
            {
                file.WriteLine(Text);
            }

        }
        public static void ReadLine()
        {
            using (System.IO.StreamReader streamReader = new System.IO.StreamReader(Path, true))
            {
                var result = streamReader.ReadToEnd();
                Console.WriteLine(result);
            }
        }
    }

}
