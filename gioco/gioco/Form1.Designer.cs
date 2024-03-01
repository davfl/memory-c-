
namespace gioco
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnAvvia = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblMosse = new System.Windows.Forms.Label();
            this.lblTitolo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAvvia
            // 
            this.btnAvvia.BackColor = System.Drawing.Color.Transparent;
            this.btnAvvia.Location = new System.Drawing.Point(152, 277);
            this.btnAvvia.Margin = new System.Windows.Forms.Padding(4);
            this.btnAvvia.Name = "btnAvvia";
            this.btnAvvia.Size = new System.Drawing.Size(217, 74);
            this.btnAvvia.TabIndex = 2;
            this.btnAvvia.Text = "START";
            this.btnAvvia.UseVisualStyleBackColor = false;
            this.btnAvvia.Click += new System.EventHandler(this.btnAvvia_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(422, 444);
            this.lblScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(76, 17);
            this.lblScore.TabIndex = 3;
            this.lblScore.Text = "SCORE:  0";
            this.lblScore.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblMosse
            // 
            this.lblMosse.AutoSize = true;
            this.lblMosse.Location = new System.Drawing.Point(650, 444);
            this.lblMosse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMosse.Name = "lblMosse";
            this.lblMosse.Size = new System.Drawing.Size(167, 17);
            this.lblMosse.TabIndex = 6;
            this.lblMosse.Text = "MOSSE RIMANENTI: 25  ";
            this.lblMosse.Visible = false;
            this.lblMosse.Click += new System.EventHandler(this.lblMosse_Click);
            // 
            // lblTitolo
            // 
            this.lblTitolo.Font = new System.Drawing.Font("Lucida Handwriting", 91F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitolo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitolo.Location = new System.Drawing.Point(-27, 28);
            this.lblTitolo.Name = "lblTitolo";
            this.lblTitolo.Size = new System.Drawing.Size(946, 245);
            this.lblTitolo.TabIndex = 7;
            this.lblTitolo.Text = "Memory";
            this.lblTitolo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1435, 562);
            this.Controls.Add(this.lblTitolo);
            this.Controls.Add(this.lblMosse);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.btnAvvia);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAvvia;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblMosse;
        private System.Windows.Forms.Label lblTitolo;
    }
}

