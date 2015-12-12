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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsn.Text.Trim() == "")
                {
                    labMessage.Text ="用户名不能为空!";
                    txtUsn.Focus();//获取焦点
                    return;
                }
                else if (txtPwd.Text.Trim() == "")
                {
                    labMessage.Text ="密码不能为空!";
                    txtPwd.Focus();
                    return;
                }  
                string sqlStr = "select userName,passWord from user_info where userName='"+txtUsn.Text+"'";
                DataSet ds = DBConn.getData(sqlStr);
                if(ds.Tables[0].Rows.Count==0)
                {
                    labMessage.Text = "用户名不存在！请重新输入";
                    txtUsn.Text = "";//文本框置空
                    txtPwd.Text = "";
                    txtUsn.Focus();
                }
                else if (ds.Tables[0].Rows[0][1].ToString() == txtPwd.Text.Trim())
                {
                    FormReport frmReport = new FormReport();
                    frmReport.labUsn.Text = txtUsn.Text.Trim();
                    labMessage.Text = "恭喜您已成功登录！";
                    this.Hide();
                    frmReport.Show(); 
                }
                else
                {
                    labMessage.Text = "密码错误！请重新输入！";
                    txtPwd.Text = "";
                    txtPwd.Focus();
                }
            }
            catch (Exception ex)
            {
                labMessage.Text = "登录异常：" + ex.Message;
                txtUsn.Text = "";
                txtPwd.Text = "";
                txtUsn.Focus();
            }
            finally
            {
                DBConn.conn.Close();//最重要的是要关闭数据库！
            }
        }
        private void txtPwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }
        private void btnRegist_Click(object sender, EventArgs e)
        {
            FormRegist frmRegist = new FormRegist();
            frmRegist.Show();
        }
    }
}
