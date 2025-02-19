﻿namespace Cabon_Project2
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.PanelLOGO = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.iconMinimize = new FontAwesome.Sharp.IconPictureBox();
            this.iconExit = new FontAwesome.Sharp.IconPictureBox();
            this.iconCurrentChild = new FontAwesome.Sharp.IconPictureBox();
            this.Page_6 = new FontAwesome.Sharp.IconButton();
            this.Page_5 = new FontAwesome.Sharp.IconButton();
            this.Page_4 = new FontAwesome.Sharp.IconButton();
            this.Page_3 = new FontAwesome.Sharp.IconButton();
            this.Page_2 = new FontAwesome.Sharp.IconButton();
            this.Page_Home = new FontAwesome.Sharp.IconButton();
            this.LOGO_Home = new System.Windows.Forms.PictureBox();
            this.PanelMenu.SuspendLayout();
            this.PanelLOGO.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChild)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LOGO_Home)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.PanelMenu.Controls.Add(this.Page_6);
            this.PanelMenu.Controls.Add(this.Page_5);
            this.PanelMenu.Controls.Add(this.Page_4);
            this.PanelMenu.Controls.Add(this.Page_3);
            this.PanelMenu.Controls.Add(this.Page_2);
            this.PanelMenu.Controls.Add(this.Page_Home);
            this.PanelMenu.Controls.Add(this.PanelLOGO);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(220, 1041);
            this.PanelMenu.TabIndex = 0;
            // 
            // PanelLOGO
            // 
            this.PanelLOGO.Controls.Add(this.LOGO_Home);
            this.PanelLOGO.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelLOGO.Location = new System.Drawing.Point(0, 0);
            this.PanelLOGO.Name = "PanelLOGO";
            this.PanelLOGO.Size = new System.Drawing.Size(220, 119);
            this.PanelLOGO.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panel1.Controls.Add(this.iconMinimize);
            this.panel1.Controls.Add(this.iconExit);
            this.panel1.Controls.Add(this.lblTitleChildForm);
            this.panel1.Controls.Add(this.iconCurrentChild);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(220, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1684, 119);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitleChildForm.Location = new System.Drawing.Point(64, 52);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(58, 21);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "Home";
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(220, 119);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(1684, 9);
            this.panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            this.panelDesktop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelDesktop.Location = new System.Drawing.Point(220, 125);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1684, 916);
            this.panelDesktop.TabIndex = 3;
            // 
            // iconMinimize
            // 
            this.iconMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconMinimize.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.iconMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.iconMinimize.IconColor = System.Drawing.SystemColors.AppWorkspace;
            this.iconMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMinimize.IconSize = 20;
            this.iconMinimize.Location = new System.Drawing.Point(1639, 2);
            this.iconMinimize.Name = "iconMinimize";
            this.iconMinimize.Size = new System.Drawing.Size(20, 20);
            this.iconMinimize.TabIndex = 4;
            this.iconMinimize.TabStop = false;
            this.iconMinimize.Click += new System.EventHandler(this.iconMinimize_Click);
            // 
            // iconExit
            // 
            this.iconExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconExit.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.iconExit.IconChar = FontAwesome.Sharp.IconChar.Remove;
            this.iconExit.IconColor = System.Drawing.SystemColors.AppWorkspace;
            this.iconExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconExit.IconSize = 20;
            this.iconExit.Location = new System.Drawing.Point(1661, 2);
            this.iconExit.Name = "iconExit";
            this.iconExit.Size = new System.Drawing.Size(20, 20);
            this.iconExit.TabIndex = 2;
            this.iconExit.TabStop = false;
            this.iconExit.Click += new System.EventHandler(this.iconExit_Click);
            // 
            // iconCurrentChild
            // 
            this.iconCurrentChild.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconCurrentChild.ForeColor = System.Drawing.Color.MediumOrchid;
            this.iconCurrentChild.IconChar = FontAwesome.Sharp.IconChar.House;
            this.iconCurrentChild.IconColor = System.Drawing.Color.MediumOrchid;
            this.iconCurrentChild.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChild.IconSize = 35;
            this.iconCurrentChild.Location = new System.Drawing.Point(23, 44);
            this.iconCurrentChild.Name = "iconCurrentChild";
            this.iconCurrentChild.Size = new System.Drawing.Size(35, 35);
            this.iconCurrentChild.TabIndex = 0;
            this.iconCurrentChild.TabStop = false;
            this.iconCurrentChild.Click += new System.EventHandler(this.iconCurrentChild_Click);
            // 
            // Page_6
            // 
            this.Page_6.FlatAppearance.BorderSize = 0;
            this.Page_6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Page_6.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Page_6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Page_6.IconChar = FontAwesome.Sharp.IconChar.Cube;
            this.Page_6.IconColor = System.Drawing.Color.White;
            this.Page_6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Page_6.IconSize = 32;
            this.Page_6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Page_6.Location = new System.Drawing.Point(3, 444);
            this.Page_6.Name = "Page_6";
            this.Page_6.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Page_6.Size = new System.Drawing.Size(214, 55);
            this.Page_6.TabIndex = 6;
            this.Page_6.Text = "Page 6";
            this.Page_6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Page_6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Page_6.UseVisualStyleBackColor = true;
            this.Page_6.Click += new System.EventHandler(this.Page_6_Click);
            // 
            // Page_5
            // 
            this.Page_5.FlatAppearance.BorderSize = 0;
            this.Page_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Page_5.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Page_5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Page_5.IconChar = FontAwesome.Sharp.IconChar.Cube;
            this.Page_5.IconColor = System.Drawing.Color.White;
            this.Page_5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Page_5.IconSize = 32;
            this.Page_5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Page_5.Location = new System.Drawing.Point(3, 383);
            this.Page_5.Name = "Page_5";
            this.Page_5.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Page_5.Size = new System.Drawing.Size(214, 55);
            this.Page_5.TabIndex = 5;
            this.Page_5.Text = "Page 5";
            this.Page_5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Page_5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Page_5.UseVisualStyleBackColor = true;
            this.Page_5.Click += new System.EventHandler(this.Page_5_Click);
            // 
            // Page_4
            // 
            this.Page_4.FlatAppearance.BorderSize = 0;
            this.Page_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Page_4.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Page_4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Page_4.IconChar = FontAwesome.Sharp.IconChar.Cube;
            this.Page_4.IconColor = System.Drawing.Color.White;
            this.Page_4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Page_4.IconSize = 32;
            this.Page_4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Page_4.Location = new System.Drawing.Point(3, 322);
            this.Page_4.Name = "Page_4";
            this.Page_4.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Page_4.Size = new System.Drawing.Size(214, 55);
            this.Page_4.TabIndex = 4;
            this.Page_4.Text = "Page 4";
            this.Page_4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Page_4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Page_4.UseVisualStyleBackColor = true;
            this.Page_4.Click += new System.EventHandler(this.Page_4_Click);
            // 
            // Page_3
            // 
            this.Page_3.FlatAppearance.BorderSize = 0;
            this.Page_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Page_3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Page_3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Page_3.IconChar = FontAwesome.Sharp.IconChar.Cube;
            this.Page_3.IconColor = System.Drawing.Color.White;
            this.Page_3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Page_3.IconSize = 32;
            this.Page_3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Page_3.Location = new System.Drawing.Point(3, 261);
            this.Page_3.Name = "Page_3";
            this.Page_3.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Page_3.Size = new System.Drawing.Size(214, 55);
            this.Page_3.TabIndex = 3;
            this.Page_3.Text = "Page 3";
            this.Page_3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Page_3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Page_3.UseVisualStyleBackColor = true;
            this.Page_3.Click += new System.EventHandler(this.Page_3_Click);
            // 
            // Page_2
            // 
            this.Page_2.FlatAppearance.BorderSize = 0;
            this.Page_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Page_2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Page_2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Page_2.IconChar = FontAwesome.Sharp.IconChar.Cube;
            this.Page_2.IconColor = System.Drawing.Color.White;
            this.Page_2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Page_2.IconSize = 32;
            this.Page_2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Page_2.Location = new System.Drawing.Point(3, 200);
            this.Page_2.Name = "Page_2";
            this.Page_2.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Page_2.Size = new System.Drawing.Size(214, 55);
            this.Page_2.TabIndex = 2;
            this.Page_2.Text = "Create Cabon Test";
            this.Page_2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Page_2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Page_2.UseVisualStyleBackColor = true;
            this.Page_2.Click += new System.EventHandler(this.Page_2_Click);
            // 
            // Page_Home
            // 
            this.Page_Home.FlatAppearance.BorderSize = 0;
            this.Page_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Page_Home.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Page_Home.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Page_Home.IconChar = FontAwesome.Sharp.IconChar.Cube;
            this.Page_Home.IconColor = System.Drawing.Color.White;
            this.Page_Home.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Page_Home.IconSize = 32;
            this.Page_Home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Page_Home.Location = new System.Drawing.Point(3, 139);
            this.Page_Home.Name = "Page_Home";
            this.Page_Home.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Page_Home.Size = new System.Drawing.Size(214, 55);
            this.Page_Home.TabIndex = 1;
            this.Page_Home.Text = "Home";
            this.Page_Home.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Page_Home.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Page_Home.UseVisualStyleBackColor = true;
            this.Page_Home.Click += new System.EventHandler(this.Page_Home_Click);
            // 
            // LOGO_Home
            // 
            this.LOGO_Home.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LOGO_Home.Image = global::Cabon_Project2.Properties.Resources.Screenshot_2024_12_07_172922_141;
            this.LOGO_Home.Location = new System.Drawing.Point(0, 0);
            this.LOGO_Home.Name = "LOGO_Home";
            this.LOGO_Home.Size = new System.Drawing.Size(220, 119);
            this.LOGO_Home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LOGO_Home.TabIndex = 0;
            this.LOGO_Home.TabStop = false;
            this.LOGO_Home.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelMenu);
            this.Controls.Add(this.panelDesktop);
            this.Font = new System.Drawing.Font("Britannic Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainMenu";
            this.Text = "Form1";
            this.PanelMenu.ResumeLayout(false);
            this.PanelLOGO.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChild)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LOGO_Home)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelMenu;
        private FontAwesome.Sharp.IconButton Page_Home;
        private System.Windows.Forms.Panel PanelLOGO;
        private FontAwesome.Sharp.IconButton Page_6;
        private FontAwesome.Sharp.IconButton Page_5;
        private FontAwesome.Sharp.IconButton Page_4;
        private FontAwesome.Sharp.IconButton Page_3;
        private FontAwesome.Sharp.IconButton Page_2;
        private System.Windows.Forms.PictureBox LOGO_Home;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChild;
        private System.Windows.Forms.Label lblTitleChildForm;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconPictureBox iconExit;
        private FontAwesome.Sharp.IconPictureBox iconMinimize;
    }
}

