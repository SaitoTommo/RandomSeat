using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using TableControl;

namespace MainNameSpace
{
    public partial class Form2 : Form
    {
        //int c = 0;
        private TableCon tableCon;
        public delegate void ToCall();
        public delegate void ToCall1(string Data);
        public delegate void ToCall2(int Min, int Max);
        public ToCall ClearListBox;
        public ToCall1 AddList;
        public ToCall2 SetNum;
        //delegate void BW();
        //BW bW;
        public Form2()
        {
            InitializeComponent();
            statusStrip1.Visible = true;
            tableCon = new TableCon(Table1);
            ClearListBox = ClearBox;
            AddList = AddToListBox;
            SetNum = SetNumber;//读取完表格后更改最大值，最小值
            //bW = SelectPosition;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Table1.Columns.Count + 1 >= 256) return;
            Table1.Columns.Add(Table1.Columns.Count.ToString(), Table1.Columns.Count.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Table1.Columns.Count <= 0) { MessageBox.Show("请先添加列"); return; }
            if (Table1.Rows.Count + 1 >= 256) return;
            Table1.Rows.Add();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClearTable();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SelectPosition();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GenerateTable();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 200; i++)
            {
                Table1.Columns.Add(Table1.Columns.Count.ToString(), Table1.Columns.Count.ToString());
            }
            for (int i = 0; i < 200; i++)
            {
                Table1.Rows.Add();
            }
            ShowProgress("就绪", 100.0f);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            SaveTable();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenTable();
        }

        private void ShowProgress(string Status, float Progress)
        {
            StatusLabel.Text = Status;
            ProgressBar.Value = (int)Progress;
        }

        private void Open_Click(object sender, EventArgs e)
        {
            OpenTable();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            SaveTable();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            ClearTable();
        }

        private void AddRow_Click(object sender, EventArgs e)
        {
            if (Table1.Columns.Count <= 0) { MessageBox.Show("请先添加列"); return; }
            if (Table1.Rows.Count + 1 >= 256) return;
            Table1.Rows.Add();
        }

