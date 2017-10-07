using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Drawing;

namespace Teliki_2
{
    class ImgLoad
    {
        public void Load(PictureBox[] array1, PictureBox[] array2)
        {
            for (int i = 0; i < 20; i++)
            {
                array1[i] = new PictureBox();
                array1[i].Size = new Size(120, 85);
                array1[i].SizeMode = PictureBoxSizeMode.StretchImage;
                array2[i] = new PictureBox();
                array2[i].Size = new Size(120, 85);
                array2[i].SizeMode = PictureBoxSizeMode.StretchImage;


                if (i < 5)
                {
                    array1[i].Location = new Point(0 + (i * 141), 57);
                    array2[i].Location = new Point(0 + (i * 141), 57);
                }
                else if (i >= 5 && i < 10)
                {
                    array1[i].Location = new Point(0 + ((i - 5) * 141), 148);
                    array2[i].Location = new Point(0 + ((i - 5) * 141), 148);
                }
                else if (i >= 10 && i < 15)
                {
                    array1[i].Location = new Point(0 + ((i - 10) * 141), 239);
                    array2[i].Location = new Point(0 + ((i - 10) * 141), 239);
                }
                else
                {
                    array1[i].Location = new Point(0 + ((i - 15) * 141), 330);
                    array2[i].Location = new Point(0 + ((i - 15) * 141), 330);
                }
            }
        }
    }
}
