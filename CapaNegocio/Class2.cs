using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaNegocio;

namespace CapaNegocio
{
    public class Examen : Evaluacion
    {
        public Examen()
        {
            Tipo = "Examen"; // Establecemos el valor de Tipo en el constructor  
        }
    }
}
