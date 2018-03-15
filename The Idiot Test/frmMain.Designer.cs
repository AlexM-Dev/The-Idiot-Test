namespace The_Idiot_Test {
    partial class frmMain {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lblCreate = new System.Windows.Forms.LinkLabel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnCustom = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCreate
            // 
            this.lblCreate.AutoSize = true;
            this.lblCreate.Location = new System.Drawing.Point(14, 12);
            this.lblCreate.Name = "lblCreate";
            this.lblCreate.Size = new System.Drawing.Size(179, 38);
            this.lblCreate.TabIndex = 0;
            this.lblCreate.TabStop = true;
            this.lblCreate.Text = "We made our Idiot Test here!\r\nMake your own today ☺";
            this.lblCreate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblCreate_LinkClicked);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Light", 27F);
            this.lblTitle.Location = new System.Drawing.Point(114, 67);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(226, 48);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "The Idiot Test!";
            // 
            // btnCustom
            // 
            this.btnCustom.Location = new System.Drawing.Point(100, 134);
            this.btnCustom.Name = "btnCustom";
            this.btnCustom.Size = new System.Drawing.Size(124, 40);
            this.btnCustom.TabIndex = 2;
            this.btnCustom.Text = "Run Custom!";
            this.btnCustom.UseVisualStyleBackColor = true;
            this.btnCustom.Click += new System.EventHandler(this.btnCustom_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(230, 134);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(124, 40);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "The REAL Test!";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 211);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnCustom);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblCreate);
            this.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(470, 250);
            this.MinimumSize = new System.Drawing.Size(470, 250);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Idiot Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lblCreate;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnCustom;
        private System.Windows.Forms.Button btnStart;
    }
}

