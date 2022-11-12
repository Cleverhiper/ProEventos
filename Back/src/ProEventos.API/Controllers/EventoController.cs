using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventoController : ControllerBase
{
    public IEnumerable<Evento> _evento = new Evento[]{
        new Evento() {
            EventoId = 1,
            Tema = "Angular 11 e .Net 5",
            Local = "Sertãozinho",
            Lote = "1° Lote",
            QtdPessoas = 250,
            DataEvento = DateTime.Now.AddDays(2).ToString(),
            ImageURL = "foto.png"
        },
        new Evento() {
            EventoId = 2,
            Tema = "Angular 12 e .Net 5",
            Local = "Ribeirão Preto",
            Lote = "1° Lote",
            QtdPessoas = 250,
            DataEvento = DateTime.Now.AddDays(2).ToString(),
            ImageURL = "foto.png"
        }
       };
    public EventoController()
    {
        
    }

    [HttpGet]
    public IEnumerable<Evento> Get()
    {
       return _evento;
    }    

    [HttpGet("{id}")]
    public IEnumerable<Evento> GetById(int id)
    {
       return _evento.Where(x => x.EventoId == id);
    }    

    [HttpPost]
    public string Post()
    {
        return "Exemplo de Post";
    }
    
    [HttpPut("{id}")]
    public string Put(int id)
    {
        return $"Exemplo do Put com id = {id}";
    }

    [HttpDelete("{id}")]
    public string Delete (int id)
    {
        return $"Exemplo de Delete com id = {id}";
    }

   
}
