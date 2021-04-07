using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			
		}

		public static string ToHexString(byte[] bytes)
		{
			string hexString = string.Empty;
			if (bytes != null)
			{
				StringBuilder strB = new StringBuilder();

				for (int i = 0; i < bytes.Length; i++)
				{
					strB.Append(bytes[i].ToString("X"));
				}
				hexString = strB.ToString();
			}
			return hexString;
		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			if(sender == "")
            {

            }
			if (textBox1.Text != "")
			{
				string Str;
				byte[] output;
				int inputNUM = textBox1.Text.Length;
				textBox2.Text = "";
				textBox3.Text = "";
				for (int i = 1; i <= inputNUM; i++)
				{
					Console.WriteLine(inputNUM);
					Str = textBox1.Text.Substring(i - 1, 1);
					output = Encoding.GetEncoding("BIG5").GetBytes(Str);
					String result = ToHexString(output);
					textBox2.Text += Str + " " + result + Environment.NewLine;
					textBox3.Text += result + " ";
				}
			}
			else if (textBox1.Text == "請輸入中文字...")
			{
				return;
			}
			else
			{

			}
		}
		private void textBox1_Enter(object sender, EventArgs e)
		{
			if(textBox1.Text== "請輸入中文字...")
			{
				textBox1.Text = "";
			}
		}
		private void textBox1_Leave(object sender, EventArgs e)
		{
			if (textBox1.Text == "")
			{
				textBox1.Text = "請輸入中文字...";
			}
		}
		private void textBox3_Enter(object sender, EventArgs e)
		{
			if (textBox3.Text == "請輸入BIG-5碼...")
			{
				textBox3.Text = "";
			}
		}
		private void textBox3_Leave(object sender, EventArgs e)
		{
			if (textBox3.Text == "")
			{
				textBox3.Text = "請輸入BIG-5碼...";
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{

		}

		private void textBox3_TextChanged(object sender, EventArgs e)
		{
			textBox4.Text = "";
			if (textBox3.Text != "")
			{
				if (textBox3.Text != "請輸入BIG-5碼...")
				{
					string hexval = textBox3.Text;
					hexval = hexval.Trim();
					string[] hexSplit = hexval.Split(' ');
					foreach (string hex in hexSplit)
					{
						int result = Convert.ToInt32(hex, 16);
						textBox4.Text += result.ToString() + Environment.NewLine;
					}
				}

			}
		}

		private void button2_Click(object sender, EventArgs e)
		{


		}
	}
}
