using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01
{
    class Veterinaria
    {
        public void AceptarAnimales(Animal[] pAnimales)
        {
            foreach (Animal animal in pAnimales)
            {
                animal.HacerRuido();
            }
        }
    }
}
