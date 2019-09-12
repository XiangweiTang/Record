namespace SimpleRecorderUI
{
    partial class SimpleRecorder
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
            this.Label_Trans = new System.Windows.Forms.Label();
            this.Btn_Record = new System.Windows.Forms.Button();
            this.Combo_TransList = new System.Windows.Forms.ComboBox();
            this.TabPage_Main = new System.Windows.Forms.TabControl();
            this.TabPage_Record = new System.Windows.Forms.TabPage();
            this.Label_Info = new System.Windows.Forms.Label();
            this.TabPage_UserInfo = new System.Windows.Forms.TabPage();
            this.TextBox_UserDialect = new System.Windows.Forms.TextBox();
            this.ComboBox_UserGender = new System.Windows.Forms.ComboBox();
            this.TextBox_UserAge = new System.Windows.Forms.TextBox();
            this.TextBox_UserId = new System.Windows.Forms.TextBox();
            this.Label_UserDialect = new System.Windows.Forms.Label();
            this.Label_UserGender = new System.Windows.Forms.Label();
            this.Label_UserAge = new System.Windows.Forms.Label();
            this.Label_UserId = new System.Windows.Forms.Label();
            this.TabPage_Setting = new System.Windows.Forms.TabPage();
            this.Btn_ResetSetting = new System.Windows.Forms.Button();
            this.TextBox_WorkRootPath = new System.Windows.Forms.TextBox();
            this.TextBox_BitsPerSample = new System.Windows.Forms.TextBox();
            this.TextBox_Channel = new System.Windows.Forms.TextBox();
            this.TextBox_SampleRate = new System.Windows.Forms.TextBox();
            this.Label_WorkRootFolder = new System.Windows.Forms.Label();
            this.Label_BitsPerSample = new System.Windows.Forms.Label();
            this.Label_Channel = new System.Windows.Forms.Label();
            this.Label_SampleRate = new System.Windows.Forms.Label();
            this.Btn_RestUI = new System.Windows.Forms.Button();
            this.TabPage_Main.SuspendLayout();
            this.TabPage_Record.SuspendLayout();
            this.TabPage_UserInfo.SuspendLayout();
            this.TabPage_Setting.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label_Trans
            // 
            this.Label_Trans.BackColor = System.Drawing.SystemColors.Info;
            this.Label_Trans.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Trans.Location = new System.Drawing.Point(6, 47);
            this.Label_Trans.Name = "Label_Trans";
            this.Label_Trans.Size = new System.Drawing.Size(794, 185);
            this.Label_Trans.TabIndex = 0;
            // 
            // Btn_Record
            // 
            this.Btn_Record.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Record.Location = new System.Drawing.Point(659, 252);
            this.Btn_Record.Name = "Btn_Record";
            this.Btn_Record.Size = new System.Drawing.Size(141, 53);
            this.Btn_Record.TabIndex = 1;
            this.Btn_Record.Text = "开始录音";
            this.Btn_Record.UseVisualStyleBackColor = true;
            this.Btn_Record.Click += new System.EventHandler(this.Btn_Record_Click);
            // 
            // Combo_TransList
            // 
            this.Combo_TransList.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Combo_TransList.FormattingEnabled = true;
            this.Combo_TransList.Location = new System.Drawing.Point(11, 271);
            this.Combo_TransList.Name = "Combo_TransList";
            this.Combo_TransList.Size = new System.Drawing.Size(626, 27);
            this.Combo_TransList.TabIndex = 7;
            this.Combo_TransList.SelectedIndexChanged += new System.EventHandler(this.Combo_TransList_SelectedIndexChanged);
            // 
            // TabPage_Main
            // 
            this.TabPage_Main.Controls.Add(this.TabPage_Record);
            this.TabPage_Main.Controls.Add(this.TabPage_UserInfo);
            this.TabPage_Main.Controls.Add(this.TabPage_Setting);
            this.TabPage_Main.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TabPage_Main.Location = new System.Drawing.Point(10, 19);
            this.TabPage_Main.Name = "TabPage_Main";
            this.TabPage_Main.SelectedIndex = 0;
            this.TabPage_Main.Size = new System.Drawing.Size(846, 367);
            this.TabPage_Main.TabIndex = 8;
            // 
            // TabPage_Record
            // 
            this.TabPage_Record.BackColor = System.Drawing.SystemColors.Control;
            this.TabPage_Record.Controls.Add(this.Btn_Record);
            this.TabPage_Record.Controls.Add(this.Combo_TransList);
            this.TabPage_Record.Controls.Add(this.Label_Info);
            this.TabPage_Record.Controls.Add(this.Label_Trans);
            this.TabPage_Record.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TabPage_Record.Location = new System.Drawing.Point(4, 30);
            this.TabPage_Record.Name = "TabPage_Record";
            this.TabPage_Record.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_Record.Size = new System.Drawing.Size(838, 333);
            this.TabPage_Record.TabIndex = 0;
            this.TabPage_Record.Text = "录音";
            // 
            // Label_Info
            // 
            this.Label_Info.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Info.Location = new System.Drawing.Point(7, 16);
            this.Label_Info.Name = "Label_Info";
            this.Label_Info.Size = new System.Drawing.Size(196, 21);
            this.Label_Info.TabIndex = 2;
            this.Label_Info.Text = "当前进度： ";
            // 
            // TabPage_UserInfo
            // 
            this.TabPage_UserInfo.BackColor = System.Drawing.SystemColors.Control;
            this.TabPage_UserInfo.Controls.Add(this.Btn_RestUI);
            this.TabPage_UserInfo.Controls.Add(this.TextBox_UserDialect);
            this.TabPage_UserInfo.Controls.Add(this.ComboBox_UserGender);
            this.TabPage_UserInfo.Controls.Add(this.TextBox_UserAge);
            this.TabPage_UserInfo.Controls.Add(this.TextBox_UserId);
            this.TabPage_UserInfo.Controls.Add(this.Label_UserDialect);
            this.TabPage_UserInfo.Controls.Add(this.Label_UserGender);
            this.TabPage_UserInfo.Controls.Add(this.Label_UserAge);
            this.TabPage_UserInfo.Controls.Add(this.Label_UserId);
            this.TabPage_UserInfo.Location = new System.Drawing.Point(4, 30);
            this.TabPage_UserInfo.Name = "TabPage_UserInfo";
            this.TabPage_UserInfo.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_UserInfo.Size = new System.Drawing.Size(838, 333);
            this.TabPage_UserInfo.TabIndex = 1;
            this.TabPage_UserInfo.Text = "用户";
            this.TabPage_UserInfo.Leave += new System.EventHandler(this.TabPage_UserInfo_Leave);
            // 
            // TextBox_UserDialect
            // 
            this.TextBox_UserDialect.Location = new System.Drawing.Point(88, 139);
            this.TextBox_UserDialect.Name = "TextBox_UserDialect";
            this.TextBox_UserDialect.Size = new System.Drawing.Size(100, 29);
            this.TextBox_UserDialect.TabIndex = 7;
            this.TextBox_UserDialect.Text = "普通话";
            // 
            // ComboBox_UserGender
            // 
            this.ComboBox_UserGender.FormattingEnabled = true;
            this.ComboBox_UserGender.Location = new System.Drawing.Point(88, 98);
            this.ComboBox_UserGender.Name = "ComboBox_UserGender";
            this.ComboBox_UserGender.Size = new System.Drawing.Size(100, 29);
            this.ComboBox_UserGender.TabIndex = 6;
            this.ComboBox_UserGender.Text = "男";
            // 
            // TextBox_UserAge
            // 
            this.TextBox_UserAge.Location = new System.Drawing.Point(88, 56);
            this.TextBox_UserAge.Name = "TextBox_UserAge";
            this.TextBox_UserAge.Size = new System.Drawing.Size(100, 29);
            this.TextBox_UserAge.TabIndex = 5;
            this.TextBox_UserAge.Text = "20";
            // 
            // TextBox_UserId
            // 
            this.TextBox_UserId.Location = new System.Drawing.Point(88, 12);
            this.TextBox_UserId.Name = "TextBox_UserId";
            this.TextBox_UserId.Size = new System.Drawing.Size(100, 29);
            this.TextBox_UserId.TabIndex = 4;
            this.TextBox_UserId.Text = "1";
            // 
            // Label_UserDialect
            // 
            this.Label_UserDialect.AutoSize = true;
            this.Label_UserDialect.Location = new System.Drawing.Point(7, 140);
            this.Label_UserDialect.Name = "Label_UserDialect";
            this.Label_UserDialect.Size = new System.Drawing.Size(74, 21);
            this.Label_UserDialect.TabIndex = 3;
            this.Label_UserDialect.Text = "用户方言";
            // 
            // Label_UserGender
            // 
            this.Label_UserGender.AutoSize = true;
            this.Label_UserGender.Location = new System.Drawing.Point(7, 98);
            this.Label_UserGender.Name = "Label_UserGender";
            this.Label_UserGender.Size = new System.Drawing.Size(74, 21);
            this.Label_UserGender.TabIndex = 2;
            this.Label_UserGender.Text = "用户性别";
            // 
            // Label_UserAge
            // 
            this.Label_UserAge.AutoSize = true;
            this.Label_UserAge.Location = new System.Drawing.Point(7, 56);
            this.Label_UserAge.Name = "Label_UserAge";
            this.Label_UserAge.Size = new System.Drawing.Size(74, 21);
            this.Label_UserAge.TabIndex = 1;
            this.Label_UserAge.Text = "用户年龄";
            // 
            // Label_UserId
            // 
            this.Label_UserId.AutoSize = true;
            this.Label_UserId.Location = new System.Drawing.Point(7, 13);
            this.Label_UserId.Name = "Label_UserId";
            this.Label_UserId.Size = new System.Drawing.Size(74, 21);
            this.Label_UserId.TabIndex = 0;
            this.Label_UserId.Text = "用户编号";
            // 
            // TabPage_Setting
            // 
            this.TabPage_Setting.BackColor = System.Drawing.SystemColors.Control;
            this.TabPage_Setting.Controls.Add(this.Btn_ResetSetting);
            this.TabPage_Setting.Controls.Add(this.TextBox_WorkRootPath);
            this.TabPage_Setting.Controls.Add(this.TextBox_BitsPerSample);
            this.TabPage_Setting.Controls.Add(this.TextBox_Channel);
            this.TabPage_Setting.Controls.Add(this.TextBox_SampleRate);
            this.TabPage_Setting.Controls.Add(this.Label_WorkRootFolder);
            this.TabPage_Setting.Controls.Add(this.Label_BitsPerSample);
            this.TabPage_Setting.Controls.Add(this.Label_Channel);
            this.TabPage_Setting.Controls.Add(this.Label_SampleRate);
            this.TabPage_Setting.Location = new System.Drawing.Point(4, 30);
            this.TabPage_Setting.Name = "TabPage_Setting";
            this.TabPage_Setting.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_Setting.Size = new System.Drawing.Size(838, 333);
            this.TabPage_Setting.TabIndex = 2;
            this.TabPage_Setting.Text = "设置";
            this.TabPage_Setting.Leave += new System.EventHandler(this.TabPage_Setting_Leave);
            // 
            // Btn_ResetSetting
            // 
            this.Btn_ResetSetting.Location = new System.Drawing.Point(23, 255);
            this.Btn_ResetSetting.Name = "Btn_ResetSetting";
            this.Btn_ResetSetting.Size = new System.Drawing.Size(114, 43);
            this.Btn_ResetSetting.TabIndex = 11;
            this.Btn_ResetSetting.Text = "Reset";
            this.Btn_ResetSetting.UseVisualStyleBackColor = true;
            this.Btn_ResetSetting.Click += new System.EventHandler(this.Btn_ResetSetting_Click);
            // 
            // TextBox_WorkRootPath
            // 
            this.TextBox_WorkRootPath.Location = new System.Drawing.Point(172, 132);
            this.TextBox_WorkRootPath.Name = "TextBox_WorkRootPath";
            this.TextBox_WorkRootPath.Size = new System.Drawing.Size(506, 29);
            this.TextBox_WorkRootPath.TabIndex = 9;
            this.TextBox_WorkRootPath.Text = "d:\\tmp\\work";
            // 
            // TextBox_BitsPerSample
            // 
            this.TextBox_BitsPerSample.Location = new System.Drawing.Point(172, 90);
            this.TextBox_BitsPerSample.Name = "TextBox_BitsPerSample";
            this.TextBox_BitsPerSample.Size = new System.Drawing.Size(100, 29);
            this.TextBox_BitsPerSample.TabIndex = 8;
            this.TextBox_BitsPerSample.Text = "16";
            // 
            // TextBox_Channel
            // 
            this.TextBox_Channel.Location = new System.Drawing.Point(172, 55);
            this.TextBox_Channel.Name = "TextBox_Channel";
            this.TextBox_Channel.Size = new System.Drawing.Size(100, 29);
            this.TextBox_Channel.TabIndex = 7;
            this.TextBox_Channel.Text = "1";
            // 
            // TextBox_SampleRate
            // 
            this.TextBox_SampleRate.Location = new System.Drawing.Point(172, 19);
            this.TextBox_SampleRate.Name = "TextBox_SampleRate";
            this.TextBox_SampleRate.Size = new System.Drawing.Size(100, 29);
            this.TextBox_SampleRate.TabIndex = 6;
            this.TextBox_SampleRate.Text = "16000";
            // 
            // Label_WorkRootFolder
            // 
            this.Label_WorkRootFolder.AutoSize = true;
            this.Label_WorkRootFolder.Location = new System.Drawing.Point(19, 132);
            this.Label_WorkRootFolder.Name = "Label_WorkRootFolder";
            this.Label_WorkRootFolder.Size = new System.Drawing.Size(99, 21);
            this.Label_WorkRootFolder.TabIndex = 4;
            this.Label_WorkRootFolder.Text = "WorkFolder";
            // 
            // Label_BitsPerSample
            // 
            this.Label_BitsPerSample.AutoSize = true;
            this.Label_BitsPerSample.Location = new System.Drawing.Point(19, 95);
            this.Label_BitsPerSample.Name = "Label_BitsPerSample";
            this.Label_BitsPerSample.Size = new System.Drawing.Size(118, 21);
            this.Label_BitsPerSample.TabIndex = 3;
            this.Label_BitsPerSample.Text = "BitsPerSample";
            // 
            // Label_Channel
            // 
            this.Label_Channel.AutoSize = true;
            this.Label_Channel.Location = new System.Drawing.Point(19, 55);
            this.Label_Channel.Name = "Label_Channel";
            this.Label_Channel.Size = new System.Drawing.Size(73, 21);
            this.Label_Channel.TabIndex = 2;
            this.Label_Channel.Text = "Channel";
            // 
            // Label_SampleRate
            // 
            this.Label_SampleRate.AutoSize = true;
            this.Label_SampleRate.Location = new System.Drawing.Point(19, 19);
            this.Label_SampleRate.Name = "Label_SampleRate";
            this.Label_SampleRate.Size = new System.Drawing.Size(100, 21);
            this.Label_SampleRate.TabIndex = 1;
            this.Label_SampleRate.Text = "SampleRate";
            // 
            // Btn_RestUI
            // 
            this.Btn_RestUI.Location = new System.Drawing.Point(11, 265);
            this.Btn_RestUI.Name = "Btn_RestUI";
            this.Btn_RestUI.Size = new System.Drawing.Size(114, 43);
            this.Btn_RestUI.TabIndex = 12;
            this.Btn_RestUI.Text = "Reset";
            this.Btn_RestUI.UseVisualStyleBackColor = true;
            this.Btn_RestUI.Click += new System.EventHandler(this.Btn_RestUI_Click);
            // 
            // SimpleRecorder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 414);
            this.Controls.Add(this.TabPage_Main);
            this.MaximizeBox = false;
            this.Name = "SimpleRecorder";
            this.Text = "SimpleRecorder";
            this.TabPage_Main.ResumeLayout(false);
            this.TabPage_Record.ResumeLayout(false);
            this.TabPage_UserInfo.ResumeLayout(false);
            this.TabPage_UserInfo.PerformLayout();
            this.TabPage_Setting.ResumeLayout(false);
            this.TabPage_Setting.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Label_Trans;
        private System.Windows.Forms.Button Btn_Record;
        private System.Windows.Forms.ComboBox Combo_TransList;
        private System.Windows.Forms.TabControl TabPage_Main;
        private System.Windows.Forms.TabPage TabPage_Record;
        private System.Windows.Forms.TabPage TabPage_UserInfo;
        private System.Windows.Forms.Label Label_Info;
        private System.Windows.Forms.TabPage TabPage_Setting;
        private System.Windows.Forms.TextBox TextBox_UserDialect;
        private System.Windows.Forms.ComboBox ComboBox_UserGender;
        private System.Windows.Forms.TextBox TextBox_UserAge;
        private System.Windows.Forms.TextBox TextBox_UserId;
        private System.Windows.Forms.Label Label_UserDialect;
        private System.Windows.Forms.Label Label_UserGender;
        private System.Windows.Forms.Label Label_UserAge;
        private System.Windows.Forms.Label Label_UserId;
        private System.Windows.Forms.Label Label_BitsPerSample;
        private System.Windows.Forms.Label Label_Channel;
        private System.Windows.Forms.Label Label_SampleRate;
        private System.Windows.Forms.Button Btn_ResetSetting;
        private System.Windows.Forms.TextBox TextBox_WorkRootPath;
        private System.Windows.Forms.TextBox TextBox_BitsPerSample;
        private System.Windows.Forms.TextBox TextBox_Channel;
        private System.Windows.Forms.TextBox TextBox_SampleRate;
        private System.Windows.Forms.Label Label_WorkRootFolder;
        private System.Windows.Forms.Button Btn_RestUI;
    }
}

