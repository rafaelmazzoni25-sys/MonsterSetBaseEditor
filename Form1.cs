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

namespace MonasterSetBase
{

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
  private object fileLoaded;
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
  private readonly List<string> spawnXmlHeaderComments = new List<string>();
  private static readonly string[] KnownMapAttributes = new string[2]{ "Number", "Name" };
  private static readonly string[] KnownSpotAttributes = new string[2]{ "Type", "Description" };
  private static readonly string[] KnownSpawnAttributes = new string[9]
  {
    "Index",
    "Distance",
    "StartX",
    "StartY",
    "Dir",
    "EndX",
    "EndY",
    "Count",
    "Element"
  };
  private static readonly string DefaultSpawnHeaderComment = @"  
// ============================================================
// == INTERNATIONAL GAMING CENTER NETWORK
// == www.igc-network.com
// == (C) 2010-2015 IGC-Network (R)
// ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
// == File is a part of IGCN Group MuOnline Server files.
// ============================================================
//
// ### MonsterSpawn::Map ###
//Number: Number of map to spawn the monster on, refer to IGC_MapList.xml
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//~~ Same map index can be defined only one in file
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Name: Name of a map, used for in-file description and logging purpose
//
// ### MonsterSpawn::Map::Spot ###
//Type: Type of spot:
//~ 0: NPC/Traps
//~ 1: Multiple Monsters Spawn
//~ 2: Single Monster Spawn
//~ 3: Elemental Monster Spawn
//Description: Spot description, used for in-file description and logging purpose
//
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//~~ Spot attributes description
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Index: Index of monster or NPC to spawn, refer to IGC_MonsterList.xml ~ (Spot Type: 0-3)
//Distance: Distance to spawn the monsters/NPC from original location ~ (Spot Type: 0-3)
//StartX: StartX Coordinate of monster spawn ~ (Spot Type: 0-3)
//StartY: StartY Coordinate of monster spawn ~ (Spot Type: 1, 3)
//EndX: End X Coordinate of monster spawn ~ (Spot Type: 0-3)
//EndY: End Y Coordinate of monster spawn ~ (Spot Type: 1, 3)
//Dir: Direction the monster/NPC looks at after spawn ~ (Spot Type: 0-3)
//~ 0: Central
//~ 1: South-West
//~ 2: South
//~ 3: South-East
//~ 4: East
//~ 5: North-East
//~ 6: North
//~ 7: North-West
//~ 8: West
//~ -1: Random
//Count:  Count of monsters to spawn ~ (Spot Type: 1, 3)
//Element:  Element type to spawn the monster with ~ (Spot Type: 3)
//~ 0: No Elemental attribute
//~ 1: Fire
//~ 2: Water
//~ 3: Earth
//~ 4: Wind
//~ 5: Darkness
//~ 6: Random
//
//~~ IMPORTANT EXCLUSIONS ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Map Number: 5 (Exile) - does not exist by default in newer game versions
//Map Number: 9, 32 for Devil Square (1-4 and 5-7) Event are managed from: IGC_DevilSquare_Classic_Monsters.xml file
//Map Number: 11, 12, 13, 14, 15, 16, 17, 52 for Blood Castle Event (1-8) are managed from: IGC_BloodCastle_Monster.xml file
//Map Number: 18, 19, 20, 21, 22, 23, 53 for Chaos Castle Event (1-7) are managed from: IGC_ChaosCastle_Monster.xml file
//Map Number: 45, 46, 47, 48, 49, 50 for Illusion Temple Renewal Event (1-6) are managed from: IGC_IllusionTemple_Renewal_NPC.xml file
//Map Number: 58 for Raklion Hatcher Event is managed from: IGC_RaklionHatchery_Monsters.xml
//Map Number: 65 (Snow), 66 (Volcan), 67 (Sea), 68 (Crystals) for Doppel Ganger Event are managed from: IGC_DoppelGanger_PositionInfo.xml file
//Map Number: 69, 70, 71 for Imperial Guardian Event are managed from: IGC_ImperialGuardian_Monster_Spawn.xml file
//Map Number: 96 for Arca Battle (Debenter) Event are managed from: IGC_ArcaBattle.xml file
//Map Number: 97 for Chaos Castle Survival is managed from: IGC_ChaosCastle_Survival_Monster.xml file
//Map Number: 98, 99 for Illusion Temple  League (disabled) Event are managed from: IGC_IllusionTemple_League_NPC.xml file
//Map Number: 101 (Uruk Mountain) is event map, do not add monsters directly on it. Number of regular Uruk Mountain map to add monsters from this file is 100
//Map Number: 102 (Tormented Square) Event is managed from: IGC_TormentedSquare_Monsters.xml file
//Mining Areas are managed from: IGC_MiningSystem.xml file
//Golden Monsters (index: 53-54, 79-83, 493-502) spawn is controlled from: IGC_GoldenInvasion.xml file
//Dragon Event (index: 44) spawn is controlled from IGC_DragonEvent.xml
//Attack Event (index: 53-56) spawn is controlled from IGC_AttackEvent.xml
//Shop NPC spawn is managed from IGC_ShopList.xml file
//Last Man Standing Event NPC spawn is managed from IGC_LastManStanding.xml
//Additional event spawn can be managed from: IGC_MonsterSpawn_Event.xml file
//
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//
// STRICTLY NO COMMENTS INSIDE TAGS
 ";
  private const string SpawnSpacerComment = "  ";

