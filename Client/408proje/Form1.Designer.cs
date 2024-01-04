
namespace _408proje
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.textIP = new System.Windows.Forms.TextBox();
            this.buttonSPS = new System.Windows.Forms.Button();
            this.buttonIF = new System.Windows.Forms.Button();
            this.textCOnnectionList = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textINPUTsps101 = new System.Windows.Forms.RichTextBox();
            this.textINPUTif100 = new System.Windows.Forms.RichTextBox();
            this.buttonSendSps101 = new System.Windows.Forms.Button();
            this.buttonSendIF100 = new System.Windows.Forms.Button();
            this.textSendSps101 = new System.Windows.Forms.RichTextBox();
            this.textSendIF = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textPort = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "IP";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(113, 37);
            this.textName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(100, 20);
            this.textName.TabIndex = 2;
            this.textName.TextChanged += new System.EventHandler(this.textName_TextChanged);
            // 
            // textIP
            // 
            this.textIP.Location = new System.Drawing.Point(113, 69);
            this.textIP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textIP.Name = "textIP";
            this.textIP.Size = new System.Drawing.Size(100, 20);
            this.textIP.TabIndex = 3;
            this.textIP.TextChanged += new System.EventHandler(this.textIP_TextChanged);
            // 
            // buttonSPS
            // 
            this.buttonSPS.ForeColor = System.Drawing.Color.Red;
            this.buttonSPS.Location = new System.Drawing.Point(322, 14);
            this.buttonSPS.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSPS.Name = "buttonSPS";
            this.buttonSPS.Size = new System.Drawing.Size(295, 23);
            this.buttonSPS.TabIndex = 4;
            this.buttonSPS.Text = "SPS101";
            this.buttonSPS.UseVisualStyleBackColor = true;
            this.buttonSPS.Click += new System.EventHandler(this.buttonSPS_Click);
            // 
            // buttonIF
            // 
            this.buttonIF.ForeColor = System.Drawing.Color.Red;
            this.buttonIF.Location = new System.Drawing.Point(638, 14);
            this.buttonIF.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonIF.Name = "buttonIF";
            this.buttonIF.Size = new System.Drawing.Size(305, 24);
            this.buttonIF.TabIndex = 7;
            this.buttonIF.Text = "IF100";
            this.buttonIF.UseVisualStyleBackColor = true;
            this.buttonIF.Click += new System.EventHandler(this.button2_Click);
            // 
            // textCOnnectionList
            // 
            this.textCOnnectionList.Location = new System.Drawing.Point(93, 227);
            this.textCOnnectionList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textCOnnectionList.Name = "textCOnnectionList";
            this.textCOnnectionList.Size = new System.Drawing.Size(143, 133);
            this.textCOnnectionList.TabIndex = 8;
            this.textCOnnectionList.Text = "";
            this.textCOnnectionList.TextChanged += new System.EventHandler(this.textCOnnectionList_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 198);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Connected Channels";
            // 
            // textINPUTsps101
            // 
            this.textINPUTsps101.Location = new System.Drawing.Point(322, 57);
            this.textINPUTsps101.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textINPUTsps101.Name = "textINPUTsps101";
            this.textINPUTsps101.Size = new System.Drawing.Size(296, 265);
            this.textINPUTsps101.TabIndex = 10;
            this.textINPUTsps101.Text = "";
            this.textINPUTsps101.TextChanged += new System.EventHandler(this.textINPUTsps101_TextChanged);
            // 
            // textINPUTif100
            // 
            this.textINPUTif100.Location = new System.Drawing.Point(638, 57);
            this.textINPUTif100.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textINPUTif100.Name = "textINPUTif100";
            this.textINPUTif100.Size = new System.Drawing.Size(306, 265);
            this.textINPUTif100.TabIndex = 11;
            this.textINPUTif100.Text = "";
            this.textINPUTif100.TextChanged += new System.EventHandler(this.textINPUTif100_TextChanged);
            // 
            // buttonSendSps101
            // 
            this.buttonSendSps101.Enabled = false;
            this.buttonSendSps101.Location = new System.Drawing.Point(322, 324);
            this.buttonSendSps101.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSendSps101.Name = "buttonSendSps101";
            this.buttonSendSps101.Size = new System.Drawing.Size(95, 68);
            this.buttonSendSps101.TabIndex = 12;
            this.buttonSendSps101.Text = "Send to SPS101";
            this.buttonSendSps101.UseVisualStyleBackColor = true;
            this.buttonSendSps101.Click += new System.EventHandler(this.buttonSendSps101_Click);
            // 
            // buttonSendIF100
            // 
            this.buttonSendIF100.Enabled = false;
            this.buttonSendIF100.Location = new System.Drawing.Point(638, 324);
            this.buttonSendIF100.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSendIF100.Name = "buttonSendIF100";
            this.buttonSendIF100.Size = new System.Drawing.Size(105, 68);
            this.buttonSendIF100.TabIndex = 13;
            this.buttonSendIF100.Text = "Send to IF100";
            this.buttonSendIF100.UseVisualStyleBackColor = true;
            this.buttonSendIF100.Click += new System.EventHandler(this.buttonSendIF100_Click);
            // 
            // textSendSps101
            // 
            this.textSendSps101.Location = new System.Drawing.Point(421, 324);
            this.textSendSps101.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textSendSps101.Name = "textSendSps101";
            this.textSendSps101.Size = new System.Drawing.Size(197, 68);
            this.textSendSps101.TabIndex = 14;
            this.textSendSps101.Text = "";
            this.textSendSps101.TextChanged += new System.EventHandler(this.textSendSps101_TextChanged);
            // 
            // textSendIF
            // 
            this.textSendIF.Location = new System.Drawing.Point(747, 324);
            this.textSendIF.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textSendIF.Name = "textSendIF";
            this.textSendIF.Size = new System.Drawing.Size(197, 69);
            this.textSendIF.TabIndex = 15;
            this.textSendIF.Text = "";
            this.textSendIF.TextChanged += new System.EventHandler(this.textSendIF_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 105);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Port";
            // 
            // textPort
            // 
            this.textPort.Location = new System.Drawing.Point(113, 101);
            this.textPort.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textPort.Name = "textPort";
            this.textPort.Size = new System.Drawing.Size(100, 20);
            this.textPort.TabIndex = 17;
            this.textPort.TextChanged += new System.EventHandler(this.textPort_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 406);
            this.Controls.Add(this.textPort);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textSendIF);
            this.Controls.Add(this.textSendSps101);
            this.Controls.Add(this.buttonSendIF100);
            this.Controls.Add(this.buttonSendSps101);
            this.Controls.Add(this.textINPUTif100);
            this.Controls.Add(this.textINPUTsps101);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textCOnnectionList);
            this.Controls.Add(this.buttonIF);
            this.Controls.Add(this.buttonSPS);
            this.Controls.Add(this.textIP);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textIP;
        private System.Windows.Forms.Button buttonSPS;
        private System.Windows.Forms.RichTextBox textCOnnectionList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonIF;
        private System.Windows.Forms.RichTextBox textINPUTsps101;
        private System.Windows.Forms.RichTextBox textINPUTif100;
        private System.Windows.Forms.Button buttonSendSps101;
        private System.Windows.Forms.Button buttonSendIF100;
        private System.Windows.Forms.RichTextBox textSendSps101;
        private System.Windows.Forms.RichTextBox textSendIF;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textPort;
    }
}

