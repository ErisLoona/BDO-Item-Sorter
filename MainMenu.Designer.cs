namespace BDO_Item_Sorter
{
    partial class MainMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.loadingBar = new System.Windows.Forms.ProgressBar();
            this.itemButton00 = new System.Windows.Forms.Button();
            this.itemButton01 = new System.Windows.Forms.Button();
            this.itemButton02 = new System.Windows.Forms.Button();
            this.itemButton03 = new System.Windows.Forms.Button();
            this.itemButton04 = new System.Windows.Forms.Button();
            this.itemButton05 = new System.Windows.Forms.Button();
            this.itemButton06 = new System.Windows.Forms.Button();
            this.itemButton07 = new System.Windows.Forms.Button();
            this.itemButton10 = new System.Windows.Forms.Button();
            this.itemButton20 = new System.Windows.Forms.Button();
            this.itemButton30 = new System.Windows.Forms.Button();
            this.itemButton40 = new System.Windows.Forms.Button();
            this.itemButton50 = new System.Windows.Forms.Button();
            this.itemButton60 = new System.Windows.Forms.Button();
            this.itemButton70 = new System.Windows.Forms.Button();
            this.itemButton11 = new System.Windows.Forms.Button();
            this.itemButton12 = new System.Windows.Forms.Button();
            this.itemButton13 = new System.Windows.Forms.Button();
            this.itemButton14 = new System.Windows.Forms.Button();
            this.itemButton15 = new System.Windows.Forms.Button();
            this.itemButton16 = new System.Windows.Forms.Button();
            this.itemButton17 = new System.Windows.Forms.Button();
            this.itemButton21 = new System.Windows.Forms.Button();
            this.itemButton22 = new System.Windows.Forms.Button();
            this.itemButton23 = new System.Windows.Forms.Button();
            this.itemButton24 = new System.Windows.Forms.Button();
            this.itemButton25 = new System.Windows.Forms.Button();
            this.itemButton26 = new System.Windows.Forms.Button();
            this.itemButton27 = new System.Windows.Forms.Button();
            this.itemButton31 = new System.Windows.Forms.Button();
            this.itemButton32 = new System.Windows.Forms.Button();
            this.itemButton33 = new System.Windows.Forms.Button();
            this.itemButton34 = new System.Windows.Forms.Button();
            this.itemButton35 = new System.Windows.Forms.Button();
            this.itemButton36 = new System.Windows.Forms.Button();
            this.itemButton37 = new System.Windows.Forms.Button();
            this.itemButton41 = new System.Windows.Forms.Button();
            this.itemButton42 = new System.Windows.Forms.Button();
            this.itemButton43 = new System.Windows.Forms.Button();
            this.itemButton44 = new System.Windows.Forms.Button();
            this.itemButton45 = new System.Windows.Forms.Button();
            this.itemButton46 = new System.Windows.Forms.Button();
            this.itemButton47 = new System.Windows.Forms.Button();
            this.itemButton51 = new System.Windows.Forms.Button();
            this.itemButton52 = new System.Windows.Forms.Button();
            this.itemButton53 = new System.Windows.Forms.Button();
            this.itemButton54 = new System.Windows.Forms.Button();
            this.itemButton55 = new System.Windows.Forms.Button();
            this.itemButton56 = new System.Windows.Forms.Button();
            this.itemButton57 = new System.Windows.Forms.Button();
            this.itemButton61 = new System.Windows.Forms.Button();
            this.itemButton62 = new System.Windows.Forms.Button();
            this.itemButton63 = new System.Windows.Forms.Button();
            this.itemButton64 = new System.Windows.Forms.Button();
            this.itemButton65 = new System.Windows.Forms.Button();
            this.itemButton66 = new System.Windows.Forms.Button();
            this.itemButton67 = new System.Windows.Forms.Button();
            this.itemButton71 = new System.Windows.Forms.Button();
            this.itemButton72 = new System.Windows.Forms.Button();
            this.itemButton73 = new System.Windows.Forms.Button();
            this.itemButton74 = new System.Windows.Forms.Button();
            this.itemButton75 = new System.Windows.Forms.Button();
            this.itemButton76 = new System.Windows.Forms.Button();
            this.itemButton77 = new System.Windows.Forms.Button();
            this.analyzeButton = new System.Windows.Forms.Button();
            this.thread1 = new System.ComponentModel.BackgroundWorker();
            this.thread2 = new System.ComponentModel.BackgroundWorker();
            this.thread3 = new System.ComponentModel.BackgroundWorker();
            this.thread4 = new System.ComponentModel.BackgroundWorker();
            this.settingsButton = new System.Windows.Forms.Button();
            this.infoLabel = new System.Windows.Forms.Label();
            this.playPauseButton = new System.Windows.Forms.Button();
            this.endSessionButton = new System.Windows.Forms.Button();
            this.clearSessionButton = new System.Windows.Forms.Button();
            this.locationBox = new System.Windows.Forms.ComboBox();
            this.itemPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.timerLabelLabel = new System.Windows.Forms.Label();
            this.timerLabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.gameOptionsWatcher = new System.IO.FileSystemWatcher();
            this.inventoryHighlights = new System.Windows.Forms.PictureBox();
            this.badScaleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gameOptionsWatcher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryHighlights)).BeginInit();
            this.SuspendLayout();
            // 
            // loadingBar
            // 
            this.loadingBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.loadingBar.Enabled = false;
            this.loadingBar.Location = new System.Drawing.Point(144, 476);
            this.loadingBar.Maximum = 2000000;
            this.loadingBar.Name = "loadingBar";
            this.loadingBar.Size = new System.Drawing.Size(151, 20);
            this.loadingBar.Step = 15625;
            this.loadingBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.loadingBar.TabIndex = 0;
            this.loadingBar.Visible = false;
            // 
            // itemButton00
            // 
            this.itemButton00.BackColor = System.Drawing.Color.Lime;
            this.itemButton00.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.itemButton00.Enabled = false;
            this.itemButton00.FlatAppearance.BorderSize = 0;
            this.itemButton00.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton00.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton00.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton00.Location = new System.Drawing.Point(9, 10);
            this.itemButton00.Name = "itemButton00";
            this.itemButton00.Size = new System.Drawing.Size(44, 44);
            this.itemButton00.TabIndex = 1;
            this.itemButton00.UseVisualStyleBackColor = false;
            this.itemButton00.Visible = false;
            this.itemButton00.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton00.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            // 
            // itemButton01
            // 
            this.itemButton01.BackColor = System.Drawing.Color.Lime;
            this.itemButton01.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.itemButton01.Enabled = false;
            this.itemButton01.FlatAppearance.BorderSize = 0;
            this.itemButton01.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton01.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton01.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton01.Location = new System.Drawing.Point(63, 10);
            this.itemButton01.Name = "itemButton01";
            this.itemButton01.Size = new System.Drawing.Size(44, 44);
            this.itemButton01.TabIndex = 2;
            this.itemButton01.UseVisualStyleBackColor = false;
            this.itemButton01.Visible = false;
            this.itemButton01.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton01.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            // 
            // itemButton02
            // 
            this.itemButton02.BackColor = System.Drawing.Color.Lime;
            this.itemButton02.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.itemButton02.Enabled = false;
            this.itemButton02.FlatAppearance.BorderSize = 0;
            this.itemButton02.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton02.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton02.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton02.Location = new System.Drawing.Point(117, 10);
            this.itemButton02.Name = "itemButton02";
            this.itemButton02.Size = new System.Drawing.Size(44, 44);
            this.itemButton02.TabIndex = 3;
            this.itemButton02.UseVisualStyleBackColor = false;
            this.itemButton02.Visible = false;
            this.itemButton02.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton02.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            // 
            // itemButton03
            // 
            this.itemButton03.BackColor = System.Drawing.Color.Lime;
            this.itemButton03.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.itemButton03.Enabled = false;
            this.itemButton03.FlatAppearance.BorderSize = 0;
            this.itemButton03.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton03.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton03.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton03.Location = new System.Drawing.Point(171, 10);
            this.itemButton03.Name = "itemButton03";
            this.itemButton03.Size = new System.Drawing.Size(44, 44);
            this.itemButton03.TabIndex = 4;
            this.itemButton03.UseVisualStyleBackColor = false;
            this.itemButton03.Visible = false;
            this.itemButton03.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton03.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            // 
            // itemButton04
            // 
            this.itemButton04.BackColor = System.Drawing.Color.Lime;
            this.itemButton04.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.itemButton04.Enabled = false;
            this.itemButton04.FlatAppearance.BorderSize = 0;
            this.itemButton04.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton04.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton04.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton04.Location = new System.Drawing.Point(225, 10);
            this.itemButton04.Name = "itemButton04";
            this.itemButton04.Size = new System.Drawing.Size(44, 44);
            this.itemButton04.TabIndex = 5;
            this.itemButton04.UseVisualStyleBackColor = false;
            this.itemButton04.Visible = false;
            this.itemButton04.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton04.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            // 
            // itemButton05
            // 
            this.itemButton05.BackColor = System.Drawing.Color.Lime;
            this.itemButton05.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.itemButton05.Enabled = false;
            this.itemButton05.FlatAppearance.BorderSize = 0;
            this.itemButton05.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton05.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton05.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton05.Location = new System.Drawing.Point(279, 10);
            this.itemButton05.Name = "itemButton05";
            this.itemButton05.Size = new System.Drawing.Size(44, 44);
            this.itemButton05.TabIndex = 6;
            this.itemButton05.UseVisualStyleBackColor = false;
            this.itemButton05.Visible = false;
            this.itemButton05.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton05.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            // 
            // itemButton06
            // 
            this.itemButton06.BackColor = System.Drawing.Color.Lime;
            this.itemButton06.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.itemButton06.Enabled = false;
            this.itemButton06.FlatAppearance.BorderSize = 0;
            this.itemButton06.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton06.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton06.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton06.Location = new System.Drawing.Point(333, 10);
            this.itemButton06.Name = "itemButton06";
            this.itemButton06.Size = new System.Drawing.Size(44, 44);
            this.itemButton06.TabIndex = 7;
            this.itemButton06.UseVisualStyleBackColor = false;
            this.itemButton06.Visible = false;
            this.itemButton06.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton06.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            // 
            // itemButton07
            // 
            this.itemButton07.BackColor = System.Drawing.Color.Lime;
            this.itemButton07.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.itemButton07.Enabled = false;
            this.itemButton07.FlatAppearance.BorderSize = 0;
            this.itemButton07.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton07.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton07.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton07.Location = new System.Drawing.Point(387, 10);
            this.itemButton07.Name = "itemButton07";
            this.itemButton07.Size = new System.Drawing.Size(44, 44);
            this.itemButton07.TabIndex = 8;
            this.itemButton07.UseVisualStyleBackColor = false;
            this.itemButton07.Visible = false;
            this.itemButton07.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton07.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            // 
            // itemButton10
            // 
            this.itemButton10.BackColor = System.Drawing.Color.Lime;
            this.itemButton10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.itemButton10.Enabled = false;
            this.itemButton10.FlatAppearance.BorderSize = 0;
            this.itemButton10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton10.Location = new System.Drawing.Point(9, 64);
            this.itemButton10.Name = "itemButton10";
            this.itemButton10.Size = new System.Drawing.Size(44, 44);
            this.itemButton10.TabIndex = 9;
            this.itemButton10.UseVisualStyleBackColor = false;
            this.itemButton10.Visible = false;
            this.itemButton10.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton10.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            // 
            // itemButton20
            // 
            this.itemButton20.BackColor = System.Drawing.Color.Lime;
            this.itemButton20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.itemButton20.Enabled = false;
            this.itemButton20.FlatAppearance.BorderSize = 0;
            this.itemButton20.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton20.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton20.Location = new System.Drawing.Point(9, 118);
            this.itemButton20.Name = "itemButton20";
            this.itemButton20.Size = new System.Drawing.Size(44, 44);
            this.itemButton20.TabIndex = 10;
            this.itemButton20.UseVisualStyleBackColor = false;
            this.itemButton20.Visible = false;
            this.itemButton20.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton20.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            // 
            // itemButton30
            // 
            this.itemButton30.BackColor = System.Drawing.Color.Lime;
            this.itemButton30.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.itemButton30.Enabled = false;
            this.itemButton30.FlatAppearance.BorderSize = 0;
            this.itemButton30.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton30.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton30.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton30.Location = new System.Drawing.Point(9, 172);
            this.itemButton30.Name = "itemButton30";
            this.itemButton30.Size = new System.Drawing.Size(44, 44);
            this.itemButton30.TabIndex = 11;
            this.itemButton30.UseVisualStyleBackColor = false;
            this.itemButton30.Visible = false;
            this.itemButton30.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton30.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            // 
            // itemButton40
            // 
            this.itemButton40.BackColor = System.Drawing.Color.Lime;
            this.itemButton40.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.itemButton40.Enabled = false;
            this.itemButton40.FlatAppearance.BorderSize = 0;
            this.itemButton40.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton40.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton40.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton40.Location = new System.Drawing.Point(9, 226);
            this.itemButton40.Name = "itemButton40";
            this.itemButton40.Size = new System.Drawing.Size(44, 44);
            this.itemButton40.TabIndex = 12;
            this.itemButton40.UseVisualStyleBackColor = false;
            this.itemButton40.Visible = false;
            this.itemButton40.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton40.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            // 
            // itemButton50
            // 
            this.itemButton50.BackColor = System.Drawing.Color.Lime;
            this.itemButton50.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.itemButton50.Enabled = false;
            this.itemButton50.FlatAppearance.BorderSize = 0;
            this.itemButton50.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton50.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton50.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton50.Location = new System.Drawing.Point(9, 280);
            this.itemButton50.Name = "itemButton50";
            this.itemButton50.Size = new System.Drawing.Size(44, 44);
            this.itemButton50.TabIndex = 13;
            this.itemButton50.UseVisualStyleBackColor = false;
            this.itemButton50.Visible = false;
            this.itemButton50.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton50.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            // 
            // itemButton60
            // 
            this.itemButton60.BackColor = System.Drawing.Color.Lime;
            this.itemButton60.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.itemButton60.Enabled = false;
            this.itemButton60.FlatAppearance.BorderSize = 0;
            this.itemButton60.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton60.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton60.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton60.Location = new System.Drawing.Point(9, 334);
            this.itemButton60.Name = "itemButton60";
            this.itemButton60.Size = new System.Drawing.Size(44, 44);
            this.itemButton60.TabIndex = 14;
            this.itemButton60.UseVisualStyleBackColor = false;
            this.itemButton60.Visible = false;
            this.itemButton60.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton60.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            // 
            // itemButton70
            // 
            this.itemButton70.BackColor = System.Drawing.Color.Lime;
            this.itemButton70.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.itemButton70.Enabled = false;
            this.itemButton70.FlatAppearance.BorderSize = 0;
            this.itemButton70.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton70.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton70.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton70.Location = new System.Drawing.Point(9, 388);
            this.itemButton70.Name = "itemButton70";
            this.itemButton70.Size = new System.Drawing.Size(44, 44);
            this.itemButton70.TabIndex = 15;
            this.itemButton70.UseVisualStyleBackColor = false;
            this.itemButton70.Visible = false;
            this.itemButton70.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton70.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            // 
            // itemButton11
            // 
            this.itemButton11.BackColor = System.Drawing.Color.Lime;
            this.itemButton11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.itemButton11.Enabled = false;
            this.itemButton11.FlatAppearance.BorderSize = 0;
            this.itemButton11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton11.Location = new System.Drawing.Point(63, 64);
            this.itemButton11.Name = "itemButton11";
            this.itemButton11.Size = new System.Drawing.Size(44, 44);
            this.itemButton11.TabIndex = 16;
            this.itemButton11.UseVisualStyleBackColor = false;
            this.itemButton11.Visible = false;
            this.itemButton11.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton11.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            // 
            // itemButton12
            // 
            this.itemButton12.BackColor = System.Drawing.Color.Lime;
            this.itemButton12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.itemButton12.Enabled = false;
            this.itemButton12.FlatAppearance.BorderSize = 0;
            this.itemButton12.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton12.Location = new System.Drawing.Point(117, 64);
            this.itemButton12.Name = "itemButton12";
            this.itemButton12.Size = new System.Drawing.Size(44, 44);
            this.itemButton12.TabIndex = 17;
            this.itemButton12.UseVisualStyleBackColor = false;
            this.itemButton12.Visible = false;
            this.itemButton12.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton12.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            // 
            // itemButton13
            // 
            this.itemButton13.BackColor = System.Drawing.Color.Lime;
            this.itemButton13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.itemButton13.Enabled = false;
            this.itemButton13.FlatAppearance.BorderSize = 0;
            this.itemButton13.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton13.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton13.Location = new System.Drawing.Point(171, 64);
            this.itemButton13.Name = "itemButton13";
            this.itemButton13.Size = new System.Drawing.Size(44, 44);
            this.itemButton13.TabIndex = 18;
            this.itemButton13.UseVisualStyleBackColor = false;
            this.itemButton13.Visible = false;
            this.itemButton13.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton13.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            // 
            // itemButton14
            // 
            this.itemButton14.BackColor = System.Drawing.Color.Lime;
            this.itemButton14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.itemButton14.Enabled = false;
            this.itemButton14.FlatAppearance.BorderSize = 0;
            this.itemButton14.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton14.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton14.Location = new System.Drawing.Point(225, 64);
            this.itemButton14.Name = "itemButton14";
            this.itemButton14.Size = new System.Drawing.Size(44, 44);
            this.itemButton14.TabIndex = 19;
            this.itemButton14.UseVisualStyleBackColor = false;
            this.itemButton14.Visible = false;
            this.itemButton14.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton14.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            // 
            // itemButton15
            // 
            this.itemButton15.BackColor = System.Drawing.Color.Lime;
            this.itemButton15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.itemButton15.Enabled = false;
            this.itemButton15.FlatAppearance.BorderSize = 0;
            this.itemButton15.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton15.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton15.Location = new System.Drawing.Point(279, 64);
            this.itemButton15.Name = "itemButton15";
            this.itemButton15.Size = new System.Drawing.Size(44, 44);
            this.itemButton15.TabIndex = 20;
            this.itemButton15.UseVisualStyleBackColor = false;
            this.itemButton15.Visible = false;
            this.itemButton15.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton15.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            // 
            // itemButton16
            // 
            this.itemButton16.BackColor = System.Drawing.Color.Lime;
            this.itemButton16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.itemButton16.Enabled = false;
            this.itemButton16.FlatAppearance.BorderSize = 0;
            this.itemButton16.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton16.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton16.Location = new System.Drawing.Point(333, 64);
            this.itemButton16.Name = "itemButton16";
            this.itemButton16.Size = new System.Drawing.Size(44, 44);
            this.itemButton16.TabIndex = 21;
            this.itemButton16.UseVisualStyleBackColor = false;
            this.itemButton16.Visible = false;
            this.itemButton16.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton16.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            // 
            // itemButton17
            // 
            this.itemButton17.BackColor = System.Drawing.Color.Lime;
            this.itemButton17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.itemButton17.Enabled = false;
            this.itemButton17.FlatAppearance.BorderSize = 0;
            this.itemButton17.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton17.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton17.Location = new System.Drawing.Point(387, 64);
            this.itemButton17.Name = "itemButton17";
            this.itemButton17.Size = new System.Drawing.Size(44, 44);
            this.itemButton17.TabIndex = 22;
            this.itemButton17.UseVisualStyleBackColor = false;
            this.itemButton17.Visible = false;
            this.itemButton17.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton17.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            // 
            // itemButton21
            // 
            this.itemButton21.BackColor = System.Drawing.Color.Lime;
            this.itemButton21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.itemButton21.Enabled = false;
            this.itemButton21.FlatAppearance.BorderSize = 0;
            this.itemButton21.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton21.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton21.Location = new System.Drawing.Point(63, 118);
            this.itemButton21.Name = "itemButton21";
            this.itemButton21.Size = new System.Drawing.Size(44, 44);
            this.itemButton21.TabIndex = 23;
            this.itemButton21.UseVisualStyleBackColor = false;
            this.itemButton21.Visible = false;
            this.itemButton21.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton21.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            // 
            // itemButton22
            // 
            this.itemButton22.BackColor = System.Drawing.Color.Lime;
            this.itemButton22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.itemButton22.Enabled = false;
            this.itemButton22.FlatAppearance.BorderSize = 0;
            this.itemButton22.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton22.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton22.Location = new System.Drawing.Point(117, 118);
            this.itemButton22.Name = "itemButton22";
            this.itemButton22.Size = new System.Drawing.Size(44, 44);
            this.itemButton22.TabIndex = 24;
            this.itemButton22.UseVisualStyleBackColor = false;
            this.itemButton22.Visible = false;
            this.itemButton22.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton22.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            // 
            // itemButton23
            // 
            this.itemButton23.BackColor = System.Drawing.Color.Lime;
            this.itemButton23.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.itemButton23.Enabled = false;
            this.itemButton23.FlatAppearance.BorderSize = 0;
            this.itemButton23.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton23.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton23.Location = new System.Drawing.Point(171, 118);
            this.itemButton23.Name = "itemButton23";
            this.itemButton23.Size = new System.Drawing.Size(44, 44);
            this.itemButton23.TabIndex = 25;
            this.itemButton23.UseVisualStyleBackColor = false;
            this.itemButton23.Visible = false;
            this.itemButton23.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton23.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            // 
            // itemButton24
            // 
            this.itemButton24.BackColor = System.Drawing.Color.Lime;
            this.itemButton24.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.itemButton24.Enabled = false;
            this.itemButton24.FlatAppearance.BorderSize = 0;
            this.itemButton24.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton24.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton24.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton24.Location = new System.Drawing.Point(225, 118);
            this.itemButton24.Name = "itemButton24";
            this.itemButton24.Size = new System.Drawing.Size(44, 44);
            this.itemButton24.TabIndex = 26;
            this.itemButton24.UseVisualStyleBackColor = false;
            this.itemButton24.Visible = false;
            this.itemButton24.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton24.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            // 
            // itemButton25
            // 
            this.itemButton25.BackColor = System.Drawing.Color.Lime;
            this.itemButton25.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.itemButton25.Enabled = false;
            this.itemButton25.FlatAppearance.BorderSize = 0;
            this.itemButton25.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton25.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton25.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton25.Location = new System.Drawing.Point(279, 118);
            this.itemButton25.Name = "itemButton25";
            this.itemButton25.Size = new System.Drawing.Size(44, 44);
            this.itemButton25.TabIndex = 27;
            this.itemButton25.UseVisualStyleBackColor = false;
            this.itemButton25.Visible = false;
            this.itemButton25.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton25.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            // 
            // itemButton26
            // 
            this.itemButton26.BackColor = System.Drawing.Color.Lime;
            this.itemButton26.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.itemButton26.Enabled = false;
            this.itemButton26.FlatAppearance.BorderSize = 0;
            this.itemButton26.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton26.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton26.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton26.Location = new System.Drawing.Point(333, 118);
            this.itemButton26.Name = "itemButton26";
            this.itemButton26.Size = new System.Drawing.Size(44, 44);
            this.itemButton26.TabIndex = 28;
            this.itemButton26.UseVisualStyleBackColor = false;
            this.itemButton26.Visible = false;
            this.itemButton26.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton26.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            // 
            // itemButton27
            // 
            this.itemButton27.BackColor = System.Drawing.Color.Lime;
            this.itemButton27.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.itemButton27.Enabled = false;
            this.itemButton27.FlatAppearance.BorderSize = 0;
            this.itemButton27.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton27.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton27.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton27.Location = new System.Drawing.Point(387, 118);
            this.itemButton27.Name = "itemButton27";
            this.itemButton27.Size = new System.Drawing.Size(44, 44);
            this.itemButton27.TabIndex = 29;
            this.itemButton27.UseVisualStyleBackColor = false;
            this.itemButton27.Visible = false;
            this.itemButton27.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton27.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            // 
            // itemButton31
            // 
            this.itemButton31.BackColor = System.Drawing.Color.Lime;
            this.itemButton31.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.itemButton31.Enabled = false;
            this.itemButton31.FlatAppearance.BorderSize = 0;
            this.itemButton31.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton31.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton31.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton31.Location = new System.Drawing.Point(63, 172);
            this.itemButton31.Name = "itemButton31";
            this.itemButton31.Size = new System.Drawing.Size(44, 44);
            this.itemButton31.TabIndex = 30;
            this.itemButton31.UseVisualStyleBackColor = false;
            this.itemButton31.Visible = false;
            this.itemButton31.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton31.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            // 
            // itemButton32
            // 
            this.itemButton32.BackColor = System.Drawing.Color.Lime;
            this.itemButton32.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.itemButton32.Enabled = false;
            this.itemButton32.FlatAppearance.BorderSize = 0;
            this.itemButton32.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton32.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton32.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton32.Location = new System.Drawing.Point(117, 172);
            this.itemButton32.Name = "itemButton32";
            this.itemButton32.Size = new System.Drawing.Size(44, 44);
            this.itemButton32.TabIndex = 31;
            this.itemButton32.UseVisualStyleBackColor = false;
            this.itemButton32.Visible = false;
            this.itemButton32.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton32.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            // 
            // itemButton33
            // 
            this.itemButton33.BackColor = System.Drawing.Color.Lime;
            this.itemButton33.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.itemButton33.Enabled = false;
            this.itemButton33.FlatAppearance.BorderSize = 0;
            this.itemButton33.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton33.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton33.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton33.Location = new System.Drawing.Point(171, 172);
            this.itemButton33.Name = "itemButton33";
            this.itemButton33.Size = new System.Drawing.Size(44, 44);
            this.itemButton33.TabIndex = 32;
            this.itemButton33.UseVisualStyleBackColor = false;
            this.itemButton33.Visible = false;
            this.itemButton33.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton33.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            // 
            // itemButton34
            // 
            this.itemButton34.BackColor = System.Drawing.Color.Lime;
            this.itemButton34.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.itemButton34.Enabled = false;
            this.itemButton34.FlatAppearance.BorderSize = 0;
            this.itemButton34.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton34.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton34.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton34.Location = new System.Drawing.Point(225, 172);
            this.itemButton34.Name = "itemButton34";
            this.itemButton34.Size = new System.Drawing.Size(44, 44);
            this.itemButton34.TabIndex = 33;
            this.itemButton34.UseVisualStyleBackColor = false;
            this.itemButton34.Visible = false;
            this.itemButton34.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton34.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            // 
            // itemButton35
            // 
            this.itemButton35.BackColor = System.Drawing.Color.Lime;
            this.itemButton35.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.itemButton35.Enabled = false;
            this.itemButton35.FlatAppearance.BorderSize = 0;
            this.itemButton35.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton35.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton35.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton35.Location = new System.Drawing.Point(279, 172);
            this.itemButton35.Name = "itemButton35";
            this.itemButton35.Size = new System.Drawing.Size(44, 44);
            this.itemButton35.TabIndex = 34;
            this.itemButton35.UseVisualStyleBackColor = false;
            this.itemButton35.Visible = false;
            this.itemButton35.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton35.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            // 
            // itemButton36
            // 
            this.itemButton36.BackColor = System.Drawing.Color.Lime;
            this.itemButton36.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.itemButton36.Enabled = false;
            this.itemButton36.FlatAppearance.BorderSize = 0;
            this.itemButton36.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton36.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton36.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton36.Location = new System.Drawing.Point(333, 172);
            this.itemButton36.Name = "itemButton36";
            this.itemButton36.Size = new System.Drawing.Size(44, 44);
            this.itemButton36.TabIndex = 35;
            this.itemButton36.UseVisualStyleBackColor = false;
            this.itemButton36.Visible = false;
            this.itemButton36.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton36.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            // 
            // itemButton37
            // 
            this.itemButton37.BackColor = System.Drawing.Color.Lime;
            this.itemButton37.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.itemButton37.Enabled = false;
            this.itemButton37.FlatAppearance.BorderSize = 0;
            this.itemButton37.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton37.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton37.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton37.Location = new System.Drawing.Point(387, 172);
            this.itemButton37.Name = "itemButton37";
            this.itemButton37.Size = new System.Drawing.Size(44, 44);
            this.itemButton37.TabIndex = 36;
            this.itemButton37.UseVisualStyleBackColor = false;
            this.itemButton37.Visible = false;
            this.itemButton37.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton37.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            // 
            // itemButton41
            // 
            this.itemButton41.BackColor = System.Drawing.Color.Lime;
            this.itemButton41.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.itemButton41.Enabled = false;
            this.itemButton41.FlatAppearance.BorderSize = 0;
            this.itemButton41.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton41.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton41.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton41.Location = new System.Drawing.Point(63, 226);
            this.itemButton41.Name = "itemButton41";
            this.itemButton41.Size = new System.Drawing.Size(44, 44);
            this.itemButton41.TabIndex = 37;
            this.itemButton41.UseVisualStyleBackColor = false;
            this.itemButton41.Visible = false;
            this.itemButton41.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton41.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            // 
            // itemButton42
            // 
            this.itemButton42.BackColor = System.Drawing.Color.Lime;
            this.itemButton42.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.itemButton42.Enabled = false;
            this.itemButton42.FlatAppearance.BorderSize = 0;
            this.itemButton42.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton42.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton42.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton42.Location = new System.Drawing.Point(117, 226);
            this.itemButton42.Name = "itemButton42";
            this.itemButton42.Size = new System.Drawing.Size(44, 44);
            this.itemButton42.TabIndex = 38;
            this.itemButton42.UseVisualStyleBackColor = false;
            this.itemButton42.Visible = false;
            this.itemButton42.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton42.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            // 
            // itemButton43
            // 
            this.itemButton43.BackColor = System.Drawing.Color.Lime;
            this.itemButton43.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.itemButton43.Enabled = false;
            this.itemButton43.FlatAppearance.BorderSize = 0;
            this.itemButton43.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton43.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton43.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton43.Location = new System.Drawing.Point(171, 226);
            this.itemButton43.Name = "itemButton43";
            this.itemButton43.Size = new System.Drawing.Size(44, 44);
            this.itemButton43.TabIndex = 39;
            this.itemButton43.UseVisualStyleBackColor = false;
            this.itemButton43.Visible = false;
            this.itemButton43.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton43.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            // 
            // itemButton44
            // 
            this.itemButton44.BackColor = System.Drawing.Color.Lime;
            this.itemButton44.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.itemButton44.Enabled = false;
            this.itemButton44.FlatAppearance.BorderSize = 0;
            this.itemButton44.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton44.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton44.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton44.Location = new System.Drawing.Point(225, 226);
            this.itemButton44.Name = "itemButton44";
            this.itemButton44.Size = new System.Drawing.Size(44, 44);
            this.itemButton44.TabIndex = 40;
            this.itemButton44.UseVisualStyleBackColor = false;
            this.itemButton44.Visible = false;
            this.itemButton44.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton44.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            // 
            // itemButton45
            // 
            this.itemButton45.BackColor = System.Drawing.Color.Lime;
            this.itemButton45.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.itemButton45.Enabled = false;
            this.itemButton45.FlatAppearance.BorderSize = 0;
            this.itemButton45.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton45.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton45.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton45.Location = new System.Drawing.Point(279, 226);
            this.itemButton45.Name = "itemButton45";
            this.itemButton45.Size = new System.Drawing.Size(44, 44);
            this.itemButton45.TabIndex = 41;
            this.itemButton45.UseVisualStyleBackColor = false;
            this.itemButton45.Visible = false;
            this.itemButton45.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton45.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            // 
            // itemButton46
            // 
            this.itemButton46.BackColor = System.Drawing.Color.Lime;
            this.itemButton46.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.itemButton46.Enabled = false;
            this.itemButton46.FlatAppearance.BorderSize = 0;
            this.itemButton46.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton46.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton46.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton46.Location = new System.Drawing.Point(333, 226);
            this.itemButton46.Name = "itemButton46";
            this.itemButton46.Size = new System.Drawing.Size(44, 44);
            this.itemButton46.TabIndex = 42;
            this.itemButton46.UseVisualStyleBackColor = false;
            this.itemButton46.Visible = false;
            this.itemButton46.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton46.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            // 
            // itemButton47
            // 
            this.itemButton47.BackColor = System.Drawing.Color.Lime;
            this.itemButton47.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.itemButton47.Enabled = false;
            this.itemButton47.FlatAppearance.BorderSize = 0;
            this.itemButton47.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton47.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton47.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton47.Location = new System.Drawing.Point(387, 226);
            this.itemButton47.Name = "itemButton47";
            this.itemButton47.Size = new System.Drawing.Size(44, 44);
            this.itemButton47.TabIndex = 43;
            this.itemButton47.UseVisualStyleBackColor = false;
            this.itemButton47.Visible = false;
            this.itemButton47.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton47.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            // 
            // itemButton51
            // 
            this.itemButton51.BackColor = System.Drawing.Color.Lime;
            this.itemButton51.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.itemButton51.Enabled = false;
            this.itemButton51.FlatAppearance.BorderSize = 0;
            this.itemButton51.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton51.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton51.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton51.Location = new System.Drawing.Point(63, 280);
            this.itemButton51.Name = "itemButton51";
            this.itemButton51.Size = new System.Drawing.Size(44, 44);
            this.itemButton51.TabIndex = 44;
            this.itemButton51.UseVisualStyleBackColor = false;
            this.itemButton51.Visible = false;
            this.itemButton51.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton51.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            // 
            // itemButton52
            // 
            this.itemButton52.BackColor = System.Drawing.Color.Lime;
            this.itemButton52.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.itemButton52.Enabled = false;
            this.itemButton52.FlatAppearance.BorderSize = 0;
            this.itemButton52.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton52.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton52.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton52.Location = new System.Drawing.Point(117, 280);
            this.itemButton52.Name = "itemButton52";
            this.itemButton52.Size = new System.Drawing.Size(44, 44);
            this.itemButton52.TabIndex = 45;
            this.itemButton52.UseVisualStyleBackColor = false;
            this.itemButton52.Visible = false;
            this.itemButton52.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton52.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            // 
            // itemButton53
            // 
            this.itemButton53.BackColor = System.Drawing.Color.Lime;
            this.itemButton53.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.itemButton53.Enabled = false;
            this.itemButton53.FlatAppearance.BorderSize = 0;
            this.itemButton53.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton53.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton53.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton53.Location = new System.Drawing.Point(171, 280);
            this.itemButton53.Name = "itemButton53";
            this.itemButton53.Size = new System.Drawing.Size(44, 44);
            this.itemButton53.TabIndex = 46;
            this.itemButton53.UseVisualStyleBackColor = false;
            this.itemButton53.Visible = false;
            this.itemButton53.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton53.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            // 
            // itemButton54
            // 
            this.itemButton54.BackColor = System.Drawing.Color.Lime;
            this.itemButton54.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.itemButton54.Enabled = false;
            this.itemButton54.FlatAppearance.BorderSize = 0;
            this.itemButton54.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton54.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton54.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton54.Location = new System.Drawing.Point(225, 280);
            this.itemButton54.Name = "itemButton54";
            this.itemButton54.Size = new System.Drawing.Size(44, 44);
            this.itemButton54.TabIndex = 47;
            this.itemButton54.UseVisualStyleBackColor = false;
            this.itemButton54.Visible = false;
            this.itemButton54.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton54.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            // 
            // itemButton55
            // 
            this.itemButton55.BackColor = System.Drawing.Color.Lime;
            this.itemButton55.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.itemButton55.Enabled = false;
            this.itemButton55.FlatAppearance.BorderSize = 0;
            this.itemButton55.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton55.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton55.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton55.Location = new System.Drawing.Point(279, 280);
            this.itemButton55.Name = "itemButton55";
            this.itemButton55.Size = new System.Drawing.Size(44, 44);
            this.itemButton55.TabIndex = 48;
            this.itemButton55.UseVisualStyleBackColor = false;
            this.itemButton55.Visible = false;
            this.itemButton55.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton55.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            // 
            // itemButton56
            // 
            this.itemButton56.BackColor = System.Drawing.Color.Lime;
            this.itemButton56.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.itemButton56.Enabled = false;
            this.itemButton56.FlatAppearance.BorderSize = 0;
            this.itemButton56.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton56.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton56.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton56.Location = new System.Drawing.Point(333, 280);
            this.itemButton56.Name = "itemButton56";
            this.itemButton56.Size = new System.Drawing.Size(44, 44);
            this.itemButton56.TabIndex = 49;
            this.itemButton56.UseVisualStyleBackColor = false;
            this.itemButton56.Visible = false;
            this.itemButton56.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton56.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            // 
            // itemButton57
            // 
            this.itemButton57.BackColor = System.Drawing.Color.Lime;
            this.itemButton57.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.itemButton57.Enabled = false;
            this.itemButton57.FlatAppearance.BorderSize = 0;
            this.itemButton57.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton57.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton57.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton57.Location = new System.Drawing.Point(387, 280);
            this.itemButton57.Name = "itemButton57";
            this.itemButton57.Size = new System.Drawing.Size(44, 44);
            this.itemButton57.TabIndex = 50;
            this.itemButton57.UseVisualStyleBackColor = false;
            this.itemButton57.Visible = false;
            this.itemButton57.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton57.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            // 
            // itemButton61
            // 
            this.itemButton61.BackColor = System.Drawing.Color.Lime;
            this.itemButton61.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.itemButton61.Enabled = false;
            this.itemButton61.FlatAppearance.BorderSize = 0;
            this.itemButton61.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton61.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton61.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton61.Location = new System.Drawing.Point(63, 334);
            this.itemButton61.Name = "itemButton61";
            this.itemButton61.Size = new System.Drawing.Size(44, 44);
            this.itemButton61.TabIndex = 51;
            this.itemButton61.UseVisualStyleBackColor = false;
            this.itemButton61.Visible = false;
            this.itemButton61.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton61.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            // 
            // itemButton62
            // 
            this.itemButton62.BackColor = System.Drawing.Color.Lime;
            this.itemButton62.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.itemButton62.Enabled = false;
            this.itemButton62.FlatAppearance.BorderSize = 0;
            this.itemButton62.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton62.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton62.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton62.Location = new System.Drawing.Point(117, 334);
            this.itemButton62.Name = "itemButton62";
            this.itemButton62.Size = new System.Drawing.Size(44, 44);
            this.itemButton62.TabIndex = 52;
            this.itemButton62.UseVisualStyleBackColor = false;
            this.itemButton62.Visible = false;
            this.itemButton62.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton62.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            // 
            // itemButton63
            // 
            this.itemButton63.BackColor = System.Drawing.Color.Lime;
            this.itemButton63.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.itemButton63.Enabled = false;
            this.itemButton63.FlatAppearance.BorderSize = 0;
            this.itemButton63.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton63.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton63.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton63.Location = new System.Drawing.Point(171, 334);
            this.itemButton63.Name = "itemButton63";
            this.itemButton63.Size = new System.Drawing.Size(44, 44);
            this.itemButton63.TabIndex = 53;
            this.itemButton63.UseVisualStyleBackColor = false;
            this.itemButton63.Visible = false;
            this.itemButton63.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton63.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            // 
            // itemButton64
            // 
            this.itemButton64.BackColor = System.Drawing.Color.Lime;
            this.itemButton64.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.itemButton64.Enabled = false;
            this.itemButton64.FlatAppearance.BorderSize = 0;
            this.itemButton64.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton64.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton64.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton64.Location = new System.Drawing.Point(225, 334);
            this.itemButton64.Name = "itemButton64";
            this.itemButton64.Size = new System.Drawing.Size(44, 44);
            this.itemButton64.TabIndex = 54;
            this.itemButton64.UseVisualStyleBackColor = false;
            this.itemButton64.Visible = false;
            this.itemButton64.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton64.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            // 
            // itemButton65
            // 
            this.itemButton65.BackColor = System.Drawing.Color.Lime;
            this.itemButton65.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.itemButton65.Enabled = false;
            this.itemButton65.FlatAppearance.BorderSize = 0;
            this.itemButton65.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton65.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton65.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton65.Location = new System.Drawing.Point(279, 334);
            this.itemButton65.Name = "itemButton65";
            this.itemButton65.Size = new System.Drawing.Size(44, 44);
            this.itemButton65.TabIndex = 55;
            this.itemButton65.UseVisualStyleBackColor = false;
            this.itemButton65.Visible = false;
            this.itemButton65.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton65.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            // 
            // itemButton66
            // 
            this.itemButton66.BackColor = System.Drawing.Color.Lime;
            this.itemButton66.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.itemButton66.Enabled = false;
            this.itemButton66.FlatAppearance.BorderSize = 0;
            this.itemButton66.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton66.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton66.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton66.Location = new System.Drawing.Point(333, 334);
            this.itemButton66.Name = "itemButton66";
            this.itemButton66.Size = new System.Drawing.Size(44, 44);
            this.itemButton66.TabIndex = 56;
            this.itemButton66.UseVisualStyleBackColor = false;
            this.itemButton66.Visible = false;
            this.itemButton66.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton66.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            // 
            // itemButton67
            // 
            this.itemButton67.BackColor = System.Drawing.Color.Lime;
            this.itemButton67.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.itemButton67.Enabled = false;
            this.itemButton67.FlatAppearance.BorderSize = 0;
            this.itemButton67.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton67.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton67.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton67.Location = new System.Drawing.Point(387, 334);
            this.itemButton67.Name = "itemButton67";
            this.itemButton67.Size = new System.Drawing.Size(44, 44);
            this.itemButton67.TabIndex = 57;
            this.itemButton67.UseVisualStyleBackColor = false;
            this.itemButton67.Visible = false;
            this.itemButton67.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton67.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            // 
            // itemButton71
            // 
            this.itemButton71.BackColor = System.Drawing.Color.Lime;
            this.itemButton71.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.itemButton71.Enabled = false;
            this.itemButton71.FlatAppearance.BorderSize = 0;
            this.itemButton71.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton71.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton71.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton71.Location = new System.Drawing.Point(63, 388);
            this.itemButton71.Name = "itemButton71";
            this.itemButton71.Size = new System.Drawing.Size(44, 44);
            this.itemButton71.TabIndex = 58;
            this.itemButton71.UseVisualStyleBackColor = false;
            this.itemButton71.Visible = false;
            this.itemButton71.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton71.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            // 
            // itemButton72
            // 
            this.itemButton72.BackColor = System.Drawing.Color.Lime;
            this.itemButton72.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.itemButton72.Enabled = false;
            this.itemButton72.FlatAppearance.BorderSize = 0;
            this.itemButton72.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton72.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton72.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton72.Location = new System.Drawing.Point(117, 388);
            this.itemButton72.Name = "itemButton72";
            this.itemButton72.Size = new System.Drawing.Size(44, 44);
            this.itemButton72.TabIndex = 59;
            this.itemButton72.UseVisualStyleBackColor = false;
            this.itemButton72.Visible = false;
            this.itemButton72.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton72.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            // 
            // itemButton73
            // 
            this.itemButton73.BackColor = System.Drawing.Color.Lime;
            this.itemButton73.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.itemButton73.Enabled = false;
            this.itemButton73.FlatAppearance.BorderSize = 0;
            this.itemButton73.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton73.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton73.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton73.Location = new System.Drawing.Point(171, 388);
            this.itemButton73.Name = "itemButton73";
            this.itemButton73.Size = new System.Drawing.Size(44, 44);
            this.itemButton73.TabIndex = 60;
            this.itemButton73.UseVisualStyleBackColor = false;
            this.itemButton73.Visible = false;
            this.itemButton73.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton73.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            // 
            // itemButton74
            // 
            this.itemButton74.BackColor = System.Drawing.Color.Lime;
            this.itemButton74.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.itemButton74.Enabled = false;
            this.itemButton74.FlatAppearance.BorderSize = 0;
            this.itemButton74.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton74.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton74.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton74.Location = new System.Drawing.Point(225, 388);
            this.itemButton74.Name = "itemButton74";
            this.itemButton74.Size = new System.Drawing.Size(44, 44);
            this.itemButton74.TabIndex = 61;
            this.itemButton74.UseVisualStyleBackColor = false;
            this.itemButton74.Visible = false;
            this.itemButton74.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton74.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            // 
            // itemButton75
            // 
            this.itemButton75.BackColor = System.Drawing.Color.Lime;
            this.itemButton75.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.itemButton75.Enabled = false;
            this.itemButton75.FlatAppearance.BorderSize = 0;
            this.itemButton75.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton75.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton75.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton75.Location = new System.Drawing.Point(279, 388);
            this.itemButton75.Name = "itemButton75";
            this.itemButton75.Size = new System.Drawing.Size(44, 44);
            this.itemButton75.TabIndex = 62;
            this.itemButton75.UseVisualStyleBackColor = false;
            this.itemButton75.Visible = false;
            this.itemButton75.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton75.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            // 
            // itemButton76
            // 
            this.itemButton76.BackColor = System.Drawing.Color.Lime;
            this.itemButton76.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.itemButton76.Enabled = false;
            this.itemButton76.FlatAppearance.BorderSize = 0;
            this.itemButton76.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton76.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton76.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton76.Location = new System.Drawing.Point(333, 388);
            this.itemButton76.Name = "itemButton76";
            this.itemButton76.Size = new System.Drawing.Size(44, 44);
            this.itemButton76.TabIndex = 63;
            this.itemButton76.UseVisualStyleBackColor = false;
            this.itemButton76.Visible = false;
            this.itemButton76.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton76.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            // 
            // itemButton77
            // 
            this.itemButton77.BackColor = System.Drawing.Color.Lime;
            this.itemButton77.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.itemButton77.Enabled = false;
            this.itemButton77.FlatAppearance.BorderSize = 0;
            this.itemButton77.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton77.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton77.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton77.Location = new System.Drawing.Point(387, 388);
            this.itemButton77.Name = "itemButton77";
            this.itemButton77.Size = new System.Drawing.Size(44, 44);
            this.itemButton77.TabIndex = 64;
            this.itemButton77.UseVisualStyleBackColor = false;
            this.itemButton77.Visible = false;
            this.itemButton77.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton77.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            // 
            // analyzeButton
            // 
            this.analyzeButton.BackColor = System.Drawing.Color.Pink;
            this.analyzeButton.FlatAppearance.BorderSize = 0;
            this.analyzeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepPink;
            this.analyzeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.HotPink;
            this.analyzeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.analyzeButton.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.analyzeButton.Location = new System.Drawing.Point(151, 438);
            this.analyzeButton.Name = "analyzeButton";
            this.analyzeButton.Size = new System.Drawing.Size(137, 31);
            this.analyzeButton.TabIndex = 65;
            this.analyzeButton.Text = "Analyze";
            this.analyzeButton.UseVisualStyleBackColor = false;
            this.analyzeButton.Click += new System.EventHandler(this.analyzeButton_Click);
            // 
            // thread1
            // 
            this.thread1.WorkerReportsProgress = true;
            this.thread1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.thread1_DoWork);
            this.thread1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.thread1_ProgressChanged);
            this.thread1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.thread1_RunWorkerCompleted);
            // 
            // thread2
            // 
            this.thread2.WorkerReportsProgress = true;
            this.thread2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.thread2_DoWork);
            this.thread2.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.thread2_ProgressChanged);
            this.thread2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.thread2_RunWorkerCompleted);
            // 
            // thread3
            // 
            this.thread3.WorkerReportsProgress = true;
            this.thread3.DoWork += new System.ComponentModel.DoWorkEventHandler(this.thread3_DoWork);
            this.thread3.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.thread3_ProgressChanged);
            this.thread3.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.thread3_RunWorkerCompleted);
            // 
            // thread4
            // 
            this.thread4.WorkerReportsProgress = true;
            this.thread4.DoWork += new System.ComponentModel.DoWorkEventHandler(this.thread4_DoWork);
            this.thread4.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.thread4_ProgressChanged);
            this.thread4.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.thread4_RunWorkerCompleted);
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.Color.Pink;
            this.settingsButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("settingsButton.BackgroundImage")));
            this.settingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.settingsButton.FlatAppearance.BorderSize = 0;
            this.settingsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepPink;
            this.settingsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.HotPink;
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsButton.Location = new System.Drawing.Point(6, 477);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(31, 31);
            this.settingsButton.TabIndex = 72;
            this.settingsButton.UseVisualStyleBackColor = false;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.infoLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel.ForeColor = System.Drawing.Color.White;
            this.infoLabel.Location = new System.Drawing.Point(747, 222);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(164, 45);
            this.infoLabel.TabIndex = 69;
            this.infoLabel.Text = "Select your grinding location\r\nand Analyze to start a new \r\ngrinding session.";
            this.infoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // playPauseButton
            // 
            this.playPauseButton.BackColor = System.Drawing.Color.Pink;
            this.playPauseButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("playPauseButton.BackgroundImage")));
            this.playPauseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playPauseButton.Enabled = false;
            this.playPauseButton.FlatAppearance.BorderSize = 0;
            this.playPauseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepPink;
            this.playPauseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.HotPink;
            this.playPauseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playPauseButton.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playPauseButton.Location = new System.Drawing.Point(762, 29);
            this.playPauseButton.Name = "playPauseButton";
            this.playPauseButton.Size = new System.Drawing.Size(24, 24);
            this.playPauseButton.TabIndex = 68;
            this.playPauseButton.UseVisualStyleBackColor = false;
            this.playPauseButton.Visible = false;
            this.playPauseButton.Click += new System.EventHandler(this.playPauseButton_Click);
            // 
            // endSessionButton
            // 
            this.endSessionButton.BackColor = System.Drawing.Color.Pink;
            this.endSessionButton.Enabled = false;
            this.endSessionButton.FlatAppearance.BorderSize = 0;
            this.endSessionButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepPink;
            this.endSessionButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.HotPink;
            this.endSessionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.endSessionButton.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endSessionButton.Location = new System.Drawing.Point(781, 103);
            this.endSessionButton.Name = "endSessionButton";
            this.endSessionButton.Size = new System.Drawing.Size(126, 31);
            this.endSessionButton.TabIndex = 67;
            this.endSessionButton.Text = "End and Autofill";
            this.endSessionButton.UseVisualStyleBackColor = false;
            this.endSessionButton.Click += new System.EventHandler(this.endSessionButton_Click);
            // 
            // clearSessionButton
            // 
            this.clearSessionButton.BackColor = System.Drawing.Color.Pink;
            this.clearSessionButton.Enabled = false;
            this.clearSessionButton.FlatAppearance.BorderSize = 0;
            this.clearSessionButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepPink;
            this.clearSessionButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.HotPink;
            this.clearSessionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearSessionButton.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearSessionButton.Location = new System.Drawing.Point(781, 66);
            this.clearSessionButton.Name = "clearSessionButton";
            this.clearSessionButton.Size = new System.Drawing.Size(126, 31);
            this.clearSessionButton.TabIndex = 66;
            this.clearSessionButton.Text = "Reset Session";
            this.clearSessionButton.UseVisualStyleBackColor = false;
            this.clearSessionButton.Click += new System.EventHandler(this.clearSessionButton_Click);
            // 
            // locationBox
            // 
            this.locationBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.locationBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.locationBox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationBox.FormattingEnabled = true;
            this.locationBox.Location = new System.Drawing.Point(481, 7);
            this.locationBox.Name = "locationBox";
            this.locationBox.Size = new System.Drawing.Size(264, 26);
            this.locationBox.TabIndex = 3;
            this.locationBox.SelectedIndexChanged += new System.EventHandler(this.locationBox_SelectedIndexChanged);
            // 
            // itemPanel
            // 
            this.itemPanel.AutoScroll = true;
            this.itemPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.itemPanel.ForeColor = System.Drawing.Color.Black;
            this.itemPanel.Location = new System.Drawing.Point(481, 45);
            this.itemPanel.Name = "itemPanel";
            this.itemPanel.Size = new System.Drawing.Size(264, 463);
            this.itemPanel.TabIndex = 2;
            // 
            // timerLabelLabel
            // 
            this.timerLabelLabel.AutoSize = true;
            this.timerLabelLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.timerLabelLabel.ForeColor = System.Drawing.Color.White;
            this.timerLabelLabel.Location = new System.Drawing.Point(776, 7);
            this.timerLabelLabel.Name = "timerLabelLabel";
            this.timerLabelLabel.Size = new System.Drawing.Size(136, 13);
            this.timerLabelLabel.TabIndex = 1;
            this.timerLabelLabel.Text = "Elapsed time in this session";
            this.timerLabelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.timerLabel.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerLabel.ForeColor = System.Drawing.Color.White;
            this.timerLabel.Location = new System.Drawing.Point(791, 19);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(126, 42);
            this.timerLabel.TabIndex = 0;
            this.timerLabel.Text = "0:00:00";
            this.timerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // toolTip
            // 
            this.toolTip.AutomaticDelay = 250;
            this.toolTip.AutoPopDelay = 5000;
            this.toolTip.InitialDelay = 250;
            this.toolTip.ReshowDelay = 50;
            // 
            // gameOptionsWatcher
            // 
            this.gameOptionsWatcher.EnableRaisingEvents = true;
            this.gameOptionsWatcher.Filter = "GameOption.txt";
            this.gameOptionsWatcher.NotifyFilter = System.IO.NotifyFilters.LastWrite;
            this.gameOptionsWatcher.SynchronizingObject = this;
            this.gameOptionsWatcher.Changed += new System.IO.FileSystemEventHandler(this.gameOptionsWatcher_Changed);
            // 
            // inventoryHighlights
            // 
            this.inventoryHighlights.Enabled = false;
            this.inventoryHighlights.Image = ((System.Drawing.Image)(resources.GetObject("inventoryHighlights.Image")));
            this.inventoryHighlights.Location = new System.Drawing.Point(9, 10);
            this.inventoryHighlights.Name = "inventoryHighlights";
            this.inventoryHighlights.Size = new System.Drawing.Size(422, 422);
            this.inventoryHighlights.TabIndex = 73;
            this.inventoryHighlights.TabStop = false;
            this.inventoryHighlights.Visible = false;
            // 
            // badScaleLabel
            // 
            this.badScaleLabel.AutoSize = true;
            this.badScaleLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.badScaleLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.badScaleLabel.ForeColor = System.Drawing.Color.White;
            this.badScaleLabel.Location = new System.Drawing.Point(112, 475);
            this.badScaleLabel.Name = "badScaleLabel";
            this.badScaleLabel.Size = new System.Drawing.Size(214, 19);
            this.badScaleLabel.TabIndex = 74;
            this.badScaleLabel.Text = "Please set your UI Scale to 100!";
            this.badScaleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.badScaleLabel.Visible = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(916, 514);
            this.Controls.Add(this.badScaleLabel);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.playPauseButton);
            this.Controls.Add(this.endSessionButton);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.clearSessionButton);
            this.Controls.Add(this.analyzeButton);
            this.Controls.Add(this.locationBox);
            this.Controls.Add(this.itemPanel);
            this.Controls.Add(this.itemButton77);
            this.Controls.Add(this.timerLabelLabel);
            this.Controls.Add(this.itemButton76);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.itemButton75);
            this.Controls.Add(this.itemButton74);
            this.Controls.Add(this.itemButton73);
            this.Controls.Add(this.itemButton72);
            this.Controls.Add(this.itemButton71);
            this.Controls.Add(this.itemButton67);
            this.Controls.Add(this.itemButton66);
            this.Controls.Add(this.itemButton65);
            this.Controls.Add(this.itemButton64);
            this.Controls.Add(this.itemButton63);
            this.Controls.Add(this.itemButton62);
            this.Controls.Add(this.itemButton61);
            this.Controls.Add(this.itemButton57);
            this.Controls.Add(this.itemButton56);
            this.Controls.Add(this.itemButton55);
            this.Controls.Add(this.itemButton54);
            this.Controls.Add(this.itemButton53);
            this.Controls.Add(this.itemButton52);
            this.Controls.Add(this.itemButton51);
            this.Controls.Add(this.itemButton47);
            this.Controls.Add(this.itemButton46);
            this.Controls.Add(this.itemButton45);
            this.Controls.Add(this.itemButton44);
            this.Controls.Add(this.itemButton43);
            this.Controls.Add(this.itemButton42);
            this.Controls.Add(this.itemButton41);
            this.Controls.Add(this.itemButton37);
            this.Controls.Add(this.itemButton36);
            this.Controls.Add(this.itemButton35);
            this.Controls.Add(this.itemButton34);
            this.Controls.Add(this.itemButton33);
            this.Controls.Add(this.itemButton32);
            this.Controls.Add(this.itemButton31);
            this.Controls.Add(this.itemButton27);
            this.Controls.Add(this.itemButton26);
            this.Controls.Add(this.itemButton25);
            this.Controls.Add(this.itemButton24);
            this.Controls.Add(this.itemButton23);
            this.Controls.Add(this.itemButton22);
            this.Controls.Add(this.itemButton21);
            this.Controls.Add(this.itemButton17);
            this.Controls.Add(this.itemButton16);
            this.Controls.Add(this.itemButton15);
            this.Controls.Add(this.itemButton14);
            this.Controls.Add(this.itemButton13);
            this.Controls.Add(this.itemButton12);
            this.Controls.Add(this.itemButton11);
            this.Controls.Add(this.itemButton70);
            this.Controls.Add(this.itemButton60);
            this.Controls.Add(this.itemButton50);
            this.Controls.Add(this.itemButton40);
            this.Controls.Add(this.itemButton30);
            this.Controls.Add(this.itemButton20);
            this.Controls.Add(this.itemButton10);
            this.Controls.Add(this.itemButton07);
            this.Controls.Add(this.itemButton06);
            this.Controls.Add(this.itemButton05);
            this.Controls.Add(this.itemButton04);
            this.Controls.Add(this.itemButton03);
            this.Controls.Add(this.itemButton02);
            this.Controls.Add(this.itemButton01);
            this.Controls.Add(this.itemButton00);
            this.Controls.Add(this.loadingBar);
            this.Controls.Add(this.inventoryHighlights);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Garmoth Autofiller";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gameOptionsWatcher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryHighlights)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar loadingBar;
        private System.Windows.Forms.Button itemButton00;
        private System.Windows.Forms.Button itemButton01;
        private System.Windows.Forms.Button itemButton02;
        private System.Windows.Forms.Button itemButton03;
        private System.Windows.Forms.Button itemButton04;
        private System.Windows.Forms.Button itemButton05;
        private System.Windows.Forms.Button itemButton06;
        private System.Windows.Forms.Button itemButton07;
        private System.Windows.Forms.Button itemButton10;
        private System.Windows.Forms.Button itemButton20;
        private System.Windows.Forms.Button itemButton30;
        private System.Windows.Forms.Button itemButton40;
        private System.Windows.Forms.Button itemButton50;
        private System.Windows.Forms.Button itemButton60;
        private System.Windows.Forms.Button itemButton70;
        private System.Windows.Forms.Button itemButton11;
        private System.Windows.Forms.Button itemButton12;
        private System.Windows.Forms.Button itemButton13;
        private System.Windows.Forms.Button itemButton14;
        private System.Windows.Forms.Button itemButton15;
        private System.Windows.Forms.Button itemButton16;
        private System.Windows.Forms.Button itemButton17;
        private System.Windows.Forms.Button itemButton21;
        private System.Windows.Forms.Button itemButton22;
        private System.Windows.Forms.Button itemButton23;
        private System.Windows.Forms.Button itemButton24;
        private System.Windows.Forms.Button itemButton25;
        private System.Windows.Forms.Button itemButton26;
        private System.Windows.Forms.Button itemButton27;
        private System.Windows.Forms.Button itemButton31;
        private System.Windows.Forms.Button itemButton32;
        private System.Windows.Forms.Button itemButton33;
        private System.Windows.Forms.Button itemButton34;
        private System.Windows.Forms.Button itemButton35;
        private System.Windows.Forms.Button itemButton36;
        private System.Windows.Forms.Button itemButton37;
        private System.Windows.Forms.Button itemButton41;
        private System.Windows.Forms.Button itemButton42;
        private System.Windows.Forms.Button itemButton43;
        private System.Windows.Forms.Button itemButton44;
        private System.Windows.Forms.Button itemButton45;
        private System.Windows.Forms.Button itemButton46;
        private System.Windows.Forms.Button itemButton47;
        private System.Windows.Forms.Button itemButton51;
        private System.Windows.Forms.Button itemButton52;
        private System.Windows.Forms.Button itemButton53;
        private System.Windows.Forms.Button itemButton54;
        private System.Windows.Forms.Button itemButton55;
        private System.Windows.Forms.Button itemButton56;
        private System.Windows.Forms.Button itemButton57;
        private System.Windows.Forms.Button itemButton61;
        private System.Windows.Forms.Button itemButton62;
        private System.Windows.Forms.Button itemButton63;
        private System.Windows.Forms.Button itemButton64;
        private System.Windows.Forms.Button itemButton65;
        private System.Windows.Forms.Button itemButton66;
        private System.Windows.Forms.Button itemButton67;
        private System.Windows.Forms.Button itemButton71;
        private System.Windows.Forms.Button itemButton72;
        private System.Windows.Forms.Button itemButton73;
        private System.Windows.Forms.Button itemButton74;
        private System.Windows.Forms.Button itemButton75;
        private System.Windows.Forms.Button itemButton76;
        private System.Windows.Forms.Button itemButton77;
        private System.Windows.Forms.Button analyzeButton;
        private System.ComponentModel.BackgroundWorker thread1;
        private System.ComponentModel.BackgroundWorker thread2;
        private System.ComponentModel.BackgroundWorker thread3;
        private System.ComponentModel.BackgroundWorker thread4;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label timerLabelLabel;
        private System.Windows.Forms.FlowLayoutPanel itemPanel;
        private System.Windows.Forms.ComboBox locationBox;
        private System.Windows.Forms.Button endSessionButton;
        private System.Windows.Forms.Button clearSessionButton;
        private System.Windows.Forms.Button playPauseButton;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.IO.FileSystemWatcher gameOptionsWatcher;
        private System.Windows.Forms.PictureBox inventoryHighlights;
        private System.Windows.Forms.Label badScaleLabel;
    }
}

