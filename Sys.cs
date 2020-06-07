using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using MainNameSpace;
using System.Diagnostics;

namespace TableControl 
{
    struct Position 
	{
        public int Row;
        public int Column;
        public static Position NewPosition(int Row,int Column) 
		{
            Position a;
            a.Row = Row;
            a.Column = Column;
            return a;
		}
        public static string ToString(Position position) 
		{
            return (string.Format("{0};{1}", position.Row, position.Column));
		}
        public static Position Parse(string Str) 
        {
            if (Str == null || Str == "") return NewPosition(-1, -1);
            string[] a;
            Position position;
            a=Regex.Split(Str, ";");
            Debug.WriteLine(Str + " " + a[0] + " " + a[1] + "From Parse");
            //Debug.WriteLine(a[0] + " " + a[1]);
            if (a.Length != 2) return NewPosition(-1,-1);
            position.Column = int.Parse(a[1]);
            position.Row = int.Parse(a[0]);
            return position;
        }
        public static bool operator ==(Position a, Position b) 
        {
            if (a.Column == b.Column && a.Row == b.Row) return true;
            return false;
        }
        public static bool operator !=(Position a, Position b)
        {
            if (a.Column != b.Column || a.Row != b.Row) return true;
            return false;
        }

    }
    class TableCon 
	{
        DataGridView dataGridView;
        ArrayList Positions = new ArrayList();
        Rad rad; 
        public TableCon(DataGridView DGV) 
        {
            dataGridView = DGV;
        }
        public void EditCell(string Value,Position position) 
        {
            if (position.Row >= dataGridView.Rows.Count
                || position.Column >= dataGridView.Columns.Count) 
            {
                AddCell(Value, position);
                return;
            }
            dataGridView[position.Column, position.Row].Value = Value;
        }
        public void AddCell(string Value, Position position) 
        {
            if (dataGridView.Columns.Count-1< position.Column) 
            {
                for (int i = dataGridView.Columns.Count; i < position.Column + 1; i++) 
                {
                    dataGridView.Columns.Add(dataGridView.Columns.Count.ToString(), dataGridView.Columns.Count.ToString());
                }
            }
            if (dataGridView.Rows.Count-1 < position.Row)
            {
                for (int i = dataGridView.Rows.Count; i < position.Row + 1; i++)
                {
                    dataGridView.Rows.Add();
                }
            }
            dataGridView[position.Column, position.Row].Value = Value;
        }
        public void AddPosition(Position position) 
		{
            if (Positions.Contains(position)) return;
            Positions.Add(position);
		}
        public void RenewPositions()
        {
            Positions = new ArrayList();
        }
        public void GenerateValue(int Min,int Max) 
        {
            rad = new Rad(Min, Max+1);
            foreach (Position a in Positions) 
            {
                Debug.WriteLine(Position.ToString(a));
                dataGridView.CurrentCell = dataGridView[a.Column, a.Row];
                dataGridView.CurrentCell.Value =rad.RadInt(); 
            }
        }
        /// <summary>
        /// 愿Num1和Num2终成眷属
        /// </summary>
        /// <param name="Min"></param>
        /// <param name="Max"></param>
        /// <param name="Num1">The Girl</param>
        /// <param name="Num2">The infatuated Boy</param>
        public void GenerateValue(int Min, int Max,int Num1,int Num2)
        {
            ArrayList b = new ArrayList(2);
            Position j, k;
            object d;
            rad = new Rad(Min, Max + 1);
            foreach (Position a in Positions)
            {
                dataGridView.CurrentCell = dataGridView[a.Column, a.Row];
                dataGridView.CurrentCell.Value = rad.RadInt();
                if ((int)dataGridView.CurrentCell.Value == Num1|| (int)dataGridView.CurrentCell.Value == Num2) b.Add(a);
            }
            if (b.Count>1&&b.Count<3&&Num1<=Max&&Num1>=Min && Num2 <= Max && Num2 >= Min&&Num1!=Num2)
            {
                j = (Position)b[0];k = (Position)b[1];
                if (j.Column - 1>=0&&dataGridView[j.Column - 1, j.Row].Value != null)
                {
                    d = dataGridView[j.Column - 1, j.Row].Value;
                    dataGridView[j.Column - 1, j.Row].Value = dataGridView[k.Column, k.Row].Value;
                    dataGridView[k.Column, k.Row].Value = d;
                    return;
                }
                else if (j.Column + 1>=1&& j.Column + 1 <dataGridView.Columns.Count&& dataGridView[j.Column + 1, j.Row].Value != null)
                {
                    d = dataGridView[j.Column + 1, j.Row].Value;
                    dataGridView[j.Column + 1, j.Row].Value = dataGridView[k.Column, k.Row].Value;
                    dataGridView[k.Column, k.Row].Value = d;
                    return;
                }
                if (k.Column - 1 >= 0 && dataGridView[k.Column - 1, k.Row].Value != null)
                {
                    d = dataGridView[k.Column - 1, k.Row].Value;
                    dataGridView[k.Column - 1, k.Row].Value = dataGridView[j.Column, j.Row].Value;
                    dataGridView[j.Column, j.Row].Value = d;
                    return;
                }
                else if (k.Column + 1 >= 1 && k.Column + 1 < dataGridView.Columns.Count && dataGridView[k.Column + 1, k.Row].Value != null)
                {
                    d = dataGridView[k.Column + 1, k.Row].Value;
                    dataGridView[k.Column + 1, k.Row].Value = dataGridView[j.Column, j.Row].Value;
                    dataGridView[j.Column, j.Row].Value = d;
                    return;
                }
            }
        }
        public void SaveTable(Stream stream) 
        {
            string Data="",Data1="";
            using (StreamWriter SW = new StreamWriter(stream))
            {
                foreach (DataGridViewColumn a in dataGridView.Columns)
                {
                    foreach (DataGridViewRow b in dataGridView.Rows)
                    {
                        if (dataGridView[a.Index, b.Index].Value != null) 
                        {
                            Data += string.Format(
                                "{0}@{1};{2}:",
                                dataGridView[a.Index, b.Index].Value,
                                dataGridView[a.Index, b.Index].RowIndex,
                                dataGridView[a.Index, b.Index].ColumnIndex
                                );
                            Data1 += Position.ToString(Position.NewPosition(b.Index, a.Index))+"&";
                            Debug.WriteLine(Position.ToString(Position.NewPosition(b.Index, a.Index)) + "&" + "From Save");
                        }
                    }
                }
                SW.WriteLine(Data+"\n"+Data1);
                SW.Close();
            }
        }
        public void ReadTable(Stream stream, Form2.ToCall2 AfterAllDone = null, Form2.ToCall1 AfterDone = null, Form2.ToCall BeforeDone = null)
        {
            string Data1,Data2;//Data 全部数据 Data1 座位表数据 Data2 选中的位置
            string[] a, b;//用于读取座位表数据的临时变量
            string[] D;//用于读取选中位置的数据
            ClearTable();
            BeforeDone?.Invoke();
            using (StreamReader SR = new StreamReader(stream)) 
            {
                try
                {
                    Data1 = SR.ReadLine();//读取第一行 座位表数据
                    Data2 = SR.ReadLine();//读取第二行 选中位置数据
                }
                catch (Exception f)
                {
                    MessageBox.Show(f.Message);
                    throw f;
                }
                //Regex.Split(Data,"\n")
                a = Regex.Split(Data1,@":");
                D = Regex.Split(Data2, @"&");
                foreach (string c in a) 
                {
                    if (c == "" || c == null) continue;
                    b = Regex.Split(c, "@");
                    AddCell(b[0], Position.Parse(b[1]));
                }
                foreach (string d in D) 
                {
                    if (Position.Parse(d) == Position.NewPosition(-1,-1)) continue;
                    Debug.WriteLine(d + "From Read Line");
                    AddPosition(Position.Parse(d));
                    AfterDone?.Invoke(d);
                }
            }
            AfterAllDone?.Invoke(1, a.Length - 1);
        }
        /// <summary>
        /// 应用映射表
        /// 数字对应行
        /// </summary>
        /// <param name="NameList">映射表</param>
        public void ApplyMap(ArrayList NameList) 
        {
            foreach (Position position in Positions) 
            {
                Debug.WriteLine(dataGridView[position.Column, position.Row].Value+"From Map");
                if ((dataGridView[position.Column, position.Row].Value as string) != string.Empty) 
                {
                    int index = Convert.ToInt32(dataGridView[position.Column, position.Row].Value);
                    //int index = int.Parse((dataGridView[position.Column, position.Row].Value as string));
                    if ((index - 1) >= NameList.Count) continue;
                    EditCell((string)NameList[index-1], position);
                }
            }
        }
        public void ClearTable() 
        {
            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();
        }
    }
    class Rad 
	{
        ArrayList NumList = new ArrayList(10);
        static Random R = new Random();
        int iMin, iMax;
        public Rad(int Min,int Max) 
        {
            NumList = new ArrayList(Max);
            iMin = Min;
            iMax = Max;
        }
        public  int RadInt() 
		{
            int a = R.Next(iMin, iMax),b=0;
            while (NumList.Contains(a)&&b<100) 
            {
                a = R.Next(iMin, iMax);
                b++;
            }
            if (NumList.Count >= 100) NumList.RemoveAt(0);
            NumList.Add(a);
            return a;
		}
	}
}