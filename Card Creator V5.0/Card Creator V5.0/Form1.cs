using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Card_Creator_V5._0
{
    public partial class Form1 : Form
    {
        public enum corners {TL, TR, BL, BR};
        public List<string> Colors = new List<string>{ "Red", "Blue", "Green", "Yellow" };

        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < Colors.Count; ++i)
            {
                cbBottomRight.Items.Add(Colors[i]);
                cbTopRight.Items.Add(Colors[i]);
                cbBottomLeft.Items.Add(Colors[i]);
                cbTopLeft.Items.Add(Colors[i]);
            }
            cbTopLeft.SelectedIndex = 0;
            cbBottomLeft.SelectedIndex = 0;
            cbTopRight.SelectedIndex = 0;
            cbBottomRight.SelectedIndex = 0;
        }

        public void ColorImageCorner(Brush color, corners corner)
        {
            Bitmap editedImg = new Bitmap(pbCard.Image);//get a new bitmap image based on the picturebox image
            Graphics flagGraphics = Graphics.FromImage(editedImg);//create a new graphic to edit based on the bitmap

            Point topLeft = new Point();
            int rectWidth = 20;
            int rectHeight = 20;

            //select top left of corner to edit based on selection
            if(corner == corners.TL)
                topLeft = new Point(2, 2);
            else if (corner == corners.TR)
                topLeft = new Point(218, 2);
            else if (corner == corners.BL)
                topLeft = new Point(2, 314);
            else if (corner == corners.BR)
                topLeft = new Point(218, 314);

            flagGraphics.DrawRectangle(new Pen(color,1), new Rectangle(topLeft.X, topLeft.Y, rectWidth, rectHeight));
            //flagGraphics.FillRectangle(color, topLeft.X, topLeft.Y, rectWidth, rectHeight);//do area fill on selected corner

            pbCard.Image = editedImg;//save the edited graphic to the picturebox image
        }

        public void WriteDescription(string text)
        {
            int width = 25;
            Bitmap editedImg = new Bitmap(pbCard.Image);//get a new bitmap image based on the picturebox image
            Graphics flagGraphics = Graphics.FromImage(editedImg);//create a new graphic to edit based on the bitmap

            flagGraphics.FillRectangle(Brushes.White, 15, 190, 210, 113);//do area fill on selected corner

            pbCard.Image = editedImg;//save the edited graphic to the picturebox image

            
            Point Location = new Point(15, 190);

            using (Font arialFont = new Font("Arial", 10))
            {
                int i = 0;
                while (i < text.Length)
                {
                    if (i + width > text.Length)
                        flagGraphics.DrawString(text.Substring(i, text.Length - i), arialFont, Brushes.Black, Location);
                    else
                        flagGraphics.DrawString(text.Substring(i, width), arialFont, Brushes.Black, Location);
                    Location.Y += 14;
                    i += width;
                }
            }

            pbCard.Image = editedImg;//save the edited graphic to the picturebox image
        }

        public void WriteCardType(string text)
        {
            int width = 30;
            Bitmap editedImg = new Bitmap(pbCard.Image);//get a new bitmap image based on the picturebox image
            Graphics flagGraphics = Graphics.FromImage(editedImg);//create a new graphic to edit based on the bitmap

            flagGraphics.FillRectangle(Brushes.White, 15, 174, 190, 8);//do area fill on selected corner

            pbCard.Image = editedImg;//save the edited graphic to the picturebox image


            Point Location = new Point(15, 171);

            using (Font arialFont = new Font("Arial", 8))
            {
                //int i = 0;
                //while (i < text.Length)
                //{
                if (width > text.Length)
                    flagGraphics.DrawString(text.Substring(0, text.Length), arialFont, Brushes.Black, Location);
                else
                    flagGraphics.DrawString(text.Substring(0, width), arialFont, Brushes.Black, Location);
                //    Location.Y += 14;
                //    i += width;
                //}
            }

            pbCard.Image = editedImg;//save the edited graphic to the picturebox image
        }

        public void WriteName(string text)
        {
            int width = 25;
            Point Location = new Point(35, 5);
            
            Bitmap editedImg = new Bitmap(pbCard.Image);//get a new bitmap image based on the picturebox image
            Graphics flagGraphics = Graphics.FromImage(editedImg);//create a new graphic to edit based on the bitmap

            flagGraphics.FillRectangle(Brushes.White, Location.X, Location.Y, 170, 17);//do area fill on selected corner

            using (Font arialFont = new Font("Arial", 10))
            {
                //int i = 0;
                //while (i < text.Length)
                //{
                    if (width > text.Length)
                        flagGraphics.DrawString(text.Substring(0, text.Length), arialFont, Brushes.Black, Location);
                    else
                        flagGraphics.DrawString(text.Substring(0, width), arialFont, Brushes.Black, Location);
                //    Location.Y += 14;
                //    i += width;
                //}
            }

            pbCard.Image = editedImg;//save the edited graphic to the picturebox image
        }

        public void WriteCosts(int pop, int food, int mineral, int money)
        {
            Point Location = new Point(32, 306);

            Bitmap editedImg = new Bitmap(pbCard.Image);//get a new bitmap image based on the picturebox image
            Graphics flagGraphics = Graphics.FromImage(editedImg);//create a new graphic to edit based on the bitmap

            using (Font arialFont = new Font("Arial", 10))
            {
                flagGraphics.FillRectangle(Brushes.White, Location.X, Location.Y, 9, 13);//do area fill on selected corner
                flagGraphics.DrawString(pop.ToString(), arialFont, Brushes.Black, Location);
                Location.Offset(19, 0);
                flagGraphics.FillRectangle(Brushes.White, Location.X, Location.Y, 9, 13);//do area fill on selected corner
                flagGraphics.DrawString(food.ToString(), arialFont, Brushes.Black, Location);
                Location.Offset(19, 0);
                flagGraphics.FillRectangle(Brushes.White, Location.X, Location.Y, 9, 13);//do area fill on selected corner
                flagGraphics.DrawString(mineral.ToString(), arialFont, Brushes.Black, Location);
                Location.Offset(19, 0);
                flagGraphics.FillRectangle(Brushes.White, Location.X, Location.Y, 9, 13);//do area fill on selected corner
                flagGraphics.DrawString(money.ToString(), arialFont, Brushes.Black, Location);
            }

            pbCard.Image = editedImg;//save the edited graphic to the picturebox image
        }

        public void WriteCombatValues(int attack, int defense)
        {
            Point Location = new Point(180, 306);

            Bitmap editedImg = new Bitmap(pbCard.Image);//get a new bitmap image based on the picturebox image
            Graphics flagGraphics = Graphics.FromImage(editedImg);//create a new graphic to edit based on the bitmap

            using (Font arialFont = new Font("Arial", 10))
            {
                flagGraphics.FillRectangle(Brushes.White, Location.X, Location.Y, 9, 13);//do area fill on selected corner
                flagGraphics.DrawString(attack.ToString(), arialFont, Brushes.Black, Location);
                Location.Offset(20, 0);
                flagGraphics.FillRectangle(Brushes.White, Location.X, Location.Y, 9, 13);//do area fill on selected corner
                flagGraphics.DrawString(defense.ToString(), arialFont, Brushes.Black, Location);
            }

            pbCard.Image = editedImg;//save the edited graphic to the picturebox image
        }

        public void SaveImage(string imageName)
        {
            pbCard.Image.Save(imageName + ".jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);
            MessageBox.Show("Image saved!");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtFileName.Text != "")
                SaveImage(txtFileName.Text);
            else
                MessageBox.Show("File Name Required.");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtFileName.Text = "";
            rtbDescription.Text = "";
            tbName.Text = "";
            foreach (NumericUpDown nud in Controls.OfType<NumericUpDown>())
                nud.Value = 0;
            foreach (ComboBox cb in Controls.OfType<ComboBox>())
                cb.SelectedIndex = 0;
            pbCard.Image = System.Drawing.Image.FromFile(Environment.CurrentDirectory + @"\CardTemplate.png");
        }

        private void UpdateConnections(object sender, EventArgs e)
        {
            ComboBox selected = (ComboBox)sender;
            Brush color = Brushes.Red;
            corners c1 = corners.TL;

            if (selected.SelectedIndex == 0)
                color = Brushes.Red;
            else if (selected.SelectedIndex == 1)
                color = Brushes.Blue;
            else if (selected.SelectedIndex == 2)
                color = Brushes.Green;
            else if (selected.SelectedIndex == 3)
                color = Brushes.Yellow;

            if (selected == cbTopLeft)
                c1 = corners.TL;
            else if (selected == cbTopRight)
                c1 = corners.TR;
            else if (selected == cbBottomLeft)
                c1 = corners.BL;
            else if (selected == cbBottomRight)
                c1 = corners.BR;

            ColorImageCorner(color, c1);
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            WriteName(tbName.Text);
        }

        private void rtbDescription_TextChanged(object sender, EventArgs e)
        {
            WriteDescription(rtbDescription.Text);
        }

        private void UpdateCosts(object sender, EventArgs e)
        {
            WriteCosts((int)nudFood.Value, (int)nudLumber.Value, (int)nudMetal.Value, (int)nudMagic.Value);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "All Files (*.*)|*.*";
            choofdlog.FilterIndex = 1;
            choofdlog.Multiselect = false;

            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                string sFileName = choofdlog.FileName;
                pbCard.Image = System.Drawing.Image.FromFile(sFileName);
            }
            
        }

        private void UpdateCombatValues(object sender, EventArgs e)
        {
            WriteCombatValues((int)nudAttack.Value, (int)nudDefense.Value);
        }

        private void txtCardType_TextChanged(object sender, EventArgs e)
        {
            WriteCardType(txtCardType.Text);
        }
    }
}
