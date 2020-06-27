using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace janken
{
    public partial class Janken1 : Form
    {
        public Janken1()
        {
            InitializeComponent();
            ControlBox = false;
        }
        /// <summary>
        /// 定義物
        /// </summary>
        public string[] janken1 = {"グー","チョキ","パー"};
        public string[] kekka1 = { "勝ち", "負け"};
        public string kekka2 ="あいこ";
        /// <summary>
        /// 実行ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRun_Click(object sender, EventArgs e)
        {
            //あいこ
            if (cbJan1.Text.Equals(cbJan2.Text))
            {
                tbJudge.Text = kekka2;
                tbJudge2.Text = kekka2;
            }
            else
            {
                if (cbJan1.Text == janken1[0] && cbJan2.Text == janken1[1])　
                {
                    tbJudge.Text = kekka1[0];
                    tbJudge2.Text = kekka1[1];
                }
                else if (cbJan1.Text == janken1[1] && cbJan2.Text == janken1[2])
                {
                    tbJudge.Text = kekka1[0];
                    tbJudge2.Text = kekka1[1];
                }
                else if (cbJan1.Text == janken1[2] && cbJan2.Text == janken1[1])
                {
                    tbJudge.Text = kekka1[0];
                    tbJudge2.Text = kekka1[1];
                }
                else
                {
                    tbJudge.Text = kekka1[1];
                    tbJudge2.Text = kekka1[0];
                }
            }
        }
        /// <summary>
        /// 開始時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Janken1_Load(object sender, EventArgs e)
        {
            for (int i=0;i< janken1.Length;i++)
            {
                cbJan1.Items.Add(janken1[i]);

                cbJan2.Items.Add(janken1[i]);
            }
        }
        /// <summary>
        /// リスト選択時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbJan1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbJudge.Text = "";
            tbJudge2.Text = "";
        }

        private void cbJan2_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbJudge.Text = "";
            tbJudge2.Text = "";
        }
        /// <summary>
        /// 終了
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStop_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// 不使用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbJudge_TextChanged(object sender, EventArgs e)
        {
        }
        private void tbJudge2_TextChanged(object sender, EventArgs e)
        {
        }

    }
}
