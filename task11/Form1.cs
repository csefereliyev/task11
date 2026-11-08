using System.Media;

namespace task11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Random random = new Random();
            bomb = random.Next(1, 7);
            if (point == 5)
            {
                MessageBox.Show(":D", "Bomba partlamadi", MessageBoxButtons.OK);
            }
        }
        int bomb;
        int point;
        bool gameover = false;
        SoundPlayer sp=new SoundPlayer("C:\\Users\\User\\Downloads\\explosion.wav");
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (gameover == true)
            {
                return;
            }
            if (bomb == 1)
            {
                pictureBox1.ImageLocation = "C:\\Users\\User\\Downloads\\bomb.png";
                gameover = true;
                sp.Play();
                MessageBox.Show(":(", "Bomba partladi", MessageBoxButtons.OK);
            }
            else
            {
                point++;
                pictureBox1.ImageLocation = "C:\\Users\\User\\Downloads\\penguin.png";
                label2.Text = point.ToString();

                pictureBox1.Enabled = false;
                if (point==5)
                {
                    gameover = true;
                    DialogResult d=MessageBox.Show("Qalib oldunuz,Yeni oyun ucun Ok duymesine basin!", ":D", MessageBoxButtons.OK);
                    if (d == DialogResult.OK) 
                    {
                        button1.PerformClick();
                    }
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (gameover == true)
            {
                return;
            }
            if (bomb == 2)
            {
                gameover = true;
                sp.Play();
                pictureBox2.ImageLocation = "C:\\Users\\User\\Downloads\\bomb.png";
                MessageBox.Show(":(", "Bomba partladi", MessageBoxButtons.OK);
            }
            else
            {
                point++;
                pictureBox2.ImageLocation = "C:\\Users\\User\\Downloads\\penguin.png";
                label2.Text = point.ToString();
                pictureBox2.Enabled = false;
                if (point == 5)
                {
                    gameover = true;
                    DialogResult d = MessageBox.Show("Qalib oldunuz,Yeni oyun ucun Ok duymesine basin!", ":D", MessageBoxButtons.OK);
                    if (d == DialogResult.OK)
                    {
                        button1.PerformClick();
                    }
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (gameover == true)
            {
                return;
            }
            if (bomb == 3)
            {
                gameover = true;
                sp.Play();
                pictureBox3.ImageLocation = "C:\\Users\\User\\Downloads\\bomb.png";
                MessageBox.Show(":(", "Bomba partladi", MessageBoxButtons.OK);
            }
            else
            {
                point++;
                pictureBox3.ImageLocation = "C:\\Users\\User\\Downloads\\penguin.png";
                label2.Text = point.ToString();
                pictureBox3.Enabled = false;
                if (point == 5)
                {
                    gameover = true;
                    DialogResult d = MessageBox.Show("Qalib oldunuz,Yeni oyun ucun Ok duymesine basin!", ":D", MessageBoxButtons.OK);
                    if (d == DialogResult.OK)
                    {
                        button1.PerformClick();
                    }
                }
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (gameover == true)
            {
                return;
            }
            if (bomb == 6)
            {
                gameover = true;
                sp.Play();
                pictureBox6.ImageLocation = "C:\\Users\\User\\Downloads\\bomb.png";
                MessageBox.Show(":(", "Bomba partladi", MessageBoxButtons.OK);
            }
            else
            {
                point++;
                pictureBox6.ImageLocation = "C:\\Users\\User\\Downloads\\penguin.png";
                label2.Text = point.ToString();
                pictureBox6.Enabled = false;
                if (point == 5)
                {
                    gameover = true;
                    DialogResult d = MessageBox.Show("Qalib oldunuz,Yeni oyun ucun Ok duymesine basin!", ":D", MessageBoxButtons.OK);
                    if (d == DialogResult.OK)
                    {
                        button1.PerformClick();
                    }
                }
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (gameover == true)
            {
                return;
            }
            if (bomb == 4)
            {
                gameover = true;
                sp.Play();
                pictureBox4.ImageLocation = "C:\\Users\\User\\Downloads\\bomb.png";
                MessageBox.Show(":(", "Bomba partladi", MessageBoxButtons.OK);
            }
            else
            {
                point++;
                pictureBox4.ImageLocation = "C:\\Users\\User\\Downloads\\penguin.png";
                label2.Text = point.ToString();
                pictureBox4.Enabled = false;
                if (point == 5)
                {
                    gameover = true;
                    DialogResult d = MessageBox.Show("Qalib oldunuz,Yeni oyun ucun Ok duymesine basin!", ":D", MessageBoxButtons.OK);
                    if (d == DialogResult.OK)
                    {
                        button1.PerformClick();
                    }
                }
            }
        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            if (gameover == true)
            {
                return;
            }
            if (bomb == 5)
            {
                pictureBox5.ImageLocation = "C:\\Users\\User\\Downloads\\bomb.png";
                sp.Play();
                gameover = true;
                MessageBox.Show(":(", "Bomba partladi", MessageBoxButtons.OK);
            }
            else
            {
                point++;
                pictureBox5.ImageLocation = "C:\\Users\\User\\Downloads\\penguin.png";
                label2.Text = point.ToString();
                pictureBox5.Enabled = false;
                if (point == 5)
                {
                    gameover = true;
                    DialogResult d = MessageBox.Show("Qalib oldunuz,Yeni oyun ucun Ok duymesine basin!", ":D", MessageBoxButtons.OK);
                    if (d == DialogResult.OK)
                    {
                        button1.PerformClick();
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "C:\\Users\\User\\Downloads\\question.png";
            pictureBox2.ImageLocation = "C:\\Users\\User\\Downloads\\question.png";
            pictureBox3.ImageLocation = "C:\\Users\\User\\Downloads\\question.png";
            pictureBox4.ImageLocation = "C:\\Users\\User\\Downloads\\question.png";
            pictureBox5.ImageLocation = "C:\\Users\\User\\Downloads\\question.png";
            pictureBox6.ImageLocation = "C:\\Users\\User\\Downloads\\question.png";

            pictureBox1.Enabled = true;
            pictureBox2.Enabled = true;
            pictureBox3.Enabled = true;
            pictureBox4.Enabled = true;
            pictureBox5.Enabled = true;
            pictureBox6.Enabled = true;

            point = 0;
            label2.Text = "0";
            Random random = new Random();
            bomb = random.Next(1, 7);
            gameover = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
