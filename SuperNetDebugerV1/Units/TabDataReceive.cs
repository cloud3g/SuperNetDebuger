using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
/*---------------作者：Maximus Ye----------------------*/
/*---------------时间：2013年8月16日---------------*/
/*---------------邮箱：yq@yyzq.net---------*/
/*---------------QQ：275623749---------*/
/*本软件也耗费了我不少的时间和精力，希望各位同行们尊重个人劳动成果，
 * 如果在此版本的基础上修改发布新的版本，请包含原作者信息（包括代码和UI界面相关信息)，为中国的
 * 开源事业做出一点贡献。*/
namespace LeafSoft.Units
{
    public partial class TabDataReceive : UserControl
    {
        List<Units.DataReceive> lstDataReceive = new List<DataReceive>();

        public TabDataReceive()
        {
            InitializeComponent();
            tabData.ContextMenuStrip = CMenu;
        }

        private Units.DataReceive AddNewDataReceive(string SourceName)
        {
            TabPage tpage = new TabPage();
            tpage.Disposed += new EventHandler(tpage_Disposed);
            tpage.Text = SourceName;
            Units.DataReceive UDataReceive = new DataReceive();
            UDataReceive.Name = SourceName;
            tpage.Controls.Add(UDataReceive);
            UDataReceive.Dock = DockStyle.Fill;
            lstDataReceive.Add(UDataReceive);
            this.Invoke(new MethodInvoker(delegate
            {
                tabData.TabPages.Add(tpage);
            }));
            return UDataReceive;
        }

        void tpage_Disposed(object sender, EventArgs e)
        {
            TabPage tpage = (TabPage)sender;
            lstDataReceive.Remove(lstDataReceive.Find(p => p.Name == tpage.Text));
        }

        #region 公有方法
        /// <summary>
        /// 添加数据
        /// </summary>
        /// <param name="SourceName">来源名称</param>
        /// <param name="data">字节数组</param>
        public void AddData(string SourceName, byte[] data)
        {
            Units.DataReceive UDataReceive = lstDataReceive.Find(p => p.Name == SourceName);
            if (UDataReceive == null)
            {
                UDataReceive = AddNewDataReceive(SourceName);
            }
            UDataReceive.AddData(data);
        }
        #endregion

        #region Tab页标题快捷菜单
        private void tabData_DoubleClick(object sender, EventArgs e)
        {
            this.tabData.SelectedTab.Dispose();
        }

        private void MS_Close_Click(object sender, EventArgs e)
        {
            this.tabData.SelectedTab.Dispose();
        }

        private void MS_CloseALL_Click(object sender, EventArgs e)
        {
            foreach(TabPage tpage in this.tabData.TabPages)
            {
                tpage.Dispose();
            }
        }

        private void MS_CloseOthers_Click(object sender, EventArgs e)
        {
            foreach (TabPage tpage in this.tabData.TabPages)
            {
                if (tpage != this.tabData.SelectedTab)
                {
                    tpage.Dispose();
                }
            }
        }
        #endregion
    }
}
