using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroFuncionarios
{
    public partial class frmAdicionarEditarFuncionario : Form
    {
        dbfuncionariosEntities db;
        public frmAdicionarEditarFuncionario(Funcionarios obj)
        {
            InitializeComponent();
            db = new dbfuncionariosEntities();
            if(obj == null)
            {
                funcionariosBindingSource.DataSource = new Funcionarios();
                db.Funcionarios.Add(funcionariosBindingSource.Current as Funcionarios);
            }
            else
            {
                funcionariosBindingSource.DataSource = obj;
                db.Funcionarios.Attach(funcionariosBindingSource.Current as Funcionarios);
            }
        }

        private void frmAdicionarEditarFuncionario_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(txtNome.Text))
                {
                    MessageBox.Show("Por favor digite seu nome completo.", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNome.Focus();
                    e.Cancel = true;
                    return;
                }
                db.SaveChanges();
                e.Cancel = false;
            }
            e.Cancel = false;
        }
    }
}
