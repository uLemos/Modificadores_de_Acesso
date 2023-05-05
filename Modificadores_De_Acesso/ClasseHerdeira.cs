using ClasseHerdada;
using System;
using System.Collections.Generic;
using System.Text;

namespace Modificadores_De_Acesso
{
    public class ClasseHerdeira : MinhaClasseProtegida
    {
        public void Call()
        {
            var classePublica = new MinhaClassePublica();
            classePublica.idadePublica = 10;

            var classeInterna = new MinhaClasseInterna();

            var classeProtegida = new MinhaClasseProtegida();
            idadeProtegida = 15;

        }

    }
}
