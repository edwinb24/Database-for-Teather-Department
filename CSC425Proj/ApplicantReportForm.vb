Imports System.Data
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class ApplicantReportForm

    Private Sub ApplicantReportForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim ds As New ApplicantReportDataSet
        Dim Conn As New SqlConnection
        Dim sql As String = "SELECT * FROM StudentReportView"

        Conn = LogInForm.Conn

        Try
            Conn.Open()

            Dim dscmd As New SqlDataAdapter(sql, Conn)
            dscmd.Fill(ds, "ApplicantReport")
            'MsgBox(ds.Tables(1).Rows.Count)
            Conn.Close()

        Catch ex As Exception
            MsgBox("Error: " + ex.Message.ToString)

        Finally
            Conn.Close()
        End Try

        Dim objRpt As New ApplicantReport
        objRpt.SetDataSource(ds.Tables(1))
        CrystalReportViewer1.ReportSource = objRpt
        CrystalReportViewer1.Refresh()
    End Sub
End Class