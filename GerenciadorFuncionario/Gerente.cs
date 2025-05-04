using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorFuncionario
{
    internal class Gerente : Funcionario
    {
        public decimal Bonus { get; set; }

        public Gerente(string nome, int idade, string cargo, decimal salario, string formaPgamento, string mtdPagamento, decimal bonus) : base(nome, idade, cargo, salario, formaPgamento, mtdPagamento)
        {
            Bonus = bonus;
        }

        public override void CalcularSalario()
        {
            Salario += Bonus;  
            Salario -= CalcularImpostos();
        }

        public override decimal CalcularImpostos()
        {
            // Implementar lógica de cálculo de impostos para o gerente  
            return Salario * 27.5m / 100; // Exemplo: 27.5% de impostos  
        }

        public override void EntregarPagamento()
        {
            base.EntregarPagamento();
        }
    }
}
