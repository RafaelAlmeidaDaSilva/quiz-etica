using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace QuizEtica
{   ////////////////////////////////////////////
    /// REGRAS:                              ///
    ///    - Variaveis Globais  iniciam      /// 
    ///    com "_"(WanderLine).              ///     
    ///    - Classes / Formulário começam    ///
    ///    com letras maiusculas.            ///
    ///    - Informe o colega sobre          ///
    ///    qualquer alteração.               ///
    ////////////////////////////////////////////
    public partial class FrmCadastro : Form
    {
        int key = 1;
        public FrmCadastro()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {   
            if (VerificaCampos()) {
             // Campos Autenticados (OK)
                ArmazenarDados(lbCodigo.Text,txtNome.Text,txtIdade.Text,txtEmail.Text);
                FrmPerguntas frm = new FrmPerguntas();
                this.Dispose();
                frm.ShowDialog();

            }
            else
            {
                MessageBox.Show("Preencha os campos obrigatórios");
            }
        }

        //Método de verificaçao de Campos VÁZIOS.
       public Boolean VerificaCampos()
        {
            if (txtNome.Text == "")
            {
                return false;
            }
            else
            {
                if (txtIdade.Text == "")
                {
                    return false;
                }
                else { return true; }
            }
            
        }
       private void FrmCadastro_Load(object sender, EventArgs e)
       {
           CriarEstruturaContadorIni();
       }

        //Metodo de Armazenar dados no INI
       void ArmazenarDados(String Codigo,String Nome, String Idade, String Email) {
           QuizEtica.CU.IniFiles ini = new CU.IniFiles();
           ini.IniFile(@"c:\DADOS\arquivo.ini");
           ini.IniWriteValue(Codigo, "Nome", Nome, @"c:\DADOS\arquivo.ini");
           ini.IniWriteValue(Codigo, "Idade", Idade, @"c:\DADOS\arquivo.ini");
           ini.IniWriteValue(Codigo, "Email", Email, @"c:\DADOS\arquivo.ini");
           ini.IniWriteValue("QTD", "QTD", Codigo, @"c:\DADOS\arquivo.ini");
       }


       //Metodo de GET do codigo do ultimo registrado
       String GetUltRegistry()
       {
           QuizEtica.CU.IniFiles ini = new CU.IniFiles();
           ini.IniFile(@"c:\DADOS\arquivo.ini");
           String Codigo = ini.IniReadValue("QTD", "QTD");
           if (Codigo== "0" || Codigo==""){
               return "1";
           }
           else
           { 
               return Codigo;
           }

          
       }

        // Metodo que criar a estrutura onde sera armazenado a qtd
       void CriarEstruturaContadorIni()
       {
           QuizEtica.CU.IniFiles ini = new CU.IniFiles();
           ini.IniFile(@"c:\DADOS\arquivo.ini");

           String Codigo =ini.IniReadValue("QTD", "QTD");
           if (Codigo == "")
           {
               ini.IniWriteValue(@"c:\DADOS\arquivo.ini", "QTD", "QTD", Convert.ToString(0));
               lbCodigo.Text = GetUltRegistry();
           }
           else
           {
               int codigoI = Convert.ToInt32(Codigo) + 1;
               lbCodigo.Text = Convert.ToString(codigoI);
           }
          
       }
       
       private void txtNome_KeyDown(object sender, KeyEventArgs e)
       {
           //Permite as teclas backspace e espaço
           if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Space))
           {
               key = 1;
           }
           else
           {
               key = 0;

           }
       }

       private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
       {
           //Só permite a inserção de letras
           if (key != 1)
           {
               if (!(char.IsLetter(e.KeyChar)))
               {
                   e.Handled = true;
               }
           }
       }

       private void txtIdade_TextChanged(object sender, EventArgs e)
       {

       }

       private void txtIdade_KeyPress(object sender, KeyPressEventArgs e)
       {
           //Só permite a inserção de números
           if (key != 1)
           {
               if (!(char.IsDigit(e.KeyChar)))
               {
                   e.Handled = true;
               }
           }
       }

       private void txtIdade_KeyDown(object sender, KeyEventArgs e)
       {
           //Habilita O BackSpace
           if ((e.KeyCode == Keys.Back))
           {
               key = 1;
           }
           else
           {
               key = 0;
           }
       }

       private void label3_Click(object sender, EventArgs e)
       {

       }

       private void label4_Click(object sender, EventArgs e)
       {

       }





    }
}
