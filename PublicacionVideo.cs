using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiShparp
{
    internal class PublicacionVideo:Publicacion
    {
        //VARIABLES

        protected bool seReproduce = false;
        protected int duracionActual = 0;

        Timer reloj;

        //PROPIEDADES
        public string? UrlVideo { get; set; }
        public int Duracion { get; set; }

        public PublicacionVideo() { }

        public PublicacionVideo(string titulo, string autor, string? urlVideo, int duracion, bool esPublico) 
        {
            this.ID = CrearID();
            this.Titulo = titulo;
            this.Autor = autor;
            this.EsPublico = esPublico;
            this.UrlVideo = urlVideo;
            this.Duracion = duracion;
        }

        public string ToStringVideo()
        {
            return String.Format("{0} - {1} - Creado por: {2} - En la direccion: {3} - Con duracion: {4}", this.ID, this.Titulo, this.Autor, this.UrlVideo, this.Duracion);
        }

        public void Play()
        {
            if (!seReproduce)
            {
                seReproduce = true;
                Console.WriteLine("Reproduciondo");
                reloj = new Timer(Reproduccion, null, 0, 1000);
            }
        }

        public void Stop()
        {
            if (seReproduce)
            {
                seReproduce = false;
                Console.WriteLine("Detenido en {0}",duracionActual);
                duracionActual = 0;
                reloj.Dispose();
            }
        }

        private void Reproduccion(Object objeto)
        {
            if (duracionActual < Duracion)
            {
                duracionActual++;
                Console.WriteLine("Video en {0}",duracionActual);
                GC.Collect();
            }
            else
            {
                Stop();
            }
        }


    }
}
