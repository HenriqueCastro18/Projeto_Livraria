using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Livraria;

namespace ModuluAcademico.Support
{
    public sealed class Singleton
    {
        private Singleton() { }

        static Singleton _instance;

        public static Singleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }

            return _instance;
        }

        public string ShowMenu(string menu, TemplateMethod tm)
        {
            string retorno = null;
            switch (menu)
            {
                case "MENU_PRINCIPAL":
                    {
                        Console.WriteLine("╔══════════════════ MENU OPÇÕES ════════════════╗    ");
                        Console.WriteLine("║                                               ║    ");
                        Console.WriteLine("║            1- MENU_SECRETARIA                 ║    ");
                        Console.WriteLine("║            2- MENU_BIBLIOTECA                 ║    ");
                        Console.WriteLine("║═══════════════════════════════════════════════║    ");
                        Console.WriteLine("║            0 SAIR                             ║    ");
                        Console.WriteLine("╚═══════════════════════════════════════════════╝    ");
                        Console.WriteLine(" ");
                        Console.Write("DIGITE UMA OPÇÃO : ");
                        retorno = Console.ReadLine();
                        break;
                    }

                case "1":
                    {
                        Console.WriteLine("╔═══════════════ MENU SECRETARIA ═══════════════╗    ");
                        Console.WriteLine("║                                               ║    ");
                        Console.WriteLine("║            1 INCLUIR   - ALUNO                ║    ");
                        Console.WriteLine("║            2 ATUALIZAR - ALUNO                ║    ");
                        Console.WriteLine("║            3 REMOVER   - ALUNO                ║    ");
                        Console.WriteLine("║            4 CONSULTAR - ALUNO                ║    ");
                        Console.WriteLine("║═══════════════════════════════════════════════║    ");
                        Console.WriteLine("║          0 SAIR                               ║    ");
                        Console.WriteLine("╚═══════════════════════════════════════════════╝    ");
                        Console.WriteLine(" ");
                        Console.Write("DIGITE UMA OPÇÃO : ");
                        retorno = Console.ReadLine();
                        tm.Run(retorno);
                        break;
                    }


                case "2":
                    {
                        Console.WriteLine("╔══════════════ MENU DE BIBLIOTECA ═════════════╗    ");
                        Console.WriteLine("║                                               ║    ");
                        Console.WriteLine("║            1 INCLUIR   - LIVRO                ║    ");
                        Console.WriteLine("║            2 ATUALIZAR - LIVRO                ║    ");
                        Console.WriteLine("║            3 REMOVER   - LIVRO                ║    ");
                        Console.WriteLine("║            4 CONSULTAR - LIVRO                ║    ");
                        Console.WriteLine("║═══════════════════════════════════════════════║    ");
                        Console.WriteLine("║          0 SAIR                               ║    ");
                        Console.WriteLine("╚═══════════════════════════════════════════════╝    ");
                        Console.WriteLine(" ");
                        Console.Write("DIGITE UMA OPÇÃO : ");
                        retorno = Console.ReadLine();
                        tm.Run(retorno);
                        break;
                    }
            }
            return retorno;
        }

        
    }
}
