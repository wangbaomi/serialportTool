namespace 串口测试工具
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.hisIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hisPort = new System.Windows.Forms.TextBox();
            this.startListen = new System.Windows.Forms.Button();
            this.myPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.myIP = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.hisMsg = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.myMsg = new System.Windows.Forms.TextBox();
            this.sendMsg = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.profileTextBox = new System.Windows.Forms.RichTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.startTest = new System.Windows.Forms.Button();
            this.testingTextBox = new System.Windows.Forms.RichTextBox();
            this.readResult = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.myPort);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.myIP);
            this.groupBox1.Controls.Add(this.startListen);
            this.groupBox1.Controls.Add(this.hisPort);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.hisIP);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(185, 155);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TCP";
            // 
            // hisIP
            // 
            this.hisIP.Location = new System.Drawing.Point(18, 44);
            this.hisIP.Name = "hisIP";
            this.hisIP.Size = new System.Drawing.Size(100, 21);
            this.hisIP.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "对方IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "端口";
            // 
            // hisPort
            // 
            this.hisPort.Location = new System.Drawing.Point(135, 44);
            this.hisPort.Name = "hisPort";
            this.hisPort.Size = new System.Drawing.Size(41, 21);
            this.hisPort.TabIndex = 3;
            // 
            // startListen
            // 
            this.startListen.Location = new System.Drawing.Point(18, 115);
            this.startListen.Name = "startListen";
            this.startListen.Size = new System.Drawing.Size(158, 23);
            this.startListen.TabIndex = 4;
            this.startListen.Text = "监听本地端口";
            this.startListen.UseVisualStyleBackColor = true;
            // 
            // myPort
            // 
            this.myPort.Location = new System.Drawing.Point(135, 83);
            this.myPort.Name = "myPort";
            this.myPort.Size = new System.Drawing.Size(41, 21);
            this.myPort.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "端口";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "本地IP";
            // 
            // myIP
            // 
            this.myIP.Location = new System.Drawing.Point(18, 83);
            this.myIP.Name = "myIP";
            this.myIP.Size = new System.Drawing.Size(100, 21);
            this.myIP.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.sendMsg);
            this.groupBox2.Controls.Add(this.myMsg);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.hisMsg);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(205, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(141, 155);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "消息";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "接收消息";
            // 
            // hisMsg
            // 
            this.hisMsg.Location = new System.Drawing.Point(11, 44);
            this.hisMsg.Name = "hisMsg";
            this.hisMsg.Size = new System.Drawing.Size(123, 21);
            this.hisMsg.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "发送消息";
            // 
            // myMsg
            // 
            this.myMsg.Location = new System.Drawing.Point(11, 83);
            this.myMsg.Name = "myMsg";
            this.myMsg.Size = new System.Drawing.Size(123, 21);
            this.myMsg.TabIndex = 3;
            // 
            // sendMsg
            // 
            this.sendMsg.Location = new System.Drawing.Point(11, 115);
            this.sendMsg.Name = "sendMsg";
            this.sendMsg.Size = new System.Drawing.Size(123, 23);
            this.sendMsg.TabIndex = 4;
            this.sendMsg.Text = "发送";
            this.sendMsg.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.profileTextBox);
            this.groupBox3.Location = new System.Drawing.Point(13, 175);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(185, 143);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "配置文件";
            // 
            // profileTextBox
            // 
            this.profileTextBox.Location = new System.Drawing.Point(7, 21);
            this.profileTextBox.Name = "profileTextBox";
            this.profileTextBox.Size = new System.Drawing.Size(167, 116);
            this.profileTextBox.TabIndex = 0;
            this.profileTextBox.Text = "";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.readResult);
            this.groupBox4.Controls.Add(this.testingTextBox);
            this.groupBox4.Controls.Add(this.startTest);
            this.groupBox4.Location = new System.Drawing.Point(205, 175);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(141, 137);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "自动测试";
            // 
            // startTest
            // 
            this.startTest.Location = new System.Drawing.Point(11, 21);
            this.startTest.Name = "startTest";
            this.startTest.Size = new System.Drawing.Size(123, 23);
            this.startTest.TabIndex = 0;
            this.startTest.Text = "开始测试";
            this.startTest.UseVisualStyleBackColor = true;
            // 
            // testingTextBox
            // 
            this.testingTextBox.Location = new System.Drawing.Point(11, 50);
            this.testingTextBox.Name = "testingTextBox";
            this.testingTextBox.Size = new System.Drawing.Size(123, 52);
            this.testingTextBox.TabIndex = 1;
            this.testingTextBox.Text = "";
            // 
            // readResult
            // 
            this.readResult.Location = new System.Drawing.Point(11, 108);
            this.readResult.Name = "readResult";
            this.readResult.Size = new System.Drawing.Size(123, 23);
            this.readResult.TabIndex = 2;
            this.readResult.Text = "查看结果";
            this.readResult.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 330);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "串口测试工具";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox myPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox myIP;
        private System.Windows.Forms.Button startListen;
        private System.Windows.Forms.TextBox hisPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox hisIP;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button sendMsg;
        private System.Windows.Forms.TextBox myMsg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox hisMsg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox profileTextBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button readResult;
        private System.Windows.Forms.RichTextBox testingTextBox;
        private System.Windows.Forms.Button startTest;
    }
}

