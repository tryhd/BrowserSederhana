Public Class Form1
    Dim a As New zoom
    Dim InitialZoom As Integer = 100
    Public Enum Exec
        OLECMDID_OPTICAL_ZOOM = 63
    End Enum
    Private Enum execOpt
        OLECMDEXECOPT_DODEFAULT = 0
        OLECMDEXECOPT_PROMPTUSER = 1
        OLECMDEXECOPT_DONTPROMPTUSER = 2
        OLECMDEXECOPT_SHOWHELP = 3
    End Enum
    Public Sub PerformZoom(ByVal Value As Integer)
        Try
            Dim Res As Object = Nothing
            Dim MyWeb As Object
            MyWeb = CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).ActiveXInstance
            MyWeb.ExecWB(Exec.OLECMDID_OPTICAL_ZOOM, execOpt.OLECMDEXECOPT_PROMPTUSER, CObj(Value), CObj(IntPtr.Zero))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate(TextBox1.Text)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        TextBox1.Text = WebBrowser1.Url.ToString
    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate(TextBox1.Text)
            e.SuppressKeyPress = True
        End If
        If e.KeyCode = Keys.F5 Then
            CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Refresh(TextBox1.Text)
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).GoBack()
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Refresh(TextBox1.Text)

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Stop()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Try
            Dim tab As New TabPage
            Dim brws As New WebBrowser
            brws.Dock = DockStyle.Fill
            tab.Text = "New Tab"
            tab.Controls.Add(brws)
            Me.TabControl1.TabPages.Add(tab)
            Me.TabControl1.SelectedTab = tab
            brws.Navigate("")


        Catch ex As Exception

        End Try
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim tab As New TabPage
            Dim brws As New WebBrowser
            brws.Dock = DockStyle.Fill
            tab.Text = " New Tab"
            tab.Controls.Add(brws)
            Me.TabControl1.TabPages.Add(tab)
            Me.TabControl1.SelectedTab = tab
            brws.Navigate("")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        TabControl1.Controls.Remove(TabControl1.SelectedTab)
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        a.zoom()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        a.zoomout()
    End Sub
End Class
