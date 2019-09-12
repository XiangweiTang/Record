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
            this.Label_Info = new System.Windows.Forms.Label();
            this.Combo_TransList = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Label_Trans
            // 
            this.Label_Trans.BackColor = System.Drawing.SystemColors.Info;
            this.Label_Trans.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Trans.Location = new System.Drawing.Point(12, 68);
            this.Label_Trans.Name = "Label_Trans";
            this.Label_Trans.Size = new System.Drawing.Size(802, 200);
            this.Label_Trans.TabIndex = 0;
            // 
            // Btn_Record
            // 
            this.Btn_Record.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Record.Location = new System.Drawing.Point(596, 285);
            this.Btn_Record.Name = "Btn_Record";
            this.Btn_Record.Size = new System.Drawing.Size(141, 57);
            this.Btn_Record.TabIndex = 1;
            this.Btn_Record.Text = "开始录音";
            this.Btn_Record.UseVisualStyleBackColor = true;
            this.Btn_Record.Click += new System.EventHandler(this.Btn_Record_Click);
            // 
            // Label_Info
            // 
            this.Label_Info.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Info.Location = new System.Drawing.Point(12, 19);
            this.Label_Info.Name = "Label_Info";
            this.Label_Info.Size = new System.Drawing.Size(631, 23);
            this.Label_Info.TabIndex = 2;
            this.Label_Info.Text = "当前文本： ";
            // 
            // Combo_TransList
            // 
            this.Combo_TransList.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Combo_TransList.FormattingEnabled = true;
            this.Combo_TransList.Location = new System.Drawing.Point(60, 285);
            this.Combo_TransList.Name = "Combo_TransList";
            this.Combo_TransList.Size = new System.Drawing.Size(457, 27);
            this.Combo_TransList.TabIndex = 7;
            this.Combo_TransList.SelectedIndexChanged += new System.EventHandler(this.Combo_TransList_SelectedIndexChanged);
            // 
            // SimpleRecorder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 450);
            this.Controls.Add(this.Combo_TransList);
            this.Controls.Add(this.Label_Info);
            this.Controls.Add(this.Btn_Record);
            this.Controls.Add(this.Label_Trans);
            this.Name = "SimpleRecorder";
            this.Text = "SimpleRecorder";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Label_Trans;
        private System.Windows.Forms.Button Btn_Record;
        private System.Windows.Forms.Label Label_Info;
        private System.Windows.Forms.ComboBox Combo_TransList;
    }
}