        private void AddColumn_Click(object sender, EventArgs e)
        {
            if (Table1.Columns.Count + 1 >= 256) return;
            Table1.Columns.Add(Table1.Columns.Count.ToString(), Table1.Columns.Count.ToString());
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ProductName + " 版本:" + ProductVersion + " 内核版本:0.0.0.1β" + "\n" + "Prod.GKT GKT作品 guotorre@gktsoft.com" + "\n" + "https://www.gktsoft.com");
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("使用说明" +
                "\n" + "1.添加足够的行和列（多了也没关系，存储时会自动删除）" +
                "\n" + "2.按住Ctrl键框选你需要的坐标（被框选的坐标会高亮显示）" +
                "\n" + "3.输入座号的最小值和最大值并点击生成按钮，并根据学号将单元格内容改为对应的名字或内容" +
                "\n" + "4.点击保存按钮，在弹出的对话框中选择路径并保存" + "\n" + "5.如需打开以前的座位表点击打开按钮即可" +

                "\n2020年6月7日 新内容 增加映射表\n在txt文件第一行添加 Map Ver1.0 GKTSOFT " +
                "\n随后每一行一个名字，行数对应学号，制作映射表后在表格的内右键->应用一个映射表即可使用" +
                "\n" + "如有其他问题请电子邮箱联系 guotorre@gktsoft.com\n或到 https://www.gktsoft.com 留言"
                );
        }

        private void Generate_Click(object sender, EventArgs e)
        {
            GenerateTable();
        }

        private void DeleteRow_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Table1.SelectedRows.Count;)
            {
                MessageBox.Show("Test");
                Table1.Rows.Remove(Table1.SelectedRows[0]);
            }
        }

        private void ClearCell_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Table1.SelectedCells.Count; i++)
            {
                Table1.SelectedCells[i].Value = null;
            }
        }

        private void SelectPosition()
        {
            if (Table1.SelectedCells.Count <= 0) return;
            tableCon.RenewPositions();
            LBox1.Items.Clear();
            ShowProgress("加载中", 0 * 100);
            foreach (DataGridViewCell a in Table1.SelectedCells)
            {
                tableCon.AddPosition(Position.NewPosition(a.RowIndex, a.ColumnIndex));
                LBox1.Items.Add(Position.ToString(Position.NewPosition(a.RowIndex, a.ColumnIndex)));
            }
            label3.Text = $"共{LBox1.Items.Count}个";
            //groupBox1.Text = "已选中坐标 共:" + LBox1.Items.Count.ToString() + "个";
            ShowProgress("完成", 100);
        }

        /// <summary>
        /// 清空ListBox 供调用
        /// </summary>
        public void ClearBox()
        {
            LBox1.Items.Clear();
        }

        /// <summary>
        /// 添加Listbox元素
        /// 供调用
        /// </summary>
        /// <param name="Data"></param>
        public void AddToListBox(string Data)
        {
            //LBox1.Items.Clear();
            LBox1.Items.Add(Data);
            label3.Text = $"共{LBox1.Items.Count}个";
        }

        public void SetNumber(int min, int max)
        {
            TBox1.Text = $"{min}";
            TBox2.Text = $"{max}";
        }

        private void ClearTable()
        {
            tableCon.ClearTable();
            tableCon.RenewPositions();
            LBox1.Items.Clear();
            //groupBox1.Text = "已选中坐标";
            label3.Text = $"";
        }

        private void SaveTable()
        {
            ShowProgress("开始保存", 0.0f);
            saveFileDialog1.FileName = DateTime.Now.ToString("yyyyMMMM") + ".table";
            saveFileDialog1.InitialDirectory = Application.StartupPath;
            saveFileDialog1.ShowDialog();
            tableCon.SaveTable(saveFileDialog1.OpenFile());
            ShowProgress("保存完成", 100.0f);
        }

        private void OpenTable()
        {
            openFileDialog1.InitialDirectory = Application.StartupPath;
            openFileDialog1.ShowDialog();
            ShowProgress("开始读取", 0.0f);
            Stream stream = openFileDialog1.OpenFile();
            if (stream != null)
                tableCon.ReadTable(stream, SetNum, AddList, ClearBox);

            ShowProgress("读取完成", 100.0f);
        }

        private void GenerateTable()
        {
            int Max, Min, Num1 = 0, Num2 = 0;
            string a = "", b = "";
            if (textBox1.Text != null &&
            (textBox1.Text.StartsWith("874") || textBox1.Text.StartsWith("884")))
            {
                //MessageBox.Show("Test");
                a = textBox1.Text.Substring(3, 2);
                b = textBox1.Text.Substring(5, 2);
            }
            if (!int.TryParse(TBox1.Text, out Min) ||
            !int.TryParse(TBox2.Text, out Max) ||
            ((!int.TryParse(a, out Num1) ||
            !int.TryParse(b, out Num2))) && a != "" && b != "")
            {
                MessageBox.Show("请输入正确的值");
                return;
            }
            ShowProgress("开始生成", 0.0f);
            if (Num1 != 0 && Num2 != 0)
            {
                tableCon.GenerateValue(Min, Max, Num1, Num2);
            }
            else
            {
                tableCon.GenerateValue(Min, Max);
            }
            ShowProgress("生成完成", 100.0f);
        }

        private void EditCell_Click(object sender, EventArgs e)
        {
            Table1.BeginEdit(false);
        }

        private void 压力测试勿随意使用ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimeSpan a, b, c, d, f, g, h;
            ClearTable();
            MessageBox.Show("现在开始压力测试，期间可能出现卡死现象，请耐心等待。" +
                "\n若有提示窗口出现请尽可能快的点击以尽可能获得准确结果。");
            a = DateTime.Now - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            for (int i = 0; i < 255; i++)
            {
                Table1.Columns.Add(Table1.Columns.Count.ToString(), Table1.Columns.Count.ToString());
                Table1.Rows.Add();
            }
            #region PressureTest
            Table1.SelectAll();
            c = DateTime.Now - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            SelectPosition();
            d = DateTime.Now - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            tableCon.GenerateValue(1, Table1.Rows.Count * Table1.Columns.Count);
            f = DateTime.Now - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            SaveTable();
            g = DateTime.Now - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            MessageBox.Show("请打开你刚才保存的表");
            h = DateTime.Now - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            OpenTable();
            b = DateTime.Now - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            #endregion
            #region MBox
            MessageBox.Show(string.Format(
                "压力测试完成" +
                "\n共耗时:{0}秒" +
                "\n其中选择坐标占用{1}秒" +
                "\n记录坐标占用{2}秒" +
                "\n生成内容占用{3}秒(包括操作浏览框的时间)" +
                "\n保存表格占用{4}秒(包括操作浏览框的时间)" +
                "\n打开表格占用{5}秒"
                , Convert.ToInt64(b.TotalSeconds - a.TotalSeconds)
                , Convert.ToInt64(c.TotalSeconds - a.TotalSeconds)
                , Convert.ToInt64(d.TotalSeconds - c.TotalSeconds)
                , Convert.ToInt64(f.TotalSeconds - d.TotalSeconds)
                , Convert.ToInt64(g.TotalSeconds - f.TotalSeconds)
                , Convert.ToInt64(b.TotalSeconds - h.TotalSeconds)));
            #endregion
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            /*if (e.Control) 
            {
                label4.Enabled = !label4.Enabled;
                label4.Visible = !label4.Visible;
                textBox1.Enabled = !textBox1.Enabled;
                textBox1.Visible = !textBox1.Visible;
            } */
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            //doDel(bW);
        }
        //void doDel(BW bW) 
        //{
        // bW();
        //}

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Apply_Map(Stream stream)
        {
            string content = "";
            StreamReader SR;
            ArrayList NameList = new ArrayList();//映射数据
            if (stream != null)
            {
                SR = new StreamReader(stream);
                if (SR.ReadLine() != "Map Ver1.0 GKTSOFT") return;
                content = SR.ReadLine();
                while (content != null && content != string.Empty)
                {
                    NameList.Add(content);
                    Debug.WriteLine(content);
                    content = SR.ReadLine();

                }
                tableCon.ApplyMap(NameList);
            }
        }
        /// <summary>
        /// 打开映射表
        /// 读取 
        /// 应用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ApplyMap_Click(object sender, EventArgs e)//应用映射表
        {
            OpenMap();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            OpenMap();
        }

        private void OpenMap()
        {
            Stream stream;
            MapDialog.ShowDialog();
            try
            {
                stream = MapDialog.OpenFile();
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message);
                throw f;
            }
            Apply_Map(stream);
        }
    }
}