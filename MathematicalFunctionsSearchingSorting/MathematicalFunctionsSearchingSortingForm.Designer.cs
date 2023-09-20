namespace MathematicalFunctionsSearchingSorting
{
    partial class MathematicalFunctionsSearchingSortingForm
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
            this.NumberTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddToListButton = new System.Windows.Forms.Button();
            this.NumberListBox = new System.Windows.Forms.ListBox();
            this.outputLabel = new System.Windows.Forms.Label();
            this.FillListBoxWithRandomValuesButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.RoundButton = new System.Windows.Forms.Button();
            this.DecimalPlacesTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.HowManyRandomValuesTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.kTextBox = new System.Windows.Forms.TextBox();
            this.KthSmallestButton = new System.Windows.Forms.Button();
            this.AverageButton = new System.Windows.Forms.Button();
            this.HarmonicMean = new System.Windows.Forms.Button();
            this.GeometricMeanButton = new System.Windows.Forms.Button();
            this.ModeButton = new System.Windows.Forms.Button();
            this.MedianButton = new System.Windows.Forms.Button();
            this.ArithmeticMeanButton = new System.Windows.Forms.Button();
            this.MinButton = new System.Windows.Forms.Button();
            this.MaxButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LinearSearchButton = new System.Windows.Forms.Button();
            this.BinarySearchButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.PartitionMethodComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RightTextBox = new System.Windows.Forms.TextBox();
            this.LeftTextBox = new System.Windows.Forms.TextBox();
            this.PartitionButton = new System.Windows.Forms.Button();
            this.SortingMethodComboBox = new System.Windows.Forms.ComboBox();
            this.SortButton = new System.Windows.Forms.Button();
            this.ScrambleButton = new System.Windows.Forms.Button();
            this.IndexListBox = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // NumberTextBox
            // 
            this.NumberTextBox.Location = new System.Drawing.Point(119, 13);
            this.NumberTextBox.Name = "NumberTextBox";
            this.NumberTextBox.Size = new System.Drawing.Size(72, 20);
            this.NumberTextBox.TabIndex = 0;
            this.NumberTextBox.Click += new System.EventHandler(this.NumberTextBox_Click);
            this.NumberTextBox.Enter += new System.EventHandler(this.NumberTextBox_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please enter a number:";
            // 
            // AddToListButton
            // 
            this.AddToListButton.Location = new System.Drawing.Point(197, 12);
            this.AddToListButton.Name = "AddToListButton";
            this.AddToListButton.Size = new System.Drawing.Size(71, 22);
            this.AddToListButton.TabIndex = 1;
            this.AddToListButton.Text = "Add to List";
            this.AddToListButton.UseVisualStyleBackColor = true;
            this.AddToListButton.Click += new System.EventHandler(this.AddToListButton_Click);
            // 
            // NumberListBox
            // 
            this.NumberListBox.FormattingEnabled = true;
            this.NumberListBox.Location = new System.Drawing.Point(58, 81);
            this.NumberListBox.Name = "NumberListBox";
            this.NumberListBox.Size = new System.Drawing.Size(154, 498);
            this.NumberListBox.TabIndex = 11;
            this.NumberListBox.Click += new System.EventHandler(this.NumberListBox_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(2, 587);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(0, 16);
            this.outputLabel.TabIndex = 10;
            // 
            // FillListBoxWithRandomValuesButton
            // 
            this.FillListBoxWithRandomValuesButton.Location = new System.Drawing.Point(5, 49);
            this.FillListBoxWithRandomValuesButton.Name = "FillListBoxWithRandomValuesButton";
            this.FillListBoxWithRandomValuesButton.Size = new System.Drawing.Size(113, 25);
            this.FillListBoxWithRandomValuesButton.TabIndex = 2;
            this.FillListBoxWithRandomValuesButton.Text = "Fill list box with";
            this.FillListBoxWithRandomValuesButton.UseVisualStyleBackColor = true;
            this.FillListBoxWithRandomValuesButton.Click += new System.EventHandler(this.FillListBoxWithRandomValuesButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(224, 82);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(149, 25);
            this.ClearButton.TabIndex = 3;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // RoundButton
            // 
            this.RoundButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoundButton.Location = new System.Drawing.Point(274, 11);
            this.RoundButton.Name = "RoundButton";
            this.RoundButton.Size = new System.Drawing.Size(56, 25);
            this.RoundButton.TabIndex = 19;
            this.RoundButton.Text = "Round to";
            this.RoundButton.UseVisualStyleBackColor = true;
            this.RoundButton.Click += new System.EventHandler(this.RoundButton_Click);
            // 
            // DecimalPlacesTextBox
            // 
            this.DecimalPlacesTextBox.Location = new System.Drawing.Point(332, 13);
            this.DecimalPlacesTextBox.Name = "DecimalPlacesTextBox";
            this.DecimalPlacesTextBox.Size = new System.Drawing.Size(28, 20);
            this.DecimalPlacesTextBox.TabIndex = 20;
            this.DecimalPlacesTextBox.Text = "2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(291, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 12);
            this.label2.TabIndex = 21;
            this.label2.Text = "decimal places.";
            // 
            // HowManyRandomValuesTextBox
            // 
            this.HowManyRandomValuesTextBox.Location = new System.Drawing.Point(119, 51);
            this.HowManyRandomValuesTextBox.Name = "HowManyRandomValuesTextBox";
            this.HowManyRandomValuesTextBox.Size = new System.Drawing.Size(40, 20);
            this.HowManyRandomValuesTextBox.TabIndex = 22;
            this.HowManyRandomValuesTextBox.Text = "20";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "pseudorandom \"double\" Values";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.kTextBox);
            this.groupBox1.Controls.Add(this.KthSmallestButton);
            this.groupBox1.Controls.Add(this.AverageButton);
            this.groupBox1.Controls.Add(this.HarmonicMean);
            this.groupBox1.Controls.Add(this.GeometricMeanButton);
            this.groupBox1.Controls.Add(this.ModeButton);
            this.groupBox1.Controls.Add(this.MedianButton);
            this.groupBox1.Controls.Add(this.ArithmeticMeanButton);
            this.groupBox1.Controls.Add(this.MinButton);
            this.groupBox1.Controls.Add(this.MaxButton);
            this.groupBox1.Location = new System.Drawing.Point(218, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(160, 212);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mathematical Functions";
            // 
            // kTextBox
            // 
            this.kTextBox.Location = new System.Drawing.Point(115, 186);
            this.kTextBox.Name = "kTextBox";
            this.kTextBox.Size = new System.Drawing.Size(40, 20);
            this.kTextBox.TabIndex = 28;
            this.kTextBox.Text = "1";
            // 
            // KthSmallestButton
            // 
            this.KthSmallestButton.Location = new System.Drawing.Point(6, 183);
            this.KthSmallestButton.Name = "KthSmallestButton";
            this.KthSmallestButton.Size = new System.Drawing.Size(106, 25);
            this.KthSmallestButton.TabIndex = 27;
            this.KthSmallestButton.Text = "kth Smallest";
            this.KthSmallestButton.UseVisualStyleBackColor = true;
            this.KthSmallestButton.Click += new System.EventHandler(this.KthSmallestButton_Click);
            // 
            // AverageButton
            // 
            this.AverageButton.Location = new System.Drawing.Point(6, 15);
            this.AverageButton.Name = "AverageButton";
            this.AverageButton.Size = new System.Drawing.Size(149, 25);
            this.AverageButton.TabIndex = 26;
            this.AverageButton.Text = "Average (Arithmetic Mean)";
            this.AverageButton.UseVisualStyleBackColor = true;
            this.AverageButton.Click += new System.EventHandler(this.AverageButton_Click);
            // 
            // HarmonicMean
            // 
            this.HarmonicMean.Location = new System.Drawing.Point(6, 111);
            this.HarmonicMean.Name = "HarmonicMean";
            this.HarmonicMean.Size = new System.Drawing.Size(149, 25);
            this.HarmonicMean.TabIndex = 25;
            this.HarmonicMean.Text = "Harmonic Mean";
            this.HarmonicMean.UseVisualStyleBackColor = true;
            this.HarmonicMean.Click += new System.EventHandler(this.HarmonicMean_Click);
            // 
            // GeometricMeanButton
            // 
            this.GeometricMeanButton.Location = new System.Drawing.Point(6, 87);
            this.GeometricMeanButton.Name = "GeometricMeanButton";
            this.GeometricMeanButton.Size = new System.Drawing.Size(149, 25);
            this.GeometricMeanButton.TabIndex = 24;
            this.GeometricMeanButton.Text = "Geometric Mean";
            this.GeometricMeanButton.UseVisualStyleBackColor = true;
            this.GeometricMeanButton.Click += new System.EventHandler(this.GeometricMeanButton_Click);
            // 
            // ModeButton
            // 
            this.ModeButton.Location = new System.Drawing.Point(6, 63);
            this.ModeButton.Name = "ModeButton";
            this.ModeButton.Size = new System.Drawing.Size(149, 25);
            this.ModeButton.TabIndex = 23;
            this.ModeButton.Text = "Mode";
            this.ModeButton.UseVisualStyleBackColor = true;
            this.ModeButton.Click += new System.EventHandler(this.ModeButton_Click);
            // 
            // MedianButton
            // 
            this.MedianButton.Location = new System.Drawing.Point(6, 39);
            this.MedianButton.Name = "MedianButton";
            this.MedianButton.Size = new System.Drawing.Size(149, 25);
            this.MedianButton.TabIndex = 22;
            this.MedianButton.Text = "Median";
            this.MedianButton.UseVisualStyleBackColor = true;
            this.MedianButton.Click += new System.EventHandler(this.MedianButton_Click);
            // 
            // ArithmeticMeanButton
            // 
            this.ArithmeticMeanButton.Location = new System.Drawing.Point(26, -34);
            this.ArithmeticMeanButton.Name = "ArithmeticMeanButton";
            this.ArithmeticMeanButton.Size = new System.Drawing.Size(149, 25);
            this.ArithmeticMeanButton.TabIndex = 21;
            this.ArithmeticMeanButton.Text = "Arithmetic Mean (Average)";
            this.ArithmeticMeanButton.UseVisualStyleBackColor = true;
            // 
            // MinButton
            // 
            this.MinButton.Location = new System.Drawing.Point(6, 135);
            this.MinButton.Name = "MinButton";
            this.MinButton.Size = new System.Drawing.Size(149, 25);
            this.MinButton.TabIndex = 19;
            this.MinButton.Text = "Min";
            this.MinButton.UseVisualStyleBackColor = true;
            this.MinButton.Click += new System.EventHandler(this.MinButton_Click);
            // 
            // MaxButton
            // 
            this.MaxButton.Location = new System.Drawing.Point(6, 159);
            this.MaxButton.Name = "MaxButton";
            this.MaxButton.Size = new System.Drawing.Size(149, 25);
            this.MaxButton.TabIndex = 20;
            this.MaxButton.Text = "Max";
            this.MaxButton.UseVisualStyleBackColor = true;
            this.MaxButton.Click += new System.EventHandler(this.MaxButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LinearSearchButton);
            this.groupBox2.Controls.Add(this.BinarySearchButton);
            this.groupBox2.Location = new System.Drawing.Point(218, 331);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(160, 74);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Searching";
            // 
            // LinearSearchButton
            // 
            this.LinearSearchButton.Location = new System.Drawing.Point(5, 19);
            this.LinearSearchButton.Name = "LinearSearchButton";
            this.LinearSearchButton.Size = new System.Drawing.Size(149, 25);
            this.LinearSearchButton.TabIndex = 33;
            this.LinearSearchButton.Text = "Linear Search";
            this.LinearSearchButton.UseVisualStyleBackColor = true;
            this.LinearSearchButton.Click += new System.EventHandler(this.LinearSearchButton_Click);
            // 
            // BinarySearchButton
            // 
            this.BinarySearchButton.Location = new System.Drawing.Point(5, 43);
            this.BinarySearchButton.Name = "BinarySearchButton";
            this.BinarySearchButton.Size = new System.Drawing.Size(149, 25);
            this.BinarySearchButton.TabIndex = 32;
            this.BinarySearchButton.Text = "Binary Search";
            this.BinarySearchButton.UseVisualStyleBackColor = true;
            this.BinarySearchButton.Click += new System.EventHandler(this.BinarySearchButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.PartitionMethodComboBox);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.RightTextBox);
            this.groupBox3.Controls.Add(this.LeftTextBox);
            this.groupBox3.Controls.Add(this.PartitionButton);
            this.groupBox3.Controls.Add(this.SortingMethodComboBox);
            this.groupBox3.Controls.Add(this.SortButton);
            this.groupBox3.Controls.Add(this.ScrambleButton);
            this.groupBox3.Location = new System.Drawing.Point(218, 409);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(160, 170);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sorting and Scrambling";
            // 
            // PartitionMethodComboBox
            // 
            this.PartitionMethodComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PartitionMethodComboBox.FormattingEnabled = true;
            this.PartitionMethodComboBox.Items.AddRange(new object[] {
            "Naive Partition",
            "Lomuto Partition",
            "Hoare Partition"});
            this.PartitionMethodComboBox.Location = new System.Drawing.Point(6, 113);
            this.PartitionMethodComboBox.Name = "PartitionMethodComboBox";
            this.PartitionMethodComboBox.Size = new System.Drawing.Size(149, 21);
            this.PartitionMethodComboBox.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(100, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 12);
            this.label5.TabIndex = 36;
            this.label5.Text = "Right";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 12);
            this.label4.TabIndex = 35;
            this.label4.Text = "Left";
            // 
            // RightTextBox
            // 
            this.RightTextBox.Location = new System.Drawing.Point(127, 141);
            this.RightTextBox.Name = "RightTextBox";
            this.RightTextBox.Size = new System.Drawing.Size(28, 20);
            this.RightTextBox.TabIndex = 34;
            this.RightTextBox.Text = "0";
            // 
            // LeftTextBox
            // 
            this.LeftTextBox.Location = new System.Drawing.Point(6, 141);
            this.LeftTextBox.Name = "LeftTextBox";
            this.LeftTextBox.Size = new System.Drawing.Size(28, 20);
            this.LeftTextBox.TabIndex = 33;
            this.LeftTextBox.Text = "0";
            // 
            // PartitionButton
            // 
            this.PartitionButton.Location = new System.Drawing.Point(6, 86);
            this.PartitionButton.Name = "PartitionButton";
            this.PartitionButton.Size = new System.Drawing.Size(149, 25);
            this.PartitionButton.TabIndex = 32;
            this.PartitionButton.Text = "Partition List for Quick Sort";
            this.PartitionButton.UseVisualStyleBackColor = true;
            this.PartitionButton.Click += new System.EventHandler(this.PartitionButton_Click);
            // 
            // SortingMethodComboBox
            // 
            this.SortingMethodComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SortingMethodComboBox.FormattingEnabled = true;
            this.SortingMethodComboBox.Items.AddRange(new object[] {
            "Selection Sort",
            "Bubble Sort",
            "Cocktail Sort",
            "Insertion Sort",
            "Shell Sort",
            "Quick Sort"});
            this.SortingMethodComboBox.Location = new System.Drawing.Point(6, 63);
            this.SortingMethodComboBox.Name = "SortingMethodComboBox";
            this.SortingMethodComboBox.Size = new System.Drawing.Size(149, 21);
            this.SortingMethodComboBox.TabIndex = 31;
            // 
            // SortButton
            // 
            this.SortButton.Location = new System.Drawing.Point(6, 38);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(149, 25);
            this.SortButton.TabIndex = 29;
            this.SortButton.Text = "Sort";
            this.SortButton.UseVisualStyleBackColor = true;
            this.SortButton.Click += new System.EventHandler(this.SortButton_Click);
            // 
            // ScrambleButton
            // 
            this.ScrambleButton.Location = new System.Drawing.Point(6, 14);
            this.ScrambleButton.Name = "ScrambleButton";
            this.ScrambleButton.Size = new System.Drawing.Size(149, 25);
            this.ScrambleButton.TabIndex = 30;
            this.ScrambleButton.Text = "Scramble";
            this.ScrambleButton.UseVisualStyleBackColor = true;
            this.ScrambleButton.Click += new System.EventHandler(this.ScrambleButton_Click);
            // 
            // IndexListBox
            // 
            this.IndexListBox.FormattingEnabled = true;
            this.IndexListBox.Location = new System.Drawing.Point(5, 82);
            this.IndexListBox.Name = "IndexListBox";
            this.IndexListBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.IndexListBox.Size = new System.Drawing.Size(47, 498);
            this.IndexListBox.TabIndex = 32;
            this.IndexListBox.Click += new System.EventHandler(this.IndexListBox_Click);
            // 
            // MathematicalFunctionsForm
            // 
            this.AcceptButton = this.AddToListButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 634);
            this.Controls.Add(this.IndexListBox);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.HowManyRandomValuesTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DecimalPlacesTextBox);
            this.Controls.Add(this.RoundButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.FillListBoxWithRandomValuesButton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.NumberListBox);
            this.Controls.Add(this.AddToListButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumberTextBox);
            this.Name = "MathematicalFunctionsForm";
            this.Text = "Mathematical Functions, Searching, Sorting";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NumberTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddToListButton;
        private System.Windows.Forms.ListBox NumberListBox;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button FillListBoxWithRandomValuesButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button RoundButton;
        private System.Windows.Forms.TextBox DecimalPlacesTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox HowManyRandomValuesTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button HarmonicMean;
        private System.Windows.Forms.Button GeometricMeanButton;
        private System.Windows.Forms.Button ModeButton;
        private System.Windows.Forms.Button MedianButton;
        private System.Windows.Forms.Button ArithmeticMeanButton;
        private System.Windows.Forms.Button MinButton;
        private System.Windows.Forms.Button MaxButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button LinearSearchButton;
        private System.Windows.Forms.Button BinarySearchButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox RightTextBox;
        private System.Windows.Forms.TextBox LeftTextBox;
        private System.Windows.Forms.Button PartitionButton;
        private System.Windows.Forms.ComboBox SortingMethodComboBox;
        private System.Windows.Forms.Button SortButton;
        private System.Windows.Forms.Button ScrambleButton;
        private System.Windows.Forms.Button AverageButton;
        private System.Windows.Forms.ListBox IndexListBox;
        private System.Windows.Forms.ComboBox PartitionMethodComboBox;
        private System.Windows.Forms.TextBox kTextBox;
        private System.Windows.Forms.Button KthSmallestButton;
    }
}

