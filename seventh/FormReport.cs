using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace sixth
{
    public partial class FormReport : Form
    {
        public FormReport()
        {
            InitializeComponent();
        }
        void ClearAll()
        {
            txtAddress.Text = "";
            txtContent.Text = "";
            ReportDate.Value = DateTime.Now;
            comboxType.SelectedIndex = -1;
        }
        private void btnReport_Click(object sender, EventArgs e)
        { 
            try
            {
                if (txtAddress.Text.Trim() == "")
                {
                    MessageBox.Show("报修地点不能为空", "提示");
                    txtAddress.Focus();
                    return;
                }
                else if (txtContent.Text.Trim() == "")
                {
                    MessageBox.Show("报修内容不能为空", "提示");
                    txtContent.Focus();
                    return;
                }
                else if (comboxType.SelectedIndex == -1)
                {
                    MessageBox.Show("请选择报修类型", "提示");
                    comboxType.Focus();
                    return;
                }
                string sqlStr1 = "select userName,repairCount from repair_info where userName='"+labUsn.Text+"'";
                DataSet ds = DBConn.getData(sqlStr1);
                if (ds.Tables[0].Rows.Count==0)//如果ds里面不存在数据，说明这个用户第一次报修，直接插入新的记录
                {
                    string sqlStr;
                    sqlStr = "insert into repair_info(userName,repairType,repairAddress,repairContent,repairDate) values('" + labUsn.Text + "','" + comboxType.SelectedItem.ToString() + "','" + txtAddress.Text.Trim() + "','" + txtContent.Text.Trim() + "','" + ReportDate.Value.ToString() + "')";
                    DBConn.upData(sqlStr);
                    MessageBox.Show("报修成功！");
                    ClearAll();
                }
                else//否则的话就是repair_info表里已经有了labUsn里的这个用户。目的就是更新这个用户的报修次数，并插入新的记录
                { 
                    string sqlStr;
                    string count = ds.Tables[0].Rows[ds.Tables[0].Rows.Count - 1][1].ToString();
                    sqlStr = "insert into repair_info(userName,repairType,repairAddress,repairContent,repairDate,repairCount) values('" + labUsn.Text + "','" + comboxType.SelectedItem.ToString() + "','" + txtAddress.Text.Trim() + "','" + txtContent.Text.Trim() + "','" + ReportDate.Value.ToString() + "','" + (int.Parse(count)+1) + "')";
                    //更新语句:sqlStr = "update repair_info set repairType ='" + comboxType.SelectedItem.ToString() + "',repairAddress='" + txtAddress.Text.Trim() + "',repairContent='" + txtContent.Text.Trim() + "',repairDate='" + ReportDate.Value + "',repairCount='" + (int.Parse(ds.Tables[0].Rows[0][1].ToString()) + 1) + "'where userName='" + labUsn.Text + "'"; 
                    DBConn.upData(sqlStr);
                    MessageBox.Show("报修成功！");
                    ClearAll();
                }    
            }
            catch (Exception ex)
            {
                DBConn.conn.Close();
                MessageBox.Show(ex.Message);
            }
        }
        private void FormReport_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("您确认要退出吗？", "退出系统", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Dispose();
                Application.Exit();
            }
            else
                e.Cancel = true;
        }
    }
}
