namespace Teliki_2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.label_u = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.TextBox();
            this.game_name = new System.Windows.Forms.Label();
            this.hall_of_fame = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.username_show = new System.Windows.Forms.Label();
            this.ImageChoose = new System.Windows.Forms.OpenFileDialog();
            this.counter = new System.Windows.Forms.Timer(this.components);
            this.image_show = new System.Windows.Forms.Timer(this.components);
            this.image_destroy = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(687, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.fileToolStripMenuItem.Text = "Settings";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.openToolStripMenuItem.Text = "Choose Images";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // timer
            // 
            this.timer.AutoSize = true;
            this.timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.timer.Location = new System.Drawing.Point(637, 4);
            this.timer.Name = "timer";
            this.timer.Size = new System.Drawing.Size(28, 16);
            this.timer.TabIndex = 1;
            this.timer.Text = "0 s";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(584, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Time:";
            // 
            // Start
            // 
            this.Start.Font = new System.Drawing.Font("Courier New", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.Location = new System.Drawing.Point(300, 249);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(103, 49);
            this.Start.TabIndex = 3;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // label_u
            // 
            this.label_u.AutoSize = true;
            this.label_u.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_u.Location = new System.Drawing.Point(222, 185);
            this.label_u.Name = "label_u";
            this.label_u.Size = new System.Drawing.Size(80, 16);
            this.label_u.TabIndex = 4;
            this.label_u.Text = "Username:";
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(300, 185);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(135, 20);
            this.Username.TabIndex = 5;
            // 
            // game_name
            // 
            this.game_name.AutoSize = true;
            this.game_name.Font = new System.Drawing.Font("Castellar", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.game_name.Location = new System.Drawing.Point(101, 86);
            this.game_name.Name = "game_name";
            this.game_name.Size = new System.Drawing.Size(516, 42);
            this.game_name.TabIndex = 6;
            this.game_name.Text = "Remember The Picture";
            // 
            // hall_of_fame
            // 
            this.hall_of_fame.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hall_of_fame.Location = new System.Drawing.Point(36, 43);
            this.hall_of_fame.Name = "hall_of_fame";
            this.hall_of_fame.Size = new System.Drawing.Size(66, 31);
            this.hall_of_fame.TabIndex = 7;
            this.hall_of_fame.Text = "Open";
            this.hall_of_fame.UseVisualStyleBackColor = true;
            this.hall_of_fame.Click += new System.EventHandler(this.hall_of_fame_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.hall_of_fame);
            this.panel1.Location = new System.Drawing.Point(548, 311);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(139, 90);
            this.panel1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(0, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 14);
            this.label3.TabIndex = 8;
            this.label3.Text = "Player Hall of Fame";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.username_show);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.timer);
            this.panel2.Location = new System.Drawing.Point(0, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(697, 27);
            this.panel2.TabIndex = 9;
            this.panel2.Visible = false;
            // 
            // username_show
            // 
            this.username_show.AutoSize = true;
            this.username_show.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_show.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.username_show.Location = new System.Drawing.Point(39, 5);
            this.username_show.Name = "username_show";
            this.username_show.Size = new System.Drawing.Size(56, 16);
            this.username_show.TabIndex = 3;
            this.username_show.Text = "label4";
            // 
            // ImageChoose
            // 
            this.ImageChoose.FileName = "ImageChoose";
            this.ImageChoose.Multiselect = true;
            // 
            // counter
            // 
            this.counter.Interval = 1000;
            this.counter.Tick += new System.EventHandler(this.counter_Tick);
            // 
            // image_show
            // 
            this.image_show.Interval = 1000;
            this.image_show.Tick += new System.EventHandler(this.image_show_Tick);
            // 
            // image_destroy
            // 
            this.image_destroy.Interval = 600;
            this.image_destroy.Tick += new System.EventHandler(this.image_destroy_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(687, 419);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.game_name);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.label_u);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Remember the Picture";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Label timer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label label_u;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.Label game_name;
        private System.Windows.Forms.Button hall_of_fame;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label username_show;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog ImageChoose;
        private System.Windows.Forms.Timer counter;
        private System.Windows.Forms.Timer image_show;
        private System.Windows.Forms.Timer image_destroy;
    }
}

