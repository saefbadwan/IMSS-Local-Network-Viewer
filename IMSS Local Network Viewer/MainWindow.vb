Imports System.Net.NetworkInformation
Imports System.Net

Public Class MainWindow
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        _IMSS_SetupListView()

        _IMSS_LoadConnectionsWorker.RunWorkerAsync()

    End Sub

    Private Sub _IMSS_SetupListView()
        With _IMSS_NetworkConnections.Groups
            .Add("Available Connections").Image = My.Resources._IMSS_NetworkViewer_Icon_24x24
        End With
        _IMSS_NetworkConnections.ShowGroups = True
    End Sub
    Private pingers As New List(Of Ping)

    Private instances As Integer = 0
    Private lock As New Object

    Private result As Integer = 0

    Private timeOut As Integer = 250
    Private ttl As Integer = 5

    Sub Ping_completed(ByVal s As Object, ByVal e As PingCompletedEventArgs)

        SyncLock lock
            instances -= 1
        End SyncLock

        If e.Reply.Status = IPStatus.Success Then
            With _IMSS_NetworkConnections.Groups(0).Items.Add(e.Reply.Address.ToString())
                .Image = My.Resources._IMSS_Screen_Icon_16x16
                .SubItems.Add("Connected").Image = My.Resources._IMSS_Connected_Icon_16x16
            End With
            result += 1
        Else
            'Console.WriteLine(String.Concat("Non-active IP: ", e.Reply.Address.ToString()))
        End If

    End Sub

    Private Sub CreatePingers(ByVal cnt As Integer)

        For i As Integer = 1 To cnt
            Dim p As New Ping
            AddHandler p.PingCompleted, AddressOf Ping_completed
            pingers.Add(p)
        Next
    End Sub
    Private Sub DestroyPingers()

        For Each p As Ping In pingers
            RemoveHandler p.PingCompleted, AddressOf Ping_completed
            p.Dispose()
        Next

        pingers.Clear()

    End Sub

    Private Sub _IMSS_LoadNetorkConnections()
        Dim baseIP As String = IMSS_Info._IMSS_GetGetewayIpAddressLocal()
        baseIP = baseIP.Remove(baseIP.Length - 1)
        Dim classD As Integer = 1

        CreatePingers(255)

        Dim po As New PingOptions(ttl, True)
        Dim enc As New System.Text.ASCIIEncoding
        Dim data As Byte() = enc.GetBytes("abababababababababababababababab")


        Dim cnt As Integer = 1

        'Dim watch As Stopwatch = Stopwatch.StartNew

        For Each p As Ping In pingers
            SyncLock lock
                instances += 1
            End SyncLock

            p.SendAsync(String.Concat(baseIP, cnt.ToString()), timeOut, data, po)
            cnt += 1
        Next

        Do While instances > 0

        Loop

        'watch.Stop()

        DestroyPingers()
    End Sub




    Private Sub _IMSS_LoadConnectionsWorker_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles _IMSS_LoadConnectionsWorker.DoWork
        _IMSS_LoadNetorkConnections()
    End Sub

    Private Sub _IMSS_LoadConnectionsWorker_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles _IMSS_LoadConnectionsWorker.RunWorkerCompleted
        _IMSS_Loading_PictureBox.Visible = False
        _IMSS_Loading_PictureBox.Enabled = False
    End Sub

    Private Sub _IMSS_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_Close.Click
        If _IMSS_LoadConnectionsWorker.IsBusy = True Then
            _IMSS_LoadConnectionsWorker.CancelAsync()
            Application.Exit()
        Else
            Application.Exit()
        End If
    End Sub
End Class
