namespace Hex_Decoder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Source_TextBox = new RichTextBox();
            ASCIIConvert_Button = new Button();
            Target_TextBox = new RichTextBox();
            UTF16Convert_Button = new Button();
            label1 = new Label();
            label2 = new Label();
            Latin1_Convert_Button = new Button();
            SuspendLayout();
            // 
            // Source_TextBox
            // 
            Source_TextBox.Location = new Point(27, 42);
            Source_TextBox.Name = "Source_TextBox";
            Source_TextBox.Size = new Size(931, 259);
            Source_TextBox.TabIndex = 0;
            Source_TextBox.Text = "";
            // 
            // ASCIIConvert_Button
            // 
            ASCIIConvert_Button.Location = new Point(800, 327);
            ASCIIConvert_Button.Name = "ASCIIConvert_Button";
            ASCIIConvert_Button.Size = new Size(155, 40);
            ASCIIConvert_Button.TabIndex = 1;
            ASCIIConvert_Button.Text = "Convert (ASCII)";
            ASCIIConvert_Button.UseVisualStyleBackColor = true;
            ASCIIConvert_Button.Click += ASCIIConvert_Button_Click;
            // 
            // Target_TextBox
            // 
            Target_TextBox.Location = new Point(27, 389);
            Target_TextBox.Name = "Target_TextBox";
            Target_TextBox.Size = new Size(928, 212);
            Target_TextBox.TabIndex = 2;
            Target_TextBox.Text = "";
            // 
            // UTF16Convert_Button
            // 
            UTF16Convert_Button.Location = new Point(611, 327);
            UTF16Convert_Button.Name = "UTF16Convert_Button";
            UTF16Convert_Button.Size = new Size(168, 40);
            UTF16Convert_Button.TabIndex = 3;
            UTF16Convert_Button.Text = "Convert (UTF-16)";
            UTF16Convert_Button.UseVisualStyleBackColor = true;
            UTF16Convert_Button.Click += UTF16Convert_Button_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 13);
            label1.Name = "label1";
            label1.Size = new Size(66, 25);
            label1.TabIndex = 4;
            label1.Text = "Source";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 342);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 5;
            label2.Text = "Result";
            // 
            // Latin1_Convert_Button
            // 
            Latin1_Convert_Button.Location = new Point(421, 327);
            Latin1_Convert_Button.Name = "Latin1_Convert_Button";
            Latin1_Convert_Button.Size = new Size(165, 40);
            Latin1_Convert_Button.TabIndex = 6;
            Latin1_Convert_Button.Text = "Convert (Latin1)";
            Latin1_Convert_Button.UseVisualStyleBackColor = true;
            Latin1_Convert_Button.Click += Latin1_Convert_Button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(989, 633);
            Controls.Add(Latin1_Convert_Button);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(UTF16Convert_Button);
            Controls.Add(Target_TextBox);
            Controls.Add(ASCIIConvert_Button);
            Controls.Add(Source_TextBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Hex Decoder - Convert Hex Strings to Strings";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox Source_TextBox;
        private Button ASCIIConvert_Button;
        private RichTextBox Target_TextBox;
        private Button UTF16Convert_Button;
        private Label label1;
        private Label label2;
        private Button Latin1_Convert_Button;
    }
}