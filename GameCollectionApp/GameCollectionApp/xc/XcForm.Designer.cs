
namespace GameCollectionApp.xc
{
  partial class XcForm
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
            this.menuButton = new System.Windows.Forms.Button();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // menuButton
            // 
            this.menuButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.menuButton.Font = new System.Drawing.Font("黑体", 9F);
            this.menuButton.Location = new System.Drawing.Point(0, 0);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(94, 40);
            this.menuButton.TabIndex = 1;
            this.menuButton.Text = "菜单";
            this.menuButton.UseVisualStyleBackColor = true;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // scoreLabel
            // 
            this.scoreLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("黑体", 18F);
            this.scoreLabel.Location = new System.Drawing.Point(813, 899);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(141, 36);
            this.scoreLabel.TabIndex = 2;
            this.scoreLabel.Text = "得分：0";
            this.scoreLabel.Click += new System.EventHandler(this.scoreLabel_Click);
            // 
            // XcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1778, 1144);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.menuButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "XcForm";
            this.Text = "XcForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.XcForm_FormClosed);
            this.Load += new System.EventHandler(this.XcForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Button menuButton;
    private System.Windows.Forms.Label scoreLabel;
  }
}
