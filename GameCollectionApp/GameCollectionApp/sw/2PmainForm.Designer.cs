
namespace GameCollectionApp.sw
{
    partial class SwForm
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
            this.attack1 = new System.Windows.Forms.Button();
            this.equipment1 = new System.Windows.Forms.Button();
            this.equipment2 = new System.Windows.Forms.Button();
            this.lost1 = new System.Windows.Forms.Button();
            this.lost2 = new System.Windows.Forms.Button();
            this.begin = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.skill1 = new System.Windows.Forms.Button();
            this.skill2 = new System.Windows.Forms.Button();
            this.turn = new System.Windows.Forms.Label();
            this.hp1 = new System.Windows.Forms.Label();
            this.hp2 = new System.Windows.Forms.Label();
            this.attack2 = new System.Windows.Forms.Button();
            this.skillattack1 = new System.Windows.Forms.Button();
            this.skillattack2 = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.check1 = new System.Windows.Forms.Button();
            this.check2 = new System.Windows.Forms.Button();
            this.skipturn1 = new System.Windows.Forms.Button();
            this.skipturn2 = new System.Windows.Forms.Button();
            this.setting = new System.Windows.Forms.Button();
            this.restart = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.player1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.player2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // attack1
            // 
            this.attack1.Enabled = false;
            this.attack1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.attack1.Location = new System.Drawing.Point(95, 129);
            this.attack1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.attack1.Name = "attack1";
            this.attack1.Size = new System.Drawing.Size(96, 38);
            this.attack1.TabIndex = 4;
            this.attack1.Text = "普通攻击";
            this.attack1.UseVisualStyleBackColor = true;
            this.attack1.Click += new System.EventHandler(this.attack1_Click);
            // 
            // equipment1
            // 
            this.equipment1.Enabled = false;
            this.equipment1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.equipment1.Location = new System.Drawing.Point(95, 258);
            this.equipment1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.equipment1.Name = "equipment1";
            this.equipment1.Size = new System.Drawing.Size(96, 38);
            this.equipment1.TabIndex = 5;
            this.equipment1.Text = "购买装备";
            this.equipment1.UseVisualStyleBackColor = true;
            this.equipment1.Click += new System.EventHandler(this.equipment1_Click);
            // 
            // equipment2
            // 
            this.equipment2.Enabled = false;
            this.equipment2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.equipment2.Location = new System.Drawing.Point(171, 256);
            this.equipment2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.equipment2.Name = "equipment2";
            this.equipment2.Size = new System.Drawing.Size(96, 38);
            this.equipment2.TabIndex = 7;
            this.equipment2.Text = "购买装备";
            this.equipment2.UseVisualStyleBackColor = true;
            this.equipment2.Click += new System.EventHandler(this.equipment2_Click);
            // 
            // lost1
            // 
            this.lost1.Enabled = false;
            this.lost1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lost1.Location = new System.Drawing.Point(95, 318);
            this.lost1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lost1.Name = "lost1";
            this.lost1.Size = new System.Drawing.Size(96, 38);
            this.lost1.TabIndex = 8;
            this.lost1.Text = "投降";
            this.lost1.UseVisualStyleBackColor = true;
            this.lost1.Click += new System.EventHandler(this.lost1_Click);
            // 
            // lost2
            // 
            this.lost2.Enabled = false;
            this.lost2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lost2.Location = new System.Drawing.Point(171, 318);
            this.lost2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lost2.Name = "lost2";
            this.lost2.Size = new System.Drawing.Size(96, 38);
            this.lost2.TabIndex = 9;
            this.lost2.Text = "投降";
            this.lost2.UseVisualStyleBackColor = true;
            this.lost2.Click += new System.EventHandler(this.lost2_Click);
            // 
            // begin
            // 
            this.begin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.begin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.begin.Location = new System.Drawing.Point(427, 491);
            this.begin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.begin.Name = "begin";
            this.begin.Size = new System.Drawing.Size(131, 58);
            this.begin.TabIndex = 10;
            this.begin.Text = "开始游戏";
            this.begin.UseVisualStyleBackColor = false;
            this.begin.Click += new System.EventHandler(this.begin_Click);
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.exit.Location = new System.Drawing.Point(901, 12);
            this.exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 42);
            this.exit.TabIndex = 11;
            this.exit.Text = "退出";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // skill1
            // 
            this.skill1.Enabled = false;
            this.skill1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skill1.Location = new System.Drawing.Point(95, 65);
            this.skill1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.skill1.Name = "skill1";
            this.skill1.Size = new System.Drawing.Size(96, 38);
            this.skill1.TabIndex = 12;
            this.skill1.Text = "技能准备";
            this.skill1.UseVisualStyleBackColor = true;
            this.skill1.Click += new System.EventHandler(this.skill1_Click);
            // 
            // skill2
            // 
            this.skill2.Enabled = false;
            this.skill2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skill2.Location = new System.Drawing.Point(171, 62);
            this.skill2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.skill2.Name = "skill2";
            this.skill2.Size = new System.Drawing.Size(96, 38);
            this.skill2.TabIndex = 13;
            this.skill2.Text = "技能准备";
            this.skill2.UseVisualStyleBackColor = true;
            this.skill2.Click += new System.EventHandler(this.skill2_Click);
            // 
            // turn
            // 
            this.turn.AutoSize = true;
            this.turn.BackColor = System.Drawing.SystemColors.Info;
            this.turn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.turn.Location = new System.Drawing.Point(373, 279);
            this.turn.Name = "turn";
            this.turn.Size = new System.Drawing.Size(127, 29);
            this.turn.TabIndex = 14;
            this.turn.Text = "XX的回合";
            // 
            // hp1
            // 
            this.hp1.AutoSize = true;
            this.hp1.Location = new System.Drawing.Point(131, 35);
            this.hp1.Name = "hp1";
            this.hp1.Size = new System.Drawing.Size(29, 18);
            this.hp1.TabIndex = 15;
            this.hp1.Text = "HP";
            // 
            // hp2
            // 
            this.hp2.AutoSize = true;
            this.hp2.Location = new System.Drawing.Point(205, 34);
            this.hp2.Name = "hp2";
            this.hp2.Size = new System.Drawing.Size(29, 18);
            this.hp2.TabIndex = 16;
            this.hp2.Text = "HP";
            // 
            // attack2
            // 
            this.attack2.Enabled = false;
            this.attack2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.attack2.Location = new System.Drawing.Point(171, 128);
            this.attack2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.attack2.Name = "attack2";
            this.attack2.Size = new System.Drawing.Size(96, 38);
            this.attack2.TabIndex = 17;
            this.attack2.Text = "普通攻击";
            this.attack2.UseVisualStyleBackColor = true;
            this.attack2.Click += new System.EventHandler(this.attack2_Click);
            // 
            // skillattack1
            // 
            this.skillattack1.Enabled = false;
            this.skillattack1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skillattack1.Location = new System.Drawing.Point(95, 192);
            this.skillattack1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.skillattack1.Name = "skillattack1";
            this.skillattack1.Size = new System.Drawing.Size(96, 38);
            this.skillattack1.TabIndex = 18;
            this.skillattack1.Text = "技能攻击";
            this.skillattack1.UseVisualStyleBackColor = true;
            this.skillattack1.Click += new System.EventHandler(this.skillattack1_Click);
            // 
            // skillattack2
            // 
            this.skillattack2.Enabled = false;
            this.skillattack2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skillattack2.Location = new System.Drawing.Point(171, 191);
            this.skillattack2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.skillattack2.Name = "skillattack2";
            this.skillattack2.Size = new System.Drawing.Size(96, 38);
            this.skillattack2.TabIndex = 19;
            this.skillattack2.Text = "技能攻击";
            this.skillattack2.UseVisualStyleBackColor = true;
            this.skillattack2.Click += new System.EventHandler(this.skillattack2_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.title.ForeColor = System.Drawing.Color.Black;
            this.title.Location = new System.Drawing.Point(409, 24);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(172, 36);
            this.title.TabIndex = 20;
            this.title.Text = "2P对战游戏";
            // 
            // check1
            // 
            this.check1.Enabled = false;
            this.check1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.check1.Location = new System.Drawing.Point(95, 378);
            this.check1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.check1.Name = "check1";
            this.check1.Size = new System.Drawing.Size(96, 38);
            this.check1.TabIndex = 22;
            this.check1.Text = "查看状态";
            this.check1.UseVisualStyleBackColor = true;
            this.check1.Click += new System.EventHandler(this.check1_Click);
            // 
            // check2
            // 
            this.check2.Enabled = false;
            this.check2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.check2.Location = new System.Drawing.Point(171, 378);
            this.check2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.check2.Name = "check2";
            this.check2.Size = new System.Drawing.Size(96, 38);
            this.check2.TabIndex = 23;
            this.check2.Text = "查看状态";
            this.check2.UseVisualStyleBackColor = true;
            this.check2.Click += new System.EventHandler(this.check2_Click);
            // 
            // skipturn1
            // 
            this.skipturn1.Enabled = false;
            this.skipturn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skipturn1.Location = new System.Drawing.Point(243, 216);
            this.skipturn1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.skipturn1.Name = "skipturn1";
            this.skipturn1.Size = new System.Drawing.Size(75, 32);
            this.skipturn1.TabIndex = 24;
            this.skipturn1.Text = "跳过";
            this.skipturn1.UseVisualStyleBackColor = true;
            this.skipturn1.Click += new System.EventHandler(this.skipturn1_Click);
            // 
            // skipturn2
            // 
            this.skipturn2.Enabled = false;
            this.skipturn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skipturn2.Location = new System.Drawing.Point(45, 215);
            this.skipturn2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.skipturn2.Name = "skipturn2";
            this.skipturn2.Size = new System.Drawing.Size(75, 32);
            this.skipturn2.TabIndex = 25;
            this.skipturn2.Text = "跳过";
            this.skipturn2.UseVisualStyleBackColor = true;
            this.skipturn2.Click += new System.EventHandler(this.skipturn2_Click);
            // 
            // setting
            // 
            this.setting.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.setting.Location = new System.Drawing.Point(13, 12);
            this.setting.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.setting.Name = "setting";
            this.setting.Size = new System.Drawing.Size(156, 42);
            this.setting.TabIndex = 26;
            this.setting.Text = "设置与游戏说明";
            this.setting.UseVisualStyleBackColor = true;
            this.setting.Click += new System.EventHandler(this.setting_Click);
            // 
            // restart
            // 
            this.restart.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.restart.Enabled = false;
            this.restart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.restart.Location = new System.Drawing.Point(427, 121);
            this.restart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(131, 58);
            this.restart.TabIndex = 27;
            this.restart.Text = "重新开始";
            this.restart.UseVisualStyleBackColor = false;
            this.restart.Click += new System.EventHandler(this.restart_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.player1);
            this.groupBox1.Controls.Add(this.skipturn1);
            this.groupBox1.Controls.Add(this.check1);
            this.groupBox1.Controls.Add(this.skillattack1);
            this.groupBox1.Controls.Add(this.hp1);
            this.groupBox1.Controls.Add(this.skill1);
            this.groupBox1.Controls.Add(this.lost1);
            this.groupBox1.Controls.Add(this.equipment1);
            this.groupBox1.Controls.Add(this.attack1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(13, 78);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(355, 508);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "玩家1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(37, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 18);
            this.label1.TabIndex = 26;
            this.label1.Text = "HP";
            // 
            // player1
            // 
            this.player1.BackColor = System.Drawing.Color.MistyRose;
            this.player1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.player1.Location = new System.Drawing.Point(5, 459);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(341, 35);
            this.player1.TabIndex = 25;
            this.player1.Text = "玩家";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.player2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.skipturn2);
            this.groupBox2.Controls.Add(this.check2);
            this.groupBox2.Controls.Add(this.skillattack2);
            this.groupBox2.Controls.Add(this.attack2);
            this.groupBox2.Controls.Add(this.hp2);
            this.groupBox2.Controls.Add(this.skill2);
            this.groupBox2.Controls.Add(this.lost2);
            this.groupBox2.Controls.Add(this.equipment2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(636, 78);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(351, 509);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "玩家2";
            // 
            // player2
            // 
            this.player2.BackColor = System.Drawing.Color.MistyRose;
            this.player2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.player2.Location = new System.Drawing.Point(5, 461);
            this.player2.Name = "player2";
            this.player2.Size = new System.Drawing.Size(339, 32);
            this.player2.TabIndex = 28;
            this.player2.Text = "玩家";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(103, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 18);
            this.label2.TabIndex = 27;
            this.label2.Text = "HP";
            // 
            // SwForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 598);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.restart);
            this.Controls.Add(this.setting);
            this.Controls.Add(this.title);
            this.Controls.Add(this.turn);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.begin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "SwForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2P回合制对战游戏";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SwForm_FormClosed);
            this.Load += new System.EventHandler(this.SwForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button attack1;
        private System.Windows.Forms.Button equipment1;
        private System.Windows.Forms.Button equipment2;
        private System.Windows.Forms.Button lost1;
        private System.Windows.Forms.Button lost2;
        private System.Windows.Forms.Button begin;
        private System.Windows.Forms.Button exit;
        public System.Windows.Forms.Button skill1;
        public System.Windows.Forms.Button skill2;
        private System.Windows.Forms.Label turn;
        private System.Windows.Forms.Label hp1;
        private System.Windows.Forms.Label hp2;
        private System.Windows.Forms.Button attack2;
        private System.Windows.Forms.Button skillattack1;
        private System.Windows.Forms.Button skillattack2;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button check1;
        private System.Windows.Forms.Button check2;
        private System.Windows.Forms.Button skipturn1;
        private System.Windows.Forms.Button skipturn2;
        private System.Windows.Forms.Button setting;
        private System.Windows.Forms.Button restart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label player1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label player2;
    }
}