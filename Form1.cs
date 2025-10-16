// Decompiled with JetBrains decompiler
// Type: MonasterSetBase.Form1
// Assembly: MonsterSetBaseEditor, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 03612203-8C9B-483E-B836-D3195F197403
// Assembly location: C:\Users\rafae\Downloads\MuOnline\Tools\Editor De Mostros\MonsterSetBaseEditor.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

#nullable disable
namespace MonasterSetBase;

[DesignerGenerated]
public class Form1 : Form
{
  private IContainer components;
  [AccessedThroughProperty("StatusStrip1")]
  private StatusStrip _StatusStrip1;
  [AccessedThroughProperty("ToolStripStatusLabel1")]
  private ToolStripStatusLabel _ToolStripStatusLabel1;
  [AccessedThroughProperty("GroupBox1")]
  private GroupBox _GroupBox1;
  [AccessedThroughProperty("PictureBox1")]
  private PictureBox _PictureBox1;
  [AccessedThroughProperty("OpenFileDialog1")]
  private OpenFileDialog _OpenFileDialog1;
  [AccessedThroughProperty("ComboBox1")]
  private ComboBox _ComboBox1;
  [AccessedThroughProperty("ListBox1")]
  private ListBox _ListBox1;
  [AccessedThroughProperty("OpenFileDialog2")]
  private OpenFileDialog _OpenFileDialog2;
  [AccessedThroughProperty("Button3")]
  private Button _Button3;
  [AccessedThroughProperty("SaveFileDialog1")]
  private SaveFileDialog _SaveFileDialog1;
  [AccessedThroughProperty("Label5")]
  private Label _Label5;
  [AccessedThroughProperty("Label4")]
  private Label _Label4;
  [AccessedThroughProperty("GroupBox2")]
  private GroupBox _GroupBox2;
  [AccessedThroughProperty("ComboBox2")]
  private ComboBox _ComboBox2;
  [AccessedThroughProperty("GroupBox3")]
  private GroupBox _GroupBox3;
  [AccessedThroughProperty("ListBox2")]
  private ListBox _ListBox2;
  [AccessedThroughProperty("TextBox3")]
  private TextBox _TextBox3;
  [AccessedThroughProperty("Button4")]
  private Button _Button4;
  [AccessedThroughProperty("Button5")]
  private Button _Button5;
  [AccessedThroughProperty("Button6")]
  private Button _Button6;
  [AccessedThroughProperty("TextBox1")]
  private TextBox _TextBox1;
  [AccessedThroughProperty("Button1")]
  private Button _Button1;
  [AccessedThroughProperty("Label2")]
  private Label _Label2;
  [AccessedThroughProperty("GroupBox4")]
  private GroupBox _GroupBox4;
  [AccessedThroughProperty("TabControl1")]
  private TabControl _TabControl1;
  [AccessedThroughProperty("TabPage1")]
  private TabPage _TabPage1;
  [AccessedThroughProperty("TabPage2")]
  private TabPage _TabPage2;
  [AccessedThroughProperty("Label3")]
  private Label _Label3;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("Button2")]
  private Button _Button2;
  [AccessedThroughProperty("Timer1")]
  private Timer _Timer1;
  [AccessedThroughProperty("Label6")]
  private Label _Label6;
  [AccessedThroughProperty("RadioButton1")]
  private RadioButton _RadioButton1;
  [AccessedThroughProperty("RadioButton7")]
  private RadioButton _RadioButton7;
  [AccessedThroughProperty("RadioButton6")]
  private RadioButton _RadioButton6;
  [AccessedThroughProperty("RadioButton5")]
  private RadioButton _RadioButton5;
  [AccessedThroughProperty("RadioButton8")]
  private RadioButton _RadioButton8;
  [AccessedThroughProperty("RadioButton2")]
  private RadioButton _RadioButton2;
  [AccessedThroughProperty("RadioButton4")]
  private RadioButton _RadioButton4;
  [AccessedThroughProperty("RadioButton3")]
  private RadioButton _RadioButton3;
  [AccessedThroughProperty("GroupBox5")]
  private GroupBox _GroupBox5;
  [AccessedThroughProperty("Label11")]
  private Label _Label11;
  [AccessedThroughProperty("Label10")]
  private Label _Label10;
  [AccessedThroughProperty("Label9")]
  private Label _Label9;
  [AccessedThroughProperty("Label8")]
  private Label _Label8;
  [AccessedThroughProperty("Label7")]
  private Label _Label7;
  [AccessedThroughProperty("Label15")]
  private Label _Label15;
  [AccessedThroughProperty("Label14")]
  private Label _Label14;
  [AccessedThroughProperty("Label13")]
  private Label _Label13;
  [AccessedThroughProperty("Label12")]
  private Label _Label12;
  [AccessedThroughProperty("RadioButton9")]
  private RadioButton _RadioButton9;
  [AccessedThroughProperty("Label17")]
  private Label _Label17;
  [AccessedThroughProperty("Label16")]
  private Label _Label16;
  private string CurrDir;
  private object LocalMousePosition;
  private object File;
  private object mappa;
  private object Monster;
  private object NameMonster;
  private object MapNumber;
  private object CordX;
  private object CordY;
  private object CordX_spot_old;
  private object CordY_spot_old;
  private object CordX_spot;
  private object CordY_spot;
  private object Dir;
  private object Quant;
  private object Inizio;
  private object colore;
  private Point OldCoord;
  private const string SectionSeparator = "//================================================================================================================";
  private readonly Dictionary<int, string> mapNames = new Dictionary<int, string>();
  private readonly Dictionary<int, string> monsterNames = new Dictionary<int, string>();
  private readonly Dictionary<string, string> spotDescriptions = new Dictionary<string, string>();
  private readonly Dictionary<int, string> spawnMapNames = new Dictionary<int, string>();

  public Form1()
  {
    this.Load += new EventHandler(this.Form1_Load);
    this.CurrDir = Environment.CurrentDirectory;
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  protected override void Dispose(bool disposing)
  {
    try
    {
      if (!disposing || this.components == null)
        return;
      this.components.Dispose();
    }
    finally
    {
      base.Dispose(disposing);
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Form1));
    this.StatusStrip1 = new StatusStrip();
    this.ToolStripStatusLabel1 = new ToolStripStatusLabel();
    this.GroupBox1 = new GroupBox();
    this.Label5 = new Label();
    this.Label4 = new Label();
    this.Label3 = new Label();
    this.Label1 = new Label();
    this.PictureBox1 = new PictureBox();
    this.OpenFileDialog1 = new OpenFileDialog();
    this.ComboBox1 = new ComboBox();
    this.ListBox1 = new ListBox();
    this.OpenFileDialog2 = new OpenFileDialog();
    this.Button3 = new Button();
    this.SaveFileDialog1 = new SaveFileDialog();
    this.GroupBox2 = new GroupBox();
    this.Label17 = new Label();
    this.Label16 = new Label();
    this.RadioButton9 = new RadioButton();
    this.RadioButton1 = new RadioButton();
    this.Label6 = new Label();
    this.RadioButton7 = new RadioButton();
    this.ComboBox2 = new ComboBox();
    this.RadioButton6 = new RadioButton();
    this.TextBox3 = new TextBox();
    this.RadioButton5 = new RadioButton();
    this.RadioButton8 = new RadioButton();
    this.RadioButton2 = new RadioButton();
    this.RadioButton4 = new RadioButton();
    this.RadioButton3 = new RadioButton();
    this.GroupBox3 = new GroupBox();
    this.ListBox2 = new ListBox();
    this.Button4 = new Button();
    this.Button5 = new Button();
    this.Button6 = new Button();
    this.TextBox1 = new TextBox();
    this.Button1 = new Button();
    this.Label2 = new Label();
    this.GroupBox4 = new GroupBox();
    this.TabControl1 = new TabControl();
    this.TabPage1 = new TabPage();
    this.GroupBox5 = new GroupBox();
    this.Label15 = new Label();
    this.Label14 = new Label();
    this.Label13 = new Label();
    this.Label12 = new Label();
    this.Label11 = new Label();
    this.Label10 = new Label();
    this.Label9 = new Label();
    this.Label8 = new Label();
    this.Label7 = new Label();
    this.Button2 = new Button();
    this.TabPage2 = new TabPage();
    this.Timer1 = new Timer(this.components);
    this.StatusStrip1.SuspendLayout();
    this.GroupBox1.SuspendLayout();
    ((ISupportInitialize) this.PictureBox1).BeginInit();
    this.GroupBox2.SuspendLayout();
    this.GroupBox3.SuspendLayout();
    this.GroupBox4.SuspendLayout();
    this.TabControl1.SuspendLayout();
    this.TabPage1.SuspendLayout();
    this.GroupBox5.SuspendLayout();
    this.SuspendLayout();
    this.StatusStrip1.Items.AddRange(new ToolStripItem[1]
    {
      (ToolStripItem) this.ToolStripStatusLabel1
    });
    StatusStrip statusStrip1_1 = this.StatusStrip1;
    Point point1 = new Point(0, 619);
    Point point2 = point1;
    statusStrip1_1.Location = point2;
    this.StatusStrip1.Name = "StatusStrip1";
    StatusStrip statusStrip1_2 = this.StatusStrip1;
    Size size1 = new Size(940, 22);
    Size size2 = size1;
    statusStrip1_2.Size = size2;
    this.StatusStrip1.SizingGrip = false;
    this.StatusStrip1.TabIndex = 0;
    this.StatusStrip1.Text = "StatusStrip1";
    this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
    ToolStripStatusLabel stripStatusLabel1 = this.ToolStripStatusLabel1;
    size1 = new Size(240 /*0xF0*/, 17);
    Size size3 = size1;
    stripStatusLabel1.Size = size3;
    this.ToolStripStatusLabel1.Text = "| Created By Vampdevil | www.sunempire.it |";
    this.GroupBox1.Controls.Add((Control) this.Label5);
    this.GroupBox1.Controls.Add((Control) this.Label4);
    this.GroupBox1.Controls.Add((Control) this.Label3);
    this.GroupBox1.Controls.Add((Control) this.Label1);
    this.GroupBox1.Controls.Add((Control) this.PictureBox1);
    GroupBox groupBox1_1 = this.GroupBox1;
    point1 = new Point(388, 6);
    Point point3 = point1;
    groupBox1_1.Location = point3;
    this.GroupBox1.Name = "GroupBox1";
    GroupBox groupBox1_2 = this.GroupBox1;
    size1 = new Size(528, 546);
    Size size4 = size1;
    groupBox1_2.Size = size4;
    this.GroupBox1.TabIndex = 1;
    this.GroupBox1.TabStop = false;
    this.Label5.AutoSize = true;
    Label label5_1 = this.Label5;
    point1 = new Point(468, 0);
    Point point4 = point1;
    label5_1.Location = point4;
    this.Label5.Name = "Label5";
    Label label5_2 = this.Label5;
    size1 = new Size(0, 13);
    Size size5 = size1;
    label5_2.Size = size5;
    this.Label5.TabIndex = 2;
    this.Label4.AutoSize = true;
    Label label4_1 = this.Label4;
    point1 = new Point(369, 0);
    Point point5 = point1;
    label4_1.Location = point5;
    this.Label4.Name = "Label4";
    Label label4_2 = this.Label4;
    size1 = new Size(0, 13);
    Size size6 = size1;
    label4_2.Size = size6;
    this.Label4.TabIndex = 1;
    this.Label3.AutoSize = true;
    Label label3_1 = this.Label3;
    point1 = new Point(432, 0);
    Point point6 = point1;
    label3_1.Location = point6;
    this.Label3.Name = "Label3";
    Label label3_2 = this.Label3;
    size1 = new Size(39, 13);
    Size size7 = size1;
    label3_2.Size = size7;
    this.Label3.TabIndex = 4;
    this.Label3.Text = "CordY:";
    this.Label1.AutoSize = true;
    Label label1_1 = this.Label1;
    point1 = new Point(335, 0);
    Point point7 = point1;
    label1_1.Location = point7;
    this.Label1.Name = "Label1";
    Label label1_2 = this.Label1;
    size1 = new Size(39, 13);
    Size size8 = size1;
    label1_2.Size = size8;
    this.Label1.TabIndex = 3;
    this.Label1.Text = "CordX:";
    this.PictureBox1.Cursor = Cursors.Default;
    PictureBox pictureBox1_1 = this.PictureBox1;
    point1 = new Point(8, 24);
    Point point8 = point1;
    pictureBox1_1.Location = point8;
    this.PictureBox1.Name = "PictureBox1";
    PictureBox pictureBox1_2 = this.PictureBox1;
    size1 = new Size(512 /*0x0200*/, 512 /*0x0200*/);
    Size size9 = size1;
    pictureBox1_2.Size = size9;
    this.PictureBox1.TabIndex = 0;
    this.PictureBox1.TabStop = false;
    this.OpenFileDialog1.FileName = "MonsterSetBase.txt";
    this.ComboBox1.Enabled = false;
    this.ComboBox1.FormattingEnabled = true;
    ComboBox comboBox1_1 = this.ComboBox1;
    point1 = new Point(10, 19);
    Point point9 = point1;
    comboBox1_1.Location = point9;
    this.ComboBox1.Name = "ComboBox1";
    ComboBox comboBox1_2 = this.ComboBox1;
    size1 = new Size(213, 21);
    Size size10 = size1;
    comboBox1_2.Size = size10;
    this.ComboBox1.TabIndex = 4;
    this.ListBox1.FormattingEnabled = true;
    this.ListBox1.HorizontalScrollbar = true;
    ListBox listBox1_1 = this.ListBox1;
    point1 = new Point(5, 224 /*0xE0*/);
    Point point10 = point1;
    listBox1_1.Location = point10;
    this.ListBox1.Name = "ListBox1";
    ListBox listBox1_2 = this.ListBox1;
    size1 = new Size(376, 316);
    Size size11 = size1;
    listBox1_2.Size = size11;
    this.ListBox1.TabIndex = 10;
    this.OpenFileDialog2.FileName = "Monster.txt";
    this.Button3.Enabled = false;
    Button button3_1 = this.Button3;
    point1 = new Point(272, 145);
    Point point11 = point1;
    button3_1.Location = point11;
    this.Button3.Name = "Button3";
    Button button3_2 = this.Button3;
    size1 = new Size(75, 39);
    Size size12 = size1;
    button3_2.Size = size12;
    this.Button3.TabIndex = 11;
    this.Button3.Text = "Save";
    this.Button3.UseVisualStyleBackColor = true;
    this.SaveFileDialog1.FileName = "MonsterSetBase.txt";
    this.GroupBox2.Controls.Add((Control) this.Label17);
    this.GroupBox2.Controls.Add((Control) this.Label16);
    this.GroupBox2.Controls.Add((Control) this.RadioButton9);
    this.GroupBox2.Controls.Add((Control) this.RadioButton1);
    this.GroupBox2.Controls.Add((Control) this.Label6);
    this.GroupBox2.Controls.Add((Control) this.RadioButton7);
    this.GroupBox2.Controls.Add((Control) this.ComboBox2);
    this.GroupBox2.Controls.Add((Control) this.ComboBox1);
    this.GroupBox2.Controls.Add((Control) this.RadioButton6);
    this.GroupBox2.Controls.Add((Control) this.TextBox3);
    this.GroupBox2.Controls.Add((Control) this.RadioButton5);
    this.GroupBox2.Controls.Add((Control) this.RadioButton8);
    this.GroupBox2.Controls.Add((Control) this.RadioButton2);
    this.GroupBox2.Controls.Add((Control) this.RadioButton4);
    this.GroupBox2.Controls.Add((Control) this.RadioButton3);
    GroupBox groupBox2_1 = this.GroupBox2;
    point1 = new Point(5, 72);
    Point point12 = point1;
    groupBox2_1.Location = point12;
    this.GroupBox2.Name = "GroupBox2";
    GroupBox groupBox2_2 = this.GroupBox2;
    size1 = new Size(231, 146);
    Size size13 = size1;
    groupBox2_2.Size = size13;
    this.GroupBox2.TabIndex = 17;
    this.GroupBox2.TabStop = false;
    this.GroupBox2.Text = "Option";
    this.Label17.AutoSize = true;
    Label label17_1 = this.Label17;
    point1 = new Point(189, 99);
    Point point13 = point1;
    label17_1.Location = point13;
    this.Label17.Name = "Label17";
    Label label17_2 = this.Label17;
    size1 = new Size(0, 13);
    Size size14 = size1;
    label17_2.Size = size14;
    this.Label17.TabIndex = 36;
    this.Label16.AutoSize = true;
    Label label16_1 = this.Label16;
    point1 = new Point(164, 99);
    Point point14 = point1;
    label16_1.Location = point14;
    this.Label16.Name = "Label16";
    Label label16_2 = this.Label16;
    size1 = new Size(26, 13);
    Size size15 = size1;
    label16_2.Size = size15;
    this.Label16.TabIndex = 35;
    this.Label16.Text = "Dir: ";
    this.RadioButton9.AutoSize = true;
    this.RadioButton9.Checked = true;
    RadioButton radioButton9_1 = this.RadioButton9;
    point1 = new Point(113, 99);
    Point point15 = point1;
    radioButton9_1.Location = point15;
    this.RadioButton9.Name = "RadioButton9";
    RadioButton radioButton9_2 = this.RadioButton9;
    size1 = new Size(14, 13);
    Size size16 = size1;
    radioButton9_2.Size = size16;
    this.RadioButton9.TabIndex = 34;
    this.RadioButton9.TabStop = true;
    this.RadioButton9.UseVisualStyleBackColor = true;
    this.RadioButton1.AutoSize = true;
    RadioButton radioButton1_1 = this.RadioButton1;
    point1 = new Point(93, 118);
    Point point16 = point1;
    radioButton1_1.Location = point16;
    this.RadioButton1.Name = "RadioButton1";
    RadioButton radioButton1_2 = this.RadioButton1;
    size1 = new Size(14, 13);
    Size size17 = size1;
    radioButton1_2.Size = size17;
    this.RadioButton1.TabIndex = 32 /*0x20*/;
    this.RadioButton1.UseVisualStyleBackColor = true;
    this.Label6.AutoSize = true;
    Label label6_1 = this.Label6;
    point1 = new Point(8, 99);
    Point point17 = point1;
    label6_1.Location = point17;
    this.Label6.Name = "Label6";
    Label label6_2 = this.Label6;
    size1 = new Size(69, 13);
    Size size18 = size1;
    label6_2.Size = size18;
    this.Label6.TabIndex = 33;
    this.Label6.Text = "NPC Position";
    this.RadioButton7.AutoSize = true;
    RadioButton radioButton7_1 = this.RadioButton7;
    point1 = new Point(93, 80 /*0x50*/);
    Point point18 = point1;
    radioButton7_1.Location = point18;
    this.RadioButton7.Name = "RadioButton7";
    RadioButton radioButton7_2 = this.RadioButton7;
    size1 = new Size(14, 13);
    Size size19 = size1;
    radioButton7_2.Size = size19;
    this.RadioButton7.TabIndex = 31 /*0x1F*/;
    this.RadioButton7.UseVisualStyleBackColor = true;
    this.ComboBox2.Enabled = false;
    this.ComboBox2.FormattingEnabled = true;
    this.ComboBox2.Items.AddRange(new object[5]
    {
      (object) "0 - Guards / NPC / Traps",
      (object) "1 - Spots",
      (object) "2 - Normal Monster",
      (object) "3 - Bone King / Golden Monsters",
      (object) "4 - Blood Castle Monsters / Gate"
    });
    ComboBox comboBox2_1 = this.ComboBox2;
    point1 = new Point(10, 46);
    Point point19 = point1;
    comboBox2_1.Location = point19;
    this.ComboBox2.Name = "ComboBox2";
    ComboBox comboBox2_2 = this.ComboBox2;
    size1 = new Size(184, 21);
    Size size20 = size1;
    comboBox2_2.Size = size20;
    this.ComboBox2.TabIndex = 18;
    this.ComboBox2.Text = "0 - Guards / NPC / Traps";
    this.RadioButton6.AutoSize = true;
    RadioButton radioButton6_1 = this.RadioButton6;
    point1 = new Point(113, 70);
    Point point20 = point1;
    radioButton6_1.Location = point20;
    this.RadioButton6.Name = "RadioButton6";
    RadioButton radioButton6_2 = this.RadioButton6;
    size1 = new Size(14, 13);
    Size size21 = size1;
    radioButton6_2.Size = size21;
    this.RadioButton6.TabIndex = 30;
    this.RadioButton6.UseVisualStyleBackColor = true;
    this.TextBox3.Enabled = false;
    TextBox textBox3_1 = this.TextBox3;
    point1 = new Point(200, 47);
    Point point21 = point1;
    textBox3_1.Location = point21;
    this.TextBox3.Name = "TextBox3";
    TextBox textBox3_2 = this.TextBox3;
    size1 = new Size(23, 20);
    Size size22 = size1;
    textBox3_2.Size = size22;
    this.TextBox3.TabIndex = 20;
    this.TextBox3.Text = "0";
    this.RadioButton5.AutoSize = true;
    RadioButton radioButton5_1 = this.RadioButton5;
    point1 = new Point(133, 80 /*0x50*/);
    Point point22 = point1;
    radioButton5_1.Location = point22;
    this.RadioButton5.Name = "RadioButton5";
    RadioButton radioButton5_2 = this.RadioButton5;
    size1 = new Size(14, 13);
    Size size23 = size1;
    radioButton5_2.Size = size23;
    this.RadioButton5.TabIndex = 29;
    this.RadioButton5.UseVisualStyleBackColor = true;
    this.RadioButton8.AutoSize = true;
    RadioButton radioButton8_1 = this.RadioButton8;
    point1 = new Point(84, 99);
    Point point23 = point1;
    radioButton8_1.Location = point23;
    this.RadioButton8.Name = "RadioButton8";
    RadioButton radioButton8_2 = this.RadioButton8;
    size1 = new Size(14, 13);
    Size size24 = size1;
    radioButton8_2.Size = size24;
    this.RadioButton8.TabIndex = 24;
    this.RadioButton8.UseVisualStyleBackColor = true;
    this.RadioButton2.AutoSize = true;
    RadioButton radioButton2_1 = this.RadioButton2;
    point1 = new Point(113, (int) sbyte.MaxValue);
    Point point24 = point1;
    radioButton2_1.Location = point24;
    this.RadioButton2.Name = "RadioButton2";
    RadioButton radioButton2_2 = this.RadioButton2;
    size1 = new Size(14, 13);
    Size size25 = size1;
    radioButton2_2.Size = size25;
    this.RadioButton2.TabIndex = 26;
    this.RadioButton2.UseVisualStyleBackColor = true;
    this.RadioButton4.AutoSize = true;
    RadioButton radioButton4_1 = this.RadioButton4;
    point1 = new Point(144 /*0x90*/, 99);
    Point point25 = point1;
    radioButton4_1.Location = point25;
    this.RadioButton4.Name = "RadioButton4";
    RadioButton radioButton4_2 = this.RadioButton4;
    size1 = new Size(14, 13);
    Size size26 = size1;
    radioButton4_2.Size = size26;
    this.RadioButton4.TabIndex = 28;
    this.RadioButton4.UseVisualStyleBackColor = true;
    this.RadioButton3.AutoSize = true;
    RadioButton radioButton3_1 = this.RadioButton3;
    point1 = new Point(133, 118);
    Point point26 = point1;
    radioButton3_1.Location = point26;
    this.RadioButton3.Name = "RadioButton3";
    RadioButton radioButton3_2 = this.RadioButton3;
    size1 = new Size(14, 13);
    Size size27 = size1;
    radioButton3_2.Size = size27;
    this.RadioButton3.TabIndex = 27;
    this.RadioButton3.UseVisualStyleBackColor = true;
    this.GroupBox3.Controls.Add((Control) this.ListBox2);
    GroupBox groupBox3_1 = this.GroupBox3;
    point1 = new Point(242, 6);
    Point point27 = point1;
    groupBox3_1.Location = point27;
    this.GroupBox3.Name = "GroupBox3";
    GroupBox groupBox3_2 = this.GroupBox3;
    size1 = new Size(140, 133);
    Size size28 = size1;
    groupBox3_2.Size = size28;
    this.GroupBox3.TabIndex = 18;
    this.GroupBox3.TabStop = false;
    this.GroupBox3.Text = "Monster";
    this.ListBox2.FormattingEnabled = true;
    ListBox listBox2_1 = this.ListBox2;
    point1 = new Point(6, 19);
    Point point28 = point1;
    listBox2_1.Location = point28;
    this.ListBox2.Name = "ListBox2";
    ListBox listBox2_2 = this.ListBox2;
    size1 = new Size(128 /*0x80*/, 108);
    Size size29 = size1;
    listBox2_2.Size = size29;
    this.ListBox2.TabIndex = 0;
    this.Button4.Enabled = false;
    Button button4_1 = this.Button4;
    point1 = new Point(4, 548);
    Point point29 = point1;
    button4_1.Location = point29;
    this.Button4.Name = "Button4";
    Button button4_2 = this.Button4;
    size1 = new Size(186, 23);
    Size size30 = size1;
    button4_2.Size = size30;
    this.Button4.TabIndex = 21;
    this.Button4.Text = "Delete selected Rows";
    this.Button4.UseVisualStyleBackColor = true;
    this.Button5.Enabled = false;
    Button button5_1 = this.Button5;
    point1 = new Point(197, 548);
    Point point30 = point1;
    button5_1.Location = point30;
    this.Button5.Name = "Button5";
    Button button5_2 = this.Button5;
    size1 = new Size(184, 23);
    Size size31 = size1;
    button5_2.Size = size31;
    this.Button5.TabIndex = 22;
    this.Button5.Text = "Delete all rows";
    this.Button5.UseVisualStyleBackColor = true;
    this.Button6.Enabled = false;
    Button button6_1 = this.Button6;
    point1 = new Point(315, 190);
    Point point31 = point1;
    button6_1.Location = point31;
    this.Button6.Name = "Button6";
    Button button6_2 = this.Button6;
    size1 = new Size(67, 22);
    Size size32 = size1;
    button6_2.Size = size32;
    this.Button6.TabIndex = 23;
    this.Button6.Text = "Close 'End'";
    this.Button6.UseVisualStyleBackColor = true;
    TextBox textBox1_1 = this.TextBox1;
    point1 = new Point(9, 32 /*0x20*/);
    Point point32 = point1;
    textBox1_1.Location = point32;
    this.TextBox1.Name = "TextBox1";
    this.TextBox1.ReadOnly = true;
    TextBox textBox1_2 = this.TextBox1;
    size1 = new Size(134, 20);
    Size size33 = size1;
    textBox1_2.Size = size33;
    this.TextBox1.TabIndex = 3;
    Button button1_1 = this.Button1;
    point1 = new Point(149, 29);
    Point point33 = point1;
    button1_1.Location = point33;
    this.Button1.Name = "Button1";
    Button button1_2 = this.Button1;
    size1 = new Size(75, 23);
    Size size34 = size1;
    button1_2.Size = size34;
    this.Button1.TabIndex = 2;
    this.Button1.Text = "Browse";
    this.Button1.UseVisualStyleBackColor = true;
    this.Label2.AutoSize = true;
    Label label2_1 = this.Label2;
    point1 = new Point(7, 16 /*0x10*/);
    Point point34 = point1;
    label2_1.Location = point34;
    this.Label2.Name = "Label2";
    Label label2_2 = this.Label2;
    size1 = new Size(88, 13);
    Size size35 = size1;
    label2_2.Size = size35;
    this.Label2.TabIndex = 8;
    this.Label2.Text = "MonsterSetBase:";
    this.GroupBox4.Controls.Add((Control) this.Label2);
    this.GroupBox4.Controls.Add((Control) this.Button1);
    this.GroupBox4.Controls.Add((Control) this.TextBox1);
    GroupBox groupBox4_1 = this.GroupBox4;
    point1 = new Point(6, 6);
    Point point35 = point1;
    groupBox4_1.Location = point35;
    this.GroupBox4.Name = "GroupBox4";
    GroupBox groupBox4_2 = this.GroupBox4;
    size1 = new Size(231, 60);
    Size size36 = size1;
    groupBox4_2.Size = size36;
    this.GroupBox4.TabIndex = 19;
    this.GroupBox4.TabStop = false;
    this.GroupBox4.Text = "Select File";
    this.TabControl1.Controls.Add((Control) this.TabPage1);
    this.TabControl1.Controls.Add((Control) this.TabPage2);
    TabControl tabControl1_1 = this.TabControl1;
    point1 = new Point(1, 1);
    Point point36 = point1;
    tabControl1_1.Location = point36;
    this.TabControl1.Name = "TabControl1";
    this.TabControl1.SelectedIndex = 0;
    TabControl tabControl1_2 = this.TabControl1;
    size1 = new Size(936, 617);
    Size size37 = size1;
    tabControl1_2.Size = size37;
    this.TabControl1.TabIndex = 25;
    this.TabPage1.Controls.Add((Control) this.GroupBox5);
    this.TabPage1.Controls.Add((Control) this.Button2);
    this.TabPage1.Controls.Add((Control) this.GroupBox4);
    this.TabPage1.Controls.Add((Control) this.Button5);
    this.TabPage1.Controls.Add((Control) this.Button4);
    this.TabPage1.Controls.Add((Control) this.GroupBox1);
    this.TabPage1.Controls.Add((Control) this.Button6);
    this.TabPage1.Controls.Add((Control) this.ListBox1);
    this.TabPage1.Controls.Add((Control) this.Button3);
    this.TabPage1.Controls.Add((Control) this.GroupBox2);
    this.TabPage1.Controls.Add((Control) this.GroupBox3);
    TabPage tabPage1_1 = this.TabPage1;
    point1 = new Point(4, 22);
    Point point37 = point1;
    tabPage1_1.Location = point37;
    this.TabPage1.Name = "TabPage1";
    TabPage tabPage1_2 = this.TabPage1;
    Padding padding1 = new Padding(3);
    Padding padding2 = padding1;
    tabPage1_2.Padding = padding2;
    TabPage tabPage1_3 = this.TabPage1;
    size1 = new Size(928, 591);
    Size size38 = size1;
    tabPage1_3.Size = size38;
    this.TabPage1.TabIndex = 0;
    this.TabPage1.Text = "MonsterSetBase";
    this.TabPage1.UseVisualStyleBackColor = true;
    this.GroupBox5.Controls.Add((Control) this.Label15);
    this.GroupBox5.Controls.Add((Control) this.Label14);
    this.GroupBox5.Controls.Add((Control) this.Label13);
    this.GroupBox5.Controls.Add((Control) this.Label12);
    this.GroupBox5.Controls.Add((Control) this.Label11);
    this.GroupBox5.Controls.Add((Control) this.Label10);
    this.GroupBox5.Controls.Add((Control) this.Label9);
    this.GroupBox5.Controls.Add((Control) this.Label8);
    this.GroupBox5.Controls.Add((Control) this.Label7);
    GroupBox groupBox5_1 = this.GroupBox5;
    point1 = new Point(391, 553);
    Point point38 = point1;
    groupBox5_1.Location = point38;
    this.GroupBox5.Name = "GroupBox5";
    GroupBox groupBox5_2 = this.GroupBox5;
    size1 = new Size(525, 31 /*0x1F*/);
    Size size39 = size1;
    groupBox5_2.Size = size39;
    this.GroupBox5.TabIndex = 24;
    this.GroupBox5.TabStop = false;
    this.GroupBox5.Text = "Legenda";
    this.Label15.AutoSize = true;
    Label label15_1 = this.Label15;
    point1 = new Point(373, 12);
    Point point39 = point1;
    label15_1.Location = point39;
    this.Label15.Name = "Label15";
    Label label15_2 = this.Label15;
    size1 = new Size(9, 13);
    Size size40 = size1;
    label15_2.Size = size40;
    this.Label15.TabIndex = 26;
    this.Label15.Text = "|";
    this.Label14.AutoSize = true;
    Label label14_1 = this.Label14;
    point1 = new Point(226, 12);
    Point point40 = point1;
    label14_1.Location = point40;
    this.Label14.Name = "Label14";
    Label label14_2 = this.Label14;
    size1 = new Size(9, 13);
    Size size41 = size1;
    label14_2.Size = size41;
    this.Label14.TabIndex = 27;
    this.Label14.Text = "|";
    this.Label13.AutoSize = true;
    Label label13_1 = this.Label13;
    point1 = new Point(144 /*0x90*/, 12);
    Point point41 = point1;
    label13_1.Location = point41;
    this.Label13.Name = "Label13";
    Label label13_2 = this.Label13;
    size1 = new Size(9, 13);
    Size size42 = size1;
    label13_2.Size = size42;
    this.Label13.TabIndex = 26;
    this.Label13.Text = "|";
    this.Label12.AutoSize = true;
    Label label12_1 = this.Label12;
    point1 = new Point(110, 13);
    Point point42 = point1;
    label12_1.Location = point42;
    this.Label12.Name = "Label12";
    Label label12_2 = this.Label12;
    size1 = new Size(9, 13);
    Size size43 = size1;
    label12_2.Size = size43;
    this.Label12.TabIndex = 25;
    this.Label12.Text = "|";
    this.Label11.AutoSize = true;
    this.Label11.ForeColor = Color.Blue;
    Label label11_1 = this.Label11;
    point1 = new Point(378, 12);
    Point point43 = point1;
    label11_1.Location = point43;
    this.Label11.Name = "Label11";
    Label label11_2 = this.Label11;
    size1 = new Size(146, 13);
    Size size44 = size1;
    label11_2.Size = size44;
    this.Label11.TabIndex = 5;
    this.Label11.Text = "Blood Castle Monsters / Gate";
    this.Label10.AutoSize = true;
    this.Label10.ForeColor = Color.DarkGoldenrod;
    Label label10_1 = this.Label10;
    point1 = new Point(231, 12);
    Point point44 = point1;
    label10_1.Location = point44;
    this.Label10.Name = "Label10";
    Label label10_2 = this.Label10;
    size1 = new Size(147, 13);
    Size size45 = size1;
    label10_2.Size = size45;
    this.Label10.TabIndex = 4;
    this.Label10.Text = "Bone King / Golden Monsters";
    this.Label9.AutoSize = true;
    this.Label9.ForeColor = Color.Lime;
    Label label9_1 = this.Label9;
    point1 = new Point(149, 13);
    Point point45 = point1;
    label9_1.Location = point45;
    this.Label9.Name = "Label9";
    Label label9_2 = this.Label9;
    size1 = new Size(81, 13);
    Size size46 = size1;
    label9_2.Size = size46;
    this.Label9.TabIndex = 3;
    this.Label9.Text = "Normal Monster";
    this.Label8.AutoSize = true;
    this.Label8.ForeColor = Color.FromArgb((int) byte.MaxValue, 128 /*0x80*/, 0);
    Label label8_1 = this.Label8;
    point1 = new Point(115, 12);
    Point point46 = point1;
    label8_1.Location = point46;
    this.Label8.Name = "Label8";
    Label label8_2 = this.Label8;
    size1 = new Size(34, 13);
    Size size47 = size1;
    label8_2.Size = size47;
    this.Label8.TabIndex = 2;
    this.Label8.Text = "Spots";
    this.Label7.AutoSize = true;
    this.Label7.ForeColor = Color.Red;
    Label label7_1 = this.Label7;
    point1 = new Point(3, 12);
    Point point47 = point1;
    label7_1.Location = point47;
    this.Label7.Name = "Label7";
    Label label7_2 = this.Label7;
    size1 = new Size(112 /*0x70*/, 13);
    Size size48 = size1;
    label7_2.Size = size48;
    this.Label7.TabIndex = 1;
    this.Label7.Text = "Guards / NPC / Traps";
    this.Button2.Enabled = false;
    Button button2_1 = this.Button2;
    point1 = new Point(242, 190);
    Point point48 = point1;
    button2_1.Location = point48;
    this.Button2.Name = "Button2";
    Button button2_2 = this.Button2;
    size1 = new Size(74, 22);
    Size size49 = size1;
    button2_2.Size = size49;
    this.Button2.TabIndex = 5;
    this.Button2.Text = "Load Mob";
    this.Button2.UseVisualStyleBackColor = true;
    TabPage tabPage2_1 = this.TabPage2;
    point1 = new Point(4, 22);
    Point point49 = point1;
    tabPage2_1.Location = point49;
    this.TabPage2.Name = "TabPage2";
    TabPage tabPage2_2 = this.TabPage2;
    padding1 = new Padding(3);
    Padding padding3 = padding1;
    tabPage2_2.Padding = padding3;
    TabPage tabPage2_3 = this.TabPage2;
    size1 = new Size(928, 591);
    Size size50 = size1;
    tabPage2_3.Size = size50;
    this.TabPage2.TabIndex = 1;
    this.TabPage2.Text = "Monster";
    this.TabPage2.UseVisualStyleBackColor = true;
    this.Timer1.Interval = 200;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(940, 641);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.TabControl1);
    this.Controls.Add((Control) this.StatusStrip1);
    this.FormBorderStyle = FormBorderStyle.FixedSingle;
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.MaximizeBox = false;
    this.Name = nameof (Form1);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "MonsterSetBase & Monster Editor 2.0";
    this.StatusStrip1.ResumeLayout(false);
    this.StatusStrip1.PerformLayout();
    this.GroupBox1.ResumeLayout(false);
    this.GroupBox1.PerformLayout();
    ((ISupportInitialize) this.PictureBox1).EndInit();
    this.GroupBox2.ResumeLayout(false);
    this.GroupBox2.PerformLayout();
    this.GroupBox3.ResumeLayout(false);
    this.GroupBox4.ResumeLayout(false);
    this.GroupBox4.PerformLayout();
    this.TabControl1.ResumeLayout(false);
    this.TabPage1.ResumeLayout(false);
    this.GroupBox5.ResumeLayout(false);
    this.GroupBox5.PerformLayout();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual StatusStrip StatusStrip1
  {
    [DebuggerNonUserCode] get => this._StatusStrip1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._StatusStrip1 = value;
    }
  }

  internal virtual ToolStripStatusLabel ToolStripStatusLabel1
  {
    [DebuggerNonUserCode] get => this._ToolStripStatusLabel1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._ToolStripStatusLabel1 = value;
    }
  }

  internal virtual GroupBox GroupBox1
  {
    [DebuggerNonUserCode] get => this._GroupBox1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._GroupBox1 = value;
    }
  }

  internal virtual PictureBox PictureBox1
  {
    [DebuggerNonUserCode] get => this._PictureBox1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      MouseEventHandler mouseEventHandler1 = new MouseEventHandler(this.PictureBox1_MouseClick);
      MouseEventHandler mouseEventHandler2 = new MouseEventHandler(this.PictureBox1_MouseUp);
      MouseEventHandler mouseEventHandler3 = new MouseEventHandler(this.PictureBox1_MouseDown);
      MouseEventHandler mouseEventHandler4 = new MouseEventHandler(this.PictureBox1_MouseMove);
      if (this._PictureBox1 != null)
      {
        this._PictureBox1.MouseClick -= mouseEventHandler1;
        this._PictureBox1.MouseUp -= mouseEventHandler2;
        this._PictureBox1.MouseDown -= mouseEventHandler3;
        this._PictureBox1.MouseMove -= mouseEventHandler4;
      }
      this._PictureBox1 = value;
      if (this._PictureBox1 == null)
        return;
      this._PictureBox1.MouseClick += mouseEventHandler1;
      this._PictureBox1.MouseUp += mouseEventHandler2;
      this._PictureBox1.MouseDown += mouseEventHandler3;
      this._PictureBox1.MouseMove += mouseEventHandler4;
    }
  }

  internal virtual OpenFileDialog OpenFileDialog1
  {
    [DebuggerNonUserCode] get => this._OpenFileDialog1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._OpenFileDialog1 = value;
    }
  }

  internal virtual ComboBox ComboBox1
  {
    [DebuggerNonUserCode] get => this._ComboBox1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ComboBox1_SelectedIndexChanged);
      if (this._ComboBox1 != null)
        this._ComboBox1.SelectedIndexChanged -= eventHandler;
      this._ComboBox1 = value;
      if (this._ComboBox1 == null)
        return;
      this._ComboBox1.SelectedIndexChanged += eventHandler;
    }
  }

  internal virtual ListBox ListBox1
  {
    [DebuggerNonUserCode] get => this._ListBox1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._ListBox1 = value;
  }

  internal virtual OpenFileDialog OpenFileDialog2
  {
    [DebuggerNonUserCode] get => this._OpenFileDialog2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._OpenFileDialog2 = value;
    }
  }

  internal virtual Button Button3
  {
    [DebuggerNonUserCode] get => this._Button3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.Button3_Click);
      if (this._Button3 != null)
        this._Button3.Click -= eventHandler;
      this._Button3 = value;
      if (this._Button3 == null)
        return;
      this._Button3.Click += eventHandler;
    }
  }

  internal virtual SaveFileDialog SaveFileDialog1
  {
    [DebuggerNonUserCode] get => this._SaveFileDialog1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._SaveFileDialog1 = value;
    }
  }

  internal virtual Label Label5
  {
    [DebuggerNonUserCode] get => this._Label5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label5 = value;
  }

  internal virtual Label Label4
  {
    [DebuggerNonUserCode] get => this._Label4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label4 = value;
  }

  internal virtual GroupBox GroupBox2
  {
    [DebuggerNonUserCode] get => this._GroupBox2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._GroupBox2 = value;
    }
  }

  internal virtual ComboBox ComboBox2
  {
    [DebuggerNonUserCode] get => this._ComboBox2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ComboBox2_SelectedIndexChanged);
      if (this._ComboBox2 != null)
        this._ComboBox2.SelectedIndexChanged -= eventHandler;
      this._ComboBox2 = value;
      if (this._ComboBox2 == null)
        return;
      this._ComboBox2.SelectedIndexChanged += eventHandler;
    }
  }

  internal virtual GroupBox GroupBox3
  {
    [DebuggerNonUserCode] get => this._GroupBox3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._GroupBox3 = value;
    }
  }

  internal virtual ListBox ListBox2
  {
    [DebuggerNonUserCode] get => this._ListBox2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._ListBox2 = value;
  }

  internal virtual TextBox TextBox3
  {
    [DebuggerNonUserCode] get => this._TextBox3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._TextBox3 = value;
  }

  internal virtual Button Button4
  {
    [DebuggerNonUserCode] get => this._Button4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.Button4_Click);
      if (this._Button4 != null)
        this._Button4.Click -= eventHandler;
      this._Button4 = value;
      if (this._Button4 == null)
        return;
      this._Button4.Click += eventHandler;
    }
  }

  internal virtual Button Button5
  {
    [DebuggerNonUserCode] get => this._Button5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.Button5_Click);
      if (this._Button5 != null)
        this._Button5.Click -= eventHandler;
      this._Button5 = value;
      if (this._Button5 == null)
        return;
      this._Button5.Click += eventHandler;
    }
  }

  internal virtual Button Button6
  {
    [DebuggerNonUserCode] get => this._Button6;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.Button6_Click);
      if (this._Button6 != null)
        this._Button6.Click -= eventHandler;
      this._Button6 = value;
      if (this._Button6 == null)
        return;
      this._Button6.Click += eventHandler;
    }
  }

  internal virtual TextBox TextBox1
  {
    [DebuggerNonUserCode] get => this._TextBox1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._TextBox1 = value;
  }

  internal virtual Button Button1
  {
    [DebuggerNonUserCode] get => this._Button1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.Button1_Click);
      if (this._Button1 != null)
        this._Button1.Click -= eventHandler;
      this._Button1 = value;
      if (this._Button1 == null)
        return;
      this._Button1.Click += eventHandler;
    }
  }

  internal virtual Label Label2
  {
    [DebuggerNonUserCode] get => this._Label2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label2 = value;
  }

  internal virtual GroupBox GroupBox4
  {
    [DebuggerNonUserCode] get => this._GroupBox4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._GroupBox4 = value;
    }
  }

  internal virtual TabControl TabControl1
  {
    [DebuggerNonUserCode] get => this._TabControl1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._TabControl1 = value;
    }
  }

  internal virtual TabPage TabPage1
  {
    [DebuggerNonUserCode] get => this._TabPage1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._TabPage1 = value;
  }

  internal virtual TabPage TabPage2
  {
    [DebuggerNonUserCode] get => this._TabPage2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._TabPage2 = value;
  }

  internal virtual Label Label3
  {
    [DebuggerNonUserCode] get => this._Label3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label3 = value;
  }

  internal virtual Label Label1
  {
    [DebuggerNonUserCode] get => this._Label1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
  }

  internal virtual Button Button2
  {
    [DebuggerNonUserCode] get => this._Button2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.Button2_Click);
      if (this._Button2 != null)
        this._Button2.Click -= eventHandler;
      this._Button2 = value;
      if (this._Button2 == null)
        return;
      this._Button2.Click += eventHandler;
    }
  }

  internal virtual Timer Timer1
  {
    [DebuggerNonUserCode] get => this._Timer1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.Timer1_Tick);
      if (this._Timer1 != null)
        this._Timer1.Tick -= eventHandler;
      this._Timer1 = value;
      if (this._Timer1 == null)
        return;
      this._Timer1.Tick += eventHandler;
    }
  }

  internal virtual Label Label6
  {
    [DebuggerNonUserCode] get => this._Label6;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label6 = value;
  }

  internal virtual RadioButton RadioButton1
  {
    [DebuggerNonUserCode] get => this._RadioButton1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.RadioButton1_CheckedChanged);
      if (this._RadioButton1 != null)
        this._RadioButton1.CheckedChanged -= eventHandler;
      this._RadioButton1 = value;
      if (this._RadioButton1 == null)
        return;
      this._RadioButton1.CheckedChanged += eventHandler;
    }
  }

  internal virtual RadioButton RadioButton7
  {
    [DebuggerNonUserCode] get => this._RadioButton7;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.RadioButton7_CheckedChanged);
      if (this._RadioButton7 != null)
        this._RadioButton7.CheckedChanged -= eventHandler;
      this._RadioButton7 = value;
      if (this._RadioButton7 == null)
        return;
      this._RadioButton7.CheckedChanged += eventHandler;
    }
  }

  internal virtual RadioButton RadioButton6
  {
    [DebuggerNonUserCode] get => this._RadioButton6;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.RadioButton6_CheckedChanged);
      if (this._RadioButton6 != null)
        this._RadioButton6.CheckedChanged -= eventHandler;
      this._RadioButton6 = value;
      if (this._RadioButton6 == null)
        return;
      this._RadioButton6.CheckedChanged += eventHandler;
    }
  }

  internal virtual RadioButton RadioButton5
  {
    [DebuggerNonUserCode] get => this._RadioButton5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.RadioButton5_CheckedChanged);
      if (this._RadioButton5 != null)
        this._RadioButton5.CheckedChanged -= eventHandler;
      this._RadioButton5 = value;
      if (this._RadioButton5 == null)
        return;
      this._RadioButton5.CheckedChanged += eventHandler;
    }
  }

  internal virtual RadioButton RadioButton8
  {
    [DebuggerNonUserCode] get => this._RadioButton8;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.RadioButton8_CheckedChanged);
      if (this._RadioButton8 != null)
        this._RadioButton8.CheckedChanged -= eventHandler;
      this._RadioButton8 = value;
      if (this._RadioButton8 == null)
        return;
      this._RadioButton8.CheckedChanged += eventHandler;
    }
  }

  internal virtual RadioButton RadioButton2
  {
    [DebuggerNonUserCode] get => this._RadioButton2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.RadioButton2_CheckedChanged);
      if (this._RadioButton2 != null)
        this._RadioButton2.CheckedChanged -= eventHandler;
      this._RadioButton2 = value;
      if (this._RadioButton2 == null)
        return;
      this._RadioButton2.CheckedChanged += eventHandler;
    }
  }

  internal virtual RadioButton RadioButton4
  {
    [DebuggerNonUserCode] get => this._RadioButton4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.RadioButton4_CheckedChanged);
      if (this._RadioButton4 != null)
        this._RadioButton4.CheckedChanged -= eventHandler;
      this._RadioButton4 = value;
      if (this._RadioButton4 == null)
        return;
      this._RadioButton4.CheckedChanged += eventHandler;
    }
  }

  internal virtual RadioButton RadioButton3
  {
    [DebuggerNonUserCode] get => this._RadioButton3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.RadioButton3_CheckedChanged);
      if (this._RadioButton3 != null)
        this._RadioButton3.CheckedChanged -= eventHandler;
      this._RadioButton3 = value;
      if (this._RadioButton3 == null)
        return;
      this._RadioButton3.CheckedChanged += eventHandler;
    }
  }

  internal virtual GroupBox GroupBox5
  {
    [DebuggerNonUserCode] get => this._GroupBox5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._GroupBox5 = value;
    }
  }

  internal virtual Label Label11
  {
    [DebuggerNonUserCode] get => this._Label11;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label11 = value;
  }

  internal virtual Label Label10
  {
    [DebuggerNonUserCode] get => this._Label10;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label10 = value;
  }

  internal virtual Label Label9
  {
    [DebuggerNonUserCode] get => this._Label9;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label9 = value;
  }

  internal virtual Label Label8
  {
    [DebuggerNonUserCode] get => this._Label8;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label8 = value;
  }

  internal virtual Label Label7
  {
    [DebuggerNonUserCode] get => this._Label7;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label7 = value;
  }

  internal virtual Label Label15
  {
    [DebuggerNonUserCode] get => this._Label15;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label15 = value;
  }

  internal virtual Label Label14
  {
    [DebuggerNonUserCode] get => this._Label14;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label14 = value;
  }

  internal virtual Label Label13
  {
    [DebuggerNonUserCode] get => this._Label13;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label13 = value;
  }

  internal virtual Label Label12
  {
    [DebuggerNonUserCode] get => this._Label12;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label12 = value;
  }

  internal virtual RadioButton RadioButton9
  {
    [DebuggerNonUserCode] get => this._RadioButton9;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.RadioButton9_CheckedChanged);
      if (this._RadioButton9 != null)
        this._RadioButton9.CheckedChanged -= eventHandler;
      this._RadioButton9 = value;
      if (this._RadioButton9 == null)
        return;
      this._RadioButton9.CheckedChanged += eventHandler;
    }
  }

  internal virtual Label Label17
  {
    [DebuggerNonUserCode] get => this._Label17;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label17 = value;
  }

  internal virtual Label Label16
  {
    [DebuggerNonUserCode] get => this._Label16;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label16 = value;
  }

  private void Button1_Click(object sender, EventArgs e)
  {
    this.OpenFileDialog1.Filter = "Monster files (*.txt;*.xml)|*.txt;*.xml|Text files (*.txt)|*.txt|XML files (*.xml)|*.xml";
    if (this.OpenFileDialog1.ShowDialog() != DialogResult.OK)
      return;
    this.ListBox1.Items.Clear();
    try
    {
      string extension = Path.GetExtension(this.OpenFileDialog1.FileName);
      if (string.Equals(extension, ".xml", StringComparison.OrdinalIgnoreCase))
        this.LoadSpawnXml(this.OpenFileDialog1.FileName);
      else
        this.LoadSpawnText(this.OpenFileDialog1.FileName);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) Interaction.MsgBox((object) "Failed to load monster spawn file", MsgBoxStyle.Critical);
      ProjectData.ClearProjectError();
      this.ListBox1.Items.Clear();
      return;
    }
    this.TextBox1.Text = this.OpenFileDialog1.FileName;
    this.File = (object) 1;
    this.ComboBox1.Enabled = true;
    this.ComboBox2.Enabled = true;
    this.Button2.Enabled = true;
    this.Button3.Enabled = true;
    this.Button4.Enabled = true;
    this.Button5.Enabled = true;
    this.Button6.Enabled = true;
  }

  private void Button3_Click(object sender, EventArgs e)
  {
    this.SaveFileDialog1.Filter = "Monster files (*.txt;*.xml)|*.txt;*.xml|Text files (*.txt)|*.txt|XML files (*.xml)|*.xml";
    if (this.SaveFileDialog1.ShowDialog() != DialogResult.OK)
      return;
    if (Operators.ConditionalCompareObjectEqual(this.Inizio, (object) 1, false))
    {
      this.ListBox1.Items.Add((object) "end");
      this.Inizio = (object) 0;
    }
    string extension = Path.GetExtension(this.SaveFileDialog1.FileName);
    if (string.Equals(extension, ".xml", StringComparison.OrdinalIgnoreCase))
    {
      this.SaveSpawnXml(this.SaveFileDialog1.FileName);
    }
    else
    {
      using (StreamWriter streamWriter = new StreamWriter(this.SaveFileDialog1.FileName))
      {
        int num1 = checked (this.ListBox1.Items.Count - 1);
        int index = 0;
        while (index <= num1)
        {
          streamWriter.WriteLine(this.ListBox1.Items[index].ToString());
          checked { ++index; }
        }
      }
    }
    int num2 = (int) Interaction.MsgBox((object) "File saved with success", MsgBoxStyle.Information);
  }

  private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
  {
    if (!Operators.ConditionalCompareObjectEqual(this.File, (object) 1, false))
      return;
    string[] strArray = Conversions.ToString(this.ComboBox1.SelectedItem).Split(' ');
    try
    {
      this.PictureBox1.Image = Image.FromFile($"{this.CurrDir}\\Maps\\{strArray[1]}.jpg");
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) Interaction.MsgBox((object) $"\\Maps\\{strArray[1]}.jpg Not found");
      ProjectData.ClearProjectError();
    }
    this.PictureBox1.Cursor = Cursors.Cross;
    this.MapNumber = (object) strArray[0];
    this.GroupBox1.Text = strArray[1];
    this.mappa = (object) 1;
    this.PictureBox1.Image.RotateFlip(RotateFlipType.Rotate180FlipX);
    this.Timer1.Enabled = true;
  }

  private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
  {
    if (!Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(this.ComboBox2.SelectedItem, (object) "1 - Spots", false), Operators.CompareObjectEqual(this.ComboBox2.SelectedItem, (object) "3 - Bone King / Golden Monsters", false))))
      return;
    this.cord_mappa();
    this.CordX_spot_old = RuntimeHelpers.GetObjectValue(this.CordX);
    this.CordY_spot_old = RuntimeHelpers.GetObjectValue(this.CordY);
  }

  private void PictureBox1_MouseUp(object sender, MouseEventArgs e)
  {
    if (!Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(this.ComboBox2.SelectedItem, (object) "1 - Spots", false), Operators.CompareObjectEqual(this.ComboBox2.SelectedItem, (object) "3 - Bone King / Golden Monsters", false))))
      return;
    this.cord_mappa();
    this.CordX_spot = RuntimeHelpers.GetObjectValue(this.CordX);
    this.CordY_spot = RuntimeHelpers.GetObjectValue(this.CordY);
    Graphics graphics = Graphics.FromImage(this.PictureBox1.Image);
    float width = 1.5f;
    object colore = this.colore;
    Color color;
    Pen pen = new Pen(colore != null ? (Color) colore : color, width);
    Point pt1 = new Point(Conversions.ToInteger(Operators.MultiplyObject(this.CordX_spot_old, (object) 2)), Conversions.ToInteger(Operators.MultiplyObject(this.CordY_spot_old, (object) 2)));
    Point pt2 = new Point(Conversions.ToInteger(Operators.MultiplyObject(this.CordX_spot, (object) 2)), Conversions.ToInteger(Operators.MultiplyObject(this.CordY_spot, (object) 2)));
    graphics.DrawLine(pen, pt1, pt2);
    this.ListBox1.Items.Add(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(this.Monster, (object) "\t"), this.MapNumber), (object) "\t"), (object) "30"), (object) "\t"), this.CordX_spot_old), (object) "\t"), this.CordY_spot_old), (object) "\t"), this.CordX_spot), (object) "\t"), this.CordY_spot), (object) "\t"), (object) "-1"), (object) "\t"), this.Quant), (object) "\t"), (object) "// "), this.NameMonster));
  }

  public void case_switch()
  {
    if (Operators.ConditionalCompareObjectEqual(this.ComboBox2.SelectedItem, (object) "0 - Guards / NPC / Traps", false))
    {
      if (Operators.ConditionalCompareObjectEqual(this.Inizio, (object) 0, false))
      {
        this.ListBox1.Items.Add((object) "//=========================================================================================");
        this.ListBox1.Items.Add((object) $"//\t{this.GroupBox1.Text} Guards / NPC / Traps");
        this.ListBox1.Items.Add((object) "//=========================================================================================");
        this.ListBox1.Items.Add((object) "//Mob\tMap\tRad\tX\tY\tStr\tName");
        this.ListBox1.Items.Add((object) "0");
        this.Inizio = (object) 1;
      }
      this.colore = (object) Color.Red;
      this.ListBox1.Items.Add(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(this.Monster, (object) "\t"), this.MapNumber), (object) "\t"), (object) "0"), (object) "\t"), this.CordX), (object) "\t"), this.CordY), (object) "\t"), this.Dir), (object) "\t"), (object) "// "), this.NameMonster));
    }
    else if (Operators.ConditionalCompareObjectEqual(this.ComboBox2.SelectedItem, (object) "1 - Spots", false))
    {
      if (Operators.ConditionalCompareObjectEqual(this.Inizio, (object) 0, false))
      {
        this.ListBox1.Items.Add((object) "//=========================================================================================");
        this.ListBox1.Items.Add((object) $"//\t{this.GroupBox1.Text} Spots");
        this.ListBox1.Items.Add((object) "//=========================================================================================");
        this.ListBox1.Items.Add((object) "//Mob\tMap\tRadio\tCordX\tCordY\tCordX2\tCordY2\tDir \tQuant  Name");
        this.ListBox1.Items.Add((object) "1");
        this.Inizio = (object) 1;
      }
      this.colore = (object) Color.Orange;
    }
    else if (Operators.ConditionalCompareObjectEqual(this.ComboBox2.SelectedItem, (object) "2 - Normal Monster", false))
    {
      if (Operators.ConditionalCompareObjectEqual(this.Inizio, (object) 0, false))
      {
        this.ListBox1.Items.Add((object) "//=========================================================================================");
        this.ListBox1.Items.Add((object) $"//\t{this.GroupBox1.Text} Monster");
        this.ListBox1.Items.Add((object) "//=========================================================================================");
        this.ListBox1.Items.Add((object) "//Mob\tMap\tRad\tX\tY\tStr\tName");
        this.ListBox1.Items.Add((object) "2");
        this.Inizio = (object) 1;
      }
      this.colore = (object) Color.Green;
      this.ListBox1.Items.Add(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(this.Monster, (object) "\t"), this.MapNumber), (object) "\t"), (object) "30"), (object) "\t"), this.CordX), (object) "\t"), this.CordY), (object) "\t"), this.Dir), (object) "\t"), (object) "// "), this.NameMonster));
    }
    else if (Operators.ConditionalCompareObjectEqual(this.ComboBox2.SelectedItem, (object) "3 - Bone King / Golden Monsters", false))
    {
      if (Operators.ConditionalCompareObjectEqual(this.Inizio, (object) 0, false))
      {
        this.ListBox1.Items.Add((object) "//=========================================================================================");
        this.ListBox1.Items.Add((object) $"//\t{this.GroupBox1.Text} Golden Monster");
        this.ListBox1.Items.Add((object) "//=========================================================================================");
        this.ListBox1.Items.Add((object) "//Mob\tMap\tRadio\tCordX\tCordY\tCordX2\tCordY2\tDir \tQuant  Name");
        this.ListBox1.Items.Add((object) "3");
        this.Inizio = (object) 1;
      }
      this.colore = (object) Color.DarkGoldenrod;
      this.ListBox1.Items.Add(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(this.Monster, (object) "\t"), this.MapNumber), (object) "\t"), (object) "30"), (object) "\t"), this.CordX), (object) "\t"), this.CordY), (object) "\t"), this.CordX_spot), (object) "\t"), this.CordY_spot), (object) "\t"), (object) "-1"), (object) "\t"), this.Quant), (object) "\t"), (object) "// "), this.NameMonster));
    }
    else
    {
      if (!Operators.ConditionalCompareObjectEqual(this.ComboBox2.SelectedItem, (object) "4 - Blood Castle Monsters / Gate", false))
        return;
      if (Operators.ConditionalCompareObjectEqual(this.Inizio, (object) 0, false))
      {
        this.ListBox1.Items.Add((object) "//=========================================================================================");
        this.ListBox1.Items.Add((object) $"//\t{this.GroupBox1.Text} Blood Castle Monsters / Gate");
        this.ListBox1.Items.Add((object) "//=========================================================================================");
        this.ListBox1.Items.Add((object) "//Mob\tMap\tRad\tX\tY\tStr\tName");
        this.ListBox1.Items.Add((object) "4");
        this.Inizio = (object) 1;
      }
      this.colore = (object) Color.Blue;
      this.ListBox1.Items.Add(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(this.Monster, (object) "\t"), this.MapNumber), (object) "\t"), (object) "30"), (object) "\t"), this.CordX), (object) "\t"), this.CordY), (object) "\t"), this.Dir), (object) "\t"), (object) "// "), this.NameMonster));
    }
  }

  private void PictureBox1_MouseClick(object sender, MouseEventArgs e)
  {
    if (!Operators.ConditionalCompareObjectEqual(this.mappa, (object) 1, false))
      return;
    if (Operators.ConditionalCompareObjectEqual(this.ListBox2.SelectedItem, (object) "", false))
    {
      int num1 = (int) Interaction.MsgBox((object) "First select monster!", MsgBoxStyle.Critical);
    }
    else
    {
      string[] strArray = Conversions.ToString(this.ListBox2.SelectedItem).Split(' ');
      this.Monster = (object) strArray[0];
      this.NameMonster = (object) strArray[1];
      if (this.RadioButton1.Checked)
        this.Dir = (object) 1;
      else if (this.RadioButton2.Checked)
        this.Dir = (object) 2;
      else if (this.RadioButton3.Checked)
        this.Dir = (object) 3;
      else if (this.RadioButton4.Checked)
        this.Dir = (object) 5;
      else if (this.RadioButton5.Checked)
        this.Dir = (object) 6;
      else if (this.RadioButton6.Checked)
        this.Dir = (object) 6;
      else if (this.RadioButton7.Checked)
        this.Dir = (object) 7;
      else if (this.RadioButton8.Checked)
        this.Dir = (object) 8;
      else if (this.RadioButton9.Checked)
        this.Dir = (object) -1;
      this.Quant = (object) this.TextBox3.Text;
      if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(this.Quant, (object) "", false), Operators.CompareObjectEqual(this.Quant, (object) "0", false))))
        this.Quant = (object) 1;
      this.case_switch();
      if (e.Button != MouseButtons.Left)
        return;
      this.OldCoord = new Point((Size) e.Location);
      Graphics graphics = Graphics.FromImage(this.PictureBox1.Image);
      float num2 = 3f;
      object colore = this.colore;
      Color color1;
      Color color2 = colore != null ? (Color) colore : color1;
      Pen pen = new Pen(color2, num2);
      Brush brush = (Brush) new SolidBrush(color2);
      graphics.DrawLine(pen, this.OldCoord, e.Location);
      graphics.FillEllipse(brush, Conversions.ToSingle(Operators.SubtractObject(Operators.MultiplyObject(this.CordX, (object) 2), (object) (float) ((double) num2 / 2.0))), Conversions.ToSingle(Operators.SubtractObject(Operators.MultiplyObject(this.CordY, (object) 2), (object) (float) ((double) num2 / 2.0))), num2, num2);
      if (this.OldCoord != e.Location)
        this.OldCoord = e.Location;
      this.Refresh();
    }
  }

  private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
  {
    if (!Operators.ConditionalCompareObjectEqual(this.mappa, (object) 1, false))
      return;
    this.cord_mappa();
    this.Label4.Text = Conversions.ToString(this.CordX);
    this.Label5.Text = Conversions.ToString(this.CordY);
  }

  private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
  {
    if (!Operators.ConditionalCompareObjectEqual(this.File, (object) 1, false))
      return;
    if (Operators.ConditionalCompareObjectEqual(this.Inizio, (object) 1, false))
    {
      this.ListBox1.Items.Add((object) "end");
      this.Inizio = (object) 0;
    }
    if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(this.ComboBox2.SelectedItem, (object) "1 - Spots", false), Operators.CompareObjectEqual(this.ComboBox2.SelectedItem, (object) "3 - Bone King / Golden Monsters", false))))
      this.TextBox3.Enabled = true;
    else if (Operators.ConditionalCompareObjectEqual(this.ComboBox2.SelectedItem, (object) "3 - Bone King / Golden Monsters", false))
      this.TextBox3.Enabled = true;
    else
      this.TextBox3.Enabled = false;
  }

  private void Button4_Click(object sender, EventArgs e)
  {
    try
    {
      this.ListBox1.Items.RemoveAt(this.ListBox1.SelectedIndex);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ProjectData.ClearProjectError();
    }
  }

  private void Button5_Click(object sender, EventArgs e)
  {
    this.Inizio = (object) 0;
    this.ListBox1.Items.Clear();
    this.spotDescriptions.Clear();
  }

  private void Button6_Click(object sender, EventArgs e)
  {
    if (!Operators.ConditionalCompareObjectEqual(this.Inizio, (object) 1, false))
      return;
    this.ListBox1.Items.Add((object) "end");
    this.Inizio = (object) 0;
  }

  private void Form1_Load(object sender, EventArgs e)
  {
    try
    {
      this.LoadMapList();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) Interaction.MsgBox((object) "\\Maps.txt Missing", MsgBoxStyle.Critical);
      ProjectData.EndApp();
      ProjectData.ClearProjectError();
    }
    try
    {
      if (!this.TryLoadMonsterListFromXml())
        this.LoadMonsterListFromText();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) Interaction.MsgBox((object) "Monster list missing (Monster.txt or IGC_MonsterList.xml)", MsgBoxStyle.Critical);
      ProjectData.EndApp();
      ProjectData.ClearProjectError();
    }
  }

  private void LoadSpawnText(string filePath)
  {
    this.spotDescriptions.Clear();
    this.spawnMapNames.Clear();
    using (StreamReader streamReader = new StreamReader(filePath))
    {
      while (!streamReader.EndOfStream)
        this.ListBox1.Items.Add((object) streamReader.ReadLine());
    }
    this.Inizio = (object) 0;
  }

  private void LoadSpawnXml(string filePath)
  {
    this.spotDescriptions.Clear();
    this.spawnMapNames.Clear();
    MonsterSpawnDocument monsterSpawnDocument;
    XmlSerializer xmlSerializer = new XmlSerializer(typeof (MonsterSpawnDocument));
    using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
      monsterSpawnDocument = (MonsterSpawnDocument) xmlSerializer.Deserialize((Stream) fileStream);
    if (monsterSpawnDocument == null || monsterSpawnDocument.Maps == null)
      return;
    foreach (MonsterMap map in monsterSpawnDocument.Maps)
    {
      if (map.Spots == null)
        continue;
      string mapName = this.ResolveMapName(map.Number, map.Name);
      if (!string.IsNullOrEmpty(mapName))
        this.spawnMapNames[map.Number] = mapName;
      foreach (MonsterSpot spot in map.Spots)
      {
        string key = this.GetSpotDescriptionKey(map.Number, spot.Type);
        if (!string.IsNullOrEmpty(spot.Description))
          this.spotDescriptions[key] = spot.Description;
        else if (this.spotDescriptions.ContainsKey(key))
          this.spotDescriptions.Remove(key);
        this.AddSpotHeader(mapName, spot.Type, spot.Description);
        if (spot.Spawns != null)
        {
          foreach (MonsterSpawnEntry spawn in spot.Spawns)
            this.ListBox1.Items.Add((object) this.FormatSpawnLine(map, spot, spawn));
        }
        this.ListBox1.Items.Add((object) "end");
      }
    }
    this.Inizio = (object) 0;
  }

  private void SaveSpawnXml(string filePath)
  {
    MonsterSpawnDocument monsterSpawnDocument = this.BuildSpawnDocumentFromList();
    XmlSerializer xmlSerializer = new XmlSerializer(typeof (MonsterSpawnDocument));
    XmlWriterSettings settings = new XmlWriterSettings();
    settings.Indent = true;
    settings.IndentChars = "  ";
    settings.NewLineHandling = NewLineHandling.Replace;
    settings.NewLineChars = Environment.NewLine;
    using (FileStream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
    {
      using (XmlWriter xmlWriter = XmlWriter.Create((Stream) fileStream, settings))
        xmlSerializer.Serialize(xmlWriter, (object) monsterSpawnDocument);
    }
  }

  private MonsterSpawnDocument BuildSpawnDocumentFromList()
  {
    Dictionary<int, MonsterMap> dictionary = new Dictionary<int, MonsterMap>();
    int num = -1;
    string currentSpotDescription = (string) null;
    foreach (object obj in this.ListBox1.Items)
    {
      string str = Conversions.ToString(obj);
      if (!string.IsNullOrEmpty(str))
      {
        string trimmed = str.Trim();
        if (trimmed.Length != 0)
        {
          if (trimmed.StartsWith("//\t", StringComparison.Ordinal))
          {
            currentSpotDescription = ParseSpotCommentDescription(trimmed);
            continue;
          }
          if (trimmed.StartsWith("//", StringComparison.Ordinal))
            continue;
          if (string.Equals(trimmed, "end", StringComparison.OrdinalIgnoreCase))
          {
            num = -1;
            currentSpotDescription = (string) null;
            continue;
          }
          int result;
          if (int.TryParse(trimmed, NumberStyles.Integer, CultureInfo.InvariantCulture, out result) && trimmed.IndexOf('\t') < 0)
          {
            num = result;
            continue;
          }
          if (num == -1)
            continue;
          string[] strArray = str.Split('\t');
          if (num == 1 || num == 3)
          {
            if (strArray.Length < 9)
              continue;
          }
          else if (strArray.Length < 6)
            continue;
          int? nullable1 = this.ParseNullableInt(strArray[0]);
          int? nullable2 = this.ParseNullableInt(strArray[1]);
          int? nullable3 = this.ParseNullableInt(strArray[2]);
          int? nullable4 = this.ParseNullableInt(strArray[3]);
          int? nullable5 = this.ParseNullableInt(strArray[4]);
          if (!nullable1.HasValue || !nullable2.HasValue || (!nullable3.HasValue || !nullable4.HasValue) || !nullable5.HasValue)
            continue;
          string spotKey = this.GetSpotDescriptionKey(nullable2.Value, num);
          if (!string.IsNullOrEmpty(currentSpotDescription))
          {
            this.spotDescriptions[spotKey] = currentSpotDescription;
            currentSpotDescription = (string) null;
          }
          else if (currentSpotDescription != null)
          {
            if (this.spotDescriptions.ContainsKey(spotKey))
              this.spotDescriptions.Remove(spotKey);
            currentSpotDescription = (string) null;
          }
          MonsterMap map = this.GetOrCreateMap(dictionary, nullable2.Value);
          MonsterSpot spot = this.GetOrCreateSpot(map, num);
          MonsterSpawnEntry monsterSpawnEntry = new MonsterSpawnEntry();
          monsterSpawnEntry.Index = nullable1.Value;
          monsterSpawnEntry.Distance = nullable3.Value;
          monsterSpawnEntry.StartX = nullable4.Value;
          monsterSpawnEntry.StartY = nullable5.Value;
          if (num == 1 || num == 3)
          {
            monsterSpawnEntry.EndX = this.ParseNullableInt(strArray[5]);
            if (!monsterSpawnEntry.EndX.HasValue)
              monsterSpawnEntry.EndX = new int?(monsterSpawnEntry.StartX);
            monsterSpawnEntry.EndY = this.ParseNullableInt(strArray[6]);
            if (!monsterSpawnEntry.EndY.HasValue)
              monsterSpawnEntry.EndY = new int?(monsterSpawnEntry.StartY);
            monsterSpawnEntry.Direction = this.ParseNullableInt(strArray[7]).GetValueOrDefault();
            monsterSpawnEntry.Count = this.ParseNullableInt(strArray[8]);
            if (num == 3)
              monsterSpawnEntry.Element = strArray.Length > 9 ? this.ParseNullableInt(strArray[9]) : new int?();
          }
          else
            monsterSpawnEntry.Direction = this.ParseNullableInt(strArray[5]).GetValueOrDefault();
          spot.Spawns.Add(monsterSpawnEntry);
        }
      }
    }
    MonsterSpawnDocument monsterSpawnDocument = new MonsterSpawnDocument();
    monsterSpawnDocument.Maps = dictionary.Values.OrderBy<MonsterMap, int>((Func<MonsterMap, int>) (m => m.Number)).ToList<MonsterMap>();
    foreach (MonsterMap map in monsterSpawnDocument.Maps)
      map.Spots = map.Spots.OrderBy<MonsterSpot, int>((Func<MonsterSpot, int>) (s => s.Type)).ToList<MonsterSpot>();
    return monsterSpawnDocument;
  }

  private MonsterMap GetOrCreateMap(Dictionary<int, MonsterMap> maps, int mapNumber)
  {
    MonsterMap monsterMap;
    if (!maps.TryGetValue(mapNumber, out monsterMap))
    {
      monsterMap = new MonsterMap();
      monsterMap.Number = mapNumber;
      monsterMap.Name = this.ResolveMapName(mapNumber, this.GetSpawnMapName(mapNumber));
      if (monsterMap.Spots == null)
        monsterMap.Spots = new List<MonsterSpot>();
      maps.Add(mapNumber, monsterMap);
    }
    else if (monsterMap.Spots == null)
      monsterMap.Spots = new List<MonsterSpot>();
    return monsterMap;
  }

  private MonsterSpot GetOrCreateSpot(MonsterMap map, int type)
  {
    if (map.Spots == null)
      map.Spots = new List<MonsterSpot>();
    MonsterSpot monsterSpot = map.Spots.FirstOrDefault<MonsterSpot>((Func<MonsterSpot, bool>) (s => s.Type == type));
    if (monsterSpot == null)
    {
      monsterSpot = new MonsterSpot();
      monsterSpot.Type = type;
      monsterSpot.Description = this.ResolveSpotDescription(map.Number, type);
      map.Spots.Add(monsterSpot);
    }
    return monsterSpot;
  }

  private string ResolveSpotDescription(int mapNumber, int type)
  {
    string str;
    if (this.spotDescriptions.TryGetValue(this.GetSpotDescriptionKey(mapNumber, type), out str) && !string.IsNullOrEmpty(str))
      return str;
    return GetSpotDescription(type);
  }

  private string GetSpawnMapName(int mapNumber)
  {
    string str;
    if (this.spawnMapNames.TryGetValue(mapNumber, out str) && !string.IsNullOrEmpty(str))
      return str;
    return string.Empty;
  }

  private string GetSpotDescriptionKey(int mapNumber, int type)
  {
    return mapNumber.ToString((IFormatProvider) CultureInfo.InvariantCulture) + ":" + type.ToString((IFormatProvider) CultureInfo.InvariantCulture);
  }

  private void AddSpotHeader(string mapName, int type, string description)
  {
    string str = string.IsNullOrEmpty(description) ? GetSpotDescription(type) : description;
    this.ListBox1.Items.Add((object) SectionSeparator);
    this.ListBox1.Items.Add((object) ("//\t" + mapName + " " + str));
    this.ListBox1.Items.Add((object) SectionSeparator);
    this.ListBox1.Items.Add((object) GetSpotHeader(type));
    this.ListBox1.Items.Add((object) type.ToString((IFormatProvider) CultureInfo.InvariantCulture));
  }

  private static string GetSpotDescription(int type)
  {
    switch (type)
    {
      case 0:
        return "Guards / NPC / Traps";
      case 1:
        return "Spots";
      case 2:
        return "Monster";
      case 3:
        return "Golden Monster";
      case 4:
        return "Blood Castle Monsters / Gate";
      default:
        return "Spot";
    }
  }

  private static string GetSpotHeader(int type)
  {
    if (type == 1)
      return "//Mob\tMap\tRadio\tCordX\tCordY\tCordX2\tCordY2\tDir \tQuant  Name";
    if (type == 3)
      return "//Mob\tMap\tRadio\tCordX\tCordY\tCordX2\tCordY2\tDir \tQuant\tElement\tName";
    return "//Mob\tMap\tRad\tX\tY\tStr\tName";
  }

  private string FormatSpawnLine(MonsterMap map, MonsterSpot spot, MonsterSpawnEntry spawn)
  {
    string monsterName = this.GetMonsterName(spawn.Index);
    if (spot.Type == 1 || spot.Type == 3)
    {
      int num1 = spawn.EndX.HasValue ? spawn.EndX.Value : spawn.StartX;
      int num2 = spawn.EndY.HasValue ? spawn.EndY.Value : spawn.StartY;
      int num3 = spawn.Count.HasValue ? spawn.Count.Value : 0;
      if (spot.Type == 3)
      {
        string element = spawn.Element.HasValue ? spawn.Element.Value.ToString((IFormatProvider) CultureInfo.InvariantCulture) : string.Empty;
        return string.Format((IFormatProvider) CultureInfo.InvariantCulture, "{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}\t{8}\t{9}\t// {10}", (object) spawn.Index, (object) map.Number, (object) spawn.Distance, (object) spawn.StartX, (object) spawn.StartY, (object) num1, (object) num2, (object) spawn.Direction, (object) num3, (object) element, (object) monsterName);
      }
      return string.Format((IFormatProvider) CultureInfo.InvariantCulture, "{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}\t{8}\t// {9}", (object) spawn.Index, (object) map.Number, (object) spawn.Distance, (object) spawn.StartX, (object) spawn.StartY, (object) num1, (object) num2, (object) spawn.Direction, (object) num3, (object) monsterName);
    }
    return string.Format((IFormatProvider) CultureInfo.InvariantCulture, "{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t// {6}", (object) spawn.Index, (object) map.Number, (object) spawn.Distance, (object) spawn.StartX, (object) spawn.StartY, (object) spawn.Direction, (object) monsterName);
  }

  private static string ParseSpotCommentDescription(string line)
  {
    if (string.IsNullOrEmpty(line))
      return (string) null;
    string str = line.Substring(3).Trim();
    if (str.Length == 0)
      return string.Empty;
    int num = str.IndexOf(' ');
    if (num < 0)
      return string.Empty;
    return str.Substring(num + 1).Trim();
  }

  private string GetMonsterName(int index)
  {
    string str;
    if (this.monsterNames.TryGetValue(index, out str))
      return str;
    return "Monster " + index.ToString((IFormatProvider) CultureInfo.InvariantCulture);
  }

  private string ResolveMapName(int mapNumber, string fallbackName)
  {
    string str;
    if (this.mapNames.TryGetValue(mapNumber, out str))
      return str;
    string spawnMapName = this.GetSpawnMapName(mapNumber);
    if (!string.IsNullOrEmpty(spawnMapName))
      return spawnMapName;
    if (!string.IsNullOrEmpty(fallbackName))
      return fallbackName;
    return mapNumber.ToString((IFormatProvider) CultureInfo.InvariantCulture);
  }

  private static string StripComment(string value)
  {
    if (value == null)
      return string.Empty;
    int length = value.IndexOf("//", StringComparison.Ordinal);
    if (length >= 0)
      value = value.Substring(0, length);
    return value.Trim();
  }

  private int? ParseNullableInt(string value)
  {
    string s = StripComment(value);
    if (s.Length == 0)
      return new int?();
    int result;
    return int.TryParse(s, NumberStyles.Integer, CultureInfo.InvariantCulture, out result) ? new int?(result) : new int?();
  }

  private void LoadMapList()
  {
    this.ComboBox1.Items.Clear();
    this.mapNames.Clear();
    string path = Path.Combine(this.CurrDir, "Maps.txt");
    using (StreamReader streamReader = new StreamReader(path))
    {
      while (!streamReader.EndOfStream)
      {
        string str = streamReader.ReadLine();
        if (!string.IsNullOrEmpty(str))
        {
          this.ComboBox1.Items.Add((object) str);
          string[] strArray = str.Split(new char[2]{ ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
          int result;
          if (strArray.Length >= 2 && int.TryParse(strArray[0], NumberStyles.Integer, CultureInfo.InvariantCulture, out result))
            this.mapNames[result] = string.Join(" ", strArray.Skip(1).ToArray());
        }
      }
    }
  }

  private bool TryLoadMonsterListFromXml()
  {
    string[] strArray = new string[2]
    {
      Path.Combine(this.CurrDir, "IGC_MonsterList.xml"),
      Path.Combine(this.CurrDir, "IGC_Monster.xml")
    };
    foreach (string path in strArray)
    {
      if (File.Exists(path))
      {
        try
        {
          XmlSerializer xmlSerializer = new XmlSerializer(typeof (MonsterDefinitionList));
          using (FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read))
          {
            MonsterDefinitionList definitionList = (MonsterDefinitionList) xmlSerializer.Deserialize((Stream) fileStream);
            this.ApplyMonsterDefinitions(definitionList);
            return true;
          }
        }
        catch (InvalidOperationException)
        {
        }
      }
    }
    return false;
  }

  private void LoadMonsterListFromText()
  {
    string path = Path.Combine(this.CurrDir, "Monster.txt");
    this.ListBox2.Items.Clear();
    this.monsterNames.Clear();
    using (StreamReader streamReader = new StreamReader(path))
    {
      while (!streamReader.EndOfStream)
      {
        string str = streamReader.ReadLine();
        if (!string.IsNullOrEmpty(str))
        {
          this.ListBox2.Items.Add((object) str);
          string[] strArray = str.Split(new char[2]{ ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
          int result;
          if (strArray.Length >= 2 && int.TryParse(strArray[0], NumberStyles.Integer, CultureInfo.InvariantCulture, out result))
            this.monsterNames[result] = string.Join(" ", strArray.Skip(1).ToArray());
        }
      }
    }
  }

  private void ApplyMonsterDefinitions(MonsterDefinitionList definitions)
  {
    this.ListBox2.Items.Clear();
    this.monsterNames.Clear();
    if (definitions == null || definitions.Monsters == null)
      return;
    foreach (MonsterDefinition monster in definitions.Monsters.OrderBy<MonsterDefinition, int>((Func<MonsterDefinition, int>) (m => m.Index)))
    {
      string str = monster.Index.ToString((IFormatProvider) CultureInfo.InvariantCulture) + " " + monster.Name;
      this.ListBox2.Items.Add((object) str);
      this.monsterNames[monster.Index] = monster.Name;
    }
  }

  public void punti()
  {
    int num1 = checked (this.ListBox1.Items.Count - 1);
    int index = 0;
    while (index <= num1)
    {
      try
      {
        string str = this.ListBox1.Items[index].ToString();
        if (!Operators.ConditionalCompareObjectEqual((object) str.Substring(0, 1), (object) "/", false))
        {
          string[] strArray = str.Split('\t');
          if (Operators.ConditionalCompareObjectEqual((object) strArray[1], this.MapNumber, false))
          {
            Graphics graphics = Graphics.FromImage(this.PictureBox1.Image);
            float num2 = 3f;
            Color aqua = Color.Aqua;
            Pen pen = new Pen(aqua, num2);
            Brush brush = (Brush) new SolidBrush(aqua);
            object obj1 = (object) (Conversions.ToDouble(strArray[3]) * 2.0);
            object obj2 = (object) (Conversions.ToDouble(strArray[4]) * 2.0);
            graphics.FillEllipse(brush, Conversions.ToSingle(obj1), Conversions.ToSingle(obj2), num2, num2);
          }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      checked { ++index; }
    }
    this.Refresh();
  }

  public void cord_mappa()
  {
    this.LocalMousePosition = (object) this.PictureBox1.PointToClient(Cursor.Position);
    this.CordX = Operators.DivideObject(NewLateBinding.LateGet(this.LocalMousePosition, (System.Type) null, "X", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) 2);
    this.CordY = Operators.DivideObject(NewLateBinding.LateGet(this.LocalMousePosition, (System.Type) null, "Y", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) 2);
    System.Type Type1 = typeof (Math);
    object[] objArray1 = new object[2]
    {
      RuntimeHelpers.GetObjectValue(this.CordX),
      (object) MidpointRounding.AwayFromZero
    };
    object[] Arguments1 = objArray1;
    bool[] flagArray1 = new bool[2]{ true, false };
    bool[] CopyBack1 = flagArray1;
    object obj1 = NewLateBinding.LateGet((object) null, Type1, "Round", Arguments1, (string[]) null, (System.Type[]) null, CopyBack1);
    if (flagArray1[0])
      this.CordX = RuntimeHelpers.GetObjectValue(objArray1[0]);
    this.CordX = RuntimeHelpers.GetObjectValue(obj1);
    System.Type Type2 = typeof (Math);
    object[] objArray2 = new object[2]
    {
      RuntimeHelpers.GetObjectValue(this.CordY),
      (object) MidpointRounding.AwayFromZero
    };
    object[] Arguments2 = objArray2;
    bool[] flagArray2 = new bool[2]{ true, false };
    bool[] CopyBack2 = flagArray2;
    object obj2 = NewLateBinding.LateGet((object) null, Type2, "Round", Arguments2, (string[]) null, (System.Type[]) null, CopyBack2);
    if (flagArray2[0])
      this.CordY = RuntimeHelpers.GetObjectValue(objArray2[0]);
    this.CordY = RuntimeHelpers.GetObjectValue(obj2);
  }

  private void Button2_Click(object sender, EventArgs e) => this.punti();

  private void Timer1_Tick(object sender, EventArgs e)
  {
    this.punti();
    this.Timer1.Enabled = false;
  }

  private void RadioButton1_CheckedChanged(object sender, EventArgs e) => this.Label17.Text = "1";

  private void RadioButton2_CheckedChanged(object sender, EventArgs e) => this.Label17.Text = "2";

  private void RadioButton3_CheckedChanged(object sender, EventArgs e) => this.Label17.Text = "3";

  private void RadioButton4_CheckedChanged(object sender, EventArgs e) => this.Label17.Text = "4";

  private void RadioButton5_CheckedChanged(object sender, EventArgs e) => this.Label17.Text = "5";

  private void RadioButton6_CheckedChanged(object sender, EventArgs e) => this.Label17.Text = "6";

  private void RadioButton7_CheckedChanged(object sender, EventArgs e) => this.Label17.Text = "7";

  private void RadioButton8_CheckedChanged(object sender, EventArgs e) => this.Label17.Text = "8";

  private void RadioButton9_CheckedChanged(object sender, EventArgs e) => this.Label17.Text = "-1";
}
