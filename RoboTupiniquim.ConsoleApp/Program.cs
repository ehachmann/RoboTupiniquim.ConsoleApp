namespace RoboTupiniquim.ConsoleApp
{
    internal class Program
    {

        // Entrada de dados e leitura do ponto de partida do robo

        static void Main(string[] args)
        {
            string[,] matriz = new string[6, 6];

            // Input de dados
            Console.WriteLine("Digite as coordenadas X e Y do ponto de partida do robô");
            Console.Write("Coordenada X: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Coordenada Y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.Write("Digite a orientação de partida, sendo N = norte, S = sul, L = leste, O = oeste");
            Console.Write("Orientação: ");
            char orientacao = Convert.ToChar(Console.ReadLine());

            // Movimentação do robô
            Console.WriteLine("Digite os comandos de movimentação do robô, ");
            Console.WriteLine("E = Esquerda, D = Direita, M = Mover");
            Console.Write("Comandos: ");
            string comando = Console.ReadLine();

            comando = comando.ToLower();

            char[] instrucao = comando.ToCharArray();

            for(int i = 0;i < instrucao.Length; i++)
            {
                if (instrucao[i] == 'e')
                {

                }
            }

            Console.WriteLine(comando);
            Console.ReadKey();
        }
    }
}
