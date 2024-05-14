using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public delegate void DelegadoString(string msg);
    public class Persona
    {

        public event DelegadoString EventoString;
        private string nombre;
        private string apellido;

        public Persona()
        {
            
        }


        public string Nombre 
        { get => nombre;

            set
            {

                nombre = value;

                if(EventoString is not null)
                {
                    EventoString.Invoke($"El nuevo nombre es: {nombre}");
                }
            }
        }
        public string Apellido 
        { 
            get => apellido;

            set
            {

                nombre = value;

                if (EventoString is not null)
                {
                    EventoString.Invoke($"El nuevo nombre es: {nombre}");
                }
            }
        }

        public string Mostrar()
        {
            return nombre + " " + apellido;
        }


    }
}
