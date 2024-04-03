using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7CSharp
{
    public partial class Form2 : Form
    {
        private Bitmap originalImage;

        public Form2()
        {
            InitializeComponent();
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Bitmap Image|*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                originalImage = new Bitmap(openFileDialog.FileName);
                pictureBox1.Image = originalImage;
            }
        }

        private void extractButton_Click(object sender, EventArgs e)
        {
            if (originalImage == null)
            {
                MessageBox.Show("Please open an image first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Bitmap extractedImage = new Bitmap(originalImage.Width, originalImage.Height);

            ColorComponent selectedComponent = GetSelectedComponent();

            for (int y = 0; y < originalImage.Height; y++)
            {
                for (int x = 0; x < originalImage.Width; x++)
                {
                    Color pixelColor = originalImage.GetPixel(x, y);
                    Color newColor = Color.Black;

                    switch (selectedComponent)
                    {
                        case ColorComponent.Red:
                            newColor = Color.FromArgb(pixelColor.R, 0, 0);
                            break;
                        case ColorComponent.Green:
                            newColor = Color.FromArgb(0, pixelColor.G, 0);
                            break;
                        case ColorComponent.Blue:
                            newColor = Color.FromArgb(0, 0, pixelColor.B);
                            break;
                    }

                    extractedImage.SetPixel(x, y, newColor);
                   
                }
            }
            pictureBox1.Image = extractedImage;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Bitmap Image|*.bmp";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                extractedImage.Save(saveFileDialog.FileName);
            }
        }

        private ColorComponent GetSelectedComponent()
        {
            if (redRadioButton.Checked)
                return ColorComponent.Red;
            else if (greenRadioButton.Checked)
                return ColorComponent.Green;
            else
                return ColorComponent.Blue;
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Bitmap extractedImage = new Bitmap(originalImage.Width, originalImage.Height);

            ColorComponent selectedComponent = GetSelectedComponent();

            for (int y = 0; y < originalImage.Height; y++)
            {
                for (int x = 0; x < originalImage.Width; x++)
                {
                    Color pixelColor = originalImage.GetPixel(x, y);
                    Color newColor = Color.Black;

                    switch (selectedComponent)
                    {
                        case ColorComponent.Red:
                            newColor = Color.FromArgb(pixelColor.R, 0, 0);
                            break;
                        case ColorComponent.Green:
                            newColor = Color.FromArgb(0, pixelColor.G, 0);
                            break;
                        case ColorComponent.Blue:
                            newColor = Color.FromArgb(0, 0, pixelColor.B);
                            break;
                    }

                    extractedImage.SetPixel(x, y, newColor);

                }
            }
            pictureBox1.Image = extractedImage;
        }
    }

    public enum ColorComponent
    {
        Red,
        Green,
        Blue
    }
}
