namespace CadastroFuncionarios
{
    partial class frmAdicionarEditarFuncionario
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
            this.components = new System.ComponentModel.Container();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRG = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.funcionariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSalvar.Location = new System.Drawing.Point(172, 88);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(146, 23);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome completo";
            // 
            // txtNome
            // 
            this.txtNome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionariosBindingSource, "NomeCompleto", true));
            this.txtNome.Location = new System.Drawing.Point(99, 12);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(219, 20);
            this.txtNome.TabIndex = 0;
            // 
            // txtTelefone
            // 
            this.txtTelefone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionariosBindingSource, "Telefone", true));
            this.txtTelefone.Location = new System.Drawing.Point(67, 38);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(109, 20);
            this.txtTelefone.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Telefone";
            // 
            // txtRG
            // 
            this.txtRG.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionariosBindingSource, "RG", true));
            this.txtRG.Location = new System.Drawing.Point(211, 38);
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(107, 20);
            this.txtRG.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "RG";
            // 
            // txtEndereco
            // 
            this.txtEndereco.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionariosBindingSource, "Endereco", true));
            this.txtEndereco.Location = new System.Drawing.Point(71, 64);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(247, 20);
            this.txtEndereco.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Endereço";
            // 
            // txtSalario
            // 
            this.txtSalario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionariosBindingSource, "Salario", true));
            this.txtSalario.Location = new System.Drawing.Point(57, 90);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(109, 20);
            this.txtSalario.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Salário";
            // 
            // funcionariosBindingSource
            // 
            this.funcionariosBindingSource.DataSource = typeof(CadastroFuncionarios.Funcionarios);
            // 
            // frmAdicionarEditarFuncionario
            // 
            this.AcceptButton = this.btnSalvar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 124);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRG);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalvar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmAdicionarEditarFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Adicionar/Editar funcionário";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAdicionarEditarFuncionario_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRG;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource funcionariosBindingSource;
    }
}