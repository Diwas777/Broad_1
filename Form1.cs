using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Broadway
{
	public partial class Form1 : Form   //Form1 is inheritance of Form 
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			textBox1.Text = "Enter first Value";
			textBox2.Text = "Enter Second Value";
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int a = Int32.Parse(textBox1.Text);  //Convert.toInt32()
			int b = Int32.Parse(textBox2.Text);
			int c = a + b;
			textBox3.Text = Convert.ToString(c);
		}

		
	}
}
