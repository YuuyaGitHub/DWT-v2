namespace Discord_Webhook_Tool_v2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem8 = new System.Windows.Forms.MenuItem();
            this.menuItem9 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem11 = new System.Windows.Forms.MenuItem();
            this.menuItem10 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem3});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem8,
            this.menuItem9,
            this.menuItem2});
            this.menuItem1.Text = "ファイル(&F)";
            // 
            // menuItem8
            // 
            this.menuItem8.Index = 0;
            this.menuItem8.Text = "新しいウインドウ(&W)";
            this.menuItem8.Click += new System.EventHandler(this.menuItem8_Click);
            // 
            // menuItem9
            // 
            this.menuItem9.Index = 1;
            this.menuItem9.Text = "-";
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 2;
            this.menuItem2.Text = "終了(&Q)";
            this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 1;
            this.menuItem3.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem11,
            this.menuItem10,
            this.menuItem6,
            this.menuItem7,
            this.menuItem5,
            this.menuItem4});
            this.menuItem3.Text = "ヘルプ(&H)";
            // 
            // menuItem11
            // 
            this.menuItem11.Index = 0;
            this.menuItem11.Text = "使い方(&O)";
            this.menuItem11.Click += new System.EventHandler(this.menuItem11_Click);
            // 
            // menuItem10
            // 
            this.menuItem10.Index = 1;
            this.menuItem10.Text = "-";
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 2;
            this.menuItem6.Text = "ウェブフックの詳細(&W)";
            this.menuItem6.Click += new System.EventHandler(this.menuItem6_Click);
            // 
            // menuItem7
            // 
            this.menuItem7.Index = 3;
            this.menuItem7.Text = "ウェブフックURLの取得方法(&H)";
            this.menuItem7.Click += new System.EventHandler(this.menuItem7_Click);
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 4;
            this.menuItem5.Text = "-";
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 5;
            this.menuItem4.Text = "バージョン情報(&A)";
            this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "このツールは、Discordのウェブフックを送信するツールです。";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "ウェブフックのURL(&U):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "名前(N): ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "アイコン(&I):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "内容:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(121, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(428, 19);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(121, 80);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(428, 19);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(121, 105);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(428, 19);
            this.textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(121, 133);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox4.Size = new System.Drawing.Size(428, 110);
            this.textBox4.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(482, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 28);
            this.button1.TabIndex = 9;
            this.button1.Text = "送信(&S)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 288);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Size = new System.Drawing.Size(564, 22);
            this.statusBar1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 310);
            this.Controls.Add(this.statusBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Discord Webhook Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem menuItem6;
        private System.Windows.Forms.MenuItem menuItem7;
        private System.Windows.Forms.MenuItem menuItem5;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MenuItem menuItem8;
        private System.Windows.Forms.MenuItem menuItem9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuItem menuItem10;
        private System.Windows.Forms.MenuItem menuItem11;
        private System.Windows.Forms.StatusBar statusBar1;
    }
}

