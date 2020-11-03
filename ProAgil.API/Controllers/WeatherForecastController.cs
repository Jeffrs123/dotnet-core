using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProAgil.API.Data;
using ProAgil.API.Model;

namespace ProAgil.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        /*
        
        private static readonly string[] Summaries = new[]
        
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }
        
        */

        public readonly DataContext _context;

        public WeatherForecastController(DataContext context)
        {
            _context = context;
        }

        
        // GET eventos
        [HttpGet]
        public IEnumerable<Evento> Get()
        {

            return _context.Eventos.ToList();
            /*  
            return new Evento [] {
                new Evento() {
                    EventoId = 1,
                    Tema = "Angular e .NET Core",
                    Local = "São Paulo",
                    Lote = "1º Lote",
                    QtdPessoas = 250,
                    DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy")
                },
                new Evento() {
                    EventoId = 2,
                    Tema = "Angular e Suas Novidades",
                    Local = "Belo Horizonte",
                    Lote = "5º Lote",
                    QtdPessoas = 10,
                    DataEvento = DateTime.Now.AddDays(5).ToString("dd/MM/yyyy")
                }
            };

            */
        }

        // GET evento/5
        [HttpGet("{id}")]
        public ActionResult<Evento> Get(int id)
        {

            return _context.Eventos.FirstOrDefault( x => x.EventoId == id);
            
            /*
            return new Evento [] {
                new Evento() {
                    EventoId = 1,
                    Tema = "Angular e .NET Core",
                    Local = "São Paulo",
                    Lote = "1º Lote",
                    QtdPessoas = 250,
                    DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy")
                },
                new Evento() {
                    EventoId = 2,
                    Tema = "Angular e Suas Novidades",
                    Local = "Belo Horizonte",
                    Lote = "5º Lote",
                    QtdPessoas = 10,
                    DataEvento = DateTime.Now.AddDays(5).ToString("dd/MM/yyyy")
                }
            }.FirstOrDefault( x => x.EventoId == id);

            */
        
        }


        /*

         [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }


        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2"};
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }


        */

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }


        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

    }
}
