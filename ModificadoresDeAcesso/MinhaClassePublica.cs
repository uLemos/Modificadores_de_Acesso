using System;
using System.Collections.Generic;
using System.Text;

namespace ClasseHerdada
{
    public class MinhaClassePublica 
    {
        public int idadePublica;

        public void Call()
        {
            var classeInterna = new MinhaClasseInterna();
            classeInterna.idadeInterna = 10;

            var privada = new MinhaClassePrivada();

            var classeProtegida = new MinhaClasseProtegida();
            //idadeProtegida = 15; // Ela é protegida, só se acessa caso seja herdada.
            classeProtegida.idadeInternaProtegida = 2;
        }



    }
}
