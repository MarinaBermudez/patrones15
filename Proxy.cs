using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Animacion
{
    // Animacion.cs
    public interface Animacion
    {
        void dibuja();
        void clic();
    }

    // AnimacionProxy.cs
    public class AnimacionProxy : Animacion
    {
        protected Video video = null;
        protected string foto = "Mostrar la foto";

        public void clic()
        {
            if (video == null)
            {
                video = new Video();
                video.carga();
            }
            video.reproduce();
        }

        public void dibuja()
        {
            if (video != null)
                video.dibuja();
            else
                dibuja(foto);
        }

        public void dibuja(string foto)
        {
            Console.WriteLine(foto);
        }
    }

    // Video.cs
    public class Video : Animacion
    {
        public void clic() { }

        public void dibuja()
        {
            Console.WriteLine("Mostrar el vídeo");
        }

        public void carga()
        {
            Console.WriteLine("Cargar el vídeo");
        }

        public void reproduce()
        {
            Console.WriteLine("Reproducir el vídeo");
        }
    }

    // VistaVehiculo.cs
    public class VistaVehiculo
    {
        static void Main(string[] args)
        {
            Animacion animacion = new AnimacionProxy();
            animacion.dibuja();
            animacion.clic();
            animacion.dibuja();
        }
    }
}
