using ProgramaFuncionario.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgramaFuncionario.Utils;
using ProgramaFuncionario.Repositories;

namespace ProgramaFuncionario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nPROGRAMA FUNCIONARIO ");
			try
			{
                var funcionario = new Funcionario();
                funcionario.Setor = new Setor();
                funcionario.Funcao = new Funcao();

                funcionario.IdPessoa = Guid.NewGuid();
                funcionario.Nome = ConsoleUtil.LerString("Nome do Funcionário: ");
                funcionario.Cpf = ConsoleUtil.LerString("CPF: ");
                funcionario.DataAdmissao = ConsoleUtil.LerDateTime("Data admissão: ");
                funcionario.Matricula = ConsoleUtil.LerString("Matrícula: ");
                funcionario.Salario = ConsoleUtil.LerDecimal("Salário: ");

                funcionario.Setor.IdSetor = Guid.NewGuid();
                funcionario.Setor.Nome = ConsoleUtil.LerString("Nome Setor: ");
                funcionario.Setor.Sigla = ConsoleUtil.LerString("Sigla: ");

                funcionario.Funcao.IdFuncao = Guid.NewGuid();
                funcionario.Funcao.Descricao = ConsoleUtil.LerString("Descrição: ");

                var funcionarioRepository = new FuncionarioRepository();
                funcionarioRepository.Exportar(funcionario);

                Console.WriteLine("\nDados do funcionário em JSON com sucesso! ");                

            }
			catch (Exception ex)
			{
                Console.Write("\nOcorreu um erro: " + ex);
            }
            Console.ReadKey();
        }
    }
}
