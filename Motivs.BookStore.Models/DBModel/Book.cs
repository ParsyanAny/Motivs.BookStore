using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motivs.BookStore.Models.DBModel
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(150)]
        public string Title { get; set; }
        public double Price { get; set; }
        public int AuthorId { get; set; }
        public int GenreId { get; set; }
    }
}