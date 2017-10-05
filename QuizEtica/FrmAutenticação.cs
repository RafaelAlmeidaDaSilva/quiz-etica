using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizEtica
{    ////////////////////////////////////////////
    /// REGRAS:                              ///
    ///    - Variaveis Globais  iniciam      /// 
    ///    com "_"(WanderLine).              ///     
    ///    - Classes / Formulário começam    ///
    ///    com letras maiusculas.            ///
    ///    - Informe o colega sobre          ///
    ///    qualquer alteração.               ///
    ////////////////////////////////////////////
    public partial class FrmAutenticação : Form
    {
        public FrmAutenticação()
        {
            InitializeComponent();
        }

        private void FrmAutenticação_KeyUp(object sender, KeyEventArgs e)
        {
        }
       
        private void btnEntrar_Click(object sender, EventArgs e)
        {   // Verificaçao de SENHA
            if (txtChave.Text == "admin") {
                FrmHome.FecharFormulario();
            }else {
                this.Close();
            }
        }

        private void txtChave_KeyUp(object sender, KeyEventArgs e)
        {   // TECLA ENTER como atalho para verificaçao
            if (e.KeyCode == Keys.Enter)
            {
                btnEntrar_Click(sender, e);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FrmAutenticação_Load(object sender, EventArgs e)
        {

        }
    }
}
