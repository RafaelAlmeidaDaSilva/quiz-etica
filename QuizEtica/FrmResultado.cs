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
    public partial class FrmResultado : Form
    {  
        public FrmResultado()
        {
            InitializeComponent();
        }

        public FrmResultado(int qt)
        {
            InitializeComponent();
            lbQt.Text = Convert.ToString(qt);
           
        }
        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void FrmResultado_Load(object sender, EventArgs e)
        {   //Centraliza o Panel
            PainelResultado.Location = new Point((this.Size.Width / 2) - (this.PainelResultado.Size.Width / 2), (this.Size.Height / 2) - (this.PainelResultado.Size.Height / 2));
            lbFrase.Text = verfPontRetoFras(Convert.ToInt32(lbQt.Text));
        }

        private void pbReiniciar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
        //metodo de verifica pontuaçao e retorna um frase relacionada com a quatidade de acertos
        String verfPontRetoFras(int Pontuaçao)
        {
            if (Pontuaçao <= 4)
            {
                return "Regular! Você pode melhorar o seu comportamento moral.\n Lembre-se, o maior beneficiado com isso será você.";
            }
            else
            {
                if (Pontuaçao < 8)
                {
                    return "Bom! Seu exemplo moral fará o mundo um lugar melhor, \nmas você ainda pode melhorá-lo.";
                }
                else
                {

                    if (Pontuaçao > 8)
                    {
                        return "Parabéns! Você é uma pessoa de princípios morais,\n seus pequenos atos são grandes atitudes.";
                    }
                    else
                    {
                        return "";
                    }
                }
            }
            
        }




    }
}
