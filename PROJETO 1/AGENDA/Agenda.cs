using System;

namespace AGENDA
{
    internal class Agenda
    {
        private string nome;
        List<Pessoa> pessoas;
        List<Telefone> telefones;

        public Agenda(string nome)
        {
            this.nome = nome;
            pessoas = new List<Pessoa>();
            telefones = new List<Telefone>();
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public List<Pessoa> Pessoas
        {
            get { return pessoas; }
        }

        public List<Telefone> Telefones
        {
            get { return telefones; }
        }

        public void AdicionarPessoa(Pessoa p)
        {
            pessoas.Add(p);
        }

        public void RemoverPessoa(Pessoa p)
        {
            pessoas.Remove(p);  
        }

        public Pessoa LocalizarPessoa(string nome)
        {
            foreach (Pessoa pessoa in pessoas)
            {
                if (pessoa.Nome == nome)
                {
                    return pessoa;  
                }
            }
            return null;
        }

        public void AdicionarTelefone(Telefone t)
        {
            telefones.Add(t);
        }

        public void RemoverTelefone(Telefone t)
        {
            telefones.Remove(t);
        }

        public Telefone LocalizarTelefone(string numero)
        {
            foreach (Telefone telefone in telefones)
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
