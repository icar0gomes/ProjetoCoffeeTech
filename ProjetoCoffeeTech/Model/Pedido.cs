using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCoffeeTech.Model
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime DataEmissao { get; set; }
        public string Status { get; set; }
       
    }
}

