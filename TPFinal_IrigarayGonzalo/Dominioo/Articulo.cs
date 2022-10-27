using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominioo
{
    public class Articulos
    {
        public object Marca;

        public int Id { get; set; }

        public string Codigo { get; set; }

        // [DisplayName("Nombre")]
        public string Nombre { get; set; }

        // [DisplayName("Descripción")]
        public string Descripcion { get; set; }

        //[DisplayName("Imagen")]
        public string ImagenUrl { get; set; }

        public Marca Marcas { get; set; }
        public Categoria Categoria { get; set; }

        public Decimal Precio { get; set; }

    }

}
