using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Models;


namespace ProEventos.API.Controllers
 {
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _evento = new Evento[] {
            new Evento() {
                EventoId = 1,
                Tema = "Angular 11 e .NET 6",
                Local = "Belo Horizonte",
                Lote = "1 Lote",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                ImagemURL = "Foto.png"
             },
            new Evento() {
                EventoId = 2,
                Tema = "Angular e suas atividades",
                Local = "São Paulo",
                Lote = "2 Lote",
                QtdPessoas = 1050,
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                ImagemURL = "Foto.png"
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
            return _evento.Where(evento => evento.EventoId == id ); 
        }

        [HttpPost]
        public string Post()
        {
            return "Retorno de Post";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Retorno de Put com id = {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Retorno de Delete com id = {id}";
        }
    }
    }

