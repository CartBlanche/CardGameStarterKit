using System;
using System.Windows.Forms;

namespace BlackJack
{
    partial class StartForm : Form
    {
        /// <summary>
        /// Main constructor for StartForm
        /// </summary>
        public StartForm()
        {
            InitializeComponent();
		}
		
        /// <summary>
        /// Invokes a new BlackJack game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		private void NewGameBtn_Click(object sender, EventArgs e)
        {
            // Show the main BlackJack UI game
			using (BlackJackForm blackjackform = new BlackJackForm())
			{
				Hide();
				blackjackform.ShowDialog();
				Show();
			}
		}

        /// <summary>
        /// Brings up the options form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		private void OptionsBtn_Click(object sender, EventArgs e)
        {
            // Show the Options panel
			using (OptionsForm optionsForm = new OptionsForm())
			{
				Hide();
				optionsForm.ShowDialog();
				Show();
			}
		}

        /// <summary>
        /// Exits the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		private void ExitBtn_Click(object sender, EventArgs e)
        {
            // Exit the Game
            Application.Exit();
		}
	}
}