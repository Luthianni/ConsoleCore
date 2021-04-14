using System;
using GameTOP.lib;

namespace GameTOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new JogoFODA(
                new Jogador1(),
                new Jogador2()
                );


            jogo.IniciarJogo();
        }
    }
    
    public class Jogador
    {
        public readonly string _Nome;

        public Jogador(string nome)
        {
            _Nome = nome;
        }

        //Chuta
        public void chuta()
        {
            Console.Write($"{_Nome} está chutando \n");
        }
        //Corre
        public void corre()
        {
           Console.Write($"{_Nome} está Correndo \n");
        }
        //Passe
        public void passe()

        {
           Console.Write($"{_Nome} está passando \n");
        }

    }

}
