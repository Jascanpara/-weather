using SegundoParcial.Models;

namespace SegundoParcial.Buiders
{
    public abstract class CBuilder
    {
        // Protected para que las clases que implementen puedan acceder
        protected Citi _Ciudad;

        public Citi ObtenerCuidad() { return _Ciudad; }

        // Un paso para cada una de las propiedades
        public virtual void PasoNombre()
        {

        }
        public virtual void PasoTemperatura()
        {

        }

        public virtual void PasoMax()
        {

        }

        public virtual void PasoMin()
        {

        }

        public virtual void PasoHum()
        {

        }
        public virtual void PasoVien()
        {

        }
        public virtual void PasoLunes()
        {

        }
        public virtual void PasoMartes()
        {

        }
        public virtual void PasoMiercoles()
        {

        }

        public virtual void PasoJueves()
        {

        }
    }
}
