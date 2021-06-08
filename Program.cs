using System;
using System.Collections.Generic;



namespace CollectionsPractise
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[] array= {0,1,2,3,4,5,6,7,8,9};
            // foreach (int arr in array)
            // {
            //     Console.WriteLine(arr);
            // }

            string[] names= { "Tim", "Martin", "Nikki", "Sara"};
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            bool[] boolean= new bool[] {true,false,true,false, true,false,true,false,true,false};
            foreach (bool b in boolean)
            {
                Console.WriteLine(b);
            }
            List<string> flavors = new List<string>();
            flavors.Add("Vanilla");
            flavors.Add("Chocolate Chip");
            flavors.Add("Mint");
            flavors.Add("Strawberry");
            flavors.Add("Birthday Cake");
            
            Console.WriteLine($"Third item is {flavors[2]}");
            Console.WriteLine($"Current length of the list is {flavors.Count}");
            flavors.RemoveAt(2);
            Console.WriteLine($"Now length of the list has became {flavors.Count}");
            foreach (string flavor in flavors)
            {
                Console.WriteLine(flavor);
            }
            Dictionary<string,string> Dict = new Dictionary<string,string>();
            Dict.Add(names[Key()],flavors[Key()]);
            Dict.Add(names[Key()],flavors[Key()]);
            Dict.Add(names[Key()],flavors[Key()]);
            foreach (KeyValuePair<string,string> value in Dict)
{
    Console.WriteLine(value.Key + " - " + value.Value);
}


        }
        static int Key()
        {
            Random rand= new Random();
            return rand.Next(0,4);
        }
    }
}
