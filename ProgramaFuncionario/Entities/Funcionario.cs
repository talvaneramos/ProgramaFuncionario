﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaFuncionario.Entities
{
    public class Funcionario : Pessoa
    {
        public DateTime DataAdmissao { get; set; }
        public string Matricula { get; set; }
        public decimal Salario { get; set; }

        public Setor Setor { get; set; }
        public Funcao Funcao { get; set; }
    }
}
