using System;


namespace AGENDA
{
    internal class Telefone
    {
        private string numero;
        private Pessoa pessoa;


        public Telefone(string numero)
        {
            this.numero = numero;
        }

        public string Numero
        {
            get { return numero; }
        }

        public Pessoa Pessoa
        {
            get { return pessoa; }
            set { pessoa = value; }
        }
    }
}
