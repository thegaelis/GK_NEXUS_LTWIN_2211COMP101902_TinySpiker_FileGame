using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;
using WMPLib;
namespace TopDownGame
{
    public partial class GameForm : Form
    {
        private SoundPlayer Sshoot, Scollect, Stele, Send, Sdamaged;
        WMPLib.WindowsMediaPlayer BGmusic;
        int speed = 10;
        int spike = 10;
        int playerHP;
        int e_type;
        int enemyCounted = 0;
        int applesCounted = 0;
        int manaPacksCounted = 0;
        int enemySpeed = 5;
        int score = 0;
        bool left, right, top, down;
        // tao list kieu bitmap de luu hinh quasi
        List<Bitmap> enemies = new List<Bitmap>() { Properties.Resources.Mole, Properties.Resources.treant_walk_side_3, Properties.Resources.alien };
        int[] dir = { 1, 2, 3, 4 };

        Random randNum = new Random();
        int facing = 4;
        public GameForm()
        {
            InitializeComponent();
            inIt();
        }
        private void inIt()
        {
            playerHP = 100;
            healthBar.Value = playerHP;
            SpikeLeft.Value = 100;
            manaPoint.Value = 100;
            e_type = 0;
            BGmusic = new WMPLib.WindowsMediaPlayer();
            Sshoot = new SoundPlayer("DM-CGS-07.wav");
            Scollect = new SoundPlayer("DM-CGS-15.wav");
            Stele = new SoundPlayer("DM-CGS-29.wav");
            Send = new SoundPlayer("DM-CGS-41.wav");
            Sdamaged = new SoundPlayer("DM-CGS-17.wav");
            BGmusic.URL = "Guild  Arcade Candy  Guardian Tales OST.mp3";
            BGmusic.settings.setMode("loop", true);
            BGmusic.controls.play();

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (playerHP > 0) {
                // tang toc do theo tung muc diem
                if (score <= 10)
                {
                    enemySpeed += 0;
                }
                else if (score < 25)
                {
                    enemySpeed = 10;
                    e_type = 1;
                }
                else
                {
                    enemySpeed = 13;
                    e_type = 2;
                }
                lbl_score.Text = "Score: " + score.ToString();
                // di chuyen nguoi choi neu trong khoang cho phep
                if (left && player.Left > 0)
                {
                    player.Left -= speed;
                }

                if (right && player.Left < line.Left - player.Width - 3)
                {
                    player.Left += speed;
                }

                if (top && player.Top > 30)
                {
                    player.Top -= speed;
                }

                if (down && player.Top + player.Height + 50 < this.Height)
                {
                    player.Top += speed;
                }
                if (enemyCounted <= 3)
                {
                    makeEnemies(e_type);
                    enemyCounted++;
                }
                // neu ban trung quai, hoi mau, huy quai. huy spike
                foreach (Control x in this.Controls)
                {
                    foreach (Control y in this.Controls)
                    {
                        if ((x is PictureBox && (string)x.Tag == "enemy") && (y is PictureBox && (string)y.Tag == "spike"))
                        {
                            if (y.Bounds.IntersectsWith(x.Bounds))
                            {
                                this.Controls.Remove(x);
                                ((PictureBox)x).Dispose();
                                enemyCounted--;
                                ((PictureBox)y).Dispose();
                                score++;
                                Send.Play();
                                if (playerHP <= 95)
                                {
                                    healthBar.Value += 5;
                                    playerHP += 5;
                                    lbl_HPNofi.Text = "+5";
                                    Nofi.Enabled = true;
                                }

                            }
                        }
                    }
                }
                foreach (Control u in this.Controls)
                {
                    // di chuyen quai qua trai
                    if (u is PictureBox && (string)u.Tag == "enemy")
                    {
                        u.Left -= enemySpeed;
                    }
                    // an tao hoi mau
                    if (u is PictureBox && (string)u.Tag == "apple")
                    {
                        if (u.Bounds.IntersectsWith(player.Bounds) && playerHP <= 90)
                        {
                            healthBar.Value += 10;
                            playerHP += 10;
                            this.Controls.Remove(u);
                            ((PictureBox)u).Dispose();
                            applesCounted--;
                            lbl_HPNofi.Text = "+10";
                            Nofi.Enabled = true;
                            Scollect.Play();

                        }
                        // an chuoi hoi mana
                    }
                    else if (u is PictureBox && (string)u.Tag == "banana")
                    {
                        {
                            if (u.Bounds.IntersectsWith(player.Bounds) && manaPoint.Value <= 90)
                            {
                                manaPoint.Value += 10;

                                this.Controls.Remove(u);
                                ((PictureBox)u).Dispose();
                                manaPacksCounted--;
                                lbl_MPNoFi.Text = "+10";
                                Nofi.Enabled = true;
                                Scollect.Play();
                            }

                        }
                    }
                    //huy quai neu cham vao line2, giam mau player
                    else if (u is PictureBox && (string)u.Tag == "enemy")
                    {
                        if (u.Bounds.IntersectsWith(line2.Bounds))
                        {
                            this.Controls.Remove(u);
                            ((PictureBox)u).Dispose();
                            enemyCounted--;
                            if (healthBar.Value - 5 == 0 && !(healthBar.Value % 10 == 0))
                            {
                                healthBar.Value -= 5;
                                playerHP -= 5;
                            }
                            else
                            {
                                healthBar.Value -= 10;
                                playerHP -= 10;
                            }

                            Sdamaged.Play();

                        }
                        else if (u.Bounds.IntersectsWith(player.Bounds))
                        {
                            healthBar.Value -= 1;
                            playerHP -= 1;
                            Sdamaged.Play();


                        }
                    }

                }

            }

        

            // mau nho == 0 chay ham restartGame();
            else
            {
                    GameEventsTimer.Stop();
                    ItemsSpawningTimer.Stop();
                    BGmusic.controls.stop();
                    MessageBox.Show("Game Over!\nYour score is: " + score.ToString(), "TinySpiker", MessageBoxButtons.OK);
                    restartGame();
            }
        }
        // kiem tra phim dang an
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
            
