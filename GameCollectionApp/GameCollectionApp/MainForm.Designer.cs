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
            this.xcButton = new System.Windows.Forms.Button();
            this.swButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dkButton
            // 
            this.dkButton.Location = new System.Drawing.Point(51, 40);
            this.dkButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dkButton.Name = "dkButton";
            this.dkButton.Size = new System.Drawing.Size(100, 28);
            this.dkButton.TabIndex = 0;
            this.dkButton.Text = "dk";
            this.dkButton.UseVisualStyleBackColor = true;
            this.dkButton.Click += new System.EventHandler(this.dkButton_Click);
            // 
            // ljwButton
            // 
            this.ljwButton.Location = new System.Drawing.Point(212, 38);
            this.ljwButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ljwButton.Name = "ljwButton";
            this.ljwButton.Size = new System.Drawing.Size(100, 28);
            this.ljwButton.TabIndex = 1;
            this.ljwButton.Text = "ljw";
            this.ljwButton.UseVisualStyleBackColor = true;
            this.ljwButton.Click += new System.EventHandler(this.ljwButton_Click);
            // 
            // xcButton
            // 
            this.xcButton.Location = new System.Drawing.Point(387, 40);
            this.xcButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.xcButton.Name = "xcButton";
            this.xcButton.Size = new System.Drawing.Size(88, 27);
            this.xcButton.TabIndex = 2;
            this.xcButton.Text = "xc";
            this.xcButton.UseVisualStyleBackColor = true;
            this.xcButton.Click += new System.EventHandler(this.xcButton_Click);
            // 
            // swButton
            // 
            this.swButton.Location = new System.Drawing.Point(549, 38);
            this.swButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.swButton.Name = "swButton";
            this.swButton.Size = new System.Drawing.Size(100, 28);
            this.swButton.TabIndex = 3;
            this.swButton.Text = "sw";
            this.swButton.UseVisualStyleBackColor = true;
            this.swButton.Click += new System.EventHandler(this.swButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.swButton);
            this.Controls.Add(this.xcButton);
            this.Controls.Add(this.ljwButton);
            this.Controls.Add(this.dkButton);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Click += new System.EventHandler(this.MainForm_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button dkButton;
        private System.Windows.Forms.Button ljwButton;
        private System.Windows.Forms.Button xcButton;
        private System.Windows.Forms.Button swButton;
    }
}
