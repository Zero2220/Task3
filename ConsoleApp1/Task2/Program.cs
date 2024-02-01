using Task2;
Library bookList = new Library();
string s = "Kitap";
try
{
    bookList.AddBook(s);
}
catch (Exception BookAlreadyHaveException)
{
    Console.WriteLine("Sehv:" + BookAlreadyHaveException.Message);
}
bookList.RemoveBook(s);

bookList.ShowAll();