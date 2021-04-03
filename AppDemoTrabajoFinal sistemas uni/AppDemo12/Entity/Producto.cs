using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDemo12.Entity
{
    public class Producto
    {
        //definir propiedades
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Fecha { get; set; }
        public string Categoria { get; set; }
        public string Proveedor { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
    }
}
