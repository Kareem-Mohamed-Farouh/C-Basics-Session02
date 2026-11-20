

namespace ass
{
    class Book { 
    
      public string? title;
       public int? pages;


    }
    internal class Program
    {

        static void Main(string[] args)
        {

            Book book = new Book();
           
            book.title = "Clean Code";
            book.pages = 464;

            object obj = book;

            Console.WriteLine(obj);//ass.Book

            // #end     Q1




         // Start Q2
            Console.WriteLine(book.ToString()); //ass.book

            Console.WriteLine(book.Equals(book));//true

            Console.WriteLine(book.GetHashCode()); //integer value 37095509

            Console.WriteLine(book.GetType());  //ass.book


            //End Q2


            // Start Q3
            //int pages = "464"; // like syntax error it`s a compi error le

            //int pages = 464; 

            //End Q3

            // Start Q4

            try
            {
                int num1 = 10;
                int num2 = 0;

                int division = num1 / num2;

            }
            catch(Exception)
            {
                Console.WriteLine("Cannot divide by zero /exception zero error");
            }
            finally
            {
                Console.WriteLine("Finally Done.");
            }

            //End Q4


            // Start Q5
            Console.WriteLine(' ');

                Console.WriteLine(' ');

            int pages = 300; 


            double allPages = pages;
            Console.WriteLine(allPages);


            //End Q5



        }





    }
}