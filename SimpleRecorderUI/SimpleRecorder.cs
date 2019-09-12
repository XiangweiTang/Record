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
        private string TransPath = @"D:\tmp\trans.txt";
        TransOp TrOp = null;
        Config Cfg = null;
        UserInfo UI = null;
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
            InitUI();
            InitTransList();
            InitGenderList();
            SetId(0);
            BE = new Backend(Cfg, UI, TrOp);
        }
        private void InitConfig()
        {
            string workRootPath = TextBox_WorkRootPath.Text;
            if (string.IsNullOrWhiteSpace(workRootPath))
                workRootPath = ".\\";

            string sampleRateStr = TextBox_SampleRate.Text;
            int sampleRate;
            if (!int.TryParse(sampleRateStr, out sampleRate))
                sampleRate = 16000;

            string channelStr = TextBox_Channel.Text;
            int channel;
            if (!int.TryParse(channelStr, out channel))
                channel = 1;

            string bitsPerSampleStr = TextBox_BitsPerSample.Text;
            int bitsPerSample;
            if (!int.TryParse(bitsPerSampleStr, out bitsPerSample))
                bitsPerSample = 2;

            Cfg = new Config();
            Cfg.Load(workRootPath, sampleRate.ToString(), channel.ToString(), bitsPerSample.ToString());
        }

        private void InitUI()
        {
            UI = new UserInfo();
            UI.UserId = TextBox_UserId.Text;

            byte age;
            if (!byte.TryParse(TextBox_UserAge.Text, out age))
                age = 20;
            UI.Age = age;

            if (ComboBox_UserGender.Text == "男")
                UI.Gender = "M";
            else
                UI.Gender = "F";

            UI.Dialect = TextBox_UserDialect.Text;
        }
        private void InitTransList()
        {
            Combo_TransList.Items.Clear();
            for (int i = 1; i <= TrOp.TransArray.Length; i++)
                Combo_TransList.Items.Add($"{i} {TrOp.TransArray[i - 1]}");
        }

        private void InitGenderList()
        {
            ComboBox_UserGender.Items.Clear();
            ComboBox_UserGender.Items.Add("男");
            ComboBox_UserGender.Items.Add("女");
        }

        private void Combo_TransList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int n = Combo_TransList.SelectedIndex;
            SetId(n);
        }

        private void ChangeId(int n)
        {
            TrOp.MoveNNext(n);
            ShowWithId();
        }

        private void SetId(int n)
        {
            TrOp.JumpToN(n);
            ShowWithId();
        }
        
        private void ShowWithId()
        {
            Combo_TransList.SelectedItem = Combo_TransList.Items[TrOp.CurrrentIndex];
            Label_Info.Text = $"当前进度：{TrOp.CurrrentIndex + 1}/{TrOp.TransArray.Length}";
            Label_Trans.Text = TrOp.TransArray[TrOp.CurrrentIndex];
        }

        private bool RecordStarted = false;
        private void Btn_Record_Click(object sender, EventArgs e)
        {
            RecordStarted = !RecordStarted;
            if (RecordStarted)
            {
                Btn_Record.Text = "正在录音";
                Btn_Record.ForeColor = Color.Green;
                Combo_TransList.Enabled = false;
                BE.StartRecord();
            }
            else
            {
                BE.EndRecord();
                Btn_Record.Text = "开始录音";
                Btn_Record.ForeColor = Color.Black;
                Combo_TransList.Enabled = true;
                ChangeId(1);
            }
        }

        private void TabPage_Setting_Leave(object sender, EventArgs e)
        {
            TextBox_SampleRate.Enabled = false;
            TextBox_Channel.Enabled = false;
            TextBox_BitsPerSample.Enabled = false;
            TextBox_WorkRootPath.Enabled = false;
            Init();            
        }

        private void TabPage_UserInfo_Leave(object sender, EventArgs e)
        {
            TextBox_UserId.Enabled = false;
            TextBox_UserAge.Enabled = false;
            ComboBox_UserGender.Enabled = false;
            TextBox_UserDialect.Enabled = false;
            Init();
        }

        private void Btn_RestUI_Click(object sender, EventArgs e)
        {
            TextBox_UserId.Enabled = true;
            TextBox_UserAge.Enabled = true;
            ComboBox_UserGender.Enabled = true;
            TextBox_UserDialect.Enabled = true;
        }

        private void Btn_ResetSetting_Click(object sender, EventArgs e)
        {
            TextBox_SampleRate.Enabled = true;
            TextBox_Channel.Enabled = true;
            TextBox_BitsPerSample.Enabled = true;
            TextBox_WorkRootPath.Enabled = true;
        }
    }
}
