using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuizEtica.CU;

namespace QuizEtica
{
    public partial class FrmPerguntas : Form
    {
        RespostasUsuario RespUsu = new RespostasUsuario();
        PerguntasAlternativas PergAlt = new PerguntasAlternativas();
        int _Cont = 1;

        public FrmPerguntas()
        {
            InitializeComponent();
        }


        void AlinharLetras()
        {
            lbA.Location = new Point(35, (rbAlternativaA.Location.Y + rbAlternativaA.Size.Height / 4));
            lbB.Location = new Point(35, (rbAlternativaB.Location.Y + rbAlternativaB.Size.Height / 4));
            lbC.Location = new Point(35, (rbAlternativaC.Location.Y + rbAlternativaC.Size.Height / 4));
            lbD.Location = new Point(35, (rbAlternativaD.Location.Y + rbAlternativaD.Size.Height / 4));
            lbE.Location = new Point(35, (rbAlternativaE.Location.Y + rbAlternativaE.Size.Height / 4));
        }



        //Metodo que contem o Loop Principal de verificação
        void LoopPrincipal()
        {

            if (VerCheckRb() != "")
            {
                if (_Cont <= 10)
                {

                    //ARMAZENA
                    ArmazenaResposta(_Cont, VerCheckRb()); //armazena a resposta escolhida 

                    _Cont++;

                    if (!(_Cont > 10))
                    {
                       //ALTERA FORMULARIO
                        geradorPerguntas(_Cont); //Gera as perguntas para a memoria
                        pergAltForm(_Cont); // Manda a pergunta para o formulario
                        AltProCheck(false);// altera o valor dos radioButton 
                        AlinharLetras();
                    }
                }
                else
                {

                    FrmResultado frm = new FrmResultado(ResultadoEQuantidade());
                    this.Close();
                    frm.ShowDialog();

                }

            }
            else
            {
                MessageBox.Show("Selecione alguma alternativa");
            }

        }
        // Metodo de armazenamento
        void ArmazenaResposta(int Contador, String Resposta)
        {
            switch (Contador)
            {
                case 1:
                    RespUsu.R1 = Resposta;
                    break;
                case 2:
                    RespUsu.R2 = Resposta;
                    break;
                case 3:
                    RespUsu.R3 = Resposta;
                    break;
                case 4:
                    RespUsu.R4 = Resposta;
                    break;
                case 5:
                    RespUsu.R5 = Resposta;
                    break;
                case 6:
                    RespUsu.R6 = Resposta;
                    break;
                case 7:
                    RespUsu.R7 = Resposta;
                    break;
                case 8:
                    RespUsu.R8 = Resposta;
                    break;
                case 9:
                    RespUsu.R9 = Resposta;
                    break;
                case 10:
                    RespUsu.R10 = Resposta;
                    break;
                default:
                    break;
            }
        }

        //Método verifica CHECK radiobutton
        String VerCheckRb()
        {
            if (rbAlternativaA.Checked)
            {
                return "A";
            }
            else
            {
                if (rbAlternativaB.Checked)
                {
                    return "B";
                }
                else
                {
                    if (rbAlternativaC.Checked)
                    {
                        return "C";
                    }
                    else
                    {
                        if (rbAlternativaD.Checked)
                        {
                            return "D";
                        }
                        else
                        {
                            if (rbAlternativaE.Checked)
                            {
                                return "E";
                            }
                            else
                            { return ""; }
                        }
                    }
                }
            }
        }
        //Comparaçao e Contagem das Respostas
        int ResultadoEQuantidade()
        {
            int cont = 0;
            for (int i = 1; i <= 10; i++)
            {
                if (ComparaPergunta(i))
                {
                    cont++;
                }
            }
            return cont;
        }

