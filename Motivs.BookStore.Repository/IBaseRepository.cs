using Motivs.BookStore.Repository.IMPL;
using System.Collections.Generic;

namespace Motivs.BookStore.Repository
{
    public interface IBaseRepository
    {
        void Create(Book book);
        Book GetById(int Id);
        List<Book> GetAll();
        void DeleteById();
        void DeleteAll();

    }
}
