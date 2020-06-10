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

        

        private void Agenda_Load(object sender, EventArgs e) {

            List<Pessoa> pessoasRegistros = ManipulaAgenda.Manipulacao.selecionarRegistros();

            for (int contador = 0; contador < pessoasRegistros.Count; contador++) {

                ListViewItem item = new ListViewItem(new[] { pessoasRegistros[contador].nome,
                                                             pessoasRegistros[contador].endereco,
                                                             pessoasRegistros[contador].telefone,
                                                             pessoasRegistros[contador].email
                                                             });


                lvAgenda.Items.Add(item);

                listaPessoas.ArmazenarPessoa(pessoasRegistros[contador].nome,
                                             pessoasRegistros[contador].endereco,
                                             pessoasRegistros[contador].telefone,
                                             pessoasRegistros[contador].email);

            }
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
            if (lvAgenda.SelectedItems.Count > 0) {

                var pessoa = new Pessoa(tbNome.Text,
                                        tbEndereco.Text,
                                        tbTelefone.Text,
                                        tbEmail.Text);

                ListViewItem item = lvAgenda.SelectedItems[0];
                int index = lvAgenda.Items.IndexOf(lvAgenda.SelectedItems[0]); ;
                listaPessoas.Editar(pessoa, index);

                string nomeOriginal = lvAgenda.SelectedItems[0].SubItems[0].Text;
                lvAgenda.SelectedItems[0].SubItems[0].Text = pessoa.nome;
                lvAgenda.SelectedItems[0].SubItems[1].Text = pessoa.endereco;
                lvAgenda.SelectedItems[0].SubItems[2].Text = pessoa.telefone;
                lvAgenda.SelectedItems[0].SubItems[3].Text = pessoa.email;

                ManipulaAgenda.Manipulacao.AtualizarRegistro(pessoa.nome, pessoa.endereco,pessoa.telefone,pessoa.email,nomeOriginal);

            } else {

                ListViewItem item = new ListViewItem(new[] { tbNome.Text,
                                                            tbEndereco.Text,
                                                            tbTelefone.Text,
                                                            tbEmail.Text
                                                             });


                lvAgenda.Items.Add(item);

                listaPessoas.ArmazenarPessoa(tbNome.Text, tbEndereco.Text, tbTelefone.Text,tbEmail.Text);

                ManipulaAgenda.Manipulacao.InserirRegistro(tbNome.Text,
                                                            tbEndereco.Text,
                                                            tbTelefone.Text,
                                                            tbEmail.Text);

            }
        }

        private void btEditar_Click(object sender, EventArgs e) {

            if (lvAgenda.SelectedItems.Count > 0) {
                ListViewItem item = lvAgenda.SelectedItems[0];
                tbNome.Text = item.SubItems[0].Text;
                tbEndereco.Text = item.SubItems[1].Text;
                tbTelefone.Text = item.SubItems[2].Text;
                tbEmail.Text = item.SubItems[3].Text;
            }

        }

        private void btDeletar_Click(object sender, EventArgs e) {
            for (int itemList = lvAgenda.SelectedItems.Count - 1; itemList >= 0; itemList--) {
                
                ListViewItem item = lvAgenda.SelectedItems[0];
                int index = lvAgenda.Items.IndexOf(item);

                string nomeOriginal = lvAgenda.SelectedItems[0].SubItems[0].Text;

                lvAgenda.SelectedItems[0].SubItems.Clear();
                listaPessoas.RemoverPessoa(index);

                lvAgenda.SelectedItems[0].Selected = false;

                ManipulaAgenda.Manipulacao.ExcluirRegistro(nomeOriginal);
            }
        }

        

        private void lvAgenda_ColumnClick(object sender, ColumnClickEventArgs e) {

            int coluna = e.Column;

            if (coluna == 0) {
                    listaPessoas.OrdenarPessoa();
                    lvAgenda.Items.Clear();
                    int tamanhoList = listaPessoas.RetornarTamanhoLista();

                    for (int indice = 0; indice < tamanhoList; indice++) {
                        var pessoa = listaPessoas.RetornaObjetoPessoa(indice);
                        ListViewItem item = new ListViewItem(new[] { pessoa.nome,
                                                                 pessoa.endereco,
                                                                 pessoa.telefone,
                                                                 pessoa.email });
                        lvAgenda.Items.Add(item);
                    }
            }
            

        }
    }
}
