using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste___mundivox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá! Bem-vindo ao gerenciador do torneio! Para começar, cadastre os times.");
            Console.Write("Time A: ");
            string teamA = Console.ReadLine();
            Console.Write("Time B: ");
            string teamB = Console.ReadLine();
            Console.Write("Time C: ");
            string teamC = Console.ReadLine();
            Console.Write("Time D: ");
            string teamD = Console.ReadLine();
            Console.Write("Time E: ");
            string teamE = Console.ReadLine();
            Console.Write("Time F: ");
            string teamF = Console.ReadLine();
            Console.Write("Time G: ");
            string teamG = Console.ReadLine();
            Console.Write("Time H: ");
            string teamH = Console.ReadLine();

            Console.WriteLine("Primeira fase, quartas-de-final:");
            Console.Write("Declare o vencedor entre "); Console.Write(teamA); Console.Write(" e "); Console.Write(teamB); Console.Write(": ");
            dynamic vencedorChave1Q = Console.ReadLine();

            if (vencedorChave1Q == teamA) ;

            else
                teamA = teamB;

            Console.Write("Declare o vencedor entre "); Console.Write(teamC); Console.Write(" e "); Console.Write(teamD); Console.Write(": ");
            dynamic vencedorChave2Q = Console.ReadLine();

            if (vencedorChave2Q == teamC) ;

            else
                teamC = teamD;

            Console.Write("Declare o vencedor entre "); Console.Write(teamE); Console.Write(" e "); Console.Write(teamF); Console.Write(": ");
            dynamic vencedorChave3Q = Console.ReadLine();

            if (vencedorChave3Q == teamE) ;

            else
                teamE = teamF;

            Console.Write("Declare o vencedor entre "); Console.Write(teamG); Console.Write(" e "); Console.Write(teamH); Console.Write(": ");
            dynamic vencedorChave4Q = Console.ReadLine();

            if (vencedorChave4Q == teamG) ;

            else
                teamG = teamH;

            Console.Write("Certo! Os times classificados para a próxima fase são: "); Console.Write(teamA); Console.Write(", "); Console.Write(teamC); Console.Write(", "); Console.Write(teamE); Console.Write(" e ");
            Console.Write(teamG); Console.Write("!");

            Console.WriteLine("Agora, vamos para as semifinais!");
                Console.Write("Declare o vencedor entre "); Console.Write(teamA); Console.Write(" e "); Console.Write(teamC); Console.Write(": ");
                dynamic vencedorChave1S = Console.ReadLine();

            if (vencedorChave1S == teamA) ;

            else
            teamA = teamC;

            Console.Write("Declare o vencedor entre "); Console.Write(teamE); Console.Write(" e "); Console.Write(teamG); Console.Write(": ");
            dynamic vencedorChave2S = Console.ReadLine();

            if (vencedorChave2S == teamE) ;

            else
            teamE = teamG;

            Console.Write("Muito bem! Os finalistas do torneio são: "); Console.Write(teamA); Console.Write(" e "); Console.Write(teamE); Console.Write("!");
            Console.Write("Por fim, declare o grande campeão: "); string campeão = Console.ReadLine();
            Console.WriteLine("O campeão é: "); Console.Write(campeão); Console.Write("!");

            










            Console.ReadLine();
        }
    }
}