  public Form1()
  {
    this.Load += new EventHandler(this.Form1_Load);
    this.CurrDir = Environment.CurrentDirectory;
    this.InitializeComponent();
    this.ResetSpawnHeaderComments();
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
    string fileName = this.OpenFileDialog1.FileName;
    EditorLogger.LogInfo("Opening spawn file '" + fileName + "'.");
    try
    {
      string extension = Path.GetExtension(fileName);
      if (string.Equals(extension, ".xml", StringComparison.OrdinalIgnoreCase))
        this.LoadSpawnXmlFile(fileName);
      else
        this.LoadSpawnTextFile(fileName);
      EditorLogger.LogInfo("Spawn file '" + fileName + "' loaded successfully.");
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      EditorLogger.LogError("Failed to load spawn file '" + fileName + "'.", ex);
      int num = (int) Interaction.MsgBox((object) "Failed to load monster spawn file", MsgBoxStyle.Critical);
      ProjectData.ClearProjectError();
      this.ListBox1.Items.Clear();
      return;
    }
    this.TextBox1.Text = this.OpenFileDialog1.FileName;
    this.fileLoaded = (object) 1;
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
    string fileName = this.SaveFileDialog1.FileName;
    EditorLogger.LogInfo("Saving spawn file '" + fileName + "'.");
    try
    {
      if (Operators.ConditionalCompareObjectEqual(this.Inizio, (object) 1, false))
      {
        this.ListBox1.Items.Add((object) "end");
        this.Inizio = (object) 0;
      }
      string extension = Path.GetExtension(fileName);
      if (string.Equals(extension, ".xml", StringComparison.OrdinalIgnoreCase))
      {
        this.SaveSpawnXmlFile(fileName);
      }
      else
      {
        using (StreamWriter streamWriter = new StreamWriter(fileName))
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
      EditorLogger.LogInfo("Spawn file '" + fileName + "' saved successfully.");
      int num2 = (int) Interaction.MsgBox((object) "File saved with success", MsgBoxStyle.Information);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      EditorLogger.LogError("Failed to save spawn file '" + fileName + "'.", ex);
      int num3 = (int) Interaction.MsgBox((object) "Failed to save monster spawn file", MsgBoxStyle.Critical);
      ProjectData.ClearProjectError();
    }
  }

  private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
  {
    if (!Operators.ConditionalCompareObjectEqual(this.fileLoaded, (object) 1, false))
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
    Color color = Color.Black;
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
      Color color1 = Color.Black;
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
    if (!Operators.ConditionalCompareObjectEqual(this.fileLoaded, (object) 1, false))
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
      EditorLogger.LogError("Failed to remove spawn entry at index " + Conversions.ToString(this.ListBox1.SelectedIndex) + ".", ex);
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
      this.LoadMapListEntries();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      EditorLogger.LogError("Failed while loading map list entries.", ex);
      int num = (int) Interaction.MsgBox((object) "\\Maps.txt Missing", MsgBoxStyle.Critical);
      ProjectData.EndApp();
      ProjectData.ClearProjectError();
    }
    try
    {
      if (!this.TryLoadMonsterListXml())
        this.LoadMonsterListText();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      EditorLogger.LogError("Failed to load monster definitions from XML or text files.", ex);
      int num = (int) Interaction.MsgBox((object) "Monster list missing (Monster.txt or IGC_MonsterList.xml)", MsgBoxStyle.Critical);
      ProjectData.EndApp();
      ProjectData.ClearProjectError();
    }
  }

  private void LoadSpawnTextFile(string filePath)
  {
    this.spotDescriptions.Clear();
    this.spawnMapNames.Clear();
    this.ResetSpawnHeaderComments();
    int num = 0;
    using (StreamReader streamReader = new StreamReader(filePath))
    {
      while (!streamReader.EndOfStream)
      {
        this.ListBox1.Items.Add((object) streamReader.ReadLine());
        checked { ++num; }
      }
    }
    this.Inizio = (object) 0;
    EditorLogger.LogInfo("Loaded spawn TXT file '" + filePath + "' with " + Conversions.ToString(num) + " line(s).");
  }

