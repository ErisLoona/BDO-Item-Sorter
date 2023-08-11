namespace BDO_Item_Sorter
{
    partial class CategoryEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryEditor));
            this.categoryDisplay = new System.Windows.Forms.ListBox();
            this.categoryDrop = new System.Windows.Forms.ComboBox();
            this.doneButton = new System.Windows.Forms.Button();
            this.newCategoryLabel = new System.Windows.Forms.Label();
            this.newCategoryText = new System.Windows.Forms.TextBox();
            this.newLocationText = new System.Windows.Forms.TextBox();
            this.newLocationLabel = new System.Windows.Forms.Label();
            this.addCategory = new System.Windows.Forms.Button();
            this.addLocation = new System.Windows.Forms.Button();
            this.moveContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.moveUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveDownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attributeButton = new System.Windows.Forms.Button();
            this.cityDrop = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.moveContext.SuspendLayout();
            this.SuspendLayout();
            // 
            // categoryDisplay
            // 
            this.categoryDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.categoryDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.categoryDisplay.Dock = System.Windows.Forms.DockStyle.Left;
            this.categoryDisplay.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryDisplay.ForeColor = System.Drawing.Color.White;
            this.categoryDisplay.FormattingEnabled = true;
            this.categoryDisplay.HorizontalScrollbar = true;
            this.categoryDisplay.ItemHeight = 15;
            this.categoryDisplay.Location = new System.Drawing.Point(0, 0);
            this.categoryDisplay.Name = "categoryDisplay";
            this.categoryDisplay.Size = new System.Drawing.Size(146, 450);
            this.categoryDisplay.TabIndex = 0;
            this.categoryDisplay.MouseDown += new System.Windows.Forms.MouseEventHandler(this.categoryDisplay_MouseDown);
            // 
            // categoryDrop
            // 
            this.categoryDrop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryDrop.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryDrop.FormattingEnabled = true;
            this.categoryDrop.Location = new System.Drawing.Point(167, 192);
            this.categoryDrop.Name = "categoryDrop";
            this.categoryDrop.Size = new System.Drawing.Size(194, 27);
            this.categoryDrop.TabIndex = 1;
            this.categoryDrop.SelectedIndexChanged += new System.EventHandler(this.categoryDrop_SelectedIndexChanged);
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
            this.doneButton.Location = new System.Drawing.Point(696, 407);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(92, 31);
            this.doneButton.TabIndex = 66;
            this.doneButton.Text = "Done";
            this.doneButton.UseVisualStyleBackColor = false;
            this.doneButton.Click += new System.EventHandler(this.doneButton_Click);
            // 
            // newCategoryLabel
            // 
            this.newCategoryLabel.AutoSize = true;
            this.newCategoryLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newCategoryLabel.Location = new System.Drawing.Point(189, 9);
            this.newCategoryLabel.Name = "newCategoryLabel";
            this.newCategoryLabel.Size = new System.Drawing.Size(120, 23);
            this.newCategoryLabel.TabIndex = 67;
            this.newCategoryLabel.Text = "New category";
            this.newCategoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // newCategoryText
            // 
            this.newCategoryText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.newCategoryText.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newCategoryText.Location = new System.Drawing.Point(152, 35);
            this.newCategoryText.Name = "newCategoryText";
            this.newCategoryText.Size = new System.Drawing.Size(194, 20);
            this.newCategoryText.TabIndex = 68;
            // 
            // newLocationText
            // 
            this.newLocationText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.newLocationText.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newLocationText.Location = new System.Drawing.Point(554, 35);
            this.newLocationText.Name = "newLocationText";
            this.newLocationText.Size = new System.Drawing.Size(194, 20);
            this.newLocationText.TabIndex = 70;
            // 
            // newLocationLabel
            // 
            this.newLocationLabel.AutoSize = true;
            this.newLocationLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newLocationLabel.Location = new System.Drawing.Point(594, 9);
            this.newLocationLabel.Name = "newLocationLabel";
            this.newLocationLabel.Size = new System.Drawing.Size(114, 23);
            this.newLocationLabel.TabIndex = 69;
            this.newLocationLabel.Text = "New location";
            this.newLocationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addCategory
            // 
            this.addCategory.BackColor = System.Drawing.Color.Pink;
            this.addCategory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addCategory.BackgroundImage")));
            this.addCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addCategory.FlatAppearance.BorderSize = 0;
            this.addCategory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepPink;
            this.addCategory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.HotPink;
            this.addCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCategory.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCategory.ForeColor = System.Drawing.Color.Black;
            this.addCategory.Location = new System.Drawing.Point(352, 35);
            this.addCategory.Name = "addCategory";
            this.addCategory.Size = new System.Drawing.Size(20, 20);
            this.addCategory.TabIndex = 71;
            this.addCategory.UseVisualStyleBackColor = false;
            this.addCategory.Click += new System.EventHandler(this.addCategory_Click);
            // 
            // addLocation
            // 
            this.addLocation.BackColor = System.Drawing.Color.Pink;
            this.addLocation.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addLocation.BackgroundImage")));
            this.addLocation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addLocation.FlatAppearance.BorderSize = 0;
            this.addLocation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepPink;
            this.addLocation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.HotPink;
            this.addLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addLocation.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addLocation.ForeColor = System.Drawing.Color.Black;
            this.addLocation.Location = new System.Drawing.Point(754, 35);
            this.addLocation.Name = "addLocation";
            this.addLocation.Size = new System.Drawing.Size(20, 20);
            this.addLocation.TabIndex = 72;
            this.addLocation.UseVisualStyleBackColor = false;
            this.addLocation.Click += new System.EventHandler(this.addLocation_Click);
            // 
            // moveContext
            // 
            this.moveContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moveUpToolStripMenuItem,
            this.moveDownToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.moveContext.Name = "moveContext";
            this.moveContext.Size = new System.Drawing.Size(138, 70);
            // 
            // moveUpToolStripMenuItem
            // 
            this.moveUpToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.moveUpToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("moveUpToolStripMenuItem.Image")));
            this.moveUpToolStripMenuItem.Name = "moveUpToolStripMenuItem";
            this.moveUpToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.moveUpToolStripMenuItem.Text = "Move up";
            this.moveUpToolStripMenuItem.Click += new System.EventHandler(this.moveUpToolStripMenuItem_Click);
            // 
            // moveDownToolStripMenuItem
            // 
            this.moveDownToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("moveDownToolStripMenuItem.Image")));
            this.moveDownToolStripMenuItem.Name = "moveDownToolStripMenuItem";
            this.moveDownToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.moveDownToolStripMenuItem.Text = "Move down";
            this.moveDownToolStripMenuItem.Click += new System.EventHandler(this.moveDownToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteToolStripMenuItem.Image")));
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // attributeButton
            // 
            this.attributeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.attributeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("attributeButton.BackgroundImage")));
            this.attributeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.attributeButton.FlatAppearance.BorderSize = 0;
            this.attributeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Pink;
            this.attributeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(21)))));
            this.attributeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.attributeButton.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attributeButton.ForeColor = System.Drawing.Color.Black;
            this.attributeButton.Location = new System.Drawing.Point(367, 192);
            this.attributeButton.Name = "attributeButton";
            this.attributeButton.Size = new System.Drawing.Size(141, 27);
            this.attributeButton.TabIndex = 76;
            this.attributeButton.UseVisualStyleBackColor = false;
            this.attributeButton.Click += new System.EventHandler(this.attributeButton_Click);
            // 
            // cityDrop
            // 
            this.cityDrop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cityDrop.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityDrop.FormattingEnabled = true;
            this.cityDrop.Location = new System.Drawing.Point(514, 192);
            this.cityDrop.Name = "cityDrop";
            this.cityDrop.Size = new System.Drawing.Size(194, 27);
            this.cityDrop.TabIndex = 77;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(224, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 23);
            this.label1.TabIndex = 78;
            this.label1.Text = "Category";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(591, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 23);
            this.label2.TabIndex = 79;
            this.label2.Text = "City";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CategoryEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cityDrop);
            this.Controls.Add(this.attributeButton);
            this.Controls.Add(this.addLocation);
            this.Controls.Add(this.addCategory);
            this.Controls.Add(this.newLocationText);
            this.Controls.Add(this.newLocationLabel);
            this.Controls.Add(this.newCategoryText);
            this.Controls.Add(this.newCategoryLabel);
            this.Controls.Add(this.doneButton);
            this.Controls.Add(this.categoryDrop);
            this.Controls.Add(this.categoryDisplay);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CategoryEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Category Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CategoryEditor_FormClosing);
            this.Load += new System.EventHandler(this.CategoryEditor_Load);
            this.moveContext.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox categoryDisplay;
        private System.Windows.Forms.ComboBox categoryDrop;
        private System.Windows.Forms.Button doneButton;
        private System.Windows.Forms.Label newCategoryLabel;
        private System.Windows.Forms.TextBox newCategoryText;
        private System.Windows.Forms.TextBox newLocationText;
        private System.Windows.Forms.Label newLocationLabel;
        private System.Windows.Forms.Button addCategory;
        private System.Windows.Forms.Button addLocation;
        private System.Windows.Forms.ContextMenuStrip moveContext;
        private System.Windows.Forms.ToolStripMenuItem moveUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveDownToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Button attributeButton;
        private System.Windows.Forms.ComboBox cityDrop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}