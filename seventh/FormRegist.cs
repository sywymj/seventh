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
    public partial class FormRegist : Form
    {
        public FormRegist()
        {
            InitializeComponent();
        }
        void ClearAll()
        {
            txtUsn.Text = "";
            txtPwd.Text = "";
        }
        bool userName(string userName)
        {
            string sqlStr = "select userName from user_info where userName='" + txtUsn.Text.Trim() + "'";
            DataSet ds = DBConn.getData(sqlStr);
            if (ds.Tables[0].Rows.Count == 0)
            {
                return false;
            }
            return true;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确认取消注册?", "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Close();
            }      
        }
        private void txtPwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnRegist_Click(sender, e);
            }
        } 
        private void btnRegist_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsn.Text.Trim() == "")
                {
                    MessageBox.Show("用户名不能为空！", "提示");
                    txtUsn.Focus();
                }
                else if (txtPwd.Text.Trim() == "")
                {
                    MessageBox.Show("密码不能为空！", "提示");
                    txtPwd.Focus();
                }
                else if (userName(txtUsn.Text.Trim()))
                {
                    MessageBox.Show("用户名已存在！", "提示");
                    ClearAll();
                }
                else
                {
                    string sqlStr = "insert into user_info values('" + txtUsn.Text.Trim() + "','" + txtPwd.Text.Trim() + "')";
                    if (DBConn.PDData(sqlStr))
                    {
                        MessageBox.Show("用户名为:" + txtUsn.Text + "注册成功！");
                    }
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                DBConn.conn.Close();
                MessageBox.Show(ex.Message);
                ClearAll();
            }
        }
    }
}
