using System;
using System.Text;

namespace EditorHtml
{
    public static class Editor
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            System.Console.WriteLine(" MODO EDITOR");
            System.Console.WriteLine("-----------");
            Start();
        }
        public static void Start()
        {
            var file = new StringBuilder();

            do
            {
                file.Append(Console.ReadLine()); //ler a linha e colocar no arquivo
                file.Append(Environment.NewLine);//pula linha
            } while (Console.ReadKey().Key != ConsoleKey.Escape);//enquanto nao apertar ESC não sai

            System.Console.WriteLine("-----------");
            System.Console.WriteLine("-----------");
            System.Console.WriteLine(".Deseja salvar o arquivo?");
            Viewer.Show(file.ToString());
        }


    }
}