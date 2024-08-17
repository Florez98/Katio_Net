using System.Data.Common;
using System.Reflection;
using Katio.Business.Services;
using Katio.Data.Models;

namespace Katio.Business.Utilities;
public static class Utilities{
    public static List<Books> CreateABooksList(){
        List<Books> bookList = new List<Books>(){
           
            new Books(){
                Title = "Cien años de soledad",
                ISBN10 = "842047183",
                ISBN13 =  "978-842047183",
                Edition= "RAE Obra Académica",
                DeweyInde = "800",
                Published = new DateTime(1967, 06, 05),
                Id = 1
            },
            new Books(){
                Title = "Huellas",
                ISBN10 = "958427275",
                ISBN13 =  "978-958427275",
                Edition= "Planeta",
                DeweyInde = "800",
                Published = new DateTime(2019, 06, 05),
                Id = 2
            },
            new Books(){
                Title = "Huellas",
                ISBN10 = "958427275",
                ISBN13 =  "978-958427275",
                Edition= "Planeta",
                DeweyInde = "800",
                Published = new DateTime(2019, 06, 05),
                Id = 3
            }

        };
        return bookList;
    }

}