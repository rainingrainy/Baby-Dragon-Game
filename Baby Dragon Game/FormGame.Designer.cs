
namespace Baby_Dragon_Game
{
    partial class FormGame
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
            this.components = new System.ComponentModel.Container();
            this.timerDragon = new System.Windows.Forms.Timer(this.components);
            this.timerObstacles = new System.Windows.Forms.Timer(this.components);
            this.NameText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuStart = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStop = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuRestart = new System.Windows.Forms.ToolStripMenuItem();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.MainPanel = new Baby_Dragon_Game.MainPanel();
            this.GameOverLabel2 = new System.Windows.Forms.Label();
            this.GameOverLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timerDragon
            // 
            this.timerDragon.Enabled = true;
            this.timerDragon.Interval = 50;
            this.timerDragon.Tick += new System.EventHandler(this.timerDragon_Tick);
            // 
            // timerObstacles
            // 
            this.timerObstacles.Enabled = true;
            this.timerObstacles.Interval = 50;
            this.timerObstacles.Tick += new System.EventHandler(this.timerObstacles_Tick);
            // 
            // NameText
            // 
            this.NameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameText.Location = new System.Drawing.Point(521, 216);
            this.NameText.MaxLength = 15;
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(304, 44);
            this.NameText.TabIndex = 3;
            this.NameText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameText_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(563, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 86);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name:";
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ScoreLabel.Location = new System.Drawing.Point(223, 177);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(69, 73);
            this.ScoreLabel.TabIndex = 1;
            this.ScoreLabel.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 86);
            this.label1.TabIndex = 0;
            this.label1.Text = "Score:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStart,
            this.MenuStop,
            this.MenuRestart});
            this.menuStrip1.Location = new System.Drawing.Point(23, 1036);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5);
            this.menuStrip1.Size = new System.Drawing.Size(615, 100);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuStart
            // 
            this.MenuStart.BackColor = System.Drawing.Color.Green;
            this.MenuStart.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuStart.ForeColor = System.Drawing.Color.Black;
            this.MenuStart.Name = "MenuStart";
            this.MenuStart.Size = new System.Drawing.Size(180, 90);
            this.MenuStart.Text = "Start";
            this.MenuStart.Click += new System.EventHandler(this.MenuStart_Click);
            // 
            // MenuStop
            // 
            this.MenuStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MenuStop.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuStop.Name = "MenuStop";
            this.MenuStop.Size = new System.Drawing.Size(179, 90);
            this.MenuStop.Text = "Stop";
            this.MenuStop.Click += new System.EventHandler(this.MenuStop_Click);
            // 
            // MenuRestart
            // 
            this.MenuRestart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.MenuRestart.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuRestart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MenuRestart.Name = "MenuRestart";
            this.MenuRestart.Size = new System.Drawing.Size(244, 90);
            this.MenuRestart.Text = "Restart";
            this.MenuRestart.Click += new System.EventHandler(this.MenuRestart_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.White;
            this.TitleLabel.Location = new System.Drawing.Point(130, 24);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(602, 108);
            this.TitleLabel.TabIndex = 2;
            this.TitleLabel.Text = "Baby Dragon";
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.LightBlue;
            this.MainPanel.BackgroundImage = global::Baby_Dragon_Game.Properties.Resources.Background;
            this.MainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MainPanel.Controls.Add(this.GameOverLabel2);
            this.MainPanel.Controls.Add(this.GameOverLabel);
            this.MainPanel.Location = new System.Drawing.Point(25, 284);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(800, 725);
            this.MainPanel.TabIndex = 0;
            this.MainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MainPanel_Paint);
            // 
            // GameOverLabel2
            // 
            this.GameOverLabel2.AutoSize = true;
            this.GameOverLabel2.Font = new System.Drawing.Font("Papyrus", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameOverLabel2.Location = new System.Drawing.Point(-1006, 371);
            this.GameOverLabel2.Name = "GameOverLabel2";
            this.GameOverLabel2.Padding = new System.Windows.Forms.Padding(1100, 0, 1100, 1100);
            this.GameOverLabel2.Size = new System.Drawing.Size(2309, 1151);
            this.GameOverLabel2.TabIndex = 1;
            this.GameOverLabel2.Text = "label4";
            // 
            // GameOverLabel
            // 
            this.GameOverLabel.AutoSize = true;
            this.GameOverLabel.Font = new System.Drawing.Font("Papyrus", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameOverLabel.Location = new System.Drawing.Point(-4, 0);
            this.GameOverLabel.Name = "GameOverLabel";
            this.GameOverLabel.Padding = new System.Windows.Forms.Padding(110);
            this.GameOverLabel.Size = new System.Drawing.Size(816, 371);
            this.GameOverLabel.TabIndex = 0;
            this.GameOverLabel.Text = "Game Over!";
            this.GameOverLabel.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Baby_Dragon_Game.Properties.Resources.Title;
            this.pictureBox1.Location = new System.Drawing.Point(23, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(802, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(143, 1145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(538, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "Copyright © 2022 by rainingrainy - All Rights Reserved.";
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(850, 1182);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(866, 1221);
            this.MinimumSize = new System.Drawing.Size(866, 1221);
            this.Name = "FormGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Baby Dragon Game";
            this.Load += new System.EventHandler(this.FormGame_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormGame_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormGame_KeyUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timerDragon;
        private MainPanel MainPanel;
        private System.Windows.Forms.Timer timerObstacles;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private new System.Windows.Forms.ToolStripMenuItem MenuStart;
        private System.Windows.Forms.ToolStripMenuItem MenuStop;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label GameOverLabel;
        private System.Windows.Forms.ToolStripMenuItem MenuRestart;
        private System.Windows.Forms.Label GameOverLabel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
    }
}

