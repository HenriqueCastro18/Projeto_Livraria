using ModuluAcademico.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria
{
    internal class Biblioteca : TemplateMethod
    {
        Livro l = new Livro();

        string sql = "";

        private void CreateLivro()
        {
            Livro l = new Livro();
            Console.WriteLine("+------------------------- LIVRO  --------------+    ");
            Console.WriteLine("¦                                               ¦    ");
            Console.WriteLine("        Forneca os dados do Livro:              ¦    ");
            Console.WriteLine("¦                                               ¦    ");
            Console.WriteLine("+-----------------------------------------------+    ");


            Console.WriteLine("ISBN: ");
            l.SetISBN(Console.ReadLine().ToString());

            Console.WriteLine("Titulo: ");
            l.SetTitulo(Console.ReadLine().ToString());

            Console.WriteLine("Autor: ");
            l.SetAutor(Console.ReadLine().ToString());

            Console.WriteLine("Ano: ");
            l.SetAno(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("Genero: ");
            l.SetGenero(Console.ReadLine().ToString());

            Console.WriteLine("Edicao: ");
            l.SetEdicao(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("Quantidade: ");
            l.SetQuantidade(Convert.ToInt32(Console.ReadLine()));

            string sql = $"INSERT INTO Livro (isbn, titulo, autor, ano, genero, edicao, quantidade) VALUES ('{l.GetISBN()}', '{l.GetTitulo()}', '{l.GetAutor()}', {l.GetAno()}, '{l.GetGenero()}', {l.GetEdicao()}, {l.GetQuantidade()});";

            using (Repositorio r = new Repositorio())
            {
                r.executeScript(sql);
            }
        }

        private void UpdateLivro()
        {
            Livro l = new Livro();
            Console.WriteLine("+------------------------- LIVRO  --------------+    ");
            Console.WriteLine("¦                                               ¦    ");
            Console.WriteLine("    Forneca os dados atualizados do Livro:      ¦    ");
            Console.WriteLine("¦                                               ¦    ");
            Console.WriteLine("+-----------------------------------------------+    ");


            Console.WriteLine("ISBN: ");
            l.SetISBN(Console.ReadLine().ToString());

            Console.WriteLine("Titulo: ");
            l.SetTitulo(Console.ReadLine().ToString());

            Console.WriteLine("Autor: ");
            l.SetAutor(Console.ReadLine().ToString());

            Console.WriteLine("Ano: ");
            l.SetAno(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("Genero: ");
            l.SetGenero(Console.ReadLine().ToString());

            Console.WriteLine("Edicao: ");
            l.SetEdicao(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("Quantidade: ");
            l.SetQuantidade(Convert.ToInt32(Console.ReadLine()));

            string sql = $"UPDATE Livro SET titulo = '{l.GetTitulo()}', autor = '{l.GetAutor()}', ano = {l.GetAno()}, genero = '{l.GetGenero()}', edicao = {l.GetEdicao()}, quantidade = {l.GetQuantidade()} WHERE isbn =  '{l.GetISBN()}' ";
            using (Repositorio r = new Repositorio())
            {
                r.executeScript(sql);
            }
        }

        private void DeleteLivro()
        {
            Livro l = new Livro();
            Console.WriteLine("+------------------- LIVRO ---------------------+    ");
            Console.WriteLine("¦                                               ¦    ");
            Console.WriteLine("¦   Remover dados do Livro:                     ¦    ");
            Console.WriteLine("¦                                               ¦    ");
            Console.WriteLine("+-----------------------------------------------+    ");


            Console.WriteLine("ISBN: ");
            l.SetISBN(Console.ReadLine().ToString());

            string sql = $"DELETE from Livro WHERE isbn =  '{l.GetISBN()}' ";

            using (Repositorio r = new Repositorio())
            {
                r.executeScript(sql);
            }


        }

        private void RetriveLivro()
        {
            Livro l = new Livro();
            Console.WriteLine("+--------------------- LIVRO --------------------+    ");
            Console.WriteLine("¦                                                ¦    ");
            Console.WriteLine("¦    Forneca O Titulo do Livro:                  ¦    ");
            Console.WriteLine("¦                                                ¦    ");
            Console.WriteLine("+------------------------------------------------+    ");

            Console.WriteLine("Titulo: ");
            l.SetTitulo(Console.ReadLine().ToString());



            sql = $"SELECT * FROM Livro WHERE titulo LIKE '%{l.GetTitulo()}%';";

            using (Repositorio r = new Repositorio())
            {
                r.executeQuery(sql);
            }

        }

        protected override void ExecutarAcao(string op)
        {
            switch (op)
            {
                case "1":
                    {
                        Biblioteca biblioteca = new Biblioteca();

                        biblioteca.CreateLivro();

                        break;

                    }
                case "2":
                    {
                        Biblioteca biblioteca = new Biblioteca();

                        biblioteca.UpdateLivro();

                        break;
                    }
                case "3":
                    {
                        Biblioteca biblioteca = new Biblioteca();

                        biblioteca.DeleteLivro();

                        break;
                    }
                case "4":
                    {
                        Biblioteca biblioteca = new Biblioteca();

                        biblioteca.RetriveLivro();

                        break;

                    }
            }
        }
    }
}
