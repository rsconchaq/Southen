Public Class ReportePersonaAgrupado
    Dim documento As String
    Private Sub ReportePersonaAgrupado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BDSouthern.p_buscadocumento' Puede moverla o quitarla según sea necesario.
        documento = lbldocumento.Text
        Me.p_buscadocumentoTableAdapter.Fill(Me.BDSouthern.p_buscadocumento, documento)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class