Imports System
Imports System.CodeDom.Compiler
Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.Diagnostics
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.VisualBasic.CompilerServices
Imports Microsoft.VisualBasic.MyServices.Internal

Namespace plg.My
	' Token: 0x02000004 RID: 4
	<GeneratedCode("MyTemplate", "8.0.0.0")>
    <HideModuleName()>
    Friend Module MyProject
        ' Token: 0x17000001 RID: 1
        ' (get) Token: 0x06000004 RID: 4 RVA: 0x0000208C File Offset: 0x0000028C
        <HelpKeyword("My.Computer")>
        Friend ReadOnly Property Computer As MyComputer
            <DebuggerHidden()>
            Get
                Return MyProject.m_ComputerObjectProvider.GetInstance
            End Get
        End Property

        ' Token: 0x17000002 RID: 2
        ' (get) Token: 0x06000005 RID: 5 RVA: 0x000020A4 File Offset: 0x000002A4
        <HelpKeyword("My.Application")>
        Friend ReadOnly Property Application As MyApplication
            <DebuggerHidden()>
            Get
                Return MyProject.m_AppObjectProvider.GetInstance
            End Get
        End Property

        ' Token: 0x17000003 RID: 3
        ' (get) Token: 0x06000006 RID: 6 RVA: 0x000020BC File Offset: 0x000002BC
        <HelpKeyword("My.User")>
        Friend ReadOnly Property User As User
            <DebuggerHidden()>
            Get
                Return MyProject.m_UserObjectProvider.GetInstance
            End Get
        End Property

        ' Token: 0x17000004 RID: 4
        ' (get) Token: 0x06000007 RID: 7 RVA: 0x000020D4 File Offset: 0x000002D4
        <HelpKeyword("My.WebServices")>
        Friend ReadOnly Property WebServices As MyProject.MyWebServices
            <DebuggerHidden()>
            Get
                Return MyProject.m_MyWebServicesObjectProvider.GetInstance
            End Get
        End Property

        ' Token: 0x04000001 RID: 1
        Private m_ComputerObjectProvider As MyProject.ThreadSafeObjectProvider(Of MyComputer) = New MyProject.ThreadSafeObjectProvider(Of MyComputer)()

        ' Token: 0x04000002 RID: 2
        Private m_AppObjectProvider As MyProject.ThreadSafeObjectProvider(Of MyApplication) = New MyProject.ThreadSafeObjectProvider(Of MyApplication)()

        ' Token: 0x04000003 RID: 3
        Private m_UserObjectProvider As MyProject.ThreadSafeObjectProvider(Of User) = New MyProject.ThreadSafeObjectProvider(Of User)()

        ' Token: 0x04000004 RID: 4
        Private m_MyWebServicesObjectProvider As MyProject.ThreadSafeObjectProvider(Of MyProject.MyWebServices) = New MyProject.ThreadSafeObjectProvider(Of MyProject.MyWebServices)()

        ' Token: 0x02000005 RID: 5
        <MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")>
        <EditorBrowsable(EditorBrowsableState.Never)>
        Friend NotInheritable Class MyWebServices
            ' Token: 0x06000008 RID: 8 RVA: 0x000020EC File Offset: 0x000002EC
            <EditorBrowsable(EditorBrowsableState.Never)>
            <DebuggerHidden()>
            Public Overrides Function Equals(o As Object) As Boolean
                Return MyBase.Equals(RuntimeHelpers.GetObjectValue(o))
            End Function

            ' Token: 0x06000009 RID: 9 RVA: 0x00002108 File Offset: 0x00000308
            <DebuggerHidden()>
            <EditorBrowsable(EditorBrowsableState.Never)>
            Public Overrides Function GetHashCode() As Integer
                Return MyBase.GetHashCode()
            End Function

            ' Token: 0x0600000A RID: 10 RVA: 0x0000211C File Offset: 0x0000031C
            <EditorBrowsable(EditorBrowsableState.Never)>
            <DebuggerHidden()>
            Friend Function [GetType]() As Type
                Return GetType(MyProject.MyWebServices)
            End Function

            ' Token: 0x0600000B RID: 11 RVA: 0x00002134 File Offset: 0x00000334
            <EditorBrowsable(EditorBrowsableState.Never)>
            <DebuggerHidden()>
            Public Overrides Function ToString() As String
                Return MyBase.ToString()
            End Function

            ' Token: 0x0600000C RID: 12 RVA: 0x00002148 File Offset: 0x00000348
            <DebuggerHidden()>
            Private Shared Function Create__Instance__(Of T As New)(instance As T) As T
                If instance Is Nothing Then
                    Return Activator.CreateInstance(Of T)()
                End If
                Return instance
            End Function

            ' Token: 0x0600000D RID: 13 RVA: 0x00002164 File Offset: 0x00000364
            <DebuggerHidden()>
            Private Sub Dispose__Instance__(Of T)(ByRef instance As T)
                instance = Nothing
            End Sub

            ' Token: 0x0600000E RID: 14 RVA: 0x00002180 File Offset: 0x00000380
            <DebuggerHidden()>
            <EditorBrowsable(EditorBrowsableState.Never)>
            Public Sub New()
            End Sub
        End Class

        ' Token: 0x02000006 RID: 6
        <ComVisible(False)>
        <EditorBrowsable(EditorBrowsableState.Never)>
        Friend NotInheritable Class ThreadSafeObjectProvider(Of T As New)
            ' Token: 0x17000005 RID: 5
            ' (get) Token: 0x0600000F RID: 15 RVA: 0x00002188 File Offset: 0x00000388
            Friend ReadOnly Property GetInstance As T
                <DebuggerHidden()>
                Get
                    Dim t As T = Me.m_Context.Value
                    If t Is Nothing Then
                        t = Activator.CreateInstance(Of T)()
                        Me.m_Context.Value = t
                    End If
                    Return t
                End Get
            End Property

            ' Token: 0x06000010 RID: 16 RVA: 0x000021BC File Offset: 0x000003BC
            <DebuggerHidden()>
            <EditorBrowsable(EditorBrowsableState.Never)>
            Public Sub New()
                Me.m_Context = New ContextValue(Of T)()
            End Sub

            ' Token: 0x04000005 RID: 5
            Private m_Context As ContextValue(Of T)
        End Class
    End Module
End Namespace
