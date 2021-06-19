
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
            this.player1 = new System.Windows.Forms.Label();
            this.player2 = new System.Windows.Forms.Label();
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
            this.label1 = new System.Windows.Forms.Label();
            this.check1 = new System.Windows.Forms.Button();
            this.check2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // player1
            // 
            this.player1.Font = new System.Drawing.Font("华文细黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.player1.Location = new System.Drawing.Point(379, 162);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(111, 91);
            this.player1.TabIndex = 1;
            this.player1.Text = "玩家1";
            // 
            // player2
            // 
            this.player2.Font = new System.Drawing.Font("华文细黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.player2.Location = new System.Drawing.Point(538, 162);
            this.player2.Name = "player2";
            this.player2.Size = new System.Drawing.Size(120, 91);
            this.player2.TabIndex = 3;
            this.player2.Text = "玩家2";
            // 
            // attack1
            // 
            this.attack1.Enabled = false;
            this.attack1.Font = new System.Drawing.Font("华文琥珀", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.attack1.Location = new System.Drawing.Point(107, 216);
            this.attack1.Name = "attack1";
            this.attack1.Size = new System.Drawing.Size(96, 37);
            this.attack1.TabIndex = 4;
            this.attack1.Text = "普通攻击";
            this.attack1.UseVisualStyleBackColor = true;
            this.attack1.Click += new System.EventHandler(this.attack1_Click);
            // 
            // equipment1
            // 
            this.equipment1.Enabled = false;
            this.equipment1.Font = new System.Drawing.Font("华文琥珀", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.equipment1.Location = new System.Drawing.Point(107, 345);
            this.equipment1.Name = "equipment1";
            this.equipment1.Size = new System.Drawing.Size(96, 37);
            this.equipment1.TabIndex = 5;
            this.equipment1.Text = "购买装备";
            this.equipment1.UseVisualStyleBackColor = true;
            this.equipment1.Click += new System.EventHandler(this.equipment1_Click);
            // 
            // equipment2
            // 
            this.equipment2.Enabled = false;
            this.equipment2.Location = new System.Drawing.Point(800, 344);
            this.equipment2.Name = "equipment2";
            this.equipment2.Size = new System.Drawing.Size(96, 37);
            this.equipment2.TabIndex = 7;
            this.equipment2.Text = "购买装备";
            this.equipment2.UseVisualStyleBackColor = true;
            this.equipment2.Click += new System.EventHandler(this.equipment2_Click);
            // 
            // lost1
            // 
            this.lost1.Enabled = false;
            this.lost1.Font = new System.Drawing.Font("华文琥珀", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lost1.Location = new System.Drawing.Point(107, 405);
            this.lost1.Name = "lost1";
            this.lost1.Size = new System.Drawing.Size(96, 37);
            this.lost1.TabIndex = 8;
            this.lost1.Text = "投降";
            this.lost1.UseVisualStyleBackColor = true;
            this.lost1.Click += new System.EventHandler(this.lost1_Click);
            // 
            // lost2
            // 
            this.lost2.Enabled = false;
            this.lost2.Location = new System.Drawing.Point(800, 405);
            this.lost2.Name = "lost2";
            this.lost2.Size = new System.Drawing.Size(96, 37);
            this.lost2.TabIndex = 9;
            this.lost2.Text = "投降";
            this.lost2.UseVisualStyleBackColor = true;
            this.lost2.Click += new System.EventHandler(this.lost2_Click);
            // 
            // begin
            // 
            this.begin.Location = new System.Drawing.Point(438, 533);
            this.begin.Name = "begin";
            this.begin.Size = new System.Drawing.Size(131, 41);
            this.begin.TabIndex = 10;
            this.begin.Text = "开始游戏";
            this.begin.UseVisualStyleBackColor = true;
            this.begin.Click += new System.EventHandler(this.begin_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(901, 12);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 38);
            this.exit.TabIndex = 11;
            this.exit.Text = "退出";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // skill1
            // 
            this.skill1.Enabled = false;
            this.skill1.Font = new System.Drawing.Font("华文琥珀", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skill1.Location = new System.Drawing.Point(107, 152);
            this.skill1.Name = "skill1";
            this.skill1.Size = new System.Drawing.Size(96, 37);
            this.skill1.TabIndex = 12;
            this.skill1.Text = "技能准备";
            this.skill1.UseVisualStyleBackColor = true;
            this.skill1.Click += new System.EventHandler(this.skill1_Click);
            // 
            // skill2
            // 
            this.skill2.Enabled = false;
            this.skill2.Location = new System.Drawing.Point(800, 151);
            this.skill2.Name = "skill2";
            this.skill2.Size = new System.Drawing.Size(96, 37);
            this.skill2.TabIndex = 13;
            this.skill2.Text = "技能准备";
            this.skill2.UseVisualStyleBackColor = true;
            this.skill2.Click += new System.EventHandler(this.skill2_Click);
            // 
            // turn
            // 
            this.turn.AutoSize = true;
            this.turn.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.turn.Location = new System.Drawing.Point(432, 277);
            this.turn.Name = "turn";
            this.turn.Size = new System.Drawing.Size(126, 33);
            this.turn.TabIndex = 14;
            this.turn.Text = "XX的回合";
            // 
            // hp1
            // 
            this.hp1.AutoSize = true;
            this.hp1.Location = new System.Drawing.Point(143, 122);
            this.hp1.Name = "hp1";
            this.hp1.Size = new System.Drawing.Size(23, 15);
            this.hp1.TabIndex = 15;
            this.hp1.Text = "HP";
            // 
            // hp2
            // 
            this.hp2.AutoSize = true;
            this.hp2.Location = new System.Drawing.Point(835, 122);
            this.hp2.Name = "hp2";
            this.hp2.Size = new System.Drawing.Size(23, 15);
            this.hp2.TabIndex = 16;
            this.hp2.Text = "HP";
            // 
            // attack2
            // 
            this.attack2.Enabled = false;
            this.attack2.Font = new System.Drawing.Font("华文琥珀", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.attack2.Location = new System.Drawing.Point(800, 216);
            this.attack2.Name = "attack2";
            this.attack2.Size = new System.Drawing.Size(96, 37);
            this.attack2.TabIndex = 17;
            this.attack2.Text = "普通攻击";
            this.attack2.UseVisualStyleBackColor = true;
            this.attack2.Click += new System.EventHandler(this.attack2_Click);
            // 
            // skillattack1
            // 
            this.skillattack1.Enabled = false;
            this.skillattack1.Location = new System.Drawing.Point(107, 279);
            this.skillattack1.Name = "skillattack1";
            this.skillattack1.Size = new System.Drawing.Size(96, 37);
            this.skillattack1.TabIndex = 18;
            this.skillattack1.Text = "技能攻击";
            this.skillattack1.UseVisualStyleBackColor = true;
            this.skillattack1.Click += new System.EventHandler(this.skillattack1_Click);
            // 
            // skillattack2
            // 
            this.skillattack2.Enabled = false;
            this.skillattack2.Location = new System.Drawing.Point(800, 279);
            this.skillattack2.Name = "skillattack2";
            this.skillattack2.Size = new System.Drawing.Size(96, 37);
            this.skillattack2.TabIndex = 19;
            this.skillattack2.Text = "技能攻击";
            this.skillattack2.UseVisualStyleBackColor = true;
            this.skillattack2.Click += new System.EventHandler(this.skillattack2_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("华光综艺_CNKI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.title.Location = new System.Drawing.Point(418, 67);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(170, 35);
            this.title.TabIndex = 20;
            this.title.Text = "2P对战游戏";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(487, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = "VS";
            // 
            // check1
            // 
            this.check1.Enabled = false;
            this.check1.Location = new System.Drawing.Point(107, 465);
            this.check1.Name = "check1";
            this.check1.Size = new System.Drawing.Size(96, 37);
            this.check1.TabIndex = 22;
            this.check1.Text = "查看状态";
            this.check1.UseVisualStyleBackColor = true;
            this.check1.Click += new System.EventHandler(this.check1_Click);
            // 
            // check2
            // 
            this.check2.Enabled = false;
            this.check2.Location = new System.Drawing.Point(800, 465);
            this.check2.Name = "check2";
            this.check2.Size = new System.Drawing.Size(96, 37);
            this.check2.TabIndex = 23;
            this.check2.Text = "查看状态";
            this.check2.UseVisualStyleBackColor = true;
            this.check2.Click += new System.EventHandler(this.check2_Click);
            // 
            // SwForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 597);
            this.Controls.Add(this.check2);
            this.Controls.Add(this.check1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.title);
            this.Controls.Add(this.skillattack2);
            this.Controls.Add(this.skillattack1);
            this.Controls.Add(this.attack2);
            this.Controls.Add(this.hp2);
            this.Controls.Add(this.hp1);
            this.Controls.Add(this.turn);
            this.Controls.Add(this.skill2);
            this.Controls.Add(this.skill1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.begin);
            this.Controls.Add(this.lost2);
            this.Controls.Add(this.lost1);
            this.Controls.Add(this.equipment2);
            this.Controls.Add(this.equipment1);
            this.Controls.Add(this.attack1);
            this.Controls.Add(this.player2);
            this.Controls.Add(this.player1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SwForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label player1;
        private System.Windows.Forms.Label player2;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button check1;
        private System.Windows.Forms.Button check2;
    }
}