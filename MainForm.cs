using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestGame
{
	public partial class mainForm : Form
	{
		public mainForm()
		{
			InitializeComponent();
		}

		/// <summary>
		/// 游戏算法：主要使用Random产生随机数，如随机选择行，随机拿走的元素数量
		/// 算法描述如下：
		/// 第一步：选择随机行，
		/// 第二步，拿走随机元素数量，
		/// 如果当前行元素为0，则删除改行，
		/// 重复上述步骤，直到剩余元素为0时，当前玩家为输家，游戏结束。
		/// </summary>
		/// <param name="startPlayer">开始玩家</param>
		/// <param name="countSum">元素总数量</param>
		/// <param name="rowData">每行的数据集合</param>
		/// <returns></returns>
		private int FormStart(int startPlayer, int countSum, List<List<int>> rowData)
		{
			//判断输入参数是否合理
			if (countSum <= 0) return -1;
			if (rowData == null || rowData.Count <= 0) return -1;
			foreach (List<int> row in rowData)
			{
				if (row == null || row.Count <= 0) return -1;
			}

			//随机数
			Random random = new Random();
			int remain = countSum;

			//随机行索引
			int rRow = -1;
			//每次拿走的随机数量
			int rCount = -1;
			//当前玩家
			int curPlayer = startPlayer;
			//保存动作消息
			StringBuilder sb = new StringBuilder();

			//开始玩游戏
			while (remain > 0)
			{
				if (curPlayer == 0)
				{
					btnPlayer1.BackColor = Color.Red;
					btnPlayer2.UseVisualStyleBackColor = true;
				}
				if (curPlayer == 1)
				{
					btnPlayer2.BackColor = Color.Red;
					btnPlayer1.UseVisualStyleBackColor = true;
				}

				//获取当前行的索引
				rRow = random.Next(0, 999) % rowData.Count;
				//取随机数量
				rCount = random.Next(1, rowData[rRow].Count + 1);

				//移除随机数量的元素
				rowData[rRow].RemoveRange(0, rCount);

				//如果该行的元素数量为空，则删除该行
				if (rowData[rRow].Count <= 0)
				{
					rowData.Remove(rowData[rRow]);
				}

				//剩余元素数量
				remain -= rCount;

				//保存当前步骤的动作
				sb.AppendLine(string.Format("玩家{0} ，拿走第 {1} 行 {2} 根牙签；", curPlayer == 0 ? "一" : "二", rRow + 1, rCount));
				//显示消息				
				rtbMessage.Text = sb.ToString();
				ShowData(rowData);

				//如果剩余为0，则游戏结束
				if (remain <= 0)
				{
					sb.AppendLine(string.Format("玩家{0} 为输家。", curPlayer == 0 ? "一" : "二"));
					//显示消息				
					rtbMessage.Text = sb.ToString();
					break;
				}
				//刷新并等待
				Refresh();
				int time = 5 * 1000;
				if (cbTime.SelectedIndex > -1)
				{
					time = 1000 * Int32.Parse(cbTime.SelectedItem.ToString());
				}
				Thread.Sleep(time);

				//下一个玩家
				int otherPlayer = curPlayer == 0 ? 1 : 0;
				curPlayer = otherPlayer;
			}

			//返回游戏结果
			return curPlayer;
		}

		private void btnStart_Click(object sender, EventArgs e)
		{
			//初始化每行的元素分布
			List<List<int>> rowData = new List<List<int>>();
			for (int i = 0; i < 3; i++)
			{
				rowData.Add(new List<int>());
				if (i == 0) rowData[i].AddRange((new int[3]).ToList());
				if (i == 1) rowData[i].AddRange((new int[5]).ToList());
				if (i == 2) rowData[i].AddRange((new int[7]).ToList());
			}

			//开始游戏
			Cursor = Cursors.WaitCursor;
			int index = FormStart(0, 15, rowData);
			Cursor = Cursors.Default;
		}

		private void ShowData(List<List<int>> rowData)
		{
			if (rowData == null || rowData.Count <= 0) return;
			gbPictrue.Controls.Clear();

			int i = 1;
			foreach (List<int> row in rowData)
			{
				//显示标签控件
				Label label = new Label();
				label.Text = string.Format("第 {0} 行", i);
				label.AutoSize = true;
				label.Location = new System.Drawing.Point(20, 60 + (i - 1) * 80);
				label.Name = "label" + i.ToString();
				label.Size = new System.Drawing.Size(60, 12);
				gbPictrue.Controls.Add(label);

				for (int j = 0; j < row.Count; j++)
				{
					//显示每行的元素
					PictureBox pb = new PictureBox();
					pb.Location = new System.Drawing.Point(80 + j * 20, 20 + (i - 1) * 80);
					pb.Name = "pictureBox" + i.ToString() + j.ToString();
					pb.Size = new System.Drawing.Size(10, 50);
					pb.TabStop = false;
					if (i == 1) pb.BackColor = Color.Blue;
					if (i == 2) pb.BackColor = Color.Green;
					if (i == 3) pb.BackColor = Color.Red;
					gbPictrue.Controls.Add(pb);
				}
				i++;
			}
		}

		/// <summary>
		/// 游戏算法：主要使用Random产生随机数，如随机选择行，随机拿走的元素数量
		/// 算法描述如下：
		/// 第一步：选择随机行，
		/// 第二步，拿走随机元素数量，
		/// 如果当前行元素为0，则删除改行，
		/// 重复上述步骤，直到剩余元素为0时，当前玩家为输家，游戏结束。
		/// </summary>
		/// <param name="startPlayer">开始玩家</param>
		/// <param name="countSum">元素总数量</param>
		/// <param name="rowData">每行的数据集合</param>
		/// <returns></returns>
		private int Start(int startPlayer, int countSum, List<List<int>> rowData)
		{
			//判断输入参数是否合理
			if (countSum <= 0) return -1;
			if (rowData == null || rowData.Count <= 0) return -1;
			foreach (List<int> row in rowData)
			{
				if (row == null || row.Count <= 0) return -1;
			}

			//随机数
			Random random = new Random();
			int remain = countSum;

			//随机行索引
			int rRow = -1;
			//每次拿走的随机数量
			int rCount = -1;
			//当前玩家
			int curPlayer = startPlayer;
			//保存动作消息
			StringBuilder sb = new StringBuilder();

			//开始玩游戏
			while (remain > 0)
			{
				//获取当前行的索引
				rRow = random.Next(0, 999) % rowData.Count;
				//取随机数量
				rCount = random.Next(1, rowData[rRow].Count + 1);

				//移除随机数量的元素
				rowData[rRow].RemoveRange(0, rCount);
				//如果该行的元素数量为空，则删除该行
				if (rowData[rRow].Count <= 0)
				{
					rowData.Remove(rowData[rRow]);
				}
				//剩余元素数量
				remain -= rCount;

				//保存当前步骤的动作
				sb.AppendLine(string.Format("第 {0} 个玩家，拿走第 {1} 行 {2} 根牙签；", curPlayer + 1, rRow + 1, rCount));
				if (remain <= 0) break;

				//下一个玩家
				int otherPlayer = curPlayer == 0 ? 1 : 0;
				curPlayer = otherPlayer;
			}

			//显示消息
			rtbMessage.Text = sb.ToString();

			//返回游戏结果
			return curPlayer;
		}

		private void mainForm_Load(object sender, EventArgs e)
		{
			//默认为3秒
			cbTime.SelectedIndex = 2;
		}
	}
}
