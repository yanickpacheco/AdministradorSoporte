<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnConsultarInventario = New System.Windows.Forms.Button()
        Me.btnVerSolicitudes = New System.Windows.Forms.Button()
        Me.btnIngresarSolicitud = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Image = Global.Administrador_Soporte.My.Resources.Resources.salida
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(395, 405)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(72, 75)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Salir"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnConsultarInventario
        '
        Me.btnConsultarInventario.Font = New System.Drawing.Font("Comic Sans MS", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsultarInventario.ForeColor = System.Drawing.Color.DodgerBlue
        Me.btnConsultarInventario.Image = Global.Administrador_Soporte.My.Resources.Resources.inventario
        Me.btnConsultarInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnConsultarInventario.Location = New System.Drawing.Point(127, 259)
        Me.btnConsultarInventario.Name = "btnConsultarInventario"
        Me.btnConsultarInventario.Size = New System.Drawing.Size(242, 72)
        Me.btnConsultarInventario.TabIndex = 2
        Me.btnConsultarInventario.Text = "Consultar Inventario"
        Me.btnConsultarInventario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConsultarInventario.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnConsultarInventario.UseVisualStyleBackColor = True
        '
        'btnVerSolicitudes
        '
        Me.btnVerSolicitudes.Font = New System.Drawing.Font("Comic Sans MS", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerSolicitudes.ForeColor = System.Drawing.Color.DodgerBlue
        Me.btnVerSolicitudes.Image = Global.Administrador_Soporte.My.Resources.Resources.encontrar
        Me.btnVerSolicitudes.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnVerSolicitudes.Location = New System.Drawing.Point(127, 174)
        Me.btnVerSolicitudes.Name = "btnVerSolicitudes"
        Me.btnVerSolicitudes.Size = New System.Drawing.Size(242, 64)
        Me.btnVerSolicitudes.TabIndex = 1
        Me.btnVerSolicitudes.Text = "Ver Solicitudes"
        Me.btnVerSolicitudes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVerSolicitudes.UseVisualStyleBackColor = True
        '
        'btnIngresarSolicitud
        '
        Me.btnIngresarSolicitud.Font = New System.Drawing.Font("Comic Sans MS", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIngresarSolicitud.ForeColor = System.Drawing.Color.DodgerBlue
        Me.btnIngresarSolicitud.Image = Global.Administrador_Soporte.My.Resources.Resources.Ingreso_2
        Me.btnIngresarSolicitud.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnIngresarSolicitud.Location = New System.Drawing.Point(127, 89)
        Me.btnIngresarSolicitud.Name = "btnIngresarSolicitud"
        Me.btnIngresarSolicitud.Size = New System.Drawing.Size(242, 67)
        Me.btnIngresarSolicitud.TabIndex = 0
        Me.btnIngresarSolicitud.Text = "Ingresar Solicitud"
        Me.btnIngresarSolicitud.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIngresarSolicitud.UseVisualStyleBackColor = True
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(479, 501)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnConsultarInventario)
        Me.Controls.Add(Me.btnVerSolicitudes)
        Me.Controls.Add(Me.btnIngresarSolicitud)
        Me.MaximizeBox = False
        Me.Name = "frmMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administracion Soporte"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnIngresarSolicitud As Button
    Friend WithEvents btnVerSolicitudes As Button
    Friend WithEvents btnConsultarInventario As Button
    Friend WithEvents Button1 As Button
End Class
