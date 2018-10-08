using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RENK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                openFileDialog1.DefaultExt = ".jpg"; openFileDialog1.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
                openFileDialog1.ShowDialog();
                String ResminYolu = openFileDialog1.FileName; pictureBox1.Image = Image.FromFile(ResminYolu);
            }


        }

        private void lumaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
                Bitmap Image = new Bitmap(pictureBox1.Image);
                Bitmap gri = grıYap(Image);
                pictureBox2.Image = gri;


            }
            private Bitmap grıYap(Bitmap bmp)
            {
                for (int i = 0; i < bmp.Height - 1; i++)
                {
                    for (int j = 0; j < bmp.Width - 1; j++)
                    {
                        int deger = Convert.ToInt16(bmp.GetPixel(j, i).R * 0.299 + bmp.GetPixel(j, i).G * 0.587 + bmp.GetPixel(j, i).B * 0.114);
                        Color renk;
                        renk = Color.FromArgb(deger, deger, deger);
                        bmp.SetPixel(j, i, renk);
                    }
                }
                return bmp;
            }

        private void ortalamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap Image = new Bitmap(pictureBox1.Image);
            Bitmap gri = griYap(Image);
            pictureBox2.Image = gri;


        }
        private Bitmap griYap(Bitmap bmp)
        {
            for (int i = 0; i < bmp.Height - 1; i++)
            {
                for (int j = 0; j < bmp.Width - 1; j++)
                {
                    int deger = Convert.ToInt16(bmp.GetPixel(j, i).R + bmp.GetPixel(j, i).G + bmp.GetPixel(j, i).B) / 3;
                    Color renk;
                    renk = Color.FromArgb(deger, deger, deger);
                    bmp.SetPixel(j, i, renk);
                }
            }
            return bmp;
        }

        private void bT709ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap Image = new Bitmap(pictureBox1.Image);
            Bitmap gri = grıyap(Image);
            pictureBox2.Image = gri;


        }
        private Bitmap grıyap(Bitmap bmp)
        {
            for (int i = 0; i < bmp.Height - 1; i++)
            {
                for (int j = 0; j < bmp.Width - 1; j++)
                {
                    int deger = Convert.ToInt16(bmp.GetPixel(j, i).R * 0.2125 + bmp.GetPixel(j, i).G * 0.7154 + bmp.GetPixel(j, i).B * 0.072);
                    Color renk;
                    renk = Color.FromArgb(deger, deger, deger);
                    bmp.SetPixel(j, i, renk);
                }
            }
            return bmp;
        }
        Bitmap kaynak, islem;
        private void KaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                saveFileDialog1.Filter = " PNG | * .png ";
                DialogResult result= saveFileDialog1.ShowDialog();
                ImageFormat format = ImageFormat.Png;
                if(result == DialogResult.OK) 
            {
                    islem.Save(saveFileDialog1.FileName, format);
                }
            }
        }
                }
            }


        
    

