
using Microsoft.AspNetCore.Mvc;
using Data.Models;
using katio.Business.Interfaces;
using Katio.Business.Interfaces;
using Microsoft.AspNetCore.Http.Timeouts;

namespace katio.API.Controllers;

[Route("api/[controller]")]
[ApiController]

public class BooksControllers : ControllerBase{
   private readonly IBookService _bookService;
   public BooksControllers(IBookService bookService){
        _bookService = bookService;
   }
}

[HttpGet]
[Route("GetAllBooks")]

public async Task<IActionResult> Index(){
    var response = await _bookService.GetAllBooks();
    return response.Count() > 0 ? Ok(response) : StatusCode(StatusCodes.Status204NoContent, "No se encontró");
}

[HttpPost]
[Route("GetByid")]
public async Task<IActionResult> GetById(int id){
    var response = await _bookService.GetById(id);
    return response.Count() > 0 ? Ok(response) : StatusCode(StatusCodes.Status204NoContent, "No se encontró");
}