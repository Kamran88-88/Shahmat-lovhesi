using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button[,] buttons = new Button[8,8];
            Label[,] label = new Label[8,8];

            for (int i = 0; i < buttons.GetLength(0); i++)
            {
                for (int j = 0; j < buttons.GetLength(1); j++)
                {
                    buttons[i, j] = new Button();
                    label[i, j] = new Label();

                    buttons[i, j].Click += Form1_Click;
                    buttons[i, j].BackColor = Color.White;
                    if (j%2!=0&&i%2==0)
                    {
                        buttons[i, j].BackColor = Color.Black;
                    }
                    else if(j % 2 == 0 && i % 2 != 0)
                    {
                        buttons[i, j].BackColor = Color.Black;
                    }
                    char c = (char)(65 + j);
                    label[i, j].Text=new string(c,1);
                    label[i, j].Location = new Point(i, j * 60+60);

                    buttons[i,j].Size = new Size(55, 55);
                    buttons[i, j].Location = new Point(i * 54+40, j * 54+40);
                    this.Controls.Add(buttons[i, j]);
                    this.Controls.Add(label[i,j]);
                }
            }
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            if (button.BackColor==Color.White)
            {
                MessageBox.Show(button.BackColor.ToString());
            }
            else
            {
                MessageBox.Show(button.BackColor.ToString());
            }
            
          
        }
    }
}
