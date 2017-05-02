using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace api2.Models
{
    public class Producte
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Categoria { get; set; }
        public double Preu { get; set; }
    }
}