
namespace TopDownGame
{
    partial class GameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.GameEventsTimer = new System.Windows.Forms.Timer(this.components);
            this.healthBar = new System.Windows.Forms.ProgressBar();
            this.lbl_hp = new System.Windows.Forms.Label();
            this.lbl_spike = new System.Windows.Forms.Label();
            this.SpikeLeft = new System.Windows.Forms.ProgressBar();
            this.lbl_score = new System.Windows.Forms.Label();
            this.manaPoint = new System.Windows.Forms.ProgressBar();
            this.lbl_mp = new System.Windows.Forms.Label();
            this.ItemsSpawningTimer = new System.Windows.Forms.Timer(this.components);
            this.lbl_HPNofi = new System.Windows.Forms.Label();
            this.lbl_spikeNofi = new System.Windows.Forms.Label();
            this.Nofi = new System.Windows.Forms.Timer(this.components);
            this.lbl_MPNoFi = new System.Windows.Forms.Label();
            this.abc = new System.Windows.Forms.Timer(this.components);
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.line2 = new System.Windows.Forms.PictureBox();
            this.line = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.line2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.line)).BeginInit();
            this.SuspendLayout();
            // 
            // GameEventsTimer
            // 
            this.GameEventsTimer.Enabled = true;
            this.GameEventsTimer.Interval = 30;
            this.GameEventsTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // healthBar
            // 
            this.healthBar.BackColor = System.Drawing.Color.White;
            this.healthBar.ForeColor = System.Drawing.SystemColors.Control;
            this.healthBar.Location = new System.Drawing.Point(51, 4);
            this.healthBar.Name = "healthBar";
            this.healthBar.Size = new System.Drawing.Size(136, 23);
            this.healthBar.TabIndex = 1;
            // 
            // lbl_hp
            // 
            this.lbl_hp.AutoSize = true;
            this.lbl_hp.BackColor = System.Drawing.Color.White;
            this.lbl_hp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hp.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_hp.Location = new System.Drawing.Point(1, 3);
            this.lbl_hp.Name = "lbl_hp";
            this.lbl_hp.Size = new System.Drawing.Size(44, 24);
            this.lbl_hp.TabIndex = 2;
            this.lbl_hp.Text = "HP:";
            // 
            // lbl_spike
            // 
            this.lbl_spike.AutoSize = true;
            this.lbl_spike.BackColor = System.Drawing.Color.White;
            this.lbl_spike.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_spike.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_spike.Location = new System.Drawing.Point(209, 2);
            this.lbl_spike.Name = "lbl_spike";
            this.lbl_spike.Size = new System.Drawing.Size(68, 24);
            this.lbl_spike.TabIndex = 2;
            this.lbl_spike.Text = "Spike:";
            // 
            // SpikeLeft
            // 
            this.SpikeLeft.BackColor = System.Drawing.Color.DarkRed;
            this.SpikeLeft.ForeColor = System.Drawing.SystemColors.Control;
            this.SpikeLeft.Location = new System.Drawing.Point(288, 4);
            this.SpikeLeft.Name = "SpikeLeft";
            this.SpikeLeft.Size = new System.Drawing.Size(136, 23);
            this.SpikeLeft.TabIndex = 1;
            // 
            // lbl_score
            // 
            this.lbl_score.AutoSize = true;
            this.lbl_score.BackColor = System.Drawing.Color.White;
            this.lbl_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_score.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_score.Location = new System.Drawing.Point(710, 3);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(77, 24);
            this.lbl_score.TabIndex = 2;
            this.lbl_score.Text = "Score: ";
            // 
            // manaPoint
            // 
            this.manaPoint.BackColor = System.Drawing.Color.White;
            this.manaPoint.ForeColor = System.Drawing.SystemColors.Control;
            this.manaPoint.Location = new System.Drawing.Point(526, 3);
            this.manaPoint.Name = "manaPoint";
            this.manaPoint.Size = new System.Drawing.Size(136, 23);
            this.manaPoint.TabIndex = 1;
            // 
            // lbl_mp
            // 
            this.lbl_mp.AutoSize = true;
            this.lbl_mp.BackColor = System.Drawing.Color.White;
            this.lbl_mp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mp.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_mp.Location = new System.Drawing.Point(463, 4);
            this.lbl_mp.Name = "lbl_mp";
            this.lbl_mp.Size = new System.Drawing.Size(40, 24);
            this.lbl_mp.TabIndex = 2;
            this.lbl_mp.Text = "MP";
            // 
            // ItemsSpawningTimer
            // 
            this.ItemsSpawningTimer.Enabled = true;
            this.ItemsSpawningTimer.Interval = 5000;
            this.ItemsSpawningTimer.Tick += new System.EventHandler(this.AppleSpawningTimer_Tick);
            // 
            // lbl_HPNofi
            // 
            this.lbl_HPNofi.AutoSize = true;
            this.lbl_HPNofi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(176)))), ((int)(((byte)(37)))));
            this.lbl_HPNofi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HPNofi.ForeColor = System.Drawing.Color.Red;
            this.lbl_HPNofi.Location = new System.Drawing.Point(102, 9);
            this.lbl_HPNofi.Name = "lbl_HPNofi";
            this.lbl_HPNofi.Size = new System.Drawing.Size(0, 16);
            this.lbl_HPNofi.TabIndex = 3;
            // 
            // lbl_spikeNofi
            // 
            this.lbl_spikeNofi.AutoSize = true;
            this.lbl_spikeNofi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(176)))), ((int)(((byte)(37)))));
            this.lbl_spikeNofi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_spikeNofi.ForeColor = System.Drawing.Color.Red;
            this.lbl_spikeNofi.Location = new System.Drawing.Point(300, 9);
            this.lbl_spikeNofi.Name = "lbl_spikeNofi";
            this.lbl_spikeNofi.Size = new System.Drawing.Size(0, 16);
            this.lbl_spikeNofi.TabIndex = 4;
            // 
            // Nofi
            // 
            this.Nofi.Enabled = true;
            this.Nofi.Interval = 1000;
            this.Nofi.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // lbl_MPNoFi
            // 
            this.lbl_MPNoFi.AutoSize = true;
            this.lbl_MPNoFi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(176)))), ((int)(((byte)(37)))));
            this.lbl_MPNoFi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MPNoFi.ForeColor = System.Drawing.Color.Red;
            this.lbl_MPNoFi.Location = new System.Drawing.Point(561, 8);
            this.lbl_MPNoFi.Name = "lbl_MPNoFi";
            this.lbl_MPNoFi.Size = new System.Drawing.Size(0, 16);
            this.lbl_MPNoFi.TabIndex = 5;
            // 
            // abc
            // 
            this.abc.Enabled = true;
            this.abc.Interval = 30000;
            this.abc.Tick += new System.EventHandler(this.Drop_Tick);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(934, 620);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(75, 23);
            this.axWindowsMediaPlayer1.TabIndex = 6;
            this.axWindowsMediaPlayer1.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1146, 295);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = global::TopDownGame.Properties.Resources.hero_idle_side;
            this.player.Location = new System.Drawing.Point(213, 279);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(77, 60);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // line2
            // 
            this.line2.BackColor = System.Drawing.Color.Transparent;
            this.line2.Location = new System.Drawing.Point(12, 12);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(18, 642);
            this.line2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.line2.TabIndex = 0;
            this.line2.TabStop = false;
            // 
            // line
            // 
            this.line.BackColor = System.Drawing.Color.Transparent;
            this.line.Location = new System.Drawing.Point(814, 1);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(18, 642);
            this.line.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.line.TabIndex = 0;
            this.line.TabStop = false;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::TopDownGame.Properties.Resources.a;
            this.ClientSize = new System.Drawing.Size(1008, 642);
            this.Controls.Add(this.lbl_MPNoFi);
            this.Controls.Add(this.lbl_spikeNofi);
            this.Controls.Add(this.lbl_HPNofi);
            this.Controls.Add(this.lbl_score);
            this.Controls.Add(this.lbl_mp);
            this.Controls.Add(this.manaPoint);
            this.Controls.Add(this.lbl_spike);
            this.Controls.Add(this.SpikeLeft);
            this.Controls.Add(this.lbl_hp);
            this.Controls.Add(this.healthBar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.player);
            this.Controls.Add(this.line2);
            this.Controls.Add(this.line);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TopDownGame";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.line2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.line)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer GameEventsTimer;
        private System.Windows.Forms.ProgressBar healthBar;
        private System.Windows.Forms.Label lbl_hp;
        private System.Windows.Forms.PictureBox line;
        private System.Windows.Forms.Label lbl_spike;
        private System.Windows.Forms.ProgressBar SpikeLeft;
        private System.Windows.Forms.PictureBox line2;
        private System.Windows.Forms.Label lbl_score;
        private System.Windows.Forms.ProgressBar manaPoint;
        private System.Windows.Forms.Label lbl_mp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer ItemsSpawningTimer;
        private System.Windows.Forms.Label lbl_HPNofi;
        private System.Windows.Forms.Label lbl_spikeNofi;
        private System.Windows.Forms.Timer Nofi;
        private System.Windows.Forms.Label lbl_MPNoFi;
        private System.Windows.Forms.Timer abc;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}

