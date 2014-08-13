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
            this.outputLabel = new System.Windows.Forms.Label();
            this.analyzeButton = new System.Windows.Forms.Button();
            this.findCardsButton = new System.Windows.Forms.Button();
            this.saveImageButton = new System.Windows.Forms.Button();
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
            this.captureButton.Location = new System.Drawing.Point(94, 13);
            this.captureButton.Name = "captureButton";
            this.captureButton.Size = new System.Drawing.Size(75, 23);
            this.captureButton.TabIndex = 1;
            this.captureButton.Text = "Capture";
            this.captureButton.UseVisualStyleBackColor = true;
            this.captureButton.Click += new System.EventHandler(this.captureButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(13, 57);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(37, 13);
            this.outputLabel.TabIndex = 4;
            this.outputLabel.Text = "output";
            // 
            // analyzeButton
            // 
            this.analyzeButton.Location = new System.Drawing.Point(266, 13);
            this.analyzeButton.Name = "analyzeButton";
            this.analyzeButton.Size = new System.Drawing.Size(75, 23);
            this.analyzeButton.TabIndex = 3;
            this.analyzeButton.Text = "Analyze";
            this.analyzeButton.UseVisualStyleBackColor = true;
            this.analyzeButton.Click += new System.EventHandler(this.analyzeButton_Click);
            // 
            // findCardsButton
            // 
            this.findCardsButton.Location = new System.Drawing.Point(176, 13);
            this.findCardsButton.Name = "findCardsButton";
            this.findCardsButton.Size = new System.Drawing.Size(75, 23);
            this.findCardsButton.TabIndex = 2;
            this.findCardsButton.Text = "Find Cards";
            this.findCardsButton.UseVisualStyleBackColor = true;
            this.findCardsButton.Click += new System.EventHandler(this.findCardsButton_Click);
            // 
            // saveImageButton
            // 
            this.saveImageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveImageButton.Location = new System.Drawing.Point(266, 272);
            this.saveImageButton.Name = "saveImageButton";
            this.saveImageButton.Size = new System.Drawing.Size(75, 23);
            this.saveImageButton.TabIndex = 5;
            this.saveImageButton.Text = "Save Image";
            this.saveImageButton.UseVisualStyleBackColor = true;
            this.saveImageButton.Click += new System.EventHandler(this.saveImageButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 307);
            this.Controls.Add(this.saveImageButton);
            this.Controls.Add(this.findCardsButton);
            this.Controls.Add(this.analyzeButton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.captureButton);
            this.Controls.Add(this.setAreaButton);
            this.Name = "MainForm";
            this.Text = "SetBot";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button setAreaButton;
        private System.Windows.Forms.Button captureButton;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button analyzeButton;
        private System.Windows.Forms.Button findCardsButton;
        private System.Windows.Forms.Button saveImageButton;
    }
}

