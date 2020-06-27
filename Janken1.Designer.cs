namespace janken
{
    partial class Janken1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.tbJudge = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.cbJan1 = new System.Windows.Forms.ComboBox();
            this.cbJan2 = new System.Windows.Forms.ComboBox();
            this.tbJudge2 = new System.Windows.Forms.TextBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbJudge
            // 
            this.tbJudge.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbJudge.Location = new System.Drawing.Point(40, 187);
            this.tbJudge.Name = "tbJudge";
            this.tbJudge.Size = new System.Drawing.Size(169, 43);
            this.tbJudge.TabIndex = 2;
            this.tbJudge.TabStop = false;
            this.tbJudge.Text = "判定";
            this.tbJudge.TextChanged += new System.EventHandler(this.tbJudge_TextChanged);
            // 
            // btnRun
            // 
            this.btnRun.Font = new System.Drawing.Font("メイリオ", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnRun.Location = new System.Drawing.Point(156, 122);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(169, 37);
            this.btnRun.TabIndex = 3;
            this.btnRun.TabStop = false;
            this.btnRun.Text = "じゃんけん実行";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // cbJan1
            // 
            this.cbJan1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbJan1.Font = new System.Drawing.Font("メイリオ", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cbJan1.FormattingEnabled = true;
            this.cbJan1.Location = new System.Drawing.Point(40, 57);
            this.cbJan1.Name = "cbJan1";
            this.cbJan1.Size = new System.Drawing.Size(158, 39);
            this.cbJan1.TabIndex = 4;
            this.cbJan1.TabStop = false;
            this.cbJan1.SelectedIndexChanged += new System.EventHandler(this.cbJan1_SelectedIndexChanged);
            // 
            // cbJan2
            // 
            this.cbJan2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbJan2.Font = new System.Drawing.Font("メイリオ", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cbJan2.FormattingEnabled = true;
            this.cbJan2.Location = new System.Drawing.Point(267, 57);
            this.cbJan2.Name = "cbJan2";
            this.cbJan2.Size = new System.Drawing.Size(158, 39);
            this.cbJan2.TabIndex = 5;
            this.cbJan2.TabStop = false;
            this.cbJan2.SelectedIndexChanged += new System.EventHandler(this.cbJan2_SelectedIndexChanged);
            // 
            // tbJudge2
            // 
            this.tbJudge2.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbJudge2.Location = new System.Drawing.Point(256, 187);
            this.tbJudge2.Name = "tbJudge2";
            this.tbJudge2.Size = new System.Drawing.Size(169, 43);
            this.tbJudge2.TabIndex = 6;
            this.tbJudge2.TabStop = false;
            this.tbJudge2.Text = "判定";
            this.tbJudge2.TextChanged += new System.EventHandler(this.tbJudge2_TextChanged);
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("メイリオ", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnStop.Location = new System.Drawing.Point(156, 252);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(169, 37);
            this.btnStop.TabIndex = 7;
            this.btnStop.TabStop = false;
            this.btnStop.Text = "やめる";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // Janken1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.tbJudge2);
            this.Controls.Add(this.cbJan2);
            this.Controls.Add(this.cbJan1);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.tbJudge);
            this.Name = "Janken1";
            this.Text = "じゃんけん";
            this.Load += new System.EventHandler(this.Janken1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbJudge;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.ComboBox cbJan1;
        private System.Windows.Forms.ComboBox cbJan2;
        private System.Windows.Forms.TextBox tbJudge2;
        private System.Windows.Forms.Button btnStop;
    }
}

