<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportePersonaAgrupado
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.BDSouthern = New Southern.Presentacion.BDSouthern()
        Me.p_buscadocumentoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.p_buscadocumentoTableAdapter = New Southern.Presentacion.BDSouthernTableAdapters.p_buscadocumentoTableAdapter()
        Me.lbldocumento = New System.Windows.Forms.Label()
        CType(Me.BDSouthern, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.p_buscadocumentoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.p_buscadocumentoBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Southern.Presentacion.rptAgrupado.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(772, 450)
        Me.ReportViewer1.TabIndex = 0
        '
        'BDSouthern
        '
        Me.BDSouthern.DataSetName = "BDSouthern"
        Me.BDSouthern.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'p_buscadocumentoBindingSource
        '
        Me.p_buscadocumentoBindingSource.DataMember = "p_buscadocumento"
        Me.p_buscadocumentoBindingSource.DataSource = Me.BDSouthern
        '
        'p_buscadocumentoTableAdapter
        '
        Me.p_buscadocumentoTableAdapter.ClearBeforeFill = True
        '
        'lbldocumento
        '
        Me.lbldocumento.AutoSize = True
        Me.lbldocumento.ForeColor = System.Drawing.SystemColors.Control
        Me.lbldocumento.Location = New System.Drawing.Point(788, 19)
        Me.lbldocumento.Name = "lbldocumento"
        Me.lbldocumento.Size = New System.Drawing.Size(0, 13)
        Me.lbldocumento.TabIndex = 1
        '
        'ReportePersonaAgrupado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(772, 450)
        Me.Controls.Add(Me.lbldocumento)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "ReportePersonaAgrupado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ReportePersonaAgrupado"
        CType(Me.BDSouthern, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.p_buscadocumentoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents p_buscadocumentoBindingSource As BindingSource
    Friend WithEvents BDSouthern As BDSouthern
    Friend WithEvents p_buscadocumentoTableAdapter As BDSouthernTableAdapters.p_buscadocumentoTableAdapter
    Public WithEvents lbldocumento As Label
End Class
