using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookShelfApp.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get { return $"{FirstName} {LastName}"; }
        }
        public string Penname { get; set; }
        public string PreferredGenre { get; set; }
        public string ApplicationUserId { get; set; }
        public List<Book> Books { get; set; }
    }
}
