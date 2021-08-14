using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hack_browser
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			chromiumWebBrowser1.Load("https://duckduckgo.com");
		}

		private void siticoneButton1_Click(object sender, EventArgs e)
		{
			chromiumWebBrowser1.Load(siticoneTextBox1.Text);
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Environment.Exit(1);
		}

		private void chromiumWebBrowser1_LoadingStateChanged(object sender, CefSharp.LoadingStateChangedEventArgs e)
		{
			
		}

		private void siticoneTextBox1_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
