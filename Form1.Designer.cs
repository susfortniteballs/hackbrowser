
namespace hack_browser
{
	partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.chromiumWebBrowser1 = new CefSharp.WinForms.ChromiumWebBrowser();
			this.siticoneTextBox1 = new Siticone.UI.WinForms.SiticoneTextBox();
			this.siticoneButton1 = new Siticone.UI.WinForms.SiticoneButton();
			this.SuspendLayout();
			// 
			// chromiumWebBrowser1
			// 
			this.chromiumWebBrowser1.ActivateBrowserOnCreation = false;
			this.chromiumWebBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
// TODO: Code generation for '			this.chromiumWebBrowser1.BrowserHwnd' failed because of Exception 'Invalid Primitive Type: System.IntPtr. Consider using CodeObjectCreateExpression.'.
			this.chromiumWebBrowser1.Location = new System.Drawing.Point(-1, 36);
			this.chromiumWebBrowser1.Name = "chromiumWebBrowser1";
			this.chromiumWebBrowser1.Size = new System.Drawing.Size(901, 497);
			this.chromiumWebBrowser1.TabIndex = 0;
			this.chromiumWebBrowser1.LoadingStateChanged += new System.EventHandler<CefSharp.LoadingStateChangedEventArgs>(this.chromiumWebBrowser1_LoadingStateChanged);
			// 
			// siticoneTextBox1
			// 
			this.siticoneTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.siticoneTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.siticoneTextBox1.DefaultText = "";
			this.siticoneTextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.siticoneTextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.siticoneTextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.siticoneTextBox1.DisabledState.Parent = this.siticoneTextBox1;
			this.siticoneTextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.siticoneTextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.siticoneTextBox1.FocusedState.Parent = this.siticoneTextBox1;
			this.siticoneTextBox1.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.siticoneTextBox1.HoveredState.Parent = this.siticoneTextBox1;
			this.siticoneTextBox1.Location = new System.Drawing.Point(-1, 1);
			this.siticoneTextBox1.Name = "siticoneTextBox1";
			this.siticoneTextBox1.PasswordChar = '\0';
			this.siticoneTextBox1.PlaceholderText = "";
			this.siticoneTextBox1.SelectedText = "";
			this.siticoneTextBox1.ShadowDecoration.Parent = this.siticoneTextBox1;
			this.siticoneTextBox1.Size = new System.Drawing.Size(788, 29);
			this.siticoneTextBox1.TabIndex = 1;
			this.siticoneTextBox1.TextChanged += new System.EventHandler(this.siticoneTextBox1_TextChanged);
			// 
			// siticoneButton1
			// 
			this.siticoneButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.siticoneButton1.CheckedState.Parent = this.siticoneButton1;
			this.siticoneButton1.CustomImages.Parent = this.siticoneButton1;
			this.siticoneButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.siticoneButton1.ForeColor = System.Drawing.Color.White;
			this.siticoneButton1.HoveredState.Parent = this.siticoneButton1;
			this.siticoneButton1.Location = new System.Drawing.Point(793, 1);
			this.siticoneButton1.Name = "siticoneButton1";
			this.siticoneButton1.ShadowDecoration.Parent = this.siticoneButton1;
			this.siticoneButton1.Size = new System.Drawing.Size(106, 29);
			this.siticoneButton1.TabIndex = 2;
			this.siticoneButton1.Text = "Navigate";
			this.siticoneButton1.Click += new System.EventHandler(this.siticoneButton1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(901, 532);
			this.Controls.Add(this.siticoneButton1);
			this.Controls.Add(this.siticoneTextBox1);
			this.Controls.Add(this.chromiumWebBrowser1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Text = "hack browser";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private CefSharp.WinForms.ChromiumWebBrowser chromiumWebBrowser1;
		private Siticone.UI.WinForms.SiticoneTextBox siticoneTextBox1;
		private Siticone.UI.WinForms.SiticoneButton siticoneButton1;
	}
}

