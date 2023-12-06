
namespace MinesweeperGeneratorForDiscord {
    partial class Form_Main {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.numericUpDown_FloorCountHorizontal = new System.Windows.Forms.NumericUpDown();
            this.menuStrip_Main = new System.Windows.Forms.MenuStrip();
            this.程式PToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.製作名單ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.結束QToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label_FloorSizeTitle = new System.Windows.Forms.Label();
            this.groupBox_Parameters = new System.Windows.Forms.GroupBox();
            this.numericUpDown_MineCount = new System.Windows.Forms.NumericUpDown();
            this.label_MineCount = new System.Windows.Forms.Label();
            this.label_FloorCountTotal = new System.Windows.Forms.Label();
            this.numericUpDown_FloorCountVertical = new System.Windows.Forms.NumericUpDown();
            this.label_X = new System.Windows.Forms.Label();
            this.groupBox_Output = new System.Windows.Forms.GroupBox();
            this.textBox_Output = new System.Windows.Forms.TextBox();
            this.button_Generate = new System.Windows.Forms.Button();
            this.button_Copy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_FloorCountHorizontal)).BeginInit();
            this.menuStrip_Main.SuspendLayout();
            this.groupBox_Parameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_MineCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_FloorCountVertical)).BeginInit();
            this.groupBox_Output.SuspendLayout();
            this.SuspendLayout();
            // 
            // numericUpDown_FloorCountHorizontal
            // 
            this.numericUpDown_FloorCountHorizontal.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.numericUpDown_FloorCountHorizontal.Location = new System.Drawing.Point(19, 43);
            this.numericUpDown_FloorCountHorizontal.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_FloorCountHorizontal.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown_FloorCountHorizontal.Name = "numericUpDown_FloorCountHorizontal";
            this.numericUpDown_FloorCountHorizontal.Size = new System.Drawing.Size(65, 27);
            this.numericUpDown_FloorCountHorizontal.TabIndex = 0;
            this.numericUpDown_FloorCountHorizontal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown_FloorCountHorizontal.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown_FloorCountHorizontal.ValueChanged += new System.EventHandler(this.numericUpDown_FloorCountHorizontal_ValueChanged);
            // 
            // menuStrip_Main
            // 
            this.menuStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.程式PToolStripMenuItem});
            this.menuStrip_Main.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_Main.Name = "menuStrip_Main";
            this.menuStrip_Main.Size = new System.Drawing.Size(450, 24);
            this.menuStrip_Main.TabIndex = 1;
            this.menuStrip_Main.Text = "menuStrip1";
            // 
            // 程式PToolStripMenuItem
            // 
            this.程式PToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.製作名單ToolStripMenuItem,
            this.結束QToolStripMenuItem});
            this.程式PToolStripMenuItem.Name = "程式PToolStripMenuItem";
            this.程式PToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.程式PToolStripMenuItem.Text = "程式 (&P)";
            // 
            // 製作名單ToolStripMenuItem
            // 
            this.製作名單ToolStripMenuItem.Name = "製作名單ToolStripMenuItem";
            this.製作名單ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.製作名單ToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.製作名單ToolStripMenuItem.Text = "製作名單";
            this.製作名單ToolStripMenuItem.Click += new System.EventHandler(this.製作名單ToolStripMenuItem_Click);
            // 
            // 結束QToolStripMenuItem
            // 
            this.結束QToolStripMenuItem.Name = "結束QToolStripMenuItem";
            this.結束QToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.結束QToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.結束QToolStripMenuItem.Text = "結束 (&Q)";
            this.結束QToolStripMenuItem.Click += new System.EventHandler(this.結束QToolStripMenuItem_Click);
            // 
            // label_FloorSizeTitle
            // 
            this.label_FloorSizeTitle.AutoSize = true;
            this.label_FloorSizeTitle.Location = new System.Drawing.Point(17, 28);
            this.label_FloorSizeTitle.Name = "label_FloorSizeTitle";
            this.label_FloorSizeTitle.Size = new System.Drawing.Size(133, 12);
            this.label_FloorSizeTitle.TabIndex = 2;
            this.label_FloorSizeTitle.Text = "地圖大小 (最小3 最大10)";
            // 
            // groupBox_Parameters
            // 
            this.groupBox_Parameters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox_Parameters.Controls.Add(this.numericUpDown_MineCount);
            this.groupBox_Parameters.Controls.Add(this.label_MineCount);
            this.groupBox_Parameters.Controls.Add(this.label_FloorCountTotal);
            this.groupBox_Parameters.Controls.Add(this.numericUpDown_FloorCountVertical);
            this.groupBox_Parameters.Controls.Add(this.label_X);
            this.groupBox_Parameters.Controls.Add(this.label_FloorSizeTitle);
            this.groupBox_Parameters.Controls.Add(this.numericUpDown_FloorCountHorizontal);
            this.groupBox_Parameters.Location = new System.Drawing.Point(12, 27);
            this.groupBox_Parameters.Name = "groupBox_Parameters";
            this.groupBox_Parameters.Size = new System.Drawing.Size(194, 165);
            this.groupBox_Parameters.TabIndex = 3;
            this.groupBox_Parameters.TabStop = false;
            this.groupBox_Parameters.Text = "輸入參數";
            // 
            // numericUpDown_MineCount
            // 
            this.numericUpDown_MineCount.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.numericUpDown_MineCount.Location = new System.Drawing.Point(19, 121);
            this.numericUpDown_MineCount.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numericUpDown_MineCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_MineCount.Name = "numericUpDown_MineCount";
            this.numericUpDown_MineCount.Size = new System.Drawing.Size(153, 27);
            this.numericUpDown_MineCount.TabIndex = 7;
            this.numericUpDown_MineCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown_MineCount.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label_MineCount
            // 
            this.label_MineCount.AutoSize = true;
            this.label_MineCount.Location = new System.Drawing.Point(17, 106);
            this.label_MineCount.Name = "label_MineCount";
            this.label_MineCount.Size = new System.Drawing.Size(133, 12);
            this.label_MineCount.TabIndex = 6;
            this.label_MineCount.Text = "地雷數量 (最小1 最大99)";
            // 
            // label_FloorCountTotal
            // 
            this.label_FloorCountTotal.AutoSize = true;
            this.label_FloorCountTotal.Location = new System.Drawing.Point(17, 73);
            this.label_FloorCountTotal.Name = "label_FloorCountTotal";
            this.label_FloorCountTotal.Size = new System.Drawing.Size(71, 12);
            this.label_FloorCountTotal.TabIndex = 5;
            this.label_FloorCountTotal.Text = "格子數量 = 9";
            // 
            // numericUpDown_FloorCountVertical
            // 
            this.numericUpDown_FloorCountVertical.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.numericUpDown_FloorCountVertical.Location = new System.Drawing.Point(107, 43);
            this.numericUpDown_FloorCountVertical.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_FloorCountVertical.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown_FloorCountVertical.Name = "numericUpDown_FloorCountVertical";
            this.numericUpDown_FloorCountVertical.Size = new System.Drawing.Size(65, 27);
            this.numericUpDown_FloorCountVertical.TabIndex = 4;
            this.numericUpDown_FloorCountVertical.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown_FloorCountVertical.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown_FloorCountVertical.ValueChanged += new System.EventHandler(this.numericUpDown_FloorCountVertical_ValueChanged);
            // 
            // label_X
            // 
            this.label_X.AutoSize = true;
            this.label_X.Location = new System.Drawing.Point(90, 48);
            this.label_X.Name = "label_X";
            this.label_X.Size = new System.Drawing.Size(11, 12);
            this.label_X.TabIndex = 3;
            this.label_X.Text = "x";
            // 
            // groupBox_Output
            // 
            this.groupBox_Output.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_Output.Controls.Add(this.textBox_Output);
            this.groupBox_Output.Location = new System.Drawing.Point(212, 27);
            this.groupBox_Output.Name = "groupBox_Output";
            this.groupBox_Output.Size = new System.Drawing.Size(226, 165);
            this.groupBox_Output.TabIndex = 4;
            this.groupBox_Output.TabStop = false;
            this.groupBox_Output.Text = "輸出文字";
            // 
            // textBox_Output
            // 
            this.textBox_Output.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Output.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_Output.Location = new System.Drawing.Point(15, 28);
            this.textBox_Output.Multiline = true;
            this.textBox_Output.Name = "textBox_Output";
            this.textBox_Output.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_Output.Size = new System.Drawing.Size(194, 120);
            this.textBox_Output.TabIndex = 0;
            // 
            // button_Generate
            // 
            this.button_Generate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_Generate.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Generate.Location = new System.Drawing.Point(12, 198);
            this.button_Generate.Name = "button_Generate";
            this.button_Generate.Size = new System.Drawing.Size(194, 46);
            this.button_Generate.TabIndex = 5;
            this.button_Generate.Text = "生成";
            this.button_Generate.UseVisualStyleBackColor = true;
            this.button_Generate.Click += new System.EventHandler(this.button_Generate_Click);
            // 
            // button_Copy
            // 
            this.button_Copy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Copy.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Copy.Location = new System.Drawing.Point(212, 198);
            this.button_Copy.Name = "button_Copy";
            this.button_Copy.Size = new System.Drawing.Size(226, 46);
            this.button_Copy.TabIndex = 6;
            this.button_Copy.Text = "複製已生成的文字";
            this.button_Copy.UseVisualStyleBackColor = true;
            this.button_Copy.Click += new System.EventHandler(this.button_Copy_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 256);
            this.Controls.Add(this.button_Copy);
            this.Controls.Add(this.button_Generate);
            this.Controls.Add(this.groupBox_Output);
            this.Controls.Add(this.groupBox_Parameters);
            this.Controls.Add(this.menuStrip_Main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip_Main;
            this.Name = "Form_Main";
            this.Text = "Discord踩地雷生成器";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_FloorCountHorizontal)).EndInit();
            this.menuStrip_Main.ResumeLayout(false);
            this.menuStrip_Main.PerformLayout();
            this.groupBox_Parameters.ResumeLayout(false);
            this.groupBox_Parameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_MineCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_FloorCountVertical)).EndInit();
            this.groupBox_Output.ResumeLayout(false);
            this.groupBox_Output.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown_FloorCountHorizontal;
        private System.Windows.Forms.MenuStrip menuStrip_Main;
        private System.Windows.Forms.ToolStripMenuItem 程式PToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 製作名單ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 結束QToolStripMenuItem;
        private System.Windows.Forms.Label label_FloorSizeTitle;
        private System.Windows.Forms.GroupBox groupBox_Parameters;
        private System.Windows.Forms.Label label_X;
        private System.Windows.Forms.NumericUpDown numericUpDown_FloorCountVertical;
        private System.Windows.Forms.Label label_FloorCountTotal;
        private System.Windows.Forms.Label label_MineCount;
        private System.Windows.Forms.NumericUpDown numericUpDown_MineCount;
        private System.Windows.Forms.GroupBox groupBox_Output;
        private System.Windows.Forms.Button button_Generate;
        private System.Windows.Forms.Button button_Copy;
        private System.Windows.Forms.TextBox textBox_Output;
    }
}

