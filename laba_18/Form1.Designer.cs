namespace laba_18
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
            calculateButton = new Button();
            textBoxEdgeLength = new TextBox();
            richTextBoxResults = new RichTextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // calculateButton
            // 
            calculateButton.Location = new Point(28, 160);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(125, 48);
            calculateButton.TabIndex = 0;
            calculateButton.Text = "Вычислить";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += calculateButton_Click;
            // 
            // textBoxEdgeLength
            // 
            textBoxEdgeLength.Location = new Point(28, 35);
            textBoxEdgeLength.Name = "textBoxEdgeLength";
            textBoxEdgeLength.Size = new Size(125, 27);
            textBoxEdgeLength.TabIndex = 1;
            textBoxEdgeLength.TextChanged += textBox1_TextChanged;
            // 
            // richTextBoxResults
            // 
            richTextBoxResults.Enabled = false;
            richTextBoxResults.Location = new Point(182, 12);
            richTextBoxResults.Name = "richTextBoxResults";
            richTextBoxResults.Size = new Size(284, 196);
            richTextBoxResults.TabIndex = 2;
            richTextBoxResults.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 12);
            label1.Name = "label1";
            label1.Size = new Size(109, 20);
            label1.TabIndex = 3;
            label1.Text = "Длинна ребра";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(499, 220);
            Controls.Add(label1);
            Controls.Add(richTextBoxResults);
            Controls.Add(textBoxEdgeLength);
            Controls.Add(calculateButton);
            Name = "Form1";
            Text = "Площадь куба";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button calculateButton;
        private TextBox textBoxEdgeLength;
        private RichTextBox richTextBoxResults;
        private Label label1;
    }
}
