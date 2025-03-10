using ModuluAcademico.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria
{
    internal class Secretaria : TemplateMethod
    {
        string sql = "";
        private void CreateAluno()
        {
            Aluno a = new Aluno();
            Console.WriteLine("+------------------ ALUNO  ---------------------+    ");
            Console.WriteLine("¦                                               ¦    ");
            Console.WriteLine("¦        Forneca os dados do Aluno:             ¦    ");
            Console.WriteLine("¦                                               ¦    ");
            Console.WriteLine("+-----------------------------------------------+    ");


            Console.WriteLine("Cpf: ");
            a.SetCpf(Console.ReadLine().ToString());

            Console.WriteLine("Nome: ");
            a.SetNome(Console.ReadLine().ToString());

            Console.WriteLine("Data de Nascimento: ");
            a.SetNascimento(Console.ReadLine().ToString());

            string sql = $"INSERT INTO Aluno (cpf, nome, nascimento) VALUES ('{a.GetCpf()}', '{a.GetNome()}', '{a.GetNascimento()}');";
            // comand C = new CreateComand(sql) para guardar um comand

            // C.EXECUTE() ; ANTES DE FAZER O INVOKER // FAÇA ATE O COMAND POR ENQT

            using (Repositorio r = new Repositorio()) // vai para create comand DENTRO DO EXECUTE
            {
                r.executeScript(sql);
            }
            // aqui vem invoker I = new Invoker()
            //I.setComand( new CreateComand(sql); X1
            // I.ExecuteComand()

            // Criar uma variavel sql string e passar para o X1

            // ANTES DE IMPLEMENTAR O INVOKER GARANTE UMA VARIAVEL QUE TENHA UMA STRING DE SQL QUE ARMAZENA O SCRIPT "INSET" "DELETE" ETC



        }

        private void UpdateAluno()
        {
            Aluno a = new Aluno();
            Console.WriteLine("+------------------ ALUNO ----------------------+    ");
            Console.WriteLine("¦                                               ¦    ");
            Console.WriteLine("¦  Forneca os dados atualizados do Aluno:       ¦    ");
            Console.WriteLine("¦                                               ¦    ");
            Console.WriteLine("+-----------------------------------------------+    ");


            Console.WriteLine("Cpf: ");
            a.SetCpf(Console.ReadLine().ToString());

            Console.WriteLine("Nome: ");
            a.SetNome(Console.ReadLine().ToString());

            Console.WriteLine("Data de Nascimento: ");
            a.SetNascimento(Console.ReadLine().ToString());

            string sql = $"UPDATE Aluno SET nome = '{a.GetNome()}', nascimento = {a.GetNascimento()} WHERE cpf =  '{a.GetCpf()}' ";

            using (Repositorio r = new Repositorio())
            {
                r.executeScript(sql);
            }
        }

        private void DeleteAluno()
        {
            Aluno a = new Aluno();
            Console.WriteLine("+------------------- Aluno ---------------------+    ");
            Console.WriteLine("¦                                               ¦    ");
            Console.WriteLine("¦   Remover dados do Aluno:                     ¦    ");
            Console.WriteLine("¦                                               ¦    ");
            Console.WriteLine("+-----------------------------------------------+    ");


            Console.WriteLine("Cpf: ");
            a.SetCpf(Console.ReadLine().ToString());

            string sql = $"DELETE from Aluno" +
                $" WHERE cpf =  '{a.GetCpf()}' ";

            using (Repositorio r = new Repositorio())
            {
                r.executeScript(sql);
            }
        }

        private void RetriveAluno()
        {
            Aluno a = new Aluno();
            Console.WriteLine("+--------------------- ALUNO --------------------+    ");
            Console.WriteLine("¦                                                ¦    ");
            Console.WriteLine("¦    Forneca o nome do Aluno:                    ¦    ");
            Console.WriteLine("¦                                                ¦    ");
            Console.WriteLine("+------------------------------------------------+    ");

            Console.WriteLine("Cpf: ");
            a.SetCpf(Console.ReadLine().ToString());



            sql = $"SELECT * FROM Aluno WHERE cpf LIKE '%{a.GetCpf()}%';";


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
                        Secretaria secretaria = new Secretaria();

                        secretaria.CreateAluno();

                        break;

                    }

                case "2":
                    {
                        Secretaria secretaria = new Secretaria();

                        secretaria.UpdateAluno();

                        break;
                    }

                case "3":
                    {
                        Secretaria secretaria = new Secretaria();

                        secretaria.DeleteAluno();

                        break;
                    }

                case "4":
                    {
                        Secretaria secretaria = new Secretaria();

                        secretaria.RetriveAluno();

                        break;

                    }
            }
        }
    }
}
