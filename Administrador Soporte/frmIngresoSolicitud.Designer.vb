<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIngresoSolicitud
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbPiso = New System.Windows.Forms.ComboBox()
        Me.cmbTipoSolicitud = New System.Windows.Forms.ComboBox()
        Me.cmbPlataforma = New System.Windows.Forms.ComboBox()
        Me.cmbSolicitante = New System.Windows.Forms.ComboBox()
        Me.dtFecha = New System.Windows.Forms.DateTimePicker()
        Me.txtObs = New System.Windows.Forms.TextBox()
        Me.btnGestión = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.cmbInsumo = New System.Windows.Forms.ComboBox()
        Me.lblInsumo = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 15.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Location = New System.Drawing.Point(162, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bitacora Cambios"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label2.Location = New System.Drawing.Point(77, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Piso:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label3.Location = New System.Drawing.Point(77, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tipo Solicitud:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label4.Location = New System.Drawing.Point(77, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Plataforma:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label5.Location = New System.Drawing.Point(77, 184)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Solicitante:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label6.Location = New System.Drawing.Point(77, 242)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Fecha y Hora:"
        Me.Label6.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label7.Location = New System.Drawing.Point(79, 281)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 17)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Observaciones:"
        '
        'cmbPiso
        '
        Me.cmbPiso.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPiso.ForeColor = System.Drawing.SystemColors.Highlight
        Me.cmbPiso.FormattingEnabled = True
        Me.cmbPiso.Items.AddRange(New Object() {"[Seleccione]", "PISO 5", "PISO 7"})
        Me.cmbPiso.Location = New System.Drawing.Point(180, 79)
        Me.cmbPiso.Name = "cmbPiso"
        Me.cmbPiso.Size = New System.Drawing.Size(145, 23)
        Me.cmbPiso.TabIndex = 1
        '
        'cmbTipoSolicitud
        '
        Me.cmbTipoSolicitud.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipoSolicitud.ForeColor = System.Drawing.SystemColors.Highlight
        Me.cmbTipoSolicitud.FormattingEnabled = True
        Me.cmbTipoSolicitud.Location = New System.Drawing.Point(180, 119)
        Me.cmbTipoSolicitud.Name = "cmbTipoSolicitud"
        Me.cmbTipoSolicitud.Size = New System.Drawing.Size(145, 23)
        Me.cmbTipoSolicitud.TabIndex = 2
        '
        'cmbPlataforma
        '
        Me.cmbPlataforma.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPlataforma.ForeColor = System.Drawing.SystemColors.Highlight
        Me.cmbPlataforma.FormattingEnabled = True
        Me.cmbPlataforma.Location = New System.Drawing.Point(180, 150)
        Me.cmbPlataforma.Name = "cmbPlataforma"
        Me.cmbPlataforma.Size = New System.Drawing.Size(145, 23)
        Me.cmbPlataforma.TabIndex = 3
        '
        'cmbSolicitante
        '
        Me.cmbSolicitante.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSolicitante.ForeColor = System.Drawing.SystemColors.Highlight
        Me.cmbSolicitante.FormattingEnabled = True
        Me.cmbSolicitante.Location = New System.Drawing.Point(180, 179)
        Me.cmbSolicitante.Name = "cmbSolicitante"
        Me.cmbSolicitante.Size = New System.Drawing.Size(145, 23)
        Me.cmbSolicitante.TabIndex = 4
        '
        'dtFecha
        '
        Me.dtFecha.Location = New System.Drawing.Point(180, 240)
        Me.dtFecha.Name = "dtFecha"
        Me.dtFecha.Size = New System.Drawing.Size(200, 20)
        Me.dtFecha.TabIndex = 5
        Me.dtFecha.Visible = False
        '
        'txtObs
        '
        Me.txtObs.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObs.ForeColor = System.Drawing.SystemColors.Highlight
        Me.txtObs.Location = New System.Drawing.Point(180, 276)
        Me.txtObs.Multiline = True
        Me.txtObs.Name = "txtObs"
        Me.txtObs.Size = New System.Drawing.Size(253, 65)
        Me.txtObs.TabIndex = 6
        '
        'btnGestión
        '
        Me.btnGestión.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGestión.ForeColor = System.Drawing.SystemColors.Highlight
        Me.btnGestión.Location = New System.Drawing.Point(164, 372)
        Me.btnGestión.Name = "btnGestión"
        Me.btnGestión.Size = New System.Drawing.Size(170, 41)
        Me.btnGestión.TabIndex = 15
        Me.btnGestión.Text = "Agregar Gestion"
        Me.btnGestión.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.Crimson
        Me.btnSalir.Location = New System.Drawing.Point(204, 419)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(91, 36)
        Me.btnSalir.TabIndex = 16
        Me.btnSalir.Text = "Volver"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'cmbInsumo
        '
        Me.cmbInsumo.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbInsumo.ForeColor = System.Drawing.SystemColors.Highlight
        Me.cmbInsumo.FormattingEnabled = True
        Me.cmbInsumo.Location = New System.Drawing.Point(180, 211)
        Me.cmbInsumo.Name = "cmbInsumo"
        Me.cmbInsumo.Size = New System.Drawing.Size(145, 23)
        Me.cmbInsumo.TabIndex = 17
        '
        'lblInsumo
        '
        Me.lblInsumo.AutoSize = True
        Me.lblInsumo.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInsumo.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblInsumo.Location = New System.Drawing.Point(79, 213)
        Me.lblInsumo.Name = "lblInsumo"
        Me.lblInsumo.Size = New System.Drawing.Size(51, 17)
        Me.lblInsumo.TabIndex = 18
        Me.lblInsumo.Text = "Insumo:"
        '
        'txtCantidad
        '
        Me.txtCantidad.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidad.ForeColor = System.Drawing.SystemColors.Highlight
        Me.txtCantidad.Location = New System.Drawing.Point(398, 209)
        Me.txtCantidad.Multiline = True
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(57, 25)
        Me.txtCantidad.TabIndex = 19
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidad.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblCantidad.Location = New System.Drawing.Point(333, 213)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(59, 17)
        Me.lblCantidad.TabIndex = 20
        Me.lblCantidad.Text = "Cantidad:"
        '
        'frmIngresoSolicitud
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(487, 493)
        Me.Controls.Add(Me.lblCantidad)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.cmbInsumo)
        Me.Controls.Add(Me.lblInsumo)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGestión)
        Me.Controls.Add(Me.txtObs)
        Me.Controls.Add(Me.dtFecha)
        Me.Controls.Add(Me.cmbSolicitante)
        Me.Controls.Add(Me.cmbPlataforma)
        Me.Controls.Add(Me.cmbTipoSolicitud)
        Me.Controls.Add(Me.cmbPiso)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmIngresoSolicitud"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmIngresoSolicitud"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cmbPiso As ComboBox
    Friend WithEvents cmbTipoSolicitud As ComboBox
    Friend WithEvents cmbPlataforma As ComboBox
    Friend WithEvents cmbSolicitante As ComboBox
    Friend WithEvents dtFecha As DateTimePicker
    Friend WithEvents txtObs As TextBox
    Friend WithEvents btnGestión As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents cmbInsumo As ComboBox
    Friend WithEvents lblInsumo As Label
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents lblCantidad As Label
End Class
