<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Agregar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Agregar))
        Me.LabelInstrucciones = New System.Windows.Forms.Label()
        Me.ComboBoxTipoElemento = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GrpBxCandidato = New System.Windows.Forms.GroupBox()
        Me.GrpBxEmpresa = New System.Windows.Forms.GroupBox()
        Me.GrpBxInvitaciones = New System.Windows.Forms.GroupBox()
        Me.GrpBxOferta = New System.Windows.Forms.GroupBox()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox23 = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.TextBox24 = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.TextBox25 = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.TextBox22 = New System.Windows.Forms.TextBox()
        Me.TextBox26 = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.TextBox27 = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.TextBox28 = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GrpBxGestor = New System.Windows.Forms.GroupBox()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.TextBox15 = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TextBox18 = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TextBox17 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TextBox16 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.TextBox20 = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.TextBox19 = New System.Windows.Forms.TextBox()
        Me.TextBox21 = New System.Windows.Forms.TextBox()
        Me.GrpBxCurriculums = New System.Windows.Forms.GroupBox()
        Me.GrpBxCandidato.SuspendLayout()
        Me.GrpBxEmpresa.SuspendLayout()
        Me.GrpBxInvitaciones.SuspendLayout()
        Me.GrpBxOferta.SuspendLayout()
        Me.GrpBxGestor.SuspendLayout()
        Me.GrpBxCurriculums.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelInstrucciones
        '
        Me.LabelInstrucciones.AutoSize = True
        Me.LabelInstrucciones.ForeColor = System.Drawing.Color.White
        Me.LabelInstrucciones.Location = New System.Drawing.Point(53, 33)
        Me.LabelInstrucciones.Name = "LabelInstrucciones"
        Me.LabelInstrucciones.Size = New System.Drawing.Size(203, 13)
        Me.LabelInstrucciones.TabIndex = 17
        Me.LabelInstrucciones.Text = "Seleccione el tipo de elemento a agregar."
        '
        'ComboBoxTipoElemento
        '
        Me.ComboBoxTipoElemento.FormattingEnabled = True
        Me.ComboBoxTipoElemento.Items.AddRange(New Object() {"Candidato", "Empresa", "GestorEmpresa", "Curriculum", "Invitaciones", "Oferta"})
        Me.ComboBoxTipoElemento.Location = New System.Drawing.Point(81, 49)
        Me.ComboBoxTipoElemento.Name = "ComboBoxTipoElemento"
        Me.ComboBoxTipoElemento.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxTipoElemento.TabIndex = 16
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(19, 51)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 18
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(19, 104)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 20
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(219, 104)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 21
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(392, 51)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 20)
        Me.TextBox5.TabIndex = 22
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(392, 104)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(100, 20)
        Me.TextBox6.TabIndex = 23
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(219, 51)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(34, 17)
        Me.RadioButton1.TabIndex = 24
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "M"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(285, 52)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(31, 17)
        Me.RadioButton2.TabIndex = 25
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "F"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(16, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Mail"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(16, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(17, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "CI"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(216, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Sexo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(216, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Ciudad"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(389, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Rubro"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(389, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Direccion"
        '
        'GrpBxCandidato
        '
        Me.GrpBxCandidato.Controls.Add(Me.TextBox6)
        Me.GrpBxCandidato.Controls.Add(Me.Label6)
        Me.GrpBxCandidato.Controls.Add(Me.TextBox1)
        Me.GrpBxCandidato.Controls.Add(Me.Label5)
        Me.GrpBxCandidato.Controls.Add(Me.TextBox3)
        Me.GrpBxCandidato.Controls.Add(Me.Label4)
        Me.GrpBxCandidato.Controls.Add(Me.TextBox4)
        Me.GrpBxCandidato.Controls.Add(Me.Label3)
        Me.GrpBxCandidato.Controls.Add(Me.TextBox5)
        Me.GrpBxCandidato.Controls.Add(Me.Label2)
        Me.GrpBxCandidato.Controls.Add(Me.RadioButton1)
        Me.GrpBxCandidato.Controls.Add(Me.Label1)
        Me.GrpBxCandidato.Controls.Add(Me.RadioButton2)
        Me.GrpBxCandidato.Location = New System.Drawing.Point(25, 77)
        Me.GrpBxCandidato.Name = "GrpBxCandidato"
        Me.GrpBxCandidato.Size = New System.Drawing.Size(507, 149)
        Me.GrpBxCandidato.TabIndex = 32
        Me.GrpBxCandidato.TabStop = False
        Me.GrpBxCandidato.Text = "Candidato"
        '
        'GrpBxEmpresa
        '
        Me.GrpBxEmpresa.Controls.Add(Me.GrpBxInvitaciones)
        Me.GrpBxEmpresa.Controls.Add(Me.TextBox11)
        Me.GrpBxEmpresa.Controls.Add(Me.Label7)
        Me.GrpBxEmpresa.Controls.Add(Me.TextBox7)
        Me.GrpBxEmpresa.Controls.Add(Me.Label8)
        Me.GrpBxEmpresa.Controls.Add(Me.TextBox8)
        Me.GrpBxEmpresa.Controls.Add(Me.Label9)
        Me.GrpBxEmpresa.Controls.Add(Me.TextBox9)
        Me.GrpBxEmpresa.Controls.Add(Me.Label10)
        Me.GrpBxEmpresa.Controls.Add(Me.TextBox10)
        Me.GrpBxEmpresa.Controls.Add(Me.Label11)
        Me.GrpBxEmpresa.Controls.Add(Me.Label12)
        Me.GrpBxEmpresa.Location = New System.Drawing.Point(0, 0)
        Me.GrpBxEmpresa.Name = "GrpBxEmpresa"
        Me.GrpBxEmpresa.Size = New System.Drawing.Size(507, 149)
        Me.GrpBxEmpresa.TabIndex = 33
        Me.GrpBxEmpresa.TabStop = False
        Me.GrpBxEmpresa.Text = "Empresa"
        '
        'GrpBxInvitaciones
        '
        Me.GrpBxInvitaciones.Controls.Add(Me.GrpBxOferta)
        Me.GrpBxInvitaciones.Controls.Add(Me.RadioButton4)
        Me.GrpBxInvitaciones.Controls.Add(Me.RadioButton3)
        Me.GrpBxInvitaciones.Controls.Add(Me.TextBox22)
        Me.GrpBxInvitaciones.Controls.Add(Me.TextBox26)
        Me.GrpBxInvitaciones.Controls.Add(Me.Label26)
        Me.GrpBxInvitaciones.Controls.Add(Me.TextBox27)
        Me.GrpBxInvitaciones.Controls.Add(Me.Label27)
        Me.GrpBxInvitaciones.Controls.Add(Me.TextBox28)
        Me.GrpBxInvitaciones.Controls.Add(Me.Label28)
        Me.GrpBxInvitaciones.Controls.Add(Me.Label29)
        Me.GrpBxInvitaciones.Controls.Add(Me.Label30)
        Me.GrpBxInvitaciones.Location = New System.Drawing.Point(89, 114)
        Me.GrpBxInvitaciones.Name = "GrpBxInvitaciones"
        Me.GrpBxInvitaciones.Size = New System.Drawing.Size(507, 149)
        Me.GrpBxInvitaciones.TabIndex = 37
        Me.GrpBxInvitaciones.TabStop = False
        Me.GrpBxInvitaciones.Text = "Invitaciones"
        '
        'GrpBxOferta
        '
        Me.GrpBxOferta.Controls.Add(Me.RadioButton5)
        Me.GrpBxOferta.Controls.Add(Me.RadioButton6)
        Me.GrpBxOferta.Controls.Add(Me.TextBox2)
        Me.GrpBxOferta.Controls.Add(Me.TextBox23)
        Me.GrpBxOferta.Controls.Add(Me.Label23)
        Me.GrpBxOferta.Controls.Add(Me.TextBox24)
        Me.GrpBxOferta.Controls.Add(Me.Label24)
        Me.GrpBxOferta.Controls.Add(Me.TextBox25)
        Me.GrpBxOferta.Controls.Add(Me.Label25)
        Me.GrpBxOferta.Controls.Add(Me.Label31)
        Me.GrpBxOferta.Controls.Add(Me.Label32)
        Me.GrpBxOferta.Location = New System.Drawing.Point(136, 138)
        Me.GrpBxOferta.Name = "GrpBxOferta"
        Me.GrpBxOferta.Size = New System.Drawing.Size(507, 149)
        Me.GrpBxOferta.TabIndex = 39
        Me.GrpBxOferta.TabStop = False
        Me.GrpBxOferta.Text = "Oferta"
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(433, 51)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(41, 17)
        Me.RadioButton5.TabIndex = 38
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.Text = "NO"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.Location = New System.Drawing.Point(392, 52)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(35, 17)
        Me.RadioButton6.TabIndex = 37
        Me.RadioButton6.TabStop = True
        Me.RadioButton6.Text = "SI"
        Me.RadioButton6.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(219, 51)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 36
        '
        'TextBox23
        '
        Me.TextBox23.Location = New System.Drawing.Point(19, 51)
        Me.TextBox23.Name = "TextBox23"
        Me.TextBox23.Size = New System.Drawing.Size(100, 20)
        Me.TextBox23.TabIndex = 18
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.ForeColor = System.Drawing.Color.White
        Me.Label23.Location = New System.Drawing.Point(389, 35)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(68, 13)
        Me.Label23.TabIndex = 30
        Me.Label23.Text = "Confirmacion"
        '
        'TextBox24
        '
        Me.TextBox24.Location = New System.Drawing.Point(19, 104)
        Me.TextBox24.Name = "TextBox24"
        Me.TextBox24.Size = New System.Drawing.Size(100, 20)
        Me.TextBox24.TabIndex = 20
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.ForeColor = System.Drawing.Color.White
        Me.Label24.Location = New System.Drawing.Point(216, 88)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(40, 13)
        Me.Label24.TabIndex = 29
        Me.Label24.Text = "Puesto"
        '
        'TextBox25
        '
        Me.TextBox25.Location = New System.Drawing.Point(219, 104)
        Me.TextBox25.Name = "TextBox25"
        Me.TextBox25.Size = New System.Drawing.Size(100, 20)
        Me.TextBox25.TabIndex = 21
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.ForeColor = System.Drawing.Color.White
        Me.Label25.Location = New System.Drawing.Point(216, 35)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(55, 13)
        Me.Label25.TabIndex = 28
        Me.Label25.Text = "Ubicacion"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.ForeColor = System.Drawing.Color.White
        Me.Label31.Location = New System.Drawing.Point(16, 88)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(85, 13)
        Me.Label31.TabIndex = 27
        Me.Label31.Text = "NombreEmpresa"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.ForeColor = System.Drawing.Color.White
        Me.Label32.Location = New System.Drawing.Point(16, 35)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(40, 13)
        Me.Label32.TabIndex = 26
        Me.Label32.Text = "Codigo"
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(433, 55)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(41, 17)
        Me.RadioButton4.TabIndex = 38
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "NO"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(392, 52)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(35, 17)
        Me.RadioButton3.TabIndex = 37
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "SI"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'TextBox22
        '
        Me.TextBox22.Location = New System.Drawing.Point(219, 51)
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.Size = New System.Drawing.Size(100, 20)
        Me.TextBox22.TabIndex = 36
        '
        'TextBox26
        '
        Me.TextBox26.Location = New System.Drawing.Point(19, 51)
        Me.TextBox26.Name = "TextBox26"
        Me.TextBox26.Size = New System.Drawing.Size(100, 20)
        Me.TextBox26.TabIndex = 18
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.ForeColor = System.Drawing.Color.White
        Me.Label26.Location = New System.Drawing.Point(389, 35)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(68, 13)
        Me.Label26.TabIndex = 30
        Me.Label26.Text = "Confirmacion"
        '
        'TextBox27
        '
        Me.TextBox27.Location = New System.Drawing.Point(19, 104)
        Me.TextBox27.Name = "TextBox27"
        Me.TextBox27.Size = New System.Drawing.Size(100, 20)
        Me.TextBox27.TabIndex = 20
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.ForeColor = System.Drawing.Color.White
        Me.Label27.Location = New System.Drawing.Point(216, 88)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(40, 13)
        Me.Label27.TabIndex = 29
        Me.Label27.Text = "Puesto"
        '
        'TextBox28
        '
        Me.TextBox28.Location = New System.Drawing.Point(219, 104)
        Me.TextBox28.Name = "TextBox28"
        Me.TextBox28.Size = New System.Drawing.Size(100, 20)
        Me.TextBox28.TabIndex = 21
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.ForeColor = System.Drawing.Color.White
        Me.Label28.Location = New System.Drawing.Point(216, 35)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(55, 13)
        Me.Label28.TabIndex = 28
        Me.Label28.Text = "Ubicacion"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.ForeColor = System.Drawing.Color.White
        Me.Label29.Location = New System.Drawing.Point(16, 88)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(85, 13)
        Me.Label29.TabIndex = 27
        Me.Label29.Text = "NombreEmpresa"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.ForeColor = System.Drawing.Color.White
        Me.Label30.Location = New System.Drawing.Point(16, 35)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(40, 13)
        Me.Label30.TabIndex = 26
        Me.Label30.Text = "Codigo"
        '
        'TextBox11
        '
        Me.TextBox11.Location = New System.Drawing.Point(219, 51)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(100, 20)
        Me.TextBox11.TabIndex = 32
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(389, 88)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(26, 13)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Mail"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(19, 51)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(100, 20)
        Me.TextBox7.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(389, 35)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 13)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Rubro"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(19, 104)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(100, 20)
        Me.TextBox8.TabIndex = 20
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(216, 88)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 13)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Ciudad"
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(219, 104)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(100, 20)
        Me.TextBox9.TabIndex = 21
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(216, 35)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 13)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "Direccion"
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(392, 51)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(100, 20)
        Me.TextBox10.TabIndex = 22
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(16, 88)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 13)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Nombre"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(16, 35)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(18, 13)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "ID"
        '
        'GrpBxGestor
        '
        Me.GrpBxGestor.Controls.Add(Me.TextBox14)
        Me.GrpBxGestor.Controls.Add(Me.TextBox15)
        Me.GrpBxGestor.Controls.Add(Me.Label17)
        Me.GrpBxGestor.Controls.Add(Me.GrpBxEmpresa)
        Me.GrpBxGestor.Controls.Add(Me.Label18)
        Me.GrpBxGestor.Location = New System.Drawing.Point(56, 76)
        Me.GrpBxGestor.Name = "GrpBxGestor"
        Me.GrpBxGestor.Size = New System.Drawing.Size(507, 149)
        Me.GrpBxGestor.TabIndex = 34
        Me.GrpBxGestor.TabStop = False
        Me.GrpBxGestor.Text = "GestorEmpresa"
        '
        'TextBox14
        '
        Me.TextBox14.Location = New System.Drawing.Point(19, 51)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(100, 20)
        Me.TextBox14.TabIndex = 18
        '
        'TextBox15
        '
        Me.TextBox15.Location = New System.Drawing.Point(19, 104)
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New System.Drawing.Size(100, 20)
        Me.TextBox15.TabIndex = 20
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(16, 88)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(26, 13)
        Me.Label17.TabIndex = 27
        Me.Label17.Text = "Mail"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(16, 35)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(59, 13)
        Me.Label18.TabIndex = 26
        Me.Label18.Text = "IDEmpresa"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(16, 35)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(18, 13)
        Me.Label20.TabIndex = 26
        Me.Label20.Text = "ID"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(16, 88)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(17, 13)
        Me.Label19.TabIndex = 27
        Me.Label19.Text = "CI"
        '
        'TextBox18
        '
        Me.TextBox18.Location = New System.Drawing.Point(392, 51)
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New System.Drawing.Size(100, 20)
        Me.TextBox18.TabIndex = 22
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(216, 35)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(44, 13)
        Me.Label16.TabIndex = 28
        Me.Label16.Text = "Apellido"
        '
        'TextBox17
        '
        Me.TextBox17.Location = New System.Drawing.Point(219, 104)
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New System.Drawing.Size(100, 20)
        Me.TextBox17.TabIndex = 21
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(216, 88)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(44, 13)
        Me.Label15.TabIndex = 29
        Me.Label15.Text = "Nombre"
        '
        'TextBox16
        '
        Me.TextBox16.Location = New System.Drawing.Point(19, 104)
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New System.Drawing.Size(100, 20)
        Me.TextBox16.TabIndex = 20
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(389, 35)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(43, 13)
        Me.Label14.TabIndex = 30
        Me.Label14.Text = "Idiomas"
        '
        'TextBox13
        '
        Me.TextBox13.Location = New System.Drawing.Point(19, 51)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(100, 20)
        Me.TextBox13.TabIndex = 18
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(389, 88)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(58, 13)
        Me.Label13.TabIndex = 31
        Me.Label13.Text = "Educacion"
        '
        'TextBox12
        '
        Me.TextBox12.Location = New System.Drawing.Point(392, 104)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(100, 20)
        Me.TextBox12.TabIndex = 23
        '
        'TextBox20
        '
        Me.TextBox20.Location = New System.Drawing.Point(531, 52)
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Size = New System.Drawing.Size(100, 20)
        Me.TextBox20.TabIndex = 32
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.ForeColor = System.Drawing.Color.White
        Me.Label22.Location = New System.Drawing.Point(528, 36)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(118, 13)
        Me.Label22.TabIndex = 34
        Me.Label22.Text = "Experiencia Profecional"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(528, 89)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(64, 13)
        Me.Label21.TabIndex = 35
        Me.Label21.Text = "Referencias"
        '
        'TextBox19
        '
        Me.TextBox19.Location = New System.Drawing.Point(531, 105)
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New System.Drawing.Size(100, 20)
        Me.TextBox19.TabIndex = 33
        '
        'TextBox21
        '
        Me.TextBox21.Location = New System.Drawing.Point(219, 51)
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Size = New System.Drawing.Size(100, 20)
        Me.TextBox21.TabIndex = 36
        '
        'GrpBxCurriculums
        '
        Me.GrpBxCurriculums.Controls.Add(Me.GrpBxCandidato)
        Me.GrpBxCurriculums.Controls.Add(Me.TextBox21)
        Me.GrpBxCurriculums.Controls.Add(Me.TextBox19)
        Me.GrpBxCurriculums.Controls.Add(Me.Label21)
        Me.GrpBxCurriculums.Controls.Add(Me.Label22)
        Me.GrpBxCurriculums.Controls.Add(Me.TextBox20)
        Me.GrpBxCurriculums.Controls.Add(Me.TextBox12)
        Me.GrpBxCurriculums.Controls.Add(Me.Label13)
        Me.GrpBxCurriculums.Controls.Add(Me.TextBox13)
        Me.GrpBxCurriculums.Controls.Add(Me.Label14)
        Me.GrpBxCurriculums.Controls.Add(Me.TextBox16)
        Me.GrpBxCurriculums.Controls.Add(Me.Label15)
        Me.GrpBxCurriculums.Controls.Add(Me.TextBox17)
        Me.GrpBxCurriculums.Controls.Add(Me.Label16)
        Me.GrpBxCurriculums.Controls.Add(Me.TextBox18)
        Me.GrpBxCurriculums.Controls.Add(Me.Label19)
        Me.GrpBxCurriculums.Controls.Add(Me.Label20)
        Me.GrpBxCurriculums.Location = New System.Drawing.Point(220, 241)
        Me.GrpBxCurriculums.Name = "GrpBxCurriculums"
        Me.GrpBxCurriculums.Size = New System.Drawing.Size(675, 149)
        Me.GrpBxCurriculums.TabIndex = 33
        Me.GrpBxCurriculums.TabStop = False
        Me.GrpBxCurriculums.Text = "Curriculum"
        '
        'Agregar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GrpBxCurriculums)
        Me.Controls.Add(Me.GrpBxGestor)
        Me.Controls.Add(Me.LabelInstrucciones)
        Me.Controls.Add(Me.ComboBoxTipoElemento)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Agregar"
        Me.Text = "Agregar"
        Me.GrpBxCandidato.ResumeLayout(False)
        Me.GrpBxCandidato.PerformLayout()
        Me.GrpBxEmpresa.ResumeLayout(False)
        Me.GrpBxEmpresa.PerformLayout()
        Me.GrpBxInvitaciones.ResumeLayout(False)
        Me.GrpBxInvitaciones.PerformLayout()
        Me.GrpBxOferta.ResumeLayout(False)
        Me.GrpBxOferta.PerformLayout()
        Me.GrpBxGestor.ResumeLayout(False)
        Me.GrpBxGestor.PerformLayout()
        Me.GrpBxCurriculums.ResumeLayout(False)
        Me.GrpBxCurriculums.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelInstrucciones As Label
    Friend WithEvents ComboBoxTipoElemento As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GrpBxCandidato As GroupBox
    Friend WithEvents GrpBxEmpresa As GroupBox
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents GrpBxGestor As GroupBox
    Friend WithEvents TextBox14 As TextBox
    Friend WithEvents TextBox15 As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents GrpBxInvitaciones As GroupBox
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents TextBox22 As TextBox
    Friend WithEvents TextBox26 As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents TextBox27 As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents TextBox28 As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents GrpBxOferta As GroupBox
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents RadioButton6 As RadioButton
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox23 As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents TextBox24 As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents TextBox25 As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents TextBox18 As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents TextBox17 As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TextBox16 As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TextBox13 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents TextBox20 As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents TextBox19 As TextBox
    Friend WithEvents TextBox21 As TextBox
    Friend WithEvents GrpBxCurriculums As GroupBox
End Class
