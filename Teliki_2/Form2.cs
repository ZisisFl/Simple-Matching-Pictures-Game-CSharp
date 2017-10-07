using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teliki_2
{
    public partial class Form2 : Form
    {
        public Form2(string[] u_name, int[] time, int[] tries)
        {
            InitializeComponent();
            player1.Text = u_name[0];
            player2.Text = u_name[1];
            player3.Text = u_name[2];
            player4.Text = u_name[3];
            player5.Text = u_name[4];
            player6.Text = u_name[5];
            player7.Text = u_name[6];
            player8.Text = u_name[7];
            player9.Text = u_name[8];
            player10.Text = u_name[9];

            time1.Text = time[0].ToString();
            time2.Text = time[1].ToString();
            time3.Text = time[2].ToString();
            time4.Text = time[3].ToString();
            time5.Text = time[4].ToString();
            time6.Text = time[5].ToString();
            time7.Text = time[6].ToString();
            time8.Text = time[7].ToString();
            time9.Text = time[8].ToString();
            time10.Text = time[9].ToString();

            tries1.Text = time[0].ToString();
            tries2.Text = time[1].ToString();
            tries3.Text = time[2].ToString();
            tries4.Text = time[3].ToString();
            tries5.Text = time[4].ToString();
            tries6.Text = time[5].ToString();
            tries7.Text = time[6].ToString();
            tries8.Text = time[7].ToString();
            tries9.Text = time[8].ToString();
            tries10.Text = time[9].ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
