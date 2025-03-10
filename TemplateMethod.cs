using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ModuluAcademico.Support
{
    public abstract class TemplateMethod
    {
        public void Run(string op)
        {
            Limpar();
            ExecutarAcao(op);


        }

        protected abstract void ExecutarAcao(string op);


        private void Limpar()
        {
            Console.Clear();
        }


    }
}
