using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoBibliotecaDeJogos.Classes
{
    internal class Jogo
    {
        public string nome;

        public int ano;

        public string genero;

        public int maxJogadores;

        public int metaCritic;

        public Jogo(string nome, int ano, string genero, int maxJogadores, int metaCritic)
        {
            this.nome = nome;
            this.ano = ano;
            this.genero = genero;
            this.maxJogadores = maxJogadores;
            this.metaCritic = metaCritic;
        }
        public Jogo(string nome, int ano, string genero, int maxJogadores)
        {
            this.nome = nome;
            this.ano = ano;
            this.genero = genero;
            this.maxJogadores = maxJogadores;
        }
        public string GetNome()
        {
            return nome;
        }
        public int GetAno()
        {
            return ano;
        }
        public string GetGenero()
        {
            return genero;
        }
        public int GetMaxJogadores()
        {
            return maxJogadores;
        }
        public int GetMetaCritic()
        {
            return metaCritic;
        }
    }
}
