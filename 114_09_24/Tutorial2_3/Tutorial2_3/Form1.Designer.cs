namespace Tutorial2_3
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
            label1 = new Label();
            translationLabel = new Label();
            italianButton = new Button();
            spanishButton = new Button();
            germanButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("華康新特圓體", 20F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1.Location = new Point(148, 45);
            label1.Name = "label1";
            label1.Size = new Size(477, 40);
            label1.TabIndex = 0;
            label1.Text = "選擇一個語言,我會說早安";
            // 
            // translationLabel
            // 
            translationLabel.BorderStyle = BorderStyle.Fixed3D;
            translationLabel.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            translationLabel.Location = new Point(100, 152);
            translationLabel.Name = "translationLabel";
            translationLabel.Size = new Size(571, 124);
            translationLabel.TabIndex = 1;
            translationLabel.TextAlign = ContentAlignment.MiddleCenter;
            translationLabel.Click += label2_Click;
            // 
            // italianButton
            // 
            italianButton.Font = new Font("Microsoft JhengHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 136);
            italianButton.Location = new Point(49, 333);
            italianButton.Name = "italianButton";
            italianButton.Size = new Size(155, 57);
            italianButton.TabIndex = 2;
            italianButton.Text = "義大利文";
            italianButton.UseVisualStyleBackColor = true;
            italianButton.Click += italianButton_Click;
            // 
            // spanishButton
            // 
            spanishButton.Font = new Font("Microsoft JhengHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 136);
            spanishButton.Location = new Point(302, 333);
            spanishButton.Name = "spanishButton";
            spanishButton.Size = new Size(155, 57);
            spanishButton.TabIndex = 3;
            spanishButton.Text = "西班牙文";
            spanishButton.UseVisualStyleBackColor = true;
            spanishButton.Click += spanishButton_Click;
            // 
            // germanButton
            // 
            germanButton.Font = new Font("Microsoft JhengHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 136);
            germanButton.Location = new Point(562, 333);
            germanButton.Name = "germanButton";
            germanButton.Size = new Size(155, 57);
            germanButton.TabIndex = 4;
            germanButton.Text = "德文";
            germanButton.UseVisualStyleBackColor = true;
            germanButton.Click += germanButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(germanButton);
            Controls.Add(spanishButton);
            Controls.Add(italianButton);
            Controls.Add(translationLabel);
            Controls.Add(label1);
            Name = "Form1";
            Text = "語言翻譯器";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label translationLabel;
        private Button italianButton;
        private Button spanishButton;
        private Button germanButton;
    }
}
