using System;


namespace FermatP
{
    class Exponenciacao
    {
        public Byte Base { get; private set;}
        public Byte Expoente { get; private set; }
        public ulong Potencia { get; private set; }

        public Exponenciacao(Byte _base)
        {
            this.Base = _base;
            this.Potencia = 1;
        }

        public void setExpoente(Byte _expoente)
        {
            this.Expoente = _expoente;
            calcPotencia();
        }

        private void calcPotencia()
        {
            Byte byte0 = 0;
            Byte byte1 = 1;
            Byte _expoente = this.Expoente;

            while (_expoente > byte0)
            {
                this.Potencia = multiplicar(this.Potencia);
                _expoente -= byte1;
            }
        }

         private ulong multiplicar(ulong _potencia)
        {
            return _potencia * this.Base;
        }

        public override string ToString()
        {
            return $"{this.Base}^{this.Expoente} = {this.Potencia}";
        }
    }
}
