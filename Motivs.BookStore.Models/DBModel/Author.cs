using System.ComponentModel.DataAnnotations;

namespace Motivs.BookStore.Models.DBModel
{
    public class Author
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FullName { get; set; }
    }
}
