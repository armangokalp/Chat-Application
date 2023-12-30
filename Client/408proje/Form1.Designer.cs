
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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "IP";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(169, 64);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(148, 26);
            this.textName.TabIndex = 2;
            this.textName.TextChanged += new System.EventHandler(this.textName_TextChanged);
            // 
            // textIP
            // 
            this.textIP.Location = new System.Drawing.Point(169, 110);
            this.textIP.Name = "textIP";
            this.textIP.Size = new System.Drawing.Size(148, 26);
            this.textIP.TabIndex = 3;
            this.textIP.Text = "192.168.0.109";
            this.textIP.TextChanged += new System.EventHandler(this.textIP_TextChanged);
            // 
            // buttonSPS
            // 
            this.buttonSPS.Enabled = false;
            this.buttonSPS.ForeColor = System.Drawing.Color.Green;
            this.buttonSPS.Location = new System.Drawing.Point(483, 22);
            this.buttonSPS.Name = "buttonSPS";
            this.buttonSPS.Size = new System.Drawing.Size(442, 35);
            this.buttonSPS.TabIndex = 4;
            this.buttonSPS.Text = "Subscribe SPS101";
            this.buttonSPS.UseVisualStyleBackColor = true;
            this.buttonSPS.Click += new System.EventHandler(this.buttonSPS_Click);
            // 
            // buttonIF
            // 
            this.buttonIF.Enabled = false;
            this.buttonIF.ForeColor = System.Drawing.Color.Green;
            this.buttonIF.Location = new System.Drawing.Point(957, 21);
            this.buttonIF.Name = "buttonIF";
            this.buttonIF.Size = new System.Drawing.Size(457, 37);
            this.buttonIF.TabIndex = 7;
            this.buttonIF.Text = "Subscribe IF100";
            this.buttonIF.UseVisualStyleBackColor = true;
            this.buttonIF.Click += new System.EventHandler(this.button2_Click);
            // 
            // textCOnnectionList
            // 
            this.textCOnnectionList.Location = new System.Drawing.Point(139, 349);
            this.textCOnnectionList.Name = "textCOnnectionList";
            this.textCOnnectionList.Size = new System.Drawing.Size(213, 203);
            this.textCOnnectionList.TabIndex = 8;
            this.textCOnnectionList.Text = "";
            this.textCOnnectionList.TextChanged += new System.EventHandler(this.textCOnnectionList_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Connected Channels";
            // 
            // textINPUTsps101
            // 
            this.textINPUTsps101.Location = new System.Drawing.Point(483, 87);
            this.textINPUTsps101.Name = "textINPUTsps101";
            this.textINPUTsps101.Size = new System.Drawing.Size(442, 405);
            this.textINPUTsps101.TabIndex = 10;
            this.textINPUTsps101.Text = "";
            this.textINPUTsps101.TextChanged += new System.EventHandler(this.textINPUTsps101_TextChanged);
            // 
            // textINPUTif100
            // 
            this.textINPUTif100.Location = new System.Drawing.Point(957, 87);
            this.textINPUTif100.Name = "textINPUTif100";
            this.textINPUTif100.Size = new System.Drawing.Size(457, 405);
            this.textINPUTif100.TabIndex = 11;
            this.textINPUTif100.Text = "";
            this.textINPUTif100.TextChanged += new System.EventHandler(this.textINPUTif100_TextChanged);
            // 
            // buttonSendSps101
            // 
            this.buttonSendSps101.Enabled = false;
            this.buttonSendSps101.Location = new System.Drawing.Point(483, 498);
            this.buttonSendSps101.Name = "buttonSendSps101";
            this.buttonSendSps101.Size = new System.Drawing.Size(143, 104);
            this.buttonSendSps101.TabIndex = 12;
            this.buttonSendSps101.Text = "Send to SPS101";
            this.buttonSendSps101.UseVisualStyleBackColor = true;
            this.buttonSendSps101.Click += new System.EventHandler(this.buttonSendSps101_Click);
            // 
            // buttonSendIF100
            // 
            this.buttonSendIF100.Enabled = false;
            this.buttonSendIF100.Location = new System.Drawing.Point(957, 498);
            this.buttonSendIF100.Name = "buttonSendIF100";
            this.buttonSendIF100.Size = new System.Drawing.Size(158, 104);
            this.buttonSendIF100.TabIndex = 13;
            this.buttonSendIF100.Text = "Send to IF100";
            this.buttonSendIF100.UseVisualStyleBackColor = true;
            this.buttonSendIF100.Click += new System.EventHandler(this.buttonSendIF100_Click);
            // 
            // textSendSps101
            // 
            this.textSendSps101.Location = new System.Drawing.Point(632, 499);
            this.textSendSps101.Name = "textSendSps101";
            this.textSendSps101.Size = new System.Drawing.Size(293, 103);
            this.textSendSps101.TabIndex = 14;
            this.textSendSps101.Text = "";
            this.textSendSps101.TextChanged += new System.EventHandler(this.textSendSps101_TextChanged);
            // 
            // textSendIF
            // 
            this.textSendIF.Location = new System.Drawing.Point(1121, 498);
            this.textSendIF.Name = "textSendIF";
            this.textSendIF.Size = new System.Drawing.Size(293, 104);
            this.textSendIF.TabIndex = 15;
            this.textSendIF.Text = "";
            this.textSendIF.TextChanged += new System.EventHandler(this.textSendIF_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Port";
            // 
            // textPort
            // 
            this.textPort.Location = new System.Drawing.Point(169, 162);
            this.textPort.Name = "textPort";
            this.textPort.Size = new System.Drawing.Size(148, 26);
            this.textPort.TabIndex = 17;
            this.textPort.Text = "1";
            this.textPort.TextChanged += new System.EventHandler(this.textPort_TextChanged);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Green;
            this.button1.Location = new System.Drawing.Point(61, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(256, 33);
            this.button1.TabIndex = 18;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1473, 625);
            this.Controls.Add(this.button1);
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
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.Button button1;
    }
}

