using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp {
    public class AgendaLista {


            public bool OrdemLista;

            List<Pessoa> Pessoas = new List<Pessoa>();

            
            public void ArmazenarPessoa(string nome, string endereco, string telefone, string email) {
                
                Pessoa pessoaObj = new Pessoa(nome, endereco, telefone, email);
                
                
                
                Pessoas.Add(pessoaObj);

            }

            public void RemoverPessoa(int index) {

                Pessoas.RemoveAt(index);
            }

            public int BuscarPessoa(String nome) {
                
                return Pessoas.FindIndex(f => f.nome == nome); 
            }

            public void OrdenarPessoa() {

                if (!OrdemLista) {
                    Pessoas = Pessoas.OrderBy(item => item.nome).ToList();
                    OrdemLista = true;

                } else {

                    Pessoas = Pessoas.OrderByDescending(item => item.nome).ToList();
                    OrdemLista = false;

                }
            }

            
            public int RetornarTamanhoLista() {
                return Pessoas.Count;
            }

            
            public Pessoa RetornaObjetoPessoa(int index) {

                return Pessoas[index];  
                 
            }

            public void Editar(Pessoa pessoa, int index) {

                Pessoas[index].nome = pessoa.nome;
                Pessoas[index].endereco = pessoa.endereco;
                Pessoas[index].telefone = pessoa.telefone;
                Pessoas[index].email = pessoa.email; 
            }




    }
}
