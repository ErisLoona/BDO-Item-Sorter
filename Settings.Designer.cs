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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.doneButton = new System.Windows.Forms.Button();
            this.alignmentButton = new System.Windows.Forms.Button();
            this.screenButton = new System.Windows.Forms.Button();
            this.screenDrop = new System.Windows.Forms.ComboBox();
            this.screenLabel = new System.Windows.Forms.Label();
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
            this.doneButton.Location = new System.Drawing.Point(231, 198);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(61, 31);
            this.doneButton.TabIndex = 67;
            this.doneButton.Text = "Done";
            this.doneButton.UseVisualStyleBackColor = false;
            this.doneButton.Click += new System.EventHandler(this.doneButton_Click);
            // 
            // alignmentButton
            // 
            this.alignmentButton.BackColor = System.Drawing.Color.Red;
            this.alignmentButton.FlatAppearance.BorderSize = 0;
            this.alignmentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.alignmentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.alignmentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.alignmentButton.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alignmentButton.ForeColor = System.Drawing.Color.White;
            this.alignmentButton.Location = new System.Drawing.Point(65, 146);
            this.alignmentButton.Name = "alignmentButton";
            this.alignmentButton.Size = new System.Drawing.Size(167, 31);
            this.alignmentButton.TabIndex = 68;
            this.alignmentButton.Text = "Set Alignment";
            this.alignmentButton.UseVisualStyleBackColor = false;
            this.alignmentButton.Click += new System.EventHandler(this.alignmentButton_Click);
            // 
            // screenButton
            // 
            this.screenButton.BackColor = System.Drawing.Color.Pink;
            this.screenButton.FlatAppearance.BorderSize = 0;
            this.screenButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepPink;
            this.screenButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.HotPink;
            this.screenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.screenButton.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.screenButton.ForeColor = System.Drawing.Color.Black;
            this.screenButton.Location = new System.Drawing.Point(99, 92);
            this.screenButton.Name = "screenButton";
            this.screenButton.Size = new System.Drawing.Size(106, 31);
            this.screenButton.TabIndex = 71;
            this.screenButton.Text = "Set Screen";
            this.screenButton.UseVisualStyleBackColor = false;
            this.screenButton.Click += new System.EventHandler(this.screenButton_Click);
            // 
            // screenDrop
            // 
            this.screenDrop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.screenDrop.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.screenDrop.FormattingEnabled = true;
            this.screenDrop.Location = new System.Drawing.Point(39, 59);
            this.screenDrop.Name = "screenDrop";
            this.screenDrop.Size = new System.Drawing.Size(227, 27);
            this.screenDrop.TabIndex = 70;
            // 
            // screenLabel
            // 
            this.screenLabel.AutoSize = true;
            this.screenLabel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.screenLabel.Location = new System.Drawing.Point(88, 24);
            this.screenLabel.Name = "screenLabel";
            this.screenLabel.Size = new System.Drawing.Size(128, 29);
            this.screenLabel.TabIndex = 69;
            this.screenLabel.Text = "BDO Screen";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(304, 241);
            this.Controls.Add(this.screenButton);
            this.Controls.Add(this.screenDrop);
            this.Controls.Add(this.screenLabel);
            this.Controls.Add(this.alignmentButton);
            this.Controls.Add(this.doneButton);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Settings_FormClosing);
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button doneButton;
        private System.Windows.Forms.Button alignmentButton;
        private System.Windows.Forms.Button screenButton;
        private System.Windows.Forms.ComboBox screenDrop;
        private System.Windows.Forms.Label screenLabel;
    }
}