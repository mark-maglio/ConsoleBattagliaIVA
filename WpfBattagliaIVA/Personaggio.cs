using System;

namespace WpfBattagliaIVA
{
    internal class Personaggio
    {
        internal readonly object Vita;
        internal readonly object Esperienza;
        private string text;
        private Razza razza;

        public Personaggio(string text, Razza razza)
        {
            this.text = text;
            this.razza = razza;
        }

        public object Nome { get; internal set; }
        public object Razza { get; internal set; }

        internal bool Attacca(Personaggio p2)
        {
            throw new NotImplementedException();
        }
    }
}