using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AndengradslommeregnerV2
{
    public partial class Andengradslommeregner : Form
    {
        private double Discriminant;
        private double NegativeDiscriminant;
        private double SquarerootOfDiscriminant;

        private double Answer1;
        private double Answer2;

        private double Tx;
        private double Ty;
        
        private string STRINGa;
        private string STRINGb;
        private string STRINGc;

        private double a;
        private double b;
        private double c;


        public Andengradslommeregner()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Convets all string values to floats

            //a
            STRINGa = textBox1.Text;
            a = System.Convert.ToSingle(STRINGa);
            //b
            STRINGb = textBox2.Text;
            b = System.Convert.ToSingle(STRINGb);
            //c
            STRINGc = textBox3.Text;
            c = System.Convert.ToSingle(STRINGc);

            //Calculates Discriminant
            Discriminant = ((b * b) - (4 * a * c)); ;
            NegativeDiscriminant = ((Discriminant - Discriminant - Discriminant));
            SquarerootOfDiscriminant = Math.Sqrt(Discriminant);

            //Calculates Answers
            if (Discriminant >= 0)
                Answer1 = (-b - Math.Sqrt(Discriminant)) / (2 * a);

            if (Discriminant > 0)
                Answer2 = ((-b + Math.Sqrt(Discriminant))) / (2 * a);

            //Calculates Top Points
            Tx = -b / (2 * a);
            Ty = -Discriminant / (4 * a);

            //Rounds Decimals
            Discriminant = Math.Round(Discriminant, 5);
            Answer1 = Math.Round(Answer1, 5);
            Answer2 = Math.Round(Answer2, 5);
            Tx = Math.Round(Tx, 5);
            Ty = Math.Round(Ty, 5);

            //Draws answers
            label1.Text = "" + Discriminant;

            if (Discriminant > 0)
            {
                label5.Text = Answer1 + " and " + Answer2;
            }
            else if (Discriminant == 0)
            {
                label5.Text = "" + Answer1;
            }
            else if (Discriminant < 0)
            {
                label5.Text = "none";
            }

            label6.Text = "(" + Tx + " ; " + Ty + ")";

            //Resets Answers
            Answer1 = 0;
            Answer2 = 0;
            Tx = 0;
            Ty = 0;
        }
    }
}