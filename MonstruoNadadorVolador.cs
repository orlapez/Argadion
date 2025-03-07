using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Argadion
{
    public class MonstruoNadadorVolador : Monstruo, IVolador, INadador
    {


        public MonstruoNadadorVolador(string Nombre, TipoAtaque tipoAtaque) : base(Nombre, tipoAtaque)
        {
            
        }
        public void Nadar()
        {
            Console.WriteLine($"{Nombre} está nadando");
        }

        public void Volar()
        {
            Console.WriteLine($"{Nombre} está volando");
        }
    }
}
