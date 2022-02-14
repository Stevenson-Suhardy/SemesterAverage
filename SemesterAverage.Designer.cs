
namespace SemesterAverage
{
    partial class formSemesterAverage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelCourse1 = new System.Windows.Forms.Label();
            this.labelCourse2 = new System.Windows.Forms.Label();
            this.labelCourse3 = new System.Windows.Forms.Label();
            this.labelCourse4 = new System.Windows.Forms.Label();
            this.labelCourse5 = new System.Windows.Forms.Label();
            this.labelCourse6 = new System.Windows.Forms.Label();
            this.labelCourse7 = new System.Windows.Forms.Label();
            this.labelSemester = new System.Windows.Forms.Label();
            this.textBoxCourse1 = new System.Windows.Forms.TextBox();
            this.textBoxCourse7 = new System.Windows.Forms.TextBox();
            this.textBoxCourse6 = new System.Windows.Forms.TextBox();
            this.textBoxCourse5 = new System.Windows.Forms.TextBox();
            this.textBoxCourse4 = new System.Windows.Forms.TextBox();
            this.textBoxCourse3 = new System.Windows.Forms.TextBox();
            this.textBoxCourse2 = new System.Windows.Forms.TextBox();
            this.labelCourse1Output = new System.Windows.Forms.Label();
            this.labelSemesterOutput = new System.Windows.Forms.Label();
            this.labelCourse2Output = new System.Windows.Forms.Label();
            this.labelCourse3Output = new System.Windows.Forms.Label();
            this.labelCourse4Output = new System.Windows.Forms.Label();
            this.labelCourse5Output = new System.Windows.Forms.Label();
            this.labelSemesterLetterGrade = new System.Windows.Forms.Label();
            this.labelCourse7Output = new System.Windows.Forms.Label();
            this.labelCourse6Output = new System.Windows.Forms.Label();
            this.labelOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(12, 478);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(94, 29);
            this.buttonCalculate.TabIndex = 18;
            this.buttonCalculate.Text = "&Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.ButtonCalculate_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(129, 478);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(94, 29);
            this.buttonReset.TabIndex = 19;
            this.buttonReset.Text = "&Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.ButtonReset_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(248, 478);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(94, 29);
            this.buttonExit.TabIndex = 20;
            this.buttonExit.Text = "E&xit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // labelCourse1
            // 
            this.labelCourse1.AutoSize = true;
            this.labelCourse1.Location = new System.Drawing.Point(43, 9);
            this.labelCourse1.Name = "labelCourse1";
            this.labelCourse1.Size = new System.Drawing.Size(69, 20);
            this.labelCourse1.TabIndex = 1;
            this.labelCourse1.Text = "Course &1:";
            // 
            // labelCourse2
            // 
            this.labelCourse2.AutoSize = true;
            this.labelCourse2.Location = new System.Drawing.Point(43, 43);
            this.labelCourse2.Name = "labelCourse2";
            this.labelCourse2.Size = new System.Drawing.Size(69, 20);
            this.labelCourse2.TabIndex = 3;
            this.labelCourse2.Text = "Course &2:";
            // 
            // labelCourse3
            // 
            this.labelCourse3.AutoSize = true;
            this.labelCourse3.Location = new System.Drawing.Point(43, 78);
            this.labelCourse3.Name = "labelCourse3";
            this.labelCourse3.Size = new System.Drawing.Size(69, 20);
            this.labelCourse3.TabIndex = 5;
            this.labelCourse3.Text = "Course &3:";
            // 
            // labelCourse4
            // 
            this.labelCourse4.AutoSize = true;
            this.labelCourse4.Location = new System.Drawing.Point(43, 108);
            this.labelCourse4.Name = "labelCourse4";
            this.labelCourse4.Size = new System.Drawing.Size(69, 20);
            this.labelCourse4.TabIndex = 7;
            this.labelCourse4.Text = "Course &4:";
            // 
            // labelCourse5
            // 
            this.labelCourse5.AutoSize = true;
            this.labelCourse5.Location = new System.Drawing.Point(43, 141);
            this.labelCourse5.Name = "labelCourse5";
            this.labelCourse5.Size = new System.Drawing.Size(69, 20);
            this.labelCourse5.TabIndex = 9;
            this.labelCourse5.Text = "Course &5:";
            // 
            // labelCourse6
            // 
            this.labelCourse6.AutoSize = true;
            this.labelCourse6.Location = new System.Drawing.Point(43, 174);
            this.labelCourse6.Name = "labelCourse6";
            this.labelCourse6.Size = new System.Drawing.Size(69, 20);
            this.labelCourse6.TabIndex = 11;
            this.labelCourse6.Text = "Course &6:";
            // 
            // labelCourse7
            // 
            this.labelCourse7.AutoSize = true;
            this.labelCourse7.Location = new System.Drawing.Point(43, 208);
            this.labelCourse7.Name = "labelCourse7";
            this.labelCourse7.Size = new System.Drawing.Size(69, 20);
            this.labelCourse7.TabIndex = 13;
            this.labelCourse7.Text = "Course &7:";
            this.labelCourse7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSemester
            // 
            this.labelSemester.AutoSize = true;
            this.labelSemester.Location = new System.Drawing.Point(39, 240);
            this.labelSemester.Name = "labelSemester";
            this.labelSemester.Size = new System.Drawing.Size(73, 20);
            this.labelSemester.TabIndex = 15;
            this.labelSemester.Text = "&Semester:";
            // 
            // textBoxCourse1
            // 
            this.textBoxCourse1.Location = new System.Drawing.Point(118, 9);
            this.textBoxCourse1.Name = "textBoxCourse1";
            this.textBoxCourse1.Size = new System.Drawing.Size(105, 27);
            this.textBoxCourse1.TabIndex = 2;
            this.textBoxCourse1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxCourse1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            this.textBoxCourse1.Leave += new System.EventHandler(this.TextBoxCourse_Leave);
            // 
            // textBoxCourse7
            // 
            this.textBoxCourse7.Location = new System.Drawing.Point(118, 207);
            this.textBoxCourse7.Name = "textBoxCourse7";
            this.textBoxCourse7.Size = new System.Drawing.Size(105, 27);
            this.textBoxCourse7.TabIndex = 14;
            this.textBoxCourse7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxCourse7.Leave += new System.EventHandler(this.TextBoxCourse_Leave);
            // 
            // textBoxCourse6
            // 
            this.textBoxCourse6.Location = new System.Drawing.Point(118, 174);
            this.textBoxCourse6.Name = "textBoxCourse6";
            this.textBoxCourse6.Size = new System.Drawing.Size(105, 27);
            this.textBoxCourse6.TabIndex = 12;
            this.textBoxCourse6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxCourse6.Leave += new System.EventHandler(this.TextBoxCourse_Leave);
            // 
            // textBoxCourse5
            // 
            this.textBoxCourse5.Location = new System.Drawing.Point(118, 141);
            this.textBoxCourse5.Name = "textBoxCourse5";
            this.textBoxCourse5.Size = new System.Drawing.Size(105, 27);
            this.textBoxCourse5.TabIndex = 10;
            this.textBoxCourse5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxCourse5.Leave += new System.EventHandler(this.TextBoxCourse_Leave);
            // 
            // textBoxCourse4
            // 
            this.textBoxCourse4.Location = new System.Drawing.Point(118, 108);
            this.textBoxCourse4.Name = "textBoxCourse4";
            this.textBoxCourse4.Size = new System.Drawing.Size(105, 27);
            this.textBoxCourse4.TabIndex = 8;
            this.textBoxCourse4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxCourse4.Leave += new System.EventHandler(this.TextBoxCourse_Leave);
            // 
            // textBoxCourse3
            // 
            this.textBoxCourse3.Location = new System.Drawing.Point(118, 76);
            this.textBoxCourse3.Name = "textBoxCourse3";
            this.textBoxCourse3.Size = new System.Drawing.Size(105, 27);
            this.textBoxCourse3.TabIndex = 6;
            this.textBoxCourse3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxCourse3.Leave += new System.EventHandler(this.TextBoxCourse_Leave);
            // 
            // textBoxCourse2
            // 
            this.textBoxCourse2.Location = new System.Drawing.Point(118, 43);
            this.textBoxCourse2.Name = "textBoxCourse2";
            this.textBoxCourse2.Size = new System.Drawing.Size(105, 27);
            this.textBoxCourse2.TabIndex = 4;
            this.textBoxCourse2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxCourse2.Leave += new System.EventHandler(this.TextBoxCourse_Leave);
            // 
            // labelCourse1Output
            // 
            this.labelCourse1Output.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCourse1Output.Location = new System.Drawing.Point(229, 9);
            this.labelCourse1Output.Name = "labelCourse1Output";
            this.labelCourse1Output.Size = new System.Drawing.Size(105, 27);
            this.labelCourse1Output.TabIndex = 21;
            this.labelCourse1Output.Text = "\r\n";
            this.labelCourse1Output.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSemesterOutput
            // 
            this.labelSemesterOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelSemesterOutput.Location = new System.Drawing.Point(118, 240);
            this.labelSemesterOutput.Name = "labelSemesterOutput";
            this.labelSemesterOutput.Size = new System.Drawing.Size(105, 27);
            this.labelSemesterOutput.TabIndex = 16;
            this.labelSemesterOutput.Text = "\r\n";
            this.labelSemesterOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelCourse2Output
            // 
            this.labelCourse2Output.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCourse2Output.Location = new System.Drawing.Point(229, 43);
            this.labelCourse2Output.Name = "labelCourse2Output";
            this.labelCourse2Output.Size = new System.Drawing.Size(105, 27);
            this.labelCourse2Output.TabIndex = 22;
            this.labelCourse2Output.Text = "\r\n";
            this.labelCourse2Output.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCourse3Output
            // 
            this.labelCourse3Output.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCourse3Output.Location = new System.Drawing.Point(229, 78);
            this.labelCourse3Output.Name = "labelCourse3Output";
            this.labelCourse3Output.Size = new System.Drawing.Size(105, 27);
            this.labelCourse3Output.TabIndex = 23;
            this.labelCourse3Output.Text = "\r\n";
            this.labelCourse3Output.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCourse4Output
            // 
            this.labelCourse4Output.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCourse4Output.Location = new System.Drawing.Point(229, 108);
            this.labelCourse4Output.Name = "labelCourse4Output";
            this.labelCourse4Output.Size = new System.Drawing.Size(105, 27);
            this.labelCourse4Output.TabIndex = 24;
            this.labelCourse4Output.Text = "\r\n";
            this.labelCourse4Output.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCourse5Output
            // 
            this.labelCourse5Output.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCourse5Output.Location = new System.Drawing.Point(229, 141);
            this.labelCourse5Output.Name = "labelCourse5Output";
            this.labelCourse5Output.Size = new System.Drawing.Size(105, 27);
            this.labelCourse5Output.TabIndex = 25;
            this.labelCourse5Output.Text = "\r\n";
            this.labelCourse5Output.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSemesterLetterGrade
            // 
            this.labelSemesterLetterGrade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelSemesterLetterGrade.Location = new System.Drawing.Point(229, 240);
            this.labelSemesterLetterGrade.Name = "labelSemesterLetterGrade";
            this.labelSemesterLetterGrade.Size = new System.Drawing.Size(105, 27);
            this.labelSemesterLetterGrade.TabIndex = 28;
            this.labelSemesterLetterGrade.Text = "\r\n";
            this.labelSemesterLetterGrade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCourse7Output
            // 
            this.labelCourse7Output.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCourse7Output.Location = new System.Drawing.Point(229, 208);
            this.labelCourse7Output.Name = "labelCourse7Output";
            this.labelCourse7Output.Size = new System.Drawing.Size(105, 27);
            this.labelCourse7Output.TabIndex = 27;
            this.labelCourse7Output.Text = "\r\n";
            this.labelCourse7Output.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCourse6Output
            // 
            this.labelCourse6Output.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCourse6Output.Location = new System.Drawing.Point(229, 174);
            this.labelCourse6Output.Name = "labelCourse6Output";
            this.labelCourse6Output.Size = new System.Drawing.Size(105, 27);
            this.labelCourse6Output.TabIndex = 26;
            this.labelCourse6Output.Text = "\r\n";
            this.labelCourse6Output.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelOutput
            // 
            this.labelOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelOutput.Location = new System.Drawing.Point(39, 278);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(295, 187);
            this.labelOutput.TabIndex = 17;
            // 
            // formSemesterAverage
            // 
            this.AcceptButton = this.buttonCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonReset;
            this.ClientSize = new System.Drawing.Size(354, 519);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.labelCourse6Output);
            this.Controls.Add(this.labelCourse7Output);
            this.Controls.Add(this.labelSemesterLetterGrade);
            this.Controls.Add(this.labelCourse5Output);
            this.Controls.Add(this.labelCourse4Output);
            this.Controls.Add(this.labelCourse3Output);
            this.Controls.Add(this.labelCourse2Output);
            this.Controls.Add(this.labelSemesterOutput);
            this.Controls.Add(this.labelCourse1Output);
            this.Controls.Add(this.textBoxCourse2);
            this.Controls.Add(this.textBoxCourse3);
            this.Controls.Add(this.textBoxCourse4);
            this.Controls.Add(this.textBoxCourse5);
            this.Controls.Add(this.textBoxCourse6);
            this.Controls.Add(this.textBoxCourse7);
            this.Controls.Add(this.textBoxCourse1);
            this.Controls.Add(this.labelSemester);
            this.Controls.Add(this.labelCourse7);
            this.Controls.Add(this.labelCourse6);
            this.Controls.Add(this.labelCourse5);
            this.Controls.Add(this.labelCourse4);
            this.Controls.Add(this.labelCourse3);
            this.Controls.Add(this.labelCourse2);
            this.Controls.Add(this.labelCourse1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonCalculate);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formSemesterAverage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stevenson\'s Semester Average";
            this.Load += new System.EventHandler(this.FormSemesterAverage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelCourse1;
        private System.Windows.Forms.Label labelCourse2;
        private System.Windows.Forms.Label labelCourse3;
        private System.Windows.Forms.Label labelCourse4;
        private System.Windows.Forms.Label labelCourse5;
        private System.Windows.Forms.Label labelCourse6;
        private System.Windows.Forms.Label labelCourse7;
        private System.Windows.Forms.Label labelSemester;
        private System.Windows.Forms.TextBox textBoxCourse1;
        private System.Windows.Forms.TextBox textBoxCourse7;
        private System.Windows.Forms.TextBox textBoxCourse6;
        private System.Windows.Forms.TextBox textBoxCourse5;
        private System.Windows.Forms.TextBox textBoxCourse4;
        private System.Windows.Forms.TextBox textBoxCourse3;
        private System.Windows.Forms.TextBox textBoxCourse2;
        private System.Windows.Forms.Label labelCourse1Output;
        private System.Windows.Forms.Label labelSemesterOutput;
        private System.Windows.Forms.Label labelCourse2Output;
        private System.Windows.Forms.Label labelCourse3Output;
        private System.Windows.Forms.Label labelCourse4Output;
        private System.Windows.Forms.Label labelCourse5Output;
        private System.Windows.Forms.Label labelSemesterLetterGrade;
        private System.Windows.Forms.Label labelCourse7Output;
        private System.Windows.Forms.Label labelCourse6Output;
        private System.Windows.Forms.Label labelOutput;
    }
}

