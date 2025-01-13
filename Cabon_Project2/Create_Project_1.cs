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
    public partial class Create_Project_1 : Form
    {
       
        public Create_Project_1()
        {
            InitializeComponent();
            if (SharedData.Last_State != "1")
            {
                Textbox_NamePro.Text = Json_Create_Project.Json_ProjectName;
                Textbox_Area.Text = Json_Create_Project.Json_Area;
                Textbox_Site.Text = Json_Create_Project.Json_Site;
                TextBox_Mnfg.Text = Json_Create_Project.Json_Mnfg;
                TextBox_Division.Text = Json_Create_Project.Json_Division;
                TextBox_Location.Text = Json_Create_Project.Json_Location;
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
            
            Json_Create_Project.Json_ProjectName = Textbox_NamePro.Text;
            Json_Create_Project.Json_Area = Textbox_Area.Text;
            Json_Create_Project.Json_Site = Textbox_Site.Text;
            Json_Create_Project.Json_Mnfg = TextBox_Mnfg.Text;
            Json_Create_Project.Json_Division = TextBox_Division.Text;
            Json_Create_Project.Json_Location = TextBox_Location.Text;
            // Json Data Keep

            
            if (string.IsNullOrWhiteSpace(Textbox_NamePro.Text) ||
                string.IsNullOrWhiteSpace(Textbox_Area.Text) ||
                string.IsNullOrWhiteSpace(Textbox_Site.Text) ||
                string.IsNullOrWhiteSpace(TextBox_Mnfg.Text) ||
                string.IsNullOrWhiteSpace(TextBox_Division.Text) ||
                string.IsNullOrWhiteSpace(TextBox_Location.Text))
            {
                System.Windows.Forms.MessageBox.Show("กรุณากรอกข้อมูลให้ครบทุกช่อง", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            /*
            // สร้างอ็อบเจ็กต์สำหรับเก็บข้อมูล
            var projectData = new
            {
                NamePro = Textbox_NamePro.Text,
                Area = Textbox_Area.Text,
                Site = Textbox_Site.Text,
                Manufacturer = TextBox_Mnfg.Text,
                Division = TextBox_Division.Text,
                Location = TextBox_Location.Text
            };

            // แปลงข้อมูลเป็น JSON
            string json = JsonConvert.SerializeObject(projectData, Formatting.Indented);

            // กำหนด Path ของโปรเจกต์
            string projectPath = AppDomain.CurrentDomain.BaseDirectory; // Path ของโปรเจกต์
            string filePath = Path.Combine(projectPath, "ProjectData.json"); // รวม Path กับชื่อไฟล์

            // บันทึกไฟล์ JSON
            File.WriteAllText(filePath, json);

            // แจ้งผู้ใช้เมื่อบันทึกสำเร็จ
            */
            SharedData.State_data = "2";



        }
    }
}
