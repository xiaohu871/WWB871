using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Web;
using System.Net;
using System.Collections;
using System.Collections.Specialized;
using System.Data.OleDb;
using System.Threading;
using System.Runtime.InteropServices;
using System.Diagnostics;
using MyExcel = Microsoft.Office.Interop.Excel;  
//using Microsoft.Office.Interop.Excel;

namespace My_IE
{
   
    public partial class IEForm : Form
    {
        private Panel panel2;
        private ToolStripDropDownButton tsdRight;
        private ToolStripDropDownButton tsdClose;
        private ToolStripDropDownButton tsdZhuye;
        private ToolStripDropDownButton tsdgetnumber;
        private ToolStripDropDownButton tsdHuifu;
        private ToolStripDropDownButton tsdWuheng;
        private ImageList ilyuanshiBtn;
        private ImageList iljingguoBtn;
        private ImageList ildianjiBTN;
        private ToolStripDropDownButton tsdLeft;
        private ToolStrip toolStrip1;
        private Label label1;
        private Thread ParameterThread;
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
        public NameValueCollection ht = new NameValueCollection();
        public NameValueCollection nb = new NameValueCollection();
        public DataTable  bhtable = new DataTable();
        private ComboBox comboBox1;
        private TabPage tabPage1;
        private WebBrowser webBrowser1;
        private TabControl tabControl1;
        string textName = "";
        string alert_info = "";
        string bhfilename = "";
        int MatchMode = 0;
        int nb_index = 0;
        public string HisXml = "History.xml";
        private ToolStripMenuItem 我的收藏夹ToolStripMenuItem;
        private ToolStripMenuItem 新建窗口ToolStripMenuItem;
        private ToolStripMenuItem 主页ToolStripMenuItem;
        private ToolStripMenuItem internet选项ToolStripMenuItem1;
        private ToolStripMenuItem 关于我的浏览器ToolStripMenuItem;
        private Button btnClosetree;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox picYuanshi;
        private ImageList imageList1;
        bool GetChange = false;
        public IEForm()
        {
            InitializeComponent();

        }

