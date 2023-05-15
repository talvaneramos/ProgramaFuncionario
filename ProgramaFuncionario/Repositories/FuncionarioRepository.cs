using Newtonsoft.Json;
using ProgramaFuncionario.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaFuncionario.Repositories
{
    public class FuncionarioRepository
    {
        public void Exportar(Funcionario funcionario)
        {
            var json = JsonConvert.SerializeObject(funcionario, Formatting.Indented);

            using (var streamWriter = new StreamWriter("c:\\temp\\funcionario.json", true))
            {
                streamWriter.WriteLine(json);
            }
        }
    }
}
