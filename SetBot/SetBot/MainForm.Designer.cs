namespace SetBot
{
    partial class MainForm
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
            this.setAreaButton = new System.Windows.Forms.Button();
            this.captureButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // setAreaButton
            // 
            this.setAreaButton.Location = new System.Drawing.Point(13, 13);
            this.setAreaButton.Name = "setAreaButton";
            this.setAreaButton.Size = new System.Drawing.Size(75, 23);
            this.setAreaButton.TabIndex = 0;
            this.setAreaButton.Text = "Set Area";
            this.setAreaButton.UseVisualStyleBackColor = true;
            this.setAreaButton.Click += new System.EventHandler(this.setAreaButton_Click);
            // 
            // captureButton
            // 
            this.captureButton.Location = new System.Drawing.Point(107, 13);
            this.captureButton.Name = "captureButton";
            this.captureButton.Size = new System.Drawing.Size(75, 23);
            this.captureButton.TabIndex = 1;
            this.captureButton.Text = "Capture";
            this.captureButton.UseVisualStyleBackColor = true;
            this.captureButton.Click += new System.EventHandler(this.captureButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 307);
            this.Controls.Add(this.captureButton);
            this.Controls.Add(this.setAreaButton);
            this.Name = "MainForm";
            this.Text = "SetBot";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button setAreaButton;
        private System.Windows.Forms.Button captureButton;
    }
}

