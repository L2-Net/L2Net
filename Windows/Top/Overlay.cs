using System;
using System.Drawing;

namespace L2_login
{
    /// <summary>
    /// Summary description for Overlay.
    /// </summary>
    public class Overlay : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label_target_cp;
        private System.Windows.Forms.Label label_target_mp;
        private System.Windows.Forms.Label label_target_hp;
        private System.Windows.Forms.Label label_target_name;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Overlay()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Overlay));
            this.label_target_cp = new System.Windows.Forms.Label();
            this.label_target_mp = new System.Windows.Forms.Label();
            this.label_target_hp = new System.Windows.Forms.Label();
            this.label_target_name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_target_cp
            // 
            this.label_target_cp.BackColor = Color.Transparent;
            this.label_target_cp.ForeColor = Color.White;
            this.label_target_cp.Location = new System.Drawing.Point(24, 16);
            this.label_target_cp.Name = "label_target_cp";
            this.label_target_cp.Size = new Size(128, 16);
            this.label_target_cp.TabIndex = 11;
            this.label_target_cp.Text = "-cp-";
            this.label_target_cp.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_target_mp
            // 
            this.label_target_mp.BackColor = Color.Transparent;
            this.label_target_mp.ForeColor = Color.White;
            this.label_target_mp.Location = new System.Drawing.Point(24, 48);
            this.label_target_mp.Name = "label_target_mp";
            this.label_target_mp.Size = new Size(128, 16);
            this.label_target_mp.TabIndex = 10;
            this.label_target_mp.Text = "-mp-";
            this.label_target_mp.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_target_hp
            // 
            this.label_target_hp.BackColor = Color.Transparent;
            this.label_target_hp.ForeColor = Color.White;
            this.label_target_hp.Location = new System.Drawing.Point(24, 32);
            this.label_target_hp.Name = "label_target_hp";
            this.label_target_hp.Size = new Size(128, 16);
            this.label_target_hp.TabIndex = 9;
            this.label_target_hp.Text = "-hp-";
            this.label_target_hp.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_target_name
            // 
            this.label_target_name.BackColor = Color.Transparent;
            this.label_target_name.ForeColor = Color.GreenYellow;
            this.label_target_name.Location = new System.Drawing.Point(24, 0);
            this.label_target_name.Name = "label_target_name";
            this.label_target_name.Size = new Size(128, 16);
            this.label_target_name.TabIndex = 8;
            this.label_target_name.Text = "-none-";
            this.label_target_name.TextAlign = ContentAlignment.MiddleCenter;
            this.label_target_name.Click += new EventHandler(this.label_target_name_Click);
            // 
            // Overlay
            // 
            this.AutoScaleBaseSize = new Size(5, 13);
            this.BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            this.ClientSize = new Size(170, 64);
            this.ControlBox = false;
            this.Controls.Add(this.label_target_cp);
            this.Controls.Add(this.label_target_mp);
            this.Controls.Add(this.label_target_hp);
            this.Controls.Add(this.label_target_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Overlay";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                ~Target Info~";
            this.TopMost = true;
            this.ResumeLayout(false);

		}
		#endregion
        
        delegate void Set_Target_Name_Callback(string name);
        public void Set_Target_Name(string name)
        {
            if (this.label_target_name.InvokeRequired)
            {
                Set_Target_Name_Callback d = new Set_Target_Name_Callback(Set_Target_Name);
                label_target_name.Invoke(d, new object[] { name });
                return;
            }

            label_target_name.Text = name;
        }

        delegate void Set_Target_CP_Callback(string text);
        public void Set_Target_CP(string text)
        {
            if (this.label_target_cp.InvokeRequired)
            {
                Set_Target_CP_Callback d = new Set_Target_CP_Callback(Set_Target_CP);
                label_target_cp.Invoke(d, new object[] { text });
                return;
            }

            label_target_cp.Text = text;
        }

        delegate void Set_Target_MP_Callback(string text);
        public void Set_Target_MP(string text)
        {
            if (this.label_target_mp.InvokeRequired)
            {
                Set_Target_MP_Callback d = new Set_Target_MP_Callback(Set_Target_MP);
                label_target_mp.Invoke(d, new object[] { text });
                return;
            }

            label_target_mp.Text = text;
        }

        delegate void Set_Target_HP_Callback(string text);
        public void Set_Target_HP(string text)
        {
            if (this.label_target_hp.InvokeRequired)
            {
                Set_Target_HP_Callback d = new Set_Target_HP_Callback(Set_Target_HP);
                label_target_hp.Invoke(d, new object[] { text });
                return;
            }

            label_target_hp.Text = text;
        }

        delegate void Set_Bot_Callback(bool on);
        public void Set_Bot(bool on)
        {
            if (this.label_target_name.InvokeRequired)
            {
                Set_Bot_Callback d = new Set_Bot_Callback(Set_Bot);
                label_target_name.Invoke(d, new object[] { on });
                return;
            }

            if (on)
            {
                label_target_name.ForeColor = Color.GreenYellow;
            }
            else
            {
                label_target_name.ForeColor = Color.LightSalmon;
            }
        }

        private void label_target_name_Click(object sender, EventArgs e)
        {
            //need to toggle botting
            Globals.l2net_home.Toggle_Botting();
        }
    }
}
