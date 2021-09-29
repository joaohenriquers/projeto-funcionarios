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
    public partial class HoraExtra : Form
    {
        public HoraExtra()
        {
            InitializeComponent();
        }

        private void HoraExtra_Load(object sender, EventArgs e)
        {
            try
            {
                using (dbfuncionariosEntities db = new dbfuncionariosEntities())
                {
                    cboFuncionarios.DataSource = db.Funcionarios.ToList();
                    cboFuncionarios.ValueMember = "Salario";
                    cboFuncionarios.DisplayMember = "NomeCompleto";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboFuncionarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Funcionarios obj = cboFuncionarios.SelectedItem as Funcionarios;
            if (obj != null)
            {
                txtSalario.Text = obj.Salario.ToString();
            }
            Cursor.Current = Cursors.Default;
        }

        private void txtSalario_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float calculo = 0;
            float vhe = 0;
            vhe = (float.Parse(txtSalario.Text) * 5)/100;
            calculo = (float.Parse(txtHoraExtra.Text) * vhe) + float.Parse(txtSalario.Text); 
            txtSalarioCheio.Text = calculo.ToString();
        }
    }
}
