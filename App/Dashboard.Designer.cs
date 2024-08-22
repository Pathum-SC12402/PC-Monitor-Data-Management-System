namespace App
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.stateItem = new System.Windows.Forms.PictureBox();
            this.searchItem = new System.Windows.Forms.PictureBox();
            this.updateItem = new System.Windows.Forms.PictureBox();
            this.deleteItem = new System.Windows.Forms.PictureBox();
            this.addItem = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stateItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updateItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addItem)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel1.Controls.Add(this.stateItem);
            this.panel1.Controls.Add(this.searchItem);
            this.panel1.Controls.Add(this.updateItem);
            this.panel1.Controls.Add(this.deleteItem);
            this.panel1.Controls.Add(this.addItem);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1195, 675);
            this.panel1.TabIndex = 0;
            // 
            // stateItem
            // 
            this.stateItem.Image = ((System.Drawing.Image)(resources.GetObject("stateItem.Image")));
            this.stateItem.Location = new System.Drawing.Point(681, 396);
            this.stateItem.Name = "stateItem";
            this.stateItem.Size = new System.Drawing.Size(216, 233);
            this.stateItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.stateItem.TabIndex = 5;
            this.stateItem.TabStop = false;
            this.stateItem.Click += new System.EventHandler(this.stateItem_Click);
            // 
            // searchItem
            // 
            this.searchItem.Image = ((System.Drawing.Image)(resources.GetObject("searchItem.Image")));
            this.searchItem.Location = new System.Drawing.Point(293, 396);
            this.searchItem.Name = "searchItem";
            this.searchItem.Size = new System.Drawing.Size(216, 233);
            this.searchItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.searchItem.TabIndex = 4;
            this.searchItem.TabStop = false;
            this.searchItem.Click += new System.EventHandler(this.searchItem_Click);
            // 
            // updateItem
            // 
            this.updateItem.Image = ((System.Drawing.Image)(resources.GetObject("updateItem.Image")));
            this.updateItem.Location = new System.Drawing.Point(872, 121);
            this.updateItem.Name = "updateItem";
            this.updateItem.Size = new System.Drawing.Size(216, 233);
            this.updateItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.updateItem.TabIndex = 3;
            this.updateItem.TabStop = false;
            // 
            // deleteItem
            // 
            this.deleteItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteItem.Image")));
            this.deleteItem.Location = new System.Drawing.Point(486, 121);
            this.deleteItem.Name = "deleteItem";
            this.deleteItem.Size = new System.Drawing.Size(216, 233);
            this.deleteItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.deleteItem.TabIndex = 2;
            this.deleteItem.TabStop = false;
            // 
            // addItem
            // 
            this.addItem.Image = ((System.Drawing.Image)(resources.GetObject("addItem.Image")));
            this.addItem.Location = new System.Drawing.Point(98, 121);
            this.addItem.Name = "addItem";
            this.addItem.Size = new System.Drawing.Size(216, 233);
            this.addItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.addItem.TabIndex = 1;
            this.addItem.TabStop = false;
            this.addItem.Click += new System.EventHandler(this.addItem_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1192, 73);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ebrima", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(440, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(749, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "PC Monitor Data Management System";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 670);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stateItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updateItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addItem)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox deleteItem;
        private System.Windows.Forms.PictureBox addItem;
        private System.Windows.Forms.PictureBox updateItem;
        private System.Windows.Forms.PictureBox stateItem;
        private System.Windows.Forms.PictureBox searchItem;
    }
}