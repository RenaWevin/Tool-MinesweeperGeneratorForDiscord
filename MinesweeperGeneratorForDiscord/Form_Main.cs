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
            isShowed100CellWarning = false;
        }

        private readonly Dictionary<MapCellType, string> MapCellTypeStrings = new Dictionary<MapCellType, string>();

        //本次啟動已經顯示過一次100格警告
        private bool isShowed100CellWarning = false;

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

        private void 使用說明HToolStripMenuItem_Click(object sender, EventArgs e) {
            const string msgFormat = "本軟體可產生出可以在Discord文字頻道中\n模擬踩地雷小遊戲的文字地圖格式" +
                "\n\n可參考以下步驟使用：" +
                "\n1. 選擇參數模板，或者選擇地圖大小與地雷數量" +
                "\n2. 按下「生成按鈕」，接著「按下複製已生成的文字」按鈕" +
                "\n3. 將複製到的文字貼到Discord文字頻道中送出" +
                "\n4. 開始遊玩踩地雷！" +
                "\n\n請各位使用時遵守Discord社群禮儀\n本軟體製作者不負任何因使用此軟體造成後果的責任";
            MessageBox.Show(string.Format(msgFormat), "使用說明", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void 製作名單ToolStripMenuItem_Click(object sender, EventArgs e) {
            const string msgFormat = "Discord踩地雷生成器 {0}\n軟體製作 by 魚丸◎蕾娜" +
                "\n\n請各位使用時遵守Discord社群禮儀\n本軟體製作者不負任何因使用此軟體造成後果的責任";
            MessageBox.Show(string.Format(msgFormat, Application.ProductVersion), "製作名單", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void 結束QToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        #endregion
        #region 左上角模板選單按鈕事件

        private void SetParameterUIValue(int floorCountHorizontal, int floorCountVertical, int mineCount) {
            numericUpDown_FloorCountHorizontal.Value = floorCountHorizontal;
            numericUpDown_FloorCountVertical.Value = floorCountVertical;
            numericUpDown_MineCount.Value = mineCount;
        }

        private void 模板_預設簡單難度ToolStripMenuItem_Click(object sender, EventArgs e) {
            SetParameterUIValue(
                floorCountHorizontal: 5,
                floorCountVertical: 5,
                mineCount: 3
            );
        }

        private void 模板_windows3_1踩地雷簡單難度ToolStripMenuItem_Click(object sender, EventArgs e) {
            SetParameterUIValue(
                floorCountHorizontal: 8,
                floorCountVertical: 8,
                mineCount: 10
            );
        }

        private void 模板_windows2000踩地雷簡單難度ToolStripMenuItem_Click(object sender, EventArgs e) {
            SetParameterUIValue(
                floorCountHorizontal: 9,
                floorCountVertical: 9,
                mineCount: 10
            );
        }

        private void 模板_半百挑戰ToolStripMenuItem_Click(object sender, EventArgs e) {
            SetParameterUIValue(
                floorCountHorizontal: 7,
                floorCountVertical: 7,
                mineCount: 9
            );
        }

        private void 模板_99挑戰ToolStripMenuItem_Click(object sender, EventArgs e) {
            SetParameterUIValue(
                floorCountHorizontal: 11,
                floorCountVertical: 9,
                mineCount: 20
            );
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
            if (count >= 100) {
                label_FloorCountTotal.ForeColor = Color.Red;
            } else {
                label_FloorCountTotal.ForeColor = Color.Black;
            }
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
            if (floorCount >= 100 && !isShowed100CellWarning) {
                MessageBox.Show("格子量超過100時\n可能會無法顯示在Discord文字頻道！\n(此警告只會顯示一次)", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isShowed100CellWarning = true;
            }
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
            sb.AppendLine($"地圖大小：{floorX}x{floorY}");
            sb.AppendLine($"地雷數量：{mineCount}");
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
