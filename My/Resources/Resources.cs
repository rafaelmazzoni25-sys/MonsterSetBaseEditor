// Decompiled with JetBrains decompiler
// Type: MonasterSetBase.My.Resources.Resources
// Assembly: MonsterSetBaseEditor, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 03612203-8C9B-483E-B836-D3195F197403
// Assembly location: C:\Users\rafae\Downloads\MuOnline\Tools\Editor De Mostros\MonsterSetBaseEditor.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace MonasterSetBase.My.Resources
{

[CompilerGenerated]
[DebuggerNonUserCode]
[StandardModule]
[HideModuleName]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
internal sealed class Resources
{
  private static ResourceManager resourceMan;
  private static CultureInfo resourceCulture;

  [EditorBrowsable(EditorBrowsableState.Advanced)]
  internal static ResourceManager ResourceManager
  {
    get
    {
      if (object.ReferenceEquals((object) MonasterSetBase.My.Resources.Resources.resourceMan, (object) null))
        MonasterSetBase.My.Resources.Resources.resourceMan = new ResourceManager("MonasterSetBase.Resources", typeof (MonasterSetBase.My.Resources.Resources).Assembly);
      return MonasterSetBase.My.Resources.Resources.resourceMan;
    }
  }

  [EditorBrowsable(EditorBrowsableState.Advanced)]
  internal static CultureInfo Culture
  {
    get => MonasterSetBase.My.Resources.Resources.resourceCulture;
    set => MonasterSetBase.My.Resources.Resources.resourceCulture = value;
  }
}

}
