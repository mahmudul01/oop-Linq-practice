using System.Collections.Generic;

namespace Linq
{
    public class BookRepository
    {
        public IEnumerable<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book() {Title = "Moner Opor Lagam", Price = 343},
                new Book() {Title = "Peradoxical Sajid", Price = 243},
                new Book() {Title = "Peradoxical Sajid", Price = 249},

                new Book() {Title = "Allah'r proti sudharona", Price = 323},
                new Book() {Title = "Kolbun Salim", Price = 123}
            };
        }
    }
}
