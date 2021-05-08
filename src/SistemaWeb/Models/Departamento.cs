using System;
using System.Collections.Generic;

namespace SistemaWeb.Models
{
    public class Departamento 
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        /* EF Relation */
        public List<Funcionario> Funcionarios { get; set; }

    }
}
