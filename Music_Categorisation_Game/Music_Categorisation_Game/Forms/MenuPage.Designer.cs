
namespace Music_Categorisation_Game
{
    partial class MenuPage
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
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnGameMode2 = new System.Windows.Forms.Button();
            this.btnGameMode1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnGameMode2);
            this.panel1.Controls.Add(this.btnGameMode1);
            this.panel1.Location = new System.Drawing.Point(209, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(383, 255);
            this.panel1.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(201, 155);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(95, 34);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(100, 155);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(95, 34);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnGameMode2
            // 
            this.btnGameMode2.Location = new System.Drawing.Point(215, 75);
            this.btnGameMode2.Name = "btnGameMode2";
            this.btnGameMode2.Size = new System.Drawing.Size(100, 47);
            this.btnGameMode2.TabIndex = 1;
            this.btnGameMode2.Text = "GameMode 2";
            this.btnGameMode2.UseVisualStyleBackColor = true;
            this.btnGameMode2.Click += new System.EventHandler(this.btnGameMode2_Click);
            // 
            // btnGameMode1
            // 
            this.btnGameMode1.Location = new System.Drawing.Point(73, 75);
            this.btnGameMode1.Name = "btnGameMode1";
            this.btnGameMode1.Size = new System.Drawing.Size(100, 47);
            this.btnGameMode1.TabIndex = 0;
            this.btnGameMode1.Text = "GameMode 1";
            this.btnGameMode1.UseVisualStyleBackColor = true;
            this.btnGameMode1.Click += new System.EventHandler(this.btnGameMode1_Click);
            // 
            // MenuPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "MenuPage";
            this.Text = "MenuPage";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnGameMode2;
        private System.Windows.Forms.Button btnGameMode1;
    }
}