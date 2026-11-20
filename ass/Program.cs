

namespace ass
{
    class Book
    {

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


           //////////////// // Start Q3
           ///
            //int pages = "464"; // like syntax error it`s a compi error le

            //int pages = 464; 

            //End Q3

           /////////////////////////////// // Start Q4
            
            //try
            //{
            //    int num1 = 10;
            //    int num2 = 0;

            //    int division = num1 / num2;

            //}
            //catch(Exception)
            //{
            //    Console.WriteLine("Cannot divide by zero /exception zero error");
            //}
            //finally
            //{
            //    Console.WriteLine("Finally Done.");
            //}

           ///////////////// //End Q4




         /////////////////////////  //////////// // Start Q5
            //Console.WriteLine(' ');

            //    Console.WriteLine(' ');

            //int pages = 300; 


            //double allPages = pages;
            //Console.WriteLine(allPages);


            //End Q5


          ////////////////////////////////////////  // Start Q6
            //double price = 49.99;

            //int intPrice = (int)price;

            //Console.WriteLine(intPrice);
            //End Q6




           //////////////////////////////// // Start Q7
            //string pagesText = "464";

            //int pages = Convert.ToInt32(pagesText);

            //Console.WriteLine(pages);
            //End Q7

           ////////////////////////////////////////////////// // Start Q8

            //string yearText = "2023";
            //int intyear = int.Parse(yearText);
            //Console.WriteLine(intyear);//2032

            //string badText = "abc";
            //if (int.TryParse(badText, out int result))
            //{
            //   Console.WriteLine(result);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid number");
            //}

            //End Q8

            ///////////////////////////////// Start Q9

            int pages = 464;
            string pagesText = pages.ToString();

            Console.WriteLine(pagesText);

            Console.WriteLine(pagesText.GetType());// System.String


            //End Q9

            //////////////////// // Start Q10
            ///
            int copies = 100;    
            object obj0 = copies;
            int newCopies = (int)obj0;
            Console.WriteLine(copies);
            Console.WriteLine(newCopies);

            //End Q10
        }





    }
}


