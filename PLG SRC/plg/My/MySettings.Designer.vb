Imports System
Imports System.CodeDom.Compiler
Imports System.ComponentModel
Imports System.Configuration
Imports System.Runtime.CompilerServices

Namespace plg.My
	' Token: 0x0200000D RID: 13
	<GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "9.0.0.0")>
	<CompilerGenerated()>
	<EditorBrowsable(EditorBrowsableState.Advanced)>
	Friend NotInheritable Partial Class MySettings
		Inherits ApplicationSettingsBase

		' Token: 0x17000008 RID: 8
		' (get) Token: 0x0600002B RID: 43 RVA: 0x00005500 File Offset: 0x00003700
		Public Shared ReadOnly Property [Default] As MySettings
			Get
				Return MySettings.defaultInstance
			End Get
		End Property

		' Token: 0x04000027 RID: 39
		Private Shared defaultInstance As MySettings = CType(SettingsBase.Synchronized(New MySettings()), MySettings)
	End Class
End Namespace
