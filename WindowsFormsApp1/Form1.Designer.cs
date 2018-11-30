namespace WindowsFormsApp1
{
    partial class Form_1
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.TOKEN = new System.Windows.Forms.ComboBox();
            this.execfile = new System.Windows.Forms.ComboBox();
            this.offline = new System.Windows.Forms.CheckBox();
            this.logbackup = new System.Windows.Forms.ComboBox();
            this.conf_dir = new System.Windows.Forms.ComboBox();
            this.R_S = new System.Windows.Forms.ComboBox();
            this.shard = new System.Windows.Forms.ComboBox();
            this.cluster = new System.Windows.Forms.ComboBox();
            this.start = new System.Windows.Forms.Button();
            this.TR = new System.Windows.Forms.TextBox();
            this.maxplayers = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TOKEN
            // 
            this.TOKEN.FormattingEnabled = true;
            this.TOKEN.Location = new System.Drawing.Point(86, 168);
            this.TOKEN.Name = "TOKEN";
            this.TOKEN.Size = new System.Drawing.Size(178, 20);
            this.TOKEN.TabIndex = 0;
            // 
            // execfile
            // 
            this.execfile.FormattingEnabled = true;
            this.execfile.Location = new System.Drawing.Point(86, 12);
            this.execfile.Name = "execfile";
            this.execfile.Size = new System.Drawing.Size(178, 20);
            this.execfile.TabIndex = 0;
            this.execfile.Text = ".\\dontstarve_dedicated_server_nullrenderer.exe";
            // 
            // offline
            // 
            this.offline.AutoSize = true;
            this.offline.Checked = true;
            this.offline.CheckState = System.Windows.Forms.CheckState.Checked;
            this.offline.Location = new System.Drawing.Point(26, 228);
            this.offline.Name = "offline";
            this.offline.Size = new System.Drawing.Size(96, 16);
            this.offline.TabIndex = 1;
            this.offline.Text = "勾上开本地服";
            this.offline.UseVisualStyleBackColor = true;
            // 
            // logbackup
            // 
            this.logbackup.FormattingEnabled = true;
            this.logbackup.Location = new System.Drawing.Point(86, 142);
            this.logbackup.Name = "logbackup";
            this.logbackup.Size = new System.Drawing.Size(178, 20);
            this.logbackup.TabIndex = 0;
            // 
            // conf_dir
            // 
            this.conf_dir.FormattingEnabled = true;
            this.conf_dir.Location = new System.Drawing.Point(86, 116);
            this.conf_dir.Name = "conf_dir";
            this.conf_dir.Size = new System.Drawing.Size(178, 20);
            this.conf_dir.TabIndex = 0;
            // 
            // R_S
            // 
            this.R_S.FormattingEnabled = true;
            this.R_S.Location = new System.Drawing.Point(86, 90);
            this.R_S.Name = "R_S";
            this.R_S.Size = new System.Drawing.Size(178, 20);
            this.R_S.TabIndex = 0;
            // 
            // shard
            // 
            this.shard.FormattingEnabled = true;
            this.shard.Location = new System.Drawing.Point(86, 38);
            this.shard.MaxDropDownItems = 1;
            this.shard.Name = "shard";
            this.shard.Size = new System.Drawing.Size(178, 20);
            this.shard.TabIndex = 0;
            this.shard.Text = "Master";
            // 
            // cluster
            // 
            this.cluster.FormattingEnabled = true;
            this.cluster.Location = new System.Drawing.Point(86, 64);
            this.cluster.MaxDropDownItems = 1;
            this.cluster.Name = "cluster";
            this.cluster.Size = new System.Drawing.Size(178, 20);
            this.cluster.TabIndex = 0;
            this.cluster.Text = "Cluster_1";
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(160, 224);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(104, 23);
            this.start.TabIndex = 2;
            this.start.Text = "启动";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.Start_Click);
            // 
            // TR
            // 
            this.TR.Location = new System.Drawing.Point(86, 194);
            this.TR.Name = "TR";
            this.TR.Size = new System.Drawing.Size(58, 21);
            this.TR.TabIndex = 3;
            this.TR.Text = "15";
            // 
            // maxplayers
            // 
            this.maxplayers.Location = new System.Drawing.Point(206, 195);
            this.maxplayers.Name = "maxplayers";
            this.maxplayers.Size = new System.Drawing.Size(58, 21);
            this.maxplayers.TabIndex = 4;
            this.maxplayers.Text = "4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "服务器程序\r\n    必填";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "Shard";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "存档";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "根储存";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "Conf_dir";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "日志备份文件";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 12);
            this.label7.TabIndex = 5;
            this.label7.Text = "Token";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 5;
            this.label8.Text = "TickRate";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(147, 198);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 5;
            this.label9.Text = "最大玩家";
            // 
            // Form_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 254);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maxplayers);
            this.Controls.Add(this.TR);
            this.Controls.Add(this.start);
            this.Controls.Add(this.offline);
            this.Controls.Add(this.cluster);
            this.Controls.Add(this.shard);
            this.Controls.Add(this.R_S);
            this.Controls.Add(this.conf_dir);
            this.Controls.Add(this.logbackup);
            this.Controls.Add(this.execfile);
            this.Controls.Add(this.TOKEN);
            this.Name = "Form_1";
            this.Text = "启动器";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox TOKEN;
        private System.Windows.Forms.ComboBox execfile;
        private System.Windows.Forms.CheckBox offline;
        private System.Windows.Forms.ComboBox logbackup;
        private System.Windows.Forms.ComboBox conf_dir;
        private System.Windows.Forms.ComboBox R_S;
        private System.Windows.Forms.ComboBox shard;
        private System.Windows.Forms.ComboBox cluster;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.TextBox TR;
        private System.Windows.Forms.TextBox maxplayers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

