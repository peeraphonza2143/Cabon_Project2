namespace Cabon_Project2
{
    partial class Create_Project_2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Textbox_Prepared = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Textbox_Reviewed = new System.Windows.Forms.TextBox();
            this.Label02 = new System.Windows.Forms.Label();
            this.TextBox_Appr = new System.Windows.Forms.TextBox();
            this.Label03 = new System.Windows.Forms.Label();
            this.TextBox_Review = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Button_Next = new FontAwesome.Sharp.IconButton();
            this.iconSplitButton1 = new FontAwesome.Sharp.IconSplitButton();
            this.Button_Back = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1666, 1061);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.Location = new System.Drawing.Point(100, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1566, 100);
            this.panel3.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(100, 1061);
            this.panel2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(1463, 1010);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 42);
            this.label2.TabIndex = 3;
            this.label2.Text = "Project Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(102, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prepared By";
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // Textbox_Prepared
            // 
            this.Textbox_Prepared.CausesValidation = false;
            this.Textbox_Prepared.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox_Prepared.Location = new System.Drawing.Point(108, 216);
            this.Textbox_Prepared.Name = "Textbox_Prepared";
            this.Textbox_Prepared.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Textbox_Prepared.Size = new System.Drawing.Size(553, 42);
            this.Textbox_Prepared.TabIndex = 1;
            this.Textbox_Prepared.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(101, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 35);
            this.label3.TabIndex = 2;
            this.label3.Text = "Reviewed By Mgt";
            // 
            // Textbox_Reviewed
            // 
            this.Textbox_Reviewed.CausesValidation = false;
            this.Textbox_Reviewed.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox_Reviewed.Location = new System.Drawing.Point(108, 374);
            this.Textbox_Reviewed.Name = "Textbox_Reviewed";
            this.Textbox_Reviewed.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Textbox_Reviewed.Size = new System.Drawing.Size(553, 42);
            this.Textbox_Reviewed.TabIndex = 3;
            // 
            // Label02
            // 
            this.Label02.AutoSize = true;
            this.Label02.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label02.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Label02.Location = new System.Drawing.Point(707, 160);
            this.Label02.Name = "Label02";
            this.Label02.Size = new System.Drawing.Size(106, 35);
            this.Label02.TabIndex = 6;
            this.Label02.Text = "Appr’d By";
            this.Label02.Click += new System.EventHandler(this.label5_Click);
            // 
            // TextBox_Appr
            // 
            this.TextBox_Appr.CausesValidation = false;
            this.TextBox_Appr.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Appr.Location = new System.Drawing.Point(713, 216);
            this.TextBox_Appr.Name = "TextBox_Appr";
            this.TextBox_Appr.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TextBox_Appr.Size = new System.Drawing.Size(553, 42);
            this.TextBox_Appr.TabIndex = 7;
            // 
            // Label03
            // 
            this.Label03.AutoSize = true;
            this.Label03.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label03.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Label03.Location = new System.Drawing.Point(707, 318);
            this.Label03.Name = "Label03";
            this.Label03.Size = new System.Drawing.Size(109, 35);
            this.Label03.TabIndex = 8;
            this.Label03.Text = "Review By";
            // 
            // TextBox_Review
            // 
            this.TextBox_Review.CausesValidation = false;
            this.TextBox_Review.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Review.Location = new System.Drawing.Point(713, 374);
            this.TextBox_Review.Name = "TextBox_Review";
            this.TextBox_Review.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TextBox_Review.Size = new System.Drawing.Size(553, 42);
            this.TextBox_Review.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.CausesValidation = false;
            this.panel4.Controls.Add(this.Button_Back);
            this.panel4.Controls.Add(this.Button_Next);
            this.panel4.Controls.Add(this.TextBox_Review);
            this.panel4.Controls.Add(this.Label03);
            this.panel4.Controls.Add(this.TextBox_Appr);
            this.panel4.Controls.Add(this.Label02);
            this.panel4.Controls.Add(this.Textbox_Reviewed);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.Textbox_Prepared);
            this.panel4.Controls.Add(this.label1);
            this.panel4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel4.Location = new System.Drawing.Point(100, 100);
            this.panel4.Name = "panel4";
            this.panel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel4.Size = new System.Drawing.Size(1369, 861);
            this.panel4.TabIndex = 6;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint_1);
            // 
            // Button_Next
            // 
            this.Button_Next.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Next.IconChar = FontAwesome.Sharp.IconChar.CircleArrowRight;
            this.Button_Next.IconColor = System.Drawing.Color.Black;
            this.Button_Next.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_Next.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button_Next.Location = new System.Drawing.Point(1146, 770);
            this.Button_Next.Name = "Button_Next";
            this.Button_Next.Size = new System.Drawing.Size(191, 60);
            this.Button_Next.TabIndex = 12;
            this.Button_Next.Text = "NEXT";
            this.Button_Next.UseVisualStyleBackColor = true;
            this.Button_Next.Click += new System.EventHandler(this.Button_Next_Click);
            // 
            // iconSplitButton1
            // 
            this.iconSplitButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconSplitButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconSplitButton1.IconColor = System.Drawing.Color.Black;
            this.iconSplitButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconSplitButton1.IconSize = 48;
            this.iconSplitButton1.Name = "iconSplitButton1";
            this.iconSplitButton1.Rotation = 0D;
            this.iconSplitButton1.Size = new System.Drawing.Size(23, 23);
            this.iconSplitButton1.Text = "iconSplitButton1";
            // 
            // Button_Back
            // 
            this.Button_Back.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Back.IconChar = FontAwesome.Sharp.IconChar.CircleArrowLeft;
            this.Button_Back.IconColor = System.Drawing.Color.Black;
            this.Button_Back.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_Back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_Back.Location = new System.Drawing.Point(43, 770);
            this.Button_Back.Name = "Button_Back";
            this.Button_Back.Size = new System.Drawing.Size(191, 60);
            this.Button_Back.TabIndex = 13;
            this.Button_Back.Text = "BACK";
            this.Button_Back.UseVisualStyleBackColor = true;
            this.Button_Back.Click += new System.EventHandler(this.Button_Back_Click);
            // 
            // Create_Project_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1666, 1061);
            this.Controls.Add(this.panel1);
            this.Name = "Create_Project_2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Create_Project_2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconSplitButton iconSplitButton1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton Button_Next;
        private System.Windows.Forms.TextBox TextBox_Review;
        private System.Windows.Forms.Label Label03;
        private System.Windows.Forms.TextBox TextBox_Appr;
        private System.Windows.Forms.Label Label02;
        private System.Windows.Forms.TextBox Textbox_Reviewed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Textbox_Prepared;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton Button_Back;
    }
}