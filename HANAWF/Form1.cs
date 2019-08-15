using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;

namespace HANAWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DSN:SysDsn32 数据源的名称 UID:sql server登录时的身份sa PWD:登录时的密码123456
            //生成连接数据库字符串
            //string ConStr = "DRIVER=/usr/sap/hdbclient/libodbcHDB.so;UID=SYSTEM;PWD=XC!@12qw;SERVERNODE=10.0.101.114:39015;DATABASE=SYSTEM";
            //string ConStr = "DSN=Angelwin;UID=Angelwin;PWD=Y168dtho1";
            //string ConStr = @"DRIVER=D:\Program Files\sap\hdbclient\libodbcHDB.lib;UID=Angelwin;PWD=Y168dtho1;SERVERNODE=10.0.108.144:39015;DATABASE=HXE";
            //string ConStr = "DRIVER={HDBODBC32};UID=Angelwin;PWD=Y168dtho1;SERVERNODE=10.0.108.144:39015;DATABASE=ANGELWIN";
            string ConStr = "DRIVER={HDBODBC};UID=SYSTEM;PWD=XC!@12qw;SERVERNODE=172.16.128.87:39015;DATABASE=SYSTEM";
            //定义SqlConnection对象实例
            OdbcConnection odbcCon = new OdbcConnection(ConStr);
            //string SqlStr = "select * from \"ANGELWIN\".\"product\"";
            string SqlStr = "SELECT  * FROM \"mdm\".\"organization\"";

            OdbcDataAdapter odbcAdapter = new OdbcDataAdapter(SqlStr, odbcCon);
            DataSet ds = new DataSet();

            odbcAdapter.Fill(ds);
            this.dataGridView1.DataSource = ds.Tables[0].DefaultView;


        }
    }
}
