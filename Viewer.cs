using System;
using System.Text.RegularExpressions;

namespace EditorHtml
{
    public class Viewer
    {

        public static void Show(string text) // texto que vou receber
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            System.Console.WriteLine(" MODO DE VISUALIZAÇÃO");
            System.Console.WriteLine("-----------");
            Replace(text);
            System.Console.WriteLine("-----------");
            Console.ReadKey();
            Menu.Show(); // volta pro visualizador
        }

        public static void Replace(string text)//substituir alguns caracteres
        {
            //Regex é uma string que substitui outras strings
            var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>");
            var words = text.Split(' ');

            for (var i = 0; i < words.Length; i++)
            {
                if (strong.IsMatch(words[i]))
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(
                    words[i].Substring(
                        words[i].IndexOf('>') + 1,
                        (
                            (words[i].LastIndexOf('<') - 1) -
                             words[i].IndexOf('>')
                     )
                    )
                    );
                    System.Console.Write(" ");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(words[i]);
                    Console.Write(" ");
                }
            }
        }

    }
}