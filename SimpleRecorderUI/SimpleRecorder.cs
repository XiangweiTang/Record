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
            InitTransList();
        }

        private void InitTransList()
        {
            for (int i = 1; i <= TrOp.TransArray.Length; i++)
                Combo_TransList.Items.Add($"{i} {TrOp.TransArray[i - 1]}");
        }

        private void Combo_TransList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string currentContext = Combo_TransList.Text;
            int spaceIndex = currentContext.IndexOf(' ');
            Label_Trans.Text = currentContext.Substring(spaceIndex + 1);
            int index = int.Parse(currentContext.Substring(0, spaceIndex)) - 1;
            TrOp.JumpToN(index);
            ChangeId();
        }

        private void ChangeId()
        {
            Label_Info.Text = $"当前文本：{TrOp.CurrrentIndex + 1}/{TrOp.TransArray.Length}";
        }
    }
}
