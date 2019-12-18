using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm
{
    public partial class JeuTaquin : Form
    {
        public JeuTaquin()
        {
            InitializeComponent();
        }

        private void btnShuffle_Click(object sender, EventArgs e)
        {
            
            List<int> listPicturesBox = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            List<int> listImages = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            
            Random random = new Random();
            int randomPictureBox = random.Next(1, 10);
            Image imageNull = WindowsForm.Properties.Resources._null;
            addPictureToIndex(imageNull, randomPictureBox);
            listPicturesBox.Remove(randomPictureBox);

            int randomImage;
            for (int index = 1; index < 9; index++)
            {
                randomPictureBox = random.Next(1, 10);
                while (!listPicturesBox.Contains(randomPictureBox))
                {
                    randomPictureBox = random.Next(1, 10);
                }

                randomImage = random.Next(1, 10);
                while (!listImages.Contains(randomImage))
                {
                    randomImage = random.Next(1, 10);
                }

                switch (randomImage)
                {
                    case 1:
                        Image image1 = WindowsForm.Properties.Resources._1;
                        addPictureToIndex(image1, randomPictureBox);
                        break;
                    case 2:
                        Image image2 = WindowsForm.Properties.Resources._2;
                        addPictureToIndex(image2, randomPictureBox);
                        break;
                    case 3:
                        Image image3 = WindowsForm.Properties.Resources._3;
                        addPictureToIndex(image3, randomPictureBox);
                        break;
                    case 4:
                        Image image4 = WindowsForm.Properties.Resources._4;
                        addPictureToIndex(image4, randomPictureBox);
                        break;
                    case 5:
                        Image image5 = WindowsForm.Properties.Resources._5;
                        addPictureToIndex(image5, randomPictureBox);
                        break;
                    case 6:
                        Image image6 = WindowsForm.Properties.Resources._6;
                        addPictureToIndex(image6, randomPictureBox);
                        break;
                    case 7:
                        Image image7 = WindowsForm.Properties.Resources._7;
                        addPictureToIndex(image7, randomPictureBox);
                        break;
                    case 8:
                        Image image8 = WindowsForm.Properties.Resources._8;
                        addPictureToIndex(image8, randomPictureBox);
                        break;
                    case 9:
                        Image image9 = WindowsForm.Properties.Resources._9;
                        addPictureToIndex(image9, randomPictureBox);
                        break;
                }
                listPicturesBox.Remove(randomPictureBox);
                listImages.Remove(randomImage);
            }
        }

        private void addPictureToIndex(Image image, int indexPictureBox)
        {
            switch (indexPictureBox)
            {
                case 1:
                    picture1.Image = image;
                    break;
                case 2:
                    picture2.Image = image;
                    break;
                case 3:
                    picture3.Image = image;
                    break;
                case 4:
                    picture4.Image = image;
                    break;
                case 5:
                    picture5.Image = image;
                    break;
                case 6:
                    picture6.Image = image;
                    break;
                case 7:
                    picture7.Image = image;
                    break;
                case 8:
                    picture8.Image = image;
                    break;
                case 9:
                    picture9.Image = image;
                    break;
            }
        }

        
        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
