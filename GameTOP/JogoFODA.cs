using GameTOP.Interface;

namespace GameTOP
{
   class JogoFODA
    {
        private readonly iJogador _Jogador1;
        private readonly iJogador _Jogador2;


        public JogoFODA(iJogador jogador1, iJogador jogador2)
        
        {
            _Jogador1 = jogador1;
            _Jogador2 = jogador2;
        }
        public void IniciarJogo()
        {
            System.Console.Write(_Jogador1.Chuta());
            System.Console.Write(_Jogador1.Corre());
            System.Console.Write(_Jogador1.Passe());
            //
            System.Console.Write("\n PRÓXIMO JOGADOR \n");
            //
            System.Console.Write(_Jogador2.Chuta());
            System.Console.Write(_Jogador2.Corre());
            System.Console.Write(_Jogador2.Passe());

            
                        
        }
    }
}