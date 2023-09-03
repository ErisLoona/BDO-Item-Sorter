namespace BDO_Item_Sorter
{
    partial class DigitCalibration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DigitCalibration));
            this.closeButton = new System.Windows.Forms.Button();
            this.getDigitButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.tooltipLabel = new System.Windows.Forms.Label();
            this.itemSuggestionLabel = new System.Windows.Forms.Label();
            this.demoBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.demoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Pink;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepPink;
            this.closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.HotPink;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.Black;
            this.closeButton.Location = new System.Drawing.Point(374, 154);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(59, 31);
            this.closeButton.TabIndex = 67;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // getDigitButton
            // 
            this.getDigitButton.BackColor = System.Drawing.Color.Pink;
            this.getDigitButton.FlatAppearance.BorderSize = 0;
            this.getDigitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepPink;
            this.getDigitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.HotPink;
            this.getDigitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getDigitButton.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getDigitButton.ForeColor = System.Drawing.Color.Black;
            this.getDigitButton.Location = new System.Drawing.Point(177, 58);
            this.getDigitButton.Name = "getDigitButton";
            this.getDigitButton.Size = new System.Drawing.Size(90, 31);
            this.getDigitButton.TabIndex = 68;
            this.getDigitButton.Text = "Get Digit";
            this.getDigitButton.UseVisualStyleBackColor = false;
            this.getDigitButton.Click += new System.EventHandler(this.getDigitButton_Click);
            // 
            // helpButton
            // 
            this.helpButton.BackColor = System.Drawing.Color.Pink;
            this.helpButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("helpButton.BackgroundImage")));
            this.helpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.helpButton.FlatAppearance.BorderSize = 0;
            this.helpButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepPink;
            this.helpButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.HotPink;
            this.helpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpButton.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpButton.Location = new System.Drawing.Point(12, 152);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(31, 31);
            this.helpButton.TabIndex = 73;
            this.helpButton.UseVisualStyleBackColor = false;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // tooltipLabel
            // 
            this.tooltipLabel.AutoSize = true;
            this.tooltipLabel.Location = new System.Drawing.Point(52, 31);
            this.tooltipLabel.Name = "tooltipLabel";
            this.tooltipLabel.Size = new System.Drawing.Size(340, 18);
            this.tooltipLabel.TabIndex = 74;
            this.tooltipLabel.Text = "Please place a stack of 1 in your top-left inventory slot";
            // 
            // itemSuggestionLabel
            // 
            this.itemSuggestionLabel.AutoSize = true;
            this.itemSuggestionLabel.Location = new System.Drawing.Point(33, 8);
            this.itemSuggestionLabel.Name = "itemSuggestionLabel";
            this.itemSuggestionLabel.Size = new System.Drawing.Size(378, 18);
            this.itemSuggestionLabel.TabIndex = 75;
            this.itemSuggestionLabel.Text = "If possible, for best results use Small or Medium HP Potions.";
            // 
            // demoBox
            // 
            this.demoBox.Location = new System.Drawing.Point(167, 100);
            this.demoBox.Name = "demoBox";
            this.demoBox.Size = new System.Drawing.Size(100, 50);
            this.demoBox.TabIndex = 76;
            this.demoBox.TabStop = false;
            // 
            // DigitCalibration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(445, 195);
            this.Controls.Add(this.demoBox);
            this.Controls.Add(this.itemSuggestionLabel);
            this.Controls.Add(this.tooltipLabel);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.getDigitButton);
            this.Controls.Add(this.closeButton);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "DigitCalibration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Digit Calibration";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DigitCalibration_FormClosing);
            this.Load += new System.EventHandler(this.DigitCalibration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.demoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button getDigitButton;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Label tooltipLabel;
        private System.Windows.Forms.Label itemSuggestionLabel;
        private System.Windows.Forms.PictureBox demoBox;
    }
}