        //metodo de comparaçao de respostas 
        Boolean ComparaPergunta(int pergunta)
        {
            switch (pergunta)
            {
                case 1:
                    if (RespUsu.R1 == RespostasCorretas.R1)
                    {
                        return true;
                    }
                    else { return false; }
                    break;
                case 2:
                    if (RespUsu.R2 == RespostasCorretas.R2)
                    {
                        return true;
                    }
                    else { return false; }

                    break;
                case 3:
                    if (RespUsu.R3 == RespostasCorretas.R3)
                    {
                        return true;
                    }
                    else { return false; }
                    break;
                case 4:
                    if (RespUsu.R4 == RespostasCorretas.R4)
                    {
                        return true;
                    }
                    else { return false; }
                    break;
                case 5:
                    if (RespUsu.R5 == RespostasCorretas.R5)
                    {
                        return true;
                    }
                    else { return false; }
                    break;
                case 6:
                    if (RespUsu.R6 == RespostasCorretas.R6)
                    {
                        return true;
                    }
                    else { return false; }
                    break;
                case 7:
                    if (RespUsu.R7 == RespostasCorretas.R7)
                    {
                        return true;
                    }
                    else { return false; }
                    break;
                case 8:
                    if (RespUsu.R8 == RespostasCorretas.R8)
                    {
                        return true;
                    }
                    else { return false; }
                    break;
                case 9:
                    if (RespUsu.R9 == RespostasCorretas.R9)
                    {
                        return true;
                    }
                    else { return false; }
                    break;
                case 10:
                    if (RespUsu.R10 == RespostasCorretas.R10)
                    {
                        return true;
                    }
                    else { return false; }
                    break;
                default:
                    return false;
                    break;
            }
            return true;
        }
        //Método que ALTERA a PROPRIEDADE de Check do Radio....
        void AltProCheck(Boolean valor)
        {
            rbAlternativaA.Checked = valor;
            rbAlternativaB.Checked = valor;
            rbAlternativaC.Checked = valor;
            rbAlternativaD.Checked = valor;
            rbAlternativaE.Checked = valor;
        }



        //Metodo que atribui as perguntas dentro dos componentes
        void pergAltForm(int Contador)
        {
            lbNPergunta.Text = Convert.ToString(Contador);
            lbPerguntas.Text = PergAlt.pergunta;
            rbAlternativaA.Text = (PergAlt.resposta1);
            rbAlternativaB.Text = (PergAlt.resposta2);
            rbAlternativaC.Text = (PergAlt.resposta3);
            rbAlternativaD.Text = (PergAlt.resposta4);
            rbAlternativaE.Text = (PergAlt.resposta5);
        }
        //Metodo que gera as perguntas 
        void geradorPerguntas(int Contador)
        {

            switch (Contador)
            {
                case 1:
                    PergAlt.perguntaUm();
                    break;
                case 2:
                    PergAlt.perguntaDois();
                    break;
                case 3:
                    PergAlt.perguntaTres();
                    break;
                case 4:
                    PergAlt.perguntaQuatro();
                    break;
                case 5:
                    PergAlt.perguntaCinco();
                    break;
                case 6:
                    PergAlt.perguntaSeis();
                    break;
                case 7:
                    PergAlt.perguntaSete();
                    break;
                case 8:
                    PergAlt.perguntaOito();
                    break;
                case 9:
                    PergAlt.perguntaNove();
                    break;
                case 10:
                    PergAlt.perguntaDez();
                    break;
                default:
                    break;
            }
        }

        private void FrmPerguntas_Load(object sender, EventArgs e)
        {   // Centraliza O texto no meio da tela
            PainelPerguntas.Location = new Point((this.Size.Width / 2) - (this.PainelPerguntas.Size.Width / 2), (this.Size.Height / 2) - (this.PainelPerguntas.Size.Height / 2));
            // Pergunta 1
            geradorPerguntas(_Cont); //Gera as perguntas para a memoria
            pergAltForm(_Cont); // Manda a pergunta para o formulario
            AltProCheck(false); // Altera Propriedade de CHECK para FALSE
            AlinharLetras();// Alinha as letras com as Radiobuttons
        }

        private void pbAvancar_Click(object sender, EventArgs e)
        {
            LoopPrincipal();
        }

        private void rbPerguntaA_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbPerguntaC_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbPerguntaB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void PainelPerguntas_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
