using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Diagnostics;

namespace My_IE
{
    public partial class Form1 : Form
    {
        private Panel panel2;
        private ToolStripDropDownButton tsdRight;
        private ToolStripDropDownButton tsdClose;
        private ToolStripDropDownButton tsdZhuye;
        private ToolStripDropDownButton tsdShuaxin;
        private ToolStripDropDownButton tsdHuifu;
        private ToolStripDropDownButton tsdWuheng;
        private ImageList ilyuanshiBtn;
        private ImageList iljingguoBtn;
        private ImageList ildianjiBTN;
        private ToolStripDropDownButton tsdLeft;
        private ToolStrip toolStrip1;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem 文件UToolStripMenuItem;
        private ToolStripMenuItem 查看ToolStripMenuItem;
        private ToolStripMenuItem 收藏BToolStripMenuItem;
        private ToolStripMenuItem 帐户UToolStripMenuItem;
        private ToolStripMenuItem 工具ToolStripMenuItem;
        private ToolStripMenuItem 帮助HToolStripMenuItem;
        private TreeView treeView1;
        private IContainer components;
        private ToolStripMenuItem internet选项ToolStripMenuItem;
        private Panel panel1;
        int index = 0;
        public List<WebBrowser> WebBrowserArr = new List<WebBrowser>();
        public List<TabPage> pages = new List<TabPage>();
        public Dictionary<int, string> names = new Dictionary<int, string>();
        private ComboBox comboBox1;
        private TabPage tabPage1;
        private WebBrowser webBrowser1;
        private TabControl tabControl1;
        string textName = "";
        public string HisXml = "History.xml";
        private ToolStripMenuItem 我的收藏夹ToolStripMenuItem;
        private ToolStripMenuItem 新建窗口ToolStripMenuItem;
        private ToolStripMenuItem 主页ToolStripMenuItem;
        private ToolStripMenuItem internet选项ToolStripMenuItem1;
        private ToolStripMenuItem 关于我的浏览器ToolStripMenuItem;
        bool GetChange = false;
        public Form1()
        {
            InitializeComponent();

        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsdLeft = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsdRight = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsdClose = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsdShuaxin = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsdZhuye = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsdHuifu = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsdWuheng = new System.Windows.Forms.ToolStripDropDownButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.ilyuanshiBtn = new System.Windows.Forms.ImageList(this.components);
            this.iljingguoBtn = new System.Windows.Forms.ImageList(this.components);
            this.ildianjiBTN = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件UToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建窗口ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.主页ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.收藏BToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.我的收藏夹ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帐户UToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.工具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.internet选项ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.internet选项ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.关于我的浏览器ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1226, 55);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(293, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(852, 20);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox1_KeyDown);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(263, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(912, 30);
            this.label1.TabIndex = 1;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.CanOverflow = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsdLeft,
            this.tsdRight,
            this.tsdClose,
            this.tsdShuaxin,
            this.tsdZhuye,
            this.tsdHuifu,
            this.tsdWuheng});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStrip1.Location = new System.Drawing.Point(1, 1);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(259, 61);
            this.toolStrip1.TabIndex = 0;
            // 
            // tsdLeft
            // 
            this.tsdLeft.Image = ((System.Drawing.Image)(resources.GetObject("tsdLeft.Image")));
            this.tsdLeft.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsdLeft.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsdLeft.Name = "tsdLeft";
            this.tsdLeft.ShowDropDownArrow = false;
            this.tsdLeft.Size = new System.Drawing.Size(35, 47);
            this.tsdLeft.Text = "后退";
            this.tsdLeft.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsdLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tsdLeft_MouseUp);
            this.tsdLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tsdLeft_MouseDown);
            this.tsdLeft.MouseLeave += new System.EventHandler(this.tsdLeft_MouseLeave);
            this.tsdLeft.MouseEnter += new System.EventHandler(this.tsdLeft_MouseEnter);
            this.tsdLeft.Click += new System.EventHandler(this.tsdLeft_Click);
            // 
            // tsdRight
            // 
            this.tsdRight.Image = ((System.Drawing.Image)(resources.GetObject("tsdRight.Image")));
            this.tsdRight.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsdRight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsdRight.Name = "tsdRight";
            this.tsdRight.ShowDropDownArrow = false;
            this.tsdRight.Size = new System.Drawing.Size(35, 48);
            this.tsdRight.Text = "前进";
            this.tsdRight.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsdRight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tsdRight_MouseUp);
            this.tsdRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tsdRight_MouseDown);
            this.tsdRight.MouseLeave += new System.EventHandler(this.tsdRight_MouseLeave);
            this.tsdRight.MouseEnter += new System.EventHandler(this.tsdRight_MouseEnter);
            this.tsdRight.Click += new System.EventHandler(this.tsdRight_Click);
            // 
            // tsdClose
            // 
            this.tsdClose.Image = ((System.Drawing.Image)(resources.GetObject("tsdClose.Image")));
            this.tsdClose.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsdClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsdClose.Name = "tsdClose";
            this.tsdClose.ShowDropDownArrow = false;
            this.tsdClose.Size = new System.Drawing.Size(35, 50);
            this.tsdClose.Text = "停止";
            this.tsdClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsdClose.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tsdClose_MouseUp);
            this.tsdClose.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tsdClose_MouseDown);
            this.tsdClose.MouseLeave += new System.EventHandler(this.tsdClose_MouseLeave);
            this.tsdClose.MouseEnter += new System.EventHandler(this.tsdClose_MouseEnter);
            this.tsdClose.Click += new System.EventHandler(this.tsdClose_Click);
            // 
            // tsdShuaxin
            // 
            this.tsdShuaxin.Image = ((System.Drawing.Image)(resources.GetObject("tsdShuaxin.Image")));
            this.tsdShuaxin.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsdShuaxin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsdShuaxin.Name = "tsdShuaxin";
            this.tsdShuaxin.ShowDropDownArrow = false;
            this.tsdShuaxin.Size = new System.Drawing.Size(35, 49);
            this.tsdShuaxin.Text = "刷新";
            this.tsdShuaxin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsdShuaxin.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tsdShuaxin_MouseUp);
            this.tsdShuaxin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tsdShuaxin_MouseDown);
            this.tsdShuaxin.MouseLeave += new System.EventHandler(this.tsdShuaxin_MouseLeave);
            this.tsdShuaxin.MouseEnter += new System.EventHandler(this.tsdShuaxin_MouseEnter);
            this.tsdShuaxin.Click += new System.EventHandler(this.tsdShuaxin_Click);
            // 
            // tsdZhuye
            // 
            this.tsdZhuye.Image = ((System.Drawing.Image)(resources.GetObject("tsdZhuye.Image")));
            this.tsdZhuye.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsdZhuye.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsdZhuye.Name = "tsdZhuye";
            this.tsdZhuye.ShowDropDownArrow = false;
            this.tsdZhuye.Size = new System.Drawing.Size(35, 48);
            this.tsdZhuye.Text = "主页";
            this.tsdZhuye.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsdZhuye.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tsdZhuye_MouseUp);
            this.tsdZhuye.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tsdZhuye_MouseDown);
            this.tsdZhuye.MouseLeave += new System.EventHandler(this.tsdZhuye_MouseLeave);
            this.tsdZhuye.MouseEnter += new System.EventHandler(this.tsdZhuye_MouseEnter);
            this.tsdZhuye.Click += new System.EventHandler(this.tsdZhuye_Click);
            // 
            // tsdHuifu
            // 
            this.tsdHuifu.Image = ((System.Drawing.Image)(resources.GetObject("tsdHuifu.Image")));
            this.tsdHuifu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsdHuifu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsdHuifu.Name = "tsdHuifu";
            this.tsdHuifu.ShowDropDownArrow = false;
            this.tsdHuifu.Size = new System.Drawing.Size(47, 48);
            this.tsdHuifu.Text = "新窗口";
            this.tsdHuifu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsdHuifu.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tsdHuifu_MouseUp);
            this.tsdHuifu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tsdHuifu_MouseDown);
            this.tsdHuifu.MouseLeave += new System.EventHandler(this.tsdHuifu_MouseLeave);
            this.tsdHuifu.MouseEnter += new System.EventHandler(this.tsdHuifu_MouseEnter);
            this.tsdHuifu.Click += new System.EventHandler(this.tsdHuifu_Click);
            // 
            // tsdWuheng
            // 
            this.tsdWuheng.Image = ((System.Drawing.Image)(resources.GetObject("tsdWuheng.Image")));
            this.tsdWuheng.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsdWuheng.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsdWuheng.Name = "tsdWuheng";
            this.tsdWuheng.ShowDropDownArrow = false;
            this.tsdWuheng.Size = new System.Drawing.Size(35, 49);
            this.tsdWuheng.Text = "无痕";
            this.tsdWuheng.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.tsdWuheng.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsdWuheng.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tsdWuheng_MouseUp);
            this.tsdWuheng.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tsdWuheng_MouseDown);
            this.tsdWuheng.MouseLeave += new System.EventHandler(this.tsdWuheng_MouseLeave);
            this.tsdWuheng.MouseEnter += new System.EventHandler(this.tsdWuheng_MouseEnter);
            this.tsdWuheng.Click += new System.EventHandler(this.tsdWuheng_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.treeView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 528);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.White;
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(121, 97);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // ilyuanshiBtn
            // 
            this.ilyuanshiBtn.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.ilyuanshiBtn.ImageSize = new System.Drawing.Size(30, 28);
            this.ilyuanshiBtn.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // iljingguoBtn
            // 
            this.iljingguoBtn.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iljingguoBtn.ImageStream")));
            this.iljingguoBtn.TransparentColor = System.Drawing.Color.Transparent;
            this.iljingguoBtn.Images.SetKeyName(0, "left2.jpg");
            this.iljingguoBtn.Images.SetKeyName(1, "right2.jpg");
            this.iljingguoBtn.Images.SetKeyName(2, "close2.jpg");
            this.iljingguoBtn.Images.SetKeyName(3, "shuaxin2.jpg");
            this.iljingguoBtn.Images.SetKeyName(4, "zhuye2.jpg");
            this.iljingguoBtn.Images.SetKeyName(5, "huifu2.jpg");
            this.iljingguoBtn.Images.SetKeyName(6, "wuheng2.jpg");
            // 
            // ildianjiBTN
            // 
            this.ildianjiBTN.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ildianjiBTN.ImageStream")));
            this.ildianjiBTN.TransparentColor = System.Drawing.Color.Transparent;
            this.ildianjiBTN.Images.SetKeyName(0, "left3.jpg");
            this.ildianjiBTN.Images.SetKeyName(1, "right3.jpg");
            this.ildianjiBTN.Images.SetKeyName(2, "close3.jpg");
            this.ildianjiBTN.Images.SetKeyName(3, "shuaxin3.jpg");
            this.ildianjiBTN.Images.SetKeyName(4, "zhuye3.jpg");
            this.ildianjiBTN.Images.SetKeyName(5, "huifu3.jpg");
            this.ildianjiBTN.Images.SetKeyName(6, "wuheng3.jpg");
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件UToolStripMenuItem,
            this.查看ToolStripMenuItem,
            this.收藏BToolStripMenuItem,
            this.帐户UToolStripMenuItem,
            this.工具ToolStripMenuItem,
            this.帮助HToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1226, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件UToolStripMenuItem
            // 
            this.文件UToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建窗口ToolStripMenuItem,
            this.主页ToolStripMenuItem});
            this.文件UToolStripMenuItem.Name = "文件UToolStripMenuItem";
            this.文件UToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.文件UToolStripMenuItem.Text = "文件(&F)";
            // 
            // 新建窗口ToolStripMenuItem
            // 
            this.新建窗口ToolStripMenuItem.Name = "新建窗口ToolStripMenuItem";
            this.新建窗口ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.新建窗口ToolStripMenuItem.Text = "新建窗口";
            this.新建窗口ToolStripMenuItem.Click += new System.EventHandler(this.新建窗口ToolStripMenuItem_Click);
            // 
            // 主页ToolStripMenuItem
            // 
            this.主页ToolStripMenuItem.Name = "主页ToolStripMenuItem";
            this.主页ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.主页ToolStripMenuItem.Text = "　主页";
            this.主页ToolStripMenuItem.Click += new System.EventHandler(this.主页ToolStripMenuItem_Click);
            // 
            // 查看ToolStripMenuItem
            // 
            this.查看ToolStripMenuItem.Name = "查看ToolStripMenuItem";
            this.查看ToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.查看ToolStripMenuItem.Text = "查看(&V)";
            // 
            // 收藏BToolStripMenuItem
            // 
            this.收藏BToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.我的收藏夹ToolStripMenuItem});
            this.收藏BToolStripMenuItem.Name = "收藏BToolStripMenuItem";
            this.收藏BToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.收藏BToolStripMenuItem.Text = "收藏(&B)";
            // 
            // 我的收藏夹ToolStripMenuItem
            // 
            this.我的收藏夹ToolStripMenuItem.Name = "我的收藏夹ToolStripMenuItem";
            this.我的收藏夹ToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.我的收藏夹ToolStripMenuItem.Text = "我的收藏夹";
            this.我的收藏夹ToolStripMenuItem.Click += new System.EventHandler(this.我的收藏夹ToolStripMenuItem_Click);
            // 
            // 帐户UToolStripMenuItem
            // 
            this.帐户UToolStripMenuItem.Name = "帐户UToolStripMenuItem";
            this.帐户UToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.帐户UToolStripMenuItem.Text = "帐户(&U)";
            // 
            // 工具ToolStripMenuItem
            // 
            this.工具ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.internet选项ToolStripMenuItem,
            this.internet选项ToolStripMenuItem1});
            this.工具ToolStripMenuItem.Name = "工具ToolStripMenuItem";
            this.工具ToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.工具ToolStripMenuItem.Text = "工具(&T)";
            // 
            // internet选项ToolStripMenuItem
            // 
            this.internet选项ToolStripMenuItem.Name = "internet选项ToolStripMenuItem";
            this.internet选项ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.internet选项ToolStripMenuItem.Text = "清空历史记录";
            this.internet选项ToolStripMenuItem.Click += new System.EventHandler(this.internet选项ToolStripMenuItem_Click);
            // 
            // internet选项ToolStripMenuItem1
            // 
            this.internet选项ToolStripMenuItem1.Name = "internet选项ToolStripMenuItem1";
            this.internet选项ToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.internet选项ToolStripMenuItem1.Text = "Internet选项";
            this.internet选项ToolStripMenuItem1.Click += new System.EventHandler(this.internet选项ToolStripMenuItem1_Click);
            // 
            // 帮助HToolStripMenuItem
            // 
            this.帮助HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于我的浏览器ToolStripMenuItem});
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            this.帮助HToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.帮助HToolStripMenuItem.Text = "帮助(&H)";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.webBrowser1);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(5);
            this.tabPage1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPage1.Size = new System.Drawing.Size(968, 503);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "欢迎使用我的IE浏览器";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(5, 5);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(958, 493);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.Navigating);
            this.webBrowser1.NewWindow += new System.ComponentModel.CancelEventHandler(this.NewWindow);
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.DocumentCompleted);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(150, 17);
            this.tabControl1.Location = new System.Drawing.Point(250, 79);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(976, 528);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 4;
            this.tabControl1.DoubleClick += new System.EventHandler(this.tabControl1_DoubleClick);
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // 关于我的浏览器ToolStripMenuItem
            // 
            this.关于我的浏览器ToolStripMenuItem.Name = "关于我的浏览器ToolStripMenuItem";
            this.关于我的浏览器ToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.关于我的浏览器ToolStripMenuItem.Text = "关于我的浏览器";
            this.关于我的浏览器ToolStripMenuItem.Click += new System.EventHandler(this.关于我的浏览器ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1226, 607);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MinimumSize = new System.Drawing.Size(640, 443);
            this.Name = "Form1";
            this.Text = "很菜的浏览器";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.tabControl1.ItemSize = new Size(150, tabControl1.ItemSize.Height);
            this.treeView1.Size = new Size(panel2.Size.Width - 1, panel2.Size.Height);
           
            我的收藏夹ToolStripMenuItem_Click(sender, e);
            ReadXml();
            ReadLishi();
            WebBrowserArr.Add(webBrowser1);
            pages.Add(tabPage1);
            this.ilyuanshiBtn.Images.Add(tsdLeft.Image);
            this.ilyuanshiBtn.Images.Add(tsdRight.Image);
            this.ilyuanshiBtn.Images.Add(tsdClose.Image);
            this.ilyuanshiBtn.Images.Add(tsdShuaxin.Image);

            this.ilyuanshiBtn.Images.Add(tsdZhuye.Image);
            this.ilyuanshiBtn.Images.Add(tsdHuifu.Image);
            this.ilyuanshiBtn.Images.Add(tsdWuheng.Image);

        }
        /// <summary>
        /// 读取历史文件
        /// </summary>
        private void ReadLishi()
        {
            FileStream fs = new FileStream("Lishi.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            treeView1.Nodes.Add("历史浏览记录");
            string str = "";
            FileInfo fi = new FileInfo("Lishi.txt");
            if (fi.Length != 0)
            {
                int ix =0;
                while (true)
                {
                    try
                    {
                        str = sr.ReadLine().Trim();
                        treeView1.Nodes[1].Nodes.Add(str);
                        treeView1.Nodes[1].Nodes[ix].Tag = str;
                        comboBox1.Items.Add(str);
                        ix++;
                    }
                    catch
                    {
                        break;
                    }
                }
            }

            sr.Close();
            fs.Close();
        }
        /// <summary>
        /// 读取xml文件
        /// </summary>
        private void ReadXml()
        {
            XmlDocument xd = new XmlDocument();
            xd.Load("MyLoveIEAdd.xml");
            int Xmlindex = 0;
            int Nodeindex1 =0;
            int Nodeindex2 = 0;
            int Nodeindex3 = 0;
            int Nodeindex4 = 0;
            foreach (XmlNode node1 in xd.DocumentElement)
            {
                if (node1.Name == "title")
                {
                    treeView1.Nodes.Add(node1.InnerText);
                }
                if (node1.Name == "最近登录")
                {
                    treeView1.Nodes[0].Nodes.Add(node1.Name);
                    for (int i = 0; i < node1.ChildNodes.Count; i++)
                    {
                        foreach (XmlNode node2 in node1.ChildNodes[i])
                        {
                            switch (node2.Name)
                            {
                                case "Name":
                                    treeView1.Nodes[0].Nodes[Xmlindex].Nodes.Add(node2.InnerText);
                                    break;
                                case "url":
                                    treeView1.Nodes[0].Nodes[Xmlindex].Nodes[Nodeindex1].Tag = node2.InnerText;
                                    Nodeindex1++;
                                    break;
                            }
                        }
                    }
                    Xmlindex++;
                   
                }
                if (node1.Name == "我最喜欢")
                {
                    treeView1.Nodes[0].Nodes.Add(node1.Name);
                    for (int i = 0; i < node1.ChildNodes.Count; i++)
                    {
                        foreach (XmlNode node2 in node1.ChildNodes[i])
                        {
                            switch (node2.Name)
                            {
                                case "Name":
                                    treeView1.Nodes[0].Nodes[Xmlindex].Nodes.Add(node2.InnerText);
                                    break;
                                case "url":
                                    treeView1.Nodes[0].Nodes[Xmlindex].Nodes[Nodeindex2].Tag = node2.InnerText;
                                    Nodeindex2++;
                                    break;
                            }
                        }
                    }
                    Xmlindex++;
                }
                if (node1.Name == "我的收藏")
                {
                    treeView1.Nodes[0].Nodes.Add(node1.Name);
                    for (int i = 0; i < node1.ChildNodes.Count; i++)
                    {
                        foreach (XmlNode node2 in node1.ChildNodes[i])
                        {
                            switch (node2.Name)
                            {
                                case "Name":
                                    treeView1.Nodes[0].Nodes[Xmlindex].Nodes.Add(node2.InnerText);
                                    break;
                                case "url":
                                    treeView1.Nodes[0].Nodes[Xmlindex].Nodes[Nodeindex3].Tag = node2.InnerText;
                                    Nodeindex3++;
                                    break;
                            }
                        }
                    }
                    Xmlindex++;
                }
                if (node1.Name == "值得推荐的网站")
                {
                    treeView1.Nodes[0].Nodes.Add(node1.Name);
                    for (int i = 0; i < node1.ChildNodes.Count; i++)
                    {
                        foreach (XmlNode node2 in node1.ChildNodes[i])
                        {
                            switch (node2.Name)
                            {
                                case "Name":
                                    treeView1.Nodes[0].Nodes[Xmlindex].Nodes.Add(node2.InnerText);
                                    break;
                                case "url":
                                    treeView1.Nodes[0].Nodes[Xmlindex].Nodes[Nodeindex4].Tag = node2.InnerText;
                                    Nodeindex4++;
                                    break;
                            }
                        }
                    }
                    Xmlindex++;
                }
            }

        }




        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panel2.ClientRectangle,
                                         SystemColors.Control,
                                         0,
                                         ButtonBorderStyle.Solid,
                                         Color.Red,
                                         0,
                                         ButtonBorderStyle.Solid,
                                         Color.Gray,
                                         1,
                                         ButtonBorderStyle.Solid,
                                         Color.Red,
                                         0,
                                         ButtonBorderStyle.Solid);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panel1.ClientRectangle,
                                       Color.DarkGray,
                                       0,
                                       ButtonBorderStyle.Solid,
                                       Color.DarkGray,
                                       1,
                                       ButtonBorderStyle.Solid,
                                       Color.DarkGray,
                                       0,
                                       ButtonBorderStyle.Solid,
                                       Color.DarkGray,
                                       1,
                                       ButtonBorderStyle.Solid);
        }

        private void tsdClose_Click(object sender, EventArgs e)
        {
            tabControl1_DoubleClick(sender, e);
        }

        private void tsdLeft_Click(object sender, EventArgs e)
        {
            this.WebBrowserArr[index].GoBack();
        }

        private void tsdRight_Click(object sender, EventArgs e)
        {
            this.WebBrowserArr[index].GoForward();
        }

        private void tsdZhuye_Click(object sender, EventArgs e)
        {
            this.WebBrowserArr[index].GoHome();
        }

        private void tsdShuaxin_Click(object sender, EventArgs e)
        {
            this.WebBrowserArr[index].Refresh();
        }


        private void DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (WebBrowserArr[index].Document.Url.ToString() == "about:blank")
            {
                this.Text = "欢迎来到我的IE浏览器！";
                pages[index].Text = "空白页";
                this.comboBox1.Text = "about:blank";
            }
            else
            {
                this.Text = this.WebBrowserArr[index].DocumentTitle;
                this.comboBox1.Text = WebBrowserArr[index].Document.Url.ToString();
                this.comboBox1.Items.Remove(this.comboBox1.Text);
                this.comboBox1.Items.Add(WebBrowserArr[index].Document.Url.ToString());
                this.comboBox1.Text = WebBrowserArr[index].Document.Url.ToString();
            }

        }


        /// <summary>
        /// 网页方法集合
        /// </summary>
        private void Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {

            WebBrowser web = (WebBrowser)sender;
            this.pages[index].Text = web.DocumentTitle;


        }
        private void NewWindow(object sender, CancelEventArgs e)
        {
            GetChange = false;
            WebBrowser web = (WebBrowser)sender;
            textName = web.DocumentTitle;
            Console.WriteLine(index.ToString());
            if (web.Document.ActiveElement != null)
            {
                WebBrowser newWeb = new WebBrowser();
                TabPage tab = new TabPage();
                
                tabControl1.Controls.Add(tab);
                e.Cancel = true;
                

                newWeb.Dock = DockStyle.Fill;
                    //this.webBrowser1.NewWindow += new System.ComponentModel.CancelEventHandler(this.NewWindow);
                newWeb.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(Navigating);
                newWeb.NewWindow += new System.ComponentModel.CancelEventHandler(NewWindow);
                newWeb.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(DocumentCompleted);
                WebBrowserArr.Add(newWeb);
                pages.Add(tab);
                tab.Controls.Add(newWeb);
                newWeb.Navigate(WebBrowserArr[index].Document.ActiveElement.GetAttribute("href"));
                this.comboBox1.Text = WebBrowserArr[index].Document.ActiveElement.GetAttribute("href");
                tab.Text = newWeb.DocumentTitle;
                pages[index].Text = textName;
                tab.Width = 150;
                tabControl1.SelectedIndex = tabControl1.Controls.Count - 1;
                GetChange = true;
                
            }
        }



        #region 按钮样式
        private void tsdLeft_MouseEnter(object sender, EventArgs e)
        {
            this.tsdLeft.Image = iljingguoBtn.Images[0];
        }

        private void tsdLeft_MouseLeave(object sender, EventArgs e)
        {
            this.tsdLeft.Image = ilyuanshiBtn.Images[0];
        }

        private void tsdLeft_MouseDown(object sender, MouseEventArgs e)
        {
            this.tsdLeft.Image = ildianjiBTN.Images[0];
        }

        private void tsdLeft_MouseUp(object sender, MouseEventArgs e)
        {
            this.tsdLeft.Image = iljingguoBtn.Images[0];
        }

        private void tsdRight_MouseDown(object sender, MouseEventArgs e)
        {
            this.tsdRight.Image = ildianjiBTN.Images[1];
        }

        private void tsdRight_MouseEnter(object sender, EventArgs e)
        {
            this.tsdRight.Image = iljingguoBtn.Images[1];
        }

        private void tsdRight_MouseLeave(object sender, EventArgs e)
        {
            this.tsdRight.Image = ilyuanshiBtn.Images[1];
        }

        private void tsdRight_MouseUp(object sender, MouseEventArgs e)
        {
            this.tsdRight.Image = iljingguoBtn.Images[1];
        }

        private void tsdClose_MouseDown(object sender, MouseEventArgs e)
        {
            this.tsdClose.Image = ildianjiBTN.Images[2];
        }

        private void tsdClose_MouseEnter(object sender, EventArgs e)
        {
            this.tsdClose.Image = iljingguoBtn.Images[2];
        }

        private void tsdClose_MouseLeave(object sender, EventArgs e)
        {
            this.tsdClose.Image = ilyuanshiBtn.Images[2];
        }

        private void tsdClose_MouseUp(object sender, MouseEventArgs e)
        {
            this.tsdClose.Image = iljingguoBtn.Images[2];
        }

        private void tsdShuaxin_MouseDown(object sender, MouseEventArgs e)
        {
            this.tsdShuaxin.Image = ildianjiBTN.Images[3];
        }

        private void tsdShuaxin_MouseEnter(object sender, EventArgs e)
        {
            this.tsdShuaxin.Image = iljingguoBtn.Images[3];
        }

        private void tsdShuaxin_MouseLeave(object sender, EventArgs e)
        {
            this.tsdShuaxin.Image = ilyuanshiBtn.Images[3];
        }

        private void tsdShuaxin_MouseUp(object sender, MouseEventArgs e)
        {
            this.tsdShuaxin.Image = iljingguoBtn.Images[3];
        }

        private void tsdZhuye_MouseDown(object sender, MouseEventArgs e)
        {
            this.tsdZhuye.Image = ildianjiBTN.Images[4];
        }

        private void tsdZhuye_MouseEnter(object sender, EventArgs e)
        {
            this.tsdZhuye.Image = iljingguoBtn.Images[4];
        }

        private void tsdZhuye_MouseLeave(object sender, EventArgs e)
        {
            this.tsdZhuye.Image = ilyuanshiBtn.Images[4];
        }

        private void tsdZhuye_MouseUp(object sender, MouseEventArgs e)
        {
            this.tsdZhuye.Image = iljingguoBtn.Images[4];
        }

        private void tsdHuifu_MouseDown(object sender, MouseEventArgs e)
        {
            this.tsdHuifu.Image = ildianjiBTN.Images[5];
        }

        private void tsdHuifu_MouseEnter(object sender, EventArgs e)
        {
            this.tsdHuifu.Image = iljingguoBtn.Images[5];
        }

        private void tsdHuifu_MouseLeave(object sender, EventArgs e)
        {
            this.tsdHuifu.Image = ilyuanshiBtn.Images[5];
        }

        private void tsdHuifu_MouseUp(object sender, MouseEventArgs e)
        {
            this.tsdHuifu.Image = iljingguoBtn.Images[5];
        }

        private void tsdWuheng_MouseDown(object sender, MouseEventArgs e)
        {
            this.tsdWuheng.Image = ildianjiBTN.Images[6];
        }

        private void tsdWuheng_MouseEnter(object sender, EventArgs e)
        {
            this.tsdWuheng.Image = iljingguoBtn.Images[6];
        }

        private void tsdWuheng_MouseLeave(object sender, EventArgs e)
        {
            this.tsdWuheng.Image = ilyuanshiBtn.Images[6];
        }

        private void tsdWuheng_MouseUp(object sender, MouseEventArgs e)
        {
            this.tsdWuheng.Image = ilyuanshiBtn.Images[6];
        }
        #endregion
        private void internet选项ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tsdWuheng_Click(sender, e);
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                this.WebBrowserArr[index].Navigate(comboBox1.Text);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            index = tabControl1.SelectedIndex;
            this.Text = pages[index].Text;
            if (GetChange)
            {
                if (index == 0)
                {
                    if (pages[0].Text != "欢迎使用我的IE浏览器")
                    {
                        comboBox1.Text = WebBrowserArr[index].Document.Url.ToString();
                    }
                    
                }
                else
                {
                    try
                    {
                        comboBox1.Text = WebBrowserArr[index].Document.Url.ToString();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    
                }
            }
        }

        private void tabControl1_DoubleClick(object sender, EventArgs e)
        {

            int ix = tabControl1.SelectedIndex;
            if (ix == 0)
            {
                pages[ix].Text = "空白页";
                WebBrowserArr[ix].Navigate("");
                this.Text = "欢迎来到我的IE浏览器！";
            }
            else
            {
                
                WebBrowserArr[ix].Dispose();
                WebBrowserArr.RemoveAt(ix);
                pages.RemoveAt(ix);
                tabControl1.TabPages.RemoveAt(ix);
                tabControl1.SelectedIndex = ix - 1;
            }
            
        }

        private void 我的收藏夹ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (panel2.Visible == false)
            {
                panel2.Visible = true;
            }
            else
            {
                panel2.Visible = false;
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView1.SelectedNode.Text == "我的收藏夹" || treeView1.SelectedNode.Text == "历史浏览记录")
            {
                return;
            }
            else if (treeView1.SelectedNode.Parent.Text == "我的收藏夹")
            {
                return;
            }
            else
            {
                string url = treeView1.SelectedNode.Tag.ToString();
                comboBox1.Items.Remove(url);
                comboBox1.Items.Add(url);
                comboBox1.SelectedItem = url;
                this.WebBrowserArr[index].Navigate(comboBox1.Text);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            FileStream fs = new FileStream("Lishi.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            string str = "";
            for (int i = 0; i < comboBox1.Items.Count; i++)
            {
                str += comboBox1.Items[i].ToString()+"\r\n";
            }
            sw.Write(str);
            sw.Close();
            fs.Close();
        }

        private void tsdWuheng_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定清空历史记录吗?", "操作提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                FileInfo fi = new FileInfo("Lishi.txt");
                fi.Delete();
                this.comboBox1.Items.Clear();
                treeView1.Nodes[1].Nodes.Clear(); 
            }
            this.Select(false, false);
        }

        private void tsdHuifu_Click(object sender, EventArgs e)
        {
            GetChange = false;
            WebBrowser web = new WebBrowser();
            textName = "空白页";
            Console.WriteLine(index.ToString());

            WebBrowser newWeb = new WebBrowser();
            TabPage tab = new TabPage();

            tabControl1.Controls.Add(tab);

            newWeb.Dock = DockStyle.Fill;
           
            newWeb.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(Navigating);
            newWeb.NewWindow += new System.ComponentModel.CancelEventHandler(NewWindow);
            newWeb.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(DocumentCompleted);
            WebBrowserArr.Add(newWeb);
            pages.Add(tab);
            tab.Controls.Add(newWeb);
            tabControl1.SelectedIndex = tabControl1.Controls.Count - 1;
            newWeb.Navigate("http://www.baidu.com");
            this.comboBox1.Text = newWeb.DocumentTitle;
            tab.Width = 150;
            GetChange = true;

        }

        private void 主页ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WebBrowserArr[index].GoHome();
        }

        private void 新建窗口ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tsdHuifu_Click(sender, e);
        }

        private void internet选项ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Process.Start("inetcpl.cpl");
        }

        private void 关于我的浏览器ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("最终解释权利归风大大！","版权",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
        }


    }
}
