Public Class zoom
    Dim InitialZoom As Integer = 100
    Public Sub zoom()
        InitialZoom += 10
        PerformZoom(InitialZoom)
    End Sub
    Public Sub zoomout()
        InitialZoom -= 10
        PerformZoom(InitialZoom)
    End Sub
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
            MyWeb = CType(Form1.TabControl1.SelectedTab.Controls.Item(0), WebBrowser).ActiveXInstance
            MyWeb.ExecWB(Exec.OLECMDID_OPTICAL_ZOOM, execOpt.OLECMDEXECOPT_PROMPTUSER, CObj(Value), CObj(IntPtr.Zero))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
