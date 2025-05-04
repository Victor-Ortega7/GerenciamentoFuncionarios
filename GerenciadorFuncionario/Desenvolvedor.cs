using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorFuncionario
{
    internal class Desenvolvedor : Funcionario
    {
        public int HorasExtras { get; set; }
        public decimal ValorHoraExtra { get; set; }

        public Desenvolvedor(string nome, int idade, string cargo, decimal salario, string formaPgamento, string mtdPagamento, int horasExtras, decimal valorHoraExtra ) : base(nome, idade, cargo, salario, formaPgamento, mtdPagamento)
        {
            HorasExtras = horasExtras;
            ValorHoraExtra = valorHoraExtra;
        }
        public override void CalcularSalario()
        {
            Salario += HorasExtras;
            Salario -= CalcularImpostos();
        }

        public override decimal CalcularImpostos()
        {
            // Implementar lógica de cálculo de impostos para o gerente  
            return Salario * 10m / 100; // Exemplo: 10% de impostos  
        }
        public override void EntregarPagamento()
        {
            base.EntregarPagamento();
        }
    }
}
