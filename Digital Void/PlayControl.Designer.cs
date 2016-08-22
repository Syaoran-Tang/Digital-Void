namespace Digital_Void
{
    partial class PlayControl
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
            this.PC_trackBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.PC_Play = new System.Windows.Forms.Button();
            this.PC_End = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PC_trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // PC_trackBar
            // 
            this.PC_trackBar.Location = new System.Drawing.Point(12, 12);
            this.PC_trackBar.Name = "PC_trackBar";
            this.PC_trackBar.Size = new System.Drawing.Size(129, 45);
            this.PC_trackBar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "快进倍数";
            // 
            // PC_Play
            // 
            this.PC_Play.Location = new System.Drawing.Point(176, 24);
            this.PC_Play.Name = "PC_Play";
            this.PC_Play.Size = new System.Drawing.Size(47, 22);
            this.PC_Play.TabIndex = 2;
            this.PC_Play.Text = "开始";
            this.PC_Play.UseVisualStyleBackColor = true;
            this.PC_Play.Click += new System.EventHandler(this.PC_Play_Click);
            // 
            // PC_End
            // 
            this.PC_End.Location = new System.Drawing.Point(238, 24);
            this.PC_End.Name = "PC_End";
            this.PC_End.Size = new System.Drawing.Size(44, 22);
            this.PC_End.TabIndex = 3;
            this.PC_End.Text = "终止";
            this.PC_End.UseVisualStyleBackColor = true;
            this.PC_End.Click += new System.EventHandler(this.PC_End_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "×1";
            // 
            // PlayControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(297, 64);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PC_End);
            this.Controls.Add(this.PC_Play);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PC_trackBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PlayControl";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "模拟控制";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.PC_trackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar PC_trackBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PC_Play;
        private System.Windows.Forms.Button PC_End;
        private System.Windows.Forms.Label label2;
    }
}