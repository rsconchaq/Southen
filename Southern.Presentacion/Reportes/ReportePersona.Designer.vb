<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReportePersona
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.p_buscadocumentoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDSouthern = New Southern.Presentacion.BDSouthern()
        Me.reportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.p_buscadocumentoTableAdapter = New Southern.Presentacion.BDSouthernTableAdapters.p_buscadocumentoTableAdapter()
        Me.lbltipo = New System.Windows.Forms.Label()
        Me.lbldocumento = New System.Windows.Forms.Label()
        Me.PbuscapersonaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.P_buscapersonaTableAdapter = New Southern.Presentacion.BDSouthernTableAdapters.p_buscapersonaTableAdapter()
        Me.p_buscapersonaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PersonaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.p_buscadocumentoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDSouthern, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbuscapersonaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.p_buscapersonaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PersonaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'p_buscadocumentoBindingSource
        '
        Me.p_buscadocumentoBindingSource.DataMember = "p_buscadocumento"
        Me.p_buscadocumentoBindingSource.DataSource = Me.BDSouthern
        '
        'BDSouthern
        '
        Me.BDSouthern.DataSetName = "BDSouthern"
        Me.BDSouthern.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'reportViewer1
        '
        Me.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.p_buscapersonaBindingSource
        Me.reportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.reportViewer1.LocalReport.ReportEmbeddedResource = "Southern.Presentacion.rptPersona2.rdlc"
        Me.reportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.reportViewer1.Name = "reportViewer1"
        Me.reportViewer1.ServerReport.BearerToken = Nothing
        Me.reportViewer1.Size = New System.Drawing.Size(870, 671)
        Me.reportViewer1.TabIndex = 1
        '
        'p_buscadocumentoTableAdapter
        '
        Me.p_buscadocumentoTableAdapter.ClearBeforeFill = True
        '
        'lbltipo
        '
        Me.lbltipo.AutoSize = True
        Me.lbltipo.BackColor = System.Drawing.Color.Transparent
        Me.lbltipo.ForeColor = System.Drawing.Color.Transparent
        Me.lbltipo.Location = New System.Drawing.Point(858, 50)
        Me.lbltipo.Name = "lbltipo"
        Me.lbltipo.Size = New System.Drawing.Size(0, 13)
        Me.lbltipo.TabIndex = 2
        '
        'lbldocumento
        '
        Me.lbldocumento.AutoSize = True
        Me.lbldocumento.BackColor = System.Drawing.Color.Transparent
        Me.lbldocumento.ForeColor = System.Drawing.Color.Transparent
        Me.lbldocumento.Location = New System.Drawing.Point(915, 46)
        Me.lbldocumento.Name = "lbldocumento"
        Me.lbldocumento.Size = New System.Drawing.Size(0, 13)
        Me.lbldocumento.TabIndex = 3
        '
        'PbuscapersonaBindingSource
        '
        Me.PbuscapersonaBindingSource.DataMember = "p_buscapersona"
        Me.PbuscapersonaBindingSource.DataSource = Me.BDSouthern
        '
        'P_buscapersonaTableAdapter
        '
        Me.P_buscapersonaTableAdapter.ClearBeforeFill = True
        '
        'p_buscapersonaBindingSource
        '
        Me.p_buscapersonaBindingSource.DataMember = "p_buscapersona"
        Me.p_buscapersonaBindingSource.DataSource = Me.BDSouthern
        '
        'PersonaBindingSource
        '
        Me.PersonaBindingSource.DataSource = GetType(Southern.DataContracts.Persona)
        '
        'ReportePersona
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(870, 671)
        Me.Controls.Add(Me.lbldocumento)
        Me.Controls.Add(Me.lbltipo)
        Me.Controls.Add(Me.reportViewer1)
        Me.Name = "ReportePersona"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ReportePersona"
        CType(Me.p_buscadocumentoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDSouthern, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbuscapersonaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.p_buscapersonaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PersonaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents reportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents p_buscadocumentoBindingSource As BindingSource
    Friend WithEvents BDSouthern As BDSouthern
    Friend WithEvents p_buscadocumentoTableAdapter As BDSouthernTableAdapters.p_buscadocumentoTableAdapter
    Public WithEvents lbltipo As Label
    Public WithEvents lbldocumento As Label
    Friend WithEvents PersonaBindingSource As BindingSource
    Friend WithEvents PbuscapersonaBindingSource As BindingSource
    Friend WithEvents P_buscapersonaTableAdapter As BDSouthernTableAdapters.p_buscapersonaTableAdapter
    Friend WithEvents p_buscapersonaBindingSource As BindingSource
End Class
