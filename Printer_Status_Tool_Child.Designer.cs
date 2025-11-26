namespace Printer_Status_Tool_MDI
{
    partial class Printer_Status_Tool_Child
    {
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
            K_Toner = new ProgressBar();
            M_Toner = new ProgressBar();
            Y_Toner = new ProgressBar();
            C_Toner = new ProgressBar();
            K_Toner_TXT = new Label();
            Y_Toner_TXT = new Label();
            M_Toner_TXT = new Label();
            C_Toner_TXT = new Label();
            System_Last_Update_Time = new Label();
            Useful_Name = new Label();
            Total_Page_Count = new Label();
            Printer_Status = new Label();
            Paper = new Label();
            Paper_Tray_1 = new Label();
            Paper_Tray_MP = new Label();
            Paper_Tray_3 = new Label();
            Paper_Tray_2 = new Label();
            Paper_Tray_4 = new Label();
            Paper_Tray_8 = new Label();
            Paper_Tray_6 = new Label();
            Paper_Tray_7 = new Label();
            Paper_Tray_5 = new Label();
            Paper_Tray_9 = new Label();
            sys_sn = new Label();
            sys_ip = new Label();
            SuspendLayout();
            // 
            // K_Toner
            // 
            K_Toner.Location = new Point(2, 27);
            K_Toner.Name = "K_Toner";
            K_Toner.Size = new Size(300, 25);
            K_Toner.TabIndex = 0;
            K_Toner.Click += K_Toner_Click;
            // 
            // M_Toner
            // 
            M_Toner.Location = new Point(2, 89);
            M_Toner.Name = "M_Toner";
            M_Toner.Size = new Size(300, 25);
            M_Toner.TabIndex = 1;
            // 
            // Y_Toner
            // 
            Y_Toner.Location = new Point(2, 120);
            Y_Toner.Name = "Y_Toner";
            Y_Toner.Size = new Size(300, 25);
            Y_Toner.TabIndex = 2;
            // 
            // C_Toner
            // 
            C_Toner.Location = new Point(2, 58);
            C_Toner.Name = "C_Toner";
            C_Toner.Size = new Size(300, 25);
            C_Toner.TabIndex = 3;
            // 
            // K_Toner_TXT
            // 
            K_Toner_TXT.AutoSize = true;
            K_Toner_TXT.Font = new Font("Arial", 12F);
            K_Toner_TXT.Location = new Point(100, 30);
            K_Toner_TXT.Name = "K_Toner_TXT";
            K_Toner_TXT.Size = new Size(104, 18);
            K_Toner_TXT.TabIndex = 4;
            K_Toner_TXT.Text = "K_Toner_TXT";
            // 
            // Y_Toner_TXT
            // 
            Y_Toner_TXT.AutoSize = true;
            Y_Toner_TXT.BackColor = Color.Transparent;
            Y_Toner_TXT.Font = new Font("Arial", 12F);
            Y_Toner_TXT.Location = new Point(100, 123);
            Y_Toner_TXT.Name = "Y_Toner_TXT";
            Y_Toner_TXT.Size = new Size(102, 18);
            Y_Toner_TXT.TabIndex = 5;
            Y_Toner_TXT.Text = "Y_Toner_TXT";
            // 
            // M_Toner_TXT
            // 
            M_Toner_TXT.AutoSize = true;
            M_Toner_TXT.Font = new Font("Arial", 12F);
            M_Toner_TXT.Location = new Point(100, 92);
            M_Toner_TXT.Name = "M_Toner_TXT";
            M_Toner_TXT.Size = new Size(106, 18);
            M_Toner_TXT.TabIndex = 6;
            M_Toner_TXT.Text = "M_Toner_TXT";
            // 
            // C_Toner_TXT
            // 
            C_Toner_TXT.AutoSize = true;
            C_Toner_TXT.Font = new Font("Arial", 12F);
            C_Toner_TXT.Location = new Point(100, 61);
            C_Toner_TXT.Name = "C_Toner_TXT";
            C_Toner_TXT.Size = new Size(105, 18);
            C_Toner_TXT.TabIndex = 7;
            C_Toner_TXT.Text = "C_Toner_TXT";
            C_Toner_TXT.Click += label3_Click;
            // 
            // System_Last_Update_Time
            // 
            System_Last_Update_Time.AutoSize = true;
            System_Last_Update_Time.Font = new Font("Arial", 6F, FontStyle.Bold);
            System_Last_Update_Time.Location = new Point(2, 260);
            System_Last_Update_Time.Name = "System_Last_Update_Time";
            System_Last_Update_Time.Size = new Size(70, 10);
            System_Last_Update_Time.TabIndex = 8;
            System_Last_Update_Time.Text = "Last Update Time";
            // 
            // Useful_Name
            // 
            Useful_Name.AutoSize = true;
            Useful_Name.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Useful_Name.Location = new Point(2, 9);
            Useful_Name.Name = "Useful_Name";
            Useful_Name.Size = new Size(121, 15);
            Useful_Name.TabIndex = 9;
            Useful_Name.Text = "xxx.xxx (Warming UP)";
            // 
            // Total_Page_Count
            // 
            Total_Page_Count.AutoSize = true;
            Total_Page_Count.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Total_Page_Count.Location = new Point(183, 9);
            Total_Page_Count.Name = "Total_Page_Count";
            Total_Page_Count.Size = new Size(119, 14);
            Total_Page_Count.TabIndex = 10;
            Total_Page_Count.Text = "Page Count xxxxxxxxx";
            Total_Page_Count.TextAlign = ContentAlignment.TopRight;
            // 
            // Printer_Status
            // 
            Printer_Status.AutoSize = true;
            Printer_Status.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Printer_Status.Location = new Point(2, 150);
            Printer_Status.Name = "Printer_Status";
            Printer_Status.Size = new Size(135, 16);
            Printer_Status.TabIndex = 11;
            Printer_Status.Text = "Printer Status: Sleepy";
            // 
            // Paper
            // 
            Paper.AutoSize = true;
            Paper.Font = new Font("Arial", 9F);
            Paper.Location = new Point(2, 178);
            Paper.Name = "Paper";
            Paper.Size = new Size(43, 15);
            Paper.TabIndex = 12;
            Paper.Text = "Paper:";
            // 
            // Paper_Tray_1
            // 
            Paper_Tray_1.AutoSize = true;
            Paper_Tray_1.Font = new Font("Arial", 9F);
            Paper_Tray_1.Location = new Point(66, 178);
            Paper_Tray_1.Name = "Paper_Tray_1";
            Paper_Tray_1.Size = new Size(99, 15);
            Paper_Tray_1.TabIndex = 13;
            Paper_Tray_1.Text = "Tray 1 (A4): XXXX";
            // 
            // Paper_Tray_MP
            // 
            Paper_Tray_MP.AutoSize = true;
            Paper_Tray_MP.Font = new Font("Arial", 9F);
            Paper_Tray_MP.Location = new Point(188, 238);
            Paper_Tray_MP.Name = "Paper_Tray_MP";
            Paper_Tray_MP.Size = new Size(76, 15);
            Paper_Tray_MP.TabIndex = 14;
            Paper_Tray_MP.Text = "MP Tray: xxxx";
            // 
            // Paper_Tray_3
            // 
            Paper_Tray_3.AutoSize = true;
            Paper_Tray_3.Font = new Font("Arial", 9F);
            Paper_Tray_3.Location = new Point(66, 208);
            Paper_Tray_3.Name = "Paper_Tray_3";
            Paper_Tray_3.Size = new Size(99, 15);
            Paper_Tray_3.TabIndex = 15;
            Paper_Tray_3.Text = "Tray 3 (A4): XXXX";
            // 
            // Paper_Tray_2
            // 
            Paper_Tray_2.AutoSize = true;
            Paper_Tray_2.Font = new Font("Arial", 9F);
            Paper_Tray_2.Location = new Point(66, 193);
            Paper_Tray_2.Name = "Paper_Tray_2";
            Paper_Tray_2.Size = new Size(99, 15);
            Paper_Tray_2.TabIndex = 16;
            Paper_Tray_2.Text = "Tray 2 (A3): XXXX";
            // 
            // Paper_Tray_4
            // 
            Paper_Tray_4.AutoSize = true;
            Paper_Tray_4.Font = new Font("Arial", 9F);
            Paper_Tray_4.Location = new Point(66, 223);
            Paper_Tray_4.Name = "Paper_Tray_4";
            Paper_Tray_4.Size = new Size(99, 15);
            Paper_Tray_4.TabIndex = 17;
            Paper_Tray_4.Text = "Tray 4 (A4): XXXX";
            // 
            // Paper_Tray_8
            // 
            Paper_Tray_8.AutoSize = true;
            Paper_Tray_8.Font = new Font("Arial", 9F);
            Paper_Tray_8.Location = new Point(188, 208);
            Paper_Tray_8.Name = "Paper_Tray_8";
            Paper_Tray_8.Size = new Size(74, 15);
            Paper_Tray_8.TabIndex = 21;
            Paper_Tray_8.Text = "Tray 8: XXXX";
            // 
            // Paper_Tray_6
            // 
            Paper_Tray_6.AutoSize = true;
            Paper_Tray_6.Font = new Font("Arial", 9F);
            Paper_Tray_6.Location = new Point(188, 178);
            Paper_Tray_6.Name = "Paper_Tray_6";
            Paper_Tray_6.Size = new Size(74, 15);
            Paper_Tray_6.TabIndex = 20;
            Paper_Tray_6.Text = "Tray 6: XXXX";
            // 
            // Paper_Tray_7
            // 
            Paper_Tray_7.AutoSize = true;
            Paper_Tray_7.Font = new Font("Arial", 9F);
            Paper_Tray_7.Location = new Point(188, 193);
            Paper_Tray_7.Name = "Paper_Tray_7";
            Paper_Tray_7.Size = new Size(74, 15);
            Paper_Tray_7.TabIndex = 19;
            Paper_Tray_7.Text = "Tray 7: XXXX";
            // 
            // Paper_Tray_5
            // 
            Paper_Tray_5.AutoSize = true;
            Paper_Tray_5.Font = new Font("Arial", 9F);
            Paper_Tray_5.Location = new Point(66, 238);
            Paper_Tray_5.Name = "Paper_Tray_5";
            Paper_Tray_5.Size = new Size(74, 15);
            Paper_Tray_5.TabIndex = 18;
            Paper_Tray_5.Text = "Tray 5: XXXX";
            // 
            // Paper_Tray_9
            // 
            Paper_Tray_9.AutoSize = true;
            Paper_Tray_9.Font = new Font("Arial", 9F);
            Paper_Tray_9.Location = new Point(188, 223);
            Paper_Tray_9.Name = "Paper_Tray_9";
            Paper_Tray_9.Size = new Size(74, 15);
            Paper_Tray_9.TabIndex = 22;
            Paper_Tray_9.Text = "Tray 9: XXXX";
            // 
            // sys_sn
            // 
            sys_sn.AutoSize = true;
            sys_sn.Font = new Font("Arial", 6F, FontStyle.Bold);
            sys_sn.Location = new Point(221, 260);
            sys_sn.Name = "sys_sn";
            sys_sn.Size = new Size(81, 10);
            sys_sn.TabIndex = 23;
            sys_sn.Text = "SN: XXXXXXXXXXXX";
            sys_sn.TextAlign = ContentAlignment.TopRight;
            // 
            // sys_ip
            // 
            sys_ip.AutoSize = true;
            sys_ip.Font = new Font("Arial", 6F, FontStyle.Bold);
            sys_ip.Location = new Point(109, 260);
            sys_ip.Name = "sys_ip";
            sys_ip.Size = new Size(76, 10);
            sys_ip.TabIndex = 24;
            sys_ip.Text = "IP: 10.XXX.XXX.XXX";
            sys_ip.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Printer_Status_Tool_Child
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(304, 271);
            ControlBox = false;
            Controls.Add(sys_ip);
            Controls.Add(sys_sn);
            Controls.Add(Paper_Tray_9);
            Controls.Add(Paper_Tray_8);
            Controls.Add(Paper_Tray_6);
            Controls.Add(Paper_Tray_7);
            Controls.Add(Paper_Tray_5);
            Controls.Add(Paper_Tray_4);
            Controls.Add(Paper_Tray_2);
            Controls.Add(Paper_Tray_3);
            Controls.Add(Paper_Tray_MP);
            Controls.Add(Paper_Tray_1);
            Controls.Add(Paper);
            Controls.Add(Printer_Status);
            Controls.Add(Total_Page_Count);
            Controls.Add(Useful_Name);
            Controls.Add(System_Last_Update_Time);
            Controls.Add(C_Toner_TXT);
            Controls.Add(M_Toner_TXT);
            Controls.Add(Y_Toner_TXT);
            Controls.Add(K_Toner_TXT);
            Controls.Add(C_Toner);
            Controls.Add(Y_Toner);
            Controls.Add(M_Toner);
            Controls.Add(K_Toner);
            MaximizeBox = false;
            MaximumSize = new Size(320, 310);
            MinimizeBox = false;
            MinimumSize = new Size(320, 310);
            Name = "Printer_Status_Tool_Child";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Printer_Status_Tool_Child";
            Load += Printer_Status_Tool_Child_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar K_Toner;
        private ProgressBar M_Toner;
        private ProgressBar Y_Toner;
        private ProgressBar C_Toner;
        private Label K_Toner_TXT;
        private Label Y_Toner_TXT;
        private Label M_Toner_TXT;
        private Label C_Toner_TXT;
        private Label System_Last_Update_Time;
        private Label Useful_Name;
        private Label Total_Page_Count;
        private Label Printer_Status;
        private Label Paper;
        private Label Paper_Tray_1;
        private Label Paper_Tray_MP;
        private Label Paper_Tray_3;
        private Label Paper_Tray_2;
        private Label Paper_Tray_4;
        private Label Paper_Tray_8;
        private Label Paper_Tray_6;
        private Label Paper_Tray_7;
        private Label Paper_Tray_5;
        private Label Paper_Tray_9;
        private Label sys_sn;
        private Label sys_ip;
    }
}