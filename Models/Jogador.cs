using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LabSemana5.Models
{
    public class Jogador
    {
        public string nome {get; set;} = null!;
        public string posição {get; set;} = null!;
        public int idade {get; set;}
        public double altura {get; set;}
        public double peso {get; set;}
        public bool titular {get; set;}
        
    }
}