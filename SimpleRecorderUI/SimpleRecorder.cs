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
        private string TransPath = @"C:\Users\v-xianta\Documents\tmp\Trans.txt";
        TransOp TrOp = null;
        public SimpleRecorder()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            TrOp = new TransOp(TransPath);
            ChangeId(0);
            InitTransList();
        }

        private void InitTransList()
        {
            for (int i = 1; i <= TrOp.TransArray.Length; i++)
                Combo_TransList.Items.Add($"{i} {TrOp.TransArray[i - 1]}");
        }

        private void Combo_TransList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = Combo_TransList.SelectedIndex;
            ChangeId(index);
        }

        private void ChangeId(int index)
        {
            TrOp.JumpToN(index);
            Label_Info.Text = $"当前文本：{TrOp.CurrrentIndex + 1}/{TrOp.TransArray.Length}";
            string currentContext = Combo_TransList.Text;
            int spaceIndex = currentContext.IndexOf(' ');
            Label_Trans.Text = currentContext.Substring(spaceIndex + 1);
        }

        private bool RecordStarted = false;
        private void Btn_Record_Click(object sender, EventArgs e)
        {
            RecordStarted = !RecordStarted;
            if (RecordStarted)
            {
                Btn_Record.Text = "正在录音";
                Btn_Record.ForeColor = Color.Green;
            }
            else
            {
                Btn_Record.Text = "开始录音";
                Btn_Record.ForeColor = Color.Black;
            }
        }
    }
}
