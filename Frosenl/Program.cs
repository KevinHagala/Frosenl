using System;
using System.Collections.Generic;
using System.IO;

namespace Frosenl
{
    class Frosenl
    {
        string name;
        string wish;

        public Frosenl(string _name, string _wish)
        {
            name = _name;
            wish = _wish;
        }
        public string Name { get { return name; } }
        public string Wish { get { return wish; } }
    }

    class FrosenList
    {
        List<Frosenl> Frosenl;
        

        public FrosenList()
        {
            Frosenl = new List<Frosenl>();
        }
        public void AddFrosenToList(string name, string wish)
        {
            Frosenl newFrosenl = new Frosenl(name, wish);
            Frosenl.Add(newFrosenl);
        }
        public void PrintAllMovies()
        {
            foreach (Frosenl list in Frosenl)
            {
                Console.WriteLine($"{list.Name} wants {list.Wish} for christmas");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\opilane\Samples";
            string fileName = @"frosen.txt";
            string fullFilePath = Path.Combine(filePath, fileName);
            string[] linesFromfile = File.ReadAllLines(fullFilePath);
            FrosenList mylist = new FrosenList();

            foreach (string line in linesFromfile)
            {
                string[] tempArray = line.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
                string Name = tempArray[0];
                string Wish = tempArray[1];
               
                mylist.AddFrosenToList(Name, Wish );
            }
            mylist.PrintAllMovies();
        }
    }
}
