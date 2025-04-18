namespace RoboTupiniquim.ConsoleApp
{

    internal class Program
    {

        static void Main(string[] args)
        {
            // Robo Um
            string posicaoInicial = "1 2 N";
            string comando = "EMEMEMEMM";

            string[] coordenadasIniciais = posicaoInicial.Split(' '); 

            Robo.posicaoX = Convert.ToInt32(coordenadasIniciais[0]); 
            Robo.posicaoY = Convert.ToInt32(coordenadasIniciais[1]); 
            Robo.direcao = Convert.ToChar(coordenadasIniciais[2]); 

            char[] instrucoes = comando.ToCharArray();

            Robo.Explorar(instrucoes);

            Robo.ExibirCoordenadas();

            //Robo Dois
            string posicaoInicialDois = "3 3 L";
            string comandoDois = "MMDMMDMDDM";

            string[] coordenadasIniciaisDois = posicaoInicialDois.Split(' ');

            Robo.posicaoX = Convert.ToInt32(coordenadasIniciaisDois[0]);
            Robo.posicaoY = Convert.ToInt32(coordenadasIniciaisDois[1]);
            Robo.direcao = Convert.ToChar(coordenadasIniciaisDois[2]);

            char[] instrucoesDois = comandoDois.ToCharArray();

            Robo.Explorar(instrucoesDois);

            Robo.ExibirCoordenadas();

        }
    }
}
