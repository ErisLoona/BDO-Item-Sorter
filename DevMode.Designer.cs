namespace BDO_Item_Sorter
{
    partial class DevMode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DevMode));
            this.titleLabel = new System.Windows.Forms.Label();
            this.infoLabel = new System.Windows.Forms.Label();
            this.grabSlotsButton = new System.Windows.Forms.Button();
            this.outputLabel1 = new System.Windows.Forms.Label();
            this.outputLabel2 = new System.Windows.Forms.Label();
            this.grabDigitsButton = new System.Windows.Forms.Button();
            this.cropCheck = new System.Windows.Forms.CheckBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.saveLocations = new System.Windows.Forms.Button();
            this.saveSpecialLocations = new System.Windows.Forms.Button();
            this.saveItemsButton = new System.Windows.Forms.Button();
            this.displayCheck = new System.Windows.Forms.CheckBox();
            this.displayLabel = new System.Windows.Forms.Label();
            this.getScreenButton = new System.Windows.Forms.Button();
            this.getInventoryButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.reportLabel2 = new System.Windows.Forms.Label();
            this.reportLabel1 = new System.Windows.Forms.Label();
            this.getAnimatedIcons = new System.Windows.Forms.Button();
            this.flowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(179, 3);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(237, 26);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Welcome to the dev tools!";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel.Location = new System.Drawing.Point(8, 26);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(579, 36);
            this.infoLabel.TabIndex = 1;
            this.infoLabel.Text = "Don\'t be surprised if the stuff here doesn\'t work or crashes the program.\r\nEveryt" +
    "hing here assumes you know what you\'re doing, there is no protection against cra" +
    "shes.\r\n";
            this.infoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grabSlotsButton
            // 
            this.grabSlotsButton.BackColor = System.Drawing.Color.Pink;
            this.grabSlotsButton.FlatAppearance.BorderSize = 0;
            this.grabSlotsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepPink;
            this.grabSlotsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.HotPink;
            this.grabSlotsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grabSlotsButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grabSlotsButton.ForeColor = System.Drawing.Color.Black;
            this.grabSlotsButton.Location = new System.Drawing.Point(26, 86);
            this.grabSlotsButton.Name = "grabSlotsButton";
            this.grabSlotsButton.Size = new System.Drawing.Size(137, 31);
            this.grabSlotsButton.TabIndex = 66;
            this.grabSlotsButton.Text = "Grab Item Slots";
            this.grabSlotsButton.UseVisualStyleBackColor = false;
            this.grabSlotsButton.Click += new System.EventHandler(this.grabSlotsButton_Click);
            // 
            // outputLabel1
            // 
            this.outputLabel1.AutoSize = true;
            this.outputLabel1.Location = new System.Drawing.Point(3, 18);
            this.outputLabel1.Name = "outputLabel1";
            this.outputLabel1.Size = new System.Drawing.Size(32, 18);
            this.outputLabel1.TabIndex = 68;
            this.outputLabel1.Text = "test";
            this.outputLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // outputLabel2
            // 
            this.outputLabel2.AutoSize = true;
            this.outputLabel2.Location = new System.Drawing.Point(166, 111);
            this.outputLabel2.Name = "outputLabel2";
            this.outputLabel2.Size = new System.Drawing.Size(137, 18);
            this.outputLabel2.TabIndex = 69;
            this.outputLabel2.Text = "Done for UI Scale 100";
            this.outputLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.outputLabel2.Visible = false;
            // 
            // grabDigitsButton
            // 
            this.grabDigitsButton.BackColor = System.Drawing.Color.Pink;
            this.grabDigitsButton.FlatAppearance.BorderSize = 0;
            this.grabDigitsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepPink;
            this.grabDigitsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.HotPink;
            this.grabDigitsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grabDigitsButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grabDigitsButton.ForeColor = System.Drawing.Color.Black;
            this.grabDigitsButton.Location = new System.Drawing.Point(26, 123);
            this.grabDigitsButton.Name = "grabDigitsButton";
            this.grabDigitsButton.Size = new System.Drawing.Size(137, 31);
            this.grabDigitsButton.TabIndex = 70;
            this.grabDigitsButton.Text = "Grab Digits";
            this.toolTip.SetToolTip(this.grabDigitsButton, "This is with my automatic algorithm, less\r\naccurate than manually editing them ou" +
        "t.\r\nHave items with stack numbers from 1 to\r\n10 in the top of your inventory, in" +
        " order.");
            this.grabDigitsButton.UseVisualStyleBackColor = false;
            this.grabDigitsButton.Click += new System.EventHandler(this.grabDigitsButton_Click);
            // 
            // cropCheck
            // 
            this.cropCheck.AutoSize = true;
            this.cropCheck.Location = new System.Drawing.Point(169, 86);
            this.cropCheck.Name = "cropCheck";
            this.cropCheck.Size = new System.Drawing.Size(87, 22);
            this.cropCheck.TabIndex = 71;
            this.cropCheck.Text = "Auto crop";
            this.toolTip.SetToolTip(this.cropCheck, "Needs one sample of each UI scale.");
            this.cropCheck.UseVisualStyleBackColor = true;
            // 
            // toolTip
            // 
            this.toolTip.AutomaticDelay = 250;
            this.toolTip.AutoPopDelay = 5000;
            this.toolTip.InitialDelay = 250;
            this.toolTip.ReshowDelay = 50;
            // 
            // saveLocations
            // 
            this.saveLocations.BackColor = System.Drawing.Color.Pink;
            this.saveLocations.FlatAppearance.BorderSize = 0;
            this.saveLocations.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepPink;
            this.saveLocations.FlatAppearance.MouseOverBackColor = System.Drawing.Color.HotPink;
            this.saveLocations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveLocations.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveLocations.ForeColor = System.Drawing.Color.Black;
            this.saveLocations.Location = new System.Drawing.Point(26, 181);
            this.saveLocations.Name = "saveLocations";
            this.saveLocations.Size = new System.Drawing.Size(147, 39);
            this.saveLocations.TabIndex = 72;
            this.saveLocations.Text = "Save Farming Locations\r\n(ALL)";
            this.toolTip.SetToolTip(this.saveLocations, "Saved to All Grind Spot Locations.txt");
            this.saveLocations.UseVisualStyleBackColor = false;
            this.saveLocations.Click += new System.EventHandler(this.saveLocations_Click);
            // 
            // saveSpecialLocations
            // 
            this.saveSpecialLocations.BackColor = System.Drawing.Color.Pink;
            this.saveSpecialLocations.FlatAppearance.BorderSize = 0;
            this.saveSpecialLocations.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepPink;
            this.saveSpecialLocations.FlatAppearance.MouseOverBackColor = System.Drawing.Color.HotPink;
            this.saveSpecialLocations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveSpecialLocations.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveSpecialLocations.ForeColor = System.Drawing.Color.Black;
            this.saveSpecialLocations.Location = new System.Drawing.Point(26, 226);
            this.saveSpecialLocations.Name = "saveSpecialLocations";
            this.saveSpecialLocations.Size = new System.Drawing.Size(147, 39);
            this.saveSpecialLocations.TabIndex = 73;
            this.saveSpecialLocations.Text = "Save Farming Locations\r\n(only those with items)";
            this.toolTip.SetToolTip(this.saveSpecialLocations, "Saved to Grind Spot Locations With Items.txt");
            this.saveSpecialLocations.UseVisualStyleBackColor = false;
            this.saveSpecialLocations.Click += new System.EventHandler(this.saveSpecialLocations_Click);
            // 
            // saveItemsButton
            // 
            this.saveItemsButton.BackColor = System.Drawing.Color.Pink;
            this.saveItemsButton.FlatAppearance.BorderSize = 0;
            this.saveItemsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepPink;
            this.saveItemsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.HotPink;
            this.saveItemsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveItemsButton.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveItemsButton.ForeColor = System.Drawing.Color.Black;
            this.saveItemsButton.Location = new System.Drawing.Point(26, 271);
            this.saveItemsButton.Name = "saveItemsButton";
            this.saveItemsButton.Size = new System.Drawing.Size(147, 39);
            this.saveItemsButton.TabIndex = 74;
            this.saveItemsButton.Text = "Save All Unique Items";
            this.toolTip.SetToolTip(this.saveItemsButton, "Saved to Items List.txt");
            this.saveItemsButton.UseVisualStyleBackColor = false;
            this.saveItemsButton.Click += new System.EventHandler(this.saveItemsButton_Click);
            // 
            // displayCheck
            // 
            this.displayCheck.AutoSize = true;
            this.displayCheck.Checked = true;
            this.displayCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.displayCheck.Location = new System.Drawing.Point(169, 132);
            this.displayCheck.Name = "displayCheck";
            this.displayCheck.Size = new System.Drawing.Size(175, 22);
            this.displayCheck.TabIndex = 79;
            this.displayCheck.Text = "Bypass screen detection";
            this.toolTip.SetToolTip(this.displayCheck, "Applies to both Slots and Digits.");
            this.displayCheck.UseVisualStyleBackColor = true;
            // 
            // displayLabel
            // 
            this.displayLabel.AutoSize = true;
            this.displayLabel.Location = new System.Drawing.Point(3, 0);
            this.displayLabel.Name = "displayLabel";
            this.displayLabel.Size = new System.Drawing.Size(32, 18);
            this.displayLabel.TabIndex = 75;
            this.displayLabel.Text = "test";
            this.displayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // getScreenButton
            // 
            this.getScreenButton.BackColor = System.Drawing.Color.Pink;
            this.getScreenButton.FlatAppearance.BorderSize = 0;
            this.getScreenButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepPink;
            this.getScreenButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.HotPink;
            this.getScreenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getScreenButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getScreenButton.ForeColor = System.Drawing.Color.Black;
            this.getScreenButton.Location = new System.Drawing.Point(26, 374);
            this.getScreenButton.Name = "getScreenButton";
            this.getScreenButton.Size = new System.Drawing.Size(137, 31);
            this.getScreenButton.TabIndex = 77;
            this.getScreenButton.Text = "Get Screen";
            this.getScreenButton.UseVisualStyleBackColor = false;
            this.getScreenButton.Click += new System.EventHandler(this.getScreenButton_Click);
            // 
            // getInventoryButton
            // 
            this.getInventoryButton.BackColor = System.Drawing.Color.Pink;
            this.getInventoryButton.FlatAppearance.BorderSize = 0;
            this.getInventoryButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepPink;
            this.getInventoryButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.HotPink;
            this.getInventoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getInventoryButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getInventoryButton.ForeColor = System.Drawing.Color.Black;
            this.getInventoryButton.Location = new System.Drawing.Point(26, 337);
            this.getInventoryButton.Name = "getInventoryButton";
            this.getInventoryButton.Size = new System.Drawing.Size(137, 31);
            this.getInventoryButton.TabIndex = 76;
            this.getInventoryButton.Text = "Get Inventory";
            this.getInventoryButton.UseVisualStyleBackColor = false;
            this.getInventoryButton.Click += new System.EventHandler(this.getInventoryButton_Click);
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.Controls.Add(this.displayLabel);
            this.flowLayoutPanel.Controls.Add(this.outputLabel1);
            this.flowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel.Location = new System.Drawing.Point(352, 86);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(242, 336);
            this.flowLayoutPanel.TabIndex = 78;
            this.flowLayoutPanel.WrapContents = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.WorkerReportsProgress = true;
            this.backgroundWorker2.WorkerSupportsCancellation = true;
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            this.backgroundWorker2.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker2_ProgressChanged);
            // 
            // reportLabel2
            // 
            this.reportLabel2.AutoSize = true;
            this.reportLabel2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportLabel2.Location = new System.Drawing.Point(180, 279);
            this.reportLabel2.Name = "reportLabel2";
            this.reportLabel2.Size = new System.Drawing.Size(168, 14);
            this.reportLabel2.TabIndex = 85;
            this.reportLabel2.Text = "Unique icons on thread 2: 100";
            this.reportLabel2.Visible = false;
            // 
            // reportLabel1
            // 
            this.reportLabel1.AutoSize = true;
            this.reportLabel1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportLabel1.Location = new System.Drawing.Point(180, 266);
            this.reportLabel1.Name = "reportLabel1";
            this.reportLabel1.Size = new System.Drawing.Size(168, 14);
            this.reportLabel1.TabIndex = 84;
            this.reportLabel1.Text = "Unique icons on thread 1: 100";
            this.reportLabel1.Visible = false;
            // 
            // getAnimatedIcons
            // 
            this.getAnimatedIcons.BackColor = System.Drawing.Color.Pink;
            this.getAnimatedIcons.FlatAppearance.BorderSize = 0;
            this.getAnimatedIcons.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepPink;
            this.getAnimatedIcons.FlatAppearance.MouseOverBackColor = System.Drawing.Color.HotPink;
            this.getAnimatedIcons.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getAnimatedIcons.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getAnimatedIcons.ForeColor = System.Drawing.Color.Black;
            this.getAnimatedIcons.Location = new System.Drawing.Point(191, 226);
            this.getAnimatedIcons.Name = "getAnimatedIcons";
            this.getAnimatedIcons.Size = new System.Drawing.Size(147, 39);
            this.getAnimatedIcons.TabIndex = 83;
            this.getAnimatedIcons.Text = "Get Animated Icons\r\nRead ToolTip";
            this.toolTip.SetToolTip(this.getAnimatedIcons, resources.GetString("getAnimatedIcons.ToolTip"));
            this.getAnimatedIcons.UseVisualStyleBackColor = false;
            this.getAnimatedIcons.Click += new System.EventHandler(this.getAnimatedIcons_Click);
            // 
            // DevMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(594, 422);
            this.Controls.Add(this.reportLabel2);
            this.Controls.Add(this.reportLabel1);
            this.Controls.Add(this.getAnimatedIcons);
            this.Controls.Add(this.displayCheck);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.getScreenButton);
            this.Controls.Add(this.getInventoryButton);
            this.Controls.Add(this.saveItemsButton);
            this.Controls.Add(this.saveSpecialLocations);
            this.Controls.Add(this.saveLocations);
            this.Controls.Add(this.cropCheck);
            this.Controls.Add(this.grabDigitsButton);
            this.Controls.Add(this.outputLabel2);
            this.Controls.Add(this.grabSlotsButton);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.titleLabel);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DevMode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dev Tools";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DevMode_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DevMode_FormClosed);
            this.Load += new System.EventHandler(this.DevMode_Load);
            this.flowLayoutPanel.ResumeLayout(false);
            this.flowLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Button grabSlotsButton;
        private System.Windows.Forms.Label outputLabel1;
        private System.Windows.Forms.Label outputLabel2;
        private System.Windows.Forms.Button grabDigitsButton;
        private System.Windows.Forms.CheckBox cropCheck;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button saveLocations;
        private System.Windows.Forms.Button saveSpecialLocations;
        private System.Windows.Forms.Button saveItemsButton;
        private System.Windows.Forms.Label displayLabel;
        private System.Windows.Forms.Button getScreenButton;
        private System.Windows.Forms.Button getInventoryButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.CheckBox displayCheck;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Label reportLabel2;
        private System.Windows.Forms.Label reportLabel1;
        private System.Windows.Forms.Button getAnimatedIcons;
    }
}