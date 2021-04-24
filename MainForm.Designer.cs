namespace TestGame
{
	partial class mainForm
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.btnStart = new System.Windows.Forms.Button();
			this.rtbMessage = new System.Windows.Forms.RichTextBox();
			this.pTop = new System.Windows.Forms.Panel();
			this.btnPlayer2 = new System.Windows.Forms.Button();
			this.gbPictrue = new System.Windows.Forms.GroupBox();
			this.btnPlayer1 = new System.Windows.Forms.Button();
			this.cbTime = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.pTop.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(834, 225);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(143, 70);
			this.btnStart.TabIndex = 0;
			this.btnStart.Text = "开始游戏...";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// rtbMessage
			// 
			this.rtbMessage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rtbMessage.Location = new System.Drawing.Point(0, 335);
			this.rtbMessage.Name = "rtbMessage";
			this.rtbMessage.Size = new System.Drawing.Size(1030, 284);
			this.rtbMessage.TabIndex = 1;
			this.rtbMessage.Text = "";
			// 
			// pTop
			// 
			this.pTop.Controls.Add(this.label3);
			this.pTop.Controls.Add(this.label2);
			this.pTop.Controls.Add(this.label1);
			this.pTop.Controls.Add(this.cbTime);
			this.pTop.Controls.Add(this.btnPlayer2);
			this.pTop.Controls.Add(this.gbPictrue);
			this.pTop.Controls.Add(this.btnPlayer1);
			this.pTop.Controls.Add(this.btnStart);
			this.pTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.pTop.Location = new System.Drawing.Point(0, 0);
			this.pTop.Name = "pTop";
			this.pTop.Size = new System.Drawing.Size(1030, 335);
			this.pTop.TabIndex = 2;
			// 
			// btnPlayer2
			// 
			this.btnPlayer2.Location = new System.Drawing.Point(834, 94);
			this.btnPlayer2.Name = "btnPlayer2";
			this.btnPlayer2.Size = new System.Drawing.Size(98, 35);
			this.btnPlayer2.TabIndex = 4;
			this.btnPlayer2.Text = "玩家二";
			this.btnPlayer2.UseVisualStyleBackColor = true;
			// 
			// gbPictrue
			// 
			this.gbPictrue.Dock = System.Windows.Forms.DockStyle.Left;
			this.gbPictrue.Location = new System.Drawing.Point(0, 0);
			this.gbPictrue.Name = "gbPictrue";
			this.gbPictrue.Size = new System.Drawing.Size(809, 335);
			this.gbPictrue.TabIndex = 0;
			this.gbPictrue.TabStop = false;
			// 
			// btnPlayer1
			// 
			this.btnPlayer1.Location = new System.Drawing.Point(834, 34);
			this.btnPlayer1.Name = "btnPlayer1";
			this.btnPlayer1.Size = new System.Drawing.Size(98, 35);
			this.btnPlayer1.TabIndex = 3;
			this.btnPlayer1.Text = "玩家一";
			this.btnPlayer1.UseVisualStyleBackColor = true;
			// 
			// cbTime
			// 
			this.cbTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbTime.FormattingEnabled = true;
			this.cbTime.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
			this.cbTime.Location = new System.Drawing.Point(834, 163);
			this.cbTime.Name = "cbTime";
			this.cbTime.Size = new System.Drawing.Size(77, 20);
			this.cbTime.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(834, 148);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(77, 12);
			this.label1.TabIndex = 6;
			this.label1.Text = "每个步骤暂停";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(915, 166);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(17, 12);
			this.label2.TabIndex = 7;
			this.label2.Text = "秒";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(834, 307);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(149, 12);
			this.label3.TabIndex = 8;
			this.label3.Text = "默认 玩家一 为第一个玩家";
			// 
			// mainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1030, 619);
			this.Controls.Add(this.rtbMessage);
			this.Controls.Add(this.pTop);
			this.Name = "mainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "游戏界面";
			this.Load += new System.EventHandler(this.mainForm_Load);
			this.pTop.ResumeLayout(false);
			this.pTop.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.RichTextBox rtbMessage;
		private System.Windows.Forms.Panel pTop;
		private System.Windows.Forms.Button btnPlayer1;
		private System.Windows.Forms.Button btnPlayer2;
		private System.Windows.Forms.GroupBox gbPictrue;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cbTime;
		private System.Windows.Forms.Label label3;
	}
}

