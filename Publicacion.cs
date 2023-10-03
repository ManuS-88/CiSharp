using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiShparp
{
    internal class Publicacion
    {

        private static int publicacionID;

        //PROPIEDADES

        protected int ID { get; set; }

        protected string Titulo { get; set; }

        protected string Autor { get; set; }

        protected bool EsPublico { get; set; }

        //CONSTRUCTOR POR DEFECTO

        public Publicacion() 
        {
            ID = CrearID();
            Titulo = "Mi primera publicacion";
            EsPublico = true;
            Autor = "Juan";
        }

        //CONSTRUCTOR PARAMETRIZADO

        public Publicacion(string titulo, bool esPublico, string autor) 
        {
            this.ID = CrearID();
            this.Titulo = titulo;
            this.Autor = autor;
            this.EsPublico = esPublico;
        }

        //METODO PARA CREAR ID

        protected int CrearID()
        {
            return ++publicacionID;
        }


        //METODO PARA EDITAR PUBLICACIONES

        public void Editar(string titulo, bool esPublico) 
        {
            this.Titulo = titulo;
            this.EsPublico = esPublico;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - Creado por: {2}", this.ID, this.Titulo, this.Autor);
        }

    }

}
