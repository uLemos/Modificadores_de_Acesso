using System;
using System.Collections.Generic;
using System.Text;

namespace ClasseHerdada
{
    public class MinhaClasseProtegida
    {
        protected int idadeProtegida;
        protected internal int idadeInternaProtegida;

        void Call()
        {
            idadeProtegida = 10;
            idadeInternaProtegida = 20;
        }
    }
}
