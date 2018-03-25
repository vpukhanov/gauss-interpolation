namespace GaussInterpolation
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.alphaTextBox = new System.Windows.Forms.TextBox();
            this.epsilonTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.deltaTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gammaTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.betaTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bScreenTextBox = new System.Windows.Forms.TextBox();
            this.dScreenTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cScreenTextBox = new System.Windows.Forms.TextBox();
            this.aScreenTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.fDrawCheckBox = new System.Windows.Forms.CheckBox();
            this.dPolyDrawCheckBox = new System.Windows.Forms.CheckBox();
            this.dfDrawCheckBox = new System.Windows.Forms.CheckBox();
            this.remainderDrawCheckBox = new System.Windows.Forms.CheckBox();
            this.polyDrawCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.interNumNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.interNumLabel = new System.Windows.Forms.Label();
            this.drawButton = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.plotView = new OxyPlot.WindowsForms.PlotView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.interNumNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "α:";
            // 
            // alphaTextBox
            // 
            this.alphaTextBox.Location = new System.Drawing.Point(55, 23);
            this.alphaTextBox.Name = "alphaTextBox";
            this.alphaTextBox.Size = new System.Drawing.Size(100, 20);
            this.alphaTextBox.TabIndex = 1;
            this.alphaTextBox.Text = "0,7";
            // 
            // epsilonTextBox
            // 
            this.epsilonTextBox.Location = new System.Drawing.Point(55, 127);
            this.epsilonTextBox.Name = "epsilonTextBox";
            this.epsilonTextBox.Size = new System.Drawing.Size(100, 20);
            this.epsilonTextBox.TabIndex = 3;
            this.epsilonTextBox.Text = "0,4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ε:";
            // 
            // deltaTextBox
            // 
            this.deltaTextBox.Location = new System.Drawing.Point(55, 101);
            this.deltaTextBox.Name = "deltaTextBox";
            this.deltaTextBox.Size = new System.Drawing.Size(100, 20);
            this.deltaTextBox.TabIndex = 5;
            this.deltaTextBox.Text = "0,6";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "δ:";
            // 
            // gammaTextBox
            // 
            this.gammaTextBox.Location = new System.Drawing.Point(55, 75);
            this.gammaTextBox.Name = "gammaTextBox";
            this.gammaTextBox.Size = new System.Drawing.Size(100, 20);
            this.gammaTextBox.TabIndex = 7;
            this.gammaTextBox.Text = "1,4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "γ:";
            // 
            // betaTextBox
            // 
            this.betaTextBox.Location = new System.Drawing.Point(55, 49);
            this.betaTextBox.Name = "betaTextBox";
            this.betaTextBox.Size = new System.Drawing.Size(100, 20);
            this.betaTextBox.TabIndex = 9;
            this.betaTextBox.Text = "0,9";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "β:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.betaTextBox);
            this.groupBox1.Controls.Add(this.deltaTextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.gammaTextBox);
            this.groupBox1.Controls.Add(this.alphaTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.epsilonTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 164);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Коэффициенты";
            // 
            // bScreenTextBox
            // 
            this.bScreenTextBox.Location = new System.Drawing.Point(67, 226);
            this.bScreenTextBox.Name = "bScreenTextBox";
            this.bScreenTextBox.Size = new System.Drawing.Size(100, 20);
            this.bScreenTextBox.TabIndex = 17;
            this.bScreenTextBox.Text = "-0,7";
            // 
            // dScreenTextBox
            // 
            this.dScreenTextBox.Location = new System.Drawing.Point(55, 99);
            this.dScreenTextBox.Name = "dScreenTextBox";
            this.dScreenTextBox.Size = new System.Drawing.Size(100, 20);
            this.dScreenTextBox.TabIndex = 13;
            this.dScreenTextBox.Text = "2,5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "B:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "A:";
            // 
            // cScreenTextBox
            // 
            this.cScreenTextBox.Location = new System.Drawing.Point(67, 252);
            this.cScreenTextBox.Name = "cScreenTextBox";
            this.cScreenTextBox.Size = new System.Drawing.Size(100, 20);
            this.cScreenTextBox.TabIndex = 15;
            this.cScreenTextBox.Text = "0,7";
            // 
            // aScreenTextBox
            // 
            this.aScreenTextBox.Location = new System.Drawing.Point(67, 200);
            this.aScreenTextBox.Name = "aScreenTextBox";
            this.aScreenTextBox.Size = new System.Drawing.Size(100, 20);
            this.aScreenTextBox.TabIndex = 11;
            this.aScreenTextBox.Text = "-3,5";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 255);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "C:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 281);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "D:";
            // 
            // fDrawCheckBox
            // 
            this.fDrawCheckBox.AutoSize = true;
            this.fDrawCheckBox.Checked = true;
            this.fDrawCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fDrawCheckBox.Location = new System.Drawing.Point(29, 314);
            this.fDrawCheckBox.Name = "fDrawCheckBox";
            this.fDrawCheckBox.Size = new System.Drawing.Size(40, 17);
            this.fDrawCheckBox.TabIndex = 18;
            this.fDrawCheckBox.Text = "f(x)";
            this.fDrawCheckBox.UseVisualStyleBackColor = true;
            // 
            // dPolyDrawCheckBox
            // 
            this.dPolyDrawCheckBox.AutoSize = true;
            this.dPolyDrawCheckBox.Location = new System.Drawing.Point(110, 337);
            this.dPolyDrawCheckBox.Name = "dPolyDrawCheckBox";
            this.dPolyDrawCheckBox.Size = new System.Drawing.Size(57, 17);
            this.dPolyDrawCheckBox.TabIndex = 19;
            this.dPolyDrawCheckBox.Text = "∂ Pₙ(x)";
            this.dPolyDrawCheckBox.UseVisualStyleBackColor = true;
            // 
            // dfDrawCheckBox
            // 
            this.dfDrawCheckBox.AutoSize = true;
            this.dfDrawCheckBox.Location = new System.Drawing.Point(110, 314);
            this.dfDrawCheckBox.Name = "dfDrawCheckBox";
            this.dfDrawCheckBox.Size = new System.Drawing.Size(49, 17);
            this.dfDrawCheckBox.TabIndex = 20;
            this.dfDrawCheckBox.Text = "∂ f(x)";
            this.dfDrawCheckBox.UseVisualStyleBackColor = true;
            // 
            // remainderDrawCheckBox
            // 
            this.remainderDrawCheckBox.AutoSize = true;
            this.remainderDrawCheckBox.Location = new System.Drawing.Point(29, 360);
            this.remainderDrawCheckBox.Name = "remainderDrawCheckBox";
            this.remainderDrawCheckBox.Size = new System.Drawing.Size(44, 17);
            this.remainderDrawCheckBox.TabIndex = 21;
            this.remainderDrawCheckBox.Text = "rₙ(x)";
            this.remainderDrawCheckBox.UseVisualStyleBackColor = true;
            // 
            // polyDrawCheckBox
            // 
            this.polyDrawCheckBox.AutoSize = true;
            this.polyDrawCheckBox.Location = new System.Drawing.Point(29, 337);
            this.polyDrawCheckBox.Name = "polyDrawCheckBox";
            this.polyDrawCheckBox.Size = new System.Drawing.Size(48, 17);
            this.polyDrawCheckBox.TabIndex = 22;
            this.polyDrawCheckBox.Text = "Pₙ(x)";
            this.polyDrawCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.dScreenTextBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 182);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(180, 203);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Отображение";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 399);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(148, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Число узлов интерполяции:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 426);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "n:";
            // 
            // interNumNumericUpDown
            // 
            this.interNumNumericUpDown.Location = new System.Drawing.Point(38, 424);
            this.interNumNumericUpDown.Name = "interNumNumericUpDown";
            this.interNumNumericUpDown.Size = new System.Drawing.Size(68, 20);
            this.interNumNumericUpDown.TabIndex = 27;
            this.interNumNumericUpDown.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.interNumNumericUpDown.ValueChanged += new System.EventHandler(this.interNumNumericUpDown_ValueChanged);
            // 
            // interNumLabel
            // 
            this.interNumLabel.AutoSize = true;
            this.interNumLabel.Location = new System.Drawing.Point(111, 426);
            this.interNumLabel.Name = "interNumLabel";
            this.interNumLabel.Size = new System.Drawing.Size(25, 13);
            this.interNumLabel.TabIndex = 28;
            this.interNumLabel.Text = "111";
            // 
            // drawButton
            // 
            this.drawButton.Location = new System.Drawing.Point(12, 459);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(180, 23);
            this.drawButton.TabIndex = 29;
            this.drawButton.Text = "Построить";
            this.drawButton.UseVisualStyleBackColor = true;
            this.drawButton.Click += new System.EventHandler(this.drawButton_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(161, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(18, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "←";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(161, 47);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(13, 13);
            this.label13.TabIndex = 32;
            this.label13.Text = "↓";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(161, 73);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(13, 13);
            this.label14.TabIndex = 33;
            this.label14.Text = "↑";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(161, 102);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(18, 13);
            this.label15.TabIndex = 34;
            this.label15.Text = "→";
            // 
            // plotView
            // 
            this.plotView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plotView.BackColor = System.Drawing.SystemColors.Control;
            this.plotView.Location = new System.Drawing.Point(198, 12);
            this.plotView.Name = "plotView";
            this.plotView.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotView.Size = new System.Drawing.Size(1174, 725);
            this.plotView.TabIndex = 30;
            this.plotView.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotView.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotView.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 749);
            this.Controls.Add(this.plotView);
            this.Controls.Add(this.drawButton);
            this.Controls.Add(this.interNumLabel);
            this.Controls.Add(this.interNumNumericUpDown);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.polyDrawCheckBox);
            this.Controls.Add(this.remainderDrawCheckBox);
            this.Controls.Add(this.dfDrawCheckBox);
            this.Controls.Add(this.dPolyDrawCheckBox);
            this.Controls.Add(this.fDrawCheckBox);
            this.Controls.Add(this.bScreenTextBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.aScreenTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cScreenTextBox);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Интерполяция по формуле Гаусса";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.interNumNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox alphaTextBox;
        private System.Windows.Forms.TextBox epsilonTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox deltaTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox gammaTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox betaTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox bScreenTextBox;
        private System.Windows.Forms.TextBox dScreenTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox cScreenTextBox;
        private System.Windows.Forms.TextBox aScreenTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox fDrawCheckBox;
        private System.Windows.Forms.CheckBox dPolyDrawCheckBox;
        private System.Windows.Forms.CheckBox dfDrawCheckBox;
        private System.Windows.Forms.CheckBox remainderDrawCheckBox;
        private System.Windows.Forms.CheckBox polyDrawCheckBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown interNumNumericUpDown;
        private System.Windows.Forms.Label interNumLabel;
        private System.Windows.Forms.Button drawButton;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private OxyPlot.WindowsForms.PlotView plotView;
    }
}

