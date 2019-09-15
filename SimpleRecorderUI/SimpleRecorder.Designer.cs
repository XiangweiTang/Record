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
            this.Label_Recording = new System.Windows.Forms.Label();
            this.Label_Info = new System.Windows.Forms.Label();
            this.TabPage_UserInfo = new System.Windows.Forms.TabPage();
            this.Btn_ResetUI = new System.Windows.Forms.Button();
            this.TextBox_UserDialect = new System.Windows.Forms.TextBox();
            this.ComboBox_UserGender = new System.Windows.Forms.ComboBox();
            this.TextBox_UserAge = new System.Windows.Forms.TextBox();
            this.TextBox_UserId = new System.Windows.Forms.TextBox();
            this.Label_UserDialect = new System.Windows.Forms.Label();
            this.Label_UserGender = new System.Windows.Forms.Label();
            this.Label_UserAge = new System.Windows.Forms.Label();
            this.Label_UserId = new System.Windows.Forms.Label();
            this.TabPage_Setting = new System.Windows.Forms.TabPage();
            this.Btn_SetWorkRootPath = new System.Windows.Forms.Button();
            this.Btn_SetTransPath = new System.Windows.Forms.Button();
            this.TextBox_TransPath = new System.Windows.Forms.TextBox();
            this.Label_TransPath = new System.Windows.Forms.Label();
            this.Btn_ResetSetting = new System.Windows.Forms.Button();
            this.TextBox_WorkRootPath = new System.Windows.Forms.TextBox();
            this.TextBox_BitsPerSample = new System.Windows.Forms.TextBox();
            this.TextBox_Channel = new System.Windows.Forms.TextBox();
            this.TextBox_SampleRate = new System.Windows.Forms.TextBox();
            this.Label_WorkRootFolder = new System.Windows.Forms.Label();
            this.Label_BitsPerSample = new System.Windows.Forms.Label();
            this.Label_Channel = new System.Windows.Forms.Label();
            this.Label_SampleRate = new System.Windows.Forms.Label();
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
            this.Label_Trans.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Label_Trans.Location = new System.Drawing.Point(10, 50);
            this.Label_Trans.Name = "Label_Trans";
            this.Label_Trans.Size = new System.Drawing.Size(800, 180);
            this.Label_Trans.TabIndex = 0;
            // 
            // Btn_Record
            // 
            this.Btn_Record.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Record.Location = new System.Drawing.Point(670, 250);
            this.Btn_Record.Name = "Btn_Record";
            this.Btn_Record.Size = new System.Drawing.Size(140, 50);
            this.Btn_Record.TabIndex = 1;
            this.Btn_Record.Text = "开始录音";
            this.Btn_Record.UseVisualStyleBackColor = true;
            this.Btn_Record.Click += new System.EventHandler(this.Btn_Record_Click);
            // 
            // Combo_TransList
            // 
            this.Combo_TransList.DropDownHeight = 300;
            this.Combo_TransList.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Combo_TransList.FormattingEnabled = true;
            this.Combo_TransList.IntegralHeight = false;
            this.Combo_TransList.Location = new System.Drawing.Point(10, 260);
            this.Combo_TransList.Name = "Combo_TransList";
            this.Combo_TransList.Size = new System.Drawing.Size(625, 27);
            this.Combo_TransList.TabIndex = 7;
            this.Combo_TransList.SelectedIndexChanged += new System.EventHandler(this.Combo_TransList_SelectedIndexChanged);
            // 
            // TabPage_Main
            // 
            this.TabPage_Main.Controls.Add(this.TabPage_Record);
            this.TabPage_Main.Controls.Add(this.TabPage_UserInfo);
            this.TabPage_Main.Controls.Add(this.TabPage_Setting);
            this.TabPage_Main.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TabPage_Main.Location = new System.Drawing.Point(10, 20);
            this.TabPage_Main.Name = "TabPage_Main";
            this.TabPage_Main.SelectedIndex = 0;
            this.TabPage_Main.Size = new System.Drawing.Size(840, 360);
            this.TabPage_Main.TabIndex = 8;
            // 
            // TabPage_Record
            // 
            this.TabPage_Record.BackColor = System.Drawing.SystemColors.Control;
            this.TabPage_Record.Controls.Add(this.Label_Recording);
            this.TabPage_Record.Controls.Add(this.Btn_Record);
            this.TabPage_Record.Controls.Add(this.Combo_TransList);
            this.TabPage_Record.Controls.Add(this.Label_Info);
            this.TabPage_Record.Controls.Add(this.Label_Trans);
            this.TabPage_Record.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TabPage_Record.Location = new System.Drawing.Point(4, 30);
            this.TabPage_Record.Name = "TabPage_Record";
            this.TabPage_Record.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_Record.Size = new System.Drawing.Size(832, 326);
            this.TabPage_Record.TabIndex = 0;
            this.TabPage_Record.Text = "录音";
            // 
            // Label_Recording
            // 
            this.Label_Recording.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Recording.ForeColor = System.Drawing.Color.Green;
            this.Label_Recording.Location = new System.Drawing.Point(690, 15);
            this.Label_Recording.Name = "Label_Recording";
            this.Label_Recording.Size = new System.Drawing.Size(120, 25);
            this.Label_Recording.TabIndex = 8;
            this.Label_Recording.Text = "未在录音";
            this.Label_Recording.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Info
            // 
            this.Label_Info.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Info.Location = new System.Drawing.Point(5, 15);
            this.Label_Info.Name = "Label_Info";
            this.Label_Info.Size = new System.Drawing.Size(200, 25);
            this.Label_Info.TabIndex = 2;
            this.Label_Info.Text = "当前进度： ";
            this.Label_Info.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TabPage_UserInfo
            // 
            this.TabPage_UserInfo.BackColor = System.Drawing.SystemColors.Control;
            this.TabPage_UserInfo.Controls.Add(this.Btn_ResetUI);
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
            this.TabPage_UserInfo.Size = new System.Drawing.Size(832, 326);
            this.TabPage_UserInfo.TabIndex = 1;
            this.TabPage_UserInfo.Text = "用户";
            // 
            // Btn_ResetUI
            // 
            this.Btn_ResetUI.Location = new System.Drawing.Point(20, 260);
            this.Btn_ResetUI.Name = "Btn_ResetUI";
            this.Btn_ResetUI.Size = new System.Drawing.Size(120, 40);
            this.Btn_ResetUI.TabIndex = 12;
            this.Btn_ResetUI.Text = "设置";
            this.Btn_ResetUI.UseVisualStyleBackColor = true;
            this.Btn_ResetUI.Click += new System.EventHandler(this.Btn_ResetUI_Click);
            // 
            // TextBox_UserDialect
            // 
            this.TextBox_UserDialect.Location = new System.Drawing.Point(180, 140);
            this.TextBox_UserDialect.Name = "TextBox_UserDialect";
            this.TextBox_UserDialect.Size = new System.Drawing.Size(100, 29);
            this.TextBox_UserDialect.TabIndex = 7;
            this.TextBox_UserDialect.Text = "普通话";
            // 
            // ComboBox_UserGender
            // 
            this.ComboBox_UserGender.FormattingEnabled = true;
            this.ComboBox_UserGender.Location = new System.Drawing.Point(180, 100);
            this.ComboBox_UserGender.Name = "ComboBox_UserGender";
            this.ComboBox_UserGender.Size = new System.Drawing.Size(100, 29);
            this.ComboBox_UserGender.TabIndex = 6;
            this.ComboBox_UserGender.Text = "男";
            // 
            // TextBox_UserAge
            // 
            this.TextBox_UserAge.Location = new System.Drawing.Point(180, 60);
            this.TextBox_UserAge.Name = "TextBox_UserAge";
            this.TextBox_UserAge.Size = new System.Drawing.Size(100, 29);
            this.TextBox_UserAge.TabIndex = 5;
            this.TextBox_UserAge.Text = "20";
            // 
            // TextBox_UserId
            // 
            this.TextBox_UserId.Location = new System.Drawing.Point(180, 20);
            this.TextBox_UserId.Name = "TextBox_UserId";
            this.TextBox_UserId.Size = new System.Drawing.Size(100, 29);
            this.TextBox_UserId.TabIndex = 4;
            this.TextBox_UserId.Text = "1";
            // 
            // Label_UserDialect
            // 
            this.Label_UserDialect.Location = new System.Drawing.Point(20, 140);
            this.Label_UserDialect.Name = "Label_UserDialect";
            this.Label_UserDialect.Size = new System.Drawing.Size(120, 30);
            this.Label_UserDialect.TabIndex = 3;
            this.Label_UserDialect.Text = "用户方言";
            this.Label_UserDialect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_UserGender
            // 
            this.Label_UserGender.Location = new System.Drawing.Point(20, 100);
            this.Label_UserGender.Name = "Label_UserGender";
            this.Label_UserGender.Size = new System.Drawing.Size(120, 30);
            this.Label_UserGender.TabIndex = 2;
            this.Label_UserGender.Text = "用户性别";
            this.Label_UserGender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_UserAge
            // 
            this.Label_UserAge.Location = new System.Drawing.Point(20, 60);
            this.Label_UserAge.Name = "Label_UserAge";
            this.Label_UserAge.Size = new System.Drawing.Size(120, 30);
            this.Label_UserAge.TabIndex = 1;
            this.Label_UserAge.Text = "用户年龄";
            this.Label_UserAge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_UserId
            // 
            this.Label_UserId.Location = new System.Drawing.Point(20, 20);
            this.Label_UserId.Name = "Label_UserId";
            this.Label_UserId.Size = new System.Drawing.Size(120, 30);
            this.Label_UserId.TabIndex = 0;
            this.Label_UserId.Text = "用户编号";
            this.Label_UserId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TabPage_Setting
            // 
            this.TabPage_Setting.BackColor = System.Drawing.SystemColors.Control;
            this.TabPage_Setting.Controls.Add(this.Btn_SetWorkRootPath);
            this.TabPage_Setting.Controls.Add(this.Btn_SetTransPath);
            this.TabPage_Setting.Controls.Add(this.TextBox_TransPath);
            this.TabPage_Setting.Controls.Add(this.Label_TransPath);
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
            this.TabPage_Setting.Size = new System.Drawing.Size(832, 326);
            this.TabPage_Setting.TabIndex = 2;
            this.TabPage_Setting.Text = "设置";
            // 
            // Btn_SetWorkRootPath
            // 
            this.Btn_SetWorkRootPath.Location = new System.Drawing.Point(700, 100);
            this.Btn_SetWorkRootPath.Name = "Btn_SetWorkRootPath";
            this.Btn_SetWorkRootPath.Size = new System.Drawing.Size(120, 29);
            this.Btn_SetWorkRootPath.TabIndex = 18;
            this.Btn_SetWorkRootPath.Text = "设置工作文件夹";
            this.Btn_SetWorkRootPath.UseVisualStyleBackColor = true;
            this.Btn_SetWorkRootPath.Click += new System.EventHandler(this.Btn_SetWorkRootPath_Click);
            // 
            // Btn_SetTransPath
            // 
            this.Btn_SetTransPath.Location = new System.Drawing.Point(700, 60);
            this.Btn_SetTransPath.Name = "Btn_SetTransPath";
            this.Btn_SetTransPath.Size = new System.Drawing.Size(120, 29);
            this.Btn_SetTransPath.TabIndex = 17;
            this.Btn_SetTransPath.Text = "设置文本路径";
            this.Btn_SetTransPath.UseVisualStyleBackColor = true;
            this.Btn_SetTransPath.Click += new System.EventHandler(this.Btn_SetTransPath_Click);
            // 
            // TextBox_TransPath
            // 
            this.TextBox_TransPath.Location = new System.Drawing.Point(160, 60);
            this.TextBox_TransPath.Name = "TextBox_TransPath";
            this.TextBox_TransPath.Size = new System.Drawing.Size(500, 29);
            this.TextBox_TransPath.TabIndex = 16;
            // 
            // Label_TransPath
            // 
            this.Label_TransPath.Location = new System.Drawing.Point(20, 60);
            this.Label_TransPath.Name = "Label_TransPath";
            this.Label_TransPath.Size = new System.Drawing.Size(120, 30);
            this.Label_TransPath.TabIndex = 15;
            this.Label_TransPath.Text = "文本路径";
            this.Label_TransPath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_ResetSetting
            // 
            this.Btn_ResetSetting.Location = new System.Drawing.Point(20, 260);
            this.Btn_ResetSetting.Name = "Btn_ResetSetting";
            this.Btn_ResetSetting.Size = new System.Drawing.Size(120, 40);
            this.Btn_ResetSetting.TabIndex = 11;
            this.Btn_ResetSetting.Text = "设置";
            this.Btn_ResetSetting.UseVisualStyleBackColor = true;
            this.Btn_ResetSetting.Click += new System.EventHandler(this.Btn_ResetSetting_Click);
            // 
            // TextBox_WorkRootPath
            // 
            this.TextBox_WorkRootPath.Location = new System.Drawing.Point(160, 100);
            this.TextBox_WorkRootPath.Name = "TextBox_WorkRootPath";
            this.TextBox_WorkRootPath.Size = new System.Drawing.Size(500, 29);
            this.TextBox_WorkRootPath.TabIndex = 9;
            // 
            // TextBox_BitsPerSample
            // 
            this.TextBox_BitsPerSample.Location = new System.Drawing.Point(600, 20);
            this.TextBox_BitsPerSample.Name = "TextBox_BitsPerSample";
            this.TextBox_BitsPerSample.Size = new System.Drawing.Size(60, 29);
            this.TextBox_BitsPerSample.TabIndex = 8;
            this.TextBox_BitsPerSample.Text = "16";
            // 
            // TextBox_Channel
            // 
            this.TextBox_Channel.Location = new System.Drawing.Point(380, 20);
            this.TextBox_Channel.Name = "TextBox_Channel";
            this.TextBox_Channel.Size = new System.Drawing.Size(60, 29);
            this.TextBox_Channel.TabIndex = 7;
            this.TextBox_Channel.Text = "1";
            // 
            // TextBox_SampleRate
            // 
            this.TextBox_SampleRate.Location = new System.Drawing.Point(160, 20);
            this.TextBox_SampleRate.Name = "TextBox_SampleRate";
            this.TextBox_SampleRate.Size = new System.Drawing.Size(60, 29);
            this.TextBox_SampleRate.TabIndex = 6;
            this.TextBox_SampleRate.Text = "16000";
            // 
            // Label_WorkRootFolder
            // 
            this.Label_WorkRootFolder.Location = new System.Drawing.Point(20, 100);
            this.Label_WorkRootFolder.Name = "Label_WorkRootFolder";
            this.Label_WorkRootFolder.Size = new System.Drawing.Size(120, 30);
            this.Label_WorkRootFolder.TabIndex = 4;
            this.Label_WorkRootFolder.Text = "工作文件夹";
            this.Label_WorkRootFolder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_BitsPerSample
            // 
            this.Label_BitsPerSample.Location = new System.Drawing.Point(460, 20);
            this.Label_BitsPerSample.Name = "Label_BitsPerSample";
            this.Label_BitsPerSample.Size = new System.Drawing.Size(120, 30);
            this.Label_BitsPerSample.TabIndex = 3;
            this.Label_BitsPerSample.Text = "精度";
            this.Label_BitsPerSample.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Channel
            // 
            this.Label_Channel.Location = new System.Drawing.Point(240, 20);
            this.Label_Channel.Name = "Label_Channel";
            this.Label_Channel.Size = new System.Drawing.Size(120, 30);
            this.Label_Channel.TabIndex = 2;
            this.Label_Channel.Text = "频道数";
            this.Label_Channel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_SampleRate
            // 
            this.Label_SampleRate.Location = new System.Drawing.Point(20, 20);
            this.Label_SampleRate.Name = "Label_SampleRate";
            this.Label_SampleRate.Size = new System.Drawing.Size(120, 30);
            this.Label_SampleRate.TabIndex = 1;
            this.Label_SampleRate.Text = "采样率";
            this.Label_SampleRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SimpleRecorder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 411);
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
        private System.Windows.Forms.Button Btn_ResetUI;
        private System.Windows.Forms.TextBox TextBox_TransPath;
        private System.Windows.Forms.Label Label_TransPath;
        private System.Windows.Forms.Label Label_Recording;
        private System.Windows.Forms.Button Btn_SetWorkRootPath;
        private System.Windows.Forms.Button Btn_SetTransPath;
    }
}

