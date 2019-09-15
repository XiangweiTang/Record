using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleRecorderUI
{
    public partial class SimpleRecorder : Form
    {
        TransOp TrOp = null;
        Config Cfg = null;
        UserInfo UInfo = null;
        Backend BE = null;
        public SimpleRecorder()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            InitConfig();
            TrOp = new TransOp(Cfg.TransPath);
            InitTransList();
            InitGenderList();
            SetId(0);
            BE = new Backend();
            BE.TrOp = TrOp;
        }
        private void InitConfig()
        {
            Cfg = new Config();
            if (Cfg.SettingExists)
                Cfg.LoadFromFile();
            else
                LoadFromForm();
        }
        private void InitTransList()
        {
            Combo_TransList.Items.Clear();
            int showIndex = 1;
            foreach (string trans in TrOp.TransArray)
                Combo_TransList.Items.Add($"{showIndex++} {trans}");
        }

        private void InitGenderList()
        {
            ComboBox_UserGender.Items.Clear();
            ComboBox_UserGender.Items.Add("男");
            ComboBox_UserGender.Items.Add("女");
            ComboBox_UserGender.Items.Add("不设置");
        }

        private void Combo_TransList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int n = Combo_TransList.SelectedIndex;
            SetId(n);
        }

        private void ChangeId(int n)
        {
            TrOp.ChangeIndex(n);
            ShowWithId();
        }

        private void SetId(int n)
        {
            TrOp.SetIndex(n);
            ShowWithId();
        }
        
        private void ShowWithId()
        {
            Combo_TransList.SelectedItem = Combo_TransList.Items[TrOp.CurrrentIndex];
            Label_Info.Text = $"当前进度：{TrOp.CurrrentIndex + 1}/{TrOp.TransArray.Length}";
            Label_Trans.Text = TrOp.CurrentTrans;
        }

        private bool RecordStarted = false;
        private void Btn_Record_Click(object sender, EventArgs e)
        {
            RecordStarted = !RecordStarted;
            if (BE.TrOp == null)
            {
                MessageBox.Show("请设定文本文件路径。");
                return;
            }
            if (BE.UInfo == null)
            {
                MessageBox.Show("请设定用户信息。");
                return;
            }
            if (BE.Cfg == null)
            {
                MessageBox.Show("请设定设置。");
                return;
            }
            if (RecordStarted)
            {
                Label_Recording.Text = "录音进行中";
                Label_Recording.ForeColor = Color.Red;
                Btn_Record.Text = "停止录音";
                Combo_TransList.Enabled = false;
                BE.StartRecord();
            }
            else
            {
                BE.EndRecord();
                Label_Recording.Text = "未在录音";
                Label_Recording.ForeColor = Color.Green;
                Btn_Record.Text = "开始录音";
                Combo_TransList.Enabled = true;
                ChangeId(1);
            }
        }

        private bool ResetSettingDone = false;
        private void Btn_ResetSetting_Click(object sender, EventArgs e)
        {
            ActivateSettings(ResetSettingDone);
            ResetSettingDone = !ResetSettingDone;
            if (ResetSettingDone)
            {
                Cfg = new Config();
                LoadFromForm();
                Cfg.SaveToFile();
                TrOp = new TransOp(Cfg.TransPath);
            }
            else
            {
                TrOp = null;          
            }
            BE.Cfg = Cfg;
            BE.TrOp = TrOp;
            Btn_ResetSetting.Text = ResetSettingDone ? "重置" : "设置";
        }

        private void LoadFromForm()
        {
            Cfg.LoadWithInput(
                TextBox_WorkRootPath.Text,
                TextBox_TransPath.Text,
                TextBox_SampleRate.Text,
                TextBox_Channel.Text,
                TextBox_BitsPerSample.Text
                );
        }
        private void ActivateSettings(bool b)
        {
            TextBox_SampleRate.Enabled = b;
            TextBox_Channel.Enabled = b;
            TextBox_BitsPerSample.Enabled = b;
            TextBox_TransPath.Enabled = b;
            TextBox_WorkRootPath.Enabled = b;
            Btn_SetTransPath.Enabled = b;
            Btn_SetWorkRootPath.Enabled = b;
        }

        private bool ResetUIDone = false;
        private void Btn_ResetUI_Click(object sender, EventArgs e)
        {
            ActivateUserInfo(ResetUIDone);
            ResetUIDone = !ResetUIDone;
            if (ResetUIDone)
            {
                UInfo = new UserInfo();
                UInfo.Load(
                    TextBox_UserId.Text,
                    TextBox_UserAge.Text,
                    ComboBox_UserGender.Text,
                    TextBox_UserDialect.Text
                    );
            }
            else
            {
                UInfo = null;                
            }
            BE.UInfo = UInfo;
            Btn_ResetUI.Text = ResetUIDone ? "重置" : "设置";
        }

        private void ActivateUserInfo(bool b)
        {
            TextBox_UserId.Enabled = b;
            TextBox_UserAge.Enabled = b;
            ComboBox_UserGender.Enabled = b;
            TextBox_UserDialect.Enabled = b;
        }

        private void Btn_SetWorkRootPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog openFolder = new FolderBrowserDialog();
            openFolder.Description = "请设置工作路径";
            if (openFolder.ShowDialog() == DialogResult.OK)
            {
                Cfg.WorkRootPath = openFolder.SelectedPath;
                TextBox_WorkRootPath.Text = openFolder.SelectedPath;
            }
        }

        private void Btn_SetTransPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Title = "请选择文本文件";
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                Cfg.TransPath = openDialog.FileName;
                TextBox_TransPath.Text = openDialog.FileName;
            }
        }
    }
}
