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
{
    public partial class FrmHome : Form
    {   ////////////////////////////////////////////
        /// REGRAS:                              ///
        ///    - Variaveis Globais  iniciam      /// 
        ///    com "_"(WanderLine).              ///     
        ///    - Classes / Formulário começam    ///
        ///    com letras maiusculas.            ///
        ///    - Informe o colega sobre          ///
        ///    qualquer alteração.               ///
        ////////////////////////////////////////////
        
        public FrmHome()
        {
            InitializeComponent();
        }

        private void pbEncerrar_Click(object sender, EventArgs e)
        {
            FrmAutenticação frm = new FrmAutenticação();
            frm.ShowDialog();
        }
        private void pbPlay_Click(object sender, EventArgs e)
        {
            FrmCadastro frm = new FrmCadastro();
            frm.ShowDialog();
           
        }
        
        //metodo de FECHAR do formulário PRINCIPAL
        public static void FecharFormulario() {
            Application.Exit();
        }

        private void FrmHome_Shown(object sender, EventArgs e)
        {
            
        }

       
    }
}
