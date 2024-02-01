using System.Net;
using Task3;

Library library = new Library();

string opr;
do
{
    Console.WriteLine("1.Kitap daxil edin ");
    Console.WriteLine("2.Kitap silin ");
    Console.WriteLine("3.Butun kitaplari goster");
    Console.WriteLine("4.Kitaplar uzre axtaris et ");

   
    
    opr = Console.ReadLine();

    switch (opr )
    {
        case "1":
            string oprAdd;           
            Console.Clear();
            Console.WriteLine("Kitap adini daxil edin:");                
            oprAdd = Console.ReadLine();
                try
                {
                    library.AddBook(oprAdd);
                }
                catch (Exception BookAlreadyHaveException)
                {
                    Console.WriteLine("Sehv:" + BookAlreadyHaveException.Message);
                }                
            break;
        case "2":
            string oprRmv;
            Console.Clear();
            Console.WriteLine("sileceyiniz kitabi secin ");
            oprRmv = Console.ReadLine();
            library.RemoveBook(oprRmv);
            break;
        case "3":
            
            library.ShowAll();
            break;
        case "4":
            Console.Clear();

            char c;
            string cStr = Console.ReadLine();

            if (char.TryParse(cStr, out c))
            {
                library.Search(c);
            }
            else Console.WriteLine("yanlish formatda daxil etdiniz");


            break;
    }
}
while (opr != "0");   