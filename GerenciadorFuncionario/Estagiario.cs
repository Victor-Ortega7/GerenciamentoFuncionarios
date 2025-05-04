using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorFuncionario
{
    internal class Estagiario : Funcionario
    {
        public Estagiario(string nome, int idade, string cargo, decimal salario, string formaPgamento, string mtdPagamento) : base(nome, idade, cargo, salario, formaPgamento, mtdPagamento)
        {
            
        }

        public override void CalcularSalario() => throw new NotImplementedException();

        public override void EntregarPagamento()
        {
            base.EntregarPagamento();
        }
    }
}