            switch (e.KeyCode)
            {
                case Keys.W:
                    player.Refresh();
                    top = true;
                    facing = dir[0];
                    player.Image = Properties.Resources.hero_idle_back;
                    break;
                case Keys.S:
                    player.Refresh();
                    down = true;
                    facing = dir[1];
                    player.Image = Properties.Resources.hero_idle_front;
                    break;
                case Keys.A :
                    player.Refresh();
                    left = true;
                    facing = dir[2];
                    player.Image = Properties.Resources.hero_idle_side___Copy;
                    break;
                case Keys.D:
                    player.Refresh();
                    right = true;
                    facing = dir[3];
                    player.Image = Properties.Resources.hero_idle_side;
                    break;
            }
        }
        // kiem tra da tha phim chua
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    top = false;
                    break;
                case Keys.S:
                    down = false;
                    break;
                case Keys.A:
                    left = false;
                    break;
                case Keys.D:
                    right = false;
                    break;
            }
        }
        // kiem tra va thuc hien cac hanh dong ban,nap dan, dich chuyen
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // ban khi nhan space va spike > 0
            if (e.KeyChar == (char)Keys.Space && spike>0)
            {
                shootspike(facing);
                spike--;
                SpikeLeft.Value-=10;
                Sshoot.Play();
            }
            // nhan R de nap dan khi spike == 0 
            if (e.KeyChar == (char)Keys.R+32)
            {
                if (spike == 0)
                {
                    spike = 10;
                    SpikeLeft.Value = 100;
                    lbl_spikeNofi.Text = "Refilling";
                    Nofi.Enabled = true;
                }
            }
            // dich chuyen theo cac huong khi nhan F
            if (e.KeyChar == (char)Keys.F + 32 && manaPoint.Value>0)

            {
                if (facing == 1 && player.Top > 50)
                {
                    player.Top -= 80;
                    manaPoint.Value -= 10;
                    Stele.Play();
                }
                else if (facing == 2 && player.Top + player.Height + 130 < this.Height)
                {
                    player.Top += 80;
                    manaPoint.Value -= 10;
                    Stele.Play();
                }
                else if (facing == 3 && player.Left > 80)
                {
                    player.Left -= 80;
                    manaPoint.Value -= 10;
                    Stele.Play();
                }
                else if (facing == 4 && player.Left < line.Left - player.Width - 83)
                {
                    player.Left += 80;
                    manaPoint.Value -= 10;
                    Stele.Play();
                }
              
            }
        }
        private void makeEnemies(int type)
        {
            PictureBox enemy = new PictureBox();
            enemy.Tag = "enemy";
            enemy.BackColor = Color.Transparent;
            enemy.Image = enemies[type];
            enemy.Left = randNum.Next(line.Left+20,this.Width-80);
            enemy.Top = randNum.Next(50,this.Height-130);
            enemy.SizeMode = PictureBoxSizeMode.StretchImage;
            enemy.Size=new Size(48, 48);
            this.Controls.Add(enemy);
            enemy.BringToFront();
            player.BringToFront();
        }

        private void GameForm_Load(object sender, EventArgs e)
        {

        }

        private void makeApples()
        {
            PictureBox apple = new PictureBox();
            apple.Tag = "apple";
            apple.BackColor = Color.Transparent;
            apple.Image = Properties.Resources.ezgif_com_gif_maker;
            apple.Left = randNum.Next(80,line.Left-50);
            apple.Top = randNum.Next(50, this.Height - 130);
            apple.SizeMode = PictureBoxSizeMode.StretchImage;
            apple.Size = new Size(48, 48);
            this.Controls.Add(apple);
            apple.BringToFront();
            player.BringToFront();
        }
        private void dropManaPacks()
        {
            PictureBox banana = new PictureBox();
            banana.Tag = "banana";
            banana.BackColor = Color.Transparent;
            banana.Image = Properties.Resources.ezgif_com_gif_maker__1_;
            banana.Left = randNum.Next(80, line.Left - 50);
            banana.Top = randNum.Next(50, this.Height - 130);
            banana.SizeMode = PictureBoxSizeMode.StretchImage;
            banana.Size = new Size(48, 48);
            this.Controls.Add(banana);
            banana.BringToFront();
            player.BringToFront();

        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (lbl_HPNofi.Text != "")
            {
                lbl_HPNofi.Text = "";
            }
            if(lbl_spikeNofi.Text!=" ")
            {
                lbl_spikeNofi.Text = "";
            }
            if (lbl_MPNoFi.Text != " ")
            {
                lbl_MPNoFi.Text = "";
            }
            
            Nofi.Enabled = false;
        }
        private void Drop_Tick(object sender, EventArgs e)
        {
            if (spike <= 8)
            {
                spike += 2;
                SpikeLeft.Value += 20;
                lbl_spikeNofi.Text = "+2";
                Nofi.Enabled = true;
            }
            if (playerHP <= 80)
            {
                playerHP += 20;
                healthBar.Value += 20;
                lbl_HPNofi.Text = "+20";
                Nofi.Enabled = true;
            }
        }
        
        private void AppleSpawningTimer_Tick(object sender, EventArgs e)
        {
            // tao tao
            if (applesCounted < 1)
            {
                makeApples();
                applesCounted++;
               
            }
            if(manaPacksCounted < 1)
            {
                dropManaPacks();
                manaPacksCounted++;
            }
           
        }
        private void shootspike(int facing)
        {
            spike shootSpike = new spike();
            shootSpike.direction = facing;
            shootSpike.spikeLeft = player.Left + (player.Width / 2);
            shootSpike.spikeTop = player.Top + (player.Height / 2);
            shootSpike.MakeBullet(this);
        }
        private void restartGame()
        {
        
            this.Close();
            BGmusic.controls.stop();
        }

    }
}
