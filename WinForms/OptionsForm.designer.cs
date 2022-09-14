namespace BlackJack
{
    partial class OptionsForm
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsForm));
			this.optionsLabel = new System.Windows.Forms.Label();
			this.playerNameTextBox = new System.Windows.Forms.TextBox();
			this.playerNameLabel = new System.Windows.Forms.Label();
			this.playerPictureBox = new System.Windows.Forms.PictureBox();
			this.playerPictureLabel = new System.Windows.Forms.Label();
			this.selectFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.defaultImageListView = new System.Windows.Forms.ListView();
			this.defaultImageList = new System.Windows.Forms.ImageList(this.components);
			this.okButton = new System.Windows.Forms.Button();
			this.cancelButton = new System.Windows.Forms.Button();
			this.previewLabel = new System.Windows.Forms.Label();
			this.iconPictureBox = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.playerPictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// optionsLabel
			// 
			this.optionsLabel.AutoSize = true;
			this.optionsLabel.BackColor = System.Drawing.Color.Transparent;
			this.optionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.optionsLabel.ForeColor = System.Drawing.Color.White;
			this.optionsLabel.Location = new System.Drawing.Point(24, 9);
			this.optionsLabel.Name = "optionsLabel";
			this.optionsLabel.Size = new System.Drawing.Size(322, 39);
			this.optionsLabel.TabIndex = 0;
			this.optionsLabel.Text = "BlackJack Options";
			// 
			// playerNameTextBox
			// 
			this.playerNameTextBox.BackColor = System.Drawing.Color.Silver;
			this.playerNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::BlackJack.Properties.Settings.Default, "PlayerName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.playerNameTextBox.Location = new System.Drawing.Point(221, 111);
			this.playerNameTextBox.Name = "playerNameTextBox";
			this.playerNameTextBox.Size = new System.Drawing.Size(265, 32);
			this.playerNameTextBox.TabIndex = 1;
			this.playerNameTextBox.Text = "Player 1";
			// 
			// playerNameLabel
			// 
			this.playerNameLabel.AutoSize = true;
			this.playerNameLabel.BackColor = System.Drawing.Color.Transparent;
			this.playerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.playerNameLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.playerNameLabel.Location = new System.Drawing.Point(26, 113);
			this.playerNameLabel.Name = "playerNameLabel";
			this.playerNameLabel.Size = new System.Drawing.Size(146, 25);
			this.playerNameLabel.TabIndex = 2;
			this.playerNameLabel.Text = "Player Name";
			this.playerNameLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// playerPictureBox
			// 
			this.playerPictureBox.BackColor = System.Drawing.Color.Silver;
			this.playerPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.playerPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.playerPictureBox.Location = new System.Drawing.Point(550, 211);
			this.playerPictureBox.Name = "playerPictureBox";
			this.playerPictureBox.Size = new System.Drawing.Size(156, 146);
			this.playerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.playerPictureBox.TabIndex = 3;
			this.playerPictureBox.TabStop = false;
			// 
			// playerPictureLabel
			// 
			this.playerPictureLabel.AutoSize = true;
			this.playerPictureLabel.BackColor = System.Drawing.Color.Transparent;
			this.playerPictureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.playerPictureLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.playerPictureLabel.Location = new System.Drawing.Point(26, 254);
			this.playerPictureLabel.Name = "playerPictureLabel";
			this.playerPictureLabel.Size = new System.Drawing.Size(160, 25);
			this.playerPictureLabel.TabIndex = 4;
			this.playerPictureLabel.Text = "Player Picture";
			this.playerPictureLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// defaultImageListView
			// 
			this.defaultImageListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
			this.defaultImageListView.BackColor = System.Drawing.Color.Silver;
			this.defaultImageListView.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
			this.defaultImageListView.HideSelection = false;
			this.defaultImageListView.LargeImageList = this.defaultImageList;
			this.defaultImageListView.Location = new System.Drawing.Point(220, 173);
			this.defaultImageListView.Margin = new System.Windows.Forms.Padding(0);
			this.defaultImageListView.MultiSelect = false;
			this.defaultImageListView.Name = "defaultImageListView";
			this.defaultImageListView.Size = new System.Drawing.Size(266, 239);
			this.defaultImageListView.TabIndex = 2;
			this.defaultImageListView.UseCompatibleStateImageBehavior = false;
			this.defaultImageListView.ItemActivate += new System.EventHandler(this.PlayerDefaultImageList_ItemActivate);
			// 
			// defaultImageList
			// 
			this.defaultImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.defaultImageList.ImageSize = new System.Drawing.Size(130, 130);
			this.defaultImageList.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// okButton
			// 
			this.okButton.BackColor = System.Drawing.Color.Transparent;
			this.okButton.BackgroundImage = global::BlackJack.Properties.Resources.ButtonSquare;
			this.okButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.okButton.FlatAppearance.BorderSize = 0;
			this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.okButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.okButton.Location = new System.Drawing.Point(220, 433);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(108, 41);
			this.okButton.TabIndex = 3;
			this.okButton.Text = "OK";
			this.okButton.UseVisualStyleBackColor = false;
			this.okButton.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// cancelButton
			// 
			this.cancelButton.BackColor = System.Drawing.Color.Transparent;
			this.cancelButton.BackgroundImage = global::BlackJack.Properties.Resources.ButtonSquare;
			this.cancelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.cancelButton.FlatAppearance.BorderSize = 0;
			this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cancelButton.Location = new System.Drawing.Point(378, 433);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(108, 41);
			this.cancelButton.TabIndex = 4;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = false;
			this.cancelButton.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// previewLabel
			// 
			this.previewLabel.AutoSize = true;
			this.previewLabel.BackColor = System.Drawing.Color.Transparent;
			this.previewLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.previewLabel.ForeColor = System.Drawing.Color.White;
			this.previewLabel.Location = new System.Drawing.Point(576, 173);
			this.previewLabel.Name = "previewLabel";
			this.previewLabel.Size = new System.Drawing.Size(95, 25);
			this.previewLabel.TabIndex = 17;
			this.previewLabel.Text = "Preview";
			// 
			// iconPictureBox
			// 
			this.iconPictureBox.BackColor = System.Drawing.Color.Transparent;
			this.iconPictureBox.ErrorImage = null;
			this.iconPictureBox.Image = global::BlackJack.Properties.Resources.StartMenuIcon;
			this.iconPictureBox.InitialImage = null;
			this.iconPictureBox.Location = new System.Drawing.Point(550, -1);
			this.iconPictureBox.Name = "iconPictureBox";
			this.iconPictureBox.Size = new System.Drawing.Size(156, 144);
			this.iconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.iconPictureBox.TabIndex = 18;
			this.iconPictureBox.TabStop = false;
			// 
			// OptionsForm
			// 
			this.BackColor = System.Drawing.SystemColors.ControlLight;
			this.BackgroundImage = global::BlackJack.Properties.Resources.backGreen;
			this.ClientSize = new System.Drawing.Size(735, 592);
			this.Controls.Add(this.iconPictureBox);
			this.Controls.Add(this.previewLabel);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.okButton);
			this.Controls.Add(this.defaultImageListView);
			this.Controls.Add(this.playerPictureLabel);
			this.Controls.Add(this.playerPictureBox);
			this.Controls.Add(this.playerNameLabel);
			this.Controls.Add(this.playerNameTextBox);
			this.Controls.Add(this.optionsLabel);
			this.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "OptionsForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "BlackJack Options";
			this.Load += new System.EventHandler(this.OptionsForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.playerPictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label optionsLabel;
        private System.Windows.Forms.TextBox playerNameTextBox;
        private System.Windows.Forms.Label playerNameLabel;
        private System.Windows.Forms.PictureBox playerPictureBox;
        private System.Windows.Forms.Label playerPictureLabel;
        private System.Windows.Forms.OpenFileDialog selectFileDialog;
        private System.Windows.Forms.ListView defaultImageListView;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ImageList defaultImageList;
        private System.Windows.Forms.Label previewLabel;
        private System.Windows.Forms.PictureBox iconPictureBox;
    }
}

