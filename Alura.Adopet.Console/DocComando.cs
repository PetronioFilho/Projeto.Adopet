using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Adopet.Console
{
    [AttributeUsage(AttributeTargets.Class)]
    internal class DocComando : System.Attribute
    {
        public DocComando(string instrucao, string documentacao)
        {
            Instrucao = instrucao;
            Documentacao = documentacao;
        }

        public string Instrucao { get; set; }
        public string Documentacao { get; set; }
    }
}
