using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp {
    class Gerente: Funcionario {

        public Gerente(string nomeParam, float salarioBrutoParam, string CPF) {
            this.nome = nomeParam;
            this.salarioBruto = salarioBrutoParam;
            this.cpf = CPF;
        }

        // Construtor vazio
        public Gerente() {

        }

        // Construtor com cinco parametros
        public Gerente(string nomeParam, float salarioBrutoParam,
                          float descontoParam, float adicionalParam, string CPF) {
            this.nome = nomeParam;
            this.salarioBruto = salarioBrutoParam;
            this.adicional = adicionalParam;
            this.desconto = descontoParam;
            this.cpf = CPF;
        }
        

        public override void CalcularBonus(float salario, float desconto, float adicional) {

            Funcionario bonusObj = new Funcionario();
            bonusObj.CalcularLiquido(bonusObj.salarioBruto, bonusObj.desconto, bonusObj.adicional);

            this.salarioLiquido = this.salarioLiquido + ((2 / 100) * this.salarioLiquido);
        }
        public override void CalcularBonus(float salario, float adicional) {

            Funcionario bonusObj = new Funcionario();
            bonusObj.CalcularLiquido(bonusObj.salarioBruto, bonusObj.adicional);

            this.salarioLiquido = this.salarioLiquido + ((2 / 100) * this.salarioLiquido);
        }
    }
}
