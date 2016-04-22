/*
 * Created by SharpDevelop.
 * User: 073620775
 * Date: 4/22/2016
 * Time: 9:54 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Math_Project
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lab_Title;
		private System.Windows.Forms.Label lab_FractionLine1;
		private System.Windows.Forms.Label lab_FractionLine2;
		private System.Windows.Forms.TextBox inbx_FractionA;
		private System.Windows.Forms.TextBox inbx_FractionC;
		private System.Windows.Forms.TextBox inbx_FractionD;
		private System.Windows.Forms.TextBox inbx_FractionB;
		private System.Windows.Forms.Label lab_Sign;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label lab_Equals;
		private System.Windows.Forms.Label lab_ResultBot;
		private System.Windows.Forms.Label lab_ResultTop;
		private System.Windows.Forms.Label lab_ResultLine;
		private System.Windows.Forms.Button button2;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.lab_Title = new System.Windows.Forms.Label();
			this.lab_FractionLine1 = new System.Windows.Forms.Label();
			this.lab_FractionLine2 = new System.Windows.Forms.Label();
			this.inbx_FractionA = new System.Windows.Forms.TextBox();
			this.inbx_FractionC = new System.Windows.Forms.TextBox();
			this.inbx_FractionD = new System.Windows.Forms.TextBox();
			this.inbx_FractionB = new System.Windows.Forms.TextBox();
			this.lab_Sign = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.lab_Equals = new System.Windows.Forms.Label();
			this.lab_ResultBot = new System.Windows.Forms.Label();
			this.lab_ResultTop = new System.Windows.Forms.Label();
			this.lab_ResultLine = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lab_Title
			// 
			this.lab_Title.AllowDrop = true;
			this.lab_Title.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lab_Title.Location = new System.Drawing.Point(433, 9);
			this.lab_Title.Name = "lab_Title";
			this.lab_Title.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lab_Title.Size = new System.Drawing.Size(533, 53);
			this.lab_Title.TabIndex = 0;
			this.lab_Title.Text = "Fraction Calculator";
			// 
			// lab_FractionLine1
			// 
			this.lab_FractionLine1.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lab_FractionLine1.Location = new System.Drawing.Point(61, 154);
			this.lab_FractionLine1.Name = "lab_FractionLine1";
			this.lab_FractionLine1.Size = new System.Drawing.Size(125, 66);
			this.lab_FractionLine1.TabIndex = 1;
			this.lab_FractionLine1.Text = "___";
			// 
			// lab_FractionLine2
			// 
			this.lab_FractionLine2.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lab_FractionLine2.Location = new System.Drawing.Point(263, 154);
			this.lab_FractionLine2.Name = "lab_FractionLine2";
			this.lab_FractionLine2.Size = new System.Drawing.Size(125, 66);
			this.lab_FractionLine2.TabIndex = 2;
			this.lab_FractionLine2.Text = "___";
			// 
			// inbx_FractionA
			// 
			this.inbx_FractionA.Location = new System.Drawing.Point(72, 165);
			this.inbx_FractionA.Name = "inbx_FractionA";
			this.inbx_FractionA.Size = new System.Drawing.Size(92, 20);
			this.inbx_FractionA.TabIndex = 3;
			this.inbx_FractionA.TextChanged += new System.EventHandler(this.TextBox1TextChanged);
			// 
			// inbx_FractionC
			// 
			this.inbx_FractionC.Location = new System.Drawing.Point(72, 234);
			this.inbx_FractionC.Name = "inbx_FractionC";
			this.inbx_FractionC.Size = new System.Drawing.Size(92, 20);
			this.inbx_FractionC.TabIndex = 4;
			// 
			// inbx_FractionD
			// 
			this.inbx_FractionD.Location = new System.Drawing.Point(274, 234);
			this.inbx_FractionD.Name = "inbx_FractionD";
			this.inbx_FractionD.Size = new System.Drawing.Size(92, 20);
			this.inbx_FractionD.TabIndex = 5;
			// 
			// inbx_FractionB
			// 
			this.inbx_FractionB.Location = new System.Drawing.Point(274, 165);
			this.inbx_FractionB.Name = "inbx_FractionB";
			this.inbx_FractionB.Size = new System.Drawing.Size(92, 20);
			this.inbx_FractionB.TabIndex = 6;
			// 
			// lab_Sign
			// 
			this.lab_Sign.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lab_Sign.Location = new System.Drawing.Point(192, 174);
			this.lab_Sign.Name = "lab_Sign";
			this.lab_Sign.Size = new System.Drawing.Size(47, 66);
			this.lab_Sign.TabIndex = 7;
			this.lab_Sign.Text = "x";
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.Blue;
			this.button1.Location = new System.Drawing.Point(158, 277);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(124, 32);
			this.button1.TabIndex = 8;
			this.button1.Text = "Change Sign";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// lab_Equals
			// 
			this.lab_Equals.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lab_Equals.Location = new System.Drawing.Point(381, 174);
			this.lab_Equals.Name = "lab_Equals";
			this.lab_Equals.Size = new System.Drawing.Size(64, 66);
			this.lab_Equals.TabIndex = 9;
			this.lab_Equals.Text = "=";
			this.lab_Equals.Click += new System.EventHandler(this.Lab_EqualsClick);
			// 
			// lab_ResultBot
			// 
			this.lab_ResultBot.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lab_ResultBot.Location = new System.Drawing.Point(451, 234);
			this.lab_ResultBot.Name = "lab_ResultBot";
			this.lab_ResultBot.Size = new System.Drawing.Size(92, 33);
			this.lab_ResultBot.TabIndex = 12;
			this.lab_ResultBot.Text = "Result";
			// 
			// lab_ResultTop
			// 
			this.lab_ResultTop.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lab_ResultTop.Location = new System.Drawing.Point(451, 154);
			this.lab_ResultTop.Name = "lab_ResultTop";
			this.lab_ResultTop.Size = new System.Drawing.Size(92, 33);
			this.lab_ResultTop.TabIndex = 13;
			this.lab_ResultTop.Text = "Result";
			// 
			// lab_ResultLine
			// 
			this.lab_ResultLine.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lab_ResultLine.Location = new System.Drawing.Point(433, 154);
			this.lab_ResultLine.Name = "lab_ResultLine";
			this.lab_ResultLine.Size = new System.Drawing.Size(125, 66);
			this.lab_ResultLine.TabIndex = 14;
			this.lab_ResultLine.Text = "___";
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.Blue;
			this.button2.Location = new System.Drawing.Point(360, 277);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(124, 32);
			this.button2.TabIndex = 15;
			this.button2.Text = "Change Sign";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.RoyalBlue;
			this.ClientSize = new System.Drawing.Size(978, 544);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.lab_ResultTop);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.lab_Sign);
			this.Controls.Add(this.inbx_FractionB);
			this.Controls.Add(this.inbx_FractionD);
			this.Controls.Add(this.inbx_FractionC);
			this.Controls.Add(this.inbx_FractionA);
			this.Controls.Add(this.lab_FractionLine2);
			this.Controls.Add(this.lab_FractionLine1);
			this.Controls.Add(this.lab_Title);
			this.Controls.Add(this.lab_ResultBot);
			this.Controls.Add(this.lab_Equals);
			this.Controls.Add(this.lab_ResultLine);
			this.Name = "MainForm";
			this.Text = "Math Project";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
