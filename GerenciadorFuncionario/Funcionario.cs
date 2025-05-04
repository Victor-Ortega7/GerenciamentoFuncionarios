using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorFuncionario
{
    internal abstract class Funcionario
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Cargo { get; set; }
        public decimal Salario { get; set; }
        public string FormaPagamento { get; set; }
        public string MtdPagamento { get; set; }

        protected Funcionario(string nome, int idade, string cargo, decimal salario, string formaPgamento, string mtdPagamento )
        {
            Nome = nome;
            Idade = idade;
            Cargo = cargo;
            Salario = salario;
            FormaPagamento = formaPgamento;
            MtdPagamento = mtdPagamento;
        }

        private readonly static List<Funcionario> funcionarios = [];

        public Funcionario() { }

        public abstract void CalcularSalario();

        public virtual decimal CalcularImpostos() {
            // Implementar lógica de cálculo de impostos para o funcionário  
            return Salario;
        }

        public static void AddFuncionario(Funcionario newFuncionario)
        {
            funcionarios.Add(newFuncionario);
            Console.WriteLine($"Funcionario {newFuncionario.Nome} " +
                $"adicionado com sucesso.");
        }

        public virtual void EntregarPagamento(){
        }



    }
}
