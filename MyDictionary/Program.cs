using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Dictionary<string> vocabularies = new Dictionary<string>();
            vocabularies.Add("Pencil");
            vocabularies.Add("Pencil");
            vocabularies.Add("Pencil");
            vocabularies.Add("Pencil");
            vocabularies.Add("Pencil");
            vocabularies.Add("Pencil");
            vocabularies.Add("Pencil");
            Console.WriteLine("Kelime Sayısı: " + vocabularies.Count);

        }
    }
}
