using System;
using System.Windows.Forms;
using System.Drawing;

namespace BlackJack
{
    partial class OptionsForm : Form
    {
        /// <summary>
        /// Main constructor for OptionsForm
        /// </summary>
        public OptionsForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Performs setup actions when the form loads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OptionsForm_Load(object sender, EventArgs e)
        {
            try
            {
                // Loads the player image from file and displays the image in the "preview" box
                playerPictureBox.Image = Image.FromFile(Properties.Settings.Default.PlayerImage);
                // Loads the path name for the other images
                string image1 = Properties.Settings.Default.DefaultImage1;
                string image2 = Properties.Settings.Default.DefaultImage2;
                string image3 = Properties.Settings.Default.DefaultImage3;
                string image4 = Properties.Settings.Default.DefaultImage4;

                // Loads each image and displays it in the image list
                defaultImageList.Images.Add(image1, Image.FromFile(image1));
                defaultImageListView.Items.Add(image1, image1);

                defaultImageList.Images.Add(image2, Image.FromFile(image2));
                defaultImageListView.Items.Add(image2, image2);

                defaultImageList.Images.Add(image3, Image.FromFile(image3));
                defaultImageListView.Items.Add(image3, image3);

                defaultImageList.Images.Add(image4, Image.FromFile(image4));
                defaultImageListView.Items.Add(image4, image4);

                defaultImageListView.Items[0].Text = "";
                defaultImageListView.Items[1].Text = "";
                defaultImageListView.Items[2].Text = "";
                defaultImageListView.Items[3].Text = "";
            }
            catch (OutOfMemoryException)
            {
                MessageBox.Show("Images did not load properly.  Verify that images are in the correct location");
            }
        }

        /// <summary>
        /// Invoked when a user selects an image in the scroll list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlayerDefaultImageList_ItemActivate(object sender, EventArgs e)
        {
            // Selects an image from the image scroll list
            ListView.SelectedListViewItemCollection items = defaultImageListView.SelectedItems;
            Properties.Settings.Default.PlayerImage = items[0].ImageKey;
            playerPictureBox.Image = Image.FromFile(Properties.Settings.Default.PlayerImage);
        }

        /// <summary>
        /// Cancels any changes made in the option form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reload();
            this.Close();
        }

        /// <summary>
        /// Saves current changes made in the options form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            // Saves the player name to the settings file
            Properties.Settings.Default.PlayerName = playerNameTextBox.Text;
            // Saves the values in the setting file to be used in the game
            Properties.Settings.Default.Save();
            this.Close();
        }
    }
}