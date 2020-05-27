using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp {
    public class Pessoa {

        public string nome, email, endereco, telefone;
        

        //Sobrecargas

        // Construtor com parametros
        public Pessoa(string nomeParam, string emailParam, string enderecoParam, string telefoneParam) {
            this.nome = nomeParam;
            this.email = emailParam;
            this.endereco= enderecoParam;
            this.telefone = telefoneParam;
        }

        // Construtor vazio
        public Pessoa() {

        }

        
    }
}
