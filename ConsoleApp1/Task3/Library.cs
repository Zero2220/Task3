using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Library
    {
        private List<string> Books = new List<string>();
        public int BookLimit = 5;
        public void AddBook(string Book)
        {
            if (Books.Contains(Book))
            {
                throw new ArgumentException("Bu kitap hal hazirda var ");
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
            foreach (string Book in Books)
            {
                Console.WriteLine("Kitablar{");
                Console.WriteLine("Kitap adi :" + Book);
                Console.WriteLine("}");

            }
        }
        public void Search(char c)
        {
            int count = 0;
            for(int i = 0; i < Books.Count; i++)
            {
                for (int j = 0; j < Books[i].Length; j++)
                {
                    if (Books[i][j] == c)
                    {
                        Console.WriteLine("Kitap adi:"+Books[i]);
                        count++;
                    }
                }
            }
            if(count == 0)
            {
                Console.WriteLine("Hec bir kitap tapila bilmedi :(");
            }

        }

    }
}
