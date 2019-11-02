using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 영상처리_공부자료
{
    public partial class Form1 : Form
    {
        Image image;

        Bitmap bitmap, newBit, converted_bit;

        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string name = "All Files(*.*)|*.*|Bitmap File(*.bmp)|*.bmp|";
            name = name + "Gif File(*.gif)|*.gif|jpeg File(*.jpg)|*.jpg";
            openFileDialog1.Title = "타이틀";

            openFileDialog1.Filter = name;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                string strName = openFileDialog1.FileName;

                image = Image.FromFile(strName);

                bitmap = new Bitmap(image, image.Width, image.Height);
//                newBit = new Bitmap(image, image.Width, image.Height);
            }

            pictureBox1.Image = new Bitmap(bitmap, pictureBox1.Width, pictureBox1.Height);
            
            IP ip = new IP(bitmap);
            newBit = ip.Gray();
            pictureBox3.Image = new Bitmap(newBit, pictureBox2.Width, pictureBox2.Height);

            this.Invalidate();
        }

        private void 이진화ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            converted_bit = new Bitmap(pictureBox3.Image, image.Width, image.Height);
            IP ip = new IP(converted_bit);
            newBit = ip.Gray();
            pictureBox3.Image = new Bitmap(newBit, pictureBox3.Width, pictureBox3.Height);

            ip = new IP(bitmap);
            newBit = ip.Gray();
            pictureBox2.Image = new Bitmap(newBit, pictureBox2.Width, pictureBox2.Height);
        }

        private void binaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            converted_bit = new Bitmap(pictureBox3.Image, image.Width, image.Height);
            IP ip = new IP(converted_bit);
            newBit = ip.binary();
            pictureBox3.Image = new Bitmap(newBit, pictureBox3.Width, pictureBox3.Height);

            ip = new IP(bitmap);
            newBit = ip.binary();
            pictureBox2.Image = new Bitmap(newBit, pictureBox2.Width, pictureBox2.Height);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void 닫기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(bitmap, pictureBox1.Width, pictureBox1.Height);
        }

        private void 닫기ToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void 닫기ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void maxminBinaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            converted_bit = new Bitmap(pictureBox3.Image, image.Width, image.Height);
            IP ip = new IP(converted_bit);
            newBit = ip.maxminbinary();
            pictureBox3.Image = new Bitmap(newBit, pictureBox3.Width, pictureBox3.Height);

            ip = new IP(bitmap);
            newBit = ip.maxminbinary();
            pictureBox2.Image = new Bitmap(newBit, pictureBox2.Width, pictureBox2.Height);
        }

        private void roiareaToolStripMenuItem_Click(object sender, EventArgs e)
        {
                        converted_bit = new Bitmap(pictureBox3.Image, image.Width, image.Height);
            IP ip = new IP(converted_bit);
            newBit = ip.roiarea();
            pictureBox3.Image = new Bitmap(newBit, pictureBox3.Width, pictureBox3.Height);

            ip = new IP(bitmap);
            newBit = ip.roiarea();
            pictureBox2.Image = new Bitmap(newBit, pictureBox2.Width, pictureBox2.Height);
        }

        private void brightupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            converted_bit = new Bitmap(pictureBox3.Image, image.Width, image.Height);
            IP ip = new IP(converted_bit);
            newBit = ip.brightup();
            pictureBox3.Image = new Bitmap(newBit, pictureBox3.Width, pictureBox3.Height);
            
            ip = new IP(bitmap);
            newBit = ip.brightup();
            pictureBox2.Image = new Bitmap(newBit, pictureBox2.Width, pictureBox2.Height);
        }

        private void flowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            converted_bit = new Bitmap(pictureBox3.Image, image.Width, image.Height);
            IP ip = new IP(converted_bit);
            newBit = ip.flow();
            pictureBox3.Image = new Bitmap(newBit, pictureBox3.Width, pictureBox3.Height);

            ip = new IP(bitmap);
            newBit = ip.flow();
            pictureBox2.Image = new Bitmap(newBit, pictureBox2.Width, pictureBox2.Height);
        }

        private void blockmaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            converted_bit = new Bitmap(pictureBox3.Image, image.Width, image.Height);
            IP ip = new IP(converted_bit);
            newBit = ip.block_mask();
            pictureBox3.Image = new Bitmap(newBit, pictureBox3.Width, pictureBox3.Height);

            ip = new IP(bitmap);
            newBit = ip.block_mask();
            pictureBox2.Image = new Bitmap(newBit, pictureBox2.Width, pictureBox2.Height);
        }

        private void borderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            converted_bit = new Bitmap(pictureBox3.Image, image.Width, image.Height);
            IP ip = new IP(converted_bit);
            newBit = ip.border();
            pictureBox3.Image = new Bitmap(newBit, pictureBox3.Width, pictureBox3.Height);

            ip = new IP(bitmap);
            newBit = ip.border();
            pictureBox2.Image = new Bitmap(newBit, pictureBox2.Width, pictureBox2.Height);
        }

        private void histogramViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            converted_bit = new Bitmap(pictureBox3.Image, image.Width, image.Height);
            histogram hs = new histogram(converted_bit);
            newBit = hs.histogramview();
            pictureBox3.Image = new Bitmap(newBit, pictureBox3.Width, pictureBox3.Height);

            hs = new histogram(bitmap);
            newBit = hs.histogramview();
            pictureBox2.Image = new Bitmap(newBit, pictureBox2.Width, pictureBox2.Height);
        }

        private void reverseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            converted_bit = new Bitmap(pictureBox3.Image, image.Width, image.Height);
            IP ip = new IP(converted_bit);
            newBit = ip.reverse();
            pictureBox3.Image = new Bitmap(newBit, pictureBox3.Width, pictureBox3.Height);

            ip = new IP(bitmap);
            newBit = ip.reverse();
            pictureBox2.Image = new Bitmap(newBit, pictureBox2.Width, pictureBox2.Height);
        }

        private void brightLUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            converted_bit = new Bitmap(pictureBox3.Image, image.Width, image.Height);
            histogram hs = new histogram(converted_bit);
            newBit = hs.adjustBright();
            pictureBox3.Image = new Bitmap(newBit, pictureBox3.Width, pictureBox3.Height);

            hs = new histogram(bitmap);
            newBit = hs.adjustBright();
            pictureBox2.Image = new Bitmap(newBit, pictureBox2.Width, pictureBox2.Height);
        }

        private void basicStretchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            converted_bit = new Bitmap(pictureBox3.Image, image.Width, image.Height);
            histogram hs = new histogram(converted_bit);
            newBit = hs.basicStretch();
            pictureBox3.Image = new Bitmap(newBit, pictureBox3.Width, pictureBox3.Height);

            hs = new histogram(bitmap);
            newBit = hs.basicStretch();
            pictureBox2.Image = new Bitmap(newBit, pictureBox2.Width, pictureBox2.Height);
        }

        private void equalizationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            converted_bit = new Bitmap(pictureBox3.Image, image.Width, image.Height);
            histogram hs = new histogram(converted_bit);
            newBit = hs.equalization();
            pictureBox3.Image = new Bitmap(newBit, pictureBox3.Width, pictureBox3.Height);

            hs = new histogram(bitmap);
            newBit = hs.equalization();
            pictureBox2.Image = new Bitmap(newBit, pictureBox2.Width, pictureBox2.Height);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
       
    }
}
