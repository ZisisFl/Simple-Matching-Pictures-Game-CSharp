using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace Teliki_2
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=" + Application.StartupPath + "\\scores.mdf;Integrated Security = True");
        PictureBox[] userImages = new PictureBox[20];
        PictureBox[] coverImg = new PictureBox[20];
        int [] imageID = new int[20];
        int[] pair = new int[2];
        int count ;
        int timepassed = 0;
        int k;
        int win_count;
        string username;
        string[] u_name = new string[10];
        int[] time = new int[10];
        int[] tries = new int[10];
        bool temp = false;


        public Form1()
        {
            InitializeComponent();
        }

        public void Game()
        {
            if (count % 2 == 0)  //pair opened
            {
                if (imageID[pair[0]] == imageID[pair[1]])//same id ?
                {
                    win_count = win_count + 1;
                    image_destroy.Start();  //clock to delay card destruction
                }
                else
                {
                    image_show.Start(); //clock to delay card closure
                }
            }
        }

        private void image_show_Tick(object sender, EventArgs e)
        {
            coverImg[pair[0]].Visible = true;
            coverImg[pair[1]].Visible = true;
            Array.Clear(pair, 0, pair.Length);
            image_show.Stop();
            temp = false;
        }

        private void image_destroy_Tick(object sender, EventArgs e)
        {
            this.Controls.Remove(userImages[pair[0]]);
            this.Controls.Remove(userImages[pair[1]]);
            Array.Clear(pair, 0, pair.Length);
            image_destroy.Stop();
            temp = false;
            if (win_count == 10)
            {
                counter.Stop();
                panel1.Location = new Point(this.ClientSize.Width / 2 - panel1.Size.Width / 2,this.ClientSize.Height / 2 - panel1.Size.Height / 2);
                this.panel1.Visible = true;
                MessageBox.Show("You have won in " + timepassed + " seconds" +
                    " with " + count / 2 + " tries");

                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into [Table](username, time, tries) values('" + username + "', '" + timepassed + "', '" + count/2 + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("successfull registration");
            }
        }


        private void hall_of_fame_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM [Table] ORDER BY time ASC";
            cmd.ExecuteNonQuery();
            SqlDataReader rdr = cmd.ExecuteReader();

            for (int l = 0;l < 10;l++)
            {
                rdr.Read();
                u_name[l] = rdr.GetString(0);
                time[l] = rdr.GetInt32(1);
                tries[l] = rdr.GetInt32(2);
            }

            con.Close();
            Form2 f2 = new Form2(u_name, time, tries);
            f2.Show();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            if (ImageChoose.FileNames.Length == 10)
            {
                if (Username.Text != "")
                {
                    username_show.Text = Username.Text.ToString();

                    username = Username.Text;
                    
                    this.Controls.Remove(Start);
                    this.Controls.Remove(game_name);
                    this.Controls.Remove(Username);
                    this.Controls.Remove(label_u);
                    this.panel1.Visible = false;
                    this.panel2.Visible = true;

                    counter.Start();

                    for (int i = 0; i < 20; i++)
                    {
                        coverImg[i].Image = Image.FromFile("background.jpg");
                        this.Controls.Add(coverImg[i]);
                    }
                    for (int i = 0; i < 20; i++)
                    {
                        this.Controls.Add(userImages[i]);
                    }
                }
                else
                    MessageBox.Show("Enter a username");
            }
            else
                MessageBox.Show("Please choose images to play with!");
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Remember the Picture! Test your memory trying to match"+
                " the identical pictures. You can turn only 2 pictures at a time."+
                " Hurry up you play against the clock. Number of tries count as "+
                "well.");
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            k = 0;
            var nums = Enumerable.Range(0, 20).ToArray();

            // Shuffle the array
            for (int i = 0; i < nums.Length; ++i)
            {
                int randomIndex = r.Next(nums.Length);
                int temp = nums[randomIndex];
                nums[randomIndex] = nums[i];
                nums[i] = temp;
            }

            ImageChoose.Multiselect = true;
            if (ImageChoose.ShowDialog() == DialogResult.OK && ImageChoose.FileNames.Length == 10)
            {
                int j = 0;
                foreach (String file in ImageChoose.FileNames)
                {
                    userImages[nums[k]].Image = Image.FromFile(file);
                    imageID[nums[k]] = j; //create id for the pair
                    k++;

                    userImages[nums[k]].Image = Image.FromFile(file);
                    imageID[nums[k]] = j;
                    k++;
                    j++;
                }
            }
            else
                MessageBox.Show("You selected " + ImageChoose.FileNames.Length.ToString() + " image(s) you need to select 10");
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            ImgLoad nimgLoad = new ImgLoad();
            nimgLoad.Load(userImages, coverImg);
            
            coverImg[0].Click += new System.EventHandler(PictureBoxes_Click);
            coverImg[1].Click += new System.EventHandler(PictureBoxes_Click1);
            coverImg[2].Click += new System.EventHandler(PictureBoxes_Click2);
            coverImg[3].Click += new System.EventHandler(PictureBoxes_Click3);
            coverImg[4].Click += new System.EventHandler(PictureBoxes_Click4);
            coverImg[5].Click += new System.EventHandler(PictureBoxes_Click5);
            coverImg[6].Click += new System.EventHandler(PictureBoxes_Click6);
            coverImg[7].Click += new System.EventHandler(PictureBoxes_Click7);
            coverImg[8].Click += new System.EventHandler(PictureBoxes_Click8);
            coverImg[9].Click += new System.EventHandler(PictureBoxes_Click9);
            coverImg[10].Click += new System.EventHandler(PictureBoxes_Click10);
            coverImg[11].Click += new System.EventHandler(PictureBoxes_Click11);
            coverImg[12].Click += new System.EventHandler(PictureBoxes_Click12);
            coverImg[13].Click += new System.EventHandler(PictureBoxes_Click13);
            coverImg[14].Click += new System.EventHandler(PictureBoxes_Click14);
            coverImg[15].Click += new System.EventHandler(PictureBoxes_Click15);
            coverImg[16].Click += new System.EventHandler(PictureBoxes_Click16);
            coverImg[17].Click += new System.EventHandler(PictureBoxes_Click17);
            coverImg[18].Click += new System.EventHandler(PictureBoxes_Click18);
            coverImg[19].Click += new System.EventHandler(PictureBoxes_Click19);

        }

        private void PictureBoxes_Click(object sender, EventArgs e)
        {
            if (temp == false)
            {
                coverImg[0].Visible = false;//are 2 cards open ?
                count++;

                if (count % 2 == 0)
                {
                    pair[1] = 0;
                    temp = true;
                }
                else
                    pair[0] = 0;

                Game();
            }

        }
        private void PictureBoxes_Click1(object sender, EventArgs e)
        {
            if (temp == false)
            {
                coverImg[1].Visible = false;
                count = count + 1;

                if (count % 2 == 0)
                {
                    pair[1] = 1;
                    temp = true;
                }
                else
                    pair[0] = 1;

                Game();
            }
        }

        private void PictureBoxes_Click2(object sender, EventArgs e)
        {
            if (temp == false)
            {
                coverImg[2].Visible = false;
                count = count + 1;

                if (count % 2 == 0)
                {
                    pair[1] = 2;
                    temp = true;
                }
                else
                    pair[0] = 2;

                Game();
            }
        }

        private void PictureBoxes_Click3(object sender, EventArgs e)
        {
            if (temp == false)
            {
                coverImg[3].Visible = false;
                count = count + 1;

                if (count % 2 == 0)
                {
                    pair[1] = 3;
                    temp = true;
                }
                else
                    pair[0] = 3;

                Game();
            }
        }

        private void PictureBoxes_Click4(object sender, EventArgs e)
        {
            if (temp == false)
            {
                coverImg[4].Visible = false;
                count = count + 1;

                if (count % 2 == 0)
                {
                    pair[1] = 4;
                    temp = true;
                }
                else
                    pair[0] = 4;

                Game();
            }
        }
        private void PictureBoxes_Click5(object sender, EventArgs e)
        {
            if (temp == false)
            {
                coverImg[5].Visible = false;
                count = count + 1;

                if (count % 2 == 0)
                {
                    pair[1] = 5;
                    temp = true;
                }
                else
                    pair[0] = 5;

                Game();
            }
        }
        private void PictureBoxes_Click6(object sender, EventArgs e)
        {
            if (temp == false)
            {
                coverImg[6].Visible = false;
                count = count + 1;

                if (count % 2 == 0)
                {
                    pair[1] = 6;
                    temp = true;
                }
                else
                    pair[0] = 6;

                Game();
            }
        }

        private void PictureBoxes_Click7(object sender, EventArgs e)
        {
            if (temp == false)
            {
                coverImg[7].Visible = false;
                count = count + 1;

                if (count % 2 == 0)
                {
                    pair[1] = 7;
                    temp = true;
                }
                else
                    pair[0] = 7;

                Game();
            }
        }

        private void PictureBoxes_Click8(object sender, EventArgs e)
        {
            if (temp == false)
            {
                coverImg[8].Visible = false;
                count = count + 1;

                if (count % 2 == 0)
                {
                    pair[1] = 8;
                    temp = true;
                }
                else
                    pair[0] = 8;

                Game();
            }
        }

        private void PictureBoxes_Click9(object sender, EventArgs e)
        {
            if (temp == false)
            {
                coverImg[9].Visible = false;
                count = count + 1;

                if (count % 2 == 0)
                {
                    pair[1] = 9;
                    temp = true;
                }
                else
                    pair[0] = 9;

                Game();
            }
        }

        private void PictureBoxes_Click10(object sender, EventArgs e)
        {
            if (temp == false)
            {
                coverImg[10].Visible = false;
                count = count + 1;

                if (count % 2 == 0)
                {
                    pair[1] = 10;
                    temp = true;
                }
                else
                    pair[0] = 10;

                Game();
            }
        }
        private void PictureBoxes_Click11(object sender, EventArgs e)
        {
            if (temp == false)
            {
                coverImg[11].Visible = false;
                count = count + 1;

                if (count % 2 == 0)
                {
                    pair[1] = 11;
                    temp = true;
                }
                else
                    pair[0] = 11;

                Game();
            }
        }

        private void PictureBoxes_Click12(object sender, EventArgs e)
        {
            if (temp == false)
            {
                coverImg[12].Visible = false;
                count = count + 1;

                if (count % 2 == 0)
                {
                    pair[1] = 12;
                    temp = true;
                }
                else
                    pair[0] = 12;

                Game();
            }
        }

        private void PictureBoxes_Click13(object sender, EventArgs e)
        {
            if (temp == false)
            {
                coverImg[13].Visible = false;
                count = count + 1;

                if (count % 2 == 0)
                {
                    pair[1] = 13;
                    temp = true;
                }
                else
                    pair[0] = 13;

                Game();
            }
        }

        private void PictureBoxes_Click14(object sender, EventArgs e)
        {
            if (temp == false)
            {
                coverImg[14].Visible = false;
                count = count + 1;

                if (count % 2 == 0)
                {
                    pair[1] = 14;
                    temp = true;
                }
                else
                    pair[0] = 14;

                Game();
            }
        }
        private void PictureBoxes_Click15(object sender, EventArgs e)
        {
            if (temp == false)
            {
                coverImg[15].Visible = false;
                count = count + 1;

                if (count % 2 == 0)
                {
                    pair[1] = 15;
                    temp = true;
                }
                else
                    pair[0] = 15;

                Game();
            }
        }
        private void PictureBoxes_Click16(object sender, EventArgs e)
        {
            if (temp == false)
            {
                coverImg[16].Visible = false;
                count = count + 1;

                if (count % 2 == 0)
                {
                    pair[1] = 16;
                    temp = true;
                }
                else
                    pair[0] = 16;

                Game();
            }
        }

        private void PictureBoxes_Click17(object sender, EventArgs e)
        {
            if (temp == false)
            {
                coverImg[17].Visible = false;
                count = count + 1;

                if (count % 2 == 0)
                {
                    pair[1] = 17;
                    temp = true;
                }
                else
                    pair[0] = 17;

                Game();
            }
        }

        private void PictureBoxes_Click18(object sender, EventArgs e)
        {
            if (temp == false)
            {
                coverImg[18].Visible = false;
                count = count + 1;

                if (count % 2 == 0)
                {
                    pair[1] = 18;
                    temp = true;
                }
                else
                    pair[0] = 18;

                Game();
            }
        }


        private void PictureBoxes_Click19(object sender, EventArgs e)
        {
            if (temp == false)
            {
                coverImg[19].Visible = false;
                count = count + 1;

                if (count % 2 == 0)
                {
                    pair[1] = 19;
                    temp = true;
                }
                else
                    pair[0] = 19;

                Game();
            }
        }

        private void counter_Tick(object sender, EventArgs e)
        {
            timepassed = timepassed + 1;
            timer.Text = timepassed.ToString()+" s";
        }

    }
}
