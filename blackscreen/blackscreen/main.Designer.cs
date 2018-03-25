﻿namespace blackscreen
{
    partial class main_screen
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.id_reader = new System.Windows.Forms.Timer(this.components);
            this.rfid_serial = new System.IO.Ports.SerialPort(this.components);
            this.student_id_label = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "프린터 사용 안내";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Noto Sans", 15F);
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(14, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Printer usage guide";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Noto Sans", 12F);
            this.label3.Location = new System.Drawing.Point(15, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(283, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "1. 학생회비 납부자만 인쇄 가능합니다.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Noto Sans", 10F);
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(33, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(244, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Only student dues payer can print.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Noto Sans", 10F);
            this.label5.ForeColor = System.Drawing.Color.LightGray;
            this.label5.Location = new System.Drawing.Point(33, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(704, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Please put your student ID card to RFID reader. You can use it while contacting y" +
    "our card to the reader.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Noto Sans", 12F);
            this.label6.Location = new System.Drawing.Point(15, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(571, 22);
            this.label6.TabIndex = 4;
            this.label6.Text = "2. 학생증을 리더기에 넣어주세요. 리더기에 들어가있는 동안 사용이 가능합니다";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Noto Sans", 10F);
            this.label7.ForeColor = System.Drawing.Color.LightGray;
            this.label7.Location = new System.Drawing.Point(33, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(597, 19);
            this.label7.TabIndex = 7;
            this.label7.Text = "If can not unlock the computer even though paid student dues, please contact the " +
    "staff";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Noto Sans", 12F);
            this.label8.Location = new System.Drawing.Point(15, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(555, 22);
            this.label8.TabIndex = 6;
            this.label8.Text = "3. 학생회비를 납부했는데도 잠금이 풀리지 않는 경우 당직에게 문의 바랍니다";
            // 
            // id_reader
            // 
            this.id_reader.Enabled = true;
            this.id_reader.Tick += new System.EventHandler(this.id_reader_Tick);
            // 
            // rfid_serial
            // 
            this.rfid_serial.PortName = "COM8";
            this.rfid_serial.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.rfid_serial_DataReceived);
            // 
            // student_id_label
            // 
            this.student_id_label.AutoSize = true;
            this.student_id_label.Font = new System.Drawing.Font("Noto Sans", 12F);
            this.student_id_label.Location = new System.Drawing.Point(15, 359);
            this.student_id_label.Name = "student_id_label";
            this.student_id_label.Size = new System.Drawing.Size(15, 22);
            this.student_id_label.TabIndex = 8;
            this.student_id_label.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Noto Sans", 10F);
            this.label9.ForeColor = System.Drawing.Color.LightGray;
            this.label9.Location = new System.Drawing.Point(33, 314);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(549, 19);
            this.label9.TabIndex = 10;
            this.label9.Text = "If program does not close even though successfully read, remove card and retry";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Noto Sans", 12F);
            this.label10.Location = new System.Drawing.Point(15, 292);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(771, 22);
            this.label10.TabIndex = 9;
            this.label10.Text = "4. 버그로 인해 카드 인식은 되지만 창이 안닫히는 경우가 있습니다. 이때는 카드를 뽑았다가 다시 넣어주세요";
            // 
            // main_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.ControlBox = false;
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.student_id_label);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "main_screen";
            this.ShowInTaskbar = false;
            this.Text = "usc dog printer screen";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.main_screen_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.main_screen_FormClosed);
            this.Load += new System.EventHandler(this.main_screen_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.main_screen_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer id_reader;
        private System.IO.Ports.SerialPort rfid_serial;
        private System.Windows.Forms.Label student_id_label;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

