using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
En el mundo mítico de Argadion, existen criaturas poderosas conocidas como Monstruos Míticos, cada uno con habilidades sobrenaturales únicas que los hacen temidos por todos los habitantes del reino. Estos monstruos pueden caminar, volar, nadar y usar ataques elementales como fuego, hielo o veneno.

Tu misión como Maestro de Criaturas Míticas es programar un sistema en Java que modele estos monstruos y permita controlar sus habilidades de manera eficiente. Necesitarás diseñar una jerarquía de monstruos que implemente diferentes habilidades a través de clases abstractas, interfaces y enumeraciones.

*/
namespace Argadion
{
  public abstract  class Monstruo
    {

        protected string Nombre;
        protected TipoAtaque tipoAtaque;


        public Monstruo(string Nombre, TipoAtaque tipoAtaque)
        {
        

            this.Nombre = Nombre;
                
        }


        public void Caminar()
        {

            Console.WriteLine($"{Nombre} está caminando");

        }




    }
}
