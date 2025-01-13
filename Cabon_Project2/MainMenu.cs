using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace Cabon_Project2
{
    public partial class MainMenu : Form
    {
        private Timer stateCheckTimer;

        private IconButton currentbtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        public MainMenu()
        {
            InitializeComponent();
            InitializeStateChecker();

            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7,60);
            PanelMenu.Controls.Add(leftBorderBtn);

            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;

            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;

            OpenChildForm(new Home_Page());
            lblTitleChildForm.Text = "Home";
            
            // this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172,126,241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }
        private void ActivateButton(object senderBtn, Color color)
        {
            Console.WriteLine(currentbtn);
           
            if (senderBtn != null)
            {
                DisableButton();

                currentbtn = (IconButton)senderBtn;
                currentbtn.BackColor = Color.FromArgb(37,36,81);
                currentbtn.ForeColor = color;
                currentbtn.TextAlign = ContentAlignment.MiddleCenter;
                currentbtn.IconColor = color;
                
                currentbtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentbtn.ImageAlign = ContentAlignment.MiddleRight;
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0,currentbtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Icon Current Child Form
                iconCurrentChild.IconChar = currentbtn.IconChar;
                iconCurrentChild.IconColor = color;
                
            }
        }
        private void DisableButton()
        {
            if (currentbtn != null)
            {
                currentbtn.BackColor = Color.FromArgb(31,30,68);
                currentbtn.ForeColor = Color.Gainsboro;
                currentbtn.TextAlign = ContentAlignment.MiddleLeft;
                currentbtn.IconColor = Color.Gainsboro;
                currentbtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentbtn.ImageAlign = ContentAlignment.MiddleLeft;
                currentbtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            

            }
        }
      
        private void OpenChildForm(Form ChildForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(ChildForm);
            panelDesktop.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
            
        }

        private void Page_Home_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new Home_Page());
            lblTitleChildForm.Text = "Home";
            
        }
        private void InitializeStateChecker()
        {
            stateCheckTimer = new Timer();
            stateCheckTimer.Interval = 500; // Check every 500ms
            stateCheckTimer.Tick += State_Create_Project;
            stateCheckTimer.Start();
        }
        private void State_Create_Project(object sender, EventArgs e)
        {
            if (SharedData.State_data == "1") //Create Project 2
            {
                if (SharedData.Last_State == "0")
                {
                    SharedData.State_data = "0";
                    SharedData.Last_State = "1";
                    OpenChildForm(new Create_Project_1());

                }
                else if (SharedData.Last_State != "0")
                {
                    SharedData.State_data = "0";
                    OpenChildForm(new Create_Project_1());

                    // SharedData.State_data = "0";

                }

            }
            else if (SharedData.State_data == "2") //Create Project 2
            {
                if (SharedData.Last_State == "1")
                {
                    SharedData.State_data = "0";
                    SharedData.Last_State = "2";
                    OpenChildForm(new Create_Project_2());

                }
                else if (SharedData.Last_State != "1")
                {
                    SharedData.State_data = "0";
                    OpenChildForm(new Create_Project_2());

                    // SharedData.State_data = "0";

                }

            }
            else if (SharedData.State_data == "3") //Create Project 3
            {
                if (SharedData.Last_State == "2")
                {
                    SharedData.State_data = "0";
                    SharedData.Last_State = "3";
                    OpenChildForm(new Create_Project_3());

                }
                else if (SharedData.Last_State != "2")
                {
                    SharedData.State_data = "0";
                    OpenChildForm(new Create_Project_3());

                    // SharedData.State_data = "0";

                }

            }
            else if (SharedData.State_data == "4") //Create Project 4
            {
                if (SharedData.Last_State == "3")
                {
                    SharedData.State_data = "0";
                    SharedData.Last_State = "4";
                    OpenChildForm(new Create_Project_4());

                }
                else if (SharedData.Last_State != "3")
                {
                    SharedData.State_data = "0";
                    OpenChildForm(new Create_Project_4());

                    // SharedData.State_data = "0";

                }

            }
            else if (SharedData.State_data == "5") //Create Project 5
            {
                if (SharedData.Last_State == "4")
                {
                    SharedData.State_data = "0";
                    SharedData.Last_State = "5";
                    OpenChildForm(new Create_Project_5());

                }
                else if (SharedData.Last_State != "4")
                {
                    SharedData.State_data = "0";
                    OpenChildForm(new Create_Project_5());

                    // SharedData.State_data = "0";

                }

            }
            else if (SharedData.State_data == "6") //Create Project 6
            {
                if (SharedData.Last_State == "5")
                {
                    SharedData.State_data = "0";
                    SharedData.Last_State = "6";
                    OpenChildForm(new Create_Project_6());

                }
                else if (SharedData.Last_State != "5")
                {
                    SharedData.State_data = "0";
                    OpenChildForm(new Create_Project_6());

                    // SharedData.State_data = "0";

                }

            }
            else if (SharedData.State_data == "7") //Create Project 7
            {
                if (SharedData.Last_State == "6")
                {
                    SharedData.State_data = "0";
                    SharedData.Last_State = "7";
                    OpenChildForm(new Create_Project_7());

                }
                else if (SharedData.Last_State != "6")
                {
                    SharedData.State_data = "0";
                    OpenChildForm(new Create_Project_7());

                    // SharedData.State_data = "0";

                }

            }
            else if (SharedData.State_data == "8") //Create Project 8
            {
                if (SharedData.Last_State == "7")
                {
                    SharedData.State_data = "0";
                    SharedData.Last_State = "8";
                    OpenChildForm(new Create_Project_8());

                }
                else if (SharedData.Last_State != "7")
                {
                    SharedData.State_data = "0";
                    OpenChildForm(new Create_Project_8());

                    // SharedData.State_data = "0";

                }

            }
            else if (SharedData.State_data == "9") //Create Project 8
            {
                if (SharedData.Last_State == "8")
                {
                    SharedData.State_data = "0";
                    SharedData.Last_State = "9";
                    OpenChildForm(new Create_Project_9());

                }
                else if (SharedData.Last_State != "8")
                {
                    SharedData.State_data = "0";
                    OpenChildForm(new Create_Project_9());

                    // SharedData.State_data = "0";

                }

            }
            else
            {

            }

        }
        public static class SharedData
        {
            public static string State_data { get; set; }
            public static string Last_State { get; set; }
        }
        public static class Json_Create_Project
        {
            public static string Json_ProjectName { get; set; }
            public static string Json_Area { get; set; }
            public static string Json_Site { get; set; }
            public static string Json_Division { get; set; }
            public static string Json_Mnfg { get; set; }
            public static string Json_Location { get; set; }
            public static string Json_Prepared { get; set; }
            public static string Json_Appr { get; set; }
            public static string Json_ReviewedbyMgt{ get; set; }
            public static string Json_Review { get; set; }
            public static string Json_Material { get; set; }
            public static string Json_Bulid { get; set; }
            public static string Json_BasicMat { get; set; }
            public static string Json_Process { get; set; }
            public static string Json_Stateofoper { get; set; }
            // Json data scor 1-3
            public static int Json_GenProcess1 { get; set; } = 0;
            public static int Json_GenProcess2 { get; set; } = 0;
            public static int Json_GenProcess3 { get; set; } = 0;
            public static int Json_GenProcess4 { get; set; } = 0;
            public static int Json_GenProcess5 { get; set; } = 0;
            public static int Json_GenProcess6 { get; set; } = 0;
            public static int Json_GenProcess7 { get; set; } = 0;
            public static int Json_GenProcess8 { get; set; } = 0;
            public static int Json_GenProcess9 { get; set; } = 0;
            public static int Json_GenProcess10 { get; set; } = 0;
            public static int Json_GenProcess11 { get; set; } = 0;
            public static int Json_GenProcess12 { get; set; } = 0;
            public static int Json_GenProcess13 { get; set; } = 0;
            public static int Json_GenProcess14 { get; set; } = 0;
            public static int Json_GenProcess15 { get; set; } = 0;
            public static int Json_GenProcess16 { get; set; } = 0;
            public static int Json_GenProcess17 { get; set; } = 0;
            public static int Json_GenProcess18 { get; set; } = 0;
            // End 
            public static int[] Json_YN_score { get; set; } = new int[20];
            public static string[] Json_YN_description { get; set; }
        }

        private void Page_2_Click(object sender, EventArgs e) //create New Project
        {
            
            if (System.Windows.Forms.MessageBox.Show("Do you want to Create New Project?","Create", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes) {

                SharedData.State_data = "1";
                SharedData.Last_State = "0";

                ActivateButton(sender, RGBColors.color2);
                //OpenChildForm(new Create_Project_1());
                lblTitleChildForm.Text = "Create Cabon Footprint Test";

               


            }
            else
            {
                ActivateButton(sender, RGBColors.color1);
                OpenChildForm(new Home_Page());
                lblTitleChildForm.Text = "Home";
            }
        }

        private void Page_3_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
        }

        private void Page_4_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
        }

        private void Page_5_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
        }

        private void Page_6_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChild.IconChar = IconChar.Home;
            iconCurrentChild.IconColor = Color.MediumPurple;
            lblTitleChildForm.Text = "Home";
            Console.WriteLine("YOU Click LOGO");
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
           // ReleaseCapture();
            //SendMessage(this.Handle,0x112,0xf012,0);
        }

        private void iconExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void iconmaximize_Click(object sender, EventArgs e)
        {
            if (WindowState ==FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState=FormWindowState.Normal;
            }
        }

        private void iconMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized ;
        }

        private void iconCurrentChild_Click(object sender, EventArgs e)
        {

        }
    }
}
