namespace musicPlayer
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Open = new System.Windows.Forms.Button();
            this.btn_Play = new System.Windows.Forms.Button();
            this.btn_Pause = new System.Windows.Forms.Button();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.btn_Previous = new System.Windows.Forms.Button();
            this.btn_Next = new System.Windows.Forms.Button();
            this.btn_Mute = new System.Windows.Forms.Button();
            this.Pb_Position = new System.Windows.Forms.ProgressBar();
            this.Pb_Volume = new System.Windows.Forms.ProgressBar();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.lb_Position = new System.Windows.Forms.Label();
            this.lb_Gender = new System.Windows.Forms.Label();
            this.lb_Artist = new System.Windows.Forms.Label();
            this.lb_Title = new System.Windows.Forms.Label();
            this.lb_Volume = new System.Windows.Forms.Label();
            this.lb_Duration = new System.Windows.Forms.Label();
            this.TimerRefresh = new System.Windows.Forms.Timer(this.components);
            this.OfDialog = new System.Windows.Forms.OpenFileDialog();
            this.MyPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(738, 364);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_Open
            // 
            this.btn_Open.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Open.BackgroundImage")));
            this.btn_Open.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Open.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Open.Location = new System.Drawing.Point(74, 260);
            this.btn_Open.Name = "btn_Open";
            this.btn_Open.Size = new System.Drawing.Size(93, 28);
            this.btn_Open.TabIndex = 2;
            this.btn_Open.Text = "Open";
            this.btn_Open.UseVisualStyleBackColor = true;
            this.btn_Open.Click += new System.EventHandler(this.btn_Open_Click);
            // 
            // btn_Play
            // 
            this.btn_Play.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Play.BackgroundImage")));
            this.btn_Play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Play.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Play.Location = new System.Drawing.Point(173, 260);
            this.btn_Play.Name = "btn_Play";
            this.btn_Play.Size = new System.Drawing.Size(93, 28);
            this.btn_Play.TabIndex = 3;
            this.btn_Play.Text = "Play";
            this.btn_Play.UseVisualStyleBackColor = true;
            this.btn_Play.Click += new System.EventHandler(this.btn_Play_Click);
            // 
            // btn_Pause
            // 
            this.btn_Pause.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Pause.BackgroundImage")));
            this.btn_Pause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Pause.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Pause.Location = new System.Drawing.Point(272, 260);
            this.btn_Pause.Name = "btn_Pause";
            this.btn_Pause.Size = new System.Drawing.Size(93, 28);
            this.btn_Pause.TabIndex = 4;
            this.btn_Pause.Text = "Pause";
            this.btn_Pause.UseVisualStyleBackColor = true;
            this.btn_Pause.Click += new System.EventHandler(this.btn_Pause_Click);
            // 
            // btn_Stop
            // 
            this.btn_Stop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Stop.BackgroundImage")));
            this.btn_Stop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Stop.Location = new System.Drawing.Point(371, 260);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(93, 28);
            this.btn_Stop.TabIndex = 5;
            this.btn_Stop.Text = "Stop";
            this.btn_Stop.UseVisualStyleBackColor = true;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // btn_Previous
            // 
            this.btn_Previous.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Previous.BackgroundImage")));
            this.btn_Previous.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Previous.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Previous.Location = new System.Drawing.Point(470, 260);
            this.btn_Previous.Name = "btn_Previous";
            this.btn_Previous.Size = new System.Drawing.Size(93, 28);
            this.btn_Previous.TabIndex = 6;
            this.btn_Previous.Text = "Previous";
            this.btn_Previous.UseVisualStyleBackColor = true;
            this.btn_Previous.Click += new System.EventHandler(this.btn_Previous_Click);
            // 
            // btn_Next
            // 
            this.btn_Next.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Next.BackgroundImage")));
            this.btn_Next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Next.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Next.Location = new System.Drawing.Point(569, 260);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(93, 28);
            this.btn_Next.TabIndex = 7;
            this.btn_Next.Text = "Next";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // btn_Mute
            // 
            this.btn_Mute.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Mute.BackgroundImage")));
            this.btn_Mute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Mute.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Mute.Location = new System.Drawing.Point(466, 326);
            this.btn_Mute.Name = "btn_Mute";
            this.btn_Mute.Size = new System.Drawing.Size(57, 26);
            this.btn_Mute.TabIndex = 8;
            this.btn_Mute.Text = "Mute";
            this.btn_Mute.UseVisualStyleBackColor = true;
            this.btn_Mute.Click += new System.EventHandler(this.btn_Mute_Click);
            // 
            // Pb_Position
            // 
            this.Pb_Position.Location = new System.Drawing.Point(53, 139);
            this.Pb_Position.Name = "Pb_Position";
            this.Pb_Position.Size = new System.Drawing.Size(628, 19);
            this.Pb_Position.TabIndex = 9;
            // 
            // Pb_Volume
            // 
            this.Pb_Volume.Location = new System.Drawing.Point(272, 309);
            this.Pb_Volume.Name = "Pb_Volume";
            this.Pb_Volume.Size = new System.Drawing.Size(192, 18);
            this.Pb_Volume.TabIndex = 10;
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.Color.Black;
            this.trackBar1.Location = new System.Drawing.Point(42, 164);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(646, 45);
            this.trackBar1.TabIndex = 11;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // trackBar2
            // 
            this.trackBar2.AutoSize = false;
            this.trackBar2.Location = new System.Drawing.Point(272, 330);
            this.trackBar2.Maximum = 100;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(192, 20);
            this.trackBar2.TabIndex = 12;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // lb_Position
            // 
            this.lb_Position.AutoSize = true;
            this.lb_Position.BackColor = System.Drawing.Color.RoyalBlue;
            this.lb_Position.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Position.ForeColor = System.Drawing.Color.White;
            this.lb_Position.Location = new System.Drawing.Point(54, 189);
            this.lb_Position.Name = "lb_Position";
            this.lb_Position.Size = new System.Drawing.Size(49, 20);
            this.lb_Position.TabIndex = 13;
            this.lb_Position.Text = "00:00";
            // 
            // lb_Gender
            // 
            this.lb_Gender.BackColor = System.Drawing.Color.Black;
            this.lb_Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Gender.ForeColor = System.Drawing.Color.Lime;
            this.lb_Gender.Location = new System.Drawing.Point(353, 88);
            this.lb_Gender.Name = "lb_Gender";
            this.lb_Gender.Size = new System.Drawing.Size(331, 35);
            this.lb_Gender.TabIndex = 14;
            this.lb_Gender.Text = "Gender";
            this.lb_Gender.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lb_Gender.Click += new System.EventHandler(this.lb_Album_Click);
            // 
            // lb_Artist
            // 
            this.lb_Artist.BackColor = System.Drawing.Color.Black;
            this.lb_Artist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Artist.ForeColor = System.Drawing.Color.Lime;
            this.lb_Artist.Location = new System.Drawing.Point(58, 51);
            this.lb_Artist.Name = "lb_Artist";
            this.lb_Artist.Size = new System.Drawing.Size(628, 38);
            this.lb_Artist.TabIndex = 15;
            this.lb_Artist.Text = "Artist";
            this.lb_Artist.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lb_Artist.Click += new System.EventHandler(this.lb_Artist_Click);
            // 
            // lb_Title
            // 
            this.lb_Title.BackColor = System.Drawing.Color.Black;
            this.lb_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Title.ForeColor = System.Drawing.Color.Lime;
            this.lb_Title.Location = new System.Drawing.Point(52, 89);
            this.lb_Title.Name = "lb_Title";
            this.lb_Title.Size = new System.Drawing.Size(304, 35);
            this.lb_Title.TabIndex = 16;
            this.lb_Title.Text = "Title";
            this.lb_Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lb_Title.Click += new System.EventHandler(this.lb_Title_Click);
            // 
            // lb_Volume
            // 
            this.lb_Volume.AutoSize = true;
            this.lb_Volume.BackColor = System.Drawing.Color.Transparent;
            this.lb_Volume.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Volume.Location = new System.Drawing.Point(356, 309);
            this.lb_Volume.Name = "lb_Volume";
            this.lb_Volume.Size = new System.Drawing.Size(27, 16);
            this.lb_Volume.TabIndex = 17;
            this.lb_Volume.Text = "0%";
            // 
            // lb_Duration
            // 
            this.lb_Duration.AutoSize = true;
            this.lb_Duration.BackColor = System.Drawing.Color.RoyalBlue;
            this.lb_Duration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Duration.ForeColor = System.Drawing.Color.White;
            this.lb_Duration.Location = new System.Drawing.Point(642, 194);
            this.lb_Duration.Name = "lb_Duration";
            this.lb_Duration.Size = new System.Drawing.Size(49, 20);
            this.lb_Duration.TabIndex = 18;
            this.lb_Duration.Text = "00:00";
            // 
            // TimerRefresh
            // 
            this.TimerRefresh.Interval = 500;
            this.TimerRefresh.Tick += new System.EventHandler(this.TimerRefresh_Tick);
            // 
            // OfDialog
            // 
            this.OfDialog.FileName = "OpenFileDialog1";
            // 
            // MyPlayer
            // 
            this.MyPlayer.Enabled = true;
            this.MyPlayer.Location = new System.Drawing.Point(111, 233);
            this.MyPlayer.Name = "MyPlayer";
            this.MyPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MyPlayer.OcxState")));
            this.MyPlayer.Size = new System.Drawing.Size(11, 12);
            this.MyPlayer.TabIndex = 19;
            
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 466);
            this.Controls.Add(this.MyPlayer);
            this.Controls.Add(this.lb_Volume);
            this.Controls.Add(this.lb_Duration);
            this.Controls.Add(this.lb_Title);
            this.Controls.Add(this.lb_Artist);
            this.Controls.Add(this.lb_Gender);
            this.Controls.Add(this.lb_Position);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.Pb_Volume);
            this.Controls.Add(this.Pb_Position);
            this.Controls.Add(this.btn_Mute);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.btn_Previous);
            this.Controls.Add(this.btn_Stop);
            this.Controls.Add(this.btn_Pause);
            this.Controls.Add(this.btn_Play);
            this.Controls.Add(this.btn_Open);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Open;
        private System.Windows.Forms.Button btn_Play;
        private System.Windows.Forms.Button btn_Pause;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.Button btn_Previous;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Button btn_Mute;
        private System.Windows.Forms.ProgressBar Pb_Position;
        private System.Windows.Forms.ProgressBar Pb_Volume;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Label lb_Position;
        private System.Windows.Forms.Label lb_Gender;
        private System.Windows.Forms.Label lb_Artist;
        private System.Windows.Forms.Label lb_Title;
        private System.Windows.Forms.Label lb_Volume;
        private System.Windows.Forms.Label lb_Duration;
        private System.Windows.Forms.Timer TimerRefresh;
        private System.Windows.Forms.OpenFileDialog OfDialog;
        private AxWMPLib.AxWindowsMediaPlayer MyPlayer;
    }
}

