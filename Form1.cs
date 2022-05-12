using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjProjetoMençao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtRm.Clear();
            txtNome.Clear();
            cboComponenteCurricular.Text="";
            cboMencao.Text="";
            rdbMatutino.Checked = false;
            rdbVespertino.Checked = false;
            rdbNoturno.Checked = false;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (txtRm.Text=="" || txtNome.Text==""|| cboComponenteCurricular.Text=="" || cboMencao.Text=="")
            {
                MessageBox.Show("Todos os campos devem ser preenchidos", "Atenção",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            if (rdbMatutino.Checked==false && rdbVespertino.Checked==false && rdbNoturno.Checked==false)
            {
                MessageBox.Show("Selecione o seu curso", "Atenção",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            if (cboMencao.Text == "MB" || cboMencao.Text=="B" ||cboMencao.Text =="R")
            {
                MessageBox.Show("você foi aprovado", "Atenção",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("você foi reprovado", "Atenção",
            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O projeto será encerrado", "Atenção",
            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
