using System;
using System.Net;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace Funcoes
{
    class Mega
    {
        public static void Resultado()
        {
            Console.Write("|Informe o número do concurso: ");
            string numConcurso = Console.ReadLine();

            if(string.IsNullOrWhiteSpace(numConcurso))
            {
                numConcurso = "2329";
            }

            string url = $@"http://www1.caixa.gov.br/loterias/loterias/megasena/megasena_pesquisa_new.asp?submeteu=sim&opcao=concurso&txtConcurso={numConcurso}";
            string html;
            
            using(WebClient webclient = new WebClient())
            {
                webclient.Headers["Cookie"] = "security=true";
                html = webclient.DownloadString(url);
            }

            // Retira Span e formata Output
            html = html.Replace("<span class=\"num_sorteio\"><ul>", ""); 
            //html = html.Replace("</ul></span>", ""); 
            html = html.Replace("</li>", ""); 

            string[] vet = Regex.Split(html, "<li>");
            List<int> resultado = new List<int>();

            resultado.Add(int.Parse(vet[1]));
            resultado.Add(int.Parse(vet[2]));
            resultado.Add(int.Parse(vet[3]));
            resultado.Add(int.Parse(vet[4]));
            resultado.Add(int.Parse(vet[5]));
            resultado.Add(int.Parse(vet[6].Substring(0, 2)));

            Console.WriteLine("|----------------------------------|");
            Console.WriteLine($"|  Resultado do Concurso :>  {numConcurso}  |");
            Console.WriteLine("|----------------------------------|");

            resultado.OrderBy(x => x).ToList().ForEach(num => {
                Console.WriteLine($"|---------->>>>>  {num}  <<<<<--------|");
            });
            Console.WriteLine("|----------------------------------|");
        }
    }
}