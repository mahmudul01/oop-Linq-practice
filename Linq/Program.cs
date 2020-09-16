using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();

            //linq query operations.
            var pricybooks =
                from b in books
                where b.Price > 10
                orderby b.Price
                select b.Title;

            foreach (var item in pricybooks)
            {
                Console.WriteLine(item);
            }
            //linq extension methods.
            var cheapbooks = books
                .Where(x => x.Price < 500)
                .OrderBy(x => x.Price)
                .Select(x => x.Title + " " + x.Price);
            foreach (var item in cheapbooks)
            {
                Console.WriteLine(item);
            }

            //Single methods.
            var Book = books.Single(x => x.Price == 2432);
            Console.WriteLine(Book.Title);

            //Single or default methods.
            var book = books.SingleOrDefault(x => x.Price == 2432);
            Console.WriteLine(book == null);

            //Last or default methods. You can also try this for first or default.
            var LastBook = books.Last(x => x.Title == "Peradoxical Sajid9");
            Console.WriteLine(LastBook.Title + " " + LastBook.Price); 

            //Last or default methods. You can also try this for first or default.
            var Lastbook = books.LastOrDefault(x => x.Title == "Peradoxical Sajid9");
            Console.WriteLine(Lastbook == null);

            //Skip take method.
            var newBooks = books.Skip(2).Take(3);
            foreach (var item in newBooks)
            {
                Console.WriteLine(item.Title + " " + item.Price);
            }


            //Some another operations.
            var count = books.Count();
            Console.WriteLine(count);

            var maxPrice = books.Max(x => x.Price);
            Console.WriteLine(maxPrice);

            var minPrice = books.Min(x => x.Price);
            Console.WriteLine(minPrice);

            var totalPrice = books.Sum(x => x.Price);
            Console.WriteLine(totalPrice);

            var averagePrice = books.Average(x => x.Price);
            Console.WriteLine(averagePrice);


        }
    }
}
