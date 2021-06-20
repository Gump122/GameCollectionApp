
namespace GameCollectionApp.sw
{
    partial class settingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(settingForm));
            this.setmoney = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.resetmoney = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.resethp = new System.Windows.Forms.Button();
            this.sethp = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.resetad = new System.Windows.Forms.Button();
            this.setad = new System.Windows.Forms.NumericUpDown();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.resetap = new System.Windows.Forms.Button();
            this.setap = new System.Windows.Forms.NumericUpDown();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.resetarmor = new System.Windows.Forms.Button();
            this.setarmor = new System.Windows.Forms.NumericUpDown();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.resetmagicResistance = new System.Windows.Forms.Button();
            this.setmagicResistance = new System.Windows.Forms.NumericUpDown();
            this.help = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.setmoney)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sethp)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.setad)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.setap)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.setarmor)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.setmagicResistance)).BeginInit();
            this.SuspendLayout();
            // 
            // setmoney
            // 
            this.setmoney.Location = new System.Drawing.Point(6, 24);
            this.setmoney.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.setmoney.Name = "setmoney";
            this.setmoney.Size = new System.Drawing.Size(95, 23);
            this.setmoney.TabIndex = 0;
            this.setmoney.ValueChanged += new System.EventHandler(this.setmoney_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox1.Controls.Add(this.resetmoney);
            this.groupBox1.Controls.Add(this.setmoney);
            this.groupBox1.Font = new System.Drawing.Font("华文琥珀", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 68);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "初始金钱";
            // 
            // resetmoney
            // 
            this.resetmoney.Location = new System.Drawing.Point(115, 24);
            this.resetmoney.Name = "resetmoney";
            this.resetmoney.Size = new System.Drawing.Size(81, 26);
            this.resetmoney.TabIndex = 1;
            this.resetmoney.Text = "重置";
            this.resetmoney.UseVisualStyleBackColor = true;
            this.resetmoney.Click += new System.EventHandler(this.resetmoney_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox2.Controls.Add(this.resethp);
            this.groupBox2.Controls.Add(this.sethp);
            this.groupBox2.Font = new System.Drawing.Font("华文琥珀", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(250, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(202, 68);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "初始血量";
            // 
            // resethp
            // 
            this.resethp.Location = new System.Drawing.Point(115, 24);
            this.resethp.Name = "resethp";
            this.resethp.Size = new System.Drawing.Size(81, 26);
            this.resethp.TabIndex = 1;
            this.resethp.Text = "重置";
            this.resethp.UseVisualStyleBackColor = true;
            this.resethp.Click += new System.EventHandler(this.resethp_Click);
            // 
            // sethp
            // 
            this.sethp.Location = new System.Drawing.Point(6, 24);
            this.sethp.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.sethp.Name = "sethp";
            this.sethp.Size = new System.Drawing.Size(95, 23);
            this.sethp.TabIndex = 0;
            this.sethp.ValueChanged += new System.EventHandler(this.sethp_ValueChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox3.Controls.Add(this.resetad);
            this.groupBox3.Controls.Add(this.setad);
            this.groupBox3.Font = new System.Drawing.Font("华文琥珀", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.Location = new System.Drawing.Point(12, 86);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(202, 68);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "初始攻击";
            // 
            // resetad
            // 
            this.resetad.Location = new System.Drawing.Point(115, 24);
            this.resetad.Name = "resetad";
            this.resetad.Size = new System.Drawing.Size(81, 26);
            this.resetad.TabIndex = 1;
            this.resetad.Text = "重置";
            this.resetad.UseVisualStyleBackColor = true;
            this.resetad.Click += new System.EventHandler(this.resetad_Click);
            // 
            // setad
            // 
            this.setad.Location = new System.Drawing.Point(6, 24);
            this.setad.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.setad.Name = "setad";
            this.setad.Size = new System.Drawing.Size(95, 23);
            this.setad.TabIndex = 0;
            this.setad.ValueChanged += new System.EventHandler(this.setad_ValueChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox4.Controls.Add(this.resetap);
            this.groupBox4.Controls.Add(this.setap);
            this.groupBox4.Font = new System.Drawing.Font("华文琥珀", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox4.Location = new System.Drawing.Point(250, 86);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(202, 68);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "初始法强";
            // 
            // resetap
            // 
            this.resetap.Location = new System.Drawing.Point(115, 24);
            this.resetap.Name = "resetap";
            this.resetap.Size = new System.Drawing.Size(81, 26);
            this.resetap.TabIndex = 1;
            this.resetap.Text = "重置";
            this.resetap.UseVisualStyleBackColor = true;
            this.resetap.Click += new System.EventHandler(this.resetap_Click);
            // 
            // setap
            // 
            this.setap.Location = new System.Drawing.Point(6, 24);
            this.setap.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.setap.Name = "setap";
            this.setap.Size = new System.Drawing.Size(95, 23);
            this.setap.TabIndex = 0;
            this.setap.ValueChanged += new System.EventHandler(this.setap_ValueChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox5.Controls.Add(this.resetarmor);
            this.groupBox5.Controls.Add(this.setarmor);
            this.groupBox5.Font = new System.Drawing.Font("华文琥珀", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox5.Location = new System.Drawing.Point(12, 160);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(202, 68);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "初始物抗";
            // 
            // resetarmor
            // 
            this.resetarmor.Location = new System.Drawing.Point(115, 24);
            this.resetarmor.Name = "resetarmor";
            this.resetarmor.Size = new System.Drawing.Size(81, 26);
            this.resetarmor.TabIndex = 1;
            this.resetarmor.Text = "重置";
            this.resetarmor.UseVisualStyleBackColor = true;
            this.resetarmor.Click += new System.EventHandler(this.resetarmor_Click);
            // 
            // setarmor
            // 
            this.setarmor.Location = new System.Drawing.Point(6, 24);
            this.setarmor.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.setarmor.Name = "setarmor";
            this.setarmor.Size = new System.Drawing.Size(95, 23);
            this.setarmor.TabIndex = 0;
            this.setarmor.ValueChanged += new System.EventHandler(this.setarmor_ValueChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox6.Controls.Add(this.resetmagicResistance);
            this.groupBox6.Controls.Add(this.setmagicResistance);
            this.groupBox6.Font = new System.Drawing.Font("华文琥珀", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox6.Location = new System.Drawing.Point(250, 160);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(202, 68);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "初始魔抗";
            // 
            // resetmagicResistance
            // 
            this.resetmagicResistance.Location = new System.Drawing.Point(115, 24);
            this.resetmagicResistance.Name = "resetmagicResistance";
            this.resetmagicResistance.Size = new System.Drawing.Size(81, 26);
            this.resetmagicResistance.TabIndex = 1;
            this.resetmagicResistance.Text = "重置";
            this.resetmagicResistance.UseVisualStyleBackColor = true;
            this.resetmagicResistance.Click += new System.EventHandler(this.resetmagicResistance_Click);
            // 
            // setmagicResistance
            // 
            this.setmagicResistance.Location = new System.Drawing.Point(6, 24);
            this.setmagicResistance.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.setmagicResistance.Name = "setmagicResistance";
            this.setmagicResistance.Size = new System.Drawing.Size(95, 23);
            this.setmagicResistance.TabIndex = 0;
            this.setmagicResistance.ValueChanged += new System.EventHandler(this.setmagicResistance_ValueChanged);
            // 
            // help
            // 
            this.help.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.help.Location = new System.Drawing.Point(18, 248);
            this.help.Multiline = true;
            this.help.Name = "help";
            this.help.ReadOnly = true;
            this.help.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.help.Size = new System.Drawing.Size(428, 181);
            this.help.TabIndex = 3;
            this.help.Text = resources.GetString("help.Text");
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.save.Font = new System.Drawing.Font("华文琥珀", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.save.Location = new System.Drawing.Point(179, 435);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(95, 36);
            this.save.TabIndex = 4;
            this.save.Text = "保存修改";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // settingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 479);
            this.Controls.Add(this.save);
            this.Controls.Add(this.help);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "settingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设置";
            ((System.ComponentModel.ISupportInitialize)(this.setmoney)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sethp)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.setad)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.setap)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.setarmor)).EndInit();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.setmagicResistance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown setmoney;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button resetmoney;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button resethp;
        private System.Windows.Forms.NumericUpDown sethp;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button resetad;
        private System.Windows.Forms.NumericUpDown setad;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button resetap;
        private System.Windows.Forms.NumericUpDown setap;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button resetarmor;
        private System.Windows.Forms.NumericUpDown setarmor;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button resetmagicResistance;
        private System.Windows.Forms.NumericUpDown setmagicResistance;
        private System.Windows.Forms.TextBox help;
        private System.Windows.Forms.Button save;
    }
}