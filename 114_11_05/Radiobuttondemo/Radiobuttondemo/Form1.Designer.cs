namespace Radiobuttondemo
{
    partial class juice
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
            this.coffee = new System.Windows.Forms.RadioButton();
            this.milktea = new System.Windows.Forms.RadioButton();
            this.blacktea = new System.Windows.Forms.RadioButton();
            this.juiceradioButton = new System.Windows.Forms.RadioButton();
            this.jellysandwich = new System.Windows.Forms.RadioButton();
            this.hamsandwich = new System.Windows.Forms.RadioButton();
            this.fishsandwich = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // coffee
            // 
            this.coffee.AutoSize = true;
            this.coffee.Location = new System.Drawing.Point(66, 74);
            this.coffee.Name = "coffee";
            this.coffee.Size = new System.Drawing.Size(69, 22);
            this.coffee.TabIndex = 0;
            this.coffee.TabStop = true;
            this.coffee.Text = "咖啡";
            this.coffee.UseVisualStyleBackColor = true;
            // 
            // milktea
            // 
            this.milktea.AutoSize = true;
            this.milktea.Location = new System.Drawing.Point(66, 135);
            this.milktea.Name = "milktea";
            this.milktea.Size = new System.Drawing.Size(69, 22);
            this.milktea.TabIndex = 1;
            this.milktea.TabStop = true;
            this.milktea.Text = "奶茶";
            this.milktea.UseVisualStyleBackColor = true;
            // 
            // blacktea
            // 
            this.blacktea.AutoSize = true;
            this.blacktea.Location = new System.Drawing.Point(66, 198);
            this.blacktea.Name = "blacktea";
            this.blacktea.Size = new System.Drawing.Size(69, 22);
            this.blacktea.TabIndex = 2;
            this.blacktea.TabStop = true;
            this.blacktea.Text = "紅茶";
            this.blacktea.UseVisualStyleBackColor = true;
            // 
            // juiceradioButton
            // 
            this.juiceradioButton.AutoSize = true;
            this.juiceradioButton.Location = new System.Drawing.Point(66, 263);
            this.juiceradioButton.Name = "juiceradioButton";
            this.juiceradioButton.Size = new System.Drawing.Size(69, 22);
            this.juiceradioButton.TabIndex = 3;
            this.juiceradioButton.TabStop = true;
            this.juiceradioButton.Text = "果汁";
            this.juiceradioButton.UseVisualStyleBackColor = true;
            // 
            // jellysandwich
            // 
            this.jellysandwich.AutoSize = true;
            this.jellysandwich.Location = new System.Drawing.Point(47, 76);
            this.jellysandwich.Name = "jellysandwich";
            this.jellysandwich.Size = new System.Drawing.Size(123, 22);
            this.jellysandwich.TabIndex = 4;
            this.jellysandwich.TabStop = true;
            this.jellysandwich.Text = "果醬三明治";
            this.jellysandwich.UseVisualStyleBackColor = true;
            this.jellysandwich.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // hamsandwich
            // 
            this.hamsandwich.AutoSize = true;
            this.hamsandwich.Location = new System.Drawing.Point(47, 152);
            this.hamsandwich.Name = "hamsandwich";
            this.hamsandwich.Size = new System.Drawing.Size(123, 22);
            this.hamsandwich.TabIndex = 5;
            this.hamsandwich.TabStop = true;
            this.hamsandwich.Text = "火腿三明治";
            this.hamsandwich.UseVisualStyleBackColor = true;
            // 
            // fishsandwich
            // 
            this.fishsandwich.AutoSize = true;
            this.fishsandwich.Location = new System.Drawing.Point(47, 235);
            this.fishsandwich.Name = "fishsandwich";
            this.fishsandwich.Size = new System.Drawing.Size(123, 22);
            this.fishsandwich.TabIndex = 6;
            this.fishsandwich.TabStop = true;
            this.fishsandwich.Text = "鮪魚三明治";
            this.fishsandwich.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.coffee);
            this.groupBox1.Controls.Add(this.milktea);
            this.groupBox1.Controls.Add(this.blacktea);
            this.groupBox1.Controls.Add(this.juiceradioButton);
            this.groupBox1.Location = new System.Drawing.Point(62, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(204, 333);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "飲料";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.fishsandwich);
            this.groupBox2.Controls.Add(this.hamsandwich);
            this.groupBox2.Controls.Add(this.jellysandwich);
            this.groupBox2.Location = new System.Drawing.Point(436, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 323);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "三明治";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(104, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 37);
            this.button1.TabIndex = 9;
            this.button1.Text = "送出訂單";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(483, 401);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 37);
            this.button2.TabIndex = 10;
            this.button2.Text = "離開";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // juice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "juice";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton coffee;
        private System.Windows.Forms.RadioButton milktea;
        private System.Windows.Forms.RadioButton blacktea;
        private System.Windows.Forms.RadioButton juiceradioButton;
        private System.Windows.Forms.RadioButton jellysandwich;
        private System.Windows.Forms.RadioButton hamsandwich;
        private System.Windows.Forms.RadioButton fishsandwich;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

