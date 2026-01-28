namespace WinForm
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.portSelector = new System.Windows.Forms.ComboBox();
            this.connectBtn = new System.Windows.Forms.Button();
            this.sendButton1 = new System.Windows.Forms.Button();
            this.sendButton2 = new System.Windows.Forms.Button();
            this.sendButton3 = new System.Windows.Forms.Button();
            this.sendButton4 = new System.Windows.Forms.Button();
            this.sendButton5 = new System.Windows.Forms.Button();
            this.sendButton6 = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // portSelector
            this.portSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.portSelector.Font = new System.Drawing.Font("MS UI Gothic", 14F);
            this.portSelector.FormattingEnabled = true;
            this.portSelector.Location = new System.Drawing.Point(50, 10);
            this.portSelector.Name = "portSelector";
            this.portSelector.Size = new System.Drawing.Size(700, 50);
            this.portSelector.TabIndex = 0;

            // connectBtn
            this.connectBtn.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.connectBtn.Location = new System.Drawing.Point(50, 55);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(700, 35);
            this.connectBtn.TabIndex = 1;
            this.connectBtn.Text = "connect";
            this.connectBtn.UseVisualStyleBackColor = true;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);

            // sendButton1
            this.sendButton1.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.sendButton1.Location = new System.Drawing.Point(90, 100);
            this.sendButton1.Name = "sendButton1";
            this.sendButton1.Size = new System.Drawing.Size(180, 80);
            this.sendButton1.TabIndex = 2;
            this.sendButton1.Text = "1";
            this.sendButton1.UseVisualStyleBackColor = true;
            this.sendButton1.Click += new System.EventHandler(this.sendButton_Click);

            // sendButton2
            this.sendButton2.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.sendButton2.Location = new System.Drawing.Point(310, 100);
            this.sendButton2.Name = "sendButton2";
            this.sendButton2.Size = new System.Drawing.Size(180, 80);
            this.sendButton2.TabIndex = 3;
            this.sendButton2.Text = "2";
            this.sendButton2.UseVisualStyleBackColor = true;
            this.sendButton2.Click += new System.EventHandler(this.sendButton_Click);

            // sendButton3
            this.sendButton3.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.sendButton3.Location = new System.Drawing.Point(530, 100);
            this.sendButton3.Name = "sendButton3";
            this.sendButton3.Size = new System.Drawing.Size(180, 80);
            this.sendButton3.TabIndex = 4;
            this.sendButton3.Text = "3";
            this.sendButton3.UseVisualStyleBackColor = true;
            this.sendButton3.Click += new System.EventHandler(this.sendButton_Click);

            // sendButton4
            this.sendButton4.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.sendButton4.Location = new System.Drawing.Point(90, 190);
            this.sendButton4.Name = "sendButton4";
            this.sendButton4.Size = new System.Drawing.Size(180, 80);
            this.sendButton4.TabIndex = 5;
            this.sendButton4.Text = "4";
            this.sendButton4.UseVisualStyleBackColor = true;
            this.sendButton4.Click += new System.EventHandler(this.sendButton_Click);

            // sendButton5
            this.sendButton5.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.sendButton5.Location = new System.Drawing.Point(310, 190);
            this.sendButton5.Name = "sendButton5";
            this.sendButton5.Size = new System.Drawing.Size(180, 80);
            this.sendButton5.TabIndex = 6;
            this.sendButton5.Text = "5";
            this.sendButton5.UseVisualStyleBackColor = true;
            this.sendButton5.Click += new System.EventHandler(this.sendButton_Click);

            // sendButton6
            this.sendButton6.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.sendButton6.Location = new System.Drawing.Point(530, 190);
            this.sendButton6.Name = "sendButton6";
            this.sendButton6.Size = new System.Drawing.Size(180, 80);
            this.sendButton6.TabIndex = 7;
            this.sendButton6.Text = "6";
            this.sendButton6.UseVisualStyleBackColor = true;
            this.sendButton6.Click += new System.EventHandler(this.sendButton_Click);

            // Form1
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 300);
            this.Controls.Add(this.sendButton6);
            this.Controls.Add(this.sendButton5);
            this.Controls.Add(this.sendButton4);
            this.Controls.Add(this.sendButton3);
            this.Controls.Add(this.sendButton2);
            this.Controls.Add(this.sendButton1);
            this.Controls.Add(this.connectBtn);
            this.Controls.Add(this.portSelector);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Serial Communication";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ComboBox portSelector;
        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.Button sendButton1;
        private System.Windows.Forms.Button sendButton2;
        private System.Windows.Forms.Button sendButton3;
        private System.Windows.Forms.Button sendButton4;
        private System.Windows.Forms.Button sendButton5;
        private System.Windows.Forms.Button sendButton6;
    }
}
