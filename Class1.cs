using System;
using System.Collections.Generic;
using System.Text;

namespace FermatP
{
    class Class1
    {
        public Byte Base { get; private set;}
        public Byte Expoente { get; private set; }
        public ulong Potencia { get; private set; }

        public Class1(Byte _base)
        {
            this.Base = _base;
        }

        public void setExpoente(Byte _expoente)
        {
            this.Expoente = _expoente;
            calcPotencia();
        }

        private void calcPotencia()
        {
            this.Potencia = 0;
            ulong teste = 0;
        }
    }
}
