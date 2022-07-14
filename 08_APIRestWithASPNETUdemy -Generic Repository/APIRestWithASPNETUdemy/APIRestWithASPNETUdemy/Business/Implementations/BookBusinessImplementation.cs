
using APIRestWithASPNETUdemy.Model;
using APIRestWithASPNETUdemy.Repository;
using System.Collections.Generic;

namespace RestWithASPNETUdemy.Business.Implementations
{
    public class BookBusinessImplementation : IBookBusiness
    {
        private IBookRepository _repository;

        public BookBusinessImplementation(IBookRepository repository)
        {
            _repository = repository;
        }

        public List<Book> FindAll()
        {
            return _repository.FindAll();
        }
        //----------------------------------------------------------------------------------
        public Book FindByID(long id)
        {
            return _repository.FindById(id);
        }
        //----------------------------------------------------------------------------------
        public Book Create(Book book)
        {
            return _repository.Create(book);
        }
        //----------------------------------------------------------------------------------
        public Book Update(Book book)
        {
            throw new System.NotImplementedException();
        }
        //----------------------------------------------------------------------------------
        public void Delete(long id)
        {
            _repository.Delete(id);
        }
        //----------------------------------------------------------------------------------

    }
}
