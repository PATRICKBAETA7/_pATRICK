using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp {
    public partial class Agenda : Form {


        AgendaLista listaPessoas = new AgendaLista();

        public Agenda() {
            InitializeComponent();
        }

        private void MinhaJanela_Load(object sender, EventArgs e) {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            LimparCampos();
        }

        

        private void Agenda_Load(object sender, EventArgs e) {

        }

        private void tbNome_Leave(object sender, EventArgs e) {

        }

        private void tbEndereco_Leave(object sender, EventArgs e) {

        }

        private void tbTelefone_Leave(object sender, EventArgs e) {

        }

        private void tbEmail_Leave(object sender, EventArgs e) {

        }

        

        private void btAdd_Click(object sender, EventArgs e) {
            LimparCampos();
        }
        private void LimparCampos() {
            tbNome.Text = "";
            tbEndereco.Text = "";
            tbTelefone.Text = "";
            tbEmail.Text = "";
        }

        private void btSalvar_Click(object sender, EventArgs e) {
            if (ValidarCampos()) {

                // metodo ArmazenarFuncionario
                // responsavel por inserir um novo objeto Funcionario
                // em uma posição da list
                listaPessoas.ArmazenarPessoa(tbNome.Text, 
                                            tbEmail.Text,
                                            tbEndereco.Text,
                                            tbTelefone.Text);

                // alimento uma "sublista" de item (que é uma linha da list view)
                // "pegando" os dados  dos textbox 
                ListViewItem item = new ListViewItem(new[] { tbNome.Text,
                                                             tbEndereco.Text,
                                                            tbTelefone.Text,
                                                            tbEmail.Text});

                // adicionando o objeto item na listview
                lvAgenda.Items.Add(item);

                MessageBox.Show($"O contato {tbNome.Text} foi salvo");
                
            }
        }

        private void btEditar_Click(object sender, EventArgs e) {


        }

        private void btDeletar_Click(object sender, EventArgs e) {
            for (int itemList = lvAgenda.SelectedItems.Count - 1; itemList >= 0; itemList--) {
                // cria um objeto tipo list view item
                // joga pra esse objeto, a lista de funcionarios selecionados
                ListViewItem lista = lvAgenda.SelectedItems[itemList];
                // metodo remove = remove uma lista (item) da list view
                lvAgenda.Items.Remove(lista);

                // obtem o text da posição 0 da minha sublista da listview
                // que é a coluna "nome"
                string nome = lista.SubItems[0].Text;

                // chamada ao metodo RemoverFuncionario
                // passando o parametro nome, obtido acima.
                listaPessoas.RemoverFuncionario(nome);
            }
        }

        private bool ValidarCampos() {
            if (tbNome.Text == "") {
                MessageBox.Show("Nome Inválido", "Atenção");
                return false;
            }

            if (tbTelefone.Text == "" || tbTelefone.Text == "0") {
                MessageBox.Show("Salário Inválido", "Atenção");
                return false;
            }

            return true;
        }

        private void LvAgenda_SelectedIndexChanged(object sender, EventArgs e) {

        }
    }
}
