using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gioco
{
    public partial class Form1 : Form
    {
        const int NumeroCarte = 20; //numero di carte
        PictureBox [] carte; //array delle carte
        PictureBox[] carte_retro; //array che contienre il retro delle carte (e serve per stamparle a scehrmo e sono cliccabili)
        Random rand; 
        int cont; //contatore che serve per il controllo (serve per vedere quante carte sono state scoperte (una o due))
        int punteggio;
        int cartaScoperta1;
        int cartaScoperta2;
        int[] numRandom;
        int mosse;
        int secret;


        public Form1()
        {
            InitializeComponent();

            carte = new PictureBox[NumeroCarte];
            carte_retro = new PictureBox[NumeroCarte];
            rand = new Random();
            cont = 0;
            punteggio = 0;
            cartaScoperta1=0;
            cartaScoperta2=0;
            numRandom = new int[NumeroCarte];
            mosse=25;
            secret = 0;
        }

        private void btnAvvia_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < NumeroCarte; i++)
            {
                carte_retro[i] = new PictureBox();
                carte_retro[i].Parent = this;
                if (i < 10)
                {
                    carte_retro[i].Left = 25 + (i * 100);
                    carte_retro[i].Top = 45;
                }
                else
                {
                    carte_retro[i].Left = 25 + ((i - 10) * 100);
                    carte_retro[i].Top = 200;
                }
                carte_retro[i].Load("retro.jpg");
                carte_retro[i].Width = 65;
                carte_retro[i].Height = 100;
                carte_retro[i].SizeMode = PictureBoxSizeMode.StretchImage;           
                carte_retro[i].Click += new EventHandler(pictureCarte_Click);

            }

            caricaCarte();
            posizionamentoCarte();
            btnAvvia.Visible = false;
            lblTitolo.Visible = false;
            lblScore.Visible = true;
            lblMosse.Visible = true;

        }
        private void posizionamentoCarte()
        {
            
            int numero;

            for (int i=0; i<NumeroCarte; i++)
            {
                do
                {
                    numero = rand.Next(0, 20);

                } while (carte[numero].Visible == true);

                carte[numero].Location = carte_retro[i].Location;
                carte[numero].Visible = true;
                numRandom[i] = numero;
            }
        }
        private void pictureCarte_Click(object sender, EventArgs e)
        {

            PictureBox p = (PictureBox)sender;

            for (int i=0; i < 20; i++)
            {
                if (carte_retro[i].Location == p.Location)
                {
                    carte_retro[i].Visible = false;
                    cont++;

                    if (cont == 1)
                    {
                        cartaScoperta1 = i;
                    }
                    else if (cont==2)
                    {
                        cartaScoperta2 = i;
                    }
                }
            }

            if (cont == 2)
            {
                if (numRandom[cartaScoperta1]+10==numRandom[cartaScoperta2] || numRandom[cartaScoperta1]==numRandom[cartaScoperta2]+10){
                    punteggio += 2;
                    mosse--;
                    lblScore.Text = "SCORE: " + punteggio;
                    cont = 0;
                    
                }
                else
                {
                    timer1.Start();
                    mosse--;
                    cont = 0;
                }
                lblMosse.Text = "MOSSE RIMANENTI: " + mosse;
                controlloWin(mosse, punteggio);
            }
        }
        private void controlloWin(int mosse,int punteggio)
        {
            if (punteggio == 20)
            {
                MessageBox.Show("Congratulation you won!!");
                Close();
            }
            if (mosse == 0)
            {
                MessageBox.Show("Retry again you will be more lucky next time");
                Close();
            }
        }
        private void caricaCarte()
        {
            for (int i = 0; i < NumeroCarte; i++)
            {
                carte[i] = new PictureBox();
                carte[i].Parent = this;
                if (i<10)
                {
                    carte[i].Load(i + ".jpg");
                }
                else
                {
                    carte[i].Load((i-10) + ".jpg");
                }
                carte[i].Width = 65;
                carte[i].Height = 100;
                carte[i].SizeMode = PictureBoxSizeMode.StretchImage;
                carte[i].Visible = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            carte_retro[cartaScoperta1].Visible = true;
            carte_retro[cartaScoperta2].Visible = true;

            timer1.Stop();
        }

        private void lblMosse_Click(object sender, EventArgs e)
        {
            secret++;
            if (secret == 1)
            {
                lblMosse.Text = "Stop.";
            }
            if (secret == 2)
            {
                lblMosse.Text = "Why you did it again";
            }
            if (secret == 3)
            {
                lblMosse.Text = "...";
            }
            if (secret == 4)
            {
                lblMosse.Text = "Do you think you will get something special?";
            }
            if (secret == 5)
            {
                lblMosse.Text = "No";
            }
            if (secret == 6)
            {
                lblMosse.Text = "You will not give up untile a prize right?";
            }
            if (secret == 7)
            {
                lblMosse.Text = "Ok then here your prize";
                MessageBox.Show("Congratulation you found out the secret ending");
                Close();
            }
        }
    }
}
