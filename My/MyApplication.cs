// Decompiled with JetBrains decompiler
// Type: MonasterSetBase.My.MyApplication
// Assembly: MonsterSetBaseEditor, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 03612203-8C9B-483E-B836-D3195F197403
// Assembly location: C:\Users\rafae\Downloads\MuOnline\Tools\Editor De Mostros\MonsterSetBaseEditor.exe

using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;

namespace MonasterSetBase.My;

[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("MyTemplate", "8.0.0.0")]
internal class MyApplication : WindowsFormsApplicationBase
{
  [STAThread]
  [EditorBrowsable(EditorBrowsableState.Advanced)]
  [DebuggerHidden]
  internal static void Main(string[] Args)
  {
    try
    {
      Application.SetCompatibleTextRenderingDefault(WindowsFormsApplicationBase.UseCompatibleTextRendering);
    }
    finally
    {
    }
    MyProject.Application.Run(Args);
  }

  [DebuggerStepThrough]
  public MyApplication()
    : base(AuthenticationMode.Windows)
  {
    this.IsSingleInstance = false;
    this.EnableVisualStyles = true;
    this.SaveMySettingsOnExit = true;
    this.ShutdownStyle = ShutdownMode.AfterMainFormCloses;
  }

  [DebuggerStepThrough]
  protected override void OnCreateMainForm() => this.MainForm = (Form) MyProject.Forms.Form1;
}
