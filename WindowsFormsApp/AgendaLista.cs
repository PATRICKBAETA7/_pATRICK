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
                
                
                
                Pessoas.Add(pessoaObj);

            }

            public void RemoverPessoa(String nome) {
                
                Pessoas.RemoveAll(f => f.nome == nome); 
            }

            public int BuscarPessoa(String nome) {
                
                return Pessoas.FindIndex(f => f.nome == nome); 
            }

            public void OrdenarPessoa() {
                
                Pessoas = Pessoas.OrderBy(f => f.nome).ToList();
            }

            
            public int RetornarTamanhoLista() {
                return Pessoas.Count;
            }

            
            public Pessoa RetornaObjetoPessoa(int index) {
                
                var pessoaObj = Pessoas[index];  
                return pessoaObj;
            }


        
    }
}
