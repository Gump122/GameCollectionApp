namespace GameCollectionApp
{
    partial class MainForm
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
            this.dkButton = new System.Windows.Forms.Button();
            this.ljwButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dkButton
            // 
            this.dkButton.Location = new System.Drawing.Point(38, 32);
            this.dkButton.Name = "dkButton";
            this.dkButton.Size = new System.Drawing.Size(75, 23);
            this.dkButton.TabIndex = 0;
            this.dkButton.Text = "dk";
            this.dkButton.UseVisualStyleBackColor = true;
            this.dkButton.Click += new System.EventHandler(this.dkButton_Click);
            // 
            // ljwButton
            // 
            this.ljwButton.Location = new System.Drawing.Point(159, 31);
            this.ljwButton.Name = "ljwButton";
            this.ljwButton.Size = new System.Drawing.Size(75, 23);
            this.ljwButton.TabIndex = 1;
            this.ljwButton.Text = "ljw";
            this.ljwButton.UseVisualStyleBackColor = true;
            this.ljwButton.Click += new System.EventHandler(this.ljwButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ljwButton);
            this.Controls.Add(this.dkButton);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Click += new System.EventHandler(this.MainForm_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button dkButton;
        private System.Windows.Forms.Button ljwButton;
    }
}