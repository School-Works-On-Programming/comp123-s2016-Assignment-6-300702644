namespace COMP123_Assignment_6_BMI
{
    partial class BMICalculator
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
            this.BodyMassIndex = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.MetricUnitsButton = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.BMIResultBox = new System.Windows.Forms.TextBox();
            this.BMIScaleBox = new System.Windows.Forms.TextBox();
            this.BMIResultLabel = new System.Windows.Forms.Label();
            this.BMIScaleLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.BMIProgressBar = new System.Windows.Forms.ProgressBar();
            this.ImperialButton = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // BodyMassIndex
            // 
            this.BodyMassIndex.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BodyMassIndex.AutoSize = true;
            this.BodyMassIndex.Location = new System.Drawing.Point(37, 9);
            this.BodyMassIndex.Name = "BodyMassIndex";
            this.BodyMassIndex.Size = new System.Drawing.Size(192, 31);
            this.BodyMassIndex.TabIndex = 1;
            this.BodyMassIndex.Text = "BMI Calculator";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 134F));
            this.tableLayoutPanel1.Controls.Add(this.ImperialButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.MetricUnitsButton, 0, 0);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 43);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.94118F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(279, 34);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // MetricUnitsButton
            // 
            this.MetricUnitsButton.Location = new System.Drawing.Point(3, 3);
            this.MetricUnitsButton.Name = "MetricUnitsButton";
            this.MetricUnitsButton.Size = new System.Drawing.Size(128, 28);
            this.MetricUnitsButton.TabIndex = 1;
            this.MetricUnitsButton.Text = "Metric";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.35125F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.64875F));
            this.tableLayoutPanel2.Controls.Add(this.HeightLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.WeightLabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.WeightTextBox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.HeightTextBox, 1, 0);
            this.tableLayoutPanel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(13, 78);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(279, 80);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // HeightLabel
            // 
            this.HeightLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Location = new System.Drawing.Point(3, 8);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(65, 24);
            this.HeightLabel.TabIndex = 6;
            this.HeightLabel.Text = "Height";
            this.HeightLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // WeightLabel
            // 
            this.WeightLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Location = new System.Drawing.Point(3, 48);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(69, 24);
            this.WeightLabel.TabIndex = 8;
            this.WeightLabel.Text = "Weight";
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WeightTextBox.Location = new System.Drawing.Point(122, 45);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(140, 29);
            this.WeightTextBox.TabIndex = 9;
            this.WeightTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.WeightTextBox_KeyPress);
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HeightTextBox.Location = new System.Drawing.Point(122, 5);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(140, 29);
            this.HeightTextBox.TabIndex = 7;
            this.HeightTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HeightTextBox_KeyPress);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.BMIResultBox, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.BMIScaleBox, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.BMIResultLabel, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.BMIScaleLabel, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.BMIProgressBar, 0, 4);
            this.tableLayoutPanel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel3.Location = new System.Drawing.Point(13, 159);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(279, 183);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // BMIResultBox
            // 
            this.BMIResultBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BMIResultBox.BackColor = System.Drawing.Color.White;
            this.BMIResultBox.Enabled = false;
            this.BMIResultBox.ForeColor = System.Drawing.Color.LimeGreen;
            this.BMIResultBox.Location = new System.Drawing.Point(89, 35);
            this.BMIResultBox.Name = "BMIResultBox";
            this.BMIResultBox.Size = new System.Drawing.Size(100, 29);
            this.BMIResultBox.TabIndex = 0;
            this.BMIResultBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BMIResultBox.TextChanged += new System.EventHandler(this.BMIResultBox_TextChanged);
            // 
            // BMIScaleBox
            // 
            this.BMIScaleBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BMIScaleBox.BackColor = System.Drawing.Color.White;
            this.BMIScaleBox.Enabled = false;
            this.BMIScaleBox.ForeColor = System.Drawing.Color.LimeGreen;
            this.BMIScaleBox.Location = new System.Drawing.Point(22, 99);
            this.BMIScaleBox.Multiline = true;
            this.BMIScaleBox.Name = "BMIScaleBox";
            this.BMIScaleBox.Size = new System.Drawing.Size(235, 29);
            this.BMIScaleBox.TabIndex = 1;
            this.BMIScaleBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BMIScaleBox.TextChanged += new System.EventHandler(this.BMIScaleBox_TextChanged);
            // 
            // BMIResultLabel
            // 
            this.BMIResultLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BMIResultLabel.AutoSize = true;
            this.BMIResultLabel.Location = new System.Drawing.Point(108, 4);
            this.BMIResultLabel.Name = "BMIResultLabel";
            this.BMIResultLabel.Size = new System.Drawing.Size(62, 24);
            this.BMIResultLabel.TabIndex = 2;
            this.BMIResultLabel.Text = "Result";
            // 
            // BMIScaleLabel
            // 
            this.BMIScaleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BMIScaleLabel.Location = new System.Drawing.Point(89, 69);
            this.BMIScaleLabel.Name = "BMIScaleLabel";
            this.BMIScaleLabel.Size = new System.Drawing.Size(100, 23);
            this.BMIScaleLabel.TabIndex = 2;
            this.BMIScaleLabel.Text = "Scale";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.CalculateButton, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.ClearButton, 1, 0);
            this.tableLayoutPanel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel4.Location = new System.Drawing.Point(13, 358);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(279, 59);
            this.tableLayoutPanel4.TabIndex = 7;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CalculateButton.BackColor = System.Drawing.Color.AntiqueWhite;
            this.CalculateButton.ForeColor = System.Drawing.Color.Maroon;
            this.CalculateButton.Location = new System.Drawing.Point(14, 9);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(110, 40);
            this.CalculateButton.TabIndex = 0;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = false;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ClearButton.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClearButton.ForeColor = System.Drawing.Color.Maroon;
            this.ClearButton.Location = new System.Drawing.Point(154, 9);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(110, 40);
            this.ClearButton.TabIndex = 1;
            this.ClearButton.Text = "Reset";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // BMIProgressBar
            // 
            this.BMIProgressBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BMIProgressBar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BMIProgressBar.Location = new System.Drawing.Point(9, 147);
            this.BMIProgressBar.Name = "BMIProgressBar";
            this.BMIProgressBar.Size = new System.Drawing.Size(261, 23);
            this.BMIProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.BMIProgressBar.TabIndex = 3;
            // 
            // ImperialButton
            // 
            this.ImperialButton.Location = new System.Drawing.Point(148, 3);
            this.ImperialButton.Name = "ImperialButton";
            this.ImperialButton.Size = new System.Drawing.Size(128, 28);
            this.ImperialButton.TabIndex = 2;
            this.ImperialButton.Text = "Imperia";
            // 
            // BMICalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(304, 442);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.BodyMassIndex);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MinimizeBox = false;
            this.Name = "BMICalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label BodyMassIndex;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton MetricUnitsButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.TextBox WeightTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.TextBox BMIResultBox;
        private System.Windows.Forms.TextBox BMIScaleBox;
        private System.Windows.Forms.Label BMIResultLabel;
        private System.Windows.Forms.Label BMIScaleLabel;
        private System.Windows.Forms.ProgressBar BMIProgressBar;
        private System.Windows.Forms.RadioButton ImperialButton;
    }
}

