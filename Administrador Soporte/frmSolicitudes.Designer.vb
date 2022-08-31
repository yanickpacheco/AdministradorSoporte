<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSolicitudes
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
        Me.dtgListadoBitacora = New System.Windows.Forms.DataGridView()
        Me.idBitacora = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.piso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipoSolicitud = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.plataforma = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.solicitante = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaIngreso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.observaciones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        CType(Me.dtgListadoBitacora, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Location = New System.Drawing.Point(298, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(183, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Listado Solicitudes"
        '
        'dtgListadoBitacora
        '
        Me.dtgListadoBitacora.AllowUserToAddRows = False
        Me.dtgListadoBitacora.AllowUserToDeleteRows = False
        Me.dtgListadoBitacora.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtgListadoBitacora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgListadoBitacora.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idBitacora, Me.piso, Me.tipoSolicitud, Me.plataforma, Me.solicitante, Me.fechaIngreso, Me.observaciones})
        Me.dtgListadoBitacora.Location = New System.Drawing.Point(30, 154)
        Me.dtgListadoBitacora.Name = "dtgListadoBitacora"
        Me.dtgListadoBitacora.ReadOnly = True
        Me.dtgListadoBitacora.Size = New System.Drawing.Size(744, 255)
        Me.dtgListadoBitacora.TabIndex = 1
        '
        'idBitacora
        '
        Me.idBitacora.DataPropertyName = "IdBitacora"
        Me.idBitacora.HeaderText = "Id"
        Me.idBitacora.Name = "idBitacora"
        Me.idBitacora.ReadOnly = True
        Me.idBitacora.Width = 41
        '
        'piso
        '
        Me.piso.DataPropertyName = "Piso"
        Me.piso.HeaderText = "Piso"
        Me.piso.Name = "piso"
        Me.piso.ReadOnly = True
        Me.piso.Width = 52
        '
        'tipoSolicitud
        '
        Me.tipoSolicitud.DataPropertyName = "TipoSolicitud"
        Me.tipoSolicitud.HeaderText = "Tipo Solicitud"
        Me.tipoSolicitud.Name = "tipoSolicitud"
        Me.tipoSolicitud.ReadOnly = True
        Me.tipoSolicitud.Width = 96
        '
        'plataforma
        '
        Me.plataforma.DataPropertyName = "Plataforma"
        Me.plataforma.HeaderText = "Plataforma"
        Me.plataforma.Name = "plataforma"
        Me.plataforma.ReadOnly = True
        Me.plataforma.Width = 82
        '
        'solicitante
        '
        Me.solicitante.DataPropertyName = "Solicitante"
        Me.solicitante.HeaderText = "Solicitante"
        Me.solicitante.Name = "solicitante"
        Me.solicitante.ReadOnly = True
        Me.solicitante.Width = 81
        '
        'fechaIngreso
        '
        Me.fechaIngreso.DataPropertyName = "FechaIngreso"
        Me.fechaIngreso.HeaderText = "Fecha Ingreso"
        Me.fechaIngreso.Name = "fechaIngreso"
        Me.fechaIngreso.ReadOnly = True
        '
        'observaciones
        '
        Me.observaciones.DataPropertyName = "Observaciones"
        Me.observaciones.HeaderText = "Observaciones"
        Me.observaciones.Name = "observaciones"
        Me.observaciones.ReadOnly = True
        Me.observaciones.Width = 103
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(140, 103)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(98, 20)
        Me.dtpFecha.TabIndex = 2
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblFecha.Location = New System.Drawing.Point(27, 109)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(96, 15)
        Me.lblFecha.TabIndex = 3
        Me.lblFecha.Text = "Filtrar por Fecha:"
        '
        'btnBuscar
        '
        Me.btnBuscar.Font = New System.Drawing.Font("Comic Sans MS", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnBuscar.Location = New System.Drawing.Point(303, 95)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(122, 40)
        Me.btnBuscar.TabIndex = 4
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.Crimson
        Me.btnSalir.Location = New System.Drawing.Point(334, 425)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(91, 36)
        Me.btnSalir.TabIndex = 18
        Me.btnSalir.Text = "Volver"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'frmSolicitudes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 490)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.dtgListadoBitacora)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmSolicitudes"
        Me.Text = "frmSolicitudes"
        CType(Me.dtgListadoBitacora, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dtgListadoBitacora As DataGridView
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents lblFecha As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents idBitacora As DataGridViewTextBoxColumn
    Friend WithEvents piso As DataGridViewTextBoxColumn
    Friend WithEvents tipoSolicitud As DataGridViewTextBoxColumn
    Friend WithEvents plataforma As DataGridViewTextBoxColumn
    Friend WithEvents solicitante As DataGridViewTextBoxColumn
    Friend WithEvents fechaIngreso As DataGridViewTextBoxColumn
    Friend WithEvents observaciones As DataGridViewTextBoxColumn
    Friend WithEvents btnSalir As Button
End Class
