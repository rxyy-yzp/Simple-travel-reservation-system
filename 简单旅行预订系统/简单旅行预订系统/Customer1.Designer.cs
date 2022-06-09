namespace 简单旅行预订系统
{
    partial class Customer1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer1));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.预定机票ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.预定巴士ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.预定旅馆ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.预定旅馆ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("方正舒体", 56F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(-1, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(802, 99);
            this.label2.TabIndex = 6;
            this.label2.Text = "简单旅行预订系统";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("华文楷体", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(180, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(456, 68);
            this.label1.TabIndex = 5;
            this.label1.Text = "欢迎用户登录！";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.预定机票ToolStripMenuItem,
            this.预定巴士ToolStripMenuItem,
            this.预定旅馆ToolStripMenuItem,
            this.预定旅馆ToolStripMenuItem1,
            this.退出ToolStripMenuItem,
            this.退出ToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 预定机票ToolStripMenuItem
            // 
            this.预定机票ToolStripMenuItem.Name = "预定机票ToolStripMenuItem";
            this.预定机票ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.预定机票ToolStripMenuItem.Text = "预定查询";
            this.预定机票ToolStripMenuItem.Click += new System.EventHandler(this.预定机票ToolStripMenuItem_Click);
            // 
            // 预定巴士ToolStripMenuItem
            // 
            this.预定巴士ToolStripMenuItem.Name = "预定巴士ToolStripMenuItem";
            this.预定巴士ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.预定巴士ToolStripMenuItem.Text = "预定机票";
            this.预定巴士ToolStripMenuItem.Click += new System.EventHandler(this.预定巴士ToolStripMenuItem_Click);
            // 
            // 预定旅馆ToolStripMenuItem
            // 
            this.预定旅馆ToolStripMenuItem.Name = "预定旅馆ToolStripMenuItem";
            this.预定旅馆ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.预定旅馆ToolStripMenuItem.Text = "预定巴士";
            this.预定旅馆ToolStripMenuItem.Click += new System.EventHandler(this.预定旅馆ToolStripMenuItem_Click);
            // 
            // 预定旅馆ToolStripMenuItem1
            // 
            this.预定旅馆ToolStripMenuItem1.Name = "预定旅馆ToolStripMenuItem1";
            this.预定旅馆ToolStripMenuItem1.Size = new System.Drawing.Size(83, 24);
            this.预定旅馆ToolStripMenuItem1.Text = "预定旅馆";
            this.预定旅馆ToolStripMenuItem1.Click += new System.EventHandler(this.预定旅馆ToolStripMenuItem1_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.退出ToolStripMenuItem.Text = "我的预定";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem1
            // 
            this.退出ToolStripMenuItem1.Name = "退出ToolStripMenuItem1";
            this.退出ToolStripMenuItem1.Size = new System.Drawing.Size(53, 24);
            this.退出ToolStripMenuItem1.Text = "退出";
            this.退出ToolStripMenuItem1.Click += new System.EventHandler(this.退出ToolStripMenuItem1_Click);
            // 
            // Customer1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Customer1";
            this.Text = "用户主页面";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 预定机票ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 预定巴士ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 预定旅馆ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 预定旅馆ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem1;
    }
}