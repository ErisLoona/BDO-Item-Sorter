namespace BDO_Item_Sorter
{
    partial class AlignmentSetter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlignmentSetter));
            this.screenBox = new System.Windows.Forms.PictureBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.zoomReticle = new System.Windows.Forms.PictureBox();
            this.setButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.screenBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomReticle)).BeginInit();
            this.SuspendLayout();
            // 
            // screenBox
            // 
            this.screenBox.Location = new System.Drawing.Point(0, 0);
            this.screenBox.Name = "screenBox";
            this.screenBox.Size = new System.Drawing.Size(100, 50);
            this.screenBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.screenBox.TabIndex = 0;
            this.screenBox.TabStop = false;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Pink;
            this.exitButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepPink;
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.HotPink;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.Black;
            this.exitButton.Location = new System.Drawing.Point(0, 419);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(800, 31);
            this.exitButton.TabIndex = 68;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // zoomReticle
            // 
            this.zoomReticle.BackColor = System.Drawing.Color.IndianRed;
            this.zoomReticle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.zoomReticle.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.zoomReticle.Image = ((System.Drawing.Image)(resources.GetObject("zoomReticle.Image")));
            this.zoomReticle.Location = new System.Drawing.Point(350, 138);
            this.zoomReticle.Name = "zoomReticle";
            this.zoomReticle.Size = new System.Drawing.Size(195, 195);
            this.zoomReticle.TabIndex = 69;
            this.zoomReticle.TabStop = false;
            this.zoomReticle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.zoomReticle_MouseDown);
            this.zoomReticle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.zoomReticle_MouseMove);
            this.zoomReticle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.zoomReticle_MouseUp);
            // 
            // setButton
            // 
            this.setButton.BackColor = System.Drawing.Color.Red;
            this.setButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.setButton.FlatAppearance.BorderSize = 0;
            this.setButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.setButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.setButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setButton.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setButton.ForeColor = System.Drawing.Color.White;
            this.setButton.Location = new System.Drawing.Point(0, 388);
            this.setButton.Name = "setButton";
            this.setButton.Size = new System.Drawing.Size(800, 31);
            this.setButton.TabIndex = 70;
            this.setButton.Text = "Set top left corner of the top left inventory slot INSIDE THE BORDER";
            this.setButton.UseVisualStyleBackColor = false;
            this.setButton.Click += new System.EventHandler(this.setButton_Click);
            // 
            // AlignmentSetter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.setButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.zoomReticle);
            this.Controls.Add(this.screenBox);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "AlignmentSetter";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Set Alignment";
            this.Load += new System.EventHandler(this.AlignmentSetter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.screenBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomReticle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox screenBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.PictureBox zoomReticle;
        private System.Windows.Forms.Button setButton;
    }
}