namespace BDO_Item_Sorter
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.doneButton = new System.Windows.Forms.Button();
            this.garmothText = new System.Windows.Forms.TextBox();
            this.garmothLabel = new System.Windows.Forms.Label();
            this.creditsLabel = new System.Windows.Forms.Label();
            this.donateButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.alignmentCheck = new System.Windows.Forms.CheckBox();
            this.updatingLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // doneButton
            // 
            this.doneButton.BackColor = System.Drawing.Color.Pink;
            this.doneButton.FlatAppearance.BorderSize = 0;
            this.doneButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepPink;
            this.doneButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.HotPink;
            this.doneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doneButton.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doneButton.ForeColor = System.Drawing.Color.Black;
            this.doneButton.Location = new System.Drawing.Point(114, 101);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(61, 31);
            this.doneButton.TabIndex = 67;
            this.doneButton.Text = "Done";
            this.doneButton.UseVisualStyleBackColor = false;
            this.doneButton.Click += new System.EventHandler(this.doneButton_Click);
            // 
            // garmothText
            // 
            this.garmothText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.garmothText.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.garmothText.Location = new System.Drawing.Point(72, 41);
            this.garmothText.Name = "garmothText";
            this.garmothText.Size = new System.Drawing.Size(145, 20);
            this.garmothText.TabIndex = 72;
            this.garmothText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip.SetToolTip(this.garmothText, "Go to garmoth, to Grind Tracker.\r\nThe URL will look like \".../grind-tracker/Somet" +
        "hing/summary\"\r\nYou want the \"something\" bit, copy-paste it here.");
            // 
            // garmothLabel
            // 
            this.garmothLabel.AutoSize = true;
            this.garmothLabel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.garmothLabel.Location = new System.Drawing.Point(72, 6);
            this.garmothLabel.Name = "garmothLabel";
            this.garmothLabel.Size = new System.Drawing.Size(144, 29);
            this.garmothLabel.TabIndex = 73;
            this.garmothLabel.Text = "Garmoth URL";
            this.garmothLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // creditsLabel
            // 
            this.creditsLabel.AutoSize = true;
            this.creditsLabel.ForeColor = System.Drawing.Color.MediumPurple;
            this.creditsLabel.Location = new System.Drawing.Point(192, 126);
            this.creditsLabel.Name = "creditsLabel";
            this.creditsLabel.Size = new System.Drawing.Size(97, 13);
            this.creditsLabel.TabIndex = 81;
            this.creditsLabel.Text = "made by Eris Loona";
            // 
            // donateButton
            // 
            this.donateButton.BackColor = System.Drawing.Color.MediumPurple;
            this.donateButton.FlatAppearance.BorderSize = 0;
            this.donateButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo;
            this.donateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            this.donateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.donateButton.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donateButton.ForeColor = System.Drawing.Color.Black;
            this.donateButton.Location = new System.Drawing.Point(236, 102);
            this.donateButton.Name = "donateButton";
            this.donateButton.Size = new System.Drawing.Size(50, 22);
            this.donateButton.TabIndex = 82;
            this.donateButton.Text = "Donate";
            this.toolTip.SetToolTip(this.donateButton, "Donate to me on ko-fi!");
            this.donateButton.UseVisualStyleBackColor = false;
            this.donateButton.Click += new System.EventHandler(this.donateButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.Pink;
            this.updateButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("updateButton.BackgroundImage")));
            this.updateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.updateButton.FlatAppearance.BorderSize = 0;
            this.updateButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepPink;
            this.updateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.HotPink;
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateButton.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(4, 109);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(28, 28);
            this.updateButton.TabIndex = 84;
            this.toolTip.SetToolTip(this.updateButton, "Update icon database.");
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // toolTip
            // 
            this.toolTip.AutomaticDelay = 250;
            this.toolTip.AutoPopDelay = 5000;
            this.toolTip.InitialDelay = 250;
            this.toolTip.ReshowDelay = 50;
            // 
            // alignmentCheck
            // 
            this.alignmentCheck.AutoSize = true;
            this.alignmentCheck.Location = new System.Drawing.Point(93, 73);
            this.alignmentCheck.Name = "alignmentCheck";
            this.alignmentCheck.Size = new System.Drawing.Size(102, 17);
            this.alignmentCheck.TabIndex = 85;
            this.alignmentCheck.Text = "Force alignment";
            this.toolTip.SetToolTip(this.alignmentCheck, resources.GetString("alignmentCheck.ToolTip"));
            this.alignmentCheck.UseVisualStyleBackColor = true;
            this.alignmentCheck.Click += new System.EventHandler(this.alignmentCheck_Click);
            // 
            // updatingLabel
            // 
            this.updatingLabel.AutoSize = true;
            this.updatingLabel.Location = new System.Drawing.Point(32, 117);
            this.updatingLabel.Name = "updatingLabel";
            this.updatingLabel.Size = new System.Drawing.Size(58, 13);
            this.updatingLabel.TabIndex = 86;
            this.updatingLabel.Text = "Updating...";
            this.updatingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.updatingLabel.Visible = false;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(289, 141);
            this.Controls.Add(this.updatingLabel);
            this.Controls.Add(this.alignmentCheck);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.donateButton);
            this.Controls.Add(this.creditsLabel);
            this.Controls.Add(this.garmothLabel);
            this.Controls.Add(this.garmothText);
            this.Controls.Add(this.doneButton);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Settings_FormClosing);
            this.Load += new System.EventHandler(this.Settings_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Settings_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Settings_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button doneButton;
        private System.Windows.Forms.TextBox garmothText;
        private System.Windows.Forms.Label garmothLabel;
        private System.Windows.Forms.Label creditsLabel;
        private System.Windows.Forms.Button donateButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.CheckBox alignmentCheck;
        private System.Windows.Forms.Label updatingLabel;
    }
}