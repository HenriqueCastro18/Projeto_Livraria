using System;
using System.Data;
using System.Reflection.Metadata.Ecma335;
using MySql.Data.MySqlClient;
using Livraria;
using ModuluAcademico.Support;


class Program
{
    public static void Main(string[] args)
    {
        string opcao = "";
        string menu = "";

        do
        {
            opcao = Singleton.GetInstance().ShowMenu("MENU_PRINCIPAL", null);


            if (opcao == "0")
                break;


            switch (opcao)
            {
                case "1":
                    {
                        menu = Singleton.GetInstance().ShowMenu("1", new Secretaria());
                        break;
                    }
                case "2":
                    {
                        menu = Singleton.GetInstance().ShowMenu("2", new Biblioteca());
                        break;
                    }

                default:
                    {
                        Console.WriteLine("Digitou uma opção invalida!!");
                        break;
                    }
            }

        }
        while (opcao != "0");

    }
}




