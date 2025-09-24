namespace tutorial_2_5
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.CardbacepictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CardbacepictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CardbacepictureBox
            // 
            this.CardbacepictureBox.Image = global::tutorial_2_5.Properties.Resources.Backface_Blue;
            this.CardbacepictureBox.Location = new System.Drawing.Point(99, 56);
            this.CardbacepictureBox.Name = "CardbacepictureBox";
            this.CardbacepictureBox.Size = new System.Drawing.Size(154, 211);
            this.CardbacepictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CardbacepictureBox.TabIndex = 0;
            this.CardbacepictureBox.TabStop = false;
            this.CardbacepictureBox.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::tutorial_2_5.Properties.Resources.Joker_Black;
            this.pictureBox1.Location = new System.Drawing.Point(479, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 211);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(749, 471);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CardbacepictureBox);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.CardbacepictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox cardfacePictureBox;
        private System.Windows.Forms.PictureBox cardbackPictureBox;
        private System.Windows.Forms.Button showbackButton;
        private System.Windows.Forms.Button showfaceButton;
        private System.Windows.Forms.PictureBox CardbacepictureBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

