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
            this.categoryOverviewLabel = new System.Windows.Forms.Label();
            this.categoryOverviewList = new System.Windows.Forms.ListBox();
            this.itemOrganization = new System.Windows.Forms.ListBox();
            this.editCategoriesButton = new System.Windows.Forms.Button();
            this.itemLookup = new System.Windows.Forms.ComboBox();
            this.itemLookupLabel = new System.Windows.Forms.TextBox();
            this.settingsButton = new System.Windows.Forms.Button();
            this.normalModePanel = new System.Windows.Forms.Panel();
            this.farmingModePanel = new System.Windows.Forms.Panel();
            this.playPauseButton = new System.Windows.Forms.Button();
            this.endSessionButton = new System.Windows.Forms.Button();
            this.clearSessionButton = new System.Windows.Forms.Button();
            this.locationBox = new System.Windows.Forms.ComboBox();
            this.itemPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.timerLabelLabel = new System.Windows.Forms.Label();
            this.timerLabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.modeCheck = new System.Windows.Forms.CheckBox();
            this.normalModePanel.SuspendLayout();
            this.farmingModePanel.SuspendLayout();
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
            this.itemButton00.Enabled = false;
            this.itemButton00.FlatAppearance.BorderSize = 0;
            this.itemButton00.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton00.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton00.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton00.Location = new System.Drawing.Point(16, 17);
            this.itemButton00.Name = "itemButton00";
            this.itemButton00.Size = new System.Drawing.Size(29, 29);
            this.itemButton00.TabIndex = 1;
            this.itemButton00.UseVisualStyleBackColor = false;
            this.itemButton00.Visible = false;
            this.itemButton00.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton00.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            this.itemButton00.MouseEnter += new System.EventHandler(this.itemButton_MouseEnter);
            this.itemButton00.MouseLeave += new System.EventHandler(this.itemButton_MouseLeave);
            // 
            // itemButton01
            // 
            this.itemButton01.BackColor = System.Drawing.Color.Lime;
            this.itemButton01.Enabled = false;
            this.itemButton01.FlatAppearance.BorderSize = 0;
            this.itemButton01.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton01.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton01.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton01.Location = new System.Drawing.Point(70, 17);
            this.itemButton01.Name = "itemButton01";
            this.itemButton01.Size = new System.Drawing.Size(29, 29);
            this.itemButton01.TabIndex = 2;
            this.itemButton01.UseVisualStyleBackColor = false;
            this.itemButton01.Visible = false;
            this.itemButton01.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton01.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            this.itemButton01.MouseEnter += new System.EventHandler(this.itemButton_MouseEnter);
            this.itemButton01.MouseLeave += new System.EventHandler(this.itemButton_MouseLeave);
            // 
            // itemButton02
            // 
            this.itemButton02.BackColor = System.Drawing.Color.Lime;
            this.itemButton02.Enabled = false;
            this.itemButton02.FlatAppearance.BorderSize = 0;
            this.itemButton02.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton02.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton02.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton02.Location = new System.Drawing.Point(124, 17);
            this.itemButton02.Name = "itemButton02";
            this.itemButton02.Size = new System.Drawing.Size(29, 29);
            this.itemButton02.TabIndex = 3;
            this.itemButton02.UseVisualStyleBackColor = false;
            this.itemButton02.Visible = false;
            this.itemButton02.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton02.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            this.itemButton02.MouseEnter += new System.EventHandler(this.itemButton_MouseEnter);
            this.itemButton02.MouseLeave += new System.EventHandler(this.itemButton_MouseLeave);
            // 
            // itemButton03
            // 
            this.itemButton03.BackColor = System.Drawing.Color.Lime;
            this.itemButton03.Enabled = false;
            this.itemButton03.FlatAppearance.BorderSize = 0;
            this.itemButton03.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton03.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton03.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton03.Location = new System.Drawing.Point(178, 17);
            this.itemButton03.Name = "itemButton03";
            this.itemButton03.Size = new System.Drawing.Size(29, 29);
            this.itemButton03.TabIndex = 4;
            this.itemButton03.UseVisualStyleBackColor = false;
            this.itemButton03.Visible = false;
            this.itemButton03.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton03.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            this.itemButton03.MouseEnter += new System.EventHandler(this.itemButton_MouseEnter);
            this.itemButton03.MouseLeave += new System.EventHandler(this.itemButton_MouseLeave);
            // 
            // itemButton04
            // 
            this.itemButton04.BackColor = System.Drawing.Color.Lime;
            this.itemButton04.Enabled = false;
            this.itemButton04.FlatAppearance.BorderSize = 0;
            this.itemButton04.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton04.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton04.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton04.Location = new System.Drawing.Point(232, 17);
            this.itemButton04.Name = "itemButton04";
            this.itemButton04.Size = new System.Drawing.Size(29, 29);
            this.itemButton04.TabIndex = 5;
            this.itemButton04.UseVisualStyleBackColor = false;
            this.itemButton04.Visible = false;
            this.itemButton04.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton04.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            this.itemButton04.MouseEnter += new System.EventHandler(this.itemButton_MouseEnter);
            this.itemButton04.MouseLeave += new System.EventHandler(this.itemButton_MouseLeave);
            // 
            // itemButton05
            // 
            this.itemButton05.BackColor = System.Drawing.Color.Lime;
            this.itemButton05.Enabled = false;
            this.itemButton05.FlatAppearance.BorderSize = 0;
            this.itemButton05.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton05.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton05.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton05.Location = new System.Drawing.Point(286, 17);
            this.itemButton05.Name = "itemButton05";
            this.itemButton05.Size = new System.Drawing.Size(29, 29);
            this.itemButton05.TabIndex = 6;
            this.itemButton05.UseVisualStyleBackColor = false;
            this.itemButton05.Visible = false;
            this.itemButton05.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton05.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            this.itemButton05.MouseEnter += new System.EventHandler(this.itemButton_MouseEnter);
            this.itemButton05.MouseLeave += new System.EventHandler(this.itemButton_MouseLeave);
            // 
            // itemButton06
            // 
            this.itemButton06.BackColor = System.Drawing.Color.Lime;
            this.itemButton06.Enabled = false;
            this.itemButton06.FlatAppearance.BorderSize = 0;
            this.itemButton06.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton06.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton06.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton06.Location = new System.Drawing.Point(340, 17);
            this.itemButton06.Name = "itemButton06";
            this.itemButton06.Size = new System.Drawing.Size(29, 29);
            this.itemButton06.TabIndex = 7;
            this.itemButton06.UseVisualStyleBackColor = false;
            this.itemButton06.Visible = false;
            this.itemButton06.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton06.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            this.itemButton06.MouseEnter += new System.EventHandler(this.itemButton_MouseEnter);
            this.itemButton06.MouseLeave += new System.EventHandler(this.itemButton_MouseLeave);
            // 
            // itemButton07
            // 
            this.itemButton07.BackColor = System.Drawing.Color.Lime;
            this.itemButton07.Enabled = false;
            this.itemButton07.FlatAppearance.BorderSize = 0;
            this.itemButton07.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton07.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton07.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton07.Location = new System.Drawing.Point(394, 17);
            this.itemButton07.Name = "itemButton07";
            this.itemButton07.Size = new System.Drawing.Size(29, 29);
            this.itemButton07.TabIndex = 8;
            this.itemButton07.UseVisualStyleBackColor = false;
            this.itemButton07.Visible = false;
            this.itemButton07.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton07.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            this.itemButton07.MouseEnter += new System.EventHandler(this.itemButton_MouseEnter);
            this.itemButton07.MouseLeave += new System.EventHandler(this.itemButton_MouseLeave);
            // 
            // itemButton10
            // 
            this.itemButton10.BackColor = System.Drawing.Color.Lime;
            this.itemButton10.Enabled = false;
            this.itemButton10.FlatAppearance.BorderSize = 0;
            this.itemButton10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton10.Location = new System.Drawing.Point(16, 71);
            this.itemButton10.Name = "itemButton10";
            this.itemButton10.Size = new System.Drawing.Size(29, 29);
            this.itemButton10.TabIndex = 9;
            this.itemButton10.UseVisualStyleBackColor = false;
            this.itemButton10.Visible = false;
            this.itemButton10.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton10.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            this.itemButton10.MouseEnter += new System.EventHandler(this.itemButton_MouseEnter);
            this.itemButton10.MouseLeave += new System.EventHandler(this.itemButton_MouseLeave);
            // 
            // itemButton20
            // 
            this.itemButton20.BackColor = System.Drawing.Color.Lime;
            this.itemButton20.Enabled = false;
            this.itemButton20.FlatAppearance.BorderSize = 0;
            this.itemButton20.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton20.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton20.Location = new System.Drawing.Point(16, 125);
            this.itemButton20.Name = "itemButton20";
            this.itemButton20.Size = new System.Drawing.Size(29, 29);
            this.itemButton20.TabIndex = 10;
            this.itemButton20.UseVisualStyleBackColor = false;
            this.itemButton20.Visible = false;
            this.itemButton20.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton20.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            this.itemButton20.MouseEnter += new System.EventHandler(this.itemButton_MouseEnter);
            this.itemButton20.MouseLeave += new System.EventHandler(this.itemButton_MouseLeave);
            // 
            // itemButton30
            // 
            this.itemButton30.BackColor = System.Drawing.Color.Lime;
            this.itemButton30.Enabled = false;
            this.itemButton30.FlatAppearance.BorderSize = 0;
            this.itemButton30.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton30.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton30.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton30.Location = new System.Drawing.Point(16, 179);
            this.itemButton30.Name = "itemButton30";
            this.itemButton30.Size = new System.Drawing.Size(29, 29);
            this.itemButton30.TabIndex = 11;
            this.itemButton30.UseVisualStyleBackColor = false;
            this.itemButton30.Visible = false;
            this.itemButton30.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton30.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            this.itemButton30.MouseEnter += new System.EventHandler(this.itemButton_MouseEnter);
            this.itemButton30.MouseLeave += new System.EventHandler(this.itemButton_MouseLeave);
            // 
            // itemButton40
            // 
            this.itemButton40.BackColor = System.Drawing.Color.Lime;
            this.itemButton40.Enabled = false;
            this.itemButton40.FlatAppearance.BorderSize = 0;
            this.itemButton40.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton40.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton40.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton40.Location = new System.Drawing.Point(16, 233);
            this.itemButton40.Name = "itemButton40";
            this.itemButton40.Size = new System.Drawing.Size(29, 29);
            this.itemButton40.TabIndex = 12;
            this.itemButton40.UseVisualStyleBackColor = false;
            this.itemButton40.Visible = false;
            this.itemButton40.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton40.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            this.itemButton40.MouseEnter += new System.EventHandler(this.itemButton_MouseEnter);
            this.itemButton40.MouseLeave += new System.EventHandler(this.itemButton_MouseLeave);
            // 
            // itemButton50
            // 
            this.itemButton50.BackColor = System.Drawing.Color.Lime;
            this.itemButton50.Enabled = false;
            this.itemButton50.FlatAppearance.BorderSize = 0;
            this.itemButton50.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton50.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton50.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton50.Location = new System.Drawing.Point(16, 287);
            this.itemButton50.Name = "itemButton50";
            this.itemButton50.Size = new System.Drawing.Size(29, 29);
            this.itemButton50.TabIndex = 13;
            this.itemButton50.UseVisualStyleBackColor = false;
            this.itemButton50.Visible = false;
            this.itemButton50.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton50.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            this.itemButton50.MouseEnter += new System.EventHandler(this.itemButton_MouseEnter);
            this.itemButton50.MouseLeave += new System.EventHandler(this.itemButton_MouseLeave);
            // 
            // itemButton60
            // 
            this.itemButton60.BackColor = System.Drawing.Color.Lime;
            this.itemButton60.Enabled = false;
            this.itemButton60.FlatAppearance.BorderSize = 0;
            this.itemButton60.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton60.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton60.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton60.Location = new System.Drawing.Point(16, 341);
            this.itemButton60.Name = "itemButton60";
            this.itemButton60.Size = new System.Drawing.Size(29, 29);
            this.itemButton60.TabIndex = 14;
            this.itemButton60.UseVisualStyleBackColor = false;
            this.itemButton60.Visible = false;
            this.itemButton60.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton60.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            this.itemButton60.MouseEnter += new System.EventHandler(this.itemButton_MouseEnter);
            this.itemButton60.MouseLeave += new System.EventHandler(this.itemButton_MouseLeave);
            // 
            // itemButton70
            // 
            this.itemButton70.BackColor = System.Drawing.Color.Lime;
            this.itemButton70.Enabled = false;
            this.itemButton70.FlatAppearance.BorderSize = 0;
            this.itemButton70.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton70.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton70.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton70.Location = new System.Drawing.Point(16, 395);
            this.itemButton70.Name = "itemButton70";
            this.itemButton70.Size = new System.Drawing.Size(29, 29);
            this.itemButton70.TabIndex = 15;
            this.itemButton70.UseVisualStyleBackColor = false;
            this.itemButton70.Visible = false;
            this.itemButton70.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton70.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            this.itemButton70.MouseEnter += new System.EventHandler(this.itemButton_MouseEnter);
            this.itemButton70.MouseLeave += new System.EventHandler(this.itemButton_MouseLeave);
            // 
            // itemButton11
            // 
            this.itemButton11.BackColor = System.Drawing.Color.Lime;
            this.itemButton11.Enabled = false;
            this.itemButton11.FlatAppearance.BorderSize = 0;
            this.itemButton11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton11.Location = new System.Drawing.Point(70, 71);
            this.itemButton11.Name = "itemButton11";
            this.itemButton11.Size = new System.Drawing.Size(29, 29);
            this.itemButton11.TabIndex = 16;
            this.itemButton11.UseVisualStyleBackColor = false;
            this.itemButton11.Visible = false;
            this.itemButton11.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton11.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            this.itemButton11.MouseEnter += new System.EventHandler(this.itemButton_MouseEnter);
            this.itemButton11.MouseLeave += new System.EventHandler(this.itemButton_MouseLeave);
            // 
            // itemButton12
            // 
            this.itemButton12.BackColor = System.Drawing.Color.Lime;
            this.itemButton12.Enabled = false;
            this.itemButton12.FlatAppearance.BorderSize = 0;
            this.itemButton12.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton12.Location = new System.Drawing.Point(124, 71);
            this.itemButton12.Name = "itemButton12";
            this.itemButton12.Size = new System.Drawing.Size(29, 29);
            this.itemButton12.TabIndex = 17;
            this.itemButton12.UseVisualStyleBackColor = false;
            this.itemButton12.Visible = false;
            this.itemButton12.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton12.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            this.itemButton12.MouseEnter += new System.EventHandler(this.itemButton_MouseEnter);
            this.itemButton12.MouseLeave += new System.EventHandler(this.itemButton_MouseLeave);
            // 
            // itemButton13
            // 
            this.itemButton13.BackColor = System.Drawing.Color.Lime;
            this.itemButton13.Enabled = false;
            this.itemButton13.FlatAppearance.BorderSize = 0;
            this.itemButton13.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton13.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton13.Location = new System.Drawing.Point(178, 71);
            this.itemButton13.Name = "itemButton13";
            this.itemButton13.Size = new System.Drawing.Size(29, 29);
            this.itemButton13.TabIndex = 18;
            this.itemButton13.UseVisualStyleBackColor = false;
            this.itemButton13.Visible = false;
            this.itemButton13.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton13.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            this.itemButton13.MouseEnter += new System.EventHandler(this.itemButton_MouseEnter);
            this.itemButton13.MouseLeave += new System.EventHandler(this.itemButton_MouseLeave);
            // 
            // itemButton14
            // 
            this.itemButton14.BackColor = System.Drawing.Color.Lime;
            this.itemButton14.Enabled = false;
            this.itemButton14.FlatAppearance.BorderSize = 0;
            this.itemButton14.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton14.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton14.Location = new System.Drawing.Point(232, 71);
            this.itemButton14.Name = "itemButton14";
            this.itemButton14.Size = new System.Drawing.Size(29, 29);
            this.itemButton14.TabIndex = 19;
            this.itemButton14.UseVisualStyleBackColor = false;
            this.itemButton14.Visible = false;
            this.itemButton14.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton14.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            this.itemButton14.MouseEnter += new System.EventHandler(this.itemButton_MouseEnter);
            this.itemButton14.MouseLeave += new System.EventHandler(this.itemButton_MouseLeave);
            // 
            // itemButton15
            // 
            this.itemButton15.BackColor = System.Drawing.Color.Lime;
            this.itemButton15.Enabled = false;
            this.itemButton15.FlatAppearance.BorderSize = 0;
            this.itemButton15.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton15.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton15.Location = new System.Drawing.Point(286, 71);
            this.itemButton15.Name = "itemButton15";
            this.itemButton15.Size = new System.Drawing.Size(29, 29);
            this.itemButton15.TabIndex = 20;
            this.itemButton15.UseVisualStyleBackColor = false;
            this.itemButton15.Visible = false;
            this.itemButton15.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton15.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            this.itemButton15.MouseEnter += new System.EventHandler(this.itemButton_MouseEnter);
            this.itemButton15.MouseLeave += new System.EventHandler(this.itemButton_MouseLeave);
            // 
            // itemButton16
            // 
            this.itemButton16.BackColor = System.Drawing.Color.Lime;
            this.itemButton16.Enabled = false;
            this.itemButton16.FlatAppearance.BorderSize = 0;
            this.itemButton16.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton16.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton16.Location = new System.Drawing.Point(340, 71);
            this.itemButton16.Name = "itemButton16";
            this.itemButton16.Size = new System.Drawing.Size(29, 29);
            this.itemButton16.TabIndex = 21;
            this.itemButton16.UseVisualStyleBackColor = false;
            this.itemButton16.Visible = false;
            this.itemButton16.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton16.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            this.itemButton16.MouseEnter += new System.EventHandler(this.itemButton_MouseEnter);
            this.itemButton16.MouseLeave += new System.EventHandler(this.itemButton_MouseLeave);
            // 
            // itemButton17
            // 
            this.itemButton17.BackColor = System.Drawing.Color.Lime;
            this.itemButton17.Enabled = false;
            this.itemButton17.FlatAppearance.BorderSize = 0;
            this.itemButton17.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton17.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton17.Location = new System.Drawing.Point(394, 71);
            this.itemButton17.Name = "itemButton17";
            this.itemButton17.Size = new System.Drawing.Size(29, 29);
            this.itemButton17.TabIndex = 22;
            this.itemButton17.UseVisualStyleBackColor = false;
            this.itemButton17.Visible = false;
            this.itemButton17.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton17.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            this.itemButton17.MouseEnter += new System.EventHandler(this.itemButton_MouseEnter);
            this.itemButton17.MouseLeave += new System.EventHandler(this.itemButton_MouseLeave);
            // 
            // itemButton21
            // 
            this.itemButton21.BackColor = System.Drawing.Color.Lime;
            this.itemButton21.Enabled = false;
            this.itemButton21.FlatAppearance.BorderSize = 0;
            this.itemButton21.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton21.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton21.Location = new System.Drawing.Point(70, 125);
            this.itemButton21.Name = "itemButton21";
            this.itemButton21.Size = new System.Drawing.Size(29, 29);
            this.itemButton21.TabIndex = 23;
            this.itemButton21.UseVisualStyleBackColor = false;
            this.itemButton21.Visible = false;
            this.itemButton21.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton21.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            this.itemButton21.MouseEnter += new System.EventHandler(this.itemButton_MouseEnter);
            this.itemButton21.MouseLeave += new System.EventHandler(this.itemButton_MouseLeave);
            // 
            // itemButton22
            // 
            this.itemButton22.BackColor = System.Drawing.Color.Lime;
            this.itemButton22.Enabled = false;
            this.itemButton22.FlatAppearance.BorderSize = 0;
            this.itemButton22.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton22.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton22.Location = new System.Drawing.Point(124, 125);
            this.itemButton22.Name = "itemButton22";
            this.itemButton22.Size = new System.Drawing.Size(29, 29);
            this.itemButton22.TabIndex = 24;
            this.itemButton22.UseVisualStyleBackColor = false;
            this.itemButton22.Visible = false;
            this.itemButton22.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton22.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            this.itemButton22.MouseEnter += new System.EventHandler(this.itemButton_MouseEnter);
            this.itemButton22.MouseLeave += new System.EventHandler(this.itemButton_MouseLeave);
            // 
            // itemButton23
            // 
            this.itemButton23.BackColor = System.Drawing.Color.Lime;
            this.itemButton23.Enabled = false;
            this.itemButton23.FlatAppearance.BorderSize = 0;
            this.itemButton23.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton23.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton23.Location = new System.Drawing.Point(178, 125);
            this.itemButton23.Name = "itemButton23";
            this.itemButton23.Size = new System.Drawing.Size(29, 29);
            this.itemButton23.TabIndex = 25;
            this.itemButton23.UseVisualStyleBackColor = false;
            this.itemButton23.Visible = false;
            this.itemButton23.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton23.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            this.itemButton23.MouseEnter += new System.EventHandler(this.itemButton_MouseEnter);
            this.itemButton23.MouseLeave += new System.EventHandler(this.itemButton_MouseLeave);
            // 
            // itemButton24
            // 
            this.itemButton24.BackColor = System.Drawing.Color.Lime;
            this.itemButton24.Enabled = false;
            this.itemButton24.FlatAppearance.BorderSize = 0;
            this.itemButton24.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton24.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton24.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton24.Location = new System.Drawing.Point(232, 125);
            this.itemButton24.Name = "itemButton24";
            this.itemButton24.Size = new System.Drawing.Size(29, 29);
            this.itemButton24.TabIndex = 26;
            this.itemButton24.UseVisualStyleBackColor = false;
            this.itemButton24.Visible = false;
            this.itemButton24.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton24.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            this.itemButton24.MouseEnter += new System.EventHandler(this.itemButton_MouseEnter);
            this.itemButton24.MouseLeave += new System.EventHandler(this.itemButton_MouseLeave);
            // 
            // itemButton25
            // 
            this.itemButton25.BackColor = System.Drawing.Color.Lime;
            this.itemButton25.Enabled = false;
            this.itemButton25.FlatAppearance.BorderSize = 0;
            this.itemButton25.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton25.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton25.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton25.Location = new System.Drawing.Point(286, 125);
            this.itemButton25.Name = "itemButton25";
            this.itemButton25.Size = new System.Drawing.Size(29, 29);
            this.itemButton25.TabIndex = 27;
            this.itemButton25.UseVisualStyleBackColor = false;
            this.itemButton25.Visible = false;
            this.itemButton25.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton25.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            this.itemButton25.MouseEnter += new System.EventHandler(this.itemButton_MouseEnter);
            this.itemButton25.MouseLeave += new System.EventHandler(this.itemButton_MouseLeave);
            // 
            // itemButton26
            // 
            this.itemButton26.BackColor = System.Drawing.Color.Lime;
            this.itemButton26.Enabled = false;
            this.itemButton26.FlatAppearance.BorderSize = 0;
            this.itemButton26.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton26.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton26.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton26.Location = new System.Drawing.Point(340, 125);
            this.itemButton26.Name = "itemButton26";
            this.itemButton26.Size = new System.Drawing.Size(29, 29);
            this.itemButton26.TabIndex = 28;
            this.itemButton26.UseVisualStyleBackColor = false;
            this.itemButton26.Visible = false;
            this.itemButton26.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton26.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            this.itemButton26.MouseEnter += new System.EventHandler(this.itemButton_MouseEnter);
            this.itemButton26.MouseLeave += new System.EventHandler(this.itemButton_MouseLeave);
            // 
            // itemButton27
            // 
            this.itemButton27.BackColor = System.Drawing.Color.Lime;
            this.itemButton27.Enabled = false;
            this.itemButton27.FlatAppearance.BorderSize = 0;
            this.itemButton27.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton27.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton27.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton27.Location = new System.Drawing.Point(394, 125);
            this.itemButton27.Name = "itemButton27";
            this.itemButton27.Size = new System.Drawing.Size(29, 29);
            this.itemButton27.TabIndex = 29;
            this.itemButton27.UseVisualStyleBackColor = false;
            this.itemButton27.Visible = false;
            this.itemButton27.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton27.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            this.itemButton27.MouseEnter += new System.EventHandler(this.itemButton_MouseEnter);
            this.itemButton27.MouseLeave += new System.EventHandler(this.itemButton_MouseLeave);
            // 
            // itemButton31
            // 
            this.itemButton31.BackColor = System.Drawing.Color.Lime;
            this.itemButton31.Enabled = false;
            this.itemButton31.FlatAppearance.BorderSize = 0;
            this.itemButton31.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton31.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton31.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton31.Location = new System.Drawing.Point(70, 179);
            this.itemButton31.Name = "itemButton31";
            this.itemButton31.Size = new System.Drawing.Size(29, 29);
            this.itemButton31.TabIndex = 30;
            this.itemButton31.UseVisualStyleBackColor = false;
            this.itemButton31.Visible = false;
            this.itemButton31.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton31.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            this.itemButton31.MouseEnter += new System.EventHandler(this.itemButton_MouseEnter);
            this.itemButton31.MouseLeave += new System.EventHandler(this.itemButton_MouseLeave);
            // 
            // itemButton32
            // 
            this.itemButton32.BackColor = System.Drawing.Color.Lime;
            this.itemButton32.Enabled = false;
            this.itemButton32.FlatAppearance.BorderSize = 0;
            this.itemButton32.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton32.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton32.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton32.Location = new System.Drawing.Point(124, 179);
            this.itemButton32.Name = "itemButton32";
            this.itemButton32.Size = new System.Drawing.Size(29, 29);
            this.itemButton32.TabIndex = 31;
            this.itemButton32.UseVisualStyleBackColor = false;
            this.itemButton32.Visible = false;
            this.itemButton32.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton32.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            this.itemButton32.MouseEnter += new System.EventHandler(this.itemButton_MouseEnter);
            this.itemButton32.MouseLeave += new System.EventHandler(this.itemButton_MouseLeave);
            // 
            // itemButton33
            // 
            this.itemButton33.BackColor = System.Drawing.Color.Lime;
            this.itemButton33.Enabled = false;
            this.itemButton33.FlatAppearance.BorderSize = 0;
            this.itemButton33.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton33.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton33.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton33.Location = new System.Drawing.Point(178, 179);
            this.itemButton33.Name = "itemButton33";
            this.itemButton33.Size = new System.Drawing.Size(29, 29);
            this.itemButton33.TabIndex = 32;
            this.itemButton33.UseVisualStyleBackColor = false;
            this.itemButton33.Visible = false;
            this.itemButton33.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton33.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            this.itemButton33.MouseEnter += new System.EventHandler(this.itemButton_MouseEnter);
            this.itemButton33.MouseLeave += new System.EventHandler(this.itemButton_MouseLeave);
            // 
            // itemButton34
            // 
            this.itemButton34.BackColor = System.Drawing.Color.Lime;
            this.itemButton34.Enabled = false;
            this.itemButton34.FlatAppearance.BorderSize = 0;
            this.itemButton34.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton34.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton34.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton34.Location = new System.Drawing.Point(232, 179);
            this.itemButton34.Name = "itemButton34";
            this.itemButton34.Size = new System.Drawing.Size(29, 29);
            this.itemButton34.TabIndex = 33;
            this.itemButton34.UseVisualStyleBackColor = false;
            this.itemButton34.Visible = false;
            this.itemButton34.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton34.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            this.itemButton34.MouseEnter += new System.EventHandler(this.itemButton_MouseEnter);
            this.itemButton34.MouseLeave += new System.EventHandler(this.itemButton_MouseLeave);
            // 
            // itemButton35
            // 
            this.itemButton35.BackColor = System.Drawing.Color.Lime;
            this.itemButton35.Enabled = false;
            this.itemButton35.FlatAppearance.BorderSize = 0;
            this.itemButton35.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton35.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton35.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton35.Location = new System.Drawing.Point(286, 179);
            this.itemButton35.Name = "itemButton35";
            this.itemButton35.Size = new System.Drawing.Size(29, 29);
            this.itemButton35.TabIndex = 34;
            this.itemButton35.UseVisualStyleBackColor = false;
            this.itemButton35.Visible = false;
            this.itemButton35.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton35.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            this.itemButton35.MouseEnter += new System.EventHandler(this.itemButton_MouseEnter);
            this.itemButton35.MouseLeave += new System.EventHandler(this.itemButton_MouseLeave);
            // 
            // itemButton36
            // 
            this.itemButton36.BackColor = System.Drawing.Color.Lime;
            this.itemButton36.Enabled = false;
            this.itemButton36.FlatAppearance.BorderSize = 0;
            this.itemButton36.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton36.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton36.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton36.Location = new System.Drawing.Point(340, 179);
            this.itemButton36.Name = "itemButton36";
            this.itemButton36.Size = new System.Drawing.Size(29, 29);
            this.itemButton36.TabIndex = 35;
            this.itemButton36.UseVisualStyleBackColor = false;
            this.itemButton36.Visible = false;
            this.itemButton36.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton36.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            this.itemButton36.MouseEnter += new System.EventHandler(this.itemButton_MouseEnter);
            this.itemButton36.MouseLeave += new System.EventHandler(this.itemButton_MouseLeave);
            // 
            // itemButton37
            // 
            this.itemButton37.BackColor = System.Drawing.Color.Lime;
            this.itemButton37.Enabled = false;
            this.itemButton37.FlatAppearance.BorderSize = 0;
            this.itemButton37.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton37.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton37.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton37.Location = new System.Drawing.Point(394, 179);
            this.itemButton37.Name = "itemButton37";
            this.itemButton37.Size = new System.Drawing.Size(29, 29);
            this.itemButton37.TabIndex = 36;
            this.itemButton37.UseVisualStyleBackColor = false;
            this.itemButton37.Visible = false;
            this.itemButton37.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton37.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            this.itemButton37.MouseEnter += new System.EventHandler(this.itemButton_MouseEnter);
            this.itemButton37.MouseLeave += new System.EventHandler(this.itemButton_MouseLeave);
            // 
            // itemButton41
            // 
            this.itemButton41.BackColor = System.Drawing.Color.Lime;
            this.itemButton41.Enabled = false;
            this.itemButton41.FlatAppearance.BorderSize = 0;
            this.itemButton41.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton41.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton41.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton41.Location = new System.Drawing.Point(70, 233);
            this.itemButton41.Name = "itemButton41";
            this.itemButton41.Size = new System.Drawing.Size(29, 29);
            this.itemButton41.TabIndex = 37;
            this.itemButton41.UseVisualStyleBackColor = false;
            this.itemButton41.Visible = false;
            this.itemButton41.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton41.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            this.itemButton41.MouseEnter += new System.EventHandler(this.itemButton_MouseEnter);
            this.itemButton41.MouseLeave += new System.EventHandler(this.itemButton_MouseLeave);
            // 
            // itemButton42
            // 
            this.itemButton42.BackColor = System.Drawing.Color.Lime;
            this.itemButton42.Enabled = false;
            this.itemButton42.FlatAppearance.BorderSize = 0;
            this.itemButton42.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton42.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton42.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton42.Location = new System.Drawing.Point(124, 233);
            this.itemButton42.Name = "itemButton42";
            this.itemButton42.Size = new System.Drawing.Size(29, 29);
            this.itemButton42.TabIndex = 38;
            this.itemButton42.UseVisualStyleBackColor = false;
            this.itemButton42.Visible = false;
            this.itemButton42.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton42.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            this.itemButton42.MouseEnter += new System.EventHandler(this.itemButton_MouseEnter);
            this.itemButton42.MouseLeave += new System.EventHandler(this.itemButton_MouseLeave);
            // 
            // itemButton43
            // 
            this.itemButton43.BackColor = System.Drawing.Color.Lime;
            this.itemButton43.Enabled = false;
            this.itemButton43.FlatAppearance.BorderSize = 0;
            this.itemButton43.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton43.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton43.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton43.Location = new System.Drawing.Point(178, 233);
            this.itemButton43.Name = "itemButton43";
            this.itemButton43.Size = new System.Drawing.Size(29, 29);
            this.itemButton43.TabIndex = 39;
            this.itemButton43.UseVisualStyleBackColor = false;
            this.itemButton43.Visible = false;
            this.itemButton43.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton43.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            this.itemButton43.MouseEnter += new System.EventHandler(this.itemButton_MouseEnter);
            this.itemButton43.MouseLeave += new System.EventHandler(this.itemButton_MouseLeave);
            // 
            // itemButton44
            // 
            this.itemButton44.BackColor = System.Drawing.Color.Lime;
            this.itemButton44.Enabled = false;
            this.itemButton44.FlatAppearance.BorderSize = 0;
            this.itemButton44.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton44.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton44.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton44.Location = new System.Drawing.Point(232, 233);
            this.itemButton44.Name = "itemButton44";
            this.itemButton44.Size = new System.Drawing.Size(29, 29);
            this.itemButton44.TabIndex = 40;
            this.itemButton44.UseVisualStyleBackColor = false;
            this.itemButton44.Visible = false;
            this.itemButton44.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton44.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            this.itemButton44.MouseEnter += new System.EventHandler(this.itemButton_MouseEnter);
            this.itemButton44.MouseLeave += new System.EventHandler(this.itemButton_MouseLeave);
            // 
            // itemButton45
            // 
            this.itemButton45.BackColor = System.Drawing.Color.Lime;
            this.itemButton45.Enabled = false;
            this.itemButton45.FlatAppearance.BorderSize = 0;
            this.itemButton45.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton45.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton45.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton45.Location = new System.Drawing.Point(286, 233);
            this.itemButton45.Name = "itemButton45";
            this.itemButton45.Size = new System.Drawing.Size(29, 29);
            this.itemButton45.TabIndex = 41;
            this.itemButton45.UseVisualStyleBackColor = false;
            this.itemButton45.Visible = false;
            this.itemButton45.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton45.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            this.itemButton45.MouseEnter += new System.EventHandler(this.itemButton_MouseEnter);
            this.itemButton45.MouseLeave += new System.EventHandler(this.itemButton_MouseLeave);
            // 
            // itemButton46
            // 
            this.itemButton46.BackColor = System.Drawing.Color.Lime;
            this.itemButton46.Enabled = false;
            this.itemButton46.FlatAppearance.BorderSize = 0;
            this.itemButton46.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton46.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton46.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton46.Location = new System.Drawing.Point(340, 233);
            this.itemButton46.Name = "itemButton46";
            this.itemButton46.Size = new System.Drawing.Size(29, 29);
            this.itemButton46.TabIndex = 42;
            this.itemButton46.UseVisualStyleBackColor = false;
            this.itemButton46.Visible = false;
            this.itemButton46.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton46.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            this.itemButton46.MouseEnter += new System.EventHandler(this.itemButton_MouseEnter);
            this.itemButton46.MouseLeave += new System.EventHandler(this.itemButton_MouseLeave);
            // 
            // itemButton47
            // 
            this.itemButton47.BackColor = System.Drawing.Color.Lime;
            this.itemButton47.Enabled = false;
            this.itemButton47.FlatAppearance.BorderSize = 0;
            this.itemButton47.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton47.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton47.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton47.Location = new System.Drawing.Point(394, 233);
            this.itemButton47.Name = "itemButton47";
            this.itemButton47.Size = new System.Drawing.Size(29, 29);
            this.itemButton47.TabIndex = 43;
            this.itemButton47.UseVisualStyleBackColor = false;
            this.itemButton47.Visible = false;
            this.itemButton47.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton47.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            this.itemButton47.MouseEnter += new System.EventHandler(this.itemButton_MouseEnter);
            this.itemButton47.MouseLeave += new System.EventHandler(this.itemButton_MouseLeave);
            // 
            // itemButton51
            // 
            this.itemButton51.BackColor = System.Drawing.Color.Lime;
            this.itemButton51.Enabled = false;
            this.itemButton51.FlatAppearance.BorderSize = 0;
            this.itemButton51.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton51.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton51.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton51.Location = new System.Drawing.Point(70, 287);
            this.itemButton51.Name = "itemButton51";
            this.itemButton51.Size = new System.Drawing.Size(29, 29);
            this.itemButton51.TabIndex = 44;
            this.itemButton51.UseVisualStyleBackColor = false;
            this.itemButton51.Visible = false;
            this.itemButton51.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton51.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            this.itemButton51.MouseEnter += new System.EventHandler(this.itemButton_MouseEnter);
            this.itemButton51.MouseLeave += new System.EventHandler(this.itemButton_MouseLeave);
            // 
            // itemButton52
            // 
            this.itemButton52.BackColor = System.Drawing.Color.Lime;
            this.itemButton52.Enabled = false;
            this.itemButton52.FlatAppearance.BorderSize = 0;
            this.itemButton52.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton52.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton52.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton52.Location = new System.Drawing.Point(124, 287);
            this.itemButton52.Name = "itemButton52";
            this.itemButton52.Size = new System.Drawing.Size(29, 29);
            this.itemButton52.TabIndex = 45;
            this.itemButton52.UseVisualStyleBackColor = false;
            this.itemButton52.Visible = false;
            this.itemButton52.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton52.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            this.itemButton52.MouseEnter += new System.EventHandler(this.itemButton_MouseEnter);
            this.itemButton52.MouseLeave += new System.EventHandler(this.itemButton_MouseLeave);
            // 
            // itemButton53
            // 
            this.itemButton53.BackColor = System.Drawing.Color.Lime;
            this.itemButton53.Enabled = false;
            this.itemButton53.FlatAppearance.BorderSize = 0;
            this.itemButton53.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton53.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton53.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton53.Location = new System.Drawing.Point(178, 287);
            this.itemButton53.Name = "itemButton53";
            this.itemButton53.Size = new System.Drawing.Size(29, 29);
            this.itemButton53.TabIndex = 46;
            this.itemButton53.UseVisualStyleBackColor = false;
            this.itemButton53.Visible = false;
            this.itemButton53.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton53.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            this.itemButton53.MouseEnter += new System.EventHandler(this.itemButton_MouseEnter);
            this.itemButton53.MouseLeave += new System.EventHandler(this.itemButton_MouseLeave);
            // 
            // itemButton54
            // 
            this.itemButton54.BackColor = System.Drawing.Color.Lime;
            this.itemButton54.Enabled = false;
            this.itemButton54.FlatAppearance.BorderSize = 0;
            this.itemButton54.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton54.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton54.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton54.Location = new System.Drawing.Point(232, 287);
            this.itemButton54.Name = "itemButton54";
            this.itemButton54.Size = new System.Drawing.Size(29, 29);
            this.itemButton54.TabIndex = 47;
            this.itemButton54.UseVisualStyleBackColor = false;
            this.itemButton54.Visible = false;
            this.itemButton54.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton54.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            this.itemButton54.MouseEnter += new System.EventHandler(this.itemButton_MouseEnter);
            this.itemButton54.MouseLeave += new System.EventHandler(this.itemButton_MouseLeave);
            // 
            // itemButton55
            // 
            this.itemButton55.BackColor = System.Drawing.Color.Lime;
            this.itemButton55.Enabled = false;
            this.itemButton55.FlatAppearance.BorderSize = 0;
            this.itemButton55.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton55.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton55.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton55.Location = new System.Drawing.Point(286, 287);
            this.itemButton55.Name = "itemButton55";
            this.itemButton55.Size = new System.Drawing.Size(29, 29);
            this.itemButton55.TabIndex = 48;
            this.itemButton55.UseVisualStyleBackColor = false;
            this.itemButton55.Visible = false;
            this.itemButton55.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton55.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            this.itemButton55.MouseEnter += new System.EventHandler(this.itemButton_MouseEnter);
            this.itemButton55.MouseLeave += new System.EventHandler(this.itemButton_MouseLeave);
            // 
            // itemButton56
            // 
            this.itemButton56.BackColor = System.Drawing.Color.Lime;
            this.itemButton56.Enabled = false;
            this.itemButton56.FlatAppearance.BorderSize = 0;
            this.itemButton56.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton56.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton56.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton56.Location = new System.Drawing.Point(340, 287);
            this.itemButton56.Name = "itemButton56";
            this.itemButton56.Size = new System.Drawing.Size(29, 29);
            this.itemButton56.TabIndex = 49;
            this.itemButton56.UseVisualStyleBackColor = false;
            this.itemButton56.Visible = false;
            this.itemButton56.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton56.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            this.itemButton56.MouseEnter += new System.EventHandler(this.itemButton_MouseEnter);
            this.itemButton56.MouseLeave += new System.EventHandler(this.itemButton_MouseLeave);
            // 
            // itemButton57
            // 
            this.itemButton57.BackColor = System.Drawing.Color.Lime;
            this.itemButton57.Enabled = false;
            this.itemButton57.FlatAppearance.BorderSize = 0;
            this.itemButton57.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton57.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton57.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton57.Location = new System.Drawing.Point(394, 287);
            this.itemButton57.Name = "itemButton57";
            this.itemButton57.Size = new System.Drawing.Size(29, 29);
            this.itemButton57.TabIndex = 50;
            this.itemButton57.UseVisualStyleBackColor = false;
            this.itemButton57.Visible = false;
            this.itemButton57.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton57.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            this.itemButton57.MouseEnter += new System.EventHandler(this.itemButton_MouseEnter);
            this.itemButton57.MouseLeave += new System.EventHandler(this.itemButton_MouseLeave);
            // 
            // itemButton61
            // 
            this.itemButton61.BackColor = System.Drawing.Color.Lime;
            this.itemButton61.Enabled = false;
            this.itemButton61.FlatAppearance.BorderSize = 0;
            this.itemButton61.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton61.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton61.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton61.Location = new System.Drawing.Point(70, 341);
            this.itemButton61.Name = "itemButton61";
            this.itemButton61.Size = new System.Drawing.Size(29, 29);
            this.itemButton61.TabIndex = 51;
            this.itemButton61.UseVisualStyleBackColor = false;
            this.itemButton61.Visible = false;
            this.itemButton61.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton61.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            this.itemButton61.MouseEnter += new System.EventHandler(this.itemButton_MouseEnter);
            this.itemButton61.MouseLeave += new System.EventHandler(this.itemButton_MouseLeave);
            // 
            // itemButton62
            // 
            this.itemButton62.BackColor = System.Drawing.Color.Lime;
            this.itemButton62.Enabled = false;
            this.itemButton62.FlatAppearance.BorderSize = 0;
            this.itemButton62.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton62.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton62.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton62.Location = new System.Drawing.Point(124, 341);
            this.itemButton62.Name = "itemButton62";
            this.itemButton62.Size = new System.Drawing.Size(29, 29);
            this.itemButton62.TabIndex = 52;
            this.itemButton62.UseVisualStyleBackColor = false;
            this.itemButton62.Visible = false;
            this.itemButton62.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton62.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            this.itemButton62.MouseEnter += new System.EventHandler(this.itemButton_MouseEnter);
            this.itemButton62.MouseLeave += new System.EventHandler(this.itemButton_MouseLeave);
            // 
            // itemButton63
            // 
            this.itemButton63.BackColor = System.Drawing.Color.Lime;
            this.itemButton63.Enabled = false;
            this.itemButton63.FlatAppearance.BorderSize = 0;
            this.itemButton63.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton63.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton63.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton63.Location = new System.Drawing.Point(178, 341);
            this.itemButton63.Name = "itemButton63";
            this.itemButton63.Size = new System.Drawing.Size(29, 29);
            this.itemButton63.TabIndex = 53;
            this.itemButton63.UseVisualStyleBackColor = false;
            this.itemButton63.Visible = false;
            this.itemButton63.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton63.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            this.itemButton63.MouseEnter += new System.EventHandler(this.itemButton_MouseEnter);
            this.itemButton63.MouseLeave += new System.EventHandler(this.itemButton_MouseLeave);
            // 
            // itemButton64
            // 
            this.itemButton64.BackColor = System.Drawing.Color.Lime;
            this.itemButton64.Enabled = false;
            this.itemButton64.FlatAppearance.BorderSize = 0;
            this.itemButton64.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton64.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton64.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton64.Location = new System.Drawing.Point(232, 341);
            this.itemButton64.Name = "itemButton64";
            this.itemButton64.Size = new System.Drawing.Size(29, 29);
            this.itemButton64.TabIndex = 54;
            this.itemButton64.UseVisualStyleBackColor = false;
            this.itemButton64.Visible = false;
            this.itemButton64.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton64.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            this.itemButton64.MouseEnter += new System.EventHandler(this.itemButton_MouseEnter);
            this.itemButton64.MouseLeave += new System.EventHandler(this.itemButton_MouseLeave);
            // 
            // itemButton65
            // 
            this.itemButton65.BackColor = System.Drawing.Color.Lime;
            this.itemButton65.Enabled = false;
            this.itemButton65.FlatAppearance.BorderSize = 0;
            this.itemButton65.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton65.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton65.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton65.Location = new System.Drawing.Point(286, 341);
            this.itemButton65.Name = "itemButton65";
            this.itemButton65.Size = new System.Drawing.Size(29, 29);
            this.itemButton65.TabIndex = 55;
            this.itemButton65.UseVisualStyleBackColor = false;
            this.itemButton65.Visible = false;
            this.itemButton65.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton65.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            this.itemButton65.MouseEnter += new System.EventHandler(this.itemButton_MouseEnter);
            this.itemButton65.MouseLeave += new System.EventHandler(this.itemButton_MouseLeave);
            // 
            // itemButton66
            // 
            this.itemButton66.BackColor = System.Drawing.Color.Lime;
            this.itemButton66.Enabled = false;
            this.itemButton66.FlatAppearance.BorderSize = 0;
            this.itemButton66.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton66.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton66.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton66.Location = new System.Drawing.Point(340, 341);
            this.itemButton66.Name = "itemButton66";
            this.itemButton66.Size = new System.Drawing.Size(29, 29);
            this.itemButton66.TabIndex = 56;
            this.itemButton66.UseVisualStyleBackColor = false;
            this.itemButton66.Visible = false;
            this.itemButton66.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton66.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            this.itemButton66.MouseEnter += new System.EventHandler(this.itemButton_MouseEnter);
            this.itemButton66.MouseLeave += new System.EventHandler(this.itemButton_MouseLeave);
            // 
            // itemButton67
            // 
            this.itemButton67.BackColor = System.Drawing.Color.Lime;
            this.itemButton67.Enabled = false;
            this.itemButton67.FlatAppearance.BorderSize = 0;
            this.itemButton67.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton67.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton67.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton67.Location = new System.Drawing.Point(394, 341);
            this.itemButton67.Name = "itemButton67";
            this.itemButton67.Size = new System.Drawing.Size(29, 29);
            this.itemButton67.TabIndex = 57;
            this.itemButton67.UseVisualStyleBackColor = false;
            this.itemButton67.Visible = false;
            this.itemButton67.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton67.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            this.itemButton67.MouseEnter += new System.EventHandler(this.itemButton_MouseEnter);
            this.itemButton67.MouseLeave += new System.EventHandler(this.itemButton_MouseLeave);
            // 
            // itemButton71
            // 
            this.itemButton71.BackColor = System.Drawing.Color.Lime;
            this.itemButton71.Enabled = false;
            this.itemButton71.FlatAppearance.BorderSize = 0;
            this.itemButton71.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton71.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton71.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton71.Location = new System.Drawing.Point(70, 395);
            this.itemButton71.Name = "itemButton71";
            this.itemButton71.Size = new System.Drawing.Size(29, 29);
            this.itemButton71.TabIndex = 58;
            this.itemButton71.UseVisualStyleBackColor = false;
            this.itemButton71.Visible = false;
            this.itemButton71.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton71.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            this.itemButton71.MouseEnter += new System.EventHandler(this.itemButton_MouseEnter);
            this.itemButton71.MouseLeave += new System.EventHandler(this.itemButton_MouseLeave);
            // 
            // itemButton72
            // 
            this.itemButton72.BackColor = System.Drawing.Color.Lime;
            this.itemButton72.Enabled = false;
            this.itemButton72.FlatAppearance.BorderSize = 0;
            this.itemButton72.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton72.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton72.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton72.Location = new System.Drawing.Point(124, 395);
            this.itemButton72.Name = "itemButton72";
            this.itemButton72.Size = new System.Drawing.Size(29, 29);
            this.itemButton72.TabIndex = 59;
            this.itemButton72.UseVisualStyleBackColor = false;
            this.itemButton72.Visible = false;
            this.itemButton72.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton72.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            this.itemButton72.MouseEnter += new System.EventHandler(this.itemButton_MouseEnter);
            this.itemButton72.MouseLeave += new System.EventHandler(this.itemButton_MouseLeave);
            // 
            // itemButton73
            // 
            this.itemButton73.BackColor = System.Drawing.Color.Lime;
            this.itemButton73.Enabled = false;
            this.itemButton73.FlatAppearance.BorderSize = 0;
            this.itemButton73.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton73.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton73.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton73.Location = new System.Drawing.Point(178, 395);
            this.itemButton73.Name = "itemButton73";
            this.itemButton73.Size = new System.Drawing.Size(29, 29);
            this.itemButton73.TabIndex = 60;
            this.itemButton73.UseVisualStyleBackColor = false;
            this.itemButton73.Visible = false;
            this.itemButton73.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton73.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            this.itemButton73.MouseEnter += new System.EventHandler(this.itemButton_MouseEnter);
            this.itemButton73.MouseLeave += new System.EventHandler(this.itemButton_MouseLeave);
            // 
            // itemButton74
            // 
            this.itemButton74.BackColor = System.Drawing.Color.Lime;
            this.itemButton74.Enabled = false;
            this.itemButton74.FlatAppearance.BorderSize = 0;
            this.itemButton74.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton74.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton74.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton74.Location = new System.Drawing.Point(232, 395);
            this.itemButton74.Name = "itemButton74";
            this.itemButton74.Size = new System.Drawing.Size(29, 29);
            this.itemButton74.TabIndex = 61;
            this.itemButton74.UseVisualStyleBackColor = false;
            this.itemButton74.Visible = false;
            this.itemButton74.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton74.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            this.itemButton74.MouseEnter += new System.EventHandler(this.itemButton_MouseEnter);
            this.itemButton74.MouseLeave += new System.EventHandler(this.itemButton_MouseLeave);
            // 
            // itemButton75
            // 
            this.itemButton75.BackColor = System.Drawing.Color.Lime;
            this.itemButton75.Enabled = false;
            this.itemButton75.FlatAppearance.BorderSize = 0;
            this.itemButton75.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton75.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton75.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton75.Location = new System.Drawing.Point(286, 395);
            this.itemButton75.Name = "itemButton75";
            this.itemButton75.Size = new System.Drawing.Size(29, 29);
            this.itemButton75.TabIndex = 62;
            this.itemButton75.UseVisualStyleBackColor = false;
            this.itemButton75.Visible = false;
            this.itemButton75.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton75.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            this.itemButton75.MouseEnter += new System.EventHandler(this.itemButton_MouseEnter);
            this.itemButton75.MouseLeave += new System.EventHandler(this.itemButton_MouseLeave);
            // 
            // itemButton76
            // 
            this.itemButton76.BackColor = System.Drawing.Color.Lime;
            this.itemButton76.Enabled = false;
            this.itemButton76.FlatAppearance.BorderSize = 0;
            this.itemButton76.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton76.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton76.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton76.Location = new System.Drawing.Point(340, 395);
            this.itemButton76.Name = "itemButton76";
            this.itemButton76.Size = new System.Drawing.Size(29, 29);
            this.itemButton76.TabIndex = 63;
            this.itemButton76.UseVisualStyleBackColor = false;
            this.itemButton76.Visible = false;
            this.itemButton76.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton76.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            this.itemButton76.MouseEnter += new System.EventHandler(this.itemButton_MouseEnter);
            this.itemButton76.MouseLeave += new System.EventHandler(this.itemButton_MouseLeave);
            // 
            // itemButton77
            // 
            this.itemButton77.BackColor = System.Drawing.Color.Lime;
            this.itemButton77.Enabled = false;
            this.itemButton77.FlatAppearance.BorderSize = 0;
            this.itemButton77.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.itemButton77.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.itemButton77.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton77.Location = new System.Drawing.Point(394, 395);
            this.itemButton77.Name = "itemButton77";
            this.itemButton77.Size = new System.Drawing.Size(29, 29);
            this.itemButton77.TabIndex = 64;
            this.itemButton77.UseVisualStyleBackColor = false;
            this.itemButton77.Visible = false;
            this.itemButton77.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton77.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            this.itemButton77.MouseEnter += new System.EventHandler(this.itemButton_MouseEnter);
            this.itemButton77.MouseLeave += new System.EventHandler(this.itemButton_MouseLeave);
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
            // categoryOverviewLabel
            // 
            this.categoryOverviewLabel.AutoSize = true;
            this.categoryOverviewLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.categoryOverviewLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryOverviewLabel.ForeColor = System.Drawing.Color.White;
            this.categoryOverviewLabel.Location = new System.Drawing.Point(319, 5);
            this.categoryOverviewLabel.Name = "categoryOverviewLabel";
            this.categoryOverviewLabel.Size = new System.Drawing.Size(159, 23);
            this.categoryOverviewLabel.TabIndex = 66;
            this.categoryOverviewLabel.Text = "Category overview";
            // 
            // categoryOverviewList
            // 
            this.categoryOverviewList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.categoryOverviewList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.categoryOverviewList.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryOverviewList.ForeColor = System.Drawing.Color.White;
            this.categoryOverviewList.FormattingEnabled = true;
            this.categoryOverviewList.HorizontalScrollbar = true;
            this.categoryOverviewList.ItemHeight = 15;
            this.categoryOverviewList.Location = new System.Drawing.Point(322, 32);
            this.categoryOverviewList.Name = "categoryOverviewList";
            this.categoryOverviewList.Size = new System.Drawing.Size(153, 482);
            this.categoryOverviewList.TabIndex = 67;
            this.categoryOverviewList.SelectedIndexChanged += new System.EventHandler(this.categoryOverviewList_SelectedIndexChanged);
            // 
            // itemOrganization
            // 
            this.itemOrganization.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.itemOrganization.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.itemOrganization.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemOrganization.ForeColor = System.Drawing.Color.White;
            this.itemOrganization.FormattingEnabled = true;
            this.itemOrganization.HorizontalScrollbar = true;
            this.itemOrganization.ItemHeight = 15;
            this.itemOrganization.Location = new System.Drawing.Point(2, 113);
            this.itemOrganization.Name = "itemOrganization";
            this.itemOrganization.Size = new System.Drawing.Size(315, 390);
            this.itemOrganization.TabIndex = 68;
            // 
            // editCategoriesButton
            // 
            this.editCategoriesButton.BackColor = System.Drawing.Color.Pink;
            this.editCategoriesButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("editCategoriesButton.BackgroundImage")));
            this.editCategoriesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editCategoriesButton.FlatAppearance.BorderSize = 0;
            this.editCategoriesButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepPink;
            this.editCategoriesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.HotPink;
            this.editCategoriesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editCategoriesButton.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editCategoriesButton.Location = new System.Drawing.Point(286, 76);
            this.editCategoriesButton.Name = "editCategoriesButton";
            this.editCategoriesButton.Size = new System.Drawing.Size(31, 31);
            this.editCategoriesButton.TabIndex = 69;
            this.editCategoriesButton.UseVisualStyleBackColor = false;
            this.editCategoriesButton.Click += new System.EventHandler(this.editCategoriesButton_Click);
            // 
            // itemLookup
            // 
            this.itemLookup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.itemLookup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.itemLookup.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemLookup.FormattingEnabled = true;
            this.itemLookup.Location = new System.Drawing.Point(2, 7);
            this.itemLookup.Name = "itemLookup";
            this.itemLookup.Size = new System.Drawing.Size(315, 26);
            this.itemLookup.TabIndex = 70;
            this.itemLookup.SelectedIndexChanged += new System.EventHandler(this.itemLookup_SelectedIndexChanged);
            // 
            // itemLookupLabel
            // 
            this.itemLookupLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.itemLookupLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.itemLookupLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.itemLookupLabel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemLookupLabel.ForeColor = System.Drawing.Color.White;
            this.itemLookupLabel.Location = new System.Drawing.Point(2, 39);
            this.itemLookupLabel.Multiline = true;
            this.itemLookupLabel.Name = "itemLookupLabel";
            this.itemLookupLabel.ReadOnly = true;
            this.itemLookupLabel.Size = new System.Drawing.Size(315, 31);
            this.itemLookupLabel.TabIndex = 71;
            this.itemLookupLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // normalModePanel
            // 
            this.normalModePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.normalModePanel.Controls.Add(this.itemLookupLabel);
            this.normalModePanel.Controls.Add(this.itemLookup);
            this.normalModePanel.Controls.Add(this.categoryOverviewLabel);
            this.normalModePanel.Controls.Add(this.editCategoriesButton);
            this.normalModePanel.Controls.Add(this.itemOrganization);
            this.normalModePanel.Controls.Add(this.categoryOverviewList);
            this.normalModePanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.normalModePanel.Location = new System.Drawing.Point(440, 0);
            this.normalModePanel.Name = "normalModePanel";
            this.normalModePanel.Size = new System.Drawing.Size(476, 514);
            this.normalModePanel.TabIndex = 73;
            // 
            // farmingModePanel
            // 
            this.farmingModePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.farmingModePanel.Controls.Add(this.playPauseButton);
            this.farmingModePanel.Controls.Add(this.endSessionButton);
            this.farmingModePanel.Controls.Add(this.clearSessionButton);
            this.farmingModePanel.Controls.Add(this.locationBox);
            this.farmingModePanel.Controls.Add(this.itemPanel);
            this.farmingModePanel.Controls.Add(this.timerLabelLabel);
            this.farmingModePanel.Controls.Add(this.timerLabel);
            this.farmingModePanel.Enabled = false;
            this.farmingModePanel.Location = new System.Drawing.Point(440, 0);
            this.farmingModePanel.Name = "farmingModePanel";
            this.farmingModePanel.Size = new System.Drawing.Size(478, 514);
            this.farmingModePanel.TabIndex = 74;
            this.farmingModePanel.Visible = false;
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
            this.playPauseButton.Location = new System.Drawing.Point(314, 35);
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
            this.endSessionButton.Location = new System.Drawing.Point(333, 109);
            this.endSessionButton.Name = "endSessionButton";
            this.endSessionButton.Size = new System.Drawing.Size(126, 31);
            this.endSessionButton.TabIndex = 67;
            this.endSessionButton.Text = "End and Auto-fill";
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
            this.clearSessionButton.Location = new System.Drawing.Point(333, 72);
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
            this.locationBox.Location = new System.Drawing.Point(36, 13);
            this.locationBox.Name = "locationBox";
            this.locationBox.Size = new System.Drawing.Size(261, 26);
            this.locationBox.TabIndex = 3;
            this.locationBox.SelectedIndexChanged += new System.EventHandler(this.locationBox_SelectedIndexChanged);
            // 
            // itemPanel
            // 
            this.itemPanel.AutoScroll = true;
            this.itemPanel.ForeColor = System.Drawing.Color.Black;
            this.itemPanel.Location = new System.Drawing.Point(33, 51);
            this.itemPanel.Name = "itemPanel";
            this.itemPanel.Size = new System.Drawing.Size(264, 463);
            this.itemPanel.TabIndex = 2;
            // 
            // timerLabelLabel
            // 
            this.timerLabelLabel.AutoSize = true;
            this.timerLabelLabel.ForeColor = System.Drawing.Color.White;
            this.timerLabelLabel.Location = new System.Drawing.Point(328, 13);
            this.timerLabelLabel.Name = "timerLabelLabel";
            this.timerLabelLabel.Size = new System.Drawing.Size(136, 13);
            this.timerLabelLabel.TabIndex = 1;
            this.timerLabelLabel.Text = "Elapsed time in this session";
            this.timerLabelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerLabel.ForeColor = System.Drawing.Color.White;
            this.timerLabel.Location = new System.Drawing.Point(343, 25);
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
            // modeCheck
            // 
            this.modeCheck.AutoSize = true;
            this.modeCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.modeCheck.ForeColor = System.Drawing.Color.White;
            this.modeCheck.Location = new System.Drawing.Point(6, 454);
            this.modeCheck.Name = "modeCheck";
            this.modeCheck.Size = new System.Drawing.Size(93, 17);
            this.modeCheck.TabIndex = 75;
            this.modeCheck.Text = "Farming Mode";
            this.modeCheck.UseVisualStyleBackColor = false;
            this.modeCheck.Click += new System.EventHandler(this.modeCheck_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(916, 514);
            this.Controls.Add(this.modeCheck);
            this.Controls.Add(this.farmingModePanel);
            this.Controls.Add(this.normalModePanel);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.analyzeButton);
            this.Controls.Add(this.itemButton77);
            this.Controls.Add(this.itemButton76);
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
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BDO Item Sorter";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.normalModePanel.ResumeLayout(false);
            this.normalModePanel.PerformLayout();
            this.farmingModePanel.ResumeLayout(false);
            this.farmingModePanel.PerformLayout();
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
        private System.Windows.Forms.Label categoryOverviewLabel;
        private System.Windows.Forms.ListBox categoryOverviewList;
        private System.Windows.Forms.ListBox itemOrganization;
        private System.Windows.Forms.Button editCategoriesButton;
        private System.Windows.Forms.ComboBox itemLookup;
        private System.Windows.Forms.TextBox itemLookupLabel;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Panel normalModePanel;
        private System.Windows.Forms.Panel farmingModePanel;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label timerLabelLabel;
        private System.Windows.Forms.FlowLayoutPanel itemPanel;
        private System.Windows.Forms.ComboBox locationBox;
        private System.Windows.Forms.CheckBox modeCheck;
        private System.Windows.Forms.Button endSessionButton;
        private System.Windows.Forms.Button clearSessionButton;
        private System.Windows.Forms.Button playPauseButton;
    }
}

