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
            this.drawCardBoundsButton = new System.Windows.Forms.Button();
            this.outputButton = new System.Windows.Forms.Button();
            this.findSetButton = new System.Windows.Forms.Button();
            this.CFAFOButton = new System.Windows.Forms.Button();
            this.takeSetButton = new System.Windows.Forms.Button();
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
            this.outputLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(192, 42);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(63, 19);
            this.outputLabel.TabIndex = 4;
            this.outputLabel.Text = "output";
            this.outputLabel.Click += new System.EventHandler(this.outputLabel_Click);
            // 
            // analyzeButton
            // 
            this.analyzeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.analyzeButton.Location = new System.Drawing.Point(315, 12);
            this.analyzeButton.Name = "analyzeButton";
            this.analyzeButton.Size = new System.Drawing.Size(75, 23);
            this.analyzeButton.TabIndex = 3;
            this.analyzeButton.Text = "Analyze";
            this.analyzeButton.UseVisualStyleBackColor = true;
            this.analyzeButton.Click += new System.EventHandler(this.analyzeButton_Click);
            // 
            // findCardsButton
            // 
            this.findCardsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.findCardsButton.Location = new System.Drawing.Point(234, 12);
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
            this.saveImageButton.Location = new System.Drawing.Point(313, 151);
            this.saveImageButton.Name = "saveImageButton";
            this.saveImageButton.Size = new System.Drawing.Size(75, 23);
            this.saveImageButton.TabIndex = 5;
            this.saveImageButton.Text = "Save Image";
            this.saveImageButton.UseVisualStyleBackColor = true;
            this.saveImageButton.Click += new System.EventHandler(this.saveImageButton_Click);
            // 
            // drawCardBoundsButton
            // 
            this.drawCardBoundsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.drawCardBoundsButton.Location = new System.Drawing.Point(196, 151);
            this.drawCardBoundsButton.Name = "drawCardBoundsButton";
            this.drawCardBoundsButton.Size = new System.Drawing.Size(111, 23);
            this.drawCardBoundsButton.TabIndex = 6;
            this.drawCardBoundsButton.Text = "Draw Card Bounds";
            this.drawCardBoundsButton.UseVisualStyleBackColor = true;
            this.drawCardBoundsButton.Click += new System.EventHandler(this.drawCardBoundsButton_Click);
            // 
            // outputButton
            // 
            this.outputButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.outputButton.Location = new System.Drawing.Point(16, 151);
            this.outputButton.Name = "outputButton";
            this.outputButton.Size = new System.Drawing.Size(75, 23);
            this.outputButton.TabIndex = 7;
            this.outputButton.Text = "Output";
            this.outputButton.UseVisualStyleBackColor = true;
            this.outputButton.Click += new System.EventHandler(this.outputButton_Click);
            // 
            // findSetButton
            // 
            this.findSetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.findSetButton.Location = new System.Drawing.Point(97, 151);
            this.findSetButton.Name = "findSetButton";
            this.findSetButton.Size = new System.Drawing.Size(75, 23);
            this.findSetButton.TabIndex = 8;
            this.findSetButton.Text = "Find Set";
            this.findSetButton.UseVisualStyleBackColor = true;
            this.findSetButton.Click += new System.EventHandler(this.findSetButton_Click);
            // 
            // CFAFOButton
            // 
            this.CFAFOButton.Location = new System.Drawing.Point(16, 42);
            this.CFAFOButton.Name = "CFAFOButton";
            this.CFAFOButton.Size = new System.Drawing.Size(153, 103);
            this.CFAFOButton.TabIndex = 9;
            this.CFAFOButton.Text = "CFAFO";
            this.CFAFOButton.UseVisualStyleBackColor = true;
            this.CFAFOButton.Click += new System.EventHandler(this.CFAFOButton_Click);
            // 
            // takeSetButton
            // 
            this.takeSetButton.Location = new System.Drawing.Point(196, 121);
            this.takeSetButton.Name = "takeSetButton";
            this.takeSetButton.Size = new System.Drawing.Size(75, 23);
            this.takeSetButton.TabIndex = 10;
            this.takeSetButton.Text = "Take Set";
            this.takeSetButton.UseVisualStyleBackColor = true;
            this.takeSetButton.Click += new System.EventHandler(this.takeSetButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 186);
            this.Controls.Add(this.takeSetButton);
            this.Controls.Add(this.CFAFOButton);
            this.Controls.Add(this.findSetButton);
            this.Controls.Add(this.outputButton);
            this.Controls.Add(this.drawCardBoundsButton);
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
        private System.Windows.Forms.Button drawCardBoundsButton;
        private System.Windows.Forms.Button outputButton;
        private System.Windows.Forms.Button findSetButton;
        private System.Windows.Forms.Button CFAFOButton;
        private System.Windows.Forms.Button takeSetButton;
    }
}

