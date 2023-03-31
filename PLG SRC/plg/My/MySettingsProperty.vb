Imports System
Imports System.ComponentModel.Design
Imports System.Diagnostics
Imports System.Runtime.CompilerServices
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace plg.My
	' Token: 0x0200000E RID: 14
	<CompilerGenerated()>
	<DebuggerNonUserCode()>
    <HideModuleName()>
    Friend Module MySettingsProperty
        ' Token: 0x17000009 RID: 9
        ' (get) Token: 0x0600002C RID: 44 RVA: 0x00005514 File Offset: 0x00003714
        <HelpKeyword("My.Settings")>
        Friend ReadOnly Property Settings As MySettings
            Get
                Return MySettings.[Default]
            End Get
        End Property
    End Module
End Namespace
