namespace Cabon_Project2
{
    partial class MessageBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageBox));
            this.label1 = new System.Windows.Forms.Label();
            this.Button_score3 = new System.Windows.Forms.Button();
            this.Button_score2 = new System.Windows.Forms.Button();
            this.Button_score1 = new System.Windows.Forms.Button();
            this.Button_score4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // Button_score3
            // 
            resources.ApplyResources(this.Button_score3, "Button_score3");
            this.Button_score3.Name = "Button_score3";
            this.Button_score3.UseVisualStyleBackColor = true;
            this.Button_score3.Click += new System.EventHandler(this.Button_score3_Click);
            // 
            // Button_score2
            // 
            resources.ApplyResources(this.Button_score2, "Button_score2");
            this.Button_score2.Name = "Button_score2";
            this.Button_score2.UseVisualStyleBackColor = true;
            this.Button_score2.Click += new System.EventHandler(this.Button_score2_Click);
            // 
            // Button_score1
            // 
            resources.ApplyResources(this.Button_score1, "Button_score1");
            this.Button_score1.Name = "Button_score1";
            this.Button_score1.UseVisualStyleBackColor = true;
            this.Button_score1.Click += new System.EventHandler(this.Button_score1_Click);
            // 
            // Button_score4
            // 
            resources.ApplyResources(this.Button_score4, "Button_score4");
            this.Button_score4.Name = "Button_score4";
            this.Button_score4.UseVisualStyleBackColor = true;
            this.Button_score4.Click += new System.EventHandler(this.Button_score4_Click);
            // 
            // MessageBox
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Button_score4);
            this.Controls.Add(this.Button_score1);
            this.Controls.Add(this.Button_score2);
            this.Controls.Add(this.Button_score3);
            this.Controls.Add(this.label1);
            this.Name = "MessageBox";
            this.Load += new System.EventHandler(this.CustomMessageBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Button_score3;
        private System.Windows.Forms.Button Button_score2;
        private System.Windows.Forms.Button Button_score1;
        private System.Windows.Forms.Button Button_score4;
    }
}