  private void LoadSpawnXmlFile(string filePath)
  {
    this.spotDescriptions.Clear();
    this.spawnMapNames.Clear();
    this.spawnXmlHeaderComments.Clear();
    EditorLogger.LogInfo("Loading spawn XML file '" + filePath + "'.");
    int skippedMaps;
    int skippedSpots;
    int skippedSpawns;
    XmlDocument xmlDocument;
    MonsterSpawnDocument monsterSpawnDocument = this.ParseSpawnXmlDocument(filePath, out skippedMaps, out skippedSpots, out skippedSpawns, out xmlDocument);
    this.CaptureSpawnXmlHeaderComments(xmlDocument);
    if (monsterSpawnDocument == null || monsterSpawnDocument.Maps == null)
    {
      EditorLogger.LogWarning("Spawn XML file '" + filePath + "' contains no maps.");
      return;
    }
    int mapCount = 0;
    int spotCount = 0;
    int spawnCount = 0;
    foreach (MonsterMap map in monsterSpawnDocument.Maps)
    {
      if (map.Spots == null)
        continue;
      checked { ++mapCount; }
      string mapName = this.ResolveMapDisplayName(map.Number, map.Name);
      if (!string.IsNullOrEmpty(mapName))
      {
        string originalMapName = !string.IsNullOrEmpty(map.Name) ? map.Name : mapName;
        this.spawnMapNames[map.Number] = originalMapName;
      }
      foreach (MonsterSpot spot in map.Spots)
      {
        checked { ++spotCount; }
        string key = this.BuildSpotDescriptionKey(map.Number, spot.Type);
        if (!string.IsNullOrEmpty(spot.Description))
          this.spotDescriptions[key] = spot.Description;
        else if (this.spotDescriptions.ContainsKey(key))
          this.spotDescriptions.Remove(key);
        this.AddSpotHeaderLines(mapName, spot.Type, spot.Description);
        if (spot.Spawns != null)
        {
          foreach (MonsterSpawnEntry spawn in spot.Spawns)
          {
            this.ListBox1.Items.Add((object) this.FormatSpawnListEntry(map, spot, spawn));
            checked { ++spawnCount; }
          }
        }
        this.ListBox1.Items.Add((object) "end");
      }
    }
    this.Inizio = (object) 0;
    EditorLogger.LogInfo("Loaded spawn XML file '" + filePath + "' with " + Conversions.ToString(mapCount) + " map(s), " + Conversions.ToString(spotCount) + " spot(s) and " + Conversions.ToString(spawnCount) + " spawn row(s).");
    if (skippedMaps > 0 || skippedSpots > 0 || skippedSpawns > 0)
      EditorLogger.LogWarning("While loading '" + filePath + "' skipped " + Conversions.ToString(skippedMaps) + " map(s), " + Conversions.ToString(skippedSpots) + " spot(s) and " + Conversions.ToString(skippedSpawns) + " spawn row(s) due to invalid or incomplete data.");
  }

  private void ResetSpawnHeaderComments()
  {
    this.spawnXmlHeaderComments.Clear();
    this.spawnXmlHeaderComments.Add(DefaultSpawnHeaderComment);
  }

  private void CaptureSpawnXmlHeaderComments(XmlDocument xmlDocument)
  {
    this.spawnXmlHeaderComments.Clear();
    if (xmlDocument != null)
    {
      foreach (XmlNode childNode in xmlDocument.ChildNodes)
      {
        if (childNode == null)
          continue;
        if (childNode.NodeType == XmlNodeType.Comment)
        {
          this.spawnXmlHeaderComments.Add(childNode.Value ?? string.Empty);
        }
        else if (childNode.NodeType == XmlNodeType.Element)
          break;
      }
    }
    if (this.spawnXmlHeaderComments.Count == 0)
      this.spawnXmlHeaderComments.Add(DefaultSpawnHeaderComment);
  }

