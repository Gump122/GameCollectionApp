namespace GameCollectionApp.ljw
{
    partial class LjwForm
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
            this.createButton = new System.Windows.Forms.Button();
            this.joinButton = new System.Windows.Forms.Button();
            this.port1 = new System.Windows.Forms.TextBox();
            this.ip2 = new System.Windows.Forms.TextBox();
            this.port2 = new System.Windows.Forms.TextBox();
            this.ip1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // createButton
            // 
            this.createButton.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.createButton.Location = new System.Drawing.Point(484, 63);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(114, 34);
            this.createButton.TabIndex = 0;
            this.createButton.Text = "create game";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // joinButton
            // 
            this.joinButton.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.joinButton.Location = new System.Drawing.Point(484, 136);
            this.joinButton.Name = "joinButton";
            this.joinButton.Size = new System.Drawing.Size(114, 34);
            this.joinButton.TabIndex = 1;
            this.joinButton.Text = "join game";
            this.joinButton.UseVisualStyleBackColor = true;
            this.joinButton.Click += new System.EventHandler(this.joinButton_Click);
            // 
            // port1
            // 
            this.port1.Location = new System.Drawing.Point(313, 73);
            this.port1.Name = "port1";
            this.port1.Size = new System.Drawing.Size(119, 21);
            this.port1.TabIndex = 2;
            // 
            // ip2
            // 
            this.ip2.Location = new System.Drawing.Point(81, 136);
            this.ip2.Name = "ip2";
            this.ip2.Size = new System.Drawing.Size(215, 21);
            this.ip2.TabIndex = 3;
            // 
            // port2
            // 
            this.port2.Location = new System.Drawing.Point(313, 136);
            this.port2.Name = "port2";
            this.port2.Size = new System.Drawing.Size(119, 21);
            this.port2.TabIndex = 4;
            // 
            // ip1
            // 
            this.ip1.Location = new System.Drawing.Point(81, 73);
            this.ip1.Name = "ip1";
            this.ip1.ReadOnly = true;
            this.ip1.Size = new System.Drawing.Size(215, 21);
            this.ip1.TabIndex = 5;
            // 
            // LjwForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 258);
            this.Controls.Add(this.ip1);
            this.Controls.Add(this.port2);
            this.Controls.Add(this.ip2);
            this.Controls.Add(this.port1);
            this.Controls.Add(this.joinButton);
            this.Controls.Add(this.createButton);
            this.Name = "LjwForm";
            this.Text = "LjwForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LjwForm_FormClosed);
            this.Load += new System.EventHandler(this.LjwForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button joinButton;
        private System.Windows.Forms.TextBox port1;
        private System.Windows.Forms.TextBox ip2;
        private System.Windows.Forms.TextBox port2;
        private System.Windows.Forms.TextBox ip1;
    }
}