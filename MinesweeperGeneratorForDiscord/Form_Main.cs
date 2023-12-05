using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MinesweeperGeneratorForDiscord {
    public partial class Form_Main : Form {
        public Form_Main() {
            InitializeComponent();
            UpdateDisplay_FloorCount();
        }

        #region 左上角目錄選單按鈕事件

        private void 製作名單ToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show($"Discord踩地雷生成器 {Application.ProductVersion}\n製作 by 魚丸◎蕾娜", "製作名單", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void 結束QToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        #endregion
        #region 地圖大小更新

        private void numericUpDown_FloorCountHorizontal_ValueChanged(object sender, EventArgs e) {
            UpdateDisplay_FloorCount();
        }

        private void numericUpDown_FloorCountVertical_ValueChanged(object sender, EventArgs e) {
            UpdateDisplay_FloorCount();
        }

        /// <summary>
        /// 取得地圖寬度
        /// </summary>
        /// <returns></returns>
        private int GetFloorCountHorizontal() {
            return Convert.ToInt32(Math.Round(numericUpDown_FloorCountHorizontal.Value, 0));
        }

        /// <summary>
        /// 取得地圖高度
        /// </summary>
        /// <returns></returns>
        private int GetFloorCountVertical() {
            return Convert.ToInt32(Math.Round(numericUpDown_FloorCountVertical.Value, 0));
        }

        private void UpdateDisplay_FloorCount() {
            int x = GetFloorCountHorizontal();
            int y = GetFloorCountVertical();
            int count = x * y;
            label_FloorCountTotal.Text = $"格子數量 = {count}";
        }

        #endregion
        #region 地雷數量調整框

        /// <summary>
        /// 取得地雷數量
        /// </summary>
        /// <returns></returns>
        private int GetMineCount() {
            return Convert.ToInt32(Math.Round(numericUpDown_MineCount.Value, 0));
        }

        #endregion
        #region 輸出方法

        private void button_Generate_Click(object sender, EventArgs e) {
            int floorX = GetFloorCountHorizontal();
            int floorY = GetFloorCountVertical();
            int floorCount = floorX * floorY;
            int mineCount = GetMineCount();
            if (mineCount > floorCount) {
                MessageBox.Show("地雷數量不能比地圖的格子總數還多！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            StringBuilder sb = new StringBuilder();
            //生成過程★
            textBox_Output.Text = sb.ToString();
        }

        #endregion
        #region 複製按鈕

        private void button_Copy_Click(object sender, EventArgs e) {
            Clipboard.SetText(textBox_Output.Text);
        }

        #endregion

    }
}
