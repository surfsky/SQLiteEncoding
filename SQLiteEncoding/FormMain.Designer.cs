namespace SQLiteEncoding
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.btnOpen = new CCWin.SkinControl.SkinButton();
            this.tbDb = new CCWin.SkinControl.SkinTextBox();
            this.grid = new CCWin.SkinControl.SkinDataGridView();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.cmbEncoding = new CCWin.SkinControl.SkinComboBox();
            this.skinSplitContainer1 = new CCWin.SkinControl.SkinSplitContainer();
            this.lbItems = new System.Windows.Forms.ListBox();
            this.btnAbout = new CCWin.SkinControl.SkinButton();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skinSplitContainer1)).BeginInit();
            this.skinSplitContainer1.Panel1.SuspendLayout();
            this.skinSplitContainer1.Panel2.SuspendLayout();
            this.skinSplitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpen.BackColor = System.Drawing.Color.Transparent;
            this.btnOpen.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnOpen.DownBack = null;
            this.btnOpen.Location = new System.Drawing.Point(834, 13);
            this.btnOpen.MouseBack = null;
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.NormlBack = null;
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "&Open";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // tbDb
            // 
            this.tbDb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDb.BackColor = System.Drawing.Color.Transparent;
            this.tbDb.DownBack = null;
            this.tbDb.Icon = null;
            this.tbDb.IconIsButton = false;
            this.tbDb.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.tbDb.IsPasswordChat = '\0';
            this.tbDb.IsSystemPasswordChar = false;
            this.tbDb.Lines = new string[0];
            this.tbDb.Location = new System.Drawing.Point(91, 13);
            this.tbDb.Margin = new System.Windows.Forms.Padding(0);
            this.tbDb.MaxLength = 32767;
            this.tbDb.MinimumSize = new System.Drawing.Size(28, 28);
            this.tbDb.MouseBack = null;
            this.tbDb.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.tbDb.Multiline = false;
            this.tbDb.Name = "tbDb";
            this.tbDb.NormlBack = null;
            this.tbDb.Padding = new System.Windows.Forms.Padding(5);
            this.tbDb.ReadOnly = false;
            this.tbDb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbDb.Size = new System.Drawing.Size(722, 28);
            // 
            // 
            // 
            this.tbDb.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDb.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbDb.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.tbDb.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.tbDb.SkinTxt.Name = "BaseText";
            this.tbDb.SkinTxt.Size = new System.Drawing.Size(712, 18);
            this.tbDb.SkinTxt.TabIndex = 0;
            this.tbDb.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tbDb.SkinTxt.WaterText = "";
            this.tbDb.TabIndex = 2;
            this.tbDb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbDb.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tbDb.WaterText = "";
            this.tbDb.WordWrap = true;
            // 
            // grid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.grid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grid.ColumnFont = null;
            this.grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.ColumnSelectForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid.DefaultCellStyle = dataGridViewCellStyle3;
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.EnableHeadersVisualStyles = false;
            this.grid.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grid.HeadFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grid.HeadSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.Name = "grid";
            this.grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.grid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.grid.RowTemplate.Height = 23;
            this.grid.Size = new System.Drawing.Size(694, 481);
            this.grid.TabIndex = 5;
            this.grid.TitleBack = null;
            this.grid.TitleBackColorBegin = System.Drawing.Color.White;
            this.grid.TitleBackColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(196)))), ((int)(((byte)(242)))));
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(9, 15);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(63, 17);
            this.skinLabel1.TabIndex = 6;
            this.skinLabel1.Text = "Database";
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.Location = new System.Drawing.Point(10, 63);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(62, 17);
            this.skinLabel3.TabIndex = 8;
            this.skinLabel3.Text = "Encoding";
            // 
            // cmbEncoding
            // 
            this.cmbEncoding.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbEncoding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEncoding.FormattingEnabled = true;
            this.cmbEncoding.Location = new System.Drawing.Point(91, 58);
            this.cmbEncoding.Name = "cmbEncoding";
            this.cmbEncoding.Size = new System.Drawing.Size(161, 22);
            this.cmbEncoding.TabIndex = 9;
            this.cmbEncoding.WaterText = "";
            this.cmbEncoding.SelectedIndexChanged += new System.EventHandler(this.cmbEncoding_SelectedIndexChanged);
            // 
            // skinSplitContainer1
            // 
            this.skinSplitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.skinSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.skinSplitContainer1.Location = new System.Drawing.Point(12, 104);
            this.skinSplitContainer1.Name = "skinSplitContainer1";
            // 
            // skinSplitContainer1.Panel1
            // 
            this.skinSplitContainer1.Panel1.Controls.Add(this.lbItems);
            // 
            // skinSplitContainer1.Panel2
            // 
            this.skinSplitContainer1.Panel2.Controls.Add(this.grid);
            this.skinSplitContainer1.Size = new System.Drawing.Size(897, 481);
            this.skinSplitContainer1.SplitterDistance = 199;
            this.skinSplitContainer1.TabIndex = 11;
            // 
            // lbItems
            // 
            this.lbItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbItems.FormattingEnabled = true;
            this.lbItems.ItemHeight = 12;
            this.lbItems.Location = new System.Drawing.Point(0, 0);
            this.lbItems.Name = "lbItems";
            this.lbItems.Size = new System.Drawing.Size(199, 481);
            this.lbItems.TabIndex = 13;
            this.lbItems.SelectedIndexChanged += new System.EventHandler(this.lbItems_SelectedIndexChanged);
            // 
            // btnAbout
            // 
            this.btnAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbout.BackColor = System.Drawing.Color.Transparent;
            this.btnAbout.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnAbout.DownBack = null;
            this.btnAbout.Location = new System.Drawing.Point(834, 56);
            this.btnAbout.MouseBack = null;
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.NormlBack = null;
            this.btnAbout.Size = new System.Drawing.Size(75, 23);
            this.btnAbout.TabIndex = 12;
            this.btnAbout.Text = "&About";
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 597);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.skinSplitContainer1);
            this.Controls.Add(this.cmbEncoding);
            this.Controls.Add(this.skinLabel3);
            this.Controls.Add(this.skinLabel1);
            this.Controls.Add(this.tbDb);
            this.Controls.Add(this.btnOpen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SQLiteEncoding Demo (SURFSKY 201907)";
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.skinSplitContainer1.Panel1.ResumeLayout(false);
            this.skinSplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.skinSplitContainer1)).EndInit();
            this.skinSplitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CCWin.SkinControl.SkinButton btnOpen;
        private CCWin.SkinControl.SkinTextBox tbDb;
        private CCWin.SkinControl.SkinDataGridView grid;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private CCWin.SkinControl.SkinComboBox cmbEncoding;
        private CCWin.SkinControl.SkinSplitContainer skinSplitContainer1;
        private CCWin.SkinControl.SkinButton btnAbout;
        private System.Windows.Forms.ListBox lbItems;
    }
}

