namespace AutoLolNexus
{
    partial class LolNexus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LolNexus));
            this.webControl1 = new Awesomium.Windows.Forms.WebControl(this.components);
            this.SuspendLayout();
            // 
            // webControl1
            // 
            this.webControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webControl1.Location = new System.Drawing.Point(0, 0);
            this.webControl1.NavigationInfo = Awesomium.Core.NavigationInfo.Normal;
            this.webControl1.Size = new System.Drawing.Size(1173, 630);
            this.webControl1.TabIndex = 0;
            // 
            // LolNexus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 630);
            this.Controls.Add(this.webControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LolNexus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LolNexus";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.LolNexus_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Awesomium.Windows.Forms.WebControl webControl1;

    }
}