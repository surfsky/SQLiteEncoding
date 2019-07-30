using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using CCWin;

namespace SQLiteEncoding
{
    public partial class FormMain : Form
    {
        //------------------------------------------------
        // Init
        //------------------------------------------------
        public FormMain()
        {
            InitializeComponent();
            ShowEncoding();
        }

        // 获取数据库连接字符串
        string GetConnectionString()
        {
            return string.Format("Data Source ={0};", this.tbDb.Text);
        }

        // 显示字符集下拉框
        void ShowEncoding()
        {
            this.cmbEncoding.Items.Clear();
            this.cmbEncoding.Items.Add("utf-8");
            this.cmbEncoding.Items.Add("gb2312");
            this.cmbEncoding.Items.Add("unicode");
            this.cmbEncoding.SelectedIndex = 0;
        }


        //------------------------------------------------
        // Events
        //------------------------------------------------
        // 关于
        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SQLite encoding demo. 2019-07 https://www.github.com/surfsky/SQLiteEncoding", "About");
        }


        // 打开数据库并显示数据库表
        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (DialogResult.OK ==  dlg.ShowDialog())
            {
                var path = dlg.FileName;
                this.tbDb.Text = path;
                try
                {
                    using (SQLiteConnection conn = new SQLiteConnection(GetConnectionString()))
                    {
                        conn.Open();
                        this.lbItems.DataSource = SQLiteHelper.GetTables(conn);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
        }

        // 数据表变更
        private void lbItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowData();
        }


        // 更换字符集
        private void cmbEncoding_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowData();
        }

        // 显示数据库数据
        private void ShowData()
        {
            var name = this.lbItems.SelectedItem?.ToString();
            if (name == "" || name == null) return;

            SQLiteConvert.Enc = Encoding.GetEncoding(cmbEncoding.SelectedItem.ToString());
            using (SQLiteConnection conn = new SQLiteConnection(GetConnectionString()))
            {
                conn.Open();
                this.grid.DataSource = SQLiteHelper.GetTableData(conn, name);
            }
        }
    }
}