        #region 窗体控件代码
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IEForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.picYuanshi = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsdLeft = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsdRight = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsdClose = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsdZhuye = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsdgetnumber = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsdHuifu = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsdWuheng = new System.Windows.Forms.ToolStripDropDownButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClosetree = new System.Windows.Forms.Button();
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
            this.关于我的浏览器ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picYuanshi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.picYuanshi);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1276, 55);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // picYuanshi
            // 
            this.picYuanshi.Image = ((System.Drawing.Image)(resources.GetObject("picYuanshi.Image")));
            this.picYuanshi.Location = new System.Drawing.Point(1166, 17);
            this.picYuanshi.Name = "picYuanshi";
            this.picYuanshi.Size = new System.Drawing.Size(25, 25);
            this.picYuanshi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picYuanshi.TabIndex = 2;
            this.picYuanshi.TabStop = false;
            this.picYuanshi.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picYuanshi_MouseDown);
            this.picYuanshi.MouseEnter += new System.EventHandler(this.picYuanshi_MouseEnter);
            this.picYuanshi.MouseLeave += new System.EventHandler(this.picYuanshi_MouseLeave);
            this.picYuanshi.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picYuanshi_MouseUp);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1327, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1197, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 24);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(334, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(826, 20);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.Text = " http://work.hzhailiao.com/admin/?action=check&f=list";
            this.comboBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox1_KeyDown);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(366, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(777, 30);
            this.label1.TabIndex = 1;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.CanOverflow = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsdLeft,
            this.tsdRight,
            this.tsdClose,
            this.tsdZhuye,
            this.tsdgetnumber,
            this.tsdHuifu,
            this.tsdWuheng});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStrip1.Location = new System.Drawing.Point(1, 1);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(330, 61);
            this.toolStrip1.TabIndex = 0;
            // 
            // tsdLeft
            // 
            this.tsdLeft.Image = ((System.Drawing.Image)(resources.GetObject("tsdLeft.Image")));
            this.tsdLeft.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsdLeft.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsdLeft.Name = "tsdLeft";
            this.tsdLeft.ShowDropDownArrow = false;
            this.tsdLeft.Size = new System.Drawing.Size(36, 50);
            this.tsdLeft.Text = "后退";
            this.tsdLeft.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsdLeft.Click += new System.EventHandler(this.tsdLeft_Click);
            this.tsdLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tsdLeft_MouseDown);
            this.tsdLeft.MouseEnter += new System.EventHandler(this.tsdLeft_MouseEnter);
            this.tsdLeft.MouseLeave += new System.EventHandler(this.tsdLeft_MouseLeave);
            this.tsdLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tsdLeft_MouseUp);
            // 
            // tsdRight
            // 
            this.tsdRight.Image = ((System.Drawing.Image)(resources.GetObject("tsdRight.Image")));
            this.tsdRight.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsdRight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsdRight.Name = "tsdRight";
            this.tsdRight.ShowDropDownArrow = false;
            this.tsdRight.Size = new System.Drawing.Size(36, 51);
            this.tsdRight.Text = "前进";
            this.tsdRight.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsdRight.Click += new System.EventHandler(this.tsdRight_Click);
            this.tsdRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tsdRight_MouseDown);
            this.tsdRight.MouseEnter += new System.EventHandler(this.tsdRight_MouseEnter);
            this.tsdRight.MouseLeave += new System.EventHandler(this.tsdRight_MouseLeave);
            this.tsdRight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tsdRight_MouseUp);
            // 
            // tsdClose
            // 
            this.tsdClose.Image = ((System.Drawing.Image)(resources.GetObject("tsdClose.Image")));
            this.tsdClose.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsdClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsdClose.Name = "tsdClose";
            this.tsdClose.ShowDropDownArrow = false;
            this.tsdClose.Size = new System.Drawing.Size(36, 53);
            this.tsdClose.Text = "停止";
            this.tsdClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsdClose.Click += new System.EventHandler(this.tsdClose_Click);
            this.tsdClose.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tsdClose_MouseDown);
            this.tsdClose.MouseEnter += new System.EventHandler(this.tsdClose_MouseEnter);
            this.tsdClose.MouseLeave += new System.EventHandler(this.tsdClose_MouseLeave);
            this.tsdClose.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tsdClose_MouseUp);
            // 
            // tsdZhuye
            // 
            this.tsdZhuye.Image = ((System.Drawing.Image)(resources.GetObject("tsdZhuye.Image")));
            this.tsdZhuye.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsdZhuye.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsdZhuye.Name = "tsdZhuye";
            this.tsdZhuye.ShowDropDownArrow = false;
            this.tsdZhuye.Size = new System.Drawing.Size(36, 51);
            this.tsdZhuye.Text = "主页";
            this.tsdZhuye.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsdZhuye.Click += new System.EventHandler(this.tsdZhuye_Click);
            this.tsdZhuye.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tsdZhuye_MouseDown);
            this.tsdZhuye.MouseEnter += new System.EventHandler(this.tsdZhuye_MouseEnter);
            this.tsdZhuye.MouseLeave += new System.EventHandler(this.tsdZhuye_MouseLeave);
            this.tsdZhuye.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tsdZhuye_MouseUp);
            // 
            // tsdgetnumber
            // 
            this.tsdgetnumber.Image = ((System.Drawing.Image)(resources.GetObject("tsdgetnumber.Image")));
            this.tsdgetnumber.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsdgetnumber.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsdgetnumber.Name = "tsdgetnumber";
            this.tsdgetnumber.ShowDropDownArrow = false;
            this.tsdgetnumber.Size = new System.Drawing.Size(60, 52);
            this.tsdgetnumber.Text = "获取编号";
            this.tsdgetnumber.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsdgetnumber.Click += new System.EventHandler(this.tsdShuaxin_Click);
            this.tsdgetnumber.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tsdShuaxin_MouseDown);
            this.tsdgetnumber.MouseEnter += new System.EventHandler(this.tsdShuaxin_MouseEnter);
            this.tsdgetnumber.MouseLeave += new System.EventHandler(this.tsdShuaxin_MouseLeave);
            this.tsdgetnumber.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tsdShuaxin_MouseUp);
            // 
            // tsdHuifu
            // 
            this.tsdHuifu.Image = ((System.Drawing.Image)(resources.GetObject("tsdHuifu.Image")));
            this.tsdHuifu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsdHuifu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsdHuifu.Name = "tsdHuifu";
            this.tsdHuifu.ShowDropDownArrow = false;
            this.tsdHuifu.Size = new System.Drawing.Size(60, 51);
            this.tsdHuifu.Text = "智能分配";
            this.tsdHuifu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsdHuifu.ToolTipText = "智能分配";
            this.tsdHuifu.Visible = false;
            this.tsdHuifu.Click += new System.EventHandler(this.tsdHuifu_Click);
            this.tsdHuifu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tsdHuifu_MouseDown);
            this.tsdHuifu.MouseEnter += new System.EventHandler(this.tsdHuifu_MouseEnter);
            this.tsdHuifu.MouseLeave += new System.EventHandler(this.tsdHuifu_MouseLeave);
            this.tsdHuifu.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tsdHuifu_MouseUp);
            // 
            // tsdWuheng
            // 
            this.tsdWuheng.Image = ((System.Drawing.Image)(resources.GetObject("tsdWuheng.Image")));
            this.tsdWuheng.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsdWuheng.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsdWuheng.Name = "tsdWuheng";
            this.tsdWuheng.ShowDropDownArrow = false;
            this.tsdWuheng.Size = new System.Drawing.Size(60, 52);
            this.tsdWuheng.Text = "自动匹配";
            this.tsdWuheng.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.tsdWuheng.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsdWuheng.Visible = false;
            this.tsdWuheng.Click += new System.EventHandler(this.tsdWuheng_Click);
            this.tsdWuheng.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tsdWuheng_MouseDown);
            this.tsdWuheng.MouseEnter += new System.EventHandler(this.tsdWuheng_MouseEnter);
            this.tsdWuheng.MouseLeave += new System.EventHandler(this.tsdWuheng_MouseLeave);
            this.tsdWuheng.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tsdWuheng_MouseUp);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btnClosetree);
            this.panel2.Controls.Add(this.treeView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 527);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnClosetree
            // 
            this.btnClosetree.BackColor = System.Drawing.Color.White;
            this.btnClosetree.FlatAppearance.BorderSize = 0;
            this.btnClosetree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClosetree.Location = new System.Drawing.Point(229, 2);
            this.btnClosetree.Name = "btnClosetree";
            this.btnClosetree.Size = new System.Drawing.Size(18, 20);
            this.btnClosetree.TabIndex = 1;
            this.btnClosetree.Text = "×";
            this.btnClosetree.UseVisualStyleBackColor = false;
            this.btnClosetree.Click += new System.EventHandler(this.button1_Click);
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
            this.menuStrip1.Size = new System.Drawing.Size(1276, 25);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件UToolStripMenuItem
            // 
            this.文件UToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建窗口ToolStripMenuItem,
            this.主页ToolStripMenuItem});
            this.文件UToolStripMenuItem.Name = "文件UToolStripMenuItem";
            this.文件UToolStripMenuItem.Size = new System.Drawing.Size(58, 21);
            this.文件UToolStripMenuItem.Text = "文件(&F)";
            // 
            // 新建窗口ToolStripMenuItem
            // 
            this.新建窗口ToolStripMenuItem.Name = "新建窗口ToolStripMenuItem";
            this.新建窗口ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.新建窗口ToolStripMenuItem.Text = "新建窗口";
            this.新建窗口ToolStripMenuItem.Click += new System.EventHandler(this.新建窗口ToolStripMenuItem_Click);
            // 
            // 主页ToolStripMenuItem
            // 
            this.主页ToolStripMenuItem.Name = "主页ToolStripMenuItem";
            this.主页ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.主页ToolStripMenuItem.Text = "　主页";
            this.主页ToolStripMenuItem.Click += new System.EventHandler(this.主页ToolStripMenuItem_Click);
            // 
            // 查看ToolStripMenuItem
            // 
            this.查看ToolStripMenuItem.Name = "查看ToolStripMenuItem";
            this.查看ToolStripMenuItem.Size = new System.Drawing.Size(60, 21);
            this.查看ToolStripMenuItem.Text = "查看(&V)";
            // 
            // 收藏BToolStripMenuItem
            // 
            this.收藏BToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.我的收藏夹ToolStripMenuItem});
            this.收藏BToolStripMenuItem.Name = "收藏BToolStripMenuItem";
            this.收藏BToolStripMenuItem.Size = new System.Drawing.Size(60, 21);
            this.收藏BToolStripMenuItem.Text = "收藏(&B)";
            // 
            // 我的收藏夹ToolStripMenuItem
            // 
            this.我的收藏夹ToolStripMenuItem.Name = "我的收藏夹ToolStripMenuItem";
            this.我的收藏夹ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.我的收藏夹ToolStripMenuItem.Text = "我的收藏夹";
            this.我的收藏夹ToolStripMenuItem.Click += new System.EventHandler(this.我的收藏夹ToolStripMenuItem_Click);
            // 
            // 帐户UToolStripMenuItem
            // 
            this.帐户UToolStripMenuItem.Name = "帐户UToolStripMenuItem";
            this.帐户UToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
            this.帐户UToolStripMenuItem.Text = "帐户(&U)";
            // 
            // 工具ToolStripMenuItem
            // 
            this.工具ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.internet选项ToolStripMenuItem,
            this.internet选项ToolStripMenuItem1});
            this.工具ToolStripMenuItem.Name = "工具ToolStripMenuItem";
            this.工具ToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
            this.工具ToolStripMenuItem.Text = "工具(&T)";
            // 
            // internet选项ToolStripMenuItem
            // 
            this.internet选项ToolStripMenuItem.Name = "internet选项ToolStripMenuItem";
            this.internet选项ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.internet选项ToolStripMenuItem.Text = "清空历史记录";
            this.internet选项ToolStripMenuItem.Click += new System.EventHandler(this.internet选项ToolStripMenuItem_Click);
            // 
            // internet选项ToolStripMenuItem1
            // 
            this.internet选项ToolStripMenuItem1.Name = "internet选项ToolStripMenuItem1";
            this.internet选项ToolStripMenuItem1.Size = new System.Drawing.Size(148, 22);
            this.internet选项ToolStripMenuItem1.Text = "Internet选项";
            this.internet选项ToolStripMenuItem1.Click += new System.EventHandler(this.internet选项ToolStripMenuItem1_Click);
            // 
            // 帮助HToolStripMenuItem
            // 
            this.帮助HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于我的浏览器ToolStripMenuItem});
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            this.帮助HToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
            this.帮助HToolStripMenuItem.Text = "帮助(&H)";
            // 
            // 关于我的浏览器ToolStripMenuItem
            // 
            this.关于我的浏览器ToolStripMenuItem.Name = "关于我的浏览器ToolStripMenuItem";
            this.关于我的浏览器ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.关于我的浏览器ToolStripMenuItem.Text = "关于我的浏览器";
            this.关于我的浏览器ToolStripMenuItem.Click += new System.EventHandler(this.关于我的浏览器ToolStripMenuItem_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.webBrowser1);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(5);
            this.tabPage1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPage1.Size = new System.Drawing.Size(1018, 502);
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
            this.webBrowser1.Size = new System.Drawing.Size(1008, 492);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.DocumentCompleted);
            this.webBrowser1.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.Navigating);
            this.webBrowser1.NewWindow += new System.ComponentModel.CancelEventHandler(this.NewWindow);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(150, 17);
            this.tabControl1.Location = new System.Drawing.Point(250, 80);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1026, 527);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 4;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            this.tabControl1.DoubleClick += new System.EventHandler(this.tabControl1_DoubleClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "X.JPG");
            this.imageList1.Images.SetKeyName(1, "XXX.JPG");
            this.imageList1.Images.SetKeyName(2, "XXX.JPG");
            // 
            // IEForm
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1276, 607);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(640, 443);
            this.Name = "IEForm";
            this.Text = "浏览器";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picYuanshi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            Directory.SetCurrentDirectory(System.AppDomain.CurrentDomain.BaseDirectory);
            this.tabControl1.ItemSize = new Size(150, tabControl1.ItemSize.Height);
            this.treeView1.Size = new Size(panel2.Size.Width - 1, panel2.Size.Height);
           
            我的收藏夹ToolStripMenuItem_Click(sender, e);
          //  ReadXml();
          //  ReadLishi();
            WebBrowserArr.Add(webBrowser1);
            webBrowser1.ScriptErrorsSuppressed = true;
            pages.Add(tabPage1);
            this.ilyuanshiBtn.Images.Add(tsdLeft.Image);
            this.ilyuanshiBtn.Images.Add(tsdRight.Image);
            this.ilyuanshiBtn.Images.Add(tsdClose.Image);
            this.ilyuanshiBtn.Images.Add(tsdgetnumber.Image);

            this.ilyuanshiBtn.Images.Add(tsdZhuye.Image);
            this.ilyuanshiBtn.Images.Add(tsdHuifu.Image);
            this.ilyuanshiBtn.Images.Add(tsdWuheng.Image);
            //bhtable.Columns.Add("xm");
            //bhtable.Columns.Add("dw");
            //bhtable.Columns.Add("bh2011");
            //bhtable.Columns.Add("bh2012");
            //bhtable.Columns.Add("bh2013");
         //   bhfilename = Application.StartupPath +"\\历年体检信息.xls";
            bhfilename = AppDomain.CurrentDomain.BaseDirectory + "历年体检信息.xls";
            LoadDataFromExcelToDataTable(bhfilename, bhtable);
            //System.Type.GetType("System.String");
            //DataColumn colDecimal;
            //colDecimal = bhtable.Columns["2013年"];
            //colDecimal.
            //bhtable.Columns["2012年"].DataType = System.Type.GetType("System.String");
            //bhtable.Columns["2011年"].DataType = System.Type.GetType("System.String");

            ParameterThread = new Thread(new ParameterizedThreadStart(LoadDataFromExcelByThreadParam));
            MyThreadParameter paramter1 = new MyThreadParameter("体检计划表.xls", 1, 10,ht);
            ParameterThread.Start(paramter1); 
          //  LoadDataFromExcelToNameValue("体检计划表.xls", 1, 10);
           
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

        public static bool IsFileCanUse(string fileName)
        {
            bool inUse = true;
      //      FileStream fs = null;

            if (!File.Exists(fileName))
            {
                MessageBox.Show(fileName + "文件不存在!");
                return false ;
            }
           // HANDLE Handle = CreateFile(fileName, GENERIC_READ, 0, NULL, OPEN_EXISTING, FILE_ATTRIBUTE_NORMAL, NULL);
           // if (INVALID_HANDLE_VALUE == Handle)
           
            return inUse;//true表示正在使用,false没有使用
        }

        public static bool SaveDataTableToExcel(System.Data.DataTable dt, string filePath, int sourcestartindex, int deststartindex)
        {
            MyExcel.Application excelApp = new MyExcel.ApplicationClass();

            try
            {
                excelApp.Visible = false;
                if (!File.Exists(filePath))
                {
                    MessageBox.Show(filePath + "文件不存在!");
                    return false;
                }
                excelApp.Workbooks.Open(filePath);
                MyExcel.Worksheet sheet = (MyExcel.Worksheet)excelApp.Worksheets[1];
                //填充
                if (dt.Rows.Count > 0)
                {
                    int colCount = dt.Columns.Count;
                    object[,] dataArray = new object[dt.Rows.Count, colCount];
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = sourcestartindex; j < colCount; j++)
                        {
                            //if (i == 0)
                            //{
                            //    //列名作为第一行
                            //    dataArray[i, j] = dt.Columns[j].ColumnName;
                            //}
                            dataArray[i, j - sourcestartindex] = dt.Rows[i][j];
                        }
                    }
                    MyExcel.Range myRange = sheet.get_Range(sheet.Cells[2, deststartindex + 1], sheet.Cells[dt.Rows.Count + 1, colCount + 1]);
                    //添加数据
                    //内容体
                    myRange.Value2 = dataArray;
                    //设置头样式
                    //sheet.get_Range(sheet.Cells[1, 1], sheet.Cells[1, colCount]).Interior.ColorIndex = 7;                          
                    //设置样式
                    //SetWorksheetStyle(sheet, dt.Rows.Count, colCount);
                }
                //刷新Pivot table等内容 
                excelApp.Workbooks[1].RefreshAll();
                //保存excel文件
                MyExcel.Workbook mybook = excelApp.Workbooks[1];
                mybook.Save();
                //关闭excel进程
                mybook.Close(false);
                //mybook = null;
                excelApp.Quit();
                //excelApp = null;
                GC.Collect();
                excelApp = null;
                return true;
            }
            catch (Exception err)
            {
                MessageBox.Show("写入Excel出错！错误原因：" + err.Message, "提示信息",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            finally
            {
            }
        }

        //加载Excel 
        //   public void LoadDataFromExcelToNameValue(string filePath,int n,int v)
        public void LoadDataFromExcelByThreadParam(Object MS)
        {
            if (MS is MyThreadParameter)
            {
                MyThreadParameter parameter = MS as MyThreadParameter;//类型转换 
                String filePath = parameter.filename;
                int n = parameter.dw;
                int v = parameter.zj;
                LoadDataFromExcelToNameValue(parameter.filename, parameter.dw, parameter.zj,parameter.nv);
            }
        }
        public void  LoadDataFromExcelToDataTable(string filePath, DataTable destDT)
        {
            string strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filePath + ";Extended Properties='Excel 8.0;HDR=False;IMEX=1'";
            OleDbConnection OleConn = new OleDbConnection(strConn);
            OleConn.Open();
            DataTable dt = OleConn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
            string tableName = dt.Rows[0][2].ToString().Trim();
            String sql = "SELECT * FROM  [" + tableName + "]";//可是更改Sheet名称，比如sheet2，等等 
            OleDbCommand DbCommand = new OleDbCommand(sql, OleConn);
            OleDbDataReader OleReader = DbCommand.ExecuteReader();

            OleDbDataAdapter OleDaExcel = new OleDbDataAdapter(sql, OleConn);
           // DataSet OleDsExcle = new DataSet();
            OleDaExcel.Fill(destDT);
            OleConn.Close();
        }
        public void LoadDataFromExcelToNameValue(string filePath, int n, int v, NameValueCollection nv)
        {
  
            string strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filePath + ";Extended Properties='Excel 8.0;HDR=False;IMEX=1'";
            OleDbConnection OleConn = new OleDbConnection(strConn);
            OleConn.Open();
            DataTable dt = OleConn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
            string tableName = dt.Rows[0][2].ToString().Trim();
            String sql = "SELECT * FROM  [" + tableName  + "]";//可是更改Sheet名称，比如sheet2，等等 
            OleDbCommand DbCommand = new OleDbCommand(sql, OleConn);
            OleDbDataReader OleReader = DbCommand.ExecuteReader();
                
            DataSet OleDsExcle = new DataSet();
            int blank = 0;

            if (OleReader.HasRows)
            {
                while (OleReader.Read())
                {
                    if (OleReader[n].ToString() != "")
                        nv.Add(OleReader[n].ToString(), OleReader[v].ToString());
                    else
                        blank++;
                    if (blank > 5) break;
                }
            }
            OleReader.Close();                
            OleConn.Close();
        }
        private void tsdShuaxin_Click(object sender, EventArgs e)
        {
            try
            { 
                if (webBrowser1.Document == null)
                {
                    MessageBox.Show("请进入体检报告管理页面，再重试！", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
                foreach (HtmlElement he in webBrowser1.Document.GetElementsByTagName("input"))
                {

                    if ((he.GetAttribute("name") == "text") && (he.GetAttribute("type") == "text"))
                    {
                        nb_index = 0;
                        if (nb_index < bhtable.Rows.Count)
                        {
                          string xm = bhtable.Rows[nb_index][2].ToString().Replace(" ","");
                          if (xm != "")
                          {
                              he.SetAttribute("value", xm);
                              he.Parent.Parent.NextSibling.NextSibling.FirstChild.InvokeMember("click");
                              MatchMode = 3;
                          }
                        }
                    }
                }
            }
            catch (DataException ed)
            {
                MessageBox.Show(ed.Message.ToString(), "出错", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            //     HtmlElement et = webBrowser1.Document.Forms["form2"];
            this.Select(false, false);
        }
        private void tsdWuheng_Click(object sender, EventArgs e)
        {
            if ((ParameterThread != null) && (ParameterThread.IsAlive))
            {
                MessageBox.Show("数据还未加载完成，请稍后再试！", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            if (webBrowser1.Document == null)
            {
                MessageBox.Show("请进入体检报告管理页面，再重试！", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            foreach (HtmlElement he in webBrowser1.Document.GetElementsByTagName("a"))
            {

                if (he.GetAttribute("className") == "cc")
                {
                    he.InvokeMember("click");
                    MatchMode = 1;
                }
            }

            //     HtmlElement et = webBrowser1.Document.Forms["form2"];

            this.Select(false, false);
        }

        private void tsdHuifu_Click(object sender, EventArgs e)
        {
            if ((ParameterThread != null) && (ParameterThread.IsAlive))
            {
                MessageBox.Show("数据还未加载完成，请稍后再试！", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            if (webBrowser1.Document == null)
            {
                MessageBox.Show("请进入体检报告管理页面，再重试！", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            foreach (HtmlElement he in webBrowser1.Document.GetElementsByTagName("a"))
            {

                if (he.GetAttribute("className") == "cc")
                {
                    he.InvokeMember("click");
                    MatchMode = 2;
                }
            }
            //     HtmlElement et = webBrowser1.Document.Forms["form2"];
            this.Select(false, false);

        }
        private CookieContainer AddCookies()
        {
            CookieContainer objcok = new CookieContainer();

            if (webBrowser1.Document.Cookie != null)
             {
                 string cookieStr = webBrowser1.Document.Cookie;
                 string[] cookstr = cookieStr.Split(';');
                foreach (string str in cookstr)
                 {
                   string[] cookieNameValue = str.Split('=');
                     Cookie ck = new Cookie(cookieNameValue[0].Trim().ToString(), cookieNameValue[1].Trim().ToString());
                     //ck.Domain = "http://work.hzhailiao.com";
                     objcok.Add(new Uri("http://work.hzhailiao.com"), ck);
                 }
             }
            return objcok;
        }
        private string get(string strURL)
        {
            HttpWebRequest request = (System.Net.HttpWebRequest)WebRequest.Create(strURL);
            request.CookieContainer = AddCookies();
            HttpWebResponse response = (System.Net.HttpWebResponse)request.GetResponse();
            System.IO.StreamReader myreader = new System.IO.StreamReader(response.GetResponseStream(), Encoding.UTF8);
            string responseText = myreader.ReadToEnd();
            myreader.Close();
            return responseText;
        }
        private string post(string strURL, NameValueCollection queryString)
        {
            HttpWebRequest request = (System.Net.HttpWebRequest)WebRequest.Create(strURL);
            request.CookieContainer = AddCookies();
            request.Method = "POST";
            request.Accept = "text/plain, */*; q=0.01";
            request.ContentType = "application/x-www-form-urlencoded";
            //    request.
            byte[] byteArray = Encoding.GetEncoding("gb2312").GetBytes(queryString.ToString());
            request.ContentLength = byteArray.Length;
            Stream newStream = request.GetRequestStream();
            newStream.Write(byteArray, 0, byteArray.Length);    //写入参数
            newStream.Close();

            // request.Headers.Add(queryString);
            HttpWebResponse response = (System.Net.HttpWebResponse)request.GetResponse();
            System.IO.StreamReader myreader = new System.IO.StreamReader(response.GetResponseStream(), Encoding.UTF8);
            string responseText = myreader.ReadToEnd();
            myreader.Close();
            return responseText;
        }
        private void DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            try
            {
                if (WebBrowserArr[index].Document.Url.ToString() == "about:blank")
                {
                    this.Text = "欢迎来到我的IE浏览器！";
                    pages[index].Text = "空白页";
                    this.comboBox1.Text = "about:blank";
                }
                else if ((MatchMode == 3) && (WebBrowserArr[index].Document.Url.ToString().IndexOf("work.hzhailiao.com/admin/index.php?action=check&f=list&text") != -1))
                {
                    string bh2013 = "";
                    string bh2012 = "";
                    string bh2011 = "";
                    string xm = "";
                    string dw = "";
                    string IdCard = "";
                    if (nb_index <= bhtable.Rows.Count)
                    {
                        xm = bhtable.Rows[nb_index][2].ToString().Replace(" ","");
                        dw = bhtable.Rows[nb_index][1].ToString().Trim();
                        IdCard = bhtable.Rows[nb_index][3].ToString().Trim();
                        webBrowser1.Parent.Text = "读取Excel第" + (nb_index + 1) + "行:" + dw + " " + xm ;
                   //    webBrowser1.Document.Cookie
                        foreach (HtmlElement he in webBrowser1.Document.GetElementsByTagName("div"))
                        {
                            if (he.GetAttribute("className") == "t-number")
                            {
                                string wdw = he.Parent.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.InnerText;
                                string wxm = "";
                                //if (he.Parent.NextSibling.NextSibling.NextSibling.NextSibling.FirstChild != null)
                                //{
                                //    wxm = he.Parent.NextSibling.NextSibling.NextSibling.NextSibling.FirstChild.InnerText.Replace(" ", ""); 
                           
                                //}
                                wxm =  he.Parent.NextSibling.NextSibling.NextSibling.NextSibling.InnerText.Replace(" ", "");
                               
                                if ((wdw.IndexOf(dw) != -1) && (xm == wxm))
                                {
                                    string wsj = he.Parent.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.InnerText;

                                    string bh = he.Parent.NextSibling.NextSibling.InnerText;
                                    if (wsj.IndexOf("2011") != -1)
                                    {
                                        if (bh2011 == "")
                                            bh2011 = bh2011 + bh;
                                        else
                                            bh2011 = bh2011 + "." + bh;
                                    }
                                    else if (wsj.IndexOf("2012") != -1)
                                    {
                                        if (bh2012 == "")
                                            bh2012 = bh2012 + bh;
                                        else
                                            bh2012 = bh2012 + "." + bh;
                                    }
                                    else if (wsj.IndexOf("2013") != -1)
                                    {
                                        if (bh2013 == "")
                                            bh2013 = bh2013 + bh;
                                        else
                                            bh2013 = bh2013 + "." + bh;
                                    }
                                }
                            }                           
                        }
                        DataRow dr = bhtable.Rows[nb_index];
                        string packstring = "";
                        if (bh2011.IndexOf(".") != -1)
                        {
                            packstring = packstring + "  2011年体检编号查到有多个：" + bh2011;
                            //    alert_info = alert_info + dw + "  有重复的姓名:" + xm + "  2011年体检编号查到有多个：" + bh2011 + "\r\n";
                        }
                        if (bh2012.IndexOf(".") != -1)
                        {
                            packstring = packstring + "  2012年体检编号查到有多个：" + bh2012;
                            //   alert_info = alert_info + dw + "  有重复的姓名:" + xm + "  2012年体检编号查到有多个：" + bh2012 + "\r\n";
                        }
                        if (bh2013.IndexOf(".") != -1)
                        {
                            packstring = packstring + "  2013年体检编号查到有多个：" + bh2013;
                            //  alert_info = alert_info + dw + "  有重复的姓名:" + xm + "  2013年体检编号查到有多个：" + bh2013 + "\r\n";
                        }
                        if (packstring != "")
                        {
                            alert_info = alert_info + dw + "  有重复的姓名:" + xm + packstring + "，请人工识别后手工添加体检编号和身份证号！\r\n";
                        }
                        else
                        {//work.hzhailiao.com/admin/index.php

                            dr["2011年"] = bh2011;
                            dr["2012年"] = bh2012;
                            dr["2013年"] = bh2013;
                            foreach (HtmlElement he in webBrowser1.Document.GetElementsByTagName("div"))
                            { 
                                if (he.GetAttribute("className") == "t-number")
                                {
                                    HtmlElement htmp = he.Parent.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.FirstChild.NextSibling.NextSibling.NextSibling.NextSibling;

                                    if (htmp.InnerText.IndexOf("添加身份证") >= 0)
                                    {
                                        string wdw = he.Parent.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.InnerText;
                                        string wxm;
                                        if (he.Parent.NextSibling.NextSibling.NextSibling.NextSibling.FirstChild != null)
                                        {
                                            wxm = he.Parent.NextSibling.NextSibling.NextSibling.NextSibling.FirstChild.InnerText.Replace(" ", "");
                                        }
                                        else
                                        {
                                            wxm = he.Parent.NextSibling.NextSibling.NextSibling.NextSibling.InnerText.Replace(" ", "");
                                        }
                                        if ((wdw.IndexOf(dw) != -1) && (xm == wxm))
                                        {
                                            if (IdCard != "")
                                            {
                                                //NameValueCollection queryString = System.Web.HttpUtility.ParseQueryString(string.Empty, Encoding.UTF8);
                                                //queryString["action"] = "check";
                                                //queryString["f"] = "update_idnum";
                                                //queryString["crid"] = htmp.GetAttribute("alt").Trim();
                                                //queryString["newid"] = IdCard;
                                                //if (post("http://work.hzhailiao.com/admin/index.php", queryString).IndexOf("success") == -1)
                                                //{
                                                //    alert_info = alert_info + dw + " 姓名：" + xm + "  更新身份证失败\r\n";
                                                //}
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        foreach (HtmlElement he in webBrowser1.Document.GetElementsByTagName("input"))
                        {

                            if ((he.GetAttribute("name") == "text") && (he.GetAttribute("type") == "text"))
                            {
                                //    nb_index = 1;

                                nb_index++;
                                if ((nb_index < bhtable.Rows.Count) && (bhtable.Rows[nb_index]["姓名"].ToString().Trim() !=""))
                                {
                                    xm = bhtable.Rows[nb_index]["姓名"].ToString().Trim();                                
                                    he.SetAttribute("value", xm);
                                    he.Parent.Parent.NextSibling.NextSibling.FirstChild.InvokeMember("click");
                                }
                                else
                                {
                                    MatchMode = 0;
                                    SaveDataTableToExcel(bhtable, bhfilename, 5, 5);
                                    if (alert_info.Trim() != "")
                                    {
                                        MessageBox.Show(alert_info, "异常", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                    }
                                    else
                                    {
                                        MessageBox.Show("体检编号写入Excel成功,身份证号上传网站成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                    }
                                }
                            }
                        }
                    }
                }
                else if (WebBrowserArr[index].Document.Url.ToString() == "http://work.hzhailiao.com/admin/?action=check&f=list&text=0&field=uexpert_name")
                {
                    this.Text = this.WebBrowserArr[index].DocumentTitle;
                    this.comboBox1.Text = WebBrowserArr[index].Document.Url.ToString();
                    this.comboBox1.Items.Remove(this.comboBox1.Text);
                    this.comboBox1.Items.Add(WebBrowserArr[index].Document.Url.ToString());
                    this.comboBox1.Text = WebBrowserArr[index].Document.Url.ToString();
                    string expertname = "";
                    foreach (HtmlElement he in webBrowser1.Document.GetElementsByTagName("div"))
                    {
                        if (he.GetAttribute("className") == "t-number")
                        {
                            //   he.InvokeMember("click");
                            // webBrowser1.Parent.Text = 
                            string s = he.Parent.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.InnerText;


                            foreach (string key in ht.Keys)
                            {
                                string skey = key.Trim();
                                if (s.IndexOf(skey) >= 0)
                                {
                                    if ((expertname == "") || (expertname == ht[skey].Trim()))
                                    {
                                        foreach (HtmlElement el in webBrowser1.Document.All)
                                        {
                                            if (el.Name == "expert")
                                            {
                                                if (el.Parent.InnerText.Trim() == ht[skey].Trim())
                                                {
                                                    expertname = ht[skey].Trim();
                                                    el.InvokeMember("click");
                                                    he.FirstChild.FirstChild.InvokeMember("click");
                                                    webBrowser1.Parent.Text = expertname;
                                                }
                                            }
                                        }
                                    }
                                    if ((expertname != "") && (MatchMode == 2))
                                    {
                                        foreach (HtmlElement ele in webBrowser1.Document.GetElementsByTagName("div"))
                                        {
                                            if (ele.GetAttribute("className") == "bd_btn")
                                                ele.FirstChild.InvokeMember("click");
                                        }
                                    }

                                }

                            }
                        }
                    }
                    if (expertname.Trim() == "")
                    {
                        // ShowDialog();
                        MessageBox.Show("本页体检信息在EXCEL里未找到对应的记录！", "未找到", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        // this.TopMost = true;
                        //this.Activate();
                        return;
                    }

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
            catch (System.Exception exception)
            {
                MessageBox.Show(exception.Message.ToString());
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
            this.tsdgetnumber.Image = ildianjiBTN.Images[3];
        }

        private void tsdShuaxin_MouseEnter(object sender, EventArgs e)
        {
            this.tsdgetnumber.Image = iljingguoBtn.Images[3];
        }

        private void tsdShuaxin_MouseLeave(object sender, EventArgs e)
        {
            this.tsdgetnumber.Image = ilyuanshiBtn.Images[3];
        }

        private void tsdShuaxin_MouseUp(object sender, MouseEventArgs e)
        {
            this.tsdgetnumber.Image = iljingguoBtn.Images[3];
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
            MessageBox.Show("关于！","版权",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }



        private void picYuanshi_MouseDown(object sender, MouseEventArgs e)
        {
            picYuanshi.Image = imageList1.Images[2];
            this.WebBrowserArr[index].Navigate(comboBox1.Text);
        }

        private void picYuanshi_MouseEnter(object sender, EventArgs e)
        {
            picYuanshi.Image = imageList1.Images[1];
        }

        private void picYuanshi_MouseLeave(object sender, EventArgs e)
        {
            picYuanshi.Image = imageList1.Images[0];
        }

        private void picYuanshi_MouseUp(object sender, MouseEventArgs e)
        {
            picYuanshi.Image = imageList1.Images[1];
        }



    }
    public partial class MyThreadParameter
    {
        private int m_dw;
        private int m_zj;
        private string m_fileName;
        private NameValueCollection m_nv;
        public string filename
        {
            get { return m_fileName; }
        }

        public int dw
        {
            get { return m_dw; }
        }
        public int zj
        {
            get { return m_zj; }
        }
        public NameValueCollection nv
        {
            get { return m_nv; }
        }
        public MyThreadParameter(string filename, int dw, int zj, NameValueCollection nv)
        {
            this.m_fileName = filename;
            this.m_dw = dw;
            this.m_zj = zj;
            this.m_nv = nv;
        }
    }
}
