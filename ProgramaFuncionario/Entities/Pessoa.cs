using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaFuncionario.Entities
{
    public class Pessoa
    {
        public Guid IdPessoa { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
    }
}
