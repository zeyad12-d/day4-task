namespace ConsoleApp3
{

    struct book()
    {
        public string titel;
        public string Author;
        public int publication_year;
        public string bookgener;
    }
    enum gener
    { 
        fiction,
        nonfiction,
        mysister,
        biograodhy
    }

internal class Program
{
     static void Main(string[] args)

        {
            Console.WriteLine("enter number of book");

            int num_book = int.Parse(Console.ReadLine());
            // array to stored book data
            book[] book_data = new book[num_book];

            for (int i = 0; i < book_data.Length; i++)
            {
                book_data[i] = new book();

                Console.WriteLine(  " entre titel: ");
                book_data[i].titel = Console.ReadLine();
                // check form titel
                if (book_data[i].titel=="zeyad")
                {
                    book_data[i].bookgener = gener.fiction.ToString();
                }
                else if (book_data[i].titel=="ahmed")
                {
                    book_data[i].bookgener= gener.nonfiction.ToString();
                }
                else if (book_data[i].titel == "saad")
                {
                    book_data[i].bookgener=gener.mysister.ToString();
                }
                else if (book_data[i].titel=="kaled")
                {
                    book_data[i].bookgener=gener.biograodhy.ToString();// to string because enum stored integer value
                }

                Console.WriteLine(" enter auther:");
                book_data[i].Author = Console.ReadLine();
                Console.WriteLine(  " enter publication year:");
                book_data[i].publication_year=int.Parse(Console.ReadLine());

            }
            // new line 
            Console.WriteLine();

            // desplay ruselt

            foreach (book book in book_data) 
            {
                Console.WriteLine($"titel:" +
                    $"{book.titel}\n" +
                    $"auther:" +
                    $"{ book.Author} \n"    +
                    $"publication year " +
                    $" {book.publication_year}\n " +
                    $"gener " +
                    $"" +
                    $" {book.bookgener }"
                    
                    
                   
                    );


            }


        }

    }

}
