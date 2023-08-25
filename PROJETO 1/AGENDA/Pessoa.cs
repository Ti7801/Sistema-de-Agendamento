using System;


namespace AGENDA
{
    internal class Pessoa
    {
        private string nome;
        List<Telefone> telefones;

        public Pessoa(string nome)
        {
            this.nome = nome;
            telefones = new List<Telefone>(); //tornando a lista nula ---pra nao ficar vazia
        }
 
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public List<Telefone> Telefones
        {
            get { return telefones; }
        }

        public void AdicionarTelefone(Telefone t)
        {
            telefones.Add(t);
        }

        public void RemoverTelefone(Telefone t)
        {
            telefones.Remove(t);
        }

        public Telefone localizarTelefone(string numero)
        {
            foreach(Telefone telefone in telefones)
            {
                if (telefone.Numero == numero)
                {
                    return telefone;
                }         
            }
            return null;
        }


    }
}
