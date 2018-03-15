namespace The_Idiot_Test {
    partial class ctrlResult {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lblExpression = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnWoah = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblExpression
            // 
            this.lblExpression.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExpression.Font = new System.Drawing.Font("Segoe UI Light", 24F);
            this.lblExpression.Location = new System.Drawing.Point(0, 0);
            this.lblExpression.Name = "lblExpression";
            this.lblExpression.Size = new System.Drawing.Size(420, 107);
            this.lblExpression.TabIndex = 0;
            this.lblExpression.Text = "You rank as a(n) ";
            this.lblExpression.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAccept
            // 
            this.btnAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccept.Location = new System.Drawing.Point(247, 141);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(147, 38);
            this.btnAccept.TabIndex = 1;
            this.btnAccept.Text = "I accept my fate.";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnWoah
            // 
            this.btnWoah.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWoah.Location = new System.Drawing.Point(94, 141);
            this.btnWoah.Name = "btnWoah";
            this.btnWoah.Size = new System.Drawing.Size(147, 38);
            this.btnWoah.TabIndex = 2;
            this.btnWoah.Text = "Woah. Send help.";
            this.btnWoah.UseVisualStyleBackColor = true;
            this.btnWoah.Click += new System.EventHandler(this.btnWoah_Click);
            // 
            // ctrlResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnWoah);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.lblExpression);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ctrlResult";
            this.Size = new System.Drawing.Size(420, 200);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblExpression;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnWoah;
    }
}
