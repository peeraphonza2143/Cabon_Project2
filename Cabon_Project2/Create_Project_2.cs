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
    public partial class Create_Project_2 : Form
    {

        public Create_Project_2()
        {
            InitializeComponent();
            if (SharedData.Last_State != "2")
            {
                Textbox_Prepared.Text = Json_Create_Project.Json_Prepared;
                TextBox_Appr.Text = Json_Create_Project.Json_Appr;
                Textbox_Reviewed.Text = Json_Create_Project.Json_ReviewedbyMgt;
                TextBox_Review.Text = Json_Create_Project.Json_Review;
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
                Json_Create_Project.Json_Prepared=Textbox_Prepared.Text;
                Json_Create_Project.Json_Appr = TextBox_Appr.Text;
                Json_Create_Project.Json_ReviewedbyMgt = Textbox_Reviewed.Text;
                Json_Create_Project.Json_Review = TextBox_Review.Text;

            if (string.IsNullOrWhiteSpace(Textbox_Prepared.Text) ||
             string.IsNullOrWhiteSpace(TextBox_Appr.Text) ||
             string.IsNullOrWhiteSpace(Textbox_Reviewed.Text) ||
             string.IsNullOrWhiteSpace(TextBox_Review.Text))
            {
                System.Windows.Forms.MessageBox.Show("กรุณากรอกข้อมูลให้ครบทุกช่อง", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SharedData.State_data = "3";
        }

        private void Button_Back_Click(object sender, EventArgs e)
        {
            SharedData.State_data = "1";
        }
    }
}
