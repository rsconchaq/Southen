<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PersonaDetalle
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
        Me.menuStrip = New System.Windows.Forms.MenuStrip()
        Me.Grabar = New System.Windows.Forms.ToolStripMenuItem()
        Me.Eliminar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Salir = New System.Windows.Forms.ToolStripMenuItem()
        Me.tabControl1 = New System.Windows.Forms.TabControl()
        Me.tabPage2 = New System.Windows.Forms.TabPage()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbEstado = New System.Windows.Forms.ComboBox()
        Me.mtxtEdad = New System.Windows.Forms.MaskedTextBox()
        Me.label11 = New System.Windows.Forms.Label()
        Me.txtNumDocumento = New System.Windows.Forms.TextBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.cbTipoDocumento = New System.Windows.Forms.ComboBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtIdPersona = New System.Windows.Forms.TextBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.lbldni = New System.Windows.Forms.Label()
        Me.menuStrip.SuspendLayout()
        Me.tabControl1.SuspendLayout()
        Me.tabPage2.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'menuStrip
        '
        Me.menuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Grabar, Me.Eliminar, Me.ExportarToolStripMenuItem, Me.Salir})
        Me.menuStrip.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip.Name = "menuStrip"
        Me.menuStrip.Size = New System.Drawing.Size(587, 24)
        Me.menuStrip.TabIndex = 8
        Me.menuStrip.Text = "MenuStrip"
        '
        'Grabar
        '
        Me.Grabar.Name = "Grabar"
        Me.Grabar.Size = New System.Drawing.Size(54, 20)
        Me.Grabar.Text = "Grabar"
        '
        'Eliminar
        '
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Size = New System.Drawing.Size(62, 20)
        Me.Eliminar.Text = "Eliminar"
        '
        'ExportarToolStripMenuItem
        '
        Me.ExportarToolStripMenuItem.Name = "ExportarToolStripMenuItem"
        Me.ExportarToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.ExportarToolStripMenuItem.Text = "Exportar"
        '
        'Salir
        '
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(41, 20)
        Me.Salir.Text = "Salir"
        '
        'tabControl1
        '
        Me.tabControl1.Controls.Add(Me.tabPage2)
        Me.tabControl1.Location = New System.Drawing.Point(12, 25)
        Me.tabControl1.Name = "tabControl1"
        Me.tabControl1.SelectedIndex = 0
        Me.tabControl1.Size = New System.Drawing.Size(482, 381)
        Me.tabControl1.TabIndex = 9
        '
        'tabPage2
        '
        Me.tabPage2.Controls.Add(Me.groupBox1)
        Me.tabPage2.Location = New System.Drawing.Point(4, 22)
        Me.tabPage2.Name = "tabPage2"
        Me.tabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage2.Size = New System.Drawing.Size(474, 355)
        Me.tabPage2.TabIndex = 1
        Me.tabPage2.Text = "Mantenimiento"
        Me.tabPage2.UseVisualStyleBackColor = True
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.Label1)
        Me.groupBox1.Controls.Add(Me.cbEstado)
        Me.groupBox1.Controls.Add(Me.mtxtEdad)
        Me.groupBox1.Controls.Add(Me.label11)
        Me.groupBox1.Controls.Add(Me.txtNumDocumento)
        Me.groupBox1.Controls.Add(Me.label6)
        Me.groupBox1.Controls.Add(Me.cbTipoDocumento)
        Me.groupBox1.Controls.Add(Me.txtApellido)
        Me.groupBox1.Controls.Add(Me.label4)
        Me.groupBox1.Controls.Add(Me.txtNombre)
        Me.groupBox1.Controls.Add(Me.txtIdPersona)
        Me.groupBox1.Controls.Add(Me.label5)
        Me.groupBox1.Controls.Add(Me.label3)
        Me.groupBox1.Location = New System.Drawing.Point(6, 14)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(477, 226)
        Me.groupBox1.TabIndex = 0
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Persona"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 168)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Estado"
        '
        'cbEstado
        '
        Me.cbEstado.FormattingEnabled = True
        Me.cbEstado.Items.AddRange(New Object() {"Activo", "Desactivo"})
        Me.cbEstado.Location = New System.Drawing.Point(100, 165)
        Me.cbEstado.Name = "cbEstado"
        Me.cbEstado.Size = New System.Drawing.Size(85, 21)
        Me.cbEstado.TabIndex = 26
        Me.cbEstado.Text = "Activo"
        '
        'mtxtEdad
        '
        Me.mtxtEdad.Location = New System.Drawing.Point(100, 139)
        Me.mtxtEdad.Mask = "999"
        Me.mtxtEdad.Name = "mtxtEdad"
        Me.mtxtEdad.Size = New System.Drawing.Size(85, 20)
        Me.mtxtEdad.TabIndex = 25
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.Location = New System.Drawing.Point(6, 139)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(35, 13)
        Me.label11.TabIndex = 24
        Me.label11.Text = "Edad:"
        '
        'txtNumDocumento
        '
        Me.txtNumDocumento.Location = New System.Drawing.Point(191, 112)
        Me.txtNumDocumento.Name = "txtNumDocumento"
        Me.txtNumDocumento.Size = New System.Drawing.Size(177, 20)
        Me.txtNumDocumento.TabIndex = 19
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(6, 115)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(89, 13)
        Me.label6.TabIndex = 18
        Me.label6.Text = "Tipo Documento:"
        '
        'cbTipoDocumento
        '
        Me.cbTipoDocumento.FormattingEnabled = True
        Me.cbTipoDocumento.Items.AddRange(New Object() {"DNI", "RUC"})
        Me.cbTipoDocumento.Location = New System.Drawing.Point(100, 112)
        Me.cbTipoDocumento.Name = "cbTipoDocumento"
        Me.cbTipoDocumento.Size = New System.Drawing.Size(85, 21)
        Me.cbTipoDocumento.TabIndex = 17
        Me.cbTipoDocumento.Text = "DNI"
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(100, 86)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(268, 20)
        Me.txtApellido.TabIndex = 13
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(6, 89)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(47, 13)
        Me.label4.TabIndex = 12
        Me.label4.Text = "Apellido:"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(100, 60)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(268, 20)
        Me.txtNombre.TabIndex = 5
        '
        'txtIdPersona
        '
        Me.txtIdPersona.Enabled = False
        Me.txtIdPersona.Location = New System.Drawing.Point(100, 34)
        Me.txtIdPersona.Name = "txtIdPersona"
        Me.txtIdPersona.Size = New System.Drawing.Size(85, 20)
        Me.txtIdPersona.TabIndex = 4
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(6, 63)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(47, 13)
        Me.label5.TabIndex = 3
        Me.label5.Text = "Nombre:"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(6, 37)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(43, 13)
        Me.label3.TabIndex = 2
        Me.label3.Text = "Código:"
        '
        'lbldni
        '
        Me.lbldni.AutoSize = True
        Me.lbldni.ForeColor = System.Drawing.SystemColors.Control
        Me.lbldni.Location = New System.Drawing.Point(536, 79)
        Me.lbldni.Name = "lbldni"
        Me.lbldni.Size = New System.Drawing.Size(0, 13)
        Me.lbldni.TabIndex = 10
        '
        'PersonaDetalle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(587, 333)
        Me.ControlBox = False
        Me.Controls.Add(Me.lbldni)
        Me.Controls.Add(Me.tabControl1)
        Me.Controls.Add(Me.menuStrip)
        Me.Name = "PersonaDetalle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PersonaDetalle"
        Me.menuStrip.ResumeLayout(False)
        Me.menuStrip.PerformLayout()
        Me.tabControl1.ResumeLayout(False)
        Me.tabPage2.ResumeLayout(False)
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents menuStrip As MenuStrip
    Private WithEvents Grabar As ToolStripMenuItem
    Friend WithEvents Eliminar As ToolStripMenuItem
    Friend WithEvents Salir As ToolStripMenuItem
    Private WithEvents tabControl1 As TabControl
    Private WithEvents tabPage2 As TabPage
    Private WithEvents groupBox1 As GroupBox
    Private WithEvents Label1 As Label
    Public WithEvents cbEstado As ComboBox
    Public WithEvents mtxtEdad As MaskedTextBox
    Private WithEvents label11 As Label
    Public WithEvents txtNumDocumento As TextBox
    Private WithEvents label6 As Label
    Public WithEvents cbTipoDocumento As ComboBox
    Public WithEvents txtApellido As TextBox
    Private WithEvents label4 As Label
    Public WithEvents txtNombre As TextBox
    Public WithEvents txtIdPersona As TextBox
    Private WithEvents label5 As Label
    Private WithEvents label3 As Label
    Friend WithEvents ExportarToolStripMenuItem As ToolStripMenuItem
    Public WithEvents lbldni As Label
End Class
