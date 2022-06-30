using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LabSemana5.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JogadorController : ControllerBase
    {
        // GET: api/Jogador
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Jogador/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Jogadora
        [HttpPost]
        public string escalação (string nome,string posição,double altura,double peso)

        {
            var p = Convert.ToInt16(peso);
            var a = Convert.ToInt16(altura); 
            var imc = p / (a*a);
            return nome+" atua de "+posição+" e tem IMC igual a "+imc;
        }

        // PUT: api/Jogador/5
        [HttpPut("{idade}")]
        public string classe(int idade)
        {
           int i;
            i = idade;

            if (i>=18)
              {return"Jogador Profissional";}
            else if ( i<18||i>12)
              {return"Jogador Juvenil";}
            else
              {return"Jogador Infantil";}
            
        }

        // DELETE: api/Jogador/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
