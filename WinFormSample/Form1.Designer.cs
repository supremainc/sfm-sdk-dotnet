namespace WinFormSample
{
    partial class Form1
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
            this.btn_connect = new System.Windows.Forms.Button();
            this.btn_disconnect = new System.Windows.Forms.Button();
            this.label_comPort = new System.Windows.Forms.Label();
            this.label_baudrate = new System.Windows.Forms.Label();
            this.tb_comPort = new System.Windows.Forms.TextBox();
            this.tb_baudrate = new System.Windows.Forms.TextBox();
            this.tb_message = new System.Windows.Forms.TextBox();
            this.btn_enroll = new System.Windows.Forms.Button();
            this.btn_identify = new System.Windows.Forms.Button();
            this.btn_verify = new System.Windows.Forms.Button();
            this.label_userID = new System.Windows.Forms.Label();
            this.tb_userID = new System.Windows.Forms.TextBox();
            this.btn_deleteTemplate = new System.Windows.Forms.Button();
            this.btn_deleteAll = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_enrollByTemplate = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(402, 45);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(75, 23);
            this.btn_connect.TabIndex = 0;
            this.btn_connect.Text = "connect";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // btn_disconnect
            // 
            this.btn_disconnect.Location = new System.Drawing.Point(483, 45);
            this.btn_disconnect.Name = "btn_disconnect";
            this.btn_disconnect.Size = new System.Drawing.Size(75, 23);
            this.btn_disconnect.TabIndex = 1;
            this.btn_disconnect.Text = "disconnect";
            this.btn_disconnect.UseVisualStyleBackColor = true;
            this.btn_disconnect.Click += new System.EventHandler(this.btn_disconnect_Click);
            // 
            // label_comPort
            // 
            this.label_comPort.AutoSize = true;
            this.label_comPort.Location = new System.Drawing.Point(12, 50);
            this.label_comPort.Name = "label_comPort";
            this.label_comPort.Size = new System.Drawing.Size(56, 13);
            this.label_comPort.TabIndex = 2;
            this.label_comPort.Text = "Com Port :";
            // 
            // label_baudrate
            // 
            this.label_baudrate.AutoSize = true;
            this.label_baudrate.Location = new System.Drawing.Point(164, 50);
            this.label_baudrate.Name = "label_baudrate";
            this.label_baudrate.Size = new System.Drawing.Size(56, 13);
            this.label_baudrate.TabIndex = 3;
            this.label_baudrate.Text = "Baudrate :";
            // 
            // tb_comPort
            // 
            this.tb_comPort.Location = new System.Drawing.Point(71, 46);
            this.tb_comPort.Name = "tb_comPort";
            this.tb_comPort.Size = new System.Drawing.Size(74, 20);
            this.tb_comPort.TabIndex = 4;
            // 
            // tb_baudrate
            // 
            this.tb_baudrate.Location = new System.Drawing.Point(224, 45);
            this.tb_baudrate.Name = "tb_baudrate";
            this.tb_baudrate.Size = new System.Drawing.Size(74, 20);
            this.tb_baudrate.TabIndex = 5;
            // 
            // tb_message
            // 
            this.tb_message.Location = new System.Drawing.Point(15, 12);
            this.tb_message.Name = "tb_message";
            this.tb_message.ReadOnly = true;
            this.tb_message.Size = new System.Drawing.Size(543, 20);
            this.tb_message.TabIndex = 6;
            this.tb_message.Text = "WinFormSample";
            this.tb_message.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_enroll
            // 
            this.btn_enroll.Location = new System.Drawing.Point(20, 32);
            this.btn_enroll.Name = "btn_enroll";
            this.btn_enroll.Size = new System.Drawing.Size(122, 23);
            this.btn_enroll.TabIndex = 7;
            this.btn_enroll.Text = "Enroll";
            this.btn_enroll.UseVisualStyleBackColor = true;
            this.btn_enroll.Click += new System.EventHandler(this.btn_enroll_Click);
            // 
            // btn_identify
            // 
            this.btn_identify.Location = new System.Drawing.Point(148, 32);
            this.btn_identify.Name = "btn_identify";
            this.btn_identify.Size = new System.Drawing.Size(122, 23);
            this.btn_identify.TabIndex = 8;
            this.btn_identify.Text = "Identify";
            this.btn_identify.UseVisualStyleBackColor = true;
            this.btn_identify.Click += new System.EventHandler(this.btn_identify_Click);
            // 
            // btn_verify
            // 
            this.btn_verify.Location = new System.Drawing.Point(276, 32);
            this.btn_verify.Name = "btn_verify";
            this.btn_verify.Size = new System.Drawing.Size(122, 23);
            this.btn_verify.TabIndex = 9;
            this.btn_verify.Text = "Verify";
            this.btn_verify.UseVisualStyleBackColor = true;
            this.btn_verify.Click += new System.EventHandler(this.btn_verify_Click);
            // 
            // label_userID
            // 
            this.label_userID.AutoSize = true;
            this.label_userID.Location = new System.Drawing.Point(12, 91);
            this.label_userID.Name = "label_userID";
            this.label_userID.Size = new System.Drawing.Size(49, 13);
            this.label_userID.TabIndex = 10;
            this.label_userID.Text = "User ID :";
            // 
            // tb_userID
            // 
            this.tb_userID.Location = new System.Drawing.Point(71, 88);
            this.tb_userID.Name = "tb_userID";
            this.tb_userID.Size = new System.Drawing.Size(74, 20);
            this.tb_userID.TabIndex = 11;
            // 
            // btn_deleteTemplate
            // 
            this.btn_deleteTemplate.Location = new System.Drawing.Point(404, 32);
            this.btn_deleteTemplate.Name = "btn_deleteTemplate";
            this.btn_deleteTemplate.Size = new System.Drawing.Size(122, 23);
            this.btn_deleteTemplate.TabIndex = 12;
            this.btn_deleteTemplate.Text = "Delete Template";
            this.btn_deleteTemplate.UseVisualStyleBackColor = true;
            this.btn_deleteTemplate.Click += new System.EventHandler(this.btn_deleteTemplate_Click);
            // 
            // btn_deleteAll
            // 
            this.btn_deleteAll.Location = new System.Drawing.Point(20, 61);
            this.btn_deleteAll.Name = "btn_deleteAll";
            this.btn_deleteAll.Size = new System.Drawing.Size(122, 23);
            this.btn_deleteAll.TabIndex = 13;
            this.btn_deleteAll.Text = "Delete All";
            this.btn_deleteAll.UseVisualStyleBackColor = true;
            this.btn_deleteAll.Click += new System.EventHandler(this.btn_deleteAll_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_enroll);
            this.groupBox1.Controls.Add(this.btn_deleteAll);
            this.groupBox1.Controls.Add(this.btn_identify);
            this.groupBox1.Controls.Add(this.btn_deleteTemplate);
            this.groupBox1.Controls.Add(this.btn_verify);
            this.groupBox1.Location = new System.Drawing.Point(15, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(548, 102);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Basic function";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_enrollByTemplate);
            this.groupBox2.Location = new System.Drawing.Point(15, 241);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(548, 76);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Template Management";
            // 
            // btn_enrollByTemplate
            // 
            this.btn_enrollByTemplate.Location = new System.Drawing.Point(20, 32);
            this.btn_enrollByTemplate.Name = "btn_enrollByTemplate";
            this.btn_enrollByTemplate.Size = new System.Drawing.Size(122, 23);
            this.btn_enrollByTemplate.TabIndex = 7;
            this.btn_enrollByTemplate.Text = "Enroll by Template";
            this.btn_enrollByTemplate.UseVisualStyleBackColor = true;
            this.btn_enrollByTemplate.Click += new System.EventHandler(this.Btn_enrollByTemplate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 469);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tb_userID);
            this.Controls.Add(this.label_userID);
            this.Controls.Add(this.tb_message);
            this.Controls.Add(this.tb_baudrate);
            this.Controls.Add(this.tb_comPort);
            this.Controls.Add(this.label_baudrate);
            this.Controls.Add(this.label_comPort);
            this.Controls.Add(this.btn_disconnect);
            this.Controls.Add(this.btn_connect);
            this.Name = "Form1";
            this.Text = "WinFormSample";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Button btn_disconnect;
        private System.Windows.Forms.Label label_comPort;
        private System.Windows.Forms.Label label_baudrate;
        private System.Windows.Forms.TextBox tb_comPort;
        private System.Windows.Forms.TextBox tb_baudrate;
        private System.Windows.Forms.TextBox tb_message;
        private System.Windows.Forms.Button btn_enroll;
        private System.Windows.Forms.Button btn_identify;
        private System.Windows.Forms.Button btn_verify;
        private System.Windows.Forms.Label label_userID;
        private System.Windows.Forms.TextBox tb_userID;
        private System.Windows.Forms.Button btn_deleteTemplate;
        private System.Windows.Forms.Button btn_deleteAll;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_enrollByTemplate;
    }
}

