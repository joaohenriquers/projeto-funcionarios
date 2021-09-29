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
    public partial class Form1 : Form
    {
        dbfuncionariosEntities db;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            db = new dbfuncionariosEntities();
            funcionariosBindingSource.DataSource = db.Funcionarios.ToList();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            using(frmAdicionarEditarFuncionario frm = new frmAdicionarEditarFuncionario(null))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                    funcionariosBindingSource.DataSource = db.Funcionarios.ToList();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (funcionariosBindingSource.Current == null)
                return;
            using (frmAdicionarEditarFuncionario frm = new frmAdicionarEditarFuncionario(funcionariosBindingSource.Current as Funcionarios))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                    funcionariosBindingSource.DataSource = db.Funcionarios.ToList();
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (funcionariosBindingSource.Current != null)
            {
                if(MessageBox.Show("Tem certeza que deseja excluir este registro", "Mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    db.Funcionarios.Remove(funcionariosBindingSource.Current as Funcionarios);
                    funcionariosBindingSource.RemoveCurrent();
                    db.SaveChanges();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HoraExtra he = new HoraExtra();
            he.ShowDialog();
        }
    }
}
