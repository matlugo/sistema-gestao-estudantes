using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            dataGridView1.DataSource = estudante.getEstudantes(comando);
            colunaDeFotos = (DataGridViewImageColumn)dataGridView1.Columns[7];
            colunaDeFotos.ImageLayout = DataGridViewImageCell.Stretch;
            dataGridView1.AllowUserToAddRows= false;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void ButtonAtualizar(object sender, EventArgs e)
        {

        }
    }
}
