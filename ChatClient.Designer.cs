namespace ChatClient
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.sendBtn = new System.Windows.Forms.Button();
            this.connectBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.userNameText = new System.Windows.Forms.TextBox();
            this.msgsText = new System.Windows.Forms.TextBox();
            this.msgText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.serverTxt = new System.Windows.Forms.ListBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.disconnectBtn = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // sendBtn
            // 
            this.sendBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendBtn.Location = new System.Drawing.Point(135, 293);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(75, 26);
            this.sendBtn.TabIndex = 0;
            this.sendBtn.Text = "SEND";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.SendBtn_Click);
            // 
            // connectBtn
            // 
            this.connectBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.connectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connectBtn.Font = new System.Drawing.Font("Times New Roman", 7F);
            this.connectBtn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.connectBtn.Location = new System.Drawing.Point(223, 11);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(121, 20);
            this.connectBtn.TabIndex = 1;
            this.connectBtn.Text = "CONNECT";
            this.connectBtn.UseVisualStyleBackColor = true;
            this.connectBtn.Click += new System.EventHandler(this.ConnectBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 11F);
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username:";
            // 
            // userNameText
            // 
            this.userNameText.Location = new System.Drawing.Point(96, 12);
            this.userNameText.Name = "userNameText";
            this.userNameText.ReadOnly = true;
            this.userNameText.Size = new System.Drawing.Size(121, 20);
            this.userNameText.TabIndex = 3;
            // 
            // msgsText
            // 
            this.msgsText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.msgsText.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.msgsText.Location = new System.Drawing.Point(17, 88);
            this.msgsText.Multiline = true;
            this.msgsText.Name = "msgsText";
            this.msgsText.ReadOnly = true;
            this.msgsText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.msgsText.Size = new System.Drawing.Size(321, 177);
            this.msgsText.TabIndex = 4;
            this.msgsText.TextChanged += new System.EventHandler(this.MsgsText_TextChanged);
            // 
            // msgText
            // 
            this.msgText.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.msgText.Location = new System.Drawing.Point(17, 267);
            this.msgText.Name = "msgText";
            this.msgText.Size = new System.Drawing.Size(321, 20);
            this.msgText.TabIndex = 5;
            this.msgText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MsgText_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 11F);
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Server:";
            // 
            // serverTxt
            // 
            this.serverTxt.FormattingEnabled = true;
            this.serverTxt.Items.AddRange(new object[] {
            "10.255.2.140"});
            this.serverTxt.Location = new System.Drawing.Point(96, 41);
            this.serverTxt.Name = "serverTxt";
            this.serverTxt.Size = new System.Drawing.Size(121, 17);
            this.serverTxt.TabIndex = 7;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            // 
            // disconnectBtn
            // 
            this.disconnectBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.disconnectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.disconnectBtn.Font = new System.Drawing.Font("Times New Roman", 7F);
            this.disconnectBtn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.disconnectBtn.Location = new System.Drawing.Point(223, 41);
            this.disconnectBtn.Name = "disconnectBtn";
            this.disconnectBtn.Size = new System.Drawing.Size(121, 20);
            this.disconnectBtn.TabIndex = 8;
            this.disconnectBtn.Text = "DISCONNECT";
            this.disconnectBtn.UseVisualStyleBackColor = true;
            this.disconnectBtn.Click += new System.EventHandler(this.DisconnectBtn_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(17, 65);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(57, 17);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Sound";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(356, 326);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.disconnectBtn);
            this.Controls.Add(this.serverTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.msgText);
            this.Controls.Add(this.msgsText);
            this.Controls.Add(this.userNameText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.connectBtn);
            this.Controls.Add(this.sendBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RWE IT CHAT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userNameText;
        private System.Windows.Forms.TextBox msgsText;
        private System.Windows.Forms.TextBox msgText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox serverTxt;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button disconnectBtn;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

