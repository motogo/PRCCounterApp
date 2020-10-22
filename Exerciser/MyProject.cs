// Decompiled with JetBrains decompiler
// Type: Exerciser.My.MyProject
// Assembly: Exerciser, Version=1.7.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A209899A-3E48-4746-B638-8A7F24C27623
// Assembly location: D:\temp\guidetech\Exerciser.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Exerciser.My
{
  [StandardModule]
  [GeneratedCode("MyTemplate", "10.0.0.0")]
  [HideModuleName]
  internal sealed class MyProject
  {
    private static readonly MyProject.ThreadSafeObjectProvider<MyComputer> m_ComputerObjectProvider = new MyProject.ThreadSafeObjectProvider<MyComputer>();
    private static readonly MyProject.ThreadSafeObjectProvider<MyApplication> m_AppObjectProvider = new MyProject.ThreadSafeObjectProvider<MyApplication>();
    private static readonly MyProject.ThreadSafeObjectProvider<User> m_UserObjectProvider = new MyProject.ThreadSafeObjectProvider<User>();
    private static MyProject.ThreadSafeObjectProvider<MyProject.MyForms> m_MyFormsObjectProvider = new MyProject.ThreadSafeObjectProvider<MyProject.MyForms>();
    private static readonly MyProject.ThreadSafeObjectProvider<MyProject.MyWebServices> m_MyWebServicesObjectProvider = new MyProject.ThreadSafeObjectProvider<MyProject.MyWebServices>();

    [HelpKeyword("My.Computer")]
    internal static MyComputer Computer
    {
      [DebuggerHidden] get => MyProject.m_ComputerObjectProvider.GetInstance;
    }

    [HelpKeyword("My.Application")]
    internal static MyApplication Application
    {
      [DebuggerHidden] get => MyProject.m_AppObjectProvider.GetInstance;
    }

    [HelpKeyword("My.User")]
    internal static User User
    {
      [DebuggerHidden] get => MyProject.m_UserObjectProvider.GetInstance;
    }

    [HelpKeyword("My.Forms")]
    internal static MyProject.MyForms Forms
    {
      [DebuggerHidden] get => MyProject.m_MyFormsObjectProvider.GetInstance;
    }

    [HelpKeyword("My.WebServices")]
    internal static MyProject.MyWebServices WebServices
    {
      [DebuggerHidden] get => MyProject.m_MyWebServicesObjectProvider.GetInstance;
    }

    [MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
    [EditorBrowsable(EditorBrowsableState.Never)]
    internal sealed class MyForms
    {
      public ConfigFrm m_ConfigFrm;
      public DebugFrm m_DebugFrm;
      public DevMapFrm m_DevMapFrm;
      public ExrFrm m_ExrFrm;
      public GraphFrm m_GraphFrm;
      public ResultsFrm m_ResultsFrm;
      public SetupFrm m_SetupFrm;
      public ShowPtrs m_ShowPtrs;
      public StableFrm m_StableFrm;
      [ThreadStatic]
      private static Hashtable m_FormBeingCreated;

      public ConfigFrm ConfigFrm
      {
        get
        {
          this.m_ConfigFrm = MyProject.MyForms.Create__Instance__<ConfigFrm>(this.m_ConfigFrm);
          return this.m_ConfigFrm;
        }
        set
        {
          if (value == this.m_ConfigFrm)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<ConfigFrm>(ref this.m_ConfigFrm);
        }
      }

      public DebugFrm DebugFrm
      {
        get
        {
          this.m_DebugFrm = MyProject.MyForms.Create__Instance__<DebugFrm>(this.m_DebugFrm);
          return this.m_DebugFrm;
        }
        set
        {
          if (value == this.m_DebugFrm)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<DebugFrm>(ref this.m_DebugFrm);
        }
      }

      public DevMapFrm DevMapFrm
      {
        get
        {
          this.m_DevMapFrm = MyProject.MyForms.Create__Instance__<DevMapFrm>(this.m_DevMapFrm);
          return this.m_DevMapFrm;
        }
        set
        {
          if (value == this.m_DevMapFrm)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<DevMapFrm>(ref this.m_DevMapFrm);
        }
      }

      public ExrFrm ExrFrm
      {
        get
        {
          this.m_ExrFrm = MyProject.MyForms.Create__Instance__<ExrFrm>(this.m_ExrFrm);
          return this.m_ExrFrm;
        }
        set
        {
          if (value == this.m_ExrFrm)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<ExrFrm>(ref this.m_ExrFrm);
        }
      }
            /*
      public GraphFrm GraphFrm
      {
        get
        {
          this.m_GraphFrm = MyProject.MyForms.Create__Instance__<GraphFrm>(this.m_GraphFrm);
          return this.m_GraphFrm;
        }
        set
        {
          if (value == this.m_GraphFrm)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<GraphFrm>(ref this.m_GraphFrm);
        }
      }
            */
            /*
      public ResultsFrm ResultsFrm
      {
        get
        {
          this.m_ResultsFrm = MyProject.MyForms.Create__Instance__<ResultsFrm>(this.m_ResultsFrm);
          return this.m_ResultsFrm;
        }
        set
        {
          if (value == this.m_ResultsFrm)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<ResultsFrm>(ref this.m_ResultsFrm);
        }
      }
            */

            /*
      public SetupFrm SetupFrm
      {
        get
        {
          this.m_SetupFrm = MyProject.MyForms.Create__Instance__<SetupFrm>(this.m_SetupFrm);
          return this.m_SetupFrm;
        }
        set
        {
          if (value == this.m_SetupFrm)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<SetupFrm>(ref this.m_SetupFrm);
        }
      }
            */

            /*
      public ShowPtrs ShowPtrs
      {
        get
        {
          this.m_ShowPtrs = MyProject.MyForms.Create__Instance__<ShowPtrs>(this.m_ShowPtrs);
          return this.m_ShowPtrs;
        }
        set
        {
          if (value == this.m_ShowPtrs)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<ShowPtrs>(ref this.m_ShowPtrs);
        }
      }
            */
            /*
      public StableFrm StableFrm
      {
        get
        {
          this.m_StableFrm = MyProject.MyForms.Create__Instance__<StableFrm>(this.m_StableFrm);
          return this.m_StableFrm;
        }
        set
        {
          if (value == this.m_StableFrm)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<StableFrm>(ref this.m_StableFrm);
        }
      }
            */
      [DebuggerHidden]
      private static T Create__Instance__<T>(T Instance) where T : Form, new()
      {
        if ((object) Instance != null && !Instance.IsDisposed)
          return Instance;
        if (MyProject.MyForms.m_FormBeingCreated != null)
        {
          if (MyProject.MyForms.m_FormBeingCreated.ContainsKey((object) typeof (T)))
            throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate"));
        }
        else
          MyProject.MyForms.m_FormBeingCreated = new Hashtable();
        MyProject.MyForms.m_FormBeingCreated.Add((object) typeof (T), (object) null);
        try
        {
          return new T();
        }
        catch (TargetInvocationException ex) when (
        {
          // ISSUE: unable to correctly present filter
          ProjectData.SetProjectError((Exception) ex);
          if (ex.InnerException != null)
          {
            SuccessfulFiltering;
          }
          else
            throw;
        }
        )
        {
          throw new InvalidOperationException(Utils.GetResourceString("WinForms_SeeInnerException", ex.InnerException.Message), ex.InnerException);
        }
        finally
        {
          MyProject.MyForms.m_FormBeingCreated.Remove((object) typeof (T));
        }
      }

      [DebuggerHidden]
      private void Dispose__Instance__<T>(ref T instance) where T : Form
      {
        instance.Dispose();
        instance = default (T);
      }

      [EditorBrowsable(EditorBrowsableState.Never)]
      [DebuggerHidden]
      public MyForms()
      {
      }

      [EditorBrowsable(EditorBrowsableState.Never)]
      public override bool Equals(object o) => base.Equals(RuntimeHelpers.GetObjectValue(o));

      [EditorBrowsable(EditorBrowsableState.Never)]
      public override int GetHashCode() => base.GetHashCode();

      [EditorBrowsable(EditorBrowsableState.Never)]
      internal new System.Type GetType() => typeof (MyProject.MyForms);

      [EditorBrowsable(EditorBrowsableState.Never)]
      public override string ToString() => base.ToString();
    }

    [MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
    [EditorBrowsable(EditorBrowsableState.Never)]
    internal sealed class MyWebServices
    {
      [DebuggerHidden]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public override bool Equals(object o) => base.Equals(RuntimeHelpers.GetObjectValue(o));

      [DebuggerHidden]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public override int GetHashCode() => base.GetHashCode();

      [EditorBrowsable(EditorBrowsableState.Never)]
      [DebuggerHidden]
      internal new System.Type GetType() => typeof (MyProject.MyWebServices);

      [EditorBrowsable(EditorBrowsableState.Never)]
      [DebuggerHidden]
      public override string ToString() => base.ToString();

      [DebuggerHidden]
      private static T Create__Instance__<T>(T instance) where T : new() => (object) instance == null ? new T() : instance;

      [DebuggerHidden]
      private void Dispose__Instance__<T>(ref T instance) => instance = default (T);

      [DebuggerHidden]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public MyWebServices()
      {
      }
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [ComVisible(false)]
    internal sealed class ThreadSafeObjectProvider<T> where T : new()
    {
      internal T GetInstance
      {
        [DebuggerHidden] get
        {
          if ((object) MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue == null)
            MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue = new T();
          return MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue;
        }
      }

      [EditorBrowsable(EditorBrowsableState.Never)]
      [DebuggerHidden]
      public ThreadSafeObjectProvider()
      {
      }
    }
  }
}
