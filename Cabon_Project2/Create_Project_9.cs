using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using static Cabon_Project2.MainMenu;
using Newtonsoft.Json;
using System.IO;


namespace Cabon_Project2
{
    public partial class Create_Project_9 : Form
    {
        private Timer stateCheckTimer2;
        public int State_Button1 = -1;
        public int State_Button2 = -1;
        public int State_Button3 = -1;


        public Create_Project_9()
        {
            InitializeComponent();
            InitializeStateChecker();

            if (SharedData.Last_State != "9")
            {
                Textbox_Des_1.Text = Json_Create_Project.Json_YN_description[1] ;
                Textbox_Des_2.Text = Json_Create_Project.Json_YN_description[2];
                Textbox_Des_3.Text = Json_Create_Project.Json_YN_description[3];
                State_Button1 = Json_Create_Project.Json_YN_score[1] ;
                State_Button2 = Json_Create_Project.Json_YN_score[2];
                State_Button3 = Json_Create_Project.Json_YN_score[3];
            }

        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            // this.FormBorderStyle = FormBorderStyle.None;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Button_Next_Click(object sender, EventArgs e)
        {
            /*
            Json_Create_Project.Json_Material = Textbox_Material.Text;
            Json_Create_Project.Json_Bulid = Textbox_Build.Text;
            Json_Create_Project.Json_BasicMat = TextBox_BasicMat.Text;
            Json_Create_Project.Json_Process = TextBox_Process.Text;
            Json_Create_Project.Json_Stateofoper = cBox_StateOper.Text;

            if (string.IsNullOrWhiteSpace(Textbox_Material.Text) ||
             string.IsNullOrWhiteSpace(Textbox_Build.Text) ||
             string.IsNullOrWhiteSpace(TextBox_BasicMat.Text) ||
             string.IsNullOrWhiteSpace(TextBox_Process.Text) ||
             string.IsNullOrWhiteSpace(cBox_StateOper.Text))
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบทุกช่อง", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }*/

            if (State_Button1 == -1 || State_Button2 == -1 ||
                State_Button3 == -1)
            {
                System.Windows.Forms.MessageBox.Show("กรุณากรอกข้อมูลให้ครบทุกช่อง", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Json_Create_Project.Json_YN_description[1] = Textbox_Des_1.Text;
            Json_Create_Project.Json_YN_description[2] = Textbox_Des_2.Text;
            Json_Create_Project.Json_YN_description[3] = Textbox_Des_3.Text;

            SharedData.State_data = "10";
        }

        private void Button_Back_Click(object sender, EventArgs e)
        {

            SharedData.State_data = "8";
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }


        private void InitializeStateChecker()
        {
            stateCheckTimer2 = new Timer();
            stateCheckTimer2.Interval = 500; // Check every 500ms
            stateCheckTimer2.Tick += Button_State_Active;
            stateCheckTimer2.Start();
        }
        private void Button_State_Active(object sender, EventArgs e)
        {
            if (State_Button1 > 0)
            {
                IButton_Yes_1.BackColor = Color.Green;
                IButton_No_1.BackColor = Color.Gray;  
            }
            else if (State_Button1 == 0)
            {
                IButton_No_1.BackColor = Color.Red;
                IButton_Yes_1.BackColor = Color.Gray;
            }
            if (State_Button2 > 0)
            {
                IButton_Yes_2.BackColor = Color.Green;
                IButton_No_2.BackColor = Color.Gray;
            }
            else if (State_Button2 == 0)
            {
                IButton_No_2.BackColor = Color.Red;
                IButton_Yes_2.BackColor = Color.Gray;
            }
            if (State_Button3 > 0)
            {
                IButton_Yes_3.BackColor = Color.Green;
                IButton_No_3.BackColor = Color.Gray;
            }
            else if (State_Button3 == 0)
            {
                IButton_No_3.BackColor = Color.Red;
                IButton_Yes_3.BackColor = Color.Gray;
            }

        }
        private void IButton_Yes_1_Click(object sender, EventArgs e)
        {
            int message1 = 1;
            MessageBox FormSelect = new MessageBox(message1);
            State_Button1 = 1;
            FormSelect.Show();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Json_Create_Project.Json_YN_score[1] = 0;
            State_Button1 = 0;
        }

        private void IButton_Yes_2_Click(object sender, EventArgs e)
        {
            int message1 = 2;
            MessageBox FormSelect = new MessageBox(message1);
            State_Button2 = 1;
            FormSelect.Show();
        }

        private void IButton_No_2_Click(object sender, EventArgs e)
        {
            Json_Create_Project.Json_YN_score[2] = 0;
            State_Button2 = 0;
        }

        private void IButton_Yes_3_Click(object sender, EventArgs e)
        {
            int message1 = 3;
            MessageBox FormSelect = new MessageBox(message1);
            State_Button3 = 1;
            FormSelect.Show();
        }

        private void IButton_No_3_Click(object sender, EventArgs e)
        {
            Json_Create_Project.Json_YN_score[3] = 0;
            State_Button3 = 0;
        }
    }
}
