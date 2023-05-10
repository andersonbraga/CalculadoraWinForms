namespace Calculadora.WinFormsApp
{
    partial class Form1
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
            txtResultado = new TextBox();
            labelOperacao = new Label();
            button45 = new Button();
            button59 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            buttonAddition = new Button();
            buttonClearEntry = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            buttonSubtraction = new Button();
            buttonClear = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            buttonMultiplication = new Button();
            button0 = new Button();
            buttonDecimal = new Button();
            buttonDivision = new Button();
            buttonEquals = new Button();
            textBoxOutput = new TextBox();
            SuspendLayout();
            // 
            // txtResultado
            // 
            txtResultado.Anchor = AnchorStyles.Right;
            txtResultado.BackColor = SystemColors.ControlDarkDark;
            txtResultado.BorderStyle = BorderStyle.None;
            txtResultado.Location = new Point(-2, -3);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(259, 138);
            txtResultado.TabIndex = 0;
            txtResultado.TextAlign = HorizontalAlignment.Right;
            // 
            // labelOperacao
            // 
            labelOperacao.Anchor = AnchorStyles.Right;
            labelOperacao.AutoSize = true;
            labelOperacao.BackColor = Color.Ivory;
            labelOperacao.ForeColor = Color.White;
            labelOperacao.Location = new Point(241, 94);
            labelOperacao.Name = "labelOperacao";
            labelOperacao.Size = new Size(0, 15);
            labelOperacao.TabIndex = 1;
            labelOperacao.TextAlign = ContentAlignment.BottomRight;
            // 
            // button45
            // 
            button45.BackColor = Color.DimGray;
            button45.BackgroundImageLayout = ImageLayout.Center;
            button45.FlatAppearance.BorderSize = 0;
            button45.FlatAppearance.MouseDownBackColor = Color.Black;
            button45.FlatStyle = FlatStyle.Popup;
            button45.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button45.ForeColor = Color.White;
            button45.Location = new Point(186, 163);
            button45.Name = "button45";
            button45.Size = new Size(51, 51);
            button45.TabIndex = 5;
            button45.Text = "<x|";
            button45.UseVisualStyleBackColor = false;
            // 
            // button59
            // 
            button59.BackColor = Color.DimGray;
            button59.BackgroundImageLayout = ImageLayout.Center;
            button59.FlatAppearance.BorderSize = 0;
            button59.FlatAppearance.MouseDownBackColor = Color.Black;
            button59.FlatStyle = FlatStyle.Popup;
            button59.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button59.ForeColor = Color.White;
            button59.Location = new Point(12, 163);
            button59.Name = "button59";
            button59.Size = new Size(51, 51);
            button59.TabIndex = 6;
            button59.Text = "%";
            button59.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = Color.DimGray;
            button7.BackgroundImageLayout = ImageLayout.Center;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatAppearance.MouseDownBackColor = Color.Black;
            button7.FlatStyle = FlatStyle.Popup;
            button7.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button7.ForeColor = Color.White;
            button7.Location = new Point(12, 219);
            button7.Name = "button7";
            button7.Size = new Size(51, 51);
            button7.TabIndex = 2;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.DimGray;
            button8.BackgroundImageLayout = ImageLayout.Center;
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatAppearance.MouseDownBackColor = Color.Black;
            button8.FlatStyle = FlatStyle.Popup;
            button8.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button8.ForeColor = Color.White;
            button8.Location = new Point(69, 219);
            button8.Name = "button8";
            button8.Size = new Size(51, 51);
            button8.TabIndex = 3;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.DimGray;
            button9.BackgroundImageLayout = ImageLayout.Center;
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatAppearance.MouseDownBackColor = Color.Black;
            button9.FlatStyle = FlatStyle.Popup;
            button9.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button9.ForeColor = Color.White;
            button9.Location = new Point(126, 220);
            button9.Name = "button9";
            button9.Size = new Size(51, 51);
            button9.TabIndex = 4;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button_Click;
            // 
            // buttonAddition
            // 
            buttonAddition.BackColor = Color.DimGray;
            buttonAddition.BackgroundImageLayout = ImageLayout.Center;
            buttonAddition.FlatAppearance.BorderSize = 0;
            buttonAddition.FlatAppearance.MouseDownBackColor = Color.Black;
            buttonAddition.FlatStyle = FlatStyle.Popup;
            buttonAddition.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAddition.ForeColor = Color.White;
            buttonAddition.Location = new Point(186, 333);
            buttonAddition.Name = "buttonAddition";
            buttonAddition.Size = new Size(51, 51);
            buttonAddition.TabIndex = 5;
            buttonAddition.Text = "+";
            buttonAddition.UseVisualStyleBackColor = false;
            buttonAddition.Click += button_Click;
            // 
            // buttonClearEntry
            // 
            buttonClearEntry.BackColor = Color.DimGray;
            buttonClearEntry.BackgroundImageLayout = ImageLayout.Center;
            buttonClearEntry.FlatAppearance.BorderSize = 0;
            buttonClearEntry.FlatAppearance.MouseDownBackColor = Color.Black;
            buttonClearEntry.FlatStyle = FlatStyle.Popup;
            buttonClearEntry.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonClearEntry.ForeColor = Color.White;
            buttonClearEntry.Location = new Point(69, 163);
            buttonClearEntry.Name = "buttonClearEntry";
            buttonClearEntry.Size = new Size(51, 51);
            buttonClearEntry.TabIndex = 6;
            buttonClearEntry.Text = "CE";
            buttonClearEntry.UseVisualStyleBackColor = false;
            buttonClearEntry.Click += button_ClearEntry_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.DimGray;
            button4.BackgroundImageLayout = ImageLayout.Center;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseDownBackColor = Color.Black;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(12, 276);
            button4.Name = "button4";
            button4.Size = new Size(51, 51);
            button4.TabIndex = 7;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.DimGray;
            button5.BackgroundImageLayout = ImageLayout.Center;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.MouseDownBackColor = Color.Black;
            button5.FlatStyle = FlatStyle.Popup;
            button5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.Location = new Point(69, 276);
            button5.Name = "button5";
            button5.Size = new Size(51, 51);
            button5.TabIndex = 8;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.DimGray;
            button6.BackgroundImageLayout = ImageLayout.Center;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatAppearance.MouseDownBackColor = Color.Black;
            button6.FlatStyle = FlatStyle.Popup;
            button6.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = Color.White;
            button6.Location = new Point(126, 276);
            button6.Name = "button6";
            button6.Size = new Size(51, 51);
            button6.TabIndex = 9;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button_Click;
            // 
            // buttonSubtraction
            // 
            buttonSubtraction.BackColor = Color.DimGray;
            buttonSubtraction.BackgroundImageLayout = ImageLayout.Center;
            buttonSubtraction.FlatAppearance.BorderSize = 0;
            buttonSubtraction.FlatAppearance.MouseDownBackColor = Color.Black;
            buttonSubtraction.FlatStyle = FlatStyle.Popup;
            buttonSubtraction.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSubtraction.ForeColor = Color.White;
            buttonSubtraction.Location = new Point(186, 276);
            buttonSubtraction.Name = "buttonSubtraction";
            buttonSubtraction.Size = new Size(51, 51);
            buttonSubtraction.TabIndex = 10;
            buttonSubtraction.Text = "-";
            buttonSubtraction.UseVisualStyleBackColor = false;
            buttonSubtraction.Click += button_Click;
            // 
            // buttonClear
            // 
            buttonClear.BackColor = Color.DimGray;
            buttonClear.BackgroundImageLayout = ImageLayout.Center;
            buttonClear.FlatAppearance.BorderSize = 0;
            buttonClear.FlatAppearance.MouseDownBackColor = Color.Black;
            buttonClear.FlatStyle = FlatStyle.Popup;
            buttonClear.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonClear.ForeColor = Color.White;
            buttonClear.Location = new Point(126, 163);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(51, 51);
            buttonClear.TabIndex = 11;
            buttonClear.Text = "C";
            buttonClear.UseVisualStyleBackColor = false;
            buttonClear.Click += button_Clear_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DimGray;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Black;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(12, 333);
            button1.Name = "button1";
            button1.Size = new Size(51, 51);
            button1.TabIndex = 12;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DimGray;
            button2.BackgroundImageLayout = ImageLayout.Center;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.Black;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(69, 333);
            button2.Name = "button2";
            button2.Size = new Size(51, 51);
            button2.TabIndex = 13;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DimGray;
            button3.BackgroundImageLayout = ImageLayout.Center;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.Black;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(126, 333);
            button3.Name = "button3";
            button3.Size = new Size(51, 51);
            button3.TabIndex = 14;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button_Click;
            // 
            // buttonMultiplication
            // 
            buttonMultiplication.BackColor = Color.DimGray;
            buttonMultiplication.BackgroundImageLayout = ImageLayout.Center;
            buttonMultiplication.FlatAppearance.BorderSize = 0;
            buttonMultiplication.FlatAppearance.MouseDownBackColor = Color.Black;
            buttonMultiplication.FlatStyle = FlatStyle.Popup;
            buttonMultiplication.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonMultiplication.ForeColor = Color.White;
            buttonMultiplication.Location = new Point(186, 219);
            buttonMultiplication.Name = "buttonMultiplication";
            buttonMultiplication.Size = new Size(51, 51);
            buttonMultiplication.TabIndex = 15;
            buttonMultiplication.Text = "X";
            buttonMultiplication.UseVisualStyleBackColor = false;
            buttonMultiplication.Click += button_Click;
            // 
            // button0
            // 
            button0.BackColor = Color.DimGray;
            button0.BackgroundImageLayout = ImageLayout.Center;
            button0.FlatAppearance.BorderSize = 0;
            button0.FlatAppearance.MouseDownBackColor = Color.Black;
            button0.FlatStyle = FlatStyle.Popup;
            button0.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button0.ForeColor = Color.White;
            button0.Location = new Point(69, 390);
            button0.Name = "button0";
            button0.Size = new Size(51, 51);
            button0.TabIndex = 18;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = false;
            button0.Click += button_Click;
            // 
            // buttonDecimal
            // 
            buttonDecimal.BackColor = Color.DimGray;
            buttonDecimal.BackgroundImageLayout = ImageLayout.Center;
            buttonDecimal.FlatAppearance.BorderSize = 0;
            buttonDecimal.FlatAppearance.MouseDownBackColor = Color.Black;
            buttonDecimal.FlatStyle = FlatStyle.Popup;
            buttonDecimal.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDecimal.ForeColor = Color.White;
            buttonDecimal.Location = new Point(126, 390);
            buttonDecimal.Name = "buttonDecimal";
            buttonDecimal.Size = new Size(51, 51);
            buttonDecimal.TabIndex = 19;
            buttonDecimal.Text = ",";
            buttonDecimal.UseVisualStyleBackColor = false;
            buttonDecimal.Click += button_Click;
            // 
            // buttonDivision
            // 
            buttonDivision.BackColor = Color.DimGray;
            buttonDivision.BackgroundImageLayout = ImageLayout.Center;
            buttonDivision.FlatAppearance.BorderSize = 0;
            buttonDivision.FlatAppearance.MouseDownBackColor = Color.Black;
            buttonDivision.FlatStyle = FlatStyle.Popup;
            buttonDivision.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDivision.ForeColor = Color.White;
            buttonDivision.Location = new Point(12, 390);
            buttonDivision.Name = "buttonDivision";
            buttonDivision.Size = new Size(51, 51);
            buttonDivision.TabIndex = 20;
            buttonDivision.Text = "÷";
            buttonDivision.UseVisualStyleBackColor = false;
            buttonDivision.Click += button_Click;
            // 
            // buttonEquals
            // 
            buttonEquals.BackColor = Color.DimGray;
            buttonEquals.BackgroundImageLayout = ImageLayout.Center;
            buttonEquals.FlatAppearance.MouseDownBackColor = Color.Black;
            buttonEquals.FlatAppearance.MouseOverBackColor = Color.Black;
            buttonEquals.FlatStyle = FlatStyle.Popup;
            buttonEquals.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEquals.ForeColor = Color.White;
            buttonEquals.Location = new Point(186, 390);
            buttonEquals.Name = "buttonEquals";
            buttonEquals.Size = new Size(51, 51);
            buttonEquals.TabIndex = 21;
            buttonEquals.Text = "=";
            buttonEquals.UseVisualStyleBackColor = false;
            buttonEquals.Click += button_Equals_Click;
            // 
            // textBoxOutput
            // 
            textBoxOutput.BorderStyle = BorderStyle.None;
            textBoxOutput.Enabled = false;
            textBoxOutput.Location = new Point(126, 46);
            textBoxOutput.Multiline = true;
            textBoxOutput.Name = "textBoxOutput";
            textBoxOutput.Size = new Size(131, 50);
            textBoxOutput.TabIndex = 22;
            textBoxOutput.TextAlign = HorizontalAlignment.Right;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(253, 462);
            Controls.Add(textBoxOutput);
            Controls.Add(buttonEquals);
            Controls.Add(buttonDivision);
            Controls.Add(buttonDecimal);
            Controls.Add(button0);
            Controls.Add(buttonMultiplication);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(buttonClear);
            Controls.Add(buttonSubtraction);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(buttonClearEntry);
            Controls.Add(buttonAddition);
            Controls.Add(button59);
            Controls.Add(button9);
            Controls.Add(button45);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(labelOperacao);
            Controls.Add(txtResultado);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtResultado;
        private Label labelOperacao;
        private Button button45;
        private Button button59;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button buttonAddition;
        private Button buttonClearEntry;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button buttonSubtraction;
        private Button buttonClear;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button buttonMultiplication;
        private Button button0;
        private Button buttonDecimal;
        private Button buttonDivision;
        private Button buttonEquals;
        private TextBox textBoxOutput;
    }
}