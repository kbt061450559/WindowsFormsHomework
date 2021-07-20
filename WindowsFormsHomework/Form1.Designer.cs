
namespace WindowsFormsHomework
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.kextuka = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.kakutei = new System.Windows.Forms.Button();
            this.kynseru = new System.Windows.Forms.Button();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.cbxType2 = new System.Windows.Forms.ComboBox();
            this.nendo = new System.Windows.Forms.RadioButton();
            this.kikan = new System.Windows.Forms.RadioButton();
            this.kiakn2 = new System.Windows.Forms.DateTimePicker();
            this.kikan3 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(31, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "使用期間";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(31, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "用途";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(31, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "汽缸CC數/馬達馬力";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(31, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "試算結果";
            // 
            // kextuka
            // 
            this.kextuka.AutoSize = true;
            this.kextuka.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.kextuka.Location = new System.Drawing.Point(224, 200);
            this.kextuka.Name = "kextuka";
            this.kextuka.Size = new System.Drawing.Size(15, 19);
            this.kextuka.TabIndex = 4;
            this.kextuka.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(224, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "從";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(462, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "至";
            this.label7.Visible = false;
            // 
            // kakutei
            // 
            this.kakutei.Location = new System.Drawing.Point(657, 196);
            this.kakutei.Name = "kakutei";
            this.kakutei.Size = new System.Drawing.Size(75, 23);
            this.kakutei.TabIndex = 7;
            this.kakutei.Text = "確定送出";
            this.kakutei.UseVisualStyleBackColor = true;
            this.kakutei.Click += new System.EventHandler(this.kakutei_Click);
            // 
            // kynseru
            // 
            this.kynseru.Location = new System.Drawing.Point(657, 244);
            this.kynseru.Name = "kynseru";
            this.kynseru.Size = new System.Drawing.Size(75, 23);
            this.kynseru.TabIndex = 8;
            this.kynseru.Text = "取消重填";
            this.kynseru.UseVisualStyleBackColor = true;
            this.kynseru.Click += new System.EventHandler(this.kynseru_Click);
            // 
            // cbxType
            // 
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Items.AddRange(new object[] {
            "機車",
            "貨車",
            "大客車",
            "自用小客車",
            "營業用小客車"});
            this.cbxType.Location = new System.Drawing.Point(226, 124);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(350, 20);
            this.cbxType.TabIndex = 9;
            this.cbxType.SelectedIndexChanged += new System.EventHandler(this.tukaikata_SelectedIndexChanged);
            // 
            // cbxType2
            // 
            this.cbxType2.FormattingEnabled = true;
            this.cbxType2.Items.AddRange(new object[] {
            "150以下/12HP以下(12.2PS以下)",
            "151-250/12.1-20HP(12.3-20.3PS)",
            "251-500/20.1HP以上(20.4PS以上)",
            "501-600",
            "601-1200",
            "1201-1800",
            "1801或以上"});
            this.cbxType2.Location = new System.Drawing.Point(226, 157);
            this.cbxType2.Name = "cbxType2";
            this.cbxType2.Size = new System.Drawing.Size(350, 20);
            this.cbxType2.TabIndex = 10;
            // 
            // nendo
            // 
            this.nendo.AutoSize = true;
            this.nendo.Checked = true;
            this.nendo.Location = new System.Drawing.Point(226, 58);
            this.nendo.Name = "nendo";
            this.nendo.Size = new System.Drawing.Size(59, 16);
            this.nendo.TabIndex = 11;
            this.nendo.TabStop = true;
            this.nendo.Text = "全年度";
            this.nendo.UseVisualStyleBackColor = true;
            // 
            // kikan
            // 
            this.kikan.AutoSize = true;
            this.kikan.Location = new System.Drawing.Point(329, 58);
            this.kikan.Name = "kikan";
            this.kikan.Size = new System.Drawing.Size(59, 16);
            this.kikan.TabIndex = 12;
            this.kikan.Text = "依期間";
            this.kikan.UseVisualStyleBackColor = true;
            this.kikan.CheckedChanged += new System.EventHandler(this.kikan_CheckedChanged);
            // 
            // kiakn2
            // 
            this.kiakn2.Location = new System.Drawing.Point(247, 82);
            this.kiakn2.Name = "kiakn2";
            this.kiakn2.Size = new System.Drawing.Size(200, 22);
            this.kiakn2.TabIndex = 13;
            this.kiakn2.Visible = false;
            // 
            // kikan3
            // 
            this.kikan3.Location = new System.Drawing.Point(510, 82);
            this.kikan3.Name = "kikan3";
            this.kikan3.Size = new System.Drawing.Size(200, 22);
            this.kikan3.TabIndex = 14;
            this.kikan3.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kikan3);
            this.Controls.Add(this.kiakn2);
            this.Controls.Add(this.kikan);
            this.Controls.Add(this.nendo);
            this.Controls.Add(this.cbxType2);
            this.Controls.Add(this.cbxType);
            this.Controls.Add(this.kynseru);
            this.Controls.Add(this.kakutei);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.kextuka);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label kextuka;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button kakutei;
        private System.Windows.Forms.Button kynseru;
        private System.Windows.Forms.ComboBox cbxType;
        private System.Windows.Forms.ComboBox cbxType2;
        private System.Windows.Forms.RadioButton nendo;
        private System.Windows.Forms.RadioButton kikan;
        private System.Windows.Forms.DateTimePicker kiakn2;
        private System.Windows.Forms.DateTimePicker kikan3;
    }
}

