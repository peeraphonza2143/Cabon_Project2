using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Cabon_Project2.MainMenu;

namespace Cabon_Project2
{
    public partial class MessageBox : Form
    {
        private int data_Send = 0;
        public MessageBox(int A)
        {
            InitializeComponent();
            data_Send = A;
            if (Json_Create_Project.Json_YN_score[data_Send] == 1)
            {
                Button_score1.BackColor = Color.Green;
                Button_score2.BackColor = Color.Gray;
                Button_score3.BackColor = Color.Gray;
                Button_score4.BackColor = Color.Gray;
            }
            else if (Json_Create_Project.Json_YN_score[data_Send] == 2)
            {
                Button_score1.BackColor = Color.Gray;
                Button_score2.BackColor = Color.Green;
                Button_score3.BackColor = Color.Gray;
                Button_score4.BackColor = Color.Gray;
            }
            else if (Json_Create_Project.Json_YN_score[data_Send] == 3)
            {
                Button_score1.BackColor = Color.Gray;
                Button_score2.BackColor = Color.Gray;
                Button_score3.BackColor = Color.Green;
                Button_score4.BackColor = Color.Gray;
            }
            else if (Json_Create_Project.Json_YN_score[data_Send] == 4)
            {
                Button_score1.BackColor = Color.Gray;
                Button_score2.BackColor = Color.Gray;
                Button_score3.BackColor = Color.Gray;
                Button_score4.BackColor = Color.Green;
            }
            else
            {
                Button_score1.BackColor = Color.White;
                Button_score2.BackColor = Color.White;
                Button_score3.BackColor = Color.White;
            }


        }

        private void CustomMessageBox_Load(object sender, EventArgs e)
        {
           
        }

        private void Button_score1_Click(object sender, EventArgs e)
        {
            Json_Create_Project.Json_YN_score[data_Send] = 1;
            this.Close();

        }

        private void Button_score2_Click(object sender, EventArgs e)
        {
            Json_Create_Project.Json_YN_score[data_Send] = 2;
            this.Close();

        }

        private void Button_score3_Click(object sender, EventArgs e)
        {
            Json_Create_Project.Json_YN_score[data_Send] = 3;
            this.Close();

        }

        private void Button_score4_Click(object sender, EventArgs e)
        {
            Json_Create_Project.Json_YN_score[data_Send] = 4;
            this.Close();
        }
    }
}
