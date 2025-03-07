using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Argadion
{
    public class MonstruoNadador : Monstruo, INadador
    {

        public MonstruoNadador(string Nombre, TipoAtaque tipoAtaque) : base(Nombre, tipoAtaque)
        {
                
        }
        public void Nadar()
        {
            Console.WriteLine($"{Nombre} está nadando");
        }
    }
}
