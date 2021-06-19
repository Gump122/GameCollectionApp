
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
            this.SuspendLayout();
            // 
            // player1
            // 
            this.player1.AutoSize = true;
            this.player1.Font = new System.Drawing.Font("华文细黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.player1.Location = new System.Drawing.Point(102, 118);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(79, 27);
            this.player1.TabIndex = 1;
            this.player1.Text = "玩家1";
            // 
            // player2
            // 
            this.player2.AutoSize = true;
            this.player2.Font = new System.Drawing.Font("华文细黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.player2.Location = new System.Drawing.Point(776, 118);
            this.player2.Name = "player2";
            this.player2.Size = new System.Drawing.Size(79, 27);
            this.player2.TabIndex = 3;
            this.player2.Text = "玩家2";
            // 
            // attack1
            // 
            this.attack1.Enabled = false;
            this.attack1.Font = new System.Drawing.Font("华文琥珀", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.attack1.Location = new System.Drawing.Point(107, 191);
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
            this.equipment1.Location = new System.Drawing.Point(107, 332);
            this.equipment1.Name = "equipment1";
            this.equipment1.Size = new System.Drawing.Size(96, 37);
            this.equipment1.TabIndex = 5;
            this.equipment1.Text = "购买装备";
            this.equipment1.UseVisualStyleBackColor = true;
            // 
            // equipment2
            // 
            this.equipment2.Enabled = false;
            this.equipment2.Location = new System.Drawing.Point(781, 332);
            this.equipment2.Name = "equipment2";
            this.equipment2.Size = new System.Drawing.Size(96, 37);
            this.equipment2.TabIndex = 7;
            this.equipment2.Text = "购买装备";
            this.equipment2.UseVisualStyleBackColor = true;
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
            this.lost2.Location = new System.Drawing.Point(781, 405);
            this.lost2.Name = "lost2";
            this.lost2.Size = new System.Drawing.Size(96, 37);
            this.lost2.TabIndex = 9;
            this.lost2.Text = "投降";
            this.lost2.UseVisualStyleBackColor = true;
            this.lost2.Click += new System.EventHandler(this.lost2_Click);
            // 
            // begin
            // 
            this.begin.Location = new System.Drawing.Point(420, 523);
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
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 11;
            this.exit.Text = "退出";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // skill1
            // 
            this.skill1.Enabled = false;
            this.skill1.Font = new System.Drawing.Font("华文琥珀", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skill1.Location = new System.Drawing.Point(107, 260);
            this.skill1.Name = "skill1";
            this.skill1.Size = new System.Drawing.Size(96, 37);
            this.skill1.TabIndex = 12;
            this.skill1.Text = "技能";
            this.skill1.UseVisualStyleBackColor = true;
            // 
            // skill2
            // 
            this.skill2.Enabled = false;
            this.skill2.Location = new System.Drawing.Point(781, 260);
            this.skill2.Name = "skill2";
            this.skill2.Size = new System.Drawing.Size(96, 37);
            this.skill2.TabIndex = 13;
            this.skill2.Text = "技能";
            this.skill2.UseVisualStyleBackColor = true;
            // 
            // turn
            // 
            this.turn.AutoSize = true;
            this.turn.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.turn.Location = new System.Drawing.Point(414, 55);
            this.turn.Name = "turn";
            this.turn.Size = new System.Drawing.Size(115, 33);
            this.turn.TabIndex = 14;
            this.turn.Text = "回合开始";
            // 
            // hp1
            // 
            this.hp1.AutoSize = true;
            this.hp1.Location = new System.Drawing.Point(129, 478);
            this.hp1.Name = "hp1";
            this.hp1.Size = new System.Drawing.Size(23, 15);
            this.hp1.TabIndex = 15;
            this.hp1.Text = "HP";
            // 
            // hp2
            // 
            this.hp2.AutoSize = true;
            this.hp2.Location = new System.Drawing.Point(802, 478);
            this.hp2.Name = "hp2";
            this.hp2.Size = new System.Drawing.Size(23, 15);
            this.hp2.TabIndex = 16;
            this.hp2.Text = "HP";
            // 
            // attack2
            // 
            this.attack2.Enabled = false;
            this.attack2.Font = new System.Drawing.Font("华文琥珀", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.attack2.Location = new System.Drawing.Point(781, 191);
            this.attack2.Name = "attack2";
            this.attack2.Size = new System.Drawing.Size(96, 37);
            this.attack2.TabIndex = 17;
            this.attack2.Text = "普通攻击";
            this.attack2.UseVisualStyleBackColor = true;
            this.attack2.Click += new System.EventHandler(this.attack2_Click);
            // 
            // SwForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 597);
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
        private System.Windows.Forms.Button skill1;
        private System.Windows.Forms.Button skill2;
        private System.Windows.Forms.Label turn;
        private System.Windows.Forms.Label hp1;
        private System.Windows.Forms.Label hp2;
        private System.Windows.Forms.Button attack2;
    }
}