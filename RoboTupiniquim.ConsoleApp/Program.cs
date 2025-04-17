namespace RoboTupiniquim.ConsoleApp
{
    internal class Program
    {

        // Implementada a versão sequencial para movimentação do robô

        static void Main(string[] args)
        {
            string[,] matriz = new string[6, 6];


            string posicaoInicial = "1 2 N";
            string comando = "EMEMEMEMM";

            string[] coordenadasIniciais = posicaoInicial.Split(' '); // ["1", "2", "N"]

            int posicaoX = Convert.ToInt32(coordenadasIniciais[0]); // 1 
            int posicaoY = Convert.ToInt32(coordenadasIniciais[1]); // 2
            char direcao = Convert.ToChar(coordenadasIniciais[2]); // N

            char[] instrucoes = comando.ToCharArray();

            for (int i = 0; i < instrucoes.Length; i++)
            {
                char instrucaoAtual = instrucoes[i];

                if (instrucaoAtual == 'E')
                {
                    if (direcao == 'N')
                        direcao = 'O';

                    else if (direcao == 'O')
                        direcao = 'S';

                    else if (direcao == 'S')
                        direcao = 'L';

                    else if (direcao == 'L')
                        direcao = 'N';

                }

                else if (instrucaoAtual == 'D')
                {
                    if (direcao == 'N')
                        direcao = 'L';

                    else if (direcao == 'O')
                        direcao = 'N';

                    else if (direcao == 'S')
                        direcao = 'O';

                    else if (direcao == 'L')
                        direcao = 'S';
                }

                else if (instrucaoAtual == 'M')
                { 
                    if (direcao == 'N')
                        posicaoY++;

                    else if (direcao == 'O')
                        posicaoX--;

                    else if (direcao == 'S')
                        posicaoY--;

                    else if (direcao == 'L')
                        posicaoX++;
                }
            }

            Console.WriteLine($"Posição final do Robô: {posicaoX} {posicaoY} {direcao}");
            Console.ReadLine();

        }
    }
}
