namespace sistema_gestao_estudantes
{
    partial class AtualizarDeletarEstudantes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnprocurar = new System.Windows.Forms.Button();
            this.Nome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.Label();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.datetime = new System.Windows.Forms.DateTimePicker();
            this.radioButtonMasculino = new System.Windows.Forms.RadioButton();
            this.radioButtonFeminno = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBoxFoto = new System.Windows.Forms.PictureBox();
            this.btnenviarfoto = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textEndereco = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.textTelefone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(141, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 20);
            this.textBox1.TabIndex = 0;
            // 
            // btnprocurar
            // 
            this.btnprocurar.Location = new System.Drawing.Point(319, 44);
            this.btnprocurar.Name = "btnprocurar";
            this.btnprocurar.Size = new System.Drawing.Size(75, 23);
            this.btnprocurar.TabIndex = 1;
            this.btnprocurar.Text = "Procurar";
            this.btnprocurar.UseVisualStyleBackColor = true;
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(86, 49);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(18, 13);
            this.Nome.TabIndex = 2;
            this.Nome.Text = "ID";
            this.Nome.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(141, 91);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(155, 20);
            this.txtNome.TabIndex = 3;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(79, 138);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(61, 13);
            this.ID.TabIndex = 6;
            this.ID.Text = "Sobrenome";
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.Location = new System.Drawing.Point(153, 135);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(155, 20);
            this.txtSobrenome.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nascimento";
            // 
            // datetime
            // 
            this.datetime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetime.Location = new System.Drawing.Point(156, 265);
            this.datetime.Name = "datetime";
            this.datetime.Size = new System.Drawing.Size(200, 20);
            this.datetime.TabIndex = 8;
            // 
            // radioButtonMasculino
            // 
            this.radioButtonMasculino.AutoSize = true;
            this.radioButtonMasculino.Checked = true;
            this.radioButtonMasculino.Location = new System.Drawing.Point(110, 19);
            this.radioButtonMasculino.Name = "radioButtonMasculino";
            this.radioButtonMasculino.Size = new System.Drawing.Size(76, 17);
            this.radioButtonMasculino.TabIndex = 9;
            this.radioButtonMasculino.TabStop = true;
            this.radioButtonMasculino.Text = "Masculino ";
            this.radioButtonMasculino.UseVisualStyleBackColor = true;
            // 
            // radioButtonFeminno
            // 
            this.radioButtonFeminno.AutoSize = true;
            this.radioButtonFeminno.Location = new System.Drawing.Point(12, 19);
            this.radioButtonFeminno.Name = "radioButtonFeminno";
            this.radioButtonFeminno.Size = new System.Drawing.Size(67, 17);
            this.radioButtonFeminno.TabIndex = 10;
            this.radioButtonFeminno.Text = "Feminino";
            this.radioButtonFeminno.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Genero";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonFeminno);
            this.groupBox1.Controls.Add(this.radioButtonMasculino);
            this.groupBox1.Location = new System.Drawing.Point(153, 324);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 59);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 469);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Foto";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // pictureBoxFoto
            // 
            this.pictureBoxFoto.Location = new System.Drawing.Point(164, 418);
            this.pictureBoxFoto.Name = "pictureBoxFoto";
            this.pictureBoxFoto.Size = new System.Drawing.Size(163, 121);
            this.pictureBoxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFoto.TabIndex = 14;
            this.pictureBoxFoto.TabStop = false;
            this.pictureBoxFoto.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnenviarfoto
            // 
            this.btnenviarfoto.Location = new System.Drawing.Point(355, 443);
            this.btnenviarfoto.Name = "btnenviarfoto";
            this.btnenviarfoto.Size = new System.Drawing.Size(109, 39);
            this.btnenviarfoto.TabIndex = 15;
            this.btnenviarfoto.Text = "Enviar Foto";
            this.btnenviarfoto.UseVisualStyleBackColor = true;
            this.btnenviarfoto.Click += new System.EventHandler(this.btnenviarfoto_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(423, 536);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 38);
            this.button3.TabIndex = 16;
            this.button3.Text = "Confirmar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textEndereco
            // 
            this.textEndereco.Location = new System.Drawing.Point(156, 200);
            this.textEndereco.Multiline = true;
            this.textEndereco.Name = "textEndereco";
            this.textEndereco.Size = new System.Drawing.Size(155, 49);
            this.textEndereco.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(89, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Endereço";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(563, 536);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(93, 38);
            this.button4.TabIndex = 19;
            this.button4.Text = "Remover";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // textTelefone
            // 
            this.textTelefone.Location = new System.Drawing.Point(153, 174);
            this.textTelefone.Name = "textTelefone";
            this.textTelefone.Size = new System.Drawing.Size(155, 20);
            this.textTelefone.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(79, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Telefone";
            // 
            // AtualizarDeletarEstudantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 612);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textTelefone);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textEndereco);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnenviarfoto);
            this.Controls.Add(this.pictureBoxFoto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.datetime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.txtSobrenome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.btnprocurar);
            this.Controls.Add(this.textBox1);
            this.Name = "AtualizarDeletarEstudantes";
            this.Text = "AtualizarDeletarEstudantes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnprocurar;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnenviarfoto;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button4;
        internal System.Windows.Forms.TextBox textTelefone;
        private System.Windows.Forms.Label label6;
        internal System.Windows.Forms.TextBox textBox1;
        internal System.Windows.Forms.TextBox txtNome;
        internal System.Windows.Forms.TextBox txtSobrenome;
        internal System.Windows.Forms.DateTimePicker datetime;
        internal System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.PictureBox pictureBoxFoto;
        internal System.Windows.Forms.TextBox textEndereco;
        internal System.Windows.Forms.RadioButton radioButtonMasculino;
        internal System.Windows.Forms.RadioButton radioButtonFeminno;
    }
}