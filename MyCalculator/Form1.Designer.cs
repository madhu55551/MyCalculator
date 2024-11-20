namespace MyCalculator
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
            this.Num1Label = new System.Windows.Forms.Label();
            this.Num2Label = new System.Windows.Forms.Label();
            this.SecondNumTextBox = new System.Windows.Forms.TextBox();
            this.OperationLabel = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Addition = new System.Windows.Forms.Button();
            this.Subtraction = new System.Windows.Forms.Button();
            this.Multiplication = new System.Windows.Forms.Button();
            this.Division = new System.Windows.Forms.Button();
            this.Modulo = new System.Windows.Forms.Button();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.FirstNumTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Num1Label
            // 
            this.Num1Label.AutoSize = true;
            this.Num1Label.Location = new System.Drawing.Point(61, 55);
            this.Num1Label.Name = "Num1Label";
            this.Num1Label.Size = new System.Drawing.Size(42, 16);
            this.Num1Label.TabIndex = 0;
            this.Num1Label.Text = "Num1";
            // 
            // Num2Label
            // 
            this.Num2Label.AutoSize = true;
            this.Num2Label.Location = new System.Drawing.Point(63, 105);
            this.Num2Label.Name = "Num2Label";
            this.Num2Label.Size = new System.Drawing.Size(42, 16);
            this.Num2Label.TabIndex = 1;
            this.Num2Label.Text = "Num2";
            // 
            // SecondNumTextBox
            // 
            this.SecondNumTextBox.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.SecondNumTextBox.Location = new System.Drawing.Point(124, 98);
            this.SecondNumTextBox.Name = "SecondNumTextBox";
            this.SecondNumTextBox.Size = new System.Drawing.Size(100, 22);
            this.SecondNumTextBox.TabIndex = 3;
            // 
            // OperationLabel
            // 
            this.OperationLabel.AutoSize = true;
            this.OperationLabel.Location = new System.Drawing.Point(35, 140);
            this.OperationLabel.Name = "OperationLabel";
            this.OperationLabel.Size = new System.Drawing.Size(73, 16);
            this.OperationLabel.TabIndex = 4;
            this.OperationLabel.Text = "Operations";
            // 
            // Addition
            // 
            this.Addition.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Addition.Location = new System.Drawing.Point(124, 133);
            this.Addition.Name = "Addition";
            this.Addition.Size = new System.Drawing.Size(25, 23);
            this.Addition.TabIndex = 5;
            this.Addition.Text = "+";
            this.Addition.UseVisualStyleBackColor = true;
            this.Addition.Click += new System.EventHandler(this.Addition_Click);
            // 
            // Subtraction
            // 
            this.Subtraction.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Subtraction.Location = new System.Drawing.Point(149, 133);
            this.Subtraction.Name = "Subtraction";
            this.Subtraction.Size = new System.Drawing.Size(23, 23);
            this.Subtraction.TabIndex = 6;
            this.Subtraction.Text = "-";
            this.Subtraction.UseVisualStyleBackColor = true;
            this.Subtraction.Click += new System.EventHandler(this.Subtraction_Click);
            // 
            // Multiplication
            // 
            this.Multiplication.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Multiplication.Location = new System.Drawing.Point(172, 133);
            this.Multiplication.Name = "Multiplication";
            this.Multiplication.Size = new System.Drawing.Size(25, 23);
            this.Multiplication.TabIndex = 9;
            this.Multiplication.Text = "*";
            this.Multiplication.UseVisualStyleBackColor = true;
            this.Multiplication.Click += new System.EventHandler(this.Multiplication_Click);
            // 
            // Division
            // 
            this.Division.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Division.Location = new System.Drawing.Point(198, 133);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(25, 23);
            this.Division.TabIndex = 10;
            this.Division.Text = "/";
            this.Division.UseVisualStyleBackColor = true;
            this.Division.Click += new System.EventHandler(this.Division_Click);
            // 
            // Modulo
            // 
            this.Modulo.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Modulo.Location = new System.Drawing.Point(224, 133);
            this.Modulo.Name = "Modulo";
            this.Modulo.Size = new System.Drawing.Size(25, 23);
            this.Modulo.TabIndex = 11;
            this.Modulo.Text = "%";
            this.Modulo.UseVisualStyleBackColor = true;
            this.Modulo.Click += new System.EventHandler(this.Modulo_Click);
            // 
            // OutputLabel
            // 
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.Location = new System.Drawing.Point(58, 194);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(45, 16);
            this.OutputLabel.TabIndex = 12;
            this.OutputLabel.Text = "Output";
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.ResultTextBox.Location = new System.Drawing.Point(126, 188);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.Size = new System.Drawing.Size(100, 22);
            this.ResultTextBox.TabIndex = 13;
            // 
            // FirstNumTextbox
            // 
            this.FirstNumTextbox.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.FirstNumTextbox.Location = new System.Drawing.Point(122, 50);
            this.FirstNumTextbox.Name = "FirstNumTextbox";
            this.FirstNumTextbox.Size = new System.Drawing.Size(100, 22);
            this.FirstNumTextbox.TabIndex = 2;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(329, 258);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.Modulo);
            this.Controls.Add(this.Division);
            this.Controls.Add(this.Multiplication);
            this.Controls.Add(this.Subtraction);
            this.Controls.Add(this.Addition);
            this.Controls.Add(this.OperationLabel);
            this.Controls.Add(this.SecondNumTextBox);
            this.Controls.Add(this.FirstNumTextbox);
            this.Controls.Add(this.Num2Label);
            this.Controls.Add(this.Num1Label);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Operations;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Num1Label;
        private System.Windows.Forms.Label Num2Label;
        private System.Windows.Forms.TextBox SecondNumTextBox;
        private System.Windows.Forms.Label OperationLabel;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button Addition;
        private System.Windows.Forms.Button Subtraction;
        private System.Windows.Forms.Button Multiplication;
        private System.Windows.Forms.Button Division;
        private System.Windows.Forms.Button Modulo;
        private System.Windows.Forms.Label OutputLabel;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.TextBox FirstNumTextbox;
    }
}

