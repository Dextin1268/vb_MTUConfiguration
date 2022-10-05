Imports System.Collections.ObjectModel
Imports System.Management.Automation
Imports System.Management.Automation.Runspaces
Imports System.Net.NetworkInformation
Imports System.Text


' /////////////////////////////////////////////////////////////////////////////////////
'   設定 MTU 需要系統管理員權限, 依下列步驟修改設定
'   1. 對專案點擊右鍵 > 屬性
'   2. 在應用程式頁面點擊"檢視 Windows 設定"
'   3. 其中有一行為 <requestedExecutionLevel level="asInvoker" uiAccess="false" />
'      將 asInvoker 改為 requireAdministrator
' /////////////////////////////////////////////////////////////////////////////////////

Public Class Form1

     Sub New()
          InitializeComponent()

          Dim nics As NetworkInterface() = NetworkInterface.GetAllNetworkInterfaces()
          For Each adapter As NetworkInterface In nics
               If adapter.Supports(NetworkInterfaceComponent.IPv4) = False Then
                    Continue For
               End If
               ComboBox1.Items.Add(adapter.Name)
          Next
          If ComboBox1.Items.Count > 0 Then
               ComboBox1.SelectedIndex = 0
          End If
     End Sub

     Private Sub btnJumboEnable_Click(sender As Object, e As EventArgs) Handles btnJumboEnable.Click
          Dim name As String = ComboBox1.SelectedItem.ToString()
          Dim jumboFrames As Integer = 9014 ' Enable Value
          Dim cmd = String.Format("Set-NetAdapterAdvancedProperty -Name ""{0}"" -RegistryKeyword ""*JumboPacket"" -Registryvalue {1}", name, jumboFrames)
          RunPowerShell(cmd)
          MsgBox("Enable Jumbo Frames")
     End Sub

     Private Sub btnJumboDisable_Click(sender As Object, e As EventArgs) Handles btnJumboDisable.Click
          Dim name As String = ComboBox1.SelectedItem.ToString()
          Dim jumboFrames As Integer = 1514 ' Disable Value
          Dim cmd = String.Format("Set-NetAdapterAdvancedProperty -Name ""{0}"" -RegistryKeyword ""*JumboPacket"" -Registryvalue {1}", name, jumboFrames)
          RunPowerShell(cmd)
          MsgBox("Disable Jumbo Frames")
     End Sub

     Private Sub btnSet_Click(sender As Object, e As EventArgs) Handles btnSet.Click
          Try
               Dim name As String = ComboBox1.SelectedItem.ToString()
               Dim mtu As Integer
               If Integer.TryParse(txtSetValue.Text, mtu) = False Then
                    MsgBox("輸入有誤")
                    Return
               End If
               Dim cmd = String.Format("netsh interface ipv4 set subinterface ""{0}"" mtu={1} store=persistent", name, mtu)
               RunPowerShell(cmd)

          Catch ex As Exception
               MsgBox(ex.Message)
          End Try
     End Sub

     Private Sub btnGet_Click(sender As Object, e As EventArgs) Handles btnGet.Click
          txtGetValue.Text = "----"
          If ComboBox1.SelectedItem Is Nothing Then
               Return
          End If
          Dim nics As NetworkInterface() = NetworkInterface.GetAllNetworkInterfaces()
          For Each adapter As NetworkInterface In nics
               If adapter.Supports(NetworkInterfaceComponent.IPv4) = False Then
                    Continue For
               End If
               If adapter.Name = ComboBox1.SelectedItem.ToString() Then
                    Dim adapterProperties As IPInterfaceProperties = adapter.GetIPProperties()
                    Dim p As IPv4InterfaceProperties = adapterProperties.GetIPv4Properties()
                    txtGetValue.Text = p.Mtu.ToString()
                    Exit For
               End If
          Next
     End Sub

     Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
          '// 測試
          txtGetValue.Text = "----"
          Dim name As String = ComboBox1.SelectedItem.ToString()
          Dim runspace As Runspace = RunspaceFactory.CreateRunspace()
          runspace.Open()

          Dim pipeline As Pipeline = runspace.CreatePipeline()
          pipeline.Commands.AddScript("netsh interface ipv4 show subinterface")
          Dim results As Collection(Of PSObject) = pipeline.Invoke()
          runspace.Close()

          For Each ps As PSObject In results
               Dim r = RegularExpressions.Regex.Split(ps.ToString(), "  ").Where(Function(s) Not String.IsNullOrWhiteSpace(s)).ToArray()
               If r.Contains(name) Then
                    txtGetValue.Text = r(0)
                    Exit For
               End If
          Next
     End Sub

     Private Sub RunPowerShell(ParamArray commands() As String)
          Try
               Dim runspace As Runspace = RunspaceFactory.CreateRunspace()
               runspace.Open()

               Dim pipeline As Pipeline = runspace.CreatePipeline()
               For Each cmd As String In commands
                    pipeline.Commands.AddScript(cmd)
               Next

               Dim results As Collection(Of PSObject) = pipeline.Invoke()
               runspace.Close()

               Dim stringBuilder As StringBuilder = New StringBuilder()
               For Each ps As PSObject In results
                    stringBuilder.AppendLine(ps.ToString())
               Next
               Dim msg As String = stringBuilder.ToString()
               If msg <> "" Then
                    MsgBox(stringBuilder.ToString())
               End If

          Catch ex As Exception
               Throw ex
          End Try
     End Sub

End Class
