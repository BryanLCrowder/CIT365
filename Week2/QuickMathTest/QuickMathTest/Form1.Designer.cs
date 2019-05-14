namespace QuickMathTest
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timeLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.plusLeftLabel = new System.Windows.Forms.Label();
            this.plusRightLabel = new System.Windows.Forms.Label();
            this.plusSign = new System.Windows.Forms.Label();
            this.equalsAdd = new System.Windows.Forms.Label();
            this.sum = new System.Windows.Forms.NumericUpDown();
            this.minusLeftLabel = new System.Windows.Forms.Label();
            this.timesLeftLabel = new System.Windows.Forms.Label();
            this.dividedLeftLabel = new System.Windows.Forms.Label();
            this.minusRightLabel = new System.Windows.Forms.Label();
            this.timesRightLabel = new System.Windows.Forms.Label();
            this.dividedRightLabel = new System.Windows.Forms.Label();
            this.subtract = new System.Windows.Forms.Label();
            this.multiply = new System.Windows.Forms.Label();
            this.divide = new System.Windows.Forms.Label();
            this.equalsSubtract = new System.Windows.Forms.Label();
            this.equalsMultiply = new System.Windows.Forms.Label();
            this.equalsDivide = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.difference = new System.Windows.Forms.NumericUpDown();
            this.product = new System.Windows.Forms.NumericUpDown();
            this.quotient = new System.Windows.Forms.NumericUpDown();
            this.timeLabel1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.currentDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.difference)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotient)).BeginInit();
            this.SuspendLayout();
            // 
            // timeLabel
            // 
            this.timeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(250, 14);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(200, 30);
            this.timeLabel.TabIndex = 0;
            this.timeLabel.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(125, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Time Left";
            // 
            // plusLeftLabel
            // 
            this.plusLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusLeftLabel.Location = new System.Drawing.Point(50, 75);
            this.plusLeftLabel.Name = "plusLeftLabel";
            this.plusLeftLabel.Size = new System.Drawing.Size(60, 50);
            this.plusLeftLabel.TabIndex = 2;
            this.plusLeftLabel.Text = "?";
            this.plusLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plusRightLabel
            // 
            this.plusRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusRightLabel.Location = new System.Drawing.Point(200, 75);
            this.plusRightLabel.Name = "plusRightLabel";
            this.plusRightLabel.Size = new System.Drawing.Size(60, 50);
            this.plusRightLabel.TabIndex = 3;
            this.plusRightLabel.Text = "?";
            this.plusRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plusSign
            // 
            this.plusSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusSign.Location = new System.Drawing.Point(125, 75);
            this.plusSign.Name = "plusSign";
            this.plusSign.Size = new System.Drawing.Size(60, 50);
            this.plusSign.TabIndex = 4;
            this.plusSign.Text = "+";
            this.plusSign.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // equalsAdd
            // 
            this.equalsAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalsAdd.Location = new System.Drawing.Point(275, 75);
            this.equalsAdd.Name = "equalsAdd";
            this.equalsAdd.Size = new System.Drawing.Size(60, 50);
            this.equalsAdd.TabIndex = 5;
            this.equalsAdd.Text = "=";
            this.equalsAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sum
            // 
            this.sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sum.Location = new System.Drawing.Point(350, 84);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(100, 35);
            this.sum.TabIndex = 6;
            this.sum.ValueChanged += new System.EventHandler(this.Sum_ValueChanged);
            this.sum.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // minusLeftLabel
            // 
            this.minusLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusLeftLabel.Location = new System.Drawing.Point(50, 150);
            this.minusLeftLabel.Name = "minusLeftLabel";
            this.minusLeftLabel.Size = new System.Drawing.Size(60, 50);
            this.minusLeftLabel.TabIndex = 7;
            this.minusLeftLabel.Text = "?";
            this.minusLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timesLeftLabel
            // 
            this.timesLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timesLeftLabel.Location = new System.Drawing.Point(50, 225);
            this.timesLeftLabel.Name = "timesLeftLabel";
            this.timesLeftLabel.Size = new System.Drawing.Size(60, 50);
            this.timesLeftLabel.TabIndex = 8;
            this.timesLeftLabel.Text = "?";
            this.timesLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dividedLeftLabel
            // 
            this.dividedLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dividedLeftLabel.Location = new System.Drawing.Point(50, 300);
            this.dividedLeftLabel.Name = "dividedLeftLabel";
            this.dividedLeftLabel.Size = new System.Drawing.Size(60, 50);
            this.dividedLeftLabel.TabIndex = 9;
            this.dividedLeftLabel.Text = "?";
            this.dividedLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minusRightLabel
            // 
            this.minusRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusRightLabel.Location = new System.Drawing.Point(200, 150);
            this.minusRightLabel.Name = "minusRightLabel";
            this.minusRightLabel.Size = new System.Drawing.Size(60, 50);
            this.minusRightLabel.TabIndex = 10;
            this.minusRightLabel.Text = "?";
            this.minusRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timesRightLabel
            // 
            this.timesRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timesRightLabel.Location = new System.Drawing.Point(200, 225);
            this.timesRightLabel.Name = "timesRightLabel";
            this.timesRightLabel.Size = new System.Drawing.Size(60, 50);
            this.timesRightLabel.TabIndex = 11;
            this.timesRightLabel.Text = "?";
            this.timesRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dividedRightLabel
            // 
            this.dividedRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dividedRightLabel.Location = new System.Drawing.Point(200, 300);
            this.dividedRightLabel.Name = "dividedRightLabel";
            this.dividedRightLabel.Size = new System.Drawing.Size(60, 50);
            this.dividedRightLabel.TabIndex = 12;
            this.dividedRightLabel.Text = "?";
            this.dividedRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // subtract
            // 
            this.subtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtract.Location = new System.Drawing.Point(125, 150);
            this.subtract.Name = "subtract";
            this.subtract.Size = new System.Drawing.Size(60, 50);
            this.subtract.TabIndex = 13;
            this.subtract.Text = "-";
            this.subtract.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // multiply
            // 
            this.multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiply.Location = new System.Drawing.Point(125, 225);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(60, 50);
            this.multiply.TabIndex = 14;
            this.multiply.Text = "*";
            this.multiply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // divide
            // 
            this.divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divide.Location = new System.Drawing.Point(125, 300);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(60, 50);
            this.divide.TabIndex = 15;
            this.divide.Text = "/";
            this.divide.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.divide.Click += new System.EventHandler(this.Divide_Click);
            // 
            // equalsSubtract
            // 
            this.equalsSubtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalsSubtract.Location = new System.Drawing.Point(275, 150);
            this.equalsSubtract.Name = "equalsSubtract";
            this.equalsSubtract.Size = new System.Drawing.Size(60, 50);
            this.equalsSubtract.TabIndex = 16;
            this.equalsSubtract.Text = "=";
            this.equalsSubtract.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.equalsSubtract.Click += new System.EventHandler(this.EqualsSubtract_Click);
            // 
            // equalsMultiply
            // 
            this.equalsMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalsMultiply.Location = new System.Drawing.Point(275, 225);
            this.equalsMultiply.Name = "equalsMultiply";
            this.equalsMultiply.Size = new System.Drawing.Size(60, 50);
            this.equalsMultiply.TabIndex = 17;
            this.equalsMultiply.Text = "=";
            this.equalsMultiply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // equalsDivide
            // 
            this.equalsDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalsDivide.Location = new System.Drawing.Point(275, 300);
            this.equalsDivide.Name = "equalsDivide";
            this.equalsDivide.Size = new System.Drawing.Size(60, 50);
            this.equalsDivide.TabIndex = 18;
            this.equalsDivide.Text = "=";
            this.equalsDivide.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startButton
            // 
            this.startButton.AutoSize = true;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(174, 47);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(105, 34);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start Quiz!";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // difference
            // 
            this.difference.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.difference.Location = new System.Drawing.Point(350, 159);
            this.difference.Name = "difference";
            this.difference.Size = new System.Drawing.Size(100, 35);
            this.difference.TabIndex = 20;
            this.difference.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // product
            // 
            this.product.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product.Location = new System.Drawing.Point(350, 234);
            this.product.Name = "product";
            this.product.Size = new System.Drawing.Size(100, 35);
            this.product.TabIndex = 21;
            this.product.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // quotient
            // 
            this.quotient.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quotient.Location = new System.Drawing.Point(350, 309);
            this.quotient.Name = "quotient";
            this.quotient.Size = new System.Drawing.Size(100, 35);
            this.quotient.TabIndex = 22;
            this.quotient.ValueChanged += new System.EventHandler(this.NumericUpDown3_ValueChanged);
            this.quotient.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // timeLabel1
            // 
            this.timeLabel1.AutoSize = true;
            this.timeLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel1.Location = new System.Drawing.Point(9, 47);
            this.timeLabel1.Name = "timeLabel1";
            this.timeLabel1.Size = new System.Drawing.Size(0, 25);
            this.timeLabel1.TabIndex = 23;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // currentDate
            // 
            this.currentDate.AutoSize = true;
            this.currentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentDate.Location = new System.Drawing.Point(309, 51);
            this.currentDate.Name = "currentDate";
            this.currentDate.Size = new System.Drawing.Size(43, 25);
            this.currentDate.TabIndex = 24;
            this.currentDate.Text = "text";
            this.currentDate.Click += new System.EventHandler(this.CurrentDate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.currentDate);
            this.Controls.Add(this.timeLabel1);
            this.Controls.Add(this.quotient);
            this.Controls.Add(this.product);
            this.Controls.Add(this.difference);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.equalsDivide);
            this.Controls.Add(this.equalsMultiply);
            this.Controls.Add(this.equalsSubtract);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.subtract);
            this.Controls.Add(this.dividedRightLabel);
            this.Controls.Add(this.timesRightLabel);
            this.Controls.Add(this.minusRightLabel);
            this.Controls.Add(this.dividedLeftLabel);
            this.Controls.Add(this.timesLeftLabel);
            this.Controls.Add(this.minusLeftLabel);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.equalsAdd);
            this.Controls.Add(this.plusSign);
            this.Controls.Add(this.plusRightLabel);
            this.Controls.Add(this.plusLeftLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.timeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Bryan Crowder Math Quiz";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.difference)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label plusLeftLabel;
        private System.Windows.Forms.Label plusRightLabel;
        private System.Windows.Forms.Label plusSign;
        private System.Windows.Forms.Label equalsAdd;
        private System.Windows.Forms.NumericUpDown sum;
        private System.Windows.Forms.Label minusLeftLabel;
        private System.Windows.Forms.Label timesLeftLabel;
        private System.Windows.Forms.Label dividedLeftLabel;
        private System.Windows.Forms.Label minusRightLabel;
        private System.Windows.Forms.Label timesRightLabel;
        private System.Windows.Forms.Label dividedRightLabel;
        private System.Windows.Forms.Label subtract;
        private System.Windows.Forms.Label multiply;
        private System.Windows.Forms.Label divide;
        private System.Windows.Forms.Label equalsSubtract;
        private System.Windows.Forms.Label equalsMultiply;
        private System.Windows.Forms.Label equalsDivide;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.NumericUpDown difference;
        private System.Windows.Forms.NumericUpDown product;
        private System.Windows.Forms.NumericUpDown quotient;
        private System.Windows.Forms.Label timeLabel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label currentDate;
    }
}

