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
            SuspendLayout();
            // 
            // Source_TextBox
            // 
            Source_TextBox.Location = new Point(27, 20);
            Source_TextBox.Name = "Source_TextBox";
            Source_TextBox.Size = new Size(931, 281);
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
            UTF16Convert_Button.Location = new Point(605, 327);
            UTF16Convert_Button.Name = "UTF16Convert_Button";
            UTF16Convert_Button.Size = new Size(168, 40);
            UTF16Convert_Button.TabIndex = 3;
            UTF16Convert_Button.Text = "Convert (UTF-16)";
            UTF16Convert_Button.UseVisualStyleBackColor = true;
            UTF16Convert_Button.Click += UTF16Convert_Button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(989, 633);
            Controls.Add(UTF16Convert_Button);
            Controls.Add(Target_TextBox);
            Controls.Add(ASCIIConvert_Button);
            Controls.Add(Source_TextBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Hex Decoder - Convert Hex Strings to Strings";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox Source_TextBox;
        private Button ASCIIConvert_Button;
        private RichTextBox Target_TextBox;
        private Button UTF16Convert_Button;
    }
}