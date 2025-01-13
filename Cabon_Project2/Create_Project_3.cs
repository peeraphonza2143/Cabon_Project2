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
    public partial class Create_Project_3 : Form
    {

        public Create_Project_3()
        {
            InitializeComponent();
            if (SharedData.Last_State != "3")
            {
                Textbox_Material.Text = Json_Create_Project.Json_Material;
                Textbox_Build.Text = Json_Create_Project.Json_Bulid ;
                 TextBox_BasicMat.Text = Json_Create_Project.Json_BasicMat ;
                 TextBox_Process.Text = Json_Create_Project.Json_Process ;
                cBox_StateOper.Text = Json_Create_Project.Json_Stateofoper;
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
                System.Windows.Forms.MessageBox.Show("กรุณากรอกข้อมูลให้ครบทุกช่อง", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            SharedData.State_data = "4";
        }

        private void Button_Back_Click(object sender, EventArgs e)
        {
            SharedData.State_data = "2";
        }
    }
}
