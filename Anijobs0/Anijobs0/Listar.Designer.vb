<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Listar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Listar))
        Me.LabelInstrucciones = New System.Windows.Forms.Label()
        Me.ComboBoxTipoElemento = New System.Windows.Forms.ComboBox()
        Me.ListViewListadoOfertas = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ListViewListadoEmpresa = New System.Windows.Forms.ListView()
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ListViewListadoInvitacion = New System.Windows.Forms.ListView()
        Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader16 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader17 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader18 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader19 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ListViewListadoCandidato = New System.Windows.Forms.ListView()
        Me.ColumnHeader20 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader21 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader22 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader23 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader24 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader31 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ListViewListadoCurriculum = New System.Windows.Forms.ListView()
        Me.ColumnHeader25 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader26 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader27 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader28 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader29 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader30 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ListViewListadoGestor = New System.Windows.Forms.ListView()
        Me.ColumnHeader36 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader37 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'LabelInstrucciones
        '
        Me.LabelInstrucciones.AutoSize = True
        Me.LabelInstrucciones.ForeColor = System.Drawing.Color.White
        Me.LabelInstrucciones.Location = New System.Drawing.Point(285, 62)
        Me.LabelInstrucciones.Name = "LabelInstrucciones"
        Me.LabelInstrucciones.Size = New System.Drawing.Size(188, 13)
        Me.LabelInstrucciones.TabIndex = 0
        Me.LabelInstrucciones.Text = "Seleccione el tipo de elemento a listar."
        '
        'ComboBoxTipoElemento
        '
        Me.ComboBoxTipoElemento.FormattingEnabled = True
        Me.ComboBoxTipoElemento.Items.AddRange(New Object() {"Candidato", "Empresa", "GestorEmpresa", "Curriculum", "Invitaciones", "Oferta"})
        Me.ComboBoxTipoElemento.Location = New System.Drawing.Point(313, 88)
        Me.ComboBoxTipoElemento.Name = "ComboBoxTipoElemento"
        Me.ComboBoxTipoElemento.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxTipoElemento.TabIndex = 1
        '
        'ListViewListadoOfertas
        '
        Me.ListViewListadoOfertas.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8})
        Me.ListViewListadoOfertas.Location = New System.Drawing.Point(53, 115)
        Me.ListViewListadoOfertas.Name = "ListViewListadoOfertas"
        Me.ListViewListadoOfertas.Size = New System.Drawing.Size(701, 234)
        Me.ListViewListadoOfertas.TabIndex = 3
        Me.ListViewListadoOfertas.UseCompatibleStateImageBehavior = False
        Me.ListViewListadoOfertas.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Numero de Serie"
        Me.ColumnHeader1.Width = 92
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Puesto"
        Me.ColumnHeader2.Width = 82
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Descripcion"
        Me.ColumnHeader3.Width = 133
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Disponibilidad"
        Me.ColumnHeader4.Width = 78
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Requisitos"
        Me.ColumnHeader5.Width = 100
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Sueldo"
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Area"
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Edad Requerida"
        Me.ColumnHeader8.Width = 94
        '
        'ListViewListadoEmpresa
        '
        Me.ListViewListadoEmpresa.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader13})
        Me.ListViewListadoEmpresa.Location = New System.Drawing.Point(53, 115)
        Me.ListViewListadoEmpresa.Name = "ListViewListadoEmpresa"
        Me.ListViewListadoEmpresa.Size = New System.Drawing.Size(701, 234)
        Me.ListViewListadoEmpresa.TabIndex = 4
        Me.ListViewListadoEmpresa.UseCompatibleStateImageBehavior = False
        Me.ListViewListadoEmpresa.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Id"
        Me.ColumnHeader9.Width = 92
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Nombre"
        Me.ColumnHeader10.Width = 114
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Direccion"
        Me.ColumnHeader11.Width = 121
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Ciudad"
        Me.ColumnHeader12.Width = 78
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Rubro"
        Me.ColumnHeader13.Width = 151
        '
        'ListViewListadoInvitacion
        '
        Me.ListViewListadoInvitacion.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader15, Me.ColumnHeader16, Me.ColumnHeader17, Me.ColumnHeader18, Me.ColumnHeader19})
        Me.ListViewListadoInvitacion.Location = New System.Drawing.Point(53, 115)
        Me.ListViewListadoInvitacion.Name = "ListViewListadoInvitacion"
        Me.ListViewListadoInvitacion.Size = New System.Drawing.Size(701, 234)
        Me.ListViewListadoInvitacion.TabIndex = 5
        Me.ListViewListadoInvitacion.UseCompatibleStateImageBehavior = False
        Me.ListViewListadoInvitacion.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "Codigo"
        Me.ColumnHeader15.Width = 92
        '
        'ColumnHeader16
        '
        Me.ColumnHeader16.Text = "Nombre Empresa"
        Me.ColumnHeader16.Width = 158
        '
        'ColumnHeader17
        '
        Me.ColumnHeader17.Text = "Ubicacion"
        Me.ColumnHeader17.Width = 121
        '
        'ColumnHeader18
        '
        Me.ColumnHeader18.Text = "Puesto"
        Me.ColumnHeader18.Width = 176
        '
        'ColumnHeader19
        '
        Me.ColumnHeader19.Text = "Confirmacion"
        Me.ColumnHeader19.Width = 151
        '
        'ListViewListadoCandidato
        '
        Me.ListViewListadoCandidato.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader20, Me.ColumnHeader21, Me.ColumnHeader22, Me.ColumnHeader23, Me.ColumnHeader24, Me.ColumnHeader31})
        Me.ListViewListadoCandidato.Location = New System.Drawing.Point(53, 115)
        Me.ListViewListadoCandidato.Name = "ListViewListadoCandidato"
        Me.ListViewListadoCandidato.Size = New System.Drawing.Size(701, 234)
        Me.ListViewListadoCandidato.TabIndex = 6
        Me.ListViewListadoCandidato.UseCompatibleStateImageBehavior = False
        Me.ListViewListadoCandidato.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader20
        '
        Me.ColumnHeader20.Text = "Cedula"
        Me.ColumnHeader20.Width = 92
        '
        'ColumnHeader21
        '
        Me.ColumnHeader21.Text = "Mail"
        Me.ColumnHeader21.Width = 98
        '
        'ColumnHeader22
        '
        Me.ColumnHeader22.Text = "Sexo"
        Me.ColumnHeader22.Width = 121
        '
        'ColumnHeader23
        '
        Me.ColumnHeader23.Text = "Rubro"
        Me.ColumnHeader23.Width = 176
        '
        'ColumnHeader24
        '
        Me.ColumnHeader24.Text = "Ciudad"
        Me.ColumnHeader24.Width = 106
        '
        'ColumnHeader31
        '
        Me.ColumnHeader31.Text = "Direccion"
        Me.ColumnHeader31.Width = 104
        '
        'ListViewListadoCurriculum
        '
        Me.ListViewListadoCurriculum.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader25, Me.ColumnHeader26, Me.ColumnHeader27, Me.ColumnHeader28, Me.ColumnHeader29, Me.ColumnHeader30})
        Me.ListViewListadoCurriculum.Location = New System.Drawing.Point(53, 115)
        Me.ListViewListadoCurriculum.Name = "ListViewListadoCurriculum"
        Me.ListViewListadoCurriculum.Size = New System.Drawing.Size(701, 234)
        Me.ListViewListadoCurriculum.TabIndex = 7
        Me.ListViewListadoCurriculum.UseCompatibleStateImageBehavior = False
        Me.ListViewListadoCurriculum.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader25
        '
        Me.ColumnHeader25.Text = "Codigo"
        Me.ColumnHeader25.Width = 92
        '
        'ColumnHeader26
        '
        Me.ColumnHeader26.Text = "Mail"
        Me.ColumnHeader26.Width = 158
        '
        'ColumnHeader27
        '
        Me.ColumnHeader27.Text = "CI"
        Me.ColumnHeader27.Width = 121
        '
        'ColumnHeader28
        '
        Me.ColumnHeader28.Text = "Apellido"
        Me.ColumnHeader28.Width = 126
        '
        'ColumnHeader29
        '
        Me.ColumnHeader29.Text = "Nombre"
        Me.ColumnHeader29.Width = 120
        '
        'ColumnHeader30
        '
        Me.ColumnHeader30.Text = "Idioma"
        Me.ColumnHeader30.Width = 80
        '
        'ListViewListadoGestor
        '
        Me.ListViewListadoGestor.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader36, Me.ColumnHeader37})
        Me.ListViewListadoGestor.Location = New System.Drawing.Point(53, 115)
        Me.ListViewListadoGestor.Name = "ListViewListadoGestor"
        Me.ListViewListadoGestor.Size = New System.Drawing.Size(701, 234)
        Me.ListViewListadoGestor.TabIndex = 8
        Me.ListViewListadoGestor.UseCompatibleStateImageBehavior = False
        Me.ListViewListadoGestor.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader36
        '
        Me.ColumnHeader36.Text = "Mail"
        Me.ColumnHeader36.Width = 230
        '
        'ColumnHeader37
        '
        Me.ColumnHeader37.Text = "Empresa"
        Me.ColumnHeader37.Width = 198
        '
        'Listar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ListViewListadoGestor)
        Me.Controls.Add(Me.ListViewListadoCurriculum)
        Me.Controls.Add(Me.ListViewListadoCandidato)
        Me.Controls.Add(Me.ListViewListadoInvitacion)
        Me.Controls.Add(Me.ListViewListadoEmpresa)
        Me.Controls.Add(Me.ListViewListadoOfertas)
        Me.Controls.Add(Me.ComboBoxTipoElemento)
        Me.Controls.Add(Me.LabelInstrucciones)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Listar"
        Me.Text = "Listar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelInstrucciones As Label
    Friend WithEvents ComboBoxTipoElemento As ComboBox
    Friend WithEvents ListViewListadoOfertas As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ListViewListadoEmpresa As ListView
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents ColumnHeader12 As ColumnHeader
    Friend WithEvents ColumnHeader13 As ColumnHeader
    Friend WithEvents ListViewListadoInvitacion As ListView
    Friend WithEvents ColumnHeader15 As ColumnHeader
    Friend WithEvents ColumnHeader16 As ColumnHeader
    Friend WithEvents ColumnHeader17 As ColumnHeader
    Friend WithEvents ColumnHeader18 As ColumnHeader
    Friend WithEvents ColumnHeader19 As ColumnHeader
    Friend WithEvents ListViewListadoCandidato As ListView
    Friend WithEvents ColumnHeader20 As ColumnHeader
    Friend WithEvents ColumnHeader21 As ColumnHeader
    Friend WithEvents ColumnHeader22 As ColumnHeader
    Friend WithEvents ColumnHeader23 As ColumnHeader
    Friend WithEvents ColumnHeader24 As ColumnHeader
    Friend WithEvents ListViewListadoCurriculum As ListView
    Friend WithEvents ColumnHeader25 As ColumnHeader
    Friend WithEvents ColumnHeader26 As ColumnHeader
    Friend WithEvents ColumnHeader27 As ColumnHeader
    Friend WithEvents ColumnHeader28 As ColumnHeader
    Friend WithEvents ColumnHeader29 As ColumnHeader
    Friend WithEvents ColumnHeader30 As ColumnHeader
    Friend WithEvents ListViewListadoGestor As ListView
    Friend WithEvents ColumnHeader36 As ColumnHeader
    Friend WithEvents ColumnHeader37 As ColumnHeader
    Friend WithEvents ColumnHeader31 As ColumnHeader
End Class
