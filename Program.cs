using ProjetoBibliotecaDeJogos.Classes;
using System;
using System.Collections.Generic;

namespace ProjetoBibliotecaDeJogos
{
    class Program
    {
        static List<Jogo> listaJogos = new List<Jogo>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("************ BIBLIOTECA DE JOGOS ************");
                Console.WriteLine("1 - Adicionar Jogo");
                Console.WriteLine("2 - Listar Jogos ");
                Console.WriteLine("3 - Editar Jogo ");
                Console.WriteLine("4 - Remover Jogo ");
                Console.WriteLine();
                Console.Write("Selecione sua opção: ");
                string opcao = Console.ReadLine();
                bool resposta;
                switch (opcao)
                {
                    case "1":
                        resposta = AdicionarJogo();
                        if(resposta == false)
                        {
                            Console.WriteLine("Erro ao cadastrar jogo, pressione ENTER para continuar...");
                            Console.ReadLine();
                        }
                        break;

                    case "2":
                        resposta = ListarJogos();
                        break;

                    case "3":
                        resposta = EditarJogo();
                        break;

                    case "4":
                        resposta = DeletarJogo();
                        break;

                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }
            
        }
        public static bool AdicionarJogo()
        {
            Console.Clear();
            Console.WriteLine("******** ADICIONAR JOGOS ********");
            Console.WriteLine("");

            Console.Write("Titulo do jogo: ");
            string titulo = Console.ReadLine();

            Console.Write("Ano do jogo: ");
            int ano = Convert.ToInt32(Console.ReadLine());

            Console.Write("Genero do jogo: ");
            string genero = Console.ReadLine();

            Console.Write("Número máximo de jogadores: ");
            int maxJogadores = Convert.ToInt32(Console.ReadLine());

            Console.Write("Pontuação do jogo no MetaCritic: ");
            int metaCritic = Convert.ToInt32(Console.ReadLine());

            if(titulo == "")
            {
                return false;
            }

            if(ano < 1950)
            {
                return false;
            }
            if(metaCritic > 100 || metaCritic < 0)
            {
                return false;
            }

            Jogo novoJogo = new Jogo(titulo, ano, genero, maxJogadores, metaCritic);

            listaJogos.Add(novoJogo);

            Console.WriteLine("");

            Console.WriteLine("Jogo salvo com sucesso!");
            Console.Beep();

            return true;
        }
        public static bool ListarJogos()
        {
            Console.Clear();
            Console.WriteLine("******** LISTA DE JOGOS ********");
            Console.WriteLine("");

            foreach (Jogo jogo in listaJogos)
            {
                Console.Write("Título: ");
                Console.WriteLine(jogo.GetNome());

                Console.Write("Ano: ");
                Console.WriteLine(jogo.GetAno());

                Console.Write("Genero: ");
                Console.WriteLine(jogo.GetGenero());

                Console.Write("Máximo de jogadores: ");
                Console.WriteLine(jogo.GetMaxJogadores());

                Console.Write("Pontuação no MetaCritic: ");
                Console.WriteLine(jogo.GetMetaCritic());

                Console.WriteLine("");

                Console.WriteLine("****************");

                Console.WriteLine("");

            }
            Console.Write("Pressione ENTER para voltar ao menu...");
            Console.ReadLine();

            return false;
        }
        public static bool EditarJogo()
        {
            Console.Clear();
            Console.WriteLine("******** EDITAR JOGOS ********");
            Console.WriteLine("");

            Console.Write("Digite o nome do jogo que deseja editar: ");
            string nome_jogo = Console.ReadLine();
            foreach(Jogo jogo in listaJogos)
            {
                if(jogo.GetNome() == nome_jogo)
                {
                    Console.Write("Novo título: ");
                    string novo_titulo = Console.ReadLine();

                    jogo.nome = novo_titulo;

                    Console.Write("Novo ano: ");
                    int novo_ano = Convert.ToInt32(Console.ReadLine());

                    jogo.ano = novo_ano;

                    Console.Write("Novo gênero: ");
                    string novo_genero = Console.ReadLine();

                    jogo.genero = novo_genero;

                    Console.Write("Novo número de jogadores: ");
                    int novo_numMaxJogadores = Convert.ToInt32(Console.ReadLine());

                    jogo.maxJogadores = novo_numMaxJogadores;

                    Console.Write("Nova pontuação no MetaCritic: ");
                    int novo_metaCritic = Convert.ToInt32(Console.ReadLine());

                    jogo.metaCritic = novo_metaCritic;
                }
            }
            return true;
        }
        public static bool DeletarJogo()
        {
            Console.Clear();
            Console.WriteLine("******** DELETAR JOGOS ********");
            Console.WriteLine("");

            Console.Write("Digite o nome do jogo que deseja deletar: ");
            string nome_jogo = Console.ReadLine();

            foreach (Jogo jogo in listaJogos)
            {
                if (jogo.GetNome() == nome_jogo)
                {
                    listaJogos.Remove(jogo);
                    Console.WriteLine("Jogo deletado com sucesso!");
                    break;
                }
     
            }

            Console.Write("Pressione ENTER para voltar ao menu...");
            Console.ReadLine();

            return true;
        }
    }
}
