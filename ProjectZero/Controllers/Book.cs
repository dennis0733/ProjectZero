using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ProjectZero.Areas.Identity.Pages.Account;

namespace ProjectZero.Controllers
{
    public class Book
    {


        [Key]
        public int BookId { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Name { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string Author { get; set; }

        public int Year { get; set; }

        [Column(TypeName = "varchar(250)")]
        public string Description { get; set; }
        

    }
}
