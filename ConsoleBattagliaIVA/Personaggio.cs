using System;

namespace ConsoleBattagliaIVA
{
    internal class Personaggio
    {
        private string v;
        private object istanza;

        public Personaggio(string v, object istanza)
        {
            this.v = v;
            this.istanza = istanza;
        }

        public object Nome { get; internal set; }

        internal object Attacca(Personaggio p2)
        {
            throw new NotImplementedException();
        }
    }
}