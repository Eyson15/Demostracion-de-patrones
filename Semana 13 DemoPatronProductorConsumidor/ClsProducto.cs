using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_13_DemoPatronProductorConsumidor
{
    public class ClsProducto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime HoraPreparacion { get; set; }

        public ClsProducto(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
            HoraPreparacion = DateTime.Now;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Nombre: {Nombre}, Preparado: {HoraPreparacion}";
        }
    }

}
