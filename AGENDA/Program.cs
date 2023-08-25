using System;
using System.Globalization;


namespace AGENDA
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciando um objeto do tipo Agenda
            Agenda contatos = new Agenda("contatos");

            // Instanciando objetos telefones
            Telefone telefone1 = new Telefone("(83) 98754-2514");
            Telefone telefone2 = new Telefone("(83) 98864-2819");
            Telefone telefone3 = new Telefone("(83) 98728-2933");
            Telefone telefone4 = new Telefone("(83) 98620-3117");
            Telefone telefone5 = new Telefone("(83) 98696-4412");
            Telefone telefone6 = new Telefone("(83) 98891-2185");

            //Adicionando os telefones no objeto contatos do tipo Agenda
            contatos.AdicionarTelefone(telefone1);
            contatos.AdicionarTelefone(telefone2);
            contatos.AdicionarTelefone(telefone3);
            contatos.AdicionarTelefone(telefone4);
            contatos.AdicionarTelefone(telefone5);
            contatos.AdicionarTelefone(telefone6);
            
            // Instanciando o primeiro contato - Adicionando o contato e seus telefones na Agenda contatos
            Pessoa pessoa1 = new Pessoa("João");
            contatos.AdicionarPessoa(pessoa1);
            pessoa1.AdicionarTelefone(telefone1);
            pessoa1.AdicionarTelefone(telefone2);
            telefone1.Pessoa = pessoa1;
            telefone2.Pessoa = pessoa1;

            // Instanciando o segundo contato - Adicionando o contato e seus telefones na Agenda contatos
            Pessoa pessoa2 = new Pessoa("Maria");
            contatos.AdicionarPessoa(pessoa2);
            pessoa2.AdicionarTelefone(telefone3);
            pessoa2.AdicionarTelefone(telefone4);
            telefone3.Pessoa = pessoa2;
            telefone4.Pessoa = pessoa2;

            // Instanciando o terceiro contato - Adicionando o contato e seus telefones na Agenda contatos
            Pessoa pessoa3 = new Pessoa("José");
            contatos.AdicionarPessoa(pessoa3);
            pessoa3.AdicionarTelefone(telefone5);
            pessoa3.AdicionarTelefone(telefone6);
            telefone5.Pessoa = pessoa3;
            telefone6.Pessoa = pessoa3;
            
            // Imprimindo a Agenda com todas as pessoas e telefones
            foreach(Pessoa pessoa in contatos.Pessoas)
            {
                Console.WriteLine(pessoa.Nome);

                foreach(Telefone telefone in pessoa.Telefones)
                {
                    Console.WriteLine(telefone.Numero);
                }
            }

            Console.WriteLine();
            Console.WriteLine("***************************************************");
            Console.WriteLine();

            //Localizar na agenda o João  e imprimi-lo com seus telefones!!

            Pessoa objeto_pessoa = contatos.LocalizarPessoa("João");

            Console.WriteLine(objeto_pessoa.Nome);

            foreach (Telefone telefone in objeto_pessoa.Telefones)
            {
                Console.WriteLine(telefone.Numero);
            }

            Console.WriteLine();
            Console.WriteLine("***************************************************");
            Console.WriteLine();


            //Localizar na agenda o telefone (83) 98620-3117 e imprimi-lo com o nome da pessoa

            Telefone tel = contatos.LocalizarTelefone("(83) 98620-3117");

            Pessoa pes_obj = tel.Pessoa;

            Console.WriteLine(pes_obj.Nome);
            Console.WriteLine(tel.Numero);


            Console.WriteLine();
            Console.WriteLine("***************************************************");
            Console.WriteLine();

            // Remover da agenda o telefone (83) 98620-3117

           
            contatos.RemoverTelefone(telefone4);
          

            Console.WriteLine();
            Console.WriteLine("***************************************************");
            Console.WriteLine();

            // Imprimir a agenda com todas as pessoas e telefones

            foreach(Pessoa TodasPessoas in contatos.Pessoas)
            {
                Console.WriteLine(TodasPessoas.Nome);
            }
            Console.WriteLine();
            foreach (Telefone TodosTelefones in contatos.Telefones)
            {
                Console.WriteLine(TodosTelefones.Numero);
            }
        }
    }
}
