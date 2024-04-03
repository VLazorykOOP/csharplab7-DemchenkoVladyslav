namespace Lab7CSharp
{
    partial class Form2
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.redRadioButton = new System.Windows.Forms.RadioButton();
            this.greenRadioButton = new System.Windows.Forms.RadioButton();
            this.openButton = new System.Windows.Forms.Button();
            this.extractButton = new System.Windows.Forms.Button();
            this.blueRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(685, 426);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // redRadioButton
            // 
            this.redRadioButton.AutoSize = true;
            this.redRadioButton.Location = new System.Drawing.Point(6, 19);
            this.redRadioButton.Name = "redRadioButton";
            this.redRadioButton.Size = new System.Drawing.Size(45, 17);
            this.redRadioButton.TabIndex = 1;
            this.redRadioButton.TabStop = true;
            this.redRadioButton.Text = "Red";
            this.redRadioButton.UseVisualStyleBackColor = true;
            this.redRadioButton.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // greenRadioButton
            // 
            this.greenRadioButton.AutoSize = true;
            this.greenRadioButton.Location = new System.Drawing.Point(6, 42);
            this.greenRadioButton.Name = "greenRadioButton";
            this.greenRadioButton.Size = new System.Drawing.Size(54, 17);
            this.greenRadioButton.TabIndex = 2;
            this.greenRadioButton.TabStop = true;
            this.greenRadioButton.Text = "Green";
            this.greenRadioButton.UseVisualStyleBackColor = true;
            this.greenRadioButton.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(703, 132);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(75, 23);
            this.openButton.TabIndex = 3;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // extractButton
            // 
            this.extractButton.Location = new System.Drawing.Point(703, 161);
            this.extractButton.Name = "extractButton";
            this.extractButton.Size = new System.Drawing.Size(75, 23);
            this.extractButton.TabIndex = 4;
            this.extractButton.Text = "Export";
            this.extractButton.UseVisualStyleBackColor = true;
            this.extractButton.Click += new System.EventHandler(this.extractButton_Click);
            // 
            // blueRadioButton
            // 
            this.blueRadioButton.AutoSize = true;
            this.blueRadioButton.Location = new System.Drawing.Point(6, 65);
            this.blueRadioButton.Name = "blueRadioButton";
            this.blueRadioButton.Size = new System.Drawing.Size(46, 17);
            this.blueRadioButton.TabIndex = 5;
            this.blueRadioButton.TabStop = true;
            this.blueRadioButton.Text = "Blue";
            this.blueRadioButton.UseVisualStyleBackColor = true;
            this.blueRadioButton.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.redRadioButton);
            this.groupBox1.Controls.Add(this.blueRadioButton);
            this.groupBox1.Controls.Add(this.greenRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(703, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(85, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Color";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.extractButton);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton redRadioButton;
        private System.Windows.Forms.RadioButton greenRadioButton;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button extractButton;
        private System.Windows.Forms.RadioButton blueRadioButton;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}