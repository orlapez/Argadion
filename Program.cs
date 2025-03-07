using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Argadion
{
    class Program
    {

        public static void Main(string[] args)
        {

            Monstruo dragon = new MonstruoVolador("Dragón de fuego", TipoAtaque.FUEGO);
            Monstruo Leviatan = new MonstruoNadador("Leviatán", TipoAtaque.HIELO);
            Monstruo kraken = new MonstruoNadadorVolador("Kraken", TipoAtaque.VENENO);

            dragon.Caminar();
            ((IVolador)dragon).Volar();

            Leviatan.Caminar();
            ((INadador)Leviatan).Nadar();

            kraken.Caminar();
            ((IVolador)kraken).Volar();
            ((INadador)kraken).Nadar();


        }
    }

}
