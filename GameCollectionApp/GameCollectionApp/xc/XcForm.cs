using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCollectionApp.xc
{
  public partial class XcForm : Form
  {
    private Form parent;
    public XcForm(Form parent)
    {
      InitializeComponent();
      this.parent = parent;
      this.Text = "金字塔纸牌";
      //this.BackgroundImage=
    }

    private void XcForm_Load(object sender, EventArgs e)
    {

    }

    public void showMenu()   //显示菜单
    {
      Panel menuPanel = new Panel(); //菜单面板
      menuPanel.Size = new Size(menuButton.Width, 4 * menuButton.Height);
      menuPanel.Location = new Point(menuButton.Location.X, 0 * menuButton.Height);
      menuPanel.BorderStyle = BorderStyle.Fixed3D;
      Controls.Add(menuPanel);
      menuPanel.BringToFront();

      //提示选项
      Button reminderButton = new Button();
      reminderButton.Size = new Size(menuButton.Width, menuButton.Height);
      reminderButton.Location = new Point(menuPanel.Location.X, menuPanel.Location.Y);
      reminderButton.Text = "提示";
      //reminderButton.Click += new EventHandler((object s, EventArgs e) =>
      Controls.Add(reminderButton);
      reminderButton.BringToFront();

      //重新开始选项
      Button restartButton = new Button();
      restartButton.Size = new Size(menuButton.Width, menuButton.Height);
      restartButton.Location = new Point(menuPanel.Location.X, menuPanel.Location.Y + menuButton.Height);
      restartButton.Text = "重新开始";
      //reminderButton.Click += new EventHandler((object s, EventArgs e) =>
      Controls.Add(restartButton);
      restartButton.BringToFront();


      //退出选项
      Button exitButton = new Button();
      exitButton.Size = new Size(menuButton.Width, menuButton.Height);
      exitButton.Location = new Point(menuPanel.Location.X, menuPanel.Location.Y + 2 * menuButton.Height);
      exitButton.Text = "退出游戏";
      exitButton.Click += new EventHandler((object s, EventArgs e) =>
      {
        parent.Show();
        Close();
      });
      Controls.Add(exitButton);
      exitButton.BringToFront();

      //游戏规则选项
      Button ruleButton = new Button();
      ruleButton.Size = new Size(menuButton.Width, menuButton.Height);
      ruleButton.Location = new Point(menuPanel.Location.X, menuPanel.Location.Y + 3 * menuButton.Height);
      ruleButton.Text = "游戏规则";
      ruleButton.Click += new EventHandler((object s, EventArgs e) =>
      {
        MessageBox.Show("123");
      });
      Controls.Add(ruleButton);
      ruleButton.BringToFront();

      //返回游戏选项
      Button returnButton = new Button();
      returnButton.Size = new Size(menuButton.Width, menuButton.Height);
      returnButton.Location = new Point(menuPanel.Location.X, menuPanel.Location.Y + 4 * menuButton.Height);
      returnButton.Text = "返回游戏";
      returnButton.Click += new EventHandler((object s, EventArgs e) =>
      {
        Controls.Remove(menuPanel);
        Controls.Remove(reminderButton);
        Controls.Remove(restartButton);
        Controls.Remove(exitButton);
        Controls.Remove(ruleButton);
        Controls.Remove(returnButton);
      });
      Controls.Add(returnButton);
      returnButton.BringToFront();
    }

    private void menuButton_Click(object sender, EventArgs e)
    {
      showMenu();
    }

    private void scoreLabel_Click(object sender, EventArgs e)
    {

    }
  }
}
