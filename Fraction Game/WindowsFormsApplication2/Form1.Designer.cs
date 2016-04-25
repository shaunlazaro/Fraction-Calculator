namespace WindowsFormsApplication2
{
    partial class Calculator
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
            this.lab_title = new System.Windows.Forms.Label();
            this.lab_Operation = new System.Windows.Forms.Label();
            this.lab_FractionLineA = new System.Windows.Forms.Label();
            this.lab_FractionLineB = new System.Windows.Forms.Label();
            this.lab_Equals = new System.Windows.Forms.Label();
            this.lab_FractionLineResult = new System.Windows.Forms.Label();
            this.inbx_FractionA = new System.Windows.Forms.TextBox();
            this.inbx_FractionB = new System.Windows.Forms.TextBox();
            this.inbx_FractionC = new System.Windows.Forms.TextBox();
            this.inbx_FractionD = new System.Windows.Forms.TextBox();
            this.lab_ResultBot = new System.Windows.Forms.Label();
            this.lab_ResultTop = new System.Windows.Forms.Label();
            this.btn_ChangeFraction = new System.Windows.Forms.Button();
            this.btn_Calculate = new System.Windows.Forms.Button();
            this.lab_Instruction1 = new System.Windows.Forms.Label();
            this.lab_Instruction2 = new System.Windows.Forms.Label();
            this.lab_Simplify = new System.Windows.Forms.Label();
            this.lab_Negative = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lab_title
            // 
            this.lab_title.AutoSize = true;
            this.lab_title.Font = new System.Drawing.Font("AR JULIAN", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_title.ForeColor = System.Drawing.Color.White;
            this.lab_title.Location = new System.Drawing.Point(12, 9);
            this.lab_title.Name = "lab_title";
            this.lab_title.Size = new System.Drawing.Size(386, 43);
            this.lab_title.TabIndex = 0;
            this.lab_title.Text = "Fraction Calculator";
            // 
            // lab_Operation
            // 
            this.lab_Operation.AutoSize = true;
            this.lab_Operation.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Operation.Location = new System.Drawing.Point(140, 133);
            this.lab_Operation.Name = "lab_Operation";
            this.lab_Operation.Size = new System.Drawing.Size(47, 42);
            this.lab_Operation.TabIndex = 1;
            this.lab_Operation.Text = "+";
            // 
            // lab_FractionLineA
            // 
            this.lab_FractionLineA.AutoSize = true;
            this.lab_FractionLineA.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_FractionLineA.Location = new System.Drawing.Point(40, 120);
            this.lab_FractionLineA.Name = "lab_FractionLineA";
            this.lab_FractionLineA.Size = new System.Drawing.Size(106, 42);
            this.lab_FractionLineA.TabIndex = 2;
            this.lab_FractionLineA.Text = "____";
            // 
            // lab_FractionLineB
            // 
            this.lab_FractionLineB.AutoSize = true;
            this.lab_FractionLineB.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_FractionLineB.Location = new System.Drawing.Point(188, 120);
            this.lab_FractionLineB.Name = "lab_FractionLineB";
            this.lab_FractionLineB.Size = new System.Drawing.Size(106, 42);
            this.lab_FractionLineB.TabIndex = 3;
            this.lab_FractionLineB.Text = "____";
            // 
            // lab_Equals
            // 
            this.lab_Equals.AutoSize = true;
            this.lab_Equals.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Equals.Location = new System.Drawing.Point(294, 133);
            this.lab_Equals.Name = "lab_Equals";
            this.lab_Equals.Size = new System.Drawing.Size(47, 42);
            this.lab_Equals.TabIndex = 4;
            this.lab_Equals.Text = "=";
            // 
            // lab_FractionLineResult
            // 
            this.lab_FractionLineResult.AutoSize = true;
            this.lab_FractionLineResult.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_FractionLineResult.Location = new System.Drawing.Point(366, 120);
            this.lab_FractionLineResult.Name = "lab_FractionLineResult";
            this.lab_FractionLineResult.Size = new System.Drawing.Size(106, 42);
            this.lab_FractionLineResult.TabIndex = 5;
            this.lab_FractionLineResult.Text = "____";
            // 
            // inbx_FractionA
            // 
            this.inbx_FractionA.Location = new System.Drawing.Point(47, 120);
            this.inbx_FractionA.Name = "inbx_FractionA";
            this.inbx_FractionA.Size = new System.Drawing.Size(90, 20);
            this.inbx_FractionA.TabIndex = 6;
            // 
            // inbx_FractionB
            // 
            this.inbx_FractionB.Location = new System.Drawing.Point(193, 120);
            this.inbx_FractionB.Name = "inbx_FractionB";
            this.inbx_FractionB.Size = new System.Drawing.Size(90, 20);
            this.inbx_FractionB.TabIndex = 7;
            // 
            // inbx_FractionC
            // 
            this.inbx_FractionC.Location = new System.Drawing.Point(47, 178);
            this.inbx_FractionC.Name = "inbx_FractionC";
            this.inbx_FractionC.Size = new System.Drawing.Size(90, 20);
            this.inbx_FractionC.TabIndex = 8;
            // 
            // inbx_FractionD
            // 
            this.inbx_FractionD.Location = new System.Drawing.Point(193, 178);
            this.inbx_FractionD.Name = "inbx_FractionD";
            this.inbx_FractionD.Size = new System.Drawing.Size(90, 20);
            this.inbx_FractionD.TabIndex = 9;
            // 
            // lab_ResultBot
            // 
            this.lab_ResultBot.AutoSize = true;
            this.lab_ResultBot.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_ResultBot.Location = new System.Drawing.Point(404, 178);
            this.lab_ResultBot.Name = "lab_ResultBot";
            this.lab_ResultBot.Size = new System.Drawing.Size(20, 18);
            this.lab_ResultBot.TabIndex = 11;
            this.lab_ResultBot.Text = "D";
            // 
            // lab_ResultTop
            // 
            this.lab_ResultTop.AutoSize = true;
            this.lab_ResultTop.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_ResultTop.Location = new System.Drawing.Point(404, 122);
            this.lab_ResultTop.Name = "lab_ResultTop";
            this.lab_ResultTop.Size = new System.Drawing.Size(20, 18);
            this.lab_ResultTop.TabIndex = 12;
            this.lab_ResultTop.Text = "N";
            // 
            // btn_ChangeFraction
            // 
            this.btn_ChangeFraction.Location = new System.Drawing.Point(125, 223);
            this.btn_ChangeFraction.Name = "btn_ChangeFraction";
            this.btn_ChangeFraction.Size = new System.Drawing.Size(75, 23);
            this.btn_ChangeFraction.TabIndex = 13;
            this.btn_ChangeFraction.Text = "Change";
            this.btn_ChangeFraction.UseVisualStyleBackColor = true;
            this.btn_ChangeFraction.Click += new System.EventHandler(this.btn_ChangeFraction_Click);
            // 
            // btn_Calculate
            // 
            this.btn_Calculate.Location = new System.Drawing.Point(283, 223);
            this.btn_Calculate.Name = "btn_Calculate";
            this.btn_Calculate.Size = new System.Drawing.Size(75, 23);
            this.btn_Calculate.TabIndex = 14;
            this.btn_Calculate.Text = "Solve";
            this.btn_Calculate.UseVisualStyleBackColor = true;
            this.btn_Calculate.Click += new System.EventHandler(this.btn_Calculate_Click);
            // 
            // lab_Instruction1
            // 
            this.lab_Instruction1.AutoSize = true;
            this.lab_Instruction1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Instruction1.Location = new System.Drawing.Point(12, 262);
            this.lab_Instruction1.Name = "lab_Instruction1";
            this.lab_Instruction1.Size = new System.Drawing.Size(432, 18);
            this.lab_Instruction1.TabIndex = 15;
            this.lab_Instruction1.Text = "Step 1: Find the Least Common Denominator(LCD).";
            // 
            // lab_Instruction2
            // 
            this.lab_Instruction2.AutoSize = true;
            this.lab_Instruction2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Instruction2.Location = new System.Drawing.Point(12, 293);
            this.lab_Instruction2.Name = "lab_Instruction2";
            this.lab_Instruction2.Size = new System.Drawing.Size(329, 18);
            this.lab_Instruction2.TabIndex = 16;
            this.lab_Instruction2.Text = "Step 2: Add, ignoring the denominator.";
            // 
            // lab_Simplify
            // 
            this.lab_Simplify.AutoSize = true;
            this.lab_Simplify.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Simplify.Location = new System.Drawing.Point(9, 326);
            this.lab_Simplify.Name = "lab_Simplify";
            this.lab_Simplify.Size = new System.Drawing.Size(242, 32);
            this.lab_Simplify.TabIndex = 17;
            this.lab_Simplify.Text = "Then, Simplify!";
            // 
            // lab_Negative
            // 
            this.lab_Negative.AutoSize = true;
            this.lab_Negative.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Negative.Location = new System.Drawing.Point(347, 133);
            this.lab_Negative.Name = "lab_Negative";
            this.lab_Negative.Size = new System.Drawing.Size(34, 42);
            this.lab_Negative.TabIndex = 18;
            this.lab_Negative.Text = "-";
            this.lab_Negative.Visible = false;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(484, 371);
            this.Controls.Add(this.lab_Negative);
            this.Controls.Add(this.lab_Simplify);
            this.Controls.Add(this.lab_Instruction2);
            this.Controls.Add(this.lab_Instruction1);
            this.Controls.Add(this.btn_Calculate);
            this.Controls.Add(this.btn_ChangeFraction);
            this.Controls.Add(this.lab_ResultTop);
            this.Controls.Add(this.inbx_FractionD);
            this.Controls.Add(this.inbx_FractionC);
            this.Controls.Add(this.inbx_FractionB);
            this.Controls.Add(this.inbx_FractionA);
            this.Controls.Add(this.lab_FractionLineResult);
            this.Controls.Add(this.lab_Equals);
            this.Controls.Add(this.lab_FractionLineB);
            this.Controls.Add(this.lab_FractionLineA);
            this.Controls.Add(this.lab_Operation);
            this.Controls.Add(this.lab_title);
            this.Controls.Add(this.lab_ResultBot);
            this.Name = "Calculator";
            this.Text = "Calculate Fractions";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Calculator_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_title;
        private System.Windows.Forms.Label lab_Operation;
        private System.Windows.Forms.Label lab_FractionLineA;
        private System.Windows.Forms.Label lab_FractionLineB;
        private System.Windows.Forms.Label lab_Equals;
        private System.Windows.Forms.Label lab_FractionLineResult;
        private System.Windows.Forms.TextBox inbx_FractionA;
        private System.Windows.Forms.TextBox inbx_FractionB;
        private System.Windows.Forms.TextBox inbx_FractionC;
        private System.Windows.Forms.TextBox inbx_FractionD;
        private System.Windows.Forms.Label lab_ResultBot;
        private System.Windows.Forms.Label lab_ResultTop;
        private System.Windows.Forms.Button btn_ChangeFraction;
        private System.Windows.Forms.Button btn_Calculate;
        private System.Windows.Forms.Label lab_Instruction1;
        private System.Windows.Forms.Label lab_Instruction2;
        private System.Windows.Forms.Label lab_Simplify;
        private System.Windows.Forms.Label lab_Negative;
    }
}

