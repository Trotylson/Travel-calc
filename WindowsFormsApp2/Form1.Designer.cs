
namespace WindowsFormsApp2
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
            this.sumButton = new System.Windows.Forms.Button();
            this.meterTextBox = new System.Windows.Forms.TextBox();
            this.meter2TextBox = new System.Windows.Forms.TextBox();
            this.mS2Label = new System.Windows.Forms.Label();
            this.mSLaber = new System.Windows.Forms.Label();
            this.tLabel = new System.Windows.Forms.Label();
            this.sumLabel = new System.Windows.Forms.Label();
            this.fuelValueTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.traveledSumLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fuelUsageTextBox = new System.Windows.Forms.TextBox();
            this.fuelUsageLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.usedFuelLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sumButton
            // 
            this.sumButton.AutoSize = true;
            this.sumButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sumButton.Location = new System.Drawing.Point(16, 170);
            this.sumButton.Name = "sumButton";
            this.sumButton.Size = new System.Drawing.Size(101, 23);
            this.sumButton.TabIndex = 0;
            this.sumButton.Text = "Podsumowanie ->";
            this.sumButton.UseVisualStyleBackColor = false;
            this.sumButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // meterTextBox
            // 
            this.meterTextBox.Location = new System.Drawing.Point(118, 16);
            this.meterTextBox.Name = "meterTextBox";
            this.meterTextBox.Size = new System.Drawing.Size(115, 20);
            this.meterTextBox.TabIndex = 1;
            this.meterTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // meter2TextBox
            // 
            this.meter2TextBox.Location = new System.Drawing.Point(118, 39);
            this.meter2TextBox.Name = "meter2TextBox";
            this.meter2TextBox.Size = new System.Drawing.Size(115, 20);
            this.meter2TextBox.TabIndex = 2;
            this.meter2TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.meter2TextBox.TextChanged += new System.EventHandler(this.meter2TextBox_TextChanged);
            // 
            // mS2Label
            // 
            this.mS2Label.AutoSize = true;
            this.mS2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mS2Label.Location = new System.Drawing.Point(13, 46);
            this.mS2Label.Name = "mS2Label";
            this.mS2Label.Size = new System.Drawing.Size(85, 13);
            this.mS2Label.TabIndex = 4;
            this.mS2Label.Text = "Stan licznika po:";
            // 
            // mSLaber
            // 
            this.mSLaber.AutoSize = true;
            this.mSLaber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mSLaber.Location = new System.Drawing.Point(13, 19);
            this.mSLaber.Name = "mSLaber";
            this.mSLaber.Size = new System.Drawing.Size(99, 13);
            this.mSLaber.TabIndex = 5;
            this.mSLaber.Text = "Stan licznika przed:";
            // 
            // tLabel
            // 
            this.tLabel.AutoSize = true;
            this.tLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tLabel.Location = new System.Drawing.Point(13, 73);
            this.tLabel.Name = "tLabel";
            this.tLabel.Size = new System.Drawing.Size(51, 13);
            this.tLabel.TabIndex = 6;
            this.tLabel.Text = "Przebyto:";
            // 
            // sumLabel
            // 
            this.sumLabel.AutoSize = true;
            this.sumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sumLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.sumLabel.Location = new System.Drawing.Point(153, 175);
            this.sumLabel.Name = "sumLabel";
            this.sumLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.sumLabel.Size = new System.Drawing.Size(81, 13);
            this.sumLabel.TabIndex = 9;
            this.sumLabel.Text = "NALEŻNOŚĆ";
            this.sumLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // fuelValueTextBox
            // 
            this.fuelValueTextBox.Location = new System.Drawing.Point(432, 16);
            this.fuelValueTextBox.Name = "fuelValueTextBox";
            this.fuelValueTextBox.Size = new System.Drawing.Size(68, 20);
            this.fuelValueTextBox.TabIndex = 10;
            this.fuelValueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(506, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "zł / litr";
            // 
            // traveledSumLabel
            // 
            this.traveledSumLabel.AutoSize = true;
            this.traveledSumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.traveledSumLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.traveledSumLabel.Location = new System.Drawing.Point(153, 73);
            this.traveledSumLabel.Name = "traveledSumLabel";
            this.traveledSumLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.traveledSumLabel.Size = new System.Drawing.Size(14, 13);
            this.traveledSumLabel.TabIndex = 13;
            this.traveledSumLabel.Text = "0";
            this.traveledSumLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(506, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "l / 100 km";
            // 
            // fuelUsageTextBox
            // 
            this.fuelUsageTextBox.Location = new System.Drawing.Point(432, 38);
            this.fuelUsageTextBox.Name = "fuelUsageTextBox";
            this.fuelUsageTextBox.Size = new System.Drawing.Size(68, 20);
            this.fuelUsageTextBox.TabIndex = 15;
            this.fuelUsageTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // fuelUsageLabel
            // 
            this.fuelUsageLabel.AutoSize = true;
            this.fuelUsageLabel.Location = new System.Drawing.Point(156, 104);
            this.fuelUsageLabel.Name = "fuelUsageLabel";
            this.fuelUsageLabel.Size = new System.Drawing.Size(52, 13);
            this.fuelUsageLabel.TabIndex = 16;
            this.fuelUsageLabel.Text = "0 l / 1 km";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(13, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Zużycie na 1 km";
            // 
            // usedFuelLabel
            // 
            this.usedFuelLabel.AutoSize = true;
            this.usedFuelLabel.Location = new System.Drawing.Point(156, 121);
            this.usedFuelLabel.Name = "usedFuelLabel";
            this.usedFuelLabel.Size = new System.Drawing.Size(18, 13);
            this.usedFuelLabel.TabIndex = 18;
            this.usedFuelLabel.Text = "0 l";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(13, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Zużyte paliwo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(344, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Cena paliwa:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(344, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Spalanie:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Magneto", 8.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label7.Location = new System.Drawing.Point(455, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 15);
            this.label7.TabIndex = 22;
            this.label7.Text = "Created by Trotyl";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(578, 205);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.usedFuelLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fuelUsageLabel);
            this.Controls.Add(this.fuelUsageTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.traveledSumLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fuelValueTextBox);
            this.Controls.Add(this.sumLabel);
            this.Controls.Add(this.tLabel);
            this.Controls.Add(this.mSLaber);
            this.Controls.Add(this.mS2Label);
            this.Controls.Add(this.meter2TextBox);
            this.Controls.Add(this.meterTextBox);
            this.Controls.Add(this.sumButton);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calc CRP (Car rental paymeter)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sumButton;
        private System.Windows.Forms.TextBox meterTextBox;
        private System.Windows.Forms.TextBox meter2TextBox;
        private System.Windows.Forms.Label mS2Label;
        private System.Windows.Forms.Label mSLaber;
        private System.Windows.Forms.Label tLabel;
        private System.Windows.Forms.Label sumLabel;
        private System.Windows.Forms.TextBox fuelValueTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label traveledSumLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fuelUsageTextBox;
        private System.Windows.Forms.Label fuelUsageLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label usedFuelLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
    }
}

