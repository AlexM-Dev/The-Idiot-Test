namespace The_Idiot_Test {
    partial class ctrlAnswer {
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
            this.lblAnswerName = new System.Windows.Forms.Label();
            this.txtAnswerText = new System.Windows.Forms.TextBox();
            this.lblValue = new System.Windows.Forms.Label();
            this.txtAnswerValue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblAnswerName
            // 
            this.lblAnswerName.AutoSize = true;
            this.lblAnswerName.Location = new System.Drawing.Point(5, 12);
            this.lblAnswerName.Name = "lblAnswerName";
            this.lblAnswerName.Size = new System.Drawing.Size(102, 13);
            this.lblAnswerName.TabIndex = 7;
            this.lblAnswerName.Text = "Answer Name/Text:";
            // 
            // txtAnswerText
            // 
            this.txtAnswerText.Location = new System.Drawing.Point(8, 28);
            this.txtAnswerText.Name = "txtAnswerText";
            this.txtAnswerText.Size = new System.Drawing.Size(170, 20);
            this.txtAnswerText.TabIndex = 6;
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(181, 12);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(37, 13);
            this.lblValue.TabIndex = 9;
            this.lblValue.Text = "Value:";
            // 
            // txtAnswerValue
            // 
            this.txtAnswerValue.Location = new System.Drawing.Point(184, 28);
            this.txtAnswerValue.Name = "txtAnswerValue";
            this.txtAnswerValue.Size = new System.Drawing.Size(72, 20);
            this.txtAnswerValue.TabIndex = 8;
            // 
            // ctrlAnswer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblAnswerName);
            this.Controls.Add(this.txtAnswerText);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.txtAnswerValue);
            this.Name = "ctrlAnswer";
            this.Size = new System.Drawing.Size(260, 60);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAnswerName;
        public System.Windows.Forms.TextBox txtAnswerText;
        private System.Windows.Forms.Label lblValue;
        public System.Windows.Forms.TextBox txtAnswerValue;
    }
}
