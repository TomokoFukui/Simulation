namespace 不平等の自然発生シミュレーション
{
    partial class FormOperation
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
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.labelCaption = new System.Windows.Forms.Label();
            this.textBoxBlance = new System.Windows.Forms.TextBox();
            this.textBoxPopulation = new System.Windows.Forms.TextBox();
            this.textBoxPay = new System.Windows.Forms.TextBox();
            this.labelBalance1 = new System.Windows.Forms.Label();
            this.labelBalance2 = new System.Windows.Forms.Label();
            this.labelPopulation1 = new System.Windows.Forms.Label();
            this.labelPopulation2 = new System.Windows.Forms.Label();
            this.labelPay1 = new System.Windows.Forms.Label();
            this.labelPay2 = new System.Windows.Forms.Label();
            this.labelPay3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(196, 168);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(288, 168);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 2;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // labelCaption
            // 
            this.labelCaption.AutoSize = true;
            this.labelCaption.Location = new System.Drawing.Point(12, 9);
            this.labelCaption.Name = "labelCaption";
            this.labelCaption.Size = new System.Drawing.Size(74, 12);
            this.labelCaption.TabIndex = 3;
            this.labelCaption.Text = "dummy string";
            // 
            // textBoxBlance
            // 
            this.textBoxBlance.Location = new System.Drawing.Point(154, 79);
            this.textBoxBlance.Name = "textBoxBlance";
            this.textBoxBlance.Size = new System.Drawing.Size(56, 19);
            this.textBoxBlance.TabIndex = 4;
            // 
            // textBoxPopulation
            // 
            this.textBoxPopulation.Location = new System.Drawing.Point(110, 57);
            this.textBoxPopulation.Name = "textBoxPopulation";
            this.textBoxPopulation.Size = new System.Drawing.Size(57, 19);
            this.textBoxPopulation.TabIndex = 5;
            // 
            // textBoxPay
            // 
            this.textBoxPay.Location = new System.Drawing.Point(129, 101);
            this.textBoxPay.Name = "textBoxPay";
            this.textBoxPay.Size = new System.Drawing.Size(59, 19);
            this.textBoxPay.TabIndex = 6;
            // 
            // labelBalance1
            // 
            this.labelBalance1.AutoSize = true;
            this.labelBalance1.Location = new System.Drawing.Point(12, 82);
            this.labelBalance1.Name = "labelBalance1";
            this.labelBalance1.Size = new System.Drawing.Size(136, 12);
            this.labelBalance1.TabIndex = 7;
            this.labelBalance1.Text = "最初の所持金は全員等しく";
            // 
            // labelBalance2
            // 
            this.labelBalance2.AutoSize = true;
            this.labelBalance2.Location = new System.Drawing.Point(212, 82);
            this.labelBalance2.Name = "labelBalance2";
            this.labelBalance2.Size = new System.Drawing.Size(29, 12);
            this.labelBalance2.TabIndex = 8;
            this.labelBalance2.Text = "万円";
            // 
            // labelPopulation1
            // 
            this.labelPopulation1.AutoSize = true;
            this.labelPopulation1.Location = new System.Drawing.Point(13, 60);
            this.labelPopulation1.Name = "labelPopulation1";
            this.labelPopulation1.Size = new System.Drawing.Size(91, 12);
            this.labelPopulation1.TabIndex = 9;
            this.labelPopulation1.Text = "ゲームの参加者は";
            // 
            // labelPopulation2
            // 
            this.labelPopulation2.AutoSize = true;
            this.labelPopulation2.Location = new System.Drawing.Point(173, 60);
            this.labelPopulation2.Name = "labelPopulation2";
            this.labelPopulation2.Size = new System.Drawing.Size(17, 12);
            this.labelPopulation2.TabIndex = 10;
            this.labelPopulation2.Text = "人";
            // 
            // labelPay1
            // 
            this.labelPay1.AutoSize = true;
            this.labelPay1.Location = new System.Drawing.Point(12, 104);
            this.labelPay1.Name = "labelPay1";
            this.labelPay1.Size = new System.Drawing.Size(114, 12);
            this.labelPay1.TabIndex = 11;
            this.labelPay1.Text = "ランダムに決めた相手に";
            // 
            // labelPay2
            // 
            this.labelPay2.AutoSize = true;
            this.labelPay2.Location = new System.Drawing.Point(194, 104);
            this.labelPay2.Name = "labelPay2";
            this.labelPay2.Size = new System.Drawing.Size(39, 12);
            this.labelPay2.TabIndex = 12;
            this.labelPay2.Text = "円渡す";
            // 
            // labelPay3
            // 
            this.labelPay3.AutoSize = true;
            this.labelPay3.Location = new System.Drawing.Point(13, 126);
            this.labelPay3.Name = "labelPay3";
            this.labelPay3.Size = new System.Drawing.Size(126, 12);
            this.labelPay3.TabIndex = 13;
            this.labelPay3.Text = "お金がないときは渡せない";
            // 
            // FormOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 203);
            this.Controls.Add(this.labelPay3);
            this.Controls.Add(this.labelPay2);
            this.Controls.Add(this.labelPay1);
            this.Controls.Add(this.labelPopulation2);
            this.Controls.Add(this.labelPopulation1);
            this.Controls.Add(this.labelBalance2);
            this.Controls.Add(this.labelBalance1);
            this.Controls.Add(this.textBoxPay);
            this.Controls.Add(this.textBoxPopulation);
            this.Controls.Add(this.textBoxBlance);
            this.Controls.Add(this.labelCaption);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Name = "FormOperation";
            this.Text = "不平等性の自然発生シミュレーション";
            this.Load += new System.EventHandler(this.FormOperation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Label labelCaption;
        private System.Windows.Forms.TextBox textBoxBlance;
        private System.Windows.Forms.TextBox textBoxPopulation;
        private System.Windows.Forms.TextBox textBoxPay;
        private System.Windows.Forms.Label labelBalance1;
        private System.Windows.Forms.Label labelBalance2;
        private System.Windows.Forms.Label labelPopulation1;
        private System.Windows.Forms.Label labelPopulation2;
        private System.Windows.Forms.Label labelPay1;
        private System.Windows.Forms.Label labelPay2;
        private System.Windows.Forms.Label labelPay3;
    }
}

