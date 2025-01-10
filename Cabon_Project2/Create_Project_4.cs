using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using static Cabon_Project2.MainMenu;
using Newtonsoft.Json;
using System.IO;


namespace Cabon_Project2
{
    public partial class Create_Project_4 : Form
    {
        public int State_Button1 = 0;
        public int State_Button2 = 0;
        public int State_Button3 = 0;
        public int State_Button4 = 0;
        public Create_Project_4()
        {
            InitializeComponent();
            /*if (SharedData.Last_State != "3")
            {
                Textbox_Material.Text = Json_Create_Project.Json_Material;
                Textbox_Build.Text = Json_Create_Project.Json_Bulid;
                TextBox_BasicMat.Text = Json_Create_Project.Json_BasicMat;
                TextBox_Process.Text = Json_Create_Project.Json_Process;
                cBox_StateOper.Text = Json_Create_Project.Json_Stateofoper;
            }*/

            if (SharedData.Last_State != "4")
            {
                State_Button1 = Json_Create_Project.Json_GenProcess1;
                State_Button2 = Json_Create_Project.Json_GenProcess2;
                State_Button3 = Json_Create_Project.Json_GenProcess3;
                State_Button4 = Json_Create_Project.Json_GenProcess4;
                if (State_Button1 == 3)
                {
                    State_Button1 = 3;
                    BT_icon_13.BackColor = Color.Red;
                    BT_icon_13.IconChar = FontAwesome.Sharp.IconChar.Check;
                    BT_icon_12.BackColor = Color.White;
                    BT_icon_11.BackColor = Color.White;
                    BT_icon_12.IconChar = FontAwesome.Sharp.IconChar.None;
                    BT_icon_11.IconChar = FontAwesome.Sharp.IconChar.None;
                }
                else if (State_Button1 == 2)
                {

                    State_Button1 = 2;
                    BT_icon_12.BackColor = Color.Red;
                    BT_icon_12.IconChar = FontAwesome.Sharp.IconChar.Check;
                    BT_icon_13.BackColor = Color.White;
                    BT_icon_11.BackColor = Color.White;
                    BT_icon_13.IconChar = FontAwesome.Sharp.IconChar.None;
                    BT_icon_11.IconChar = FontAwesome.Sharp.IconChar.None;
                }
                else if (State_Button1 == 1)
                {

                    State_Button1 = 1;
                    BT_icon_11.BackColor = Color.Red;
                    BT_icon_11.IconChar = FontAwesome.Sharp.IconChar.Check;
                    BT_icon_12.BackColor = Color.White;
                    BT_icon_13.BackColor = Color.White;
                    BT_icon_12.IconChar = FontAwesome.Sharp.IconChar.None;
                    BT_icon_13.IconChar = FontAwesome.Sharp.IconChar.None;
                }

                if (State_Button2 == 3)
                {

                    State_Button2 = 3;
                    BT_icon_23.BackColor = Color.Red;
                    BT_icon_23.IconChar = FontAwesome.Sharp.IconChar.Check;
                    BT_icon_22.BackColor = Color.White;
                    BT_icon_21.BackColor = Color.White;
                    BT_icon_22.IconChar = FontAwesome.Sharp.IconChar.None;
                    BT_icon_21.IconChar = FontAwesome.Sharp.IconChar.None;

                }
                else if (State_Button2 == 2)
                {
                    State_Button2 = 2;
                    BT_icon_22.BackColor = Color.Red;
                    BT_icon_22.IconChar = FontAwesome.Sharp.IconChar.Check;
                    BT_icon_23.BackColor = Color.White;
                    BT_icon_21.BackColor = Color.White;
                    BT_icon_23.IconChar = FontAwesome.Sharp.IconChar.None;
                    BT_icon_21.IconChar = FontAwesome.Sharp.IconChar.None;
                }
                else if (State_Button2 == 1)
                {
                    State_Button2 = 1;
                    BT_icon_21.BackColor = Color.Red;
                    BT_icon_21.IconChar = FontAwesome.Sharp.IconChar.Check;
                    BT_icon_23.BackColor = Color.White;
                    BT_icon_22.BackColor = Color.White;
                    BT_icon_23.IconChar = FontAwesome.Sharp.IconChar.None;
                    BT_icon_22.IconChar = FontAwesome.Sharp.IconChar.None;
                }

                if (State_Button3 == 3)
                {
                    State_Button3 = 3;
                    BT_icon_33.BackColor = Color.Red;
                    BT_icon_33.IconChar = FontAwesome.Sharp.IconChar.Check;
                    BT_icon_31.BackColor = Color.White;
                    BT_icon_32.BackColor = Color.White;
                    BT_icon_31.IconChar = FontAwesome.Sharp.IconChar.None;
                    BT_icon_32.IconChar = FontAwesome.Sharp.IconChar.None;
                }
                else if (State_Button3 == 2)
                {

                    State_Button3 = 2;
                    BT_icon_32.BackColor = Color.Red;
                    BT_icon_32.IconChar = FontAwesome.Sharp.IconChar.Check;
                    BT_icon_33.BackColor = Color.White;
                    BT_icon_31.BackColor = Color.White;
                    BT_icon_33.IconChar = FontAwesome.Sharp.IconChar.None;
                    BT_icon_31.IconChar = FontAwesome.Sharp.IconChar.None;
                }
                else if (State_Button3 == 1)
                {
                    State_Button3 = 1;
                    BT_icon_31.BackColor = Color.Red;
                    BT_icon_31.IconChar = FontAwesome.Sharp.IconChar.Check;
                    BT_icon_33.BackColor = Color.White;
                    BT_icon_32.BackColor = Color.White;
                    BT_icon_33.IconChar = FontAwesome.Sharp.IconChar.None;
                    BT_icon_32.IconChar = FontAwesome.Sharp.IconChar.None;
                }
                if (State_Button4 == 3)
                {
                    State_Button4 = 3;
                    BT_icon_43.BackColor = Color.Red;
                    BT_icon_43.IconChar = FontAwesome.Sharp.IconChar.Check;
                    BT_icon_41.BackColor = Color.White;
                    BT_icon_42.BackColor = Color.White;
                    BT_icon_41.IconChar = FontAwesome.Sharp.IconChar.None;
                    BT_icon_42.IconChar = FontAwesome.Sharp.IconChar.None;
                }
                else if (State_Button4 == 2)
                {
                    State_Button4 = 2;
                    BT_icon_42.BackColor = Color.Red;
                    BT_icon_42.IconChar = FontAwesome.Sharp.IconChar.Check;
                    BT_icon_43.BackColor = Color.White;
                    BT_icon_41.BackColor = Color.White;
                    BT_icon_43.IconChar = FontAwesome.Sharp.IconChar.None;
                    BT_icon_41.IconChar = FontAwesome.Sharp.IconChar.None;

                }
                else if (State_Button4 == 1)
                {

                    State_Button4 = 1;
                    BT_icon_41.BackColor = Color.Red;
                    BT_icon_41.IconChar = FontAwesome.Sharp.IconChar.Check;
                    BT_icon_43.BackColor = Color.White;
                    BT_icon_42.BackColor = Color.White;
                    BT_icon_43.IconChar = FontAwesome.Sharp.IconChar.None;
                    BT_icon_42.IconChar = FontAwesome.Sharp.IconChar.None;
                }
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
            
            if (State_Button1 == 0 || State_Button2 == 0 ||
                State_Button3 == 0 || State_Button4 == 0 )
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบทุกช่อง", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Json_Create_Project.Json_GenProcess1 = State_Button1;
            Json_Create_Project.Json_GenProcess2 = State_Button2;
            Json_Create_Project.Json_GenProcess3 = State_Button3;
            Json_Create_Project.Json_GenProcess4 = State_Button4;
            SharedData.State_data = "5";
        }

        private void Button_Back_Click(object sender, EventArgs e)
        {
            
            SharedData.State_data = "3";
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        

        private void BT_icon_13_Click(object sender, EventArgs e)
        {
            if (State_Button1 != 3)
            {
                State_Button1 = 3;
                BT_icon_13.BackColor = Color.Red;
                BT_icon_13.IconChar = FontAwesome.Sharp.IconChar.Check;
            }
            BT_icon_12.BackColor = Color.White;
            BT_icon_11.BackColor = Color.White;
            BT_icon_12.IconChar = FontAwesome.Sharp.IconChar.None;
            BT_icon_11.IconChar = FontAwesome.Sharp.IconChar.None;
        }

        private void BT_icon_12_Click(object sender, EventArgs e)
        {
            if (State_Button1 != 2)
            {
                State_Button1 = 2;
                BT_icon_12.BackColor = Color.Red;
                BT_icon_12.IconChar = FontAwesome.Sharp.IconChar.Check;
            }
            BT_icon_13.BackColor = Color.White;
            BT_icon_11.BackColor = Color.White;
            BT_icon_13.IconChar = FontAwesome.Sharp.IconChar.None;
            BT_icon_11.IconChar = FontAwesome.Sharp.IconChar.None;
        }

        private void BT_icon_11_Click(object sender, EventArgs e)
        {
            if (State_Button1 != 1)
            {
                State_Button1 = 1;
                BT_icon_11.BackColor = Color.Red;
                BT_icon_11.IconChar = FontAwesome.Sharp.IconChar.Check;
            }
            BT_icon_12.BackColor = Color.White;
            BT_icon_13.BackColor = Color.White;
            BT_icon_12.IconChar = FontAwesome.Sharp.IconChar.None;
            BT_icon_13.IconChar = FontAwesome.Sharp.IconChar.None;
        }

        private void BT_icon_23_Click(object sender, EventArgs e)
        {
            if (State_Button2 != 3)
            {
                State_Button2 = 3;
                BT_icon_23.BackColor = Color.Red;
                BT_icon_23.IconChar = FontAwesome.Sharp.IconChar.Check;
            }
            BT_icon_22.BackColor = Color.White;
            BT_icon_21.BackColor = Color.White;
            BT_icon_22.IconChar = FontAwesome.Sharp.IconChar.None;
            BT_icon_21.IconChar = FontAwesome.Sharp.IconChar.None;
        }

        private void BT_icon_22_Click(object sender, EventArgs e)
        {
            if (State_Button2 != 2)
            {
                State_Button2 = 2;
                BT_icon_22.BackColor = Color.Red;
                BT_icon_22.IconChar = FontAwesome.Sharp.IconChar.Check;
            }
            BT_icon_23.BackColor = Color.White;
            BT_icon_21.BackColor = Color.White;
            BT_icon_23.IconChar = FontAwesome.Sharp.IconChar.None;
            BT_icon_21.IconChar = FontAwesome.Sharp.IconChar.None;
        }

        private void BT_icon_21_Click(object sender, EventArgs e)
        {
            if (State_Button2 != 1)
            {
                State_Button2 = 1;
                BT_icon_21.BackColor = Color.Red;
                BT_icon_21.IconChar = FontAwesome.Sharp.IconChar.Check;
            }
            BT_icon_23.BackColor = Color.White;
            BT_icon_22.BackColor = Color.White;
            BT_icon_23.IconChar = FontAwesome.Sharp.IconChar.None;
            BT_icon_22.IconChar = FontAwesome.Sharp.IconChar.None;
        }

        private void BT_icon_33_Click(object sender, EventArgs e)
        {
            if (State_Button3 != 3)
            {
                State_Button3 = 3;
                BT_icon_33.BackColor = Color.Red;
                BT_icon_33.IconChar = FontAwesome.Sharp.IconChar.Check;
            }
            BT_icon_31.BackColor = Color.White;
            BT_icon_32.BackColor = Color.White;
            BT_icon_31.IconChar = FontAwesome.Sharp.IconChar.None;
            BT_icon_32.IconChar = FontAwesome.Sharp.IconChar.None;
        }

        private void BT_icon_32_Click(object sender, EventArgs e)
        {
            if (State_Button3 != 2)
            {
                State_Button3 = 2;
                BT_icon_32.BackColor = Color.Red;
                BT_icon_32.IconChar = FontAwesome.Sharp.IconChar.Check;
            }
            BT_icon_33.BackColor = Color.White;
            BT_icon_31.BackColor = Color.White;
            BT_icon_33.IconChar = FontAwesome.Sharp.IconChar.None;
            BT_icon_31.IconChar = FontAwesome.Sharp.IconChar.None;
        }

        private void BT_icon_31_Click(object sender, EventArgs e)
        {
            if (State_Button3 != 1)
            {
                State_Button3 = 1;
                BT_icon_31.BackColor = Color.Red;
                BT_icon_31.IconChar = FontAwesome.Sharp.IconChar.Check;
            }
            BT_icon_33.BackColor = Color.White;
            BT_icon_32.BackColor = Color.White;
            BT_icon_33.IconChar = FontAwesome.Sharp.IconChar.None;
            BT_icon_32.IconChar = FontAwesome.Sharp.IconChar.None;
        }

        private void BT_icon_43_Click(object sender, EventArgs e)
        {
            if (State_Button4 != 3)
            {
                State_Button4 = 3;
                BT_icon_43.BackColor = Color.Red;
                BT_icon_43.IconChar = FontAwesome.Sharp.IconChar.Check;
            }
            BT_icon_41.BackColor = Color.White;
            BT_icon_42.BackColor = Color.White;
            BT_icon_41.IconChar = FontAwesome.Sharp.IconChar.None;
            BT_icon_42.IconChar = FontAwesome.Sharp.IconChar.None;
        }

        private void BT_icon_42_Click(object sender, EventArgs e)
        {
            if (State_Button4 != 2)
            {
                State_Button4 = 2;
                BT_icon_42.BackColor = Color.Red;
                BT_icon_42.IconChar = FontAwesome.Sharp.IconChar.Check;
            }
            BT_icon_43.BackColor = Color.White;
            BT_icon_41.BackColor = Color.White;
            BT_icon_43.IconChar = FontAwesome.Sharp.IconChar.None;
            BT_icon_41.IconChar = FontAwesome.Sharp.IconChar.None;
        }

        private void BT_icon_41_Click(object sender, EventArgs e)
        {
            if (State_Button4 != 1)
            {
                State_Button4 = 1;
                BT_icon_41.BackColor = Color.Red;
                BT_icon_41.IconChar = FontAwesome.Sharp.IconChar.Check;
            }
            BT_icon_43.BackColor = Color.White;
            BT_icon_42.BackColor = Color.White;
            BT_icon_43.IconChar = FontAwesome.Sharp.IconChar.None;
            BT_icon_42.IconChar = FontAwesome.Sharp.IconChar.None;

        }
    }
}
