namespace AutoLolNexus
{
    partial class Setup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setup));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.summonerName = new System.Windows.Forms.TextBox();
            this.serverName = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(-3, 117);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 48);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Server:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Summoner Name";
            // 
            // summonerName
            // 
            this.summonerName.Location = new System.Drawing.Point(135, 71);
            this.summonerName.Name = "summonerName";
            this.summonerName.Size = new System.Drawing.Size(121, 20);
            this.summonerName.TabIndex = 4;
            // 
            // serverName
            // 
            this.serverName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.serverName.FormattingEnabled = true;
            this.serverName.Items.AddRange(new object[] {
            "NA",
            "EUW",
            "EUNE",
            "BR",
            "TR",
            "RU",
            "LAN",
            "LAS",
            "OCE"});
            this.serverName.Location = new System.Drawing.Point(135, 29);
            this.serverName.Name = "serverName";
            this.serverName.Size = new System.Drawing.Size(121, 21);
            this.serverName.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(264, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Setup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(352, 164);
            this.Controls.Add(this.serverName);
            this.Controls.Add(this.summonerName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Setup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setup";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox summonerName;
        private System.Windows.Forms.ComboBox serverName;
    }
}