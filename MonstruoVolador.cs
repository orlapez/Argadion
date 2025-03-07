using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Argadion
{
  public  class MonstruoVolador: Monstruo, IVolador
    {

        public MonstruoVolador(string Nombre, TipoAtaque tipoAtaque) : base(Nombre, tipoAtaque)
        {

        }

        public void Volar()
        {

            Console.WriteLine($"{Nombre} está volando");


        }


    }
}
