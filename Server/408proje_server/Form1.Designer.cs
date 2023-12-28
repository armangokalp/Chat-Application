
namespace _408proje_server
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
            this.textIF100_connected_users = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textSPS101_connected_users = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.text_all_actions = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_START = new System.Windows.Forms.Button();
            this.text_port_num = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // textIF100_connected_users
            // 
            this.textIF100_connected_users.Location = new System.Drawing.Point(6, 25);
            this.textIF100_connected_users.Name = "textIF100_connected_users";
            this.textIF100_connected_users.Size = new System.Drawing.Size(509, 199);
            this.textIF100_connected_users.TabIndex = 9;
            this.textIF100_connected_users.Text = "";
            this.textIF100_connected_users.TextChanged += new System.EventHandler(this.textIF100_connected_users_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textIF100_connected_users);
            this.groupBox1.Location = new System.Drawing.Point(32, 632);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(521, 230);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "IF100  Connected Users";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textSPS101_connected_users);
            this.groupBox2.Location = new System.Drawing.Point(32, 366);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(521, 230);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SPS101  Connected Users";
            // 
            // textSPS101_connected_users
            // 
            this.textSPS101_connected_users.Location = new System.Drawing.Point(6, 25);
            this.textSPS101_connected_users.Name = "textSPS101_connected_users";
            this.textSPS101_connected_users.Size = new System.Drawing.Size(509, 199);
            this.textSPS101_connected_users.TabIndex = 9;
            this.textSPS101_connected_users.Text = "";
            this.textSPS101_connected_users.TextChanged += new System.EventHandler(this.textSPS101_connected_users_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.richTextBox1);
            this.groupBox3.Location = new System.Drawing.Point(32, 111);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(521, 230);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "All Connected Users";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(6, 25);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(509, 199);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.text_all_actions);
            this.groupBox4.Location = new System.Drawing.Point(577, 24);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(621, 838);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "All Actions";
            // 
            // text_all_actions
            // 
            this.text_all_actions.Location = new System.Drawing.Point(7, 25);
            this.text_all_actions.Name = "text_all_actions";
            this.text_all_actions.Size = new System.Drawing.Size(608, 807);
            this.text_all_actions.TabIndex = 0;
            this.text_all_actions.Text = "";
            this.text_all_actions.TextChanged += new System.EventHandler(this.text_all_actions_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Port";
            // 
            // button_START
            // 
            this.button_START.Location = new System.Drawing.Point(265, 36);
            this.button_START.Name = "button_START";
            this.button_START.Size = new System.Drawing.Size(282, 69);
            this.button_START.TabIndex = 15;
            this.button_START.Text = "START";
            this.button_START.UseVisualStyleBackColor = true;
            this.button_START.Click += new System.EventHandler(this.button_START_Click);
            // 
            // text_port_num
            // 
            this.text_port_num.Location = new System.Drawing.Point(82, 42);
            this.text_port_num.Name = "text_port_num";
            this.text_port_num.Size = new System.Drawing.Size(156, 26);
            this.text_port_num.TabIndex = 16;
            this.text_port_num.Text = "1";
            this.text_port_num.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 873);
            this.Controls.Add(this.text_port_num);
            this.Controls.Add(this.button_START);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox textIF100_connected_users;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox textSPS101_connected_users;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RichTextBox text_all_actions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_START;
        private System.Windows.Forms.TextBox text_port_num;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

