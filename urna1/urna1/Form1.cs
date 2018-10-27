using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace urna1
{
    public partial class Form1 : Form

    {
        
        public Form1()
        {
            InitializeComponent();
            
        }
        string num1;
        string nomeCandidato;
        string nomePartido;

        
        
        //388; 448

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Click_num(object sender, EventArgs e)
        {
            Button num = (Button)sender;

            txtValor.Text =  txtValor.Text + num.Text;
            num1 = txtValor.Text;
            
            switch (num1)
            {
                case "17":
                    nomeCandidato = "Jair Messias Bolsonaro";
                    nomePartido = "PSL";
                    txtNome.Text = System.Convert.ToString(nomeCandidato);
                    txtPartido.Text = System.Convert.ToString(nomePartido);
                    pctCandidato.Load("bolsonaro.jpg");
                    break;
                default:
                    break;
            }

            

        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtPartido.Clear();
            pctCandidato.Load("branco.png");
            txtValor.Clear();

        }

        private void click_Confirma(object sender, EventArgs e)
        {


            pctFim.Width = 389;
            pctFim.Load("fim.png");
            SoundPlayer soundPlayer = new SoundPlayer(@"C:\Users\Manoel Clemente\source\repos\Urna\urna1\urna1\bin\Debug\1.wav");
            soundPlayer.Play();

        }
    }
}
