namespace Resturant_AE0524
{
    partial class frmWelcome
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btmDrinks = new System.Windows.Forms.Button();
            this.btmStarters = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btmDrinks);
            this.panel1.Controls.Add(this.btmStarters);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 547);
            this.panel1.TabIndex = 0;
            // 
            // btmDrinks
            // 
            this.btmDrinks.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btmDrinks.Image = global::Resturant_AE0524.Properties.Resources.Drinks;
            this.btmDrinks.Location = new System.Drawing.Point(11, 153);
            this.btmDrinks.Name = "btmDrinks";
            this.btmDrinks.Size = new System.Drawing.Size(219, 60);
            this.btmDrinks.TabIndex = 1;
            this.btmDrinks.Text = "Drinks";
            this.btmDrinks.UseVisualStyleBackColor = true;
            // 
            // btmStarters
            // 
            this.btmStarters.BackgroundImage = global::Resturant_AE0524.Properties.Resources.starters;
            this.btmStarters.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btmStarters.Image = global::Resturant_AE0524.Properties.Resources.starters;
            this.btmStarters.Location = new System.Drawing.Point(11, 83);
            this.btmStarters.Name = "btmStarters";
            this.btmStarters.Size = new System.Drawing.Size(219, 64);
            this.btmStarters.TabIndex = 0;
            this.btmStarters.Text = "Starters";
            this.btmStarters.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(249, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(551, 60);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your Favorite Restaurant";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // frmWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(800, 547);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmWelcome";
            this.Text = "Welcome";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button btmDrinks;
        private Button btmStarters;
        private Panel panel2;
        private Label label1;
    }
}