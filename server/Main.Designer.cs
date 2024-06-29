namespace ETS2_Local_Radio_server
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            keyTimeout = new System.Windows.Forms.Timer(components);
            saveButton = new Button();
            nextKeyTextBox = new TextBox();
            previousKeyTextBox = new TextBox();
            stopKeyTextBox = new TextBox();
            groupSettings = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            goToFavouriteKeyLabel = new Label();
            goToFavouriteButtonTextbox = new TextBox();
            makeFavouriteKeyLabel = new Label();
            keyLabel = new Label();
            volumeDownKeyLabel = new Label();
            volumeUpKeyLabel = new Label();
            makeFavouriteButtonTextbox = new TextBox();
            stopKeyLabel = new Label();
            previousKeyLabel = new Label();
            goToFavouriteKeyTextbox = new TextBox();
            previousButtonTextBox = new TextBox();
            nextKeyLabel = new Label();
            volumeUpButtonTextBox = new TextBox();
            makeFavouriteKeyTextbox = new TextBox();
            volumeDownButtonTextBox = new TextBox();
            nextButtonTextBox = new TextBox();
            volumeDownKeyTextBox = new TextBox();
            stopButtonTextBox = new TextBox();
            volumeUpKeyTextBox = new TextBox();
            buttonLabel = new Label();
            groupInfo = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            gameInfo = new Label();
            gameLabel = new Label();
            statusInfo = new Label();
            coordinatesInfo = new Label();
            URLInfo = new Label();
            statusLabel = new Label();
            locationLabel = new Label();
            comboIP = new ComboBox();
            URLLabel = new LinkLabel();
            comboLang = new ComboBox();
            folderDialog = new FolderBrowserDialog();
            joystickTimer = new System.Windows.Forms.Timer(components);
            currentGameTimer = new System.Windows.Forms.Timer(components);
            groupInstall = new GroupBox();
            removePluginButton = new LinkLabel();
            installEts2Button = new Button();
            installAtsButton = new Button();
            Koenvh = new PictureBox();
            groupController = new GroupBox();
            comboController = new ComboBox();
            groupSettings.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            groupInfo.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            groupInstall.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Koenvh).BeginInit();
            groupController.SuspendLayout();
            SuspendLayout();
            // 
            // keyTimeout
            // 
            keyTimeout.Interval = 10;
            keyTimeout.Tick += keyTimeout_Tick;
            // 
            // saveButton
            // 
            tableLayoutPanel2.SetColumnSpan(saveButton, 2);
            saveButton.Dock = DockStyle.Fill;
            saveButton.Font = new Font("Segoe UI", 8.25F);
            saveButton.Location = new Point(277, 235);
            saveButton.Margin = new Padding(4, 3, 4, 3);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(190, 39);
            saveButton.TabIndex = 0;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // nextKeyTextBox
            // 
            nextKeyTextBox.Dock = DockStyle.Fill;
            nextKeyTextBox.Location = new Point(277, 32);
            nextKeyTextBox.Margin = new Padding(4, 3, 4, 3);
            nextKeyTextBox.Name = "nextKeyTextBox";
            nextKeyTextBox.ShortcutsEnabled = false;
            nextKeyTextBox.Size = new Size(91, 22);
            nextKeyTextBox.TabIndex = 1;
            // 
            // previousKeyTextBox
            // 
            previousKeyTextBox.Dock = DockStyle.Fill;
            previousKeyTextBox.Location = new Point(277, 61);
            previousKeyTextBox.Margin = new Padding(4, 3, 4, 3);
            previousKeyTextBox.Name = "previousKeyTextBox";
            previousKeyTextBox.ShortcutsEnabled = false;
            previousKeyTextBox.Size = new Size(91, 22);
            previousKeyTextBox.TabIndex = 2;
            // 
            // stopKeyTextBox
            // 
            stopKeyTextBox.Dock = DockStyle.Fill;
            stopKeyTextBox.Location = new Point(277, 90);
            stopKeyTextBox.Margin = new Padding(4, 3, 4, 3);
            stopKeyTextBox.Name = "stopKeyTextBox";
            stopKeyTextBox.ShortcutsEnabled = false;
            stopKeyTextBox.Size = new Size(91, 22);
            stopKeyTextBox.TabIndex = 3;
            // 
            // groupSettings
            // 
            groupSettings.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupSettings.Controls.Add(tableLayoutPanel2);
            groupSettings.Font = new Font("Segoe UI", 8.25F);
            groupSettings.Location = new Point(14, 181);
            groupSettings.Margin = new Padding(4, 3, 4, 3);
            groupSettings.Name = "groupSettings";
            groupSettings.Padding = new Padding(4, 3, 4, 3);
            groupSettings.Size = new Size(482, 308);
            groupSettings.TabIndex = 4;
            groupSettings.TabStop = false;
            groupSettings.Text = "Settings";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 99F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 99F));
            tableLayoutPanel2.Controls.Add(goToFavouriteKeyLabel, 0, 7);
            tableLayoutPanel2.Controls.Add(goToFavouriteButtonTextbox, 2, 7);
            tableLayoutPanel2.Controls.Add(makeFavouriteKeyLabel, 0, 6);
            tableLayoutPanel2.Controls.Add(keyLabel, 1, 0);
            tableLayoutPanel2.Controls.Add(volumeDownKeyLabel, 0, 5);
            tableLayoutPanel2.Controls.Add(saveButton, 1, 8);
            tableLayoutPanel2.Controls.Add(volumeUpKeyLabel, 0, 4);
            tableLayoutPanel2.Controls.Add(makeFavouriteButtonTextbox, 2, 6);
            tableLayoutPanel2.Controls.Add(stopKeyLabel, 0, 3);
            tableLayoutPanel2.Controls.Add(previousKeyLabel, 0, 2);
            tableLayoutPanel2.Controls.Add(goToFavouriteKeyTextbox, 1, 7);
            tableLayoutPanel2.Controls.Add(previousButtonTextBox, 2, 2);
            tableLayoutPanel2.Controls.Add(nextKeyLabel, 0, 1);
            tableLayoutPanel2.Controls.Add(nextKeyTextBox, 1, 1);
            tableLayoutPanel2.Controls.Add(volumeUpButtonTextBox, 2, 4);
            tableLayoutPanel2.Controls.Add(makeFavouriteKeyTextbox, 1, 6);
            tableLayoutPanel2.Controls.Add(volumeDownButtonTextBox, 2, 5);
            tableLayoutPanel2.Controls.Add(nextButtonTextBox, 2, 1);
            tableLayoutPanel2.Controls.Add(previousKeyTextBox, 1, 2);
            tableLayoutPanel2.Controls.Add(volumeDownKeyTextBox, 1, 5);
            tableLayoutPanel2.Controls.Add(stopButtonTextBox, 2, 3);
            tableLayoutPanel2.Controls.Add(volumeUpKeyTextBox, 1, 4);
            tableLayoutPanel2.Controls.Add(stopKeyTextBox, 1, 3);
            tableLayoutPanel2.Controls.Add(buttonLabel, 2, 0);
            tableLayoutPanel2.Location = new Point(7, 24);
            tableLayoutPanel2.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 9;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 23F));
            tableLayoutPanel2.Size = new Size(471, 277);
            tableLayoutPanel2.TabIndex = 25;
            // 
            // goToFavouriteKeyLabel
            // 
            goToFavouriteKeyLabel.Dock = DockStyle.Fill;
            goToFavouriteKeyLabel.Font = new Font("Segoe UI", 8.25F);
            goToFavouriteKeyLabel.Location = new Point(4, 203);
            goToFavouriteKeyLabel.Margin = new Padding(4, 0, 4, 0);
            goToFavouriteKeyLabel.Name = "goToFavouriteKeyLabel";
            goToFavouriteKeyLabel.Size = new Size(265, 29);
            goToFavouriteKeyLabel.TabIndex = 23;
            goToFavouriteKeyLabel.Text = "Go to favourite key:";
            goToFavouriteKeyLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // goToFavouriteButtonTextbox
            // 
            goToFavouriteButtonTextbox.BackColor = SystemColors.Window;
            goToFavouriteButtonTextbox.Dock = DockStyle.Fill;
            goToFavouriteButtonTextbox.Location = new Point(376, 206);
            goToFavouriteButtonTextbox.Margin = new Padding(4, 3, 4, 3);
            goToFavouriteButtonTextbox.Name = "goToFavouriteButtonTextbox";
            goToFavouriteButtonTextbox.ReadOnly = true;
            goToFavouriteButtonTextbox.ShortcutsEnabled = false;
            goToFavouriteButtonTextbox.Size = new Size(91, 22);
            goToFavouriteButtonTextbox.TabIndex = 24;
            // 
            // makeFavouriteKeyLabel
            // 
            makeFavouriteKeyLabel.Dock = DockStyle.Fill;
            makeFavouriteKeyLabel.Font = new Font("Segoe UI", 8.25F);
            makeFavouriteKeyLabel.Location = new Point(4, 174);
            makeFavouriteKeyLabel.Margin = new Padding(4, 0, 4, 0);
            makeFavouriteKeyLabel.Name = "makeFavouriteKeyLabel";
            makeFavouriteKeyLabel.Size = new Size(265, 29);
            makeFavouriteKeyLabel.TabIndex = 13;
            makeFavouriteKeyLabel.Text = "Make favourite key:";
            makeFavouriteKeyLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // keyLabel
            // 
            keyLabel.Dock = DockStyle.Fill;
            keyLabel.Font = new Font("Segoe UI", 8.25F);
            keyLabel.Location = new Point(277, 0);
            keyLabel.Margin = new Padding(4, 0, 4, 0);
            keyLabel.Name = "keyLabel";
            keyLabel.Size = new Size(91, 29);
            keyLabel.TabIndex = 20;
            keyLabel.Text = "Keyboard";
            keyLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // volumeDownKeyLabel
            // 
            volumeDownKeyLabel.Dock = DockStyle.Fill;
            volumeDownKeyLabel.Font = new Font("Segoe UI", 8.25F);
            volumeDownKeyLabel.Location = new Point(4, 145);
            volumeDownKeyLabel.Margin = new Padding(4, 0, 4, 0);
            volumeDownKeyLabel.Name = "volumeDownKeyLabel";
            volumeDownKeyLabel.Size = new Size(265, 29);
            volumeDownKeyLabel.TabIndex = 11;
            volumeDownKeyLabel.Text = "Volume down key:";
            volumeDownKeyLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // volumeUpKeyLabel
            // 
            volumeUpKeyLabel.Dock = DockStyle.Fill;
            volumeUpKeyLabel.Font = new Font("Segoe UI", 8.25F);
            volumeUpKeyLabel.Location = new Point(4, 116);
            volumeUpKeyLabel.Margin = new Padding(4, 0, 4, 0);
            volumeUpKeyLabel.Name = "volumeUpKeyLabel";
            volumeUpKeyLabel.Size = new Size(265, 29);
            volumeUpKeyLabel.TabIndex = 10;
            volumeUpKeyLabel.Text = "Volume up key:";
            volumeUpKeyLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // makeFavouriteButtonTextbox
            // 
            makeFavouriteButtonTextbox.BackColor = SystemColors.Window;
            makeFavouriteButtonTextbox.Dock = DockStyle.Fill;
            makeFavouriteButtonTextbox.Location = new Point(376, 177);
            makeFavouriteButtonTextbox.Margin = new Padding(4, 3, 4, 3);
            makeFavouriteButtonTextbox.Name = "makeFavouriteButtonTextbox";
            makeFavouriteButtonTextbox.ReadOnly = true;
            makeFavouriteButtonTextbox.ShortcutsEnabled = false;
            makeFavouriteButtonTextbox.Size = new Size(91, 22);
            makeFavouriteButtonTextbox.TabIndex = 19;
            // 
            // stopKeyLabel
            // 
            stopKeyLabel.Dock = DockStyle.Fill;
            stopKeyLabel.Font = new Font("Segoe UI", 8.25F);
            stopKeyLabel.Location = new Point(4, 87);
            stopKeyLabel.Margin = new Padding(4, 0, 4, 0);
            stopKeyLabel.Name = "stopKeyLabel";
            stopKeyLabel.Size = new Size(265, 29);
            stopKeyLabel.TabIndex = 5;
            stopKeyLabel.Text = "Stop playback key:";
            stopKeyLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // previousKeyLabel
            // 
            previousKeyLabel.Dock = DockStyle.Fill;
            previousKeyLabel.Font = new Font("Segoe UI", 8.25F);
            previousKeyLabel.Location = new Point(4, 58);
            previousKeyLabel.Margin = new Padding(4, 0, 4, 0);
            previousKeyLabel.Name = "previousKeyLabel";
            previousKeyLabel.Size = new Size(265, 29);
            previousKeyLabel.TabIndex = 5;
            previousKeyLabel.Text = "Previous station key:";
            previousKeyLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // goToFavouriteKeyTextbox
            // 
            goToFavouriteKeyTextbox.Dock = DockStyle.Fill;
            goToFavouriteKeyTextbox.Location = new Point(277, 206);
            goToFavouriteKeyTextbox.Margin = new Padding(4, 3, 4, 3);
            goToFavouriteKeyTextbox.Name = "goToFavouriteKeyTextbox";
            goToFavouriteKeyTextbox.ShortcutsEnabled = false;
            goToFavouriteKeyTextbox.Size = new Size(91, 22);
            goToFavouriteKeyTextbox.TabIndex = 22;
            // 
            // previousButtonTextBox
            // 
            previousButtonTextBox.BackColor = SystemColors.Window;
            previousButtonTextBox.Dock = DockStyle.Fill;
            previousButtonTextBox.Location = new Point(376, 61);
            previousButtonTextBox.Margin = new Padding(4, 3, 4, 3);
            previousButtonTextBox.Name = "previousButtonTextBox";
            previousButtonTextBox.ReadOnly = true;
            previousButtonTextBox.ShortcutsEnabled = false;
            previousButtonTextBox.Size = new Size(91, 22);
            previousButtonTextBox.TabIndex = 15;
            // 
            // nextKeyLabel
            // 
            nextKeyLabel.Dock = DockStyle.Fill;
            nextKeyLabel.Font = new Font("Segoe UI", 8.25F);
            nextKeyLabel.Location = new Point(4, 29);
            nextKeyLabel.Margin = new Padding(4, 0, 4, 0);
            nextKeyLabel.Name = "nextKeyLabel";
            nextKeyLabel.Size = new Size(265, 29);
            nextKeyLabel.TabIndex = 4;
            nextKeyLabel.Text = "Next station key:";
            nextKeyLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // volumeUpButtonTextBox
            // 
            volumeUpButtonTextBox.BackColor = SystemColors.Window;
            volumeUpButtonTextBox.Dock = DockStyle.Fill;
            volumeUpButtonTextBox.Location = new Point(376, 119);
            volumeUpButtonTextBox.Margin = new Padding(4, 3, 4, 3);
            volumeUpButtonTextBox.Name = "volumeUpButtonTextBox";
            volumeUpButtonTextBox.ReadOnly = true;
            volumeUpButtonTextBox.ShortcutsEnabled = false;
            volumeUpButtonTextBox.Size = new Size(91, 22);
            volumeUpButtonTextBox.TabIndex = 17;
            // 
            // makeFavouriteKeyTextbox
            // 
            makeFavouriteKeyTextbox.Dock = DockStyle.Fill;
            makeFavouriteKeyTextbox.Location = new Point(277, 177);
            makeFavouriteKeyTextbox.Margin = new Padding(4, 3, 4, 3);
            makeFavouriteKeyTextbox.Name = "makeFavouriteKeyTextbox";
            makeFavouriteKeyTextbox.ShortcutsEnabled = false;
            makeFavouriteKeyTextbox.Size = new Size(91, 22);
            makeFavouriteKeyTextbox.TabIndex = 12;
            // 
            // volumeDownButtonTextBox
            // 
            volumeDownButtonTextBox.BackColor = SystemColors.Window;
            volumeDownButtonTextBox.Dock = DockStyle.Fill;
            volumeDownButtonTextBox.Location = new Point(376, 148);
            volumeDownButtonTextBox.Margin = new Padding(4, 3, 4, 3);
            volumeDownButtonTextBox.Name = "volumeDownButtonTextBox";
            volumeDownButtonTextBox.ReadOnly = true;
            volumeDownButtonTextBox.ShortcutsEnabled = false;
            volumeDownButtonTextBox.Size = new Size(91, 22);
            volumeDownButtonTextBox.TabIndex = 18;
            // 
            // nextButtonTextBox
            // 
            nextButtonTextBox.BackColor = SystemColors.Window;
            nextButtonTextBox.Dock = DockStyle.Fill;
            nextButtonTextBox.Location = new Point(376, 32);
            nextButtonTextBox.Margin = new Padding(4, 3, 4, 3);
            nextButtonTextBox.Name = "nextButtonTextBox";
            nextButtonTextBox.ReadOnly = true;
            nextButtonTextBox.ShortcutsEnabled = false;
            nextButtonTextBox.Size = new Size(91, 22);
            nextButtonTextBox.TabIndex = 14;
            // 
            // volumeDownKeyTextBox
            // 
            volumeDownKeyTextBox.Dock = DockStyle.Fill;
            volumeDownKeyTextBox.Location = new Point(277, 148);
            volumeDownKeyTextBox.Margin = new Padding(4, 3, 4, 3);
            volumeDownKeyTextBox.Name = "volumeDownKeyTextBox";
            volumeDownKeyTextBox.ShortcutsEnabled = false;
            volumeDownKeyTextBox.Size = new Size(91, 22);
            volumeDownKeyTextBox.TabIndex = 9;
            // 
            // stopButtonTextBox
            // 
            stopButtonTextBox.BackColor = SystemColors.Window;
            stopButtonTextBox.Dock = DockStyle.Fill;
            stopButtonTextBox.Location = new Point(376, 90);
            stopButtonTextBox.Margin = new Padding(4, 3, 4, 3);
            stopButtonTextBox.Name = "stopButtonTextBox";
            stopButtonTextBox.ReadOnly = true;
            stopButtonTextBox.ShortcutsEnabled = false;
            stopButtonTextBox.Size = new Size(91, 22);
            stopButtonTextBox.TabIndex = 16;
            // 
            // volumeUpKeyTextBox
            // 
            volumeUpKeyTextBox.Dock = DockStyle.Fill;
            volumeUpKeyTextBox.Location = new Point(277, 119);
            volumeUpKeyTextBox.Margin = new Padding(4, 3, 4, 3);
            volumeUpKeyTextBox.Name = "volumeUpKeyTextBox";
            volumeUpKeyTextBox.ShortcutsEnabled = false;
            volumeUpKeyTextBox.Size = new Size(91, 22);
            volumeUpKeyTextBox.TabIndex = 8;
            // 
            // buttonLabel
            // 
            buttonLabel.Dock = DockStyle.Fill;
            buttonLabel.Font = new Font("Segoe UI", 8.25F);
            buttonLabel.Location = new Point(376, 0);
            buttonLabel.Margin = new Padding(4, 0, 4, 0);
            buttonLabel.Name = "buttonLabel";
            buttonLabel.Size = new Size(91, 29);
            buttonLabel.TabIndex = 21;
            buttonLabel.Text = "Controller";
            buttonLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupInfo
            // 
            groupInfo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupInfo.Controls.Add(tableLayoutPanel1);
            groupInfo.Font = new Font("Segoe UI", 8.25F);
            groupInfo.Location = new Point(14, 14);
            groupInfo.Margin = new Padding(4, 3, 4, 3);
            groupInfo.Name = "groupInfo";
            groupInfo.Padding = new Padding(4, 3, 4, 3);
            groupInfo.Size = new Size(482, 160);
            groupInfo.TabIndex = 5;
            groupInfo.TabStop = false;
            groupInfo.Text = "Info";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 117F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 358F));
            tableLayoutPanel1.Controls.Add(gameInfo, 0, 0);
            tableLayoutPanel1.Controls.Add(gameLabel, 1, 0);
            tableLayoutPanel1.Controls.Add(statusInfo, 0, 1);
            tableLayoutPanel1.Controls.Add(coordinatesInfo, 0, 2);
            tableLayoutPanel1.Controls.Add(URLInfo, 0, 3);
            tableLayoutPanel1.Controls.Add(statusLabel, 1, 1);
            tableLayoutPanel1.Controls.Add(locationLabel, 1, 2);
            tableLayoutPanel1.Controls.Add(comboIP, 1, 3);
            tableLayoutPanel1.Controls.Add(URLLabel, 1, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(4, 18);
            tableLayoutPanel1.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(474, 139);
            tableLayoutPanel1.TabIndex = 14;
            // 
            // gameInfo
            // 
            gameInfo.Dock = DockStyle.Fill;
            gameInfo.Font = new Font("Segoe UI", 8.25F);
            gameInfo.Location = new Point(4, 0);
            gameInfo.Margin = new Padding(4, 0, 4, 0);
            gameInfo.Name = "gameInfo";
            gameInfo.Size = new Size(109, 27);
            gameInfo.TabIndex = 13;
            gameInfo.Text = "Game:";
            gameInfo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // gameLabel
            // 
            gameLabel.Dock = DockStyle.Fill;
            gameLabel.Font = new Font("Segoe UI", 8.25F);
            gameLabel.Location = new Point(121, 0);
            gameLabel.Margin = new Padding(4, 0, 4, 0);
            gameLabel.Name = "gameLabel";
            gameLabel.Size = new Size(350, 27);
            gameLabel.TabIndex = 12;
            gameLabel.Text = "Euro Truck Simulator 2";
            gameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // statusInfo
            // 
            statusInfo.Dock = DockStyle.Fill;
            statusInfo.Font = new Font("Segoe UI", 8.25F);
            statusInfo.Location = new Point(4, 27);
            statusInfo.Margin = new Padding(4, 0, 4, 0);
            statusInfo.Name = "statusInfo";
            statusInfo.Size = new Size(109, 27);
            statusInfo.TabIndex = 8;
            statusInfo.Text = "Status:";
            statusInfo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // coordinatesInfo
            // 
            coordinatesInfo.Dock = DockStyle.Fill;
            coordinatesInfo.Font = new Font("Segoe UI", 8.25F);
            coordinatesInfo.Location = new Point(4, 54);
            coordinatesInfo.Margin = new Padding(4, 0, 4, 0);
            coordinatesInfo.Name = "coordinatesInfo";
            coordinatesInfo.Size = new Size(109, 27);
            coordinatesInfo.TabIndex = 9;
            coordinatesInfo.Text = "Coordinates:";
            coordinatesInfo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // URLInfo
            // 
            URLInfo.Dock = DockStyle.Fill;
            URLInfo.Font = new Font("Segoe UI", 8.25F);
            URLInfo.Location = new Point(4, 81);
            URLInfo.Margin = new Padding(4, 0, 4, 0);
            URLInfo.Name = "URLInfo";
            URLInfo.Size = new Size(109, 27);
            URLInfo.TabIndex = 10;
            URLInfo.Text = "URL:";
            URLInfo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // statusLabel
            // 
            statusLabel.Dock = DockStyle.Fill;
            statusLabel.Font = new Font("Segoe UI", 8.25F);
            statusLabel.Location = new Point(121, 27);
            statusLabel.Margin = new Padding(4, 0, 4, 0);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(350, 27);
            statusLabel.TabIndex = 7;
            statusLabel.Text = "status";
            statusLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // locationLabel
            // 
            locationLabel.Dock = DockStyle.Fill;
            locationLabel.Font = new Font("Segoe UI", 8.25F);
            locationLabel.Location = new Point(121, 54);
            locationLabel.Margin = new Padding(4, 0, 4, 0);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new Size(350, 27);
            locationLabel.TabIndex = 6;
            locationLabel.Text = "XYZ";
            locationLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // comboIP
            // 
            comboIP.Dock = DockStyle.Fill;
            comboIP.DropDownStyle = ComboBoxStyle.DropDownList;
            comboIP.Font = new Font("Segoe UI", 8.25F);
            comboIP.FormattingEnabled = true;
            comboIP.Location = new Point(121, 84);
            comboIP.Margin = new Padding(4, 3, 4, 3);
            comboIP.Name = "comboIP";
            comboIP.Size = new Size(350, 21);
            comboIP.TabIndex = 11;
            // 
            // URLLabel
            // 
            URLLabel.Dock = DockStyle.Fill;
            URLLabel.Font = new Font("Segoe UI", 8.25F);
            URLLabel.Location = new Point(121, 108);
            URLLabel.Margin = new Padding(4, 0, 4, 0);
            URLLabel.Name = "URLLabel";
            URLLabel.Size = new Size(350, 31);
            URLLabel.TabIndex = 6;
            URLLabel.TabStop = true;
            URLLabel.Text = "Open ETS2 Local Radio";
            URLLabel.TextAlign = ContentAlignment.MiddleLeft;
            URLLabel.LinkClicked += URLLabel_LinkClicked;
            // 
            // comboLang
            // 
            comboLang.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            comboLang.DropDownStyle = ComboBoxStyle.DropDownList;
            comboLang.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboLang.FormattingEnabled = true;
            comboLang.Location = new Point(420, 713);
            comboLang.Margin = new Padding(4, 3, 4, 3);
            comboLang.Name = "comboLang";
            comboLang.Size = new Size(75, 21);
            comboLang.TabIndex = 8;
            comboLang.SelectedIndexChanged += comboLang_SelectedIndexChanged;
            // 
            // folderDialog
            // 
            folderDialog.Description = "Please select the Euro Truck Simulator 2 installation folder, usually found in C:\\Program Files (x86)\\Steam\\SteamApps\\common\\Euro Truck Simulator 2";
            folderDialog.ShowNewFolderButton = false;
            // 
            // joystickTimer
            // 
            joystickTimer.Interval = 10;
            joystickTimer.Tick += joystickTimer_Tick;
            // 
            // currentGameTimer
            // 
            currentGameTimer.Interval = 3000;
            currentGameTimer.Tick += currentGameTimer_Tick;
            // 
            // groupInstall
            // 
            groupInstall.Controls.Add(removePluginButton);
            groupInstall.Controls.Add(installEts2Button);
            groupInstall.Controls.Add(installAtsButton);
            groupInstall.Font = new Font("Segoe UI", 8.25F);
            groupInstall.Location = new Point(14, 568);
            groupInstall.Margin = new Padding(4, 3, 4, 3);
            groupInstall.Name = "groupInstall";
            groupInstall.Padding = new Padding(4, 3, 4, 3);
            groupInstall.Size = new Size(482, 105);
            groupInstall.TabIndex = 9;
            groupInstall.TabStop = false;
            groupInstall.Text = "Install plugin";
            // 
            // removePluginButton
            // 
            removePluginButton.AutoSize = true;
            removePluginButton.Location = new Point(12, 83);
            removePluginButton.Margin = new Padding(4, 0, 4, 0);
            removePluginButton.Name = "removePluginButton";
            removePluginButton.Size = new Size(84, 13);
            removePluginButton.TabIndex = 2;
            removePluginButton.TabStop = true;
            removePluginButton.Text = "Remove plugin";
            removePluginButton.LinkClicked += removePluginButton_LinkClicked;
            // 
            // installEts2Button
            // 
            installEts2Button.Font = new Font("Segoe UI", 8.25F);
            installEts2Button.ForeColor = SystemColors.ControlText;
            installEts2Button.ImageAlign = ContentAlignment.MiddleLeft;
            installEts2Button.Location = new Point(248, 27);
            installEts2Button.Margin = new Padding(4, 3, 4, 3);
            installEts2Button.Name = "installEts2Button";
            installEts2Button.Size = new Size(222, 51);
            installEts2Button.TabIndex = 1;
            installEts2Button.Text = "Install plugin for \r\nEuro Truck Simulator 2";
            installEts2Button.UseVisualStyleBackColor = true;
            installEts2Button.Click += installEts2Button_Click;
            // 
            // installAtsButton
            // 
            installAtsButton.Font = new Font("Segoe UI", 8.25F);
            installAtsButton.ForeColor = SystemColors.ControlText;
            installAtsButton.ImageAlign = ContentAlignment.MiddleLeft;
            installAtsButton.Location = new Point(12, 27);
            installAtsButton.Margin = new Padding(4, 3, 4, 3);
            installAtsButton.Name = "installAtsButton";
            installAtsButton.Size = new Size(222, 51);
            installAtsButton.TabIndex = 0;
            installAtsButton.Text = "Install plugin for \r\nAmerican Truck Simulator";
            installAtsButton.UseVisualStyleBackColor = true;
            installAtsButton.Click += installAtsButton_Click;
            // 
            // Koenvh
            // 
            Koenvh.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Koenvh.Cursor = Cursors.Hand;
            Koenvh.Image = server.Properties.Resources.Koenvh_fat_text_smaller;
            Koenvh.Location = new Point(163, 680);
            Koenvh.Margin = new Padding(4, 3, 4, 3);
            Koenvh.Name = "Koenvh";
            Koenvh.Size = new Size(182, 58);
            Koenvh.TabIndex = 6;
            Koenvh.TabStop = false;
            Koenvh.Click += Koenvh_Click;
            // 
            // groupController
            // 
            groupController.Controls.Add(comboController);
            groupController.Font = new Font("Segoe UI", 8.25F);
            groupController.Location = new Point(14, 496);
            groupController.Margin = new Padding(4, 3, 4, 3);
            groupController.Name = "groupController";
            groupController.Padding = new Padding(4, 3, 4, 3);
            groupController.Size = new Size(482, 65);
            groupController.TabIndex = 10;
            groupController.TabStop = false;
            groupController.Text = "Controller";
            // 
            // comboController
            // 
            comboController.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboController.FormattingEnabled = true;
            comboController.Location = new Point(12, 25);
            comboController.Margin = new Padding(4, 3, 4, 3);
            comboController.Name = "comboController";
            comboController.Size = new Size(458, 21);
            comboController.TabIndex = 11;
            comboController.SelectedIndexChanged += comboController_SelectedIndexChanged;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(510, 749);
            Controls.Add(groupController);
            Controls.Add(groupInstall);
            Controls.Add(comboLang);
            Controls.Add(Koenvh);
            Controls.Add(groupInfo);
            Controls.Add(groupSettings);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "Main";
            Text = "ETS2/ATS Local Radio server";
            FormClosing += Main_FormClosing;
            Load += Main_Load;
            groupSettings.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            groupInfo.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            groupInstall.ResumeLayout(false);
            groupInstall.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Koenvh).EndInit();
            groupController.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer keyTimeout;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox nextKeyTextBox;
        private System.Windows.Forms.TextBox previousKeyTextBox;
        private System.Windows.Forms.TextBox stopKeyTextBox;
        private System.Windows.Forms.GroupBox groupSettings;
        private System.Windows.Forms.Label previousKeyLabel;
        private System.Windows.Forms.Label stopKeyLabel;
        private System.Windows.Forms.Label nextKeyLabel;
        private System.Windows.Forms.GroupBox groupInfo;
        private System.Windows.Forms.LinkLabel URLLabel;
        private System.Windows.Forms.Label volumeDownKeyLabel;
        private System.Windows.Forms.Label volumeUpKeyLabel;
        private System.Windows.Forms.TextBox volumeDownKeyTextBox;
        private System.Windows.Forms.TextBox volumeUpKeyTextBox;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label statusInfo;
        private System.Windows.Forms.Label coordinatesInfo;
        private System.Windows.Forms.PictureBox Koenvh;
        private System.Windows.Forms.Label URLInfo;
        private System.Windows.Forms.ComboBox comboIP;
        private System.Windows.Forms.ComboBox comboLang;
        private System.Windows.Forms.Label makeFavouriteKeyLabel;
        private System.Windows.Forms.TextBox makeFavouriteKeyTextbox;
        private System.Windows.Forms.FolderBrowserDialog folderDialog;
        private System.Windows.Forms.Timer joystickTimer;
        private System.Windows.Forms.Label buttonLabel;
        private System.Windows.Forms.Label keyLabel;
        private System.Windows.Forms.TextBox makeFavouriteButtonTextbox;
        private System.Windows.Forms.TextBox volumeDownButtonTextBox;
        private System.Windows.Forms.TextBox volumeUpButtonTextBox;
        private System.Windows.Forms.TextBox stopButtonTextBox;
        private System.Windows.Forms.TextBox previousButtonTextBox;
        private System.Windows.Forms.TextBox nextButtonTextBox;
        private System.Windows.Forms.Timer currentGameTimer;
        private System.Windows.Forms.Label gameInfo;
        private System.Windows.Forms.Label gameLabel;
        private System.Windows.Forms.GroupBox groupInstall;
        private System.Windows.Forms.Button installEts2Button;
        private System.Windows.Forms.Button installAtsButton;
        private System.Windows.Forms.GroupBox groupController;
        private System.Windows.Forms.ComboBox comboController;
        private System.Windows.Forms.TextBox goToFavouriteButtonTextbox;
        private System.Windows.Forms.Label goToFavouriteKeyLabel;
        private System.Windows.Forms.TextBox goToFavouriteKeyTextbox;
        private System.Windows.Forms.LinkLabel removePluginButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}