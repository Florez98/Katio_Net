using System;
using Katio.Business.Interfaces;
using Katio.Data.Models;
namespace Katio.Business.Services;
using Katio.Business.Utilities;

public class BookService : IBookService{
    /// <summary>
    /// Busca todos los libres de la base de datos
    /// </summary>
    /// <returns>Lista de string </returns>

    
    public async Task<IEnumerable<Books>> GetAllBooks(){
    
        return Utilities.Utilities.CreateABooksList();
    }

    public async Task<IEnumerable<Books>> GetById(int id){
        ///if(id <= 0){
        ///    return new List<Book>();
        ///}
        
        var list = Utilities.Utilities.CreateABooksList();

        for(int i = 0; i < list.Count; i++){
            if(list[i].Id == id){
                var list = new List<Books>();
                listBooks.Add(list[i]);

                return listBooks;
            }
        }
        


    }
    
}