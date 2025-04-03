using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD
{
    public class Cerveza
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Estilo { get; set; }
        public double Alcohol { get; set; }
        public double Precio { get; set; }

        public Cerveza(int id, string name, string estilo, double alcohol, double precio)
        {
            Id = id;
            Name = name;
            Estilo = estilo;
            Alcohol = alcohol;
            Precio = precio;
        }

        public Cerveza()
        {
        }
    }
}
