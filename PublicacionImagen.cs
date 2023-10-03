using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiShparp
{
    internal class PublicacionImagen : Publicacion
    {
        //PROPIEDAD NUEVA

        public string? UrlImagen { get; set; }

        //CONSTRUCTOR POR DEFECTO

        public PublicacionImagen() { }

        //CONSTRUCTOR PARAMETRIZADO

        public PublicacionImagen(string titulo,string autor, string urlImagen, bool esPublico)
        {
            this.ID=CrearID();
            this.UrlImagen=urlImagen;
            this.Titulo=titulo;
            this.Autor=autor; 
            this.EsPublico=esPublico;
        }

        public string ToStringImagen()
        {
            return String.Format("{0} - {1} - Creado por: {2} - En la direccion: {3}", this.ID, this.Titulo, this.Autor, this.UrlImagen);
        }
    }
}
