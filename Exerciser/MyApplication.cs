// Decompiled with JetBrains decompiler
// Type: Exerciser.My.MyApplication
// Assembly: Exerciser, Version=1.7.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A209899A-3E48-4746-B638-8A7F24C27623
// Assembly location: D:\temp\guidetech\Exerciser.exe

using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Exerciser.My
{
  [EditorBrowsable(EditorBrowsableState.Never)]
  [GeneratedCode("MyTemplate", "10.0.0.0")]
  internal class MyApplication : WindowsFormsApplicationBase
  {
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [DebuggerHidden]
    [STAThread]
    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
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
    protected override void OnCreateMainForm() => this.MainForm = (Form) MyProject.Forms.ExrFrm;
  }
}
