namespace BlackJack
{
    partial class BlackJackForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BlackJackForm));
			this.clearBetButton = new System.Windows.Forms.Button();
			this.myBetLabel = new System.Windows.Forms.Label();
			this.myAccountLabel = new System.Windows.Forms.Label();
			this.myBetTextBox = new System.Windows.Forms.TextBox();
			this.hundredButton = new System.Windows.Forms.Button();
			this.fiftyButton = new System.Windows.Forms.Button();
			this.twentyFiveButton = new System.Windows.Forms.Button();
			this.tenButton = new System.Windows.Forms.Button();
			this.myAccountTextBox = new System.Windows.Forms.TextBox();
			this.deckCard3PictureBox = new System.Windows.Forms.PictureBox();
			this.deckCard2PictureBox = new System.Windows.Forms.PictureBox();
			this.deckCard1PictureBox = new System.Windows.Forms.PictureBox();
			this.gameOverTextBox = new System.Windows.Forms.TextBox();
			this.dealerCard6PictureBox = new System.Windows.Forms.PictureBox();
			this.dealerCard5PictureBox = new System.Windows.Forms.PictureBox();
			this.dealerCard4PictureBox = new System.Windows.Forms.PictureBox();
			this.dealerCard3PictureBox = new System.Windows.Forms.PictureBox();
			this.dealerCard2PictureBox = new System.Windows.Forms.PictureBox();
			this.dealerCard1PictureBox = new System.Windows.Forms.PictureBox();
			this.tiesTextBox = new System.Windows.Forms.TextBox();
			this.tiesLabel = new System.Windows.Forms.Label();
			this.lossTextBox = new System.Windows.Forms.TextBox();
			this.lossesLabel = new System.Windows.Forms.Label();
			this.winsLabel = new System.Windows.Forms.Label();
			this.winTextBox = new System.Windows.Forms.TextBox();
			this.endGameButton = new System.Windows.Forms.Button();
			this.standButton = new System.Windows.Forms.Button();
			this.dealButton = new System.Windows.Forms.Button();
			this.hitButton = new System.Windows.Forms.Button();
			this.playerCard1 = new System.Windows.Forms.PictureBox();
			this.playerCard2 = new System.Windows.Forms.PictureBox();
			this.playerCard3 = new System.Windows.Forms.PictureBox();
			this.playerCard4 = new System.Windows.Forms.PictureBox();
			this.playerCard5 = new System.Windows.Forms.PictureBox();
			this.playerCard6 = new System.Windows.Forms.PictureBox();
			this.playerTotalLabel = new System.Windows.Forms.Label();
			this.framePictureBox = new System.Windows.Forms.PictureBox();
			this.doubleDownButton = new System.Windows.Forms.Button();
			this.recordPanel = new System.Windows.Forms.Panel();
			this.betPanel = new System.Windows.Forms.Panel();
			this.playerNameLabel = new System.Windows.Forms.Label();
			this.photoPictureBox = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.deckCard3PictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.deckCard2PictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.deckCard1PictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dealerCard6PictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dealerCard5PictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dealerCard4PictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dealerCard3PictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dealerCard2PictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dealerCard1PictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.playerCard1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.playerCard2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.playerCard3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.playerCard4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.playerCard5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.playerCard6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.framePictureBox)).BeginInit();
			this.recordPanel.SuspendLayout();
			this.betPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// clearBetButton
			// 
			this.clearBetButton.BackColor = System.Drawing.Color.Transparent;
			this.clearBetButton.BackgroundImage = global::BlackJack.Properties.Resources.ButtonSquare;
			this.clearBetButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.clearBetButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.clearBetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.clearBetButton.Location = new System.Drawing.Point(456, 15);
			this.clearBetButton.Name = "clearBetButton";
			this.clearBetButton.Size = new System.Drawing.Size(81, 30);
			this.clearBetButton.TabIndex = 10;
			this.clearBetButton.Text = "Clear";
			this.clearBetButton.UseVisualStyleBackColor = false;
			this.clearBetButton.Click += new System.EventHandler(this.ClearBetBtn_Click);
			// 
			// myBetLabel
			// 
			this.myBetLabel.AutoSize = true;
			this.myBetLabel.BackColor = System.Drawing.Color.Transparent;
			this.myBetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.myBetLabel.ForeColor = System.Drawing.Color.Gold;
			this.myBetLabel.Location = new System.Drawing.Point(360, 38);
			this.myBetLabel.Name = "myBetLabel";
			this.myBetLabel.Size = new System.Drawing.Size(64, 20);
			this.myBetLabel.TabIndex = 7;
			this.myBetLabel.Text = "My Bet";
			// 
			// myAccountLabel
			// 
			this.myAccountLabel.AutoSize = true;
			this.myAccountLabel.BackColor = System.Drawing.Color.Transparent;
			this.myAccountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.myAccountLabel.ForeColor = System.Drawing.Color.Gold;
			this.myAccountLabel.Location = new System.Drawing.Point(130, 10);
			this.myAccountLabel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
			this.myAccountLabel.Name = "myAccountLabel";
			this.myAccountLabel.Size = new System.Drawing.Size(102, 20);
			this.myAccountLabel.TabIndex = 6;
			this.myAccountLabel.Text = "My Account";
			// 
			// myBetTextBox
			// 
			this.myBetTextBox.BackColor = System.Drawing.SystemColors.InfoText;
			this.myBetTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.myBetTextBox.ForeColor = System.Drawing.Color.Orange;
			this.myBetTextBox.Location = new System.Drawing.Point(358, 12);
			this.myBetTextBox.Multiline = true;
			this.myBetTextBox.Name = "myBetTextBox";
			this.myBetTextBox.ReadOnly = true;
			this.myBetTextBox.Size = new System.Drawing.Size(64, 25);
			this.myBetTextBox.TabIndex = 9;
			this.myBetTextBox.Text = "0";
			this.myBetTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// hundredButton
			// 
			this.hundredButton.BackColor = System.Drawing.Color.Transparent;
			this.hundredButton.BackgroundImage = global::BlackJack.Properties.Resources.coin4;
			this.hundredButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.hundredButton.FlatAppearance.BorderSize = 0;
			this.hundredButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.hundredButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.hundredButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.hundredButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.hundredButton.Location = new System.Drawing.Point(261, -1);
			this.hundredButton.Margin = new System.Windows.Forms.Padding(0);
			this.hundredButton.Name = "hundredButton";
			this.hundredButton.Size = new System.Drawing.Size(61, 63);
			this.hundredButton.TabIndex = 8;
			this.hundredButton.Text = "100";
			this.hundredButton.UseVisualStyleBackColor = false;
			this.hundredButton.Click += new System.EventHandler(this.HundredBtn_Click);
			// 
			// fiftyButton
			// 
			this.fiftyButton.BackColor = System.Drawing.Color.Transparent;
			this.fiftyButton.BackgroundImage = global::BlackJack.Properties.Resources.coin3;
			this.fiftyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.fiftyButton.FlatAppearance.BorderSize = 0;
			this.fiftyButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.fiftyButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.fiftyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.fiftyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fiftyButton.Location = new System.Drawing.Point(186, -1);
			this.fiftyButton.Margin = new System.Windows.Forms.Padding(0);
			this.fiftyButton.Name = "fiftyButton";
			this.fiftyButton.Size = new System.Drawing.Size(60, 62);
			this.fiftyButton.TabIndex = 7;
			this.fiftyButton.Text = "50";
			this.fiftyButton.UseVisualStyleBackColor = false;
			this.fiftyButton.Click += new System.EventHandler(this.FiftyBtn_Click);
			// 
			// twentyFiveButton
			// 
			this.twentyFiveButton.BackColor = System.Drawing.Color.Transparent;
			this.twentyFiveButton.BackgroundImage = global::BlackJack.Properties.Resources.coin2;
			this.twentyFiveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.twentyFiveButton.FlatAppearance.BorderSize = 0;
			this.twentyFiveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.twentyFiveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.twentyFiveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.twentyFiveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.twentyFiveButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.twentyFiveButton.Location = new System.Drawing.Point(109, -1);
			this.twentyFiveButton.Margin = new System.Windows.Forms.Padding(0);
			this.twentyFiveButton.Name = "twentyFiveButton";
			this.twentyFiveButton.Size = new System.Drawing.Size(60, 62);
			this.twentyFiveButton.TabIndex = 6;
			this.twentyFiveButton.Text = "25";
			this.twentyFiveButton.UseVisualStyleBackColor = false;
			this.twentyFiveButton.Click += new System.EventHandler(this.TwentyFiveBtn_Click);
			// 
			// tenButton
			// 
			this.tenButton.BackColor = System.Drawing.Color.Transparent;
			this.tenButton.BackgroundImage = global::BlackJack.Properties.Resources.coin1;
			this.tenButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.tenButton.FlatAppearance.BorderSize = 0;
			this.tenButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.tenButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.tenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.tenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tenButton.Location = new System.Drawing.Point(31, -1);
			this.tenButton.Margin = new System.Windows.Forms.Padding(0);
			this.tenButton.Name = "tenButton";
			this.tenButton.Size = new System.Drawing.Size(60, 62);
			this.tenButton.TabIndex = 5;
			this.tenButton.Tag = "10";
			this.tenButton.Text = "10";
			this.tenButton.UseVisualStyleBackColor = false;
			this.tenButton.Click += new System.EventHandler(this.TenBtn_Click);
			// 
			// myAccountTextBox
			// 
			this.myAccountTextBox.BackColor = System.Drawing.SystemColors.InfoText;
			this.myAccountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.myAccountTextBox.ForeColor = System.Drawing.Color.Orange;
			this.myAccountTextBox.Location = new System.Drawing.Point(138, 34);
			this.myAccountTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 3);
			this.myAccountTextBox.Multiline = true;
			this.myAccountTextBox.Name = "myAccountTextBox";
			this.myAccountTextBox.ReadOnly = true;
			this.myAccountTextBox.Size = new System.Drawing.Size(82, 28);
			this.myAccountTextBox.TabIndex = 1;
			this.myAccountTextBox.Text = "2000";
			this.myAccountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// deckCard3PictureBox
			// 
			this.deckCard3PictureBox.BackColor = System.Drawing.Color.Transparent;
			this.deckCard3PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.deckCard3PictureBox.Location = new System.Drawing.Point(440, 113);
			this.deckCard3PictureBox.Name = "deckCard3PictureBox";
			this.deckCard3PictureBox.Size = new System.Drawing.Size(80, 101);
			this.deckCard3PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.deckCard3PictureBox.TabIndex = 8;
			this.deckCard3PictureBox.TabStop = false;
			// 
			// deckCard2PictureBox
			// 
			this.deckCard2PictureBox.BackColor = System.Drawing.Color.Transparent;
			this.deckCard2PictureBox.Location = new System.Drawing.Point(430, 124);
			this.deckCard2PictureBox.Name = "deckCard2PictureBox";
			this.deckCard2PictureBox.Size = new System.Drawing.Size(81, 100);
			this.deckCard2PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.deckCard2PictureBox.TabIndex = 7;
			this.deckCard2PictureBox.TabStop = false;
			// 
			// deckCard1PictureBox
			// 
			this.deckCard1PictureBox.BackColor = System.Drawing.Color.Transparent;
			this.deckCard1PictureBox.Location = new System.Drawing.Point(421, 133);
			this.deckCard1PictureBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
			this.deckCard1PictureBox.Name = "deckCard1PictureBox";
			this.deckCard1PictureBox.Size = new System.Drawing.Size(80, 100);
			this.deckCard1PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.deckCard1PictureBox.TabIndex = 6;
			this.deckCard1PictureBox.TabStop = false;
			// 
			// gameOverTextBox
			// 
			this.gameOverTextBox.BackColor = System.Drawing.Color.Black;
			this.gameOverTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gameOverTextBox.ForeColor = System.Drawing.SystemColors.Window;
			this.gameOverTextBox.Location = new System.Drawing.Point(478, 501);
			this.gameOverTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 3);
			this.gameOverTextBox.Multiline = true;
			this.gameOverTextBox.Name = "gameOverTextBox";
			this.gameOverTextBox.ReadOnly = true;
			this.gameOverTextBox.Size = new System.Drawing.Size(223, 30);
			this.gameOverTextBox.TabIndex = 5;
			this.gameOverTextBox.Text = "Dealer Won";
			this.gameOverTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// dealerCard6PictureBox
			// 
			this.dealerCard6PictureBox.BackColor = System.Drawing.Color.Transparent;
			this.dealerCard6PictureBox.Location = new System.Drawing.Point(307, 119);
			this.dealerCard6PictureBox.Margin = new System.Windows.Forms.Padding(1, 1, 3, 3);
			this.dealerCard6PictureBox.Name = "dealerCard6PictureBox";
			this.dealerCard6PictureBox.Size = new System.Drawing.Size(75, 95);
			this.dealerCard6PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.dealerCard6PictureBox.TabIndex = 14;
			this.dealerCard6PictureBox.TabStop = false;
			this.dealerCard6PictureBox.Visible = false;
			// 
			// dealerCard5PictureBox
			// 
			this.dealerCard5PictureBox.BackColor = System.Drawing.Color.Transparent;
			this.dealerCard5PictureBox.Location = new System.Drawing.Point(286, 119);
			this.dealerCard5PictureBox.Name = "dealerCard5PictureBox";
			this.dealerCard5PictureBox.Size = new System.Drawing.Size(75, 95);
			this.dealerCard5PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.dealerCard5PictureBox.TabIndex = 13;
			this.dealerCard5PictureBox.TabStop = false;
			this.dealerCard5PictureBox.Visible = false;
			// 
			// dealerCard4PictureBox
			// 
			this.dealerCard4PictureBox.BackColor = System.Drawing.Color.Transparent;
			this.dealerCard4PictureBox.Location = new System.Drawing.Point(267, 119);
			this.dealerCard4PictureBox.Margin = new System.Windows.Forms.Padding(3, 3, 1, 3);
			this.dealerCard4PictureBox.Name = "dealerCard4PictureBox";
			this.dealerCard4PictureBox.Size = new System.Drawing.Size(75, 95);
			this.dealerCard4PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.dealerCard4PictureBox.TabIndex = 12;
			this.dealerCard4PictureBox.TabStop = false;
			this.dealerCard4PictureBox.Visible = false;
			// 
			// dealerCard3PictureBox
			// 
			this.dealerCard3PictureBox.BackColor = System.Drawing.Color.Transparent;
			this.dealerCard3PictureBox.Location = new System.Drawing.Point(247, 119);
			this.dealerCard3PictureBox.Name = "dealerCard3PictureBox";
			this.dealerCard3PictureBox.Size = new System.Drawing.Size(75, 95);
			this.dealerCard3PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.dealerCard3PictureBox.TabIndex = 11;
			this.dealerCard3PictureBox.TabStop = false;
			this.dealerCard3PictureBox.Visible = false;
			// 
			// dealerCard2PictureBox
			// 
			this.dealerCard2PictureBox.BackColor = System.Drawing.Color.Transparent;
			this.dealerCard2PictureBox.Location = new System.Drawing.Point(230, 119);
			this.dealerCard2PictureBox.Name = "dealerCard2PictureBox";
			this.dealerCard2PictureBox.Size = new System.Drawing.Size(75, 95);
			this.dealerCard2PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.dealerCard2PictureBox.TabIndex = 10;
			this.dealerCard2PictureBox.TabStop = false;
			this.dealerCard2PictureBox.Visible = false;
			// 
			// dealerCard1PictureBox
			// 
			this.dealerCard1PictureBox.BackColor = System.Drawing.Color.Transparent;
			this.dealerCard1PictureBox.Location = new System.Drawing.Point(212, 119);
			this.dealerCard1PictureBox.Name = "dealerCard1PictureBox";
			this.dealerCard1PictureBox.Size = new System.Drawing.Size(75, 95);
			this.dealerCard1PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.dealerCard1PictureBox.TabIndex = 9;
			this.dealerCard1PictureBox.TabStop = false;
			this.dealerCard1PictureBox.Visible = false;
			// 
			// tiesTextBox
			// 
			this.tiesTextBox.BackColor = System.Drawing.SystemColors.InfoText;
			this.tiesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tiesTextBox.ForeColor = System.Drawing.Color.DarkOrange;
			this.tiesTextBox.Location = new System.Drawing.Point(529, 33);
			this.tiesTextBox.Multiline = true;
			this.tiesTextBox.Name = "tiesTextBox";
			this.tiesTextBox.ReadOnly = true;
			this.tiesTextBox.Size = new System.Drawing.Size(32, 28);
			this.tiesTextBox.TabIndex = 4;
			this.tiesTextBox.Text = "0";
			this.tiesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// tiesLabel
			// 
			this.tiesLabel.AutoSize = true;
			this.tiesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tiesLabel.ForeColor = System.Drawing.Color.Gold;
			this.tiesLabel.Location = new System.Drawing.Point(526, 10);
			this.tiesLabel.Name = "tiesLabel";
			this.tiesLabel.Size = new System.Drawing.Size(42, 20);
			this.tiesLabel.TabIndex = 4;
			this.tiesLabel.Text = "Ties";
			// 
			// lossTextBox
			// 
			this.lossTextBox.BackColor = System.Drawing.SystemColors.InfoText;
			this.lossTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lossTextBox.ForeColor = System.Drawing.Color.DarkOrange;
			this.lossTextBox.Location = new System.Drawing.Point(420, 33);
			this.lossTextBox.Multiline = true;
			this.lossTextBox.Name = "lossTextBox";
			this.lossTextBox.ReadOnly = true;
			this.lossTextBox.Size = new System.Drawing.Size(32, 28);
			this.lossTextBox.TabIndex = 3;
			this.lossTextBox.Text = "0";
			this.lossTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// lossesLabel
			// 
			this.lossesLabel.AutoSize = true;
			this.lossesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lossesLabel.ForeColor = System.Drawing.Color.Gold;
			this.lossesLabel.Location = new System.Drawing.Point(408, 10);
			this.lossesLabel.Name = "lossesLabel";
			this.lossesLabel.Size = new System.Drawing.Size(66, 20);
			this.lossesLabel.TabIndex = 2;
			this.lossesLabel.Text = "Losses";
			// 
			// winsLabel
			// 
			this.winsLabel.AutoSize = true;
			this.winsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.winsLabel.ForeColor = System.Drawing.Color.Gold;
			this.winsLabel.Location = new System.Drawing.Point(295, 10);
			this.winsLabel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
			this.winsLabel.Name = "winsLabel";
			this.winsLabel.Size = new System.Drawing.Size(48, 20);
			this.winsLabel.TabIndex = 1;
			this.winsLabel.Text = "Wins";
			// 
			// winTextBox
			// 
			this.winTextBox.BackColor = System.Drawing.SystemColors.InfoText;
			this.winTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.winTextBox.ForeColor = System.Drawing.Color.DarkOrange;
			this.winTextBox.Location = new System.Drawing.Point(302, 34);
			this.winTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 3);
			this.winTextBox.Multiline = true;
			this.winTextBox.Name = "winTextBox";
			this.winTextBox.ReadOnly = true;
			this.winTextBox.Size = new System.Drawing.Size(32, 28);
			this.winTextBox.TabIndex = 2;
			this.winTextBox.Text = "0";
			this.winTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// endGameButton
			// 
			this.endGameButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.endGameButton.BackColor = System.Drawing.Color.Transparent;
			this.endGameButton.BackgroundImage = global::BlackJack.Properties.Resources.ButtonRound;
			this.endGameButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.endGameButton.FlatAppearance.BorderSize = 0;
			this.endGameButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.endGameButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.endGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.endGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.endGameButton.Location = new System.Drawing.Point(589, 654);
			this.endGameButton.Name = "endGameButton";
			this.endGameButton.Size = new System.Drawing.Size(112, 39);
			this.endGameButton.TabIndex = 15;
			this.endGameButton.Text = "End Game";
			this.endGameButton.UseVisualStyleBackColor = false;
			this.endGameButton.Click += new System.EventHandler(this.ExitBtn_Click);
			// 
			// standButton
			// 
			this.standButton.BackColor = System.Drawing.Color.Transparent;
			this.standButton.BackgroundImage = global::BlackJack.Properties.Resources.ButtonRound;
			this.standButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.standButton.FlatAppearance.BorderSize = 0;
			this.standButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.standButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.standButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.standButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.standButton.ForeColor = System.Drawing.Color.Black;
			this.standButton.Location = new System.Drawing.Point(317, 655);
			this.standButton.Name = "standButton";
			this.standButton.Size = new System.Drawing.Size(112, 39);
			this.standButton.TabIndex = 13;
			this.standButton.Text = "Stand";
			this.standButton.UseVisualStyleBackColor = false;
			this.standButton.Click += new System.EventHandler(this.StandBtn_Click);
			// 
			// dealButton
			// 
			this.dealButton.AutoSize = true;
			this.dealButton.BackColor = System.Drawing.Color.Transparent;
			this.dealButton.BackgroundImage = global::BlackJack.Properties.Resources.ButtonRound;
			this.dealButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.dealButton.FlatAppearance.BorderSize = 0;
			this.dealButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.dealButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.dealButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.dealButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dealButton.ForeColor = System.Drawing.SystemColors.ControlText;
			this.dealButton.Location = new System.Drawing.Point(452, 655);
			this.dealButton.Name = "dealButton";
			this.dealButton.Size = new System.Drawing.Size(112, 39);
			this.dealButton.TabIndex = 14;
			this.dealButton.Text = "Deal";
			this.dealButton.UseVisualStyleBackColor = false;
			this.dealButton.Click += new System.EventHandler(this.DealBtn_Click);
			// 
			// hitButton
			// 
			this.hitButton.BackColor = System.Drawing.Color.Transparent;
			this.hitButton.BackgroundImage = global::BlackJack.Properties.Resources.ButtonRound;
			this.hitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.hitButton.FlatAppearance.BorderSize = 0;
			this.hitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.hitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.hitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.hitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.hitButton.ForeColor = System.Drawing.SystemColors.ControlText;
			this.hitButton.Location = new System.Drawing.Point(178, 655);
			this.hitButton.Margin = new System.Windows.Forms.Padding(0);
			this.hitButton.Name = "hitButton";
			this.hitButton.Size = new System.Drawing.Size(112, 39);
			this.hitButton.TabIndex = 12;
			this.hitButton.Text = "Hit";
			this.hitButton.UseVisualStyleBackColor = false;
			this.hitButton.Click += new System.EventHandler(this.HitBtn_Click);
			// 
			// playerCard1
			// 
			this.playerCard1.BackColor = System.Drawing.Color.Transparent;
			this.playerCard1.Location = new System.Drawing.Point(261, 238);
			this.playerCard1.Name = "playerCard1";
			this.playerCard1.Size = new System.Drawing.Size(75, 95);
			this.playerCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.playerCard1.TabIndex = 0;
			this.playerCard1.TabStop = false;
			this.playerCard1.Visible = false;
			// 
			// playerCard2
			// 
			this.playerCard2.BackColor = System.Drawing.Color.Transparent;
			this.playerCard2.Location = new System.Drawing.Point(281, 238);
			this.playerCard2.Name = "playerCard2";
			this.playerCard2.Size = new System.Drawing.Size(75, 95);
			this.playerCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.playerCard2.TabIndex = 1;
			this.playerCard2.TabStop = false;
			this.playerCard2.Visible = false;
			// 
			// playerCard3
			// 
			this.playerCard3.BackColor = System.Drawing.Color.Transparent;
			this.playerCard3.Location = new System.Drawing.Point(301, 238);
			this.playerCard3.Name = "playerCard3";
			this.playerCard3.Size = new System.Drawing.Size(75, 95);
			this.playerCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.playerCard3.TabIndex = 2;
			this.playerCard3.TabStop = false;
			this.playerCard3.Visible = false;
			// 
			// playerCard4
			// 
			this.playerCard4.BackColor = System.Drawing.Color.Transparent;
			this.playerCard4.Location = new System.Drawing.Point(322, 238);
			this.playerCard4.Name = "playerCard4";
			this.playerCard4.Size = new System.Drawing.Size(75, 95);
			this.playerCard4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.playerCard4.TabIndex = 3;
			this.playerCard4.TabStop = false;
			this.playerCard4.Visible = false;
			// 
			// playerCard5
			// 
			this.playerCard5.BackColor = System.Drawing.Color.Transparent;
			this.playerCard5.Location = new System.Drawing.Point(340, 239);
			this.playerCard5.Name = "playerCard5";
			this.playerCard5.Size = new System.Drawing.Size(75, 95);
			this.playerCard5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.playerCard5.TabIndex = 4;
			this.playerCard5.TabStop = false;
			this.playerCard5.Visible = false;
			// 
			// playerCard6
			// 
			this.playerCard6.BackColor = System.Drawing.Color.Transparent;
			this.playerCard6.Location = new System.Drawing.Point(359, 239);
			this.playerCard6.Name = "playerCard6";
			this.playerCard6.Size = new System.Drawing.Size(75, 95);
			this.playerCard6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.playerCard6.TabIndex = 5;
			this.playerCard6.TabStop = false;
			this.playerCard6.Visible = false;
			// 
			// playerTotalLabel
			// 
			this.playerTotalLabel.AutoSize = true;
			this.playerTotalLabel.Location = new System.Drawing.Point(243, 238);
			this.playerTotalLabel.Name = "playerTotalLabel";
			this.playerTotalLabel.Size = new System.Drawing.Size(13, 13);
			this.playerTotalLabel.TabIndex = 6;
			this.playerTotalLabel.Text = "0";
			// 
			// framePictureBox
			// 
			this.framePictureBox.BackColor = System.Drawing.Color.Transparent;
			this.framePictureBox.BackgroundImage = global::BlackJack.Properties.Resources.FrameOrange;
			this.framePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.framePictureBox.Location = new System.Drawing.Point(278, 390);
			this.framePictureBox.Name = "framePictureBox";
			this.framePictureBox.Size = new System.Drawing.Size(138, 143);
			this.framePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.framePictureBox.TabIndex = 16;
			this.framePictureBox.TabStop = false;
			// 
			// doubleDownButton
			// 
			this.doubleDownButton.BackColor = System.Drawing.Color.Transparent;
			this.doubleDownButton.BackgroundImage = global::BlackJack.Properties.Resources.ButtonRound;
			this.doubleDownButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.doubleDownButton.FlatAppearance.BorderSize = 0;
			this.doubleDownButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.doubleDownButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.doubleDownButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.doubleDownButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.doubleDownButton.ForeColor = System.Drawing.SystemColors.ControlText;
			this.doubleDownButton.Location = new System.Drawing.Point(33, 655);
			this.doubleDownButton.Margin = new System.Windows.Forms.Padding(0);
			this.doubleDownButton.Name = "doubleDownButton";
			this.doubleDownButton.Size = new System.Drawing.Size(123, 38);
			this.doubleDownButton.TabIndex = 11;
			this.doubleDownButton.Text = "Double Down";
			this.doubleDownButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
			this.doubleDownButton.UseVisualStyleBackColor = false;
			this.doubleDownButton.Visible = false;
			this.doubleDownButton.Click += new System.EventHandler(this.DblDwnBtn_Click);
			// 
			// recordPanel
			// 
			this.recordPanel.BackColor = System.Drawing.Color.Transparent;
			this.recordPanel.BackgroundImage = global::BlackJack.Properties.Resources.BorderPlaceYourBetTop;
			this.recordPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.recordPanel.Controls.Add(this.lossesLabel);
			this.recordPanel.Controls.Add(this.tiesLabel);
			this.recordPanel.Controls.Add(this.winsLabel);
			this.recordPanel.Controls.Add(this.winTextBox);
			this.recordPanel.Controls.Add(this.tiesTextBox);
			this.recordPanel.Controls.Add(this.lossTextBox);
			this.recordPanel.Controls.Add(this.myAccountLabel);
			this.recordPanel.Controls.Add(this.myAccountTextBox);
			this.recordPanel.Location = new System.Drawing.Point(5, 24);
			this.recordPanel.Name = "recordPanel";
			this.recordPanel.Size = new System.Drawing.Size(705, 72);
			this.recordPanel.TabIndex = 24;
			// 
			// betPanel
			// 
			this.betPanel.BackColor = System.Drawing.Color.Transparent;
			this.betPanel.BackgroundImage = global::BlackJack.Properties.Resources.BorderPlaceYourBetBottom;
			this.betPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.betPanel.Controls.Add(this.twentyFiveButton);
			this.betPanel.Controls.Add(this.clearBetButton);
			this.betPanel.Controls.Add(this.fiftyButton);
			this.betPanel.Controls.Add(this.myBetTextBox);
			this.betPanel.Controls.Add(this.myBetLabel);
			this.betPanel.Controls.Add(this.hundredButton);
			this.betPanel.Controls.Add(this.tenButton);
			this.betPanel.Location = new System.Drawing.Point(79, 574);
			this.betPanel.Name = "betPanel";
			this.betPanel.Size = new System.Drawing.Size(567, 68);
			this.betPanel.TabIndex = 25;
			// 
			// playerNameLabel
			// 
			this.playerNameLabel.BackColor = System.Drawing.Color.Transparent;
			this.playerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.playerNameLabel.ForeColor = System.Drawing.SystemColors.Control;
			this.playerNameLabel.Location = new System.Drawing.Point(277, 540);
			this.playerNameLabel.Name = "playerNameLabel";
			this.playerNameLabel.Size = new System.Drawing.Size(100, 23);
			this.playerNameLabel.TabIndex = 26;
			this.playerNameLabel.Text = "Player 1";
			// 
			// photoPictureBox
			// 
			this.photoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.photoPictureBox.ImageLocation = "";
			this.photoPictureBox.Location = new System.Drawing.Point(293, 407);
			this.photoPictureBox.Name = "photoPictureBox";
			this.photoPictureBox.Size = new System.Drawing.Size(109, 110);
			this.photoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.photoPictureBox.TabIndex = 17;
			this.photoPictureBox.TabStop = false;
			// 
			// BlackJackForm
			// 
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackgroundImage = global::BlackJack.Properties.Resources.Background;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(734, 706);
			this.Controls.Add(this.betPanel);
			this.Controls.Add(this.recordPanel);
			this.Controls.Add(this.playerNameLabel);
			this.Controls.Add(this.playerCard6);
			this.Controls.Add(this.playerCard5);
			this.Controls.Add(this.dealerCard6PictureBox);
			this.Controls.Add(this.dealerCard5PictureBox);
			this.Controls.Add(this.gameOverTextBox);
			this.Controls.Add(this.dealerCard4PictureBox);
			this.Controls.Add(this.dealerCard3PictureBox);
			this.Controls.Add(this.photoPictureBox);
			this.Controls.Add(this.framePictureBox);
			this.Controls.Add(this.endGameButton);
			this.Controls.Add(this.playerTotalLabel);
			this.Controls.Add(this.dealButton);
			this.Controls.Add(this.standButton);
			this.Controls.Add(this.hitButton);
			this.Controls.Add(this.doubleDownButton);
			this.Controls.Add(this.playerCard4);
			this.Controls.Add(this.playerCard3);
			this.Controls.Add(this.playerCard2);
			this.Controls.Add(this.playerCard1);
			this.Controls.Add(this.deckCard3PictureBox);
			this.Controls.Add(this.deckCard2PictureBox);
			this.Controls.Add(this.deckCard1PictureBox);
			this.Controls.Add(this.dealerCard2PictureBox);
			this.Controls.Add(this.dealerCard1PictureBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "BlackJackForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "BlackJack Casino";
			((System.ComponentModel.ISupportInitialize)(this.deckCard3PictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.deckCard2PictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.deckCard1PictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dealerCard6PictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dealerCard5PictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dealerCard4PictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dealerCard3PictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dealerCard2PictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dealerCard1PictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.playerCard1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.playerCard2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.playerCard3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.playerCard4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.playerCard5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.playerCard6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.framePictureBox)).EndInit();
			this.recordPanel.ResumeLayout(false);
			this.recordPanel.PerformLayout();
			this.betPanel.ResumeLayout(false);
			this.betPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.TextBox myAccountTextBox;
        private System.Windows.Forms.Button tenButton;
        private System.Windows.Forms.Button twentyFiveButton;
        private System.Windows.Forms.Button fiftyButton;
        private System.Windows.Forms.Button hundredButton;
        private System.Windows.Forms.TextBox winTextBox;
        private System.Windows.Forms.TextBox myBetTextBox;
        private System.Windows.Forms.Button hitButton;
        private System.Windows.Forms.Button dealButton;
        private System.Windows.Forms.Button standButton;
        private System.Windows.Forms.Label myAccountLabel;
        private System.Windows.Forms.Label myBetLabel;
        private System.Windows.Forms.TextBox gameOverTextBox;
        private System.Windows.Forms.Label winsLabel;
        private System.Windows.Forms.Label lossesLabel;
        private System.Windows.Forms.TextBox lossTextBox;
        private System.Windows.Forms.Label tiesLabel;
        private System.Windows.Forms.TextBox tiesTextBox;
        private System.Windows.Forms.PictureBox deckCard1PictureBox;
        private System.Windows.Forms.PictureBox deckCard2PictureBox;
		private System.Windows.Forms.PictureBox deckCard3PictureBox;
        private System.Windows.Forms.PictureBox dealerCard6PictureBox;
        private System.Windows.Forms.PictureBox dealerCard5PictureBox;
        private System.Windows.Forms.PictureBox dealerCard4PictureBox;
        private System.Windows.Forms.PictureBox dealerCard3PictureBox;
        private System.Windows.Forms.PictureBox dealerCard2PictureBox;
        private System.Windows.Forms.PictureBox dealerCard1PictureBox;
        private System.Windows.Forms.Button clearBetButton;
        private System.Windows.Forms.Button endGameButton;
        private System.Windows.Forms.PictureBox playerCard1;
        private System.Windows.Forms.PictureBox playerCard2;
        private System.Windows.Forms.PictureBox playerCard3;
        private System.Windows.Forms.PictureBox playerCard4;
        private System.Windows.Forms.PictureBox playerCard5;
        private System.Windows.Forms.PictureBox playerCard6;
        private System.Windows.Forms.Label playerTotalLabel;
        private System.Windows.Forms.PictureBox framePictureBox;
        private System.Windows.Forms.Button doubleDownButton;
        private System.Windows.Forms.Panel recordPanel;
        private System.Windows.Forms.Panel betPanel;
        private System.Windows.Forms.Label playerNameLabel;
        private System.Windows.Forms.PictureBox photoPictureBox;
    }
}