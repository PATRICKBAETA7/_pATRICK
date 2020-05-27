using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp {
    public class AgendaLista {

        
            
            List<Pessoa> Pessoas = new List<Pessoa>();

            
            public void ArmazenarPessoa(string nome, string endereco, string telefone, string email) {
                
                Pessoa pessoaObj = new Pessoa(nome, endereco, telefone, email);
                
                
                // Função add é herdada da list
                Pessoas.Add(pessoaObj);

            }

            public void RemoverFuncionario(String nome) {
                // Função removeall é herdada da list
                Pessoas.RemoveAll(f => f.nome == nome); // a expressão lambda é uma representação :
                                                             // (input-parameters) => expression
            }

            public int BuscarFuncionario(String nome) {
                // Função findindex é herdada da list
                return Pessoas.FindIndex(f => f.nome == nome); // expressao lambda. Parametro f do tipo Funcionario
                                                                    // variavel capturada: nome comparada com o nome recebido por parametro
            }

            public void OrdenarFuncionario() {
                // Função OrderBy é herdada da list
                Pessoas = Pessoas.OrderBy(f => f.nome).ToList();
            }

            // Retorna o tamanho da list.
            // Lembrando que esses metodos da list só existem dentro da classe.
            // em outro escopo, instanciado a classe ListaFuncionario, a lista está encapsulada dentro do objeto
            // por isso é enrxgado como list apenas dentro da classe
            public int RetornarTamanhoLista() {
                return Pessoas.Count;
            }

            // busca um unico objeto funcionario, de acordo com o indice recebido.
            // retorna um unico objeto Funcionario
            // lembrando que aqui temos uma lista de vários objetos funcionarios, um em cada indice
            public Pessoa RetornaObjetoPessoa(int index) {
                // var é uma forma implicita de definir um dado.
                // a variavel irá tomar a forma que lhe form atribuido
                var pessoaObj = Pessoas[index]; // perceba que aqui pode-se manipular a lista diretamente com colchetes 
                return pessoaObj;
            }


        
    }
}
