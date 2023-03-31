Imports System
Imports System.CodeDom.Compiler
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Globalization
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace plg.My.Resources
    ' Token: 0x0200000C RID: 12
    <CompilerGenerated()>
    <GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")>
    <DebuggerNonUserCode()>
    <HideModuleName()>
    Friend Module Resources
        ' Token: 0x17000006 RID: 6
        ' (get) Token: 0x06000026 RID: 38 RVA: 0x00005484 File Offset: 0x00003684
        <EditorBrowsable(EditorBrowsableState.Advanced)>
        Friend ReadOnly Property ResourceManager As ResourceManager
            Get
                If Object.ReferenceEquals(Resources.resourceMan, Nothing) Then
                    Dim resourcexManager As ResourceManager = New ResourceManager("plg.Resources", GetType(Resources).Assembly)
                    Resources.resourceMan = resourceManager
                End If
                Return Resources.resourceMan
            End Get
        End Property

        ' Token: 0x17000007 RID: 7
        ' (get) Token: 0x06000027 RID: 39 RVA: 0x000054C4 File Offset: 0x000036C4
        ' (set) Token: 0x06000028 RID: 40 RVA: 0x000054D8 File Offset: 0x000036D8
        <EditorBrowsable(EditorBrowsableState.Advanced)>
        Friend Property Culture As CultureInfo
            Get
                Return Resources.resourceCulture
            End Get
            Set(value As CultureInfo)
                Resources.resourceCulture = value
            End Set
        End Property

        ' Token: 0x04000025 RID: 37
        Private resourceMan As ResourceManager

        ' Token: 0x04000026 RID: 38
        Private resourceCulture As CultureInfo
    End Module
End Namespace
