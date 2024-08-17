using System.Numerics;
using Katio.Business.Services;
using Katio.Data.Models;

namespace Katio.Business.Interfaces;

public interface IBookService{
    Task<IEnumerable<Books>> GetAllBooks();
    Task<IEnumerable<BookService>> GetById();
}