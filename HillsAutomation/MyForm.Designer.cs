namespace HillsAutomation
{
    partial class MyForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_send = new System.Windows.Forms.Button();
            this.tb_serial = new System.Windows.Forms.TextBox();
            this.pb_qrcode = new System.Windows.Forms.PictureBox();
            this.tb_width = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_height = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_writePath = new System.Windows.Forms.TextBox();
            this.lb_loading = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_qrcode)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.lb_title.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_title.Location = new System.Drawing.Point(12, 23);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(238, 33);
            this.lb_title.TabIndex = 0;
            this.lb_title.Text = "HILLS AUTOMATION";
            this.lb_title.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quantidade de seriais";
            // 
            // bt_send
            // 
            this.bt_send.BackColor = System.Drawing.SystemColors.Control;
            this.bt_send.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bt_send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_send.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_send.ForeColor = System.Drawing.Color.Teal;
            this.bt_send.Location = new System.Drawing.Point(17, 342);
            this.bt_send.Name = "bt_send";
            this.bt_send.Size = new System.Drawing.Size(82, 31);
            this.bt_send.TabIndex = 2;
            this.bt_send.Text = "Inserir";
            this.bt_send.UseVisualStyleBackColor = false;
            this.bt_send.Click += new System.EventHandler(this.bt_send_Click);
            // 
            // tb_serial
            // 
            this.tb_serial.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_serial.Location = new System.Drawing.Point(217, 99);
            this.tb_serial.Name = "tb_serial";
            this.tb_serial.Size = new System.Drawing.Size(162, 27);
            this.tb_serial.TabIndex = 3;
            this.tb_serial.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pb_qrcode
            // 
            this.pb_qrcode.BackColor = System.Drawing.Color.MintCream;
            this.pb_qrcode.Location = new System.Drawing.Point(425, 97);
            this.pb_qrcode.Name = "pb_qrcode";
            this.pb_qrcode.Size = new System.Drawing.Size(161, 151);
            this.pb_qrcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_qrcode.TabIndex = 4;
            this.pb_qrcode.TabStop = false;
            // 
            // tb_width
            // 
            this.tb_width.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_width.Location = new System.Drawing.Point(101, 220);
            this.tb_width.Name = "tb_width";
            this.tb_width.Size = new System.Drawing.Size(78, 27);
            this.tb_width.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(12, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Largura";
            // 
            // tb_height
            // 
            this.tb_height.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_height.Location = new System.Drawing.Point(301, 220);
            this.tb_height.Name = "tb_height";
            this.tb_height.Size = new System.Drawing.Size(78, 27);
            this.tb_height.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(212, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "Altura";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(419, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 33);
            this.label4.TabIndex = 9;
            this.label4.Text = "QR CODE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(12, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 33);
            this.label5.TabIndex = 10;
            this.label5.Text = "CONFIG";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(12, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 26);
            this.label6.TabIndex = 11;
            this.label6.Text = "Caminho de gravação";
            // 
            // tb_writePath
            // 
            this.tb_writePath.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_writePath.Location = new System.Drawing.Point(217, 276);
            this.tb_writePath.Name = "tb_writePath";
            this.tb_writePath.Size = new System.Drawing.Size(369, 27);
            this.tb_writePath.TabIndex = 12;
            this.tb_writePath.Click += new System.EventHandler(this.tb_writePath_Click);
            // 
            // lb_loading
            // 
            this.lb_loading.AutoSize = true;
            this.lb_loading.BackColor = System.Drawing.Color.MintCream;
            this.lb_loading.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_loading.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_loading.Location = new System.Drawing.Point(428, 147);
            this.lb_loading.Name = "lb_loading";
            this.lb_loading.Size = new System.Drawing.Size(158, 29);
            this.lb_loading.TabIndex = 13;
            this.lb_loading.Text = "CARREGANDO";
            this.lb_loading.Visible = false;
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(613, 395);
            this.Controls.Add(this.lb_loading);
            this.Controls.Add(this.tb_writePath);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_height);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_width);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pb_qrcode);
            this.Controls.Add(this.tb_serial);
            this.Controls.Add(this.bt_send);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_title);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(394, 255);
            this.Name = "MyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pb_qrcode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_send;
        private System.Windows.Forms.TextBox tb_serial;
        private System.Windows.Forms.PictureBox pb_qrcode;
        private System.Windows.Forms.TextBox tb_width;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_height;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_writePath;
        private System.Windows.Forms.Label lb_loading;
    }
}

