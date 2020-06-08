using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp {
    public class Pessoa {

        public string nome, endereco, telefone,email;
        

        //Sobrecargas

        // Construtor com parametros
        public Pessoa(string nomeParam, string enderecoParam, string telefoneParam, string emailParam) {
            this.nome = nomeParam;
            this.endereco = enderecoParam;
            this.telefone = telefoneParam;
            this.email = emailParam;
        }

        // Construtor vazio
        public Pessoa() {

        }

        
    }
}
