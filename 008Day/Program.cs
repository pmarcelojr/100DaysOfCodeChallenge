using System;
using System.Net;

namespace _008Day
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("|   Seja Bem vindo ao Robô  *-*   |");
            Console.WriteLine("|     Resultado da Mega Sena      |");
            Console.WriteLine("|---------------------------------|");
            Console.Write("Informe o número do concurso: ");
            string numConcurso = Console.ReadLine();

            if(string.IsNullOrWhiteSpace(numConcurso))
            {
                numConcurso = "2329";
            }

            string url = $@"http://www1.caixa.gov.br/loterias/loterias/megasena/megasena_pesquisa_new.asp?submeteu=sim&opcao=concurso&txtConcurso={numConcurso}";
            string html;

            using (WebClient wc = new WebClient())
            {
                wc.Headers["Cookie"] = "security=true";
                html = wc.DownloadString(url);                
            }

            Console.WriteLine(html);

        }
    }
}
