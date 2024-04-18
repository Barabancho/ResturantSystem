namespace ResturantSystem
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button2 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.toolTip1.SetToolTip(this.contextMenuStrip1, resources.GetString("contextMenuStrip1.ToolTip"));
            this.toolTip2.SetToolTip(this.contextMenuStrip1, resources.GetString("contextMenuStrip1.ToolTip1"));
            this.toolTip3.SetToolTip(this.contextMenuStrip1, resources.GetString("contextMenuStrip1.ToolTip2"));
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button2.Name = "button2";
            this.toolTip2.SetToolTip(this.button2, resources.GetString("button2.ToolTip"));
            this.toolTip3.SetToolTip(this.button2, resources.GetString("button2.ToolTip1"));
            this.toolTip1.SetToolTip(this.button2, resources.GetString("button2.ToolTip2"));
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            this.toolTip1.SetToolTip(this.textBox1, resources.GetString("textBox1.ToolTip"));
            this.toolTip2.SetToolTip(this.textBox1, resources.GetString("textBox1.ToolTip1"));
            this.toolTip3.SetToolTip(this.textBox1, resources.GetString("textBox1.ToolTip2"));
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // textBox2
            // 
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.Name = "textBox2";
            this.toolTip1.SetToolTip(this.textBox2, resources.GetString("textBox2.ToolTip"));
            this.toolTip2.SetToolTip(this.textBox2, resources.GetString("textBox2.ToolTip1"));
            this.toolTip3.SetToolTip(this.textBox2, resources.GetString("textBox2.ToolTip2"));
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox2.Enter += new System.EventHandler(this.textBox2_Enter);
            this.textBox2.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // comboBox1
            // 
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            resources.GetString("comboBox1.Items"),
            resources.GetString("comboBox1.Items1")});
            this.comboBox1.Name = "comboBox1";
            this.toolTip2.SetToolTip(this.comboBox1, resources.GetString("comboBox1.ToolTip"));
            this.toolTip1.SetToolTip(this.comboBox1, resources.GetString("comboBox1.ToolTip1"));
            this.toolTip3.SetToolTip(this.comboBox1, resources.GetString("comboBox1.ToolTip2"));
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.toolTip2.SetToolTip(this.pictureBox1, resources.GetString("pictureBox1.ToolTip"));
            this.toolTip3.SetToolTip(this.pictureBox1, resources.GetString("pictureBox1.ToolTip1"));
            this.toolTip1.SetToolTip(this.pictureBox1, resources.GetString("pictureBox1.ToolTip2"));
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.btnLogin);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            this.toolTip3.SetToolTip(this.groupBox1, resources.GetString("groupBox1.ToolTip"));
            this.toolTip1.SetToolTip(this.groupBox1, resources.GetString("groupBox1.ToolTip1"));
            this.toolTip2.SetToolTip(this.groupBox1, resources.GetString("groupBox1.ToolTip2"));
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnLogin
            // 
            resources.ApplyResources(this.btnLogin, "btnLogin");
            this.btnLogin.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnLogin.Image = global::ResturantSystem.Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_dialog_ok_apply_24;
            this.btnLogin.Name = "btnLogin";
            this.toolTip2.SetToolTip(this.btnLogin, resources.GetString("btnLogin.ToolTip"));
            this.toolTip3.SetToolTip(this.btnLogin, resources.GetString("btnLogin.ToolTip1"));
            this.toolTip1.SetToolTip(this.btnLogin, resources.GetString("btnLogin.ToolTip2"));
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Login";
            this.toolTip3.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.toolTip1.SetToolTip(this, resources.GetString("$this.ToolTip1"));
            this.toolTip2.SetToolTip(this, resources.GetString("$this.ToolTip2"));
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

