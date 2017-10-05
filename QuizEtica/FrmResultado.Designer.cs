namespace QuizEtica
{
    partial class FrmResultado
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
            this.PainelResultado = new System.Windows.Forms.Panel();
            this.lbQt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbFrase = new System.Windows.Forms.Label();
            this.pbReiniciar = new System.Windows.Forms.PictureBox();
            this.PainelResultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbReiniciar)).BeginInit();
            this.SuspendLayout();
            // 
            // PainelResultado
            // 
            this.PainelResultado.BackColor = System.Drawing.Color.LightCyan;
            this.PainelResultado.Controls.Add(this.lbQt);
            this.PainelResultado.Controls.Add(this.label2);
            this.PainelResultado.Controls.Add(this.lbFrase);
            this.PainelResultado.Location = new System.Drawing.Point(2, 1);
            this.PainelResultado.Name = "PainelResultado";
            this.PainelResultado.Size = new System.Drawing.Size(787, 229);
            this.PainelResultado.TabIndex = 3;
            // 
            // lbQt
            // 
            this.lbQt.AutoSize = true;
            this.lbQt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQt.ForeColor = System.Drawing.Color.Black;
            this.lbQt.Location = new System.Drawing.Point(383, 179);
            this.lbQt.Name = "lbQt";
            this.lbQt.Size = new System.Drawing.Size(47, 31);
            this.lbQt.TabIndex = 5;
            this.lbQt.Text = "N°";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Location = new System.Drawing.Point(64, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(329, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Quantidade de Acertos: ";
            // 
            // lbFrase
            // 
            this.lbFrase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbFrase.AutoSize = true;
            this.lbFrase.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFrase.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbFrase.Location = new System.Drawing.Point(21, 41);
            this.lbFrase.Name = "lbFrase";
            this.lbFrase.Size = new System.Drawing.Size(89, 31);
            this.lbFrase.TabIndex = 3;
            this.lbFrase.Text = "Frase";
            // 
            // pbReiniciar
            // 
            this.pbReiniciar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbReiniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbReiniciar.Image = global::QuizEtica.Properties.Resources._1442712833_play1;
            this.pbReiniciar.Location = new System.Drawing.Point(605, 190);
            this.pbReiniciar.Name = "pbReiniciar";
            this.pbReiniciar.Size = new System.Drawing.Size(141, 112);
            this.pbReiniciar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbReiniciar.TabIndex = 4;
            this.pbReiniciar.TabStop = false;
            this.pbReiniciar.Click += new System.EventHandler(this.pbReiniciar_Click);
            // 
            // FrmResultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(745, 302);
            this.Controls.Add(this.pbReiniciar);
            this.Controls.Add(this.PainelResultado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmResultado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmResultado";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmResultado_Load);
            this.PainelResultado.ResumeLayout(false);
            this.PainelResultado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbReiniciar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PainelResultado;
        private System.Windows.Forms.Label lbQt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbFrase;
        private System.Windows.Forms.PictureBox pbReiniciar;


    }
}