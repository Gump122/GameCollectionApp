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
            this.ljwButton.Location = new System.Drawing.Point(149, 31);
            this.ljwButton.Name = "ljwButton";
            this.ljwButton.Size = new System.Drawing.Size(75, 23);
            this.ljwButton.TabIndex = 1;
            this.ljwButton.Text = "ljw";
            this.ljwButton.UseVisualStyleBackColor = true;
            this.ljwButton.Click += new System.EventHandler(this.ljwButton_Click);
            // 
            // xcButton
            // 
            this.xcButton.Location = new System.Drawing.Point(258, 31);
            this.xcButton.Name = "xcButton";
            this.xcButton.Size = new System.Drawing.Size(81, 22);
            this.xcButton.TabIndex = 2;
            this.xcButton.Text = "xc";
            this.xcButton.UseVisualStyleBackColor = true;
            this.xcButton.Click += new System.EventHandler(this.xcButton_Click);
            // 
            // swButton
            // 
            this.swButton.Location = new System.Drawing.Point(370, 31);
            this.swButton.Name = "swButton";
            this.swButton.Size = new System.Drawing.Size(84, 21);
            this.swButton.TabIndex = 3;
            this.swButton.Text = "sw";
            this.swButton.UseVisualStyleBackColor = true;
            this.swButton.Click += new System.EventHandler(this.swButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.swButton);
            this.Controls.Add(this.xcButton);
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
        private System.Windows.Forms.Button xcButton;
        private System.Windows.Forms.Button swButton;
    }
}