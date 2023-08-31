using MySql.Data.MySqlClient;
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
    public partial class FormListaDeEstudantes : Form
    {
        public FormListaDeEstudantes()
        {
            InitializeComponent();
        }


        Estudante estudante = new Estudante();

        public object ColunaDeFotos { get; private set; }

        private void FormListaDeEstudantes_Load(object sender, EventArgs e)
        {
            // Preenche o "DataGridView" com os dados dos estudantes.
            MySqlCommand comando = new MySqlCommand("SELECT * FROM `estudantes`");
            dataGridView1.ReadOnly = true;
            DataGridViewImageColumn colunaDeFotos = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = estudante.pegarEstudantes(comando);
            colunaDeFotos = (DataGridViewImageColumn)dataGridView1.Columns[7];
           // colunaDeFotos.ImageLayout = DataGridViewImageCell. = true ;
            dataGridView1.AllowUserToAddRows= false;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            AtualizarDeletarEstudantes atualizarDeletarEstudantes = new AtualizarDeletarEstudantes();
            atualizarDeletarEstudantes.textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            atualizarDeletarEstudantes.txtNome.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            atualizarDeletarEstudantes.txtSobrenome.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            atualizarDeletarEstudantes.datetime.Value = (DateTime) dataGridView1.CurrentRow.Cells[3].Value;

            if (dataGridView1.CurrentRow.Cells[4].Value.ToString() == "Masculino")
            {
                atualizarDeletarEstudantes.radioButtonFeminno.Checked = true;
            }
            else
            {
                atualizarDeletarEstudantes.radioButtonMasculino.Checked = true;
            }

            atualizarDeletarEstudantes.textTelefone.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            atualizarDeletarEstudantes.textEndereco.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();


            //foto
            byte[] fotoDaLista;
            fotoDaLista = (byte[])dataGridView1.CurrentRow.Cells[7].Value;
            MemoryStream fotoDoEstudante = new MemoryStream(fotoDaLista);
            atualizarDeletarEstudantes.pictureBoxFoto.Image = Image.FromStream(fotoDoEstudante);
            atualizarDeletarEstudantes.Show();
        }

        private void ButtonAtualizar(object sender, EventArgs e)
        {

        }
    }
}
