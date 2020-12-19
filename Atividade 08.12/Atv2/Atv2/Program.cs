using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Atv2
{
    class Program
    {
        static void Main(string[] args)
        {

            Contatos pessoas = new Contatos();

            pessoas.adicionar(new Contato("miemail1", "Maria", "1398820", new Data(03,07,2001)));
            pessoas.adicionar(new Contato("miemail2", "Roberta", "135410", new Data(13, 02, 2001)));
            pessoas.adicionar(new Contato("meuemail3", "Antonio", "139920", new Data(23, 04, 2001)));
            pessoas.adicionar(new Contato("miemail4", "João", "19872", new Data(12, 03, 2001)));

            Console.WriteLine(pessoas.pesquisar("meuemail").ToString());

            Console.WriteLine(pessoas.pesquisar("meuemail").Email != "meuemail" ? "Nao encontrado" : "Encontrado");


            pessoas.listarContatos();
            Console.WriteLine(pessoas.remover(new Contato("meuemail", "Antonio", "139920", new Data(23, 04, 2001))) ? "Removido" : "Não Encontrado");
            pessoas.listarContatos();
            Console.WriteLine(pessoas.remover(new Contato("meuemail", "Antonio", "139920", new Data(23, 04, 2001))) ? "Removido" : "Não Encontrado");
            pessoas.listarContatos();

            int escolha = -1;
            string email, nome, telefone;
            int dia, mes, ano;
            Data dtNasc;

            while (escolha != 0)
            {
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("0.Sair");
                Console.WriteLine("1.Adicionar contato");
                Console.WriteLine("2.Pesquisar contato");
                Console.WriteLine("3.Alterar contato");
                Console.WriteLine("4.Remover contato");
                Console.WriteLine("5.Listar contatos");
                Console.Write("Opção escolhida: ");
                escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 0:
                        break;

                    case 1:
                        Console.Write("Insira o email: ");
                        email = Console.ReadLine();
                        Console.Write("Insira o nome: ");
                        nome = Console.ReadLine();
                        Console.Write("Insira o telefone : ");
                        telefone = Console.ReadLine();
                        Console.Write("Insira o dia que você nasceu: ");
                        dia = int.Parse(Console.ReadLine());
                        Console.Write("Insira o mes que você nasceu: ");
                        mes = int.Parse(Console.ReadLine());
                        Console.Write("Insira o ano que você nasceu: ");
                        ano = int.Parse(Console.ReadLine());

                        dtNasc = new Data(dia, mes, ano);
                        pessoas.adicionar(new Contato(email, nome, telefone, dtNasc));

                    break;

                    case 2:
                        Console.Write("Insira o email a ser pesquisado: ");
                        email = Console.ReadLine();
                        Console.WriteLine(pessoas.pesquisar(email).Email != email ? "Nao encontrado" : pessoas.pesquisar(email).ToString());
                        break;


                    case 3:
                        Console.Write("Insira o email: ");
                        email = Console.ReadLine();
                        Console.Write("Insira o nome: ");
                        nome = Console.ReadLine();
                        Console.Write("Insira o telefone : ");
                        telefone = Console.ReadLine();
                        Console.Write("Insira o dia que você nasceu: ");
                        dia = int.Parse(Console.ReadLine());
                        Console.Write("Insira o mes que você nasceu: ");
                        mes = int.Parse(Console.ReadLine());
                        Console.Write("Insira o ano que você nasceu: ");
                        ano = int.Parse(Console.ReadLine());

                        dtNasc = new Data(dia, mes, ano);
                        pessoas.alterar(new Contato(email, nome, telefone, dtNasc));

                        break;
                    case 4:
                        Console.Write("Insira o email: ");
                        email = Console.ReadLine();
                        Console.Write("Insira o nome: ");
                        nome = Console.ReadLine();
                        Console.Write("Insira o telefone : ");
                        telefone = Console.ReadLine();
                        Console.Write("Insira o dia que você nasceu: ");
                        dia = int.Parse(Console.ReadLine());
                        Console.Write("Insira o mes que você nasceu: ");
                        mes = int.Parse(Console.ReadLine());
                        Console.Write("Insira o ano que você nasceu: ");
                        ano = int.Parse(Console.ReadLine());

                        dtNasc = new Data(dia, mes, ano);
                        
                        Console.WriteLine(pessoas.remover(new Contato(email, nome, telefone, dtNasc)) ? "Removido" : "Não Encontrado");

                        break;
                    case 5:
                        pessoas.listarContatos();
                        break;
                }
            }
        }
    }
}