  private MonsterSpawnDocument ParseSpawnXmlDocument(string filePath, out int skippedMaps, out int skippedSpots, out int skippedSpawns, out XmlDocument originalDocument)
  {
    skippedMaps = 0;
    skippedSpots = 0;
    skippedSpawns = 0;
    XmlDocument xmlDocument = new XmlDocument();
    XmlReaderSettings settings = new XmlReaderSettings();
    settings.IgnoreComments = false;
    settings.IgnoreWhitespace = true;
    using (FileStream input = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read))
    {
      using (XmlReader reader = XmlReader.Create((Stream) input, settings))
        xmlDocument.Load(reader);
    }
    originalDocument = xmlDocument;
    XmlElement documentElement = xmlDocument.DocumentElement;
    if (documentElement == null || !string.Equals(documentElement.Name, "MonsterSpawn", StringComparison.Ordinal))
    {
      EditorLogger.LogError("Spawn XML file '" + filePath + "' has unexpected root node '" + (documentElement != null ? documentElement.Name : (string) null) + "'.", (Exception) null);
      throw new InvalidOperationException("Invalid MonsterSpawn XML root element.");
    }
    MonsterSpawnDocument monsterSpawnDocument = new MonsterSpawnDocument();
    foreach (XmlNode childNode in documentElement.ChildNodes)
    {
      XmlElement mapElement = childNode as XmlElement;
      if (mapElement == null || !string.Equals(mapElement.Name, "Map", StringComparison.Ordinal))
        continue;
      int mapNumber;
      if (!TryParseIntAttribute(mapElement, "Number", out mapNumber))
      {
        EditorLogger.LogWarning("Skipping map entry with invalid or missing Number attribute ('" + mapElement.GetAttribute("Number") + "') in '" + filePath + "'.");
        checked { ++skippedMaps; }
        continue;
      }
      MonsterMap monsterMap = new MonsterMap();
      monsterMap.Number = mapNumber;
      monsterMap.Name = GetAttributeValue(mapElement, "Name");
      if (monsterMap.ExtraAttributes == null)
        monsterMap.ExtraAttributes = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
      CaptureExtraAttributes(mapElement, monsterMap.ExtraAttributes, KnownMapAttributes);
      foreach (XmlNode childNode2 in mapElement.ChildNodes)
      {
        XmlElement spotElement = childNode2 as XmlElement;
        if (spotElement == null || !string.Equals(spotElement.Name, "Spot", StringComparison.Ordinal))
          continue;
        int type;
        if (!TryParseIntAttribute(spotElement, "Type", out type))
        {
          EditorLogger.LogWarning("Skipping spot entry on map " + Conversions.ToString(mapNumber) + " because Type attribute is missing or invalid ('" + spotElement.GetAttribute("Type") + "').");
          checked { ++skippedSpots; }
          continue;
        }
        MonsterSpot monsterSpot = new MonsterSpot();
        monsterSpot.Type = type;
        monsterSpot.Description = GetAttributeValue(spotElement, "Description");
        if (monsterSpot.ExtraAttributes == null)
          monsterSpot.ExtraAttributes = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        CaptureExtraAttributes(spotElement, monsterSpot.ExtraAttributes, KnownSpotAttributes);
        foreach (XmlNode childNode3 in spotElement.ChildNodes)
        {
          XmlElement spawnElement = childNode3 as XmlElement;
          if (spawnElement == null || !string.Equals(spawnElement.Name, "Spawn", StringComparison.Ordinal))
            continue;
          MonsterSpawnEntry monsterSpawnEntry = this.ParseSpawnEntry(spawnElement, mapNumber, type);
          if (monsterSpawnEntry != null)
            monsterSpot.Spawns.Add(monsterSpawnEntry);
          else
            checked { ++skippedSpawns; }
        }
        monsterMap.Spots.Add(monsterSpot);
      }
      monsterSpawnDocument.Maps.Add(monsterMap);
    }
    return monsterSpawnDocument;
  }

  private static string GetAttributeValue(XmlElement element, string attributeName)
  {
    if (element == null || attributeName == null)
      return string.Empty;
    string attribute = element.GetAttribute(attributeName);
    if (attribute == null)
      return string.Empty;
    return attribute;
  }

  private MonsterSpawnEntry ParseSpawnEntry(XmlElement spawnElement, int mapNumber, int spotType)
  {
    if (spawnElement == null)
      return (MonsterSpawnEntry) null;
    int index;
    if (!this.TryParseRequiredIntAttribute(spawnElement, "Index", mapNumber, spotType, out index))
      return (MonsterSpawnEntry) null;
    int distance;
    if (!this.TryParseRequiredIntAttribute(spawnElement, "Distance", mapNumber, spotType, out distance))
      return (MonsterSpawnEntry) null;
    int startX;
    if (!this.TryParseRequiredIntAttribute(spawnElement, "StartX", mapNumber, spotType, out startX))
      return (MonsterSpawnEntry) null;
    int startY;
    if (!this.TryParseRequiredIntAttribute(spawnElement, "StartY", mapNumber, spotType, out startY))
      return (MonsterSpawnEntry) null;
    int direction;
    if (!this.TryParseRequiredIntAttribute(spawnElement, "Dir", mapNumber, spotType, out direction))
      return (MonsterSpawnEntry) null;
    MonsterSpawnEntry monsterSpawnEntry = new MonsterSpawnEntry();
    monsterSpawnEntry.Index = index;
    monsterSpawnEntry.Distance = distance;
    monsterSpawnEntry.StartX = startX;
    monsterSpawnEntry.StartY = startY;
    monsterSpawnEntry.Direction = direction;
    monsterSpawnEntry.EndX = this.TryParseOptionalIntAttribute(spawnElement, "EndX", mapNumber, spotType);
    monsterSpawnEntry.EndY = this.TryParseOptionalIntAttribute(spawnElement, "EndY", mapNumber, spotType);
    monsterSpawnEntry.Count = this.TryParseOptionalIntAttribute(spawnElement, "Count", mapNumber, spotType);
    monsterSpawnEntry.Element = this.TryParseOptionalIntAttribute(spawnElement, "Element", mapNumber, spotType);
    if (monsterSpawnEntry.ExtraAttributes == null)
      monsterSpawnEntry.ExtraAttributes = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
    CaptureExtraAttributes(spawnElement, monsterSpawnEntry.ExtraAttributes, KnownSpawnAttributes);
    return monsterSpawnEntry;
  }

  private static void CaptureExtraAttributes(XmlElement element, Dictionary<string, string> target, string[] knownAttributes)
  {
    if (element == null || target == null)
      return;
    foreach (XmlAttribute xmlAttribute in element.Attributes)
    {
      if (xmlAttribute != null && !string.IsNullOrEmpty(xmlAttribute.Name) && !IsKnownAttribute(xmlAttribute.Name, knownAttributes))
        target[xmlAttribute.Name] = xmlAttribute.Value;
    }
  }

  private static bool IsKnownAttribute(string attributeName, string[] knownAttributes)
  {
    if (string.IsNullOrEmpty(attributeName) || knownAttributes == null)
      return false;
    foreach (string str in knownAttributes)
    {
      if (string.Equals(attributeName, str, StringComparison.OrdinalIgnoreCase))
        return true;
    }
    return false;
  }

  private static bool TryParseIntAttribute(XmlElement element, string attributeName, out int value)
  {
    value = 0;
    if (element == null || attributeName == null)
      return false;
    string attribute = element.GetAttribute(attributeName);
    if (string.IsNullOrEmpty(attribute))
      return false;
    return int.TryParse(attribute, NumberStyles.Integer, (IFormatProvider) CultureInfo.InvariantCulture, out value);
  }

  private bool TryParseRequiredIntAttribute(XmlElement element, string attributeName, int mapNumber, int spotType, out int value)
  {
    value = 0;
    if (element == null)
      return false;
    string attribute = element.GetAttribute(attributeName);
    if (string.IsNullOrEmpty(attribute))
    {
      EditorLogger.LogWarning("Spawn entry missing attribute '" + attributeName + "' on map " + Conversions.ToString(mapNumber) + " spot type " + Conversions.ToString(spotType) + ".");
      return false;
    }
    if (!int.TryParse(attribute, NumberStyles.Integer, (IFormatProvider) CultureInfo.InvariantCulture, out value))
    {
      EditorLogger.LogWarning("Spawn entry has invalid integer value '" + attribute + "' for attribute '" + attributeName + "' on map " + Conversions.ToString(mapNumber) + " spot type " + Conversions.ToString(spotType) + ".");
      return false;
    }
    return true;
  }

  private int? TryParseOptionalIntAttribute(XmlElement element, string attributeName, int mapNumber, int spotType)
  {
    if (element == null)
      return new int?();
    if (!element.HasAttribute(attributeName))
      return new int?();
    string attribute = element.GetAttribute(attributeName);
    if (string.IsNullOrEmpty(attribute))
      return new int?();
    int result;
    if (int.TryParse(attribute, NumberStyles.Integer, (IFormatProvider) CultureInfo.InvariantCulture, out result))
      return new int?(result);
    EditorLogger.LogWarning("Spawn entry has invalid integer value '" + attribute + "' for optional attribute '" + attributeName + "' on map " + Conversions.ToString(mapNumber) + " spot type " + Conversions.ToString(spotType) + ".");
    return new int?();
  }

  private void SaveSpawnXmlFile(string filePath)
  {
    MonsterSpawnDocument monsterSpawnDocument = this.BuildSpawnDocument();
    XmlDocument xmlDocument = this.CreateSpawnXmlDocument(monsterSpawnDocument);
    XmlWriterSettings settings = new XmlWriterSettings();
    settings.Indent = true;
    settings.IndentChars = "  ";
    settings.NewLineHandling = NewLineHandling.Replace;
    settings.NewLineChars = Environment.NewLine;
    try
    {
      using (FileStream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
      {
        using (XmlWriter xmlWriter = XmlWriter.Create((Stream) fileStream, settings))
          xmlDocument.Save(xmlWriter);
      }
    }
    catch (Exception ex)
    {
      EditorLogger.LogError("Failed to save XML spawn file '" + filePath + "'.", ex);
      throw;
    }
  }

  private XmlDocument CreateSpawnXmlDocument(MonsterSpawnDocument document)
  {
    XmlDocument xmlDocument = new XmlDocument();
    xmlDocument.PreserveWhitespace = false;
    XmlDeclaration xmlDeclaration = xmlDocument.CreateXmlDeclaration("1.0", "utf-8", (string) null);
    xmlDocument.AppendChild((XmlNode) xmlDeclaration);
    if (this.spawnXmlHeaderComments.Count == 0)
      this.spawnXmlHeaderComments.Add(DefaultSpawnHeaderComment);
    foreach (string spawnXmlHeaderComment in this.spawnXmlHeaderComments)
    {
      if (spawnXmlHeaderComment != null)
        xmlDocument.AppendChild((XmlNode) xmlDocument.CreateComment(spawnXmlHeaderComment));
    }
    XmlElement root = xmlDocument.CreateElement("MonsterSpawn");
    xmlDocument.AppendChild((XmlNode) root);
    if (document != null && document.Maps != null)
    {
      foreach (MonsterMap map in document.Maps)
      {
        XmlElement mapElement = xmlDocument.CreateElement("Map");
        mapElement.SetAttribute("Number", map.Number.ToString((IFormatProvider) CultureInfo.InvariantCulture));
        if (!string.IsNullOrEmpty(map.Name))
          mapElement.SetAttribute("Name", map.Name);
        ApplyExtraAttributes(mapElement, map.ExtraAttributes);
        if (map.Spots != null)
        {
          foreach (MonsterSpot spot in map.Spots)
          {
            XmlElement spotElement = xmlDocument.CreateElement("Spot");
            spotElement.SetAttribute("Type", spot.Type.ToString((IFormatProvider) CultureInfo.InvariantCulture));
            if (!string.IsNullOrEmpty(spot.Description))
              spotElement.SetAttribute("Description", spot.Description);
            ApplyExtraAttributes(spotElement, spot.ExtraAttributes);
            if (spot.Spawns != null && spot.Spawns.Count > 0)
            {
              foreach (MonsterSpawnEntry spawn in spot.Spawns)
              {
                XmlElement spawnElement = this.CreateSpawnElement(xmlDocument, spawn);
                spotElement.AppendChild((XmlNode) spawnElement);
                if (!string.IsNullOrEmpty(SpawnSpacerComment))
                  spotElement.AppendChild((XmlNode) xmlDocument.CreateComment(SpawnSpacerComment));
              }
            }
            mapElement.AppendChild((XmlNode) spotElement);
          }
        }
        root.AppendChild((XmlNode) mapElement);
      }
    }
    return xmlDocument;
  }

  private XmlElement CreateSpawnElement(XmlDocument xmlDocument, MonsterSpawnEntry spawn)
  {
    XmlElement element = xmlDocument.CreateElement("Spawn");
    element.SetAttribute("Index", spawn.Index.ToString((IFormatProvider) CultureInfo.InvariantCulture));
    element.SetAttribute("Distance", spawn.Distance.ToString((IFormatProvider) CultureInfo.InvariantCulture));
    element.SetAttribute("StartX", spawn.StartX.ToString((IFormatProvider) CultureInfo.InvariantCulture));
    element.SetAttribute("StartY", spawn.StartY.ToString((IFormatProvider) CultureInfo.InvariantCulture));
    element.SetAttribute("Dir", spawn.Direction.ToString((IFormatProvider) CultureInfo.InvariantCulture));
    if (spawn.EndX.HasValue)
      element.SetAttribute("EndX", spawn.EndX.Value.ToString((IFormatProvider) CultureInfo.InvariantCulture));
    if (spawn.EndY.HasValue)
      element.SetAttribute("EndY", spawn.EndY.Value.ToString((IFormatProvider) CultureInfo.InvariantCulture));
    if (spawn.Count.HasValue)
      element.SetAttribute("Count", spawn.Count.Value.ToString((IFormatProvider) CultureInfo.InvariantCulture));
    if (spawn.Element.HasValue)
      element.SetAttribute("Element", spawn.Element.Value.ToString((IFormatProvider) CultureInfo.InvariantCulture));
    ApplyExtraAttributes(element, spawn.ExtraAttributes);
    return element;
  }

  private static void ApplyExtraAttributes(XmlElement element, Dictionary<string, string> extraAttributes)
  {
    if (element == null || extraAttributes == null || extraAttributes.Count == 0)
      return;
    foreach (KeyValuePair<string, string> extraAttribute in extraAttributes)
    {
      if (!string.IsNullOrEmpty(extraAttribute.Key))
        element.SetAttribute(extraAttribute.Key, extraAttribute.Value ?? string.Empty);
    }
  }

  private MonsterSpawnDocument BuildSpawnDocument()
  {
    Dictionary<int, MonsterMap> dictionary = new Dictionary<int, MonsterMap>();
    int num = -1;
    string currentSpotDescription = (string) null;
    int lineNumber = 0;
    foreach (object obj in this.ListBox1.Items)
    {
      string str = Conversions.ToString(obj);
      checked { ++lineNumber; }
      if (!string.IsNullOrEmpty(str))
      {
        string trimmed = str.Trim();
        if (trimmed.Length != 0)
        {
          if (trimmed.StartsWith("//\t", StringComparison.Ordinal))
          {
            currentSpotDescription = ParseSpotComment(trimmed);
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
          {
            EditorLogger.LogWarning("Skipping line " + Conversions.ToString(lineNumber) + " because no spot header was detected: " + trimmed);
            continue;
          }
          string[] strArray = str.Split('\t');
          if (num == 1 || num == 3)
          {
            if (strArray.Length < 9)
            {
              EditorLogger.LogWarning("Skipping multi-spawn entry at line " + Conversions.ToString(lineNumber) + " due to insufficient columns (" + Conversions.ToString(strArray.Length) + ").");
              continue;
            }
          }
          else if (strArray.Length < 6)
          {
            EditorLogger.LogWarning("Skipping spawn entry at line " + Conversions.ToString(lineNumber) + " due to insufficient columns (" + Conversions.ToString(strArray.Length) + ").");
            continue;
          }
          int? nullable1 = this.ParseNullableInt32(strArray[0]);
          int? nullable2 = this.ParseNullableInt32(strArray[1]);
          int? nullable3 = this.ParseNullableInt32(strArray[2]);
          int? nullable4 = this.ParseNullableInt32(strArray[3]);
          int? nullable5 = this.ParseNullableInt32(strArray[4]);
          if (!nullable1.HasValue || !nullable2.HasValue || (!nullable3.HasValue || !nullable4.HasValue) || !nullable5.HasValue)
          {
            EditorLogger.LogWarning("Skipping spawn entry at line " + Conversions.ToString(lineNumber) + " due to invalid numeric values.");
            continue;
          }
          string spotKey = this.BuildSpotDescriptionKey(nullable2.Value, num);
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
          MonsterMap map = this.GetOrCreateMapEntry(dictionary, nullable2.Value);
          MonsterSpot spot = this.GetOrCreateSpotEntry(map, num);
          MonsterSpawnEntry monsterSpawnEntry = new MonsterSpawnEntry();
          monsterSpawnEntry.Index = nullable1.Value;
          monsterSpawnEntry.Distance = nullable3.Value;
          monsterSpawnEntry.StartX = nullable4.Value;
          monsterSpawnEntry.StartY = nullable5.Value;
          if (num == 1 || num == 3)
          {
            monsterSpawnEntry.EndX = this.ParseNullableInt32(strArray[5]);
            if (!monsterSpawnEntry.EndX.HasValue)
              monsterSpawnEntry.EndX = new int?(monsterSpawnEntry.StartX);
            monsterSpawnEntry.EndY = this.ParseNullableInt32(strArray[6]);
            if (!monsterSpawnEntry.EndY.HasValue)
              monsterSpawnEntry.EndY = new int?(monsterSpawnEntry.StartY);
            monsterSpawnEntry.Direction = this.ParseNullableInt32(strArray[7]).GetValueOrDefault();
            monsterSpawnEntry.Count = this.ParseNullableInt32(strArray[8]);
            if (num == 3)
              monsterSpawnEntry.Element = strArray.Length > 9 ? this.ParseNullableInt32(strArray[9]) : new int?();
          }
          else
            monsterSpawnEntry.Direction = this.ParseNullableInt32(strArray[5]).GetValueOrDefault();
          spot.Spawns.Add(monsterSpawnEntry);
        }
      }
    }
    MonsterSpawnDocument monsterSpawnDocument = new MonsterSpawnDocument();
    monsterSpawnDocument.Maps = dictionary.Values.OrderBy<MonsterMap, int>((Func<MonsterMap, int>) (m => m.Number)).ToList<MonsterMap>();
    foreach (MonsterMap map in monsterSpawnDocument.Maps)
      map.Spots = map.Spots.OrderBy<MonsterSpot, int>((Func<MonsterSpot, int>) (s => s.Type)).ToList<MonsterSpot>();
    int totalSpots = monsterSpawnDocument.Maps.Sum<MonsterMap>((Func<MonsterMap, int>) (m => m.Spots != null ? m.Spots.Count : 0));
    int totalSpawns = monsterSpawnDocument.Maps.Sum<MonsterMap>((Func<MonsterMap, int>) (m =>
    {
      if (m.Spots == null)
        return 0;
      return m.Spots.Sum<MonsterSpot>((Func<MonsterSpot, int>) (s => s.Spawns != null ? s.Spawns.Count : 0));
    }));
    EditorLogger.LogInfo("Built spawn document with " + Conversions.ToString(monsterSpawnDocument.Maps.Count) + " map(s), " + Conversions.ToString(totalSpots) + " spot(s) and " + Conversions.ToString(totalSpawns) + " spawn row(s).");
    return monsterSpawnDocument;
  }

  private MonsterMap GetOrCreateMapEntry(Dictionary<int, MonsterMap> maps, int mapNumber)
  {
    MonsterMap monsterMap;
    if (!maps.TryGetValue(mapNumber, out monsterMap))
    {
      monsterMap = new MonsterMap();
      monsterMap.Number = mapNumber;
      monsterMap.Name = this.ResolveMapDisplayName(mapNumber, this.LookupSpawnMapName(mapNumber));
      if (monsterMap.Spots == null)
        monsterMap.Spots = new List<MonsterSpot>();
      maps.Add(mapNumber, monsterMap);
    }
    else if (monsterMap.Spots == null)
      monsterMap.Spots = new List<MonsterSpot>();
    return monsterMap;
  }

  private MonsterSpot GetOrCreateSpotEntry(MonsterMap map, int type)
  {
    if (map.Spots == null)
      map.Spots = new List<MonsterSpot>();
    MonsterSpot monsterSpot = map.Spots.FirstOrDefault<MonsterSpot>((Func<MonsterSpot, bool>) (s => s.Type == type));
    if (monsterSpot == null)
    {
      monsterSpot = new MonsterSpot();
      monsterSpot.Type = type;
      monsterSpot.Description = this.ResolveSpotDescriptionText(map.Number, type);
      map.Spots.Add(monsterSpot);
    }
    return monsterSpot;
  }

  private string ResolveSpotDescriptionText(int mapNumber, int type)
  {
    string str;
    if (this.spotDescriptions.TryGetValue(this.BuildSpotDescriptionKey(mapNumber, type), out str) && !string.IsNullOrEmpty(str))
      return str;
    return GetDefaultSpotDescription(type);
  }

  private string LookupSpawnMapName(int mapNumber)
  {
    string str;
    if (this.spawnMapNames.TryGetValue(mapNumber, out str) && !string.IsNullOrEmpty(str))
      return str;
    return string.Empty;
  }

  private string BuildSpotDescriptionKey(int mapNumber, int type)
  {
    return mapNumber.ToString((IFormatProvider) CultureInfo.InvariantCulture) + ":" + type.ToString((IFormatProvider) CultureInfo.InvariantCulture);
  }

  private void AddSpotHeaderLines(string mapName, int type, string description)
  {
    string str = string.IsNullOrEmpty(description) ? GetDefaultSpotDescription(type) : description;
    this.ListBox1.Items.Add((object) SectionSeparator);
    this.ListBox1.Items.Add((object) ("//\t" + mapName + " " + str));
    this.ListBox1.Items.Add((object) SectionSeparator);
    this.ListBox1.Items.Add((object) GetSpotHeaderLine(type));
    this.ListBox1.Items.Add((object) type.ToString((IFormatProvider) CultureInfo.InvariantCulture));
  }

  private static string GetDefaultSpotDescription(int type)
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

  private static string GetSpotHeaderLine(int type)
  {
    if (type == 1)
      return "//Mob\tMap\tRadio\tCordX\tCordY\tCordX2\tCordY2\tDir \tQuant  Name";
    if (type == 3)
      return "//Mob\tMap\tRadio\tCordX\tCordY\tCordX2\tCordY2\tDir \tQuant\tElement\tName";
    return "//Mob\tMap\tRad\tX\tY\tStr\tName";
  }

  private string FormatSpawnListEntry(MonsterMap map, MonsterSpot spot, MonsterSpawnEntry spawn)
  {
    string monsterName = this.LookupMonsterName(spawn.Index);
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

  private static string ParseSpotComment(string line)
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

  private string LookupMonsterName(int index)
  {
    string str;
    if (this.monsterNames.TryGetValue(index, out str))
      return str;
    return "Monster " + index.ToString((IFormatProvider) CultureInfo.InvariantCulture);
  }

  private string ResolveMapDisplayName(int mapNumber, string fallbackName)
  {
    string str;
    if (this.mapNames.TryGetValue(mapNumber, out str))
      return str;
    string spawnMapName = this.LookupSpawnMapName(mapNumber);
    if (!string.IsNullOrEmpty(spawnMapName))
      return spawnMapName;
    if (!string.IsNullOrEmpty(fallbackName))
      return fallbackName;
    return mapNumber.ToString((IFormatProvider) CultureInfo.InvariantCulture);
  }

  private static string StripLineComment(string value)
  {
    if (value == null)
      return string.Empty;
    int length = value.IndexOf("//", StringComparison.Ordinal);
    if (length >= 0)
      value = value.Substring(0, length);
    return value.Trim();
  }

  private int? ParseNullableInt32(string value)
  {
    string s = StripLineComment(value);
    if (s.Length == 0)
      return new int?();
    int result;
    return int.TryParse(s, NumberStyles.Integer, CultureInfo.InvariantCulture, out result) ? new int?(result) : new int?();
  }

  private void LoadMapListEntries()
  {
    this.ComboBox1.Items.Clear();
    this.mapNames.Clear();
    string path = Path.Combine(this.CurrDir, "Maps.txt");
    if (!File.Exists(path))
    {
      EditorLogger.LogError("Maps.txt not found at '" + path + "'.", (Exception) null);
      throw new FileNotFoundException("Maps.txt file not found.", path);
    }
    int count = 0;
    try
    {
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
            checked { ++count; }
          }
        }
      }
      EditorLogger.LogInfo("Loaded map list with " + Conversions.ToString(count) + " entry(ies) from '" + path + "'.");
    }
    catch (Exception ex)
    {
      EditorLogger.LogError("Failed to read Maps.txt from '" + path + "'.", ex);
      throw;
    }
  }

  private bool TryLoadMonsterListXml()
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
            this.ApplyMonsterDefinitionsToList(definitionList);
            EditorLogger.LogInfo("Loaded monster definitions from XML '" + path + "'.");
            return true;
          }
        }
        catch (InvalidOperationException ex)
        {
          EditorLogger.LogError("Failed to parse monster definitions from XML '" + path + "'.", ex);
        }
        catch (Exception ex)
        {
          EditorLogger.LogError("Unexpected error reading monster definitions from XML '" + path + "'.", ex);
        }
      }
    }
    return false;
  }

  private void LoadMonsterListText()
  {
    string path = Path.Combine(this.CurrDir, "Monster.txt");
    this.ListBox2.Items.Clear();
    this.monsterNames.Clear();
    if (!File.Exists(path))
    {
      EditorLogger.LogError("Monster.txt not found at '" + path + "'.", (Exception) null);
      throw new FileNotFoundException("Monster.txt file not found.", path);
    }
    int count = 0;
    try
    {
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
            checked { ++count; }
          }
        }
      }
      EditorLogger.LogInfo("Loaded monster definitions from text file '" + path + "' with " + Conversions.ToString(count) + " entry(ies).");
    }
    catch (Exception ex)
    {
      EditorLogger.LogError("Failed to read Monster.txt from '" + path + "'.", ex);
      throw;
    }
  }

  private void ApplyMonsterDefinitionsToList(MonsterDefinitionList definitions)
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
    EditorLogger.LogInfo("Applied " + Conversions.ToString(this.monsterNames.Count) + " monster definition(s) to the list.");
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
        EditorLogger.LogError("Failed to draw spawn point at list index " + Conversions.ToString(index) + ".", ex);
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

}
