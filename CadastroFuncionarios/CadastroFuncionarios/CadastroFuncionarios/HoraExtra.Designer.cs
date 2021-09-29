namespace CadastroFuncionarios
{
    partial class HoraExtra
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboFuncionarios = new System.Windows.Forms.ComboBox();
            this.funcionariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHoraExtra = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSalarioCheio = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Funcionários";
            // 
            // cboFuncionarios
            // 
            this.cboFuncionarios.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.funcionariosBindingSource, "NomeCompleto", true));
            this.cboFuncionarios.DataSource = this.funcionariosBindingSource;
            this.cboFuncionarios.DisplayMember = "NomeCompleto";
            this.cboFuncionarios.FormattingEnabled = true;
            this.cboFuncionarios.Location = new System.Drawing.Point(85, 12);
            this.cboFuncionarios.Name = "cboFuncionarios";
            this.cboFuncionarios.Size = new System.Drawing.Size(256, 21);
            this.cboFuncionarios.TabIndex = 1;
            this.cboFuncionarios.ValueMember = "NomeCompleto";
            this.cboFuncionarios.SelectedIndexChanged += new System.EventHandler(this.cboFuncionarios_SelectedIndexChanged);
            // 
            // funcionariosBindingSource
            // 
            this.funcionariosBindingSource.DataSource = typeof(CadastroFuncionarios.Funcionarios);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(347, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Salário";
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(392, 12);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(94, 20);
            this.txtSalario.TabIndex = 3;
            this.txtSalario.TextChanged += new System.EventHandler(this.txtSalario_TextChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(474, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "CALCULAR HORA EXTRA";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Quantidade de horas extras";
            // 
            // txtHoraExtra
            // 
            this.txtHoraExtra.Location = new System.Drawing.Point(155, 62);
            this.txtHoraExtra.Name = "txtHoraExtra";
            this.txtHoraExtra.Size = new System.Drawing.Size(50, 20);
            this.txtHoraExtra.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(211, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(282, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "salário + horas extras";
            // 
            // txtSalarioCheio
            // 
            this.txtSalarioCheio.Location = new System.Drawing.Point(394, 62);
            this.txtSalarioCheio.Name = "txtSalarioCheio";
            this.txtSalarioCheio.Size = new System.Drawing.Size(92, 20);
            this.txtSalarioCheio.TabIndex = 9;
            // 
            // HoraExtra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 95);
            this.Controls.Add(this.txtSalarioCheio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtHoraExtra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboFuncionarios);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "HoraExtra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HoraExtra";
            this.Load += new System.EventHandler(this.HoraExtra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboFuncionarios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.BindingSource funcionariosBindingSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHoraExtra;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSalarioCheio;
    }
}