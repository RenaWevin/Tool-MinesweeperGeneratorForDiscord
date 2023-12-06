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
            MapCellTypeStrings.Add(MapCellType.Mine, "||:boom:||");
            MapCellTypeStrings.Add(MapCellType.Empty, "||:zero:||");
            MapCellTypeStrings.Add(MapCellType.Cell1, "||:one:||");
            MapCellTypeStrings.Add(MapCellType.Cell2, "||:two:||");
            MapCellTypeStrings.Add(MapCellType.Cell3, "||:three:||");
            MapCellTypeStrings.Add(MapCellType.Cell4, "||:four:||");
            MapCellTypeStrings.Add(MapCellType.Cell5, "||:five:||");
            MapCellTypeStrings.Add(MapCellType.Cell6, "||:six:||");
            MapCellTypeStrings.Add(MapCellType.Cell7, "||:seven:||");
            MapCellTypeStrings.Add(MapCellType.Cell8, "||:eight:||");
        }

        private readonly Dictionary<MapCellType, string> MapCellTypeStrings = new Dictionary<MapCellType, string>();

        #region enum

        private enum MapCellType {
            Mine = -1,
            Empty = 0,
            Cell1 = 1,
            Cell2 = 2,
            Cell3 = 3,
            Cell4 = 4,
            Cell5 = 5,
            Cell6 = 6,
            Cell7 = 7,
            Cell8 = 8,
        }

        #endregion

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
            int floorX = GetFloorCountHorizontal(); //地圖寬度
            int floorY = GetFloorCountVertical(); //地圖高度
            int floorCount = floorX * floorY;
            int mineCount = GetMineCount();
            if (mineCount > floorCount) {
                MessageBox.Show("地雷數量不能比地圖的格子總數還多！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            StringBuilder sb = new StringBuilder();
            #region  -> 生成過程
            //生成過程
            int[] map = new int[floorCount];
            int[] mapRandomIds = new int[floorCount];
            for (int i = 0; i < map.Length; i++) {
                mapRandomIds[i] = i;
            }
            //隨機取出要生成地雷的Index
            Random random = new Random();
            for (int i = 0; i < mineCount; i++) {
                int randomMineMax = floorCount - i;
                int randomIndex = random.Next(0, randomMineMax);
                int randomId = mapRandomIds[randomIndex];
                //設定該格為地雷
                map[randomId] = (int)MapCellType.Mine;
                //將最後一項的數值放進這項，直接取代掉就好 
                mapRandomIds[randomIndex] = mapRandomIds[randomMineMax - 1];
            }
            //定義檢查該格是否有地雷的方法
            bool IsCellHasMine(int targetX, int targetY) {
                int index = (targetY * floorX) + targetX;
                return map[index] == (int)MapCellType.Mine;
            }
            //為所有有地雷的周邊加上數字
            for (int i = 0; i < map.Length; i++) {
                //自己不是地雷才能檢查
                if (map[i] != (int)MapCellType.Mine) {
                    int cellX = i % floorX; //目前這格是第幾直排
                    int cellY = i / floorX; //目前這格是第幾橫列
                    //地雷數量暫存
                    int cellMineCount = 0;
                    //檢查上下左右八方向的地雷
                    for (int checkY = cellY - 1; checkY <= cellY + 1; checkY++) {
                        for (int checkX = cellX - 1; checkX <= cellX + 1; checkX++) {
                            //跳過自己
                            if (checkX == cellX && checkY == cellY) {
                                continue;
                            }
                            //檢查是否有不合理的座標
                            if (checkX < 0) { continue; }
                            if (checkX >= floorX) { continue; }
                            if (checkY < 0) { continue; }
                            if (checkY >= floorY) { continue; }
                            //檢查此格是否有地雷
                            if (IsCellHasMine(checkX, checkY)) {
                                cellMineCount++;
                            }
                        }
                    }
                    //最後寫入數量
                    map[i] = cellMineCount;
                }
            }
            #endregion
            #region  -> 將整張地圖轉成文字
            sb.AppendLine($"地圖大小 {floorX}x{floorY}");
            sb.AppendLine($"地雷數量 {mineCount}");
            for (int i = 0; i < map.Length; i++) {
                if (i > 0 && i % floorX == 0) {
                    sb.AppendLine();
                }
                MapCellType type = (MapCellType)map[i];
                string cell = MapCellTypeStrings[type];
                sb.Append(cell);
            }
            #endregion
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
