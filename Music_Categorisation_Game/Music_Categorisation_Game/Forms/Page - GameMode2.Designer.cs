
namespace Music_Categorisation_Game
{
    partial class Page___GameMode2
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
            this.TimeRemaining = new System.Windows.Forms.ProgressBar();
            this.lblTimer = new System.Windows.Forms.Label();
            this.pnlTimerHolder = new System.Windows.Forms.Panel();
            this.btnOption3 = new System.Windows.Forms.Button();
            this.btnOption2 = new System.Windows.Forms.Button();
            this.btnOption1 = new System.Windows.Forms.Button();
            this.lblArtist = new System.Windows.Forms.Label();
            this.pnlTimerHolder.SuspendLayout();
            this.SuspendLayout();
            // 
            // TimeRemaining
            // 
            this.TimeRemaining.Location = new System.Drawing.Point(12, 3);
            this.TimeRemaining.Name = "TimeRemaining";
            this.TimeRemaining.Size = new System.Drawing.Size(860, 10);
            this.TimeRemaining.TabIndex = 2;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTimer.Location = new System.Drawing.Point(33, 5);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(117, 42);
            this.lblTimer.TabIndex = 0;
            this.lblTimer.Text = "00:00";
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlTimerHolder
            // 
            this.pnlTimerHolder.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlTimerHolder.Controls.Add(this.lblTimer);
            this.pnlTimerHolder.Location = new System.Drawing.Point(351, 19);
            this.pnlTimerHolder.Name = "pnlTimerHolder";
            this.pnlTimerHolder.Size = new System.Drawing.Size(177, 54);
            this.pnlTimerHolder.TabIndex = 3;
            // 
            // btnOption3
            // 
            this.btnOption3.Location = new System.Drawing.Point(329, 409);
            this.btnOption3.Name = "btnOption3";
            this.btnOption3.Size = new System.Drawing.Size(227, 62);
            this.btnOption3.TabIndex = 5;
            this.btnOption3.Text = "{option3}";
            this.btnOption3.UseVisualStyleBackColor = true;
            // 
            // btnOption2
            // 
            this.btnOption2.Location = new System.Drawing.Point(329, 327);
            this.btnOption2.Name = "btnOption2";
            this.btnOption2.Size = new System.Drawing.Size(227, 62);
            this.btnOption2.TabIndex = 6;
            this.btnOption2.Text = "{option2}";
            this.btnOption2.UseVisualStyleBackColor = true;
            // 
            // btnOption1
            // 
            this.btnOption1.Location = new System.Drawing.Point(329, 245);
            this.btnOption1.Name = "btnOption1";
            this.btnOption1.Size = new System.Drawing.Size(227, 62);
            this.btnOption1.TabIndex = 7;
            this.btnOption1.Text = "{option1}";
            this.btnOption1.UseVisualStyleBackColor = true;
            // 
            // lblArtist
            // 
            this.lblArtist.AutoSize = true;
            this.lblArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtist.Location = new System.Drawing.Point(396, 149);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(92, 31);
            this.lblArtist.TabIndex = 4;
            this.lblArtist.Text = "{artist}";
            this.lblArtist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Page___GameMode2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.btnOption3);
            this.Controls.Add(this.btnOption2);
            this.Controls.Add(this.btnOption1);
            this.Controls.Add(this.lblArtist);
            this.Controls.Add(this.pnlTimerHolder);
            this.Controls.Add(this.TimeRemaining);
            this.Name = "Page___GameMode2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Page - GameMode2";
            this.pnlTimerHolder.ResumeLayout(false);
            this.pnlTimerHolder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ProgressBar TimeRemaining;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Panel pnlTimerHolder;
        private System.Windows.Forms.Button btnOption3;
        private System.Windows.Forms.Button btnOption2;
        private System.Windows.Forms.Button btnOption1;
        private System.Windows.Forms.Label lblArtist;
    }
}