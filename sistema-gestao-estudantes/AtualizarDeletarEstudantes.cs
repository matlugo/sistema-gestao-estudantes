﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_gestao_estudantes
{
    public partial class AtualizarDeletarEstudantes : Form
    {
        //internal object textendereco;
        Estudante estudante = new Estudante();
        public AtualizarDeletarEstudantes()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnenviarfoto_Click(object sender, EventArgs e)
        {
            // Pesquisa pela imagem no computador.
            OpenFileDialog abrirArquivo = new OpenFileDialog();
            abrirArquivo.Filter =
                "Seleciona a Foto(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (abrirArquivo.ShowDialog() == DialogResult.OK)
            {
                pictureBoxFoto.Image = Image.FromFile(abrirArquivo.FileName);
            }
        }
        bool Verificar()
        {
            if ((txtNome.Text.Trim() == "") ||
                (txtSobrenome.Text.Trim() == "") ||
                (textTelefone.Text.Trim() == "") ||
                (textEndereco.Text.Trim() == "") ||
                (pictureBoxFoto.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnconfirmar(object sender, EventArgs e)
        {
          //  Estudante estudante = new Estudante();
            int id = Convert.ToInt32(textBoxID.Text);
            string nome = txtNome.Text;
            string sobrenome = txtSobrenome.Text;
            DateTime nascimento = datetime.Value;
            string telefone = textTelefone.Text;
            string endereco = textEndereco.Text;
            string genero = "Feminino";

            if (radioButtonMasculino.Checked)
            {
                genero = "Masculino";
            }

            // A foto do estudante em formato binário.
            MemoryStream foto = new MemoryStream();

            // Verifica se o estudante é maior de 10 anos.
            int anoDeNascimento = datetime.Value.Year;
            // Pega o ano no qual estamos.
            int anoAtual = DateTime.Now.Year;
            if (
                (anoAtual - anoDeNascimento) < 10 ||
                (anoAtual - anoDeNascimento) > 100
                )
            {
                MessageBox.Show("A idade precisa ser entre 10 e 100 anos.",
                    "Idade Inválida",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Verificar())
            {
                pictureBoxFoto.Image.Save(foto, pictureBoxFoto.Image.RawFormat);
                if (estudante.atualizarEstudante(id, nome, sobrenome, nascimento,
                    telefone, genero, endereco, foto))
                {
                    MessageBox.Show("Novo Estudante Cadastrado", "Sucesso!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erro", "Inserir Estudante",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Campos não preenchidos",
                    "Inserir Estudante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void textboxID_text(object sender, EventArgs e)
        {

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxID.Text);

            if(MessageBox.Show("Tem certeza que quer remover o estudante ?",
                "Remover Estudante", MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (estudante.deletarestudante(id))
                {
                    MessageBox.Show("Estudante Removido", "Remover Estudante",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);


                    textBoxID.Text = ""; //Obs dará erro se entar apagar o mesmo estudante 2X
                    txtNome.Text = "";
                    txtSobrenome.Text = "";
                    textTelefone.Text = "";
                    textEndereco.Text = "";
                    datetime.Value = DateTime.Now;
                    pictureBoxFoto.Image = null;


                }
                else
                {
                    MessageBox.Show("Estudante não Removido", "Remover Estudante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

                
        }

        private void btnprocurar_Click(object sender, EventArgs e)
        {
            //Procura estudante pela Id.

            int id = Convert.ToInt32(textBoxID.Text);
            MySqlCommand comando = new MySqlCommand("SELECT `id`, `nome`, `sobrenome`, `nascimento`, `genero`, `telefone`, `endereco`, `foto` FROM `estudantes` WHERE `id`=" + id);

            DataTable tabela = estudante.pegarEstudantes(comando);

            if (tabela.Rows.Count > 0)
                {
                txtNome.Text = tabela.Rows[0]["nome"].ToString();
                txtSobrenome.Text = tabela.Rows[0]["sobrenome"].ToString();
                textTelefone.Text = tabela.Rows[0]["telefone"].ToString();
                textEndereco.Text = tabela.Rows[0]["endereco"].ToString();

                datetime.Value = (DateTime)tabela.Rows[0]["nascimento"];
                    
                    if (tabela.Rows[0]["genero"].ToString() == "Feminino")
                {
                    radioButtonFeminno.Checked = true;
                }
                    else
                {
                    radioButtonMasculino.Checked = true;
                }

                // Foto de estudante 
                byte[] fotoDaTabela = (byte[])tabela.Rows[0]["foto"];
                MemoryStream fotoDaInterface = new MemoryStream(fotoDaTabela);
                pictureBoxFoto.Image = Image.FromStream(fotoDaInterface);
            }
        }
    }
}
