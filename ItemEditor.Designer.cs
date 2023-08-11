namespace BDO_Item_Sorter
{
    partial class ItemEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemEditor));
            this.doneButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.catDrop = new System.Windows.Forms.ComboBox();
            this.ignoredBox = new System.Windows.Forms.CheckBox();
            this.nameText = new System.Windows.Forms.TextBox();
            this.problematicBox = new System.Windows.Forms.CheckBox();
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
            this.doneButton.Location = new System.Drawing.Point(446, 222);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(92, 31);
            this.doneButton.TabIndex = 67;
            this.doneButton.Text = "Done";
            this.doneButton.UseVisualStyleBackColor = false;
            this.doneButton.Click += new System.EventHandler(this.doneButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(235, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 23);
            this.label2.TabIndex = 84;
            this.label2.Text = "Category";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // catDrop
            // 
            this.catDrop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.catDrop.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catDrop.FormattingEnabled = true;
            this.catDrop.Location = new System.Drawing.Point(178, 95);
            this.catDrop.Name = "catDrop";
            this.catDrop.Size = new System.Drawing.Size(194, 27);
            this.catDrop.TabIndex = 82;
            // 
            // ignoredBox
            // 
            this.ignoredBox.AutoSize = true;
            this.ignoredBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ignoredBox.Location = new System.Drawing.Point(387, 163);
            this.ignoredBox.Name = "ignoredBox";
            this.ignoredBox.Size = new System.Drawing.Size(107, 23);
            this.ignoredBox.TabIndex = 86;
            this.ignoredBox.Text = "Ignore item";
            this.ignoredBox.UseVisualStyleBackColor = true;
            // 
            // nameText
            // 
            this.nameText.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameText.Location = new System.Drawing.Point(24, 17);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(502, 27);
            this.nameText.TabIndex = 87;
            // 
            // problematicBox
            // 
            this.problematicBox.AutoSize = true;
            this.problematicBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.problematicBox.Location = new System.Drawing.Point(46, 163);
            this.problematicBox.Name = "problematicBox";
            this.problematicBox.Size = new System.Drawing.Size(139, 23);
            this.problematicBox.TabIndex = 85;
            this.problematicBox.Text = "Item shares icon";
            this.problematicBox.UseVisualStyleBackColor = true;
            // 
            // ItemEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(550, 265);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.ignoredBox);
            this.Controls.Add(this.problematicBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.catDrop);
            this.Controls.Add(this.doneButton);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ItemEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item Editor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ItemEditor_FormClosed);
            this.Load += new System.EventHandler(this.ItemEditor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button doneButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox catDrop;
        private System.Windows.Forms.CheckBox ignoredBox;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.CheckBox problematicBox;
    }
}