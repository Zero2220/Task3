using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Library
    {
        private List<string> Books =new List<string>();
        public int BookLimit =5;

        

        public void AddBook(string Book)
        {
            if (Books.Contains(Book))
            {
                throw new ArgumentException("Bo kitap hal hazirda var ");
            }

            if (Books.Count >= BookLimit)
            {
                throw new InvalidOperationException("Kitap limiti doldu ");
            }

            Books.Add(Book);


        }
        public bool RemoveBook(string Book)
        {
            if (Books.Contains(Book))
            {
                Books.Remove(Book);
                return true;
            }
            return false;
        }

        public void ShowAll()
        {

            foreach(string Book in Books)
            {
                Console.WriteLine(Book);


            }

        }


    }
}
