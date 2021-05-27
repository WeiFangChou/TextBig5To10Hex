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

			if (textBox1.Text != "")
			{


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
			
		}
		private void textBox1_Leave(object sender, EventArgs e)
		{
			if (textBox1.Text == "")
			{
				textBox1.Text = "請輸入中文字...";
			}
		}


		private void button1_Click(object sender, EventArgs e)
		{
			if(textBox1.Text.Length != 0)
            {
				textBox2.Text = "";
				string Str;
				byte[] output;
				char[] values = textBox1.Text.ToCharArray();
				for (int i = 1; i <= textBox1.Text.Length; i++)
				{
					Str = textBox1.Text.Substring(i - 1, 1);
					output = Encoding.GetEncoding("BIG5").GetBytes(Str);
					String result = ToHexString(output);

					int resultInt = Convert.ToInt32(result, 16);

					String outputStr = $"{Str}：(16) {result} (10) {resultInt}";

					textBox2.Text += outputStr + Environment.NewLine;

					//Console.WriteLine(resultInt);
					//Console.WriteLine(result);

				}
			}
			textBox1.SelectAll();

		}

	}
}
