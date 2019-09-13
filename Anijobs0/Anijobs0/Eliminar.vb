Public Class Eliminar


    Private Sub ComboBoxTipoElemento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxTipoElemento.SelectedIndexChanged

        ListViewListadoCandidato.Items.Clear()
        ListViewListadoCurriculum.Items.Clear()
        ListViewListadoEmpresa.Items.Clear()
        ListViewListadoGestor.Items.Clear()
        ListViewListadoInvitacion.Items.Clear()
        ListViewListadoOfertas.Items.Clear()

        Select Case (ComboBoxTipoElemento.SelectedItem.ToString)

            Case "Candidato"
                ListViewListadoCandidato.Visible = True
                ListViewListadoCurriculum.Visible = False
                ListViewListadoEmpresa.Visible = False
                ListViewListadoGestor.Visible = False
                ListViewListadoInvitacion.Visible = False
                ListViewListadoOfertas.Visible = False
                TextBox1.Visible = True
                TextBox2.Visible = True
                TextBox3.Visible = False


            Case "Curriculum"
                ListViewListadoCandidato.Visible = False
                ListViewListadoCurriculum.Visible = True
                ListViewListadoEmpresa.Visible = False
                ListViewListadoGestor.Visible = False
                ListViewListadoInvitacion.Visible = False
                ListViewListadoOfertas.Visible = False
                TextBox1.Visible = True
                TextBox2.Visible = True
                TextBox3.Visible = True

            Case "Empresa"
                ListViewListadoCandidato.Visible = False
                ListViewListadoCurriculum.Visible = False
                ListViewListadoEmpresa.Visible = True
                ListViewListadoGestor.Visible = False
                ListViewListadoInvitacion.Visible = False
                ListViewListadoOfertas.Visible = False
                TextBox1.Visible = True
                TextBox2.Visible = False
                TextBox3.Visible = False

            Case "GestorEmpresa"
                ListViewListadoCandidato.Visible = False
                ListViewListadoCurriculum.Visible = False
                ListViewListadoEmpresa.Visible = False
                ListViewListadoGestor.Visible = True
                ListViewListadoInvitacion.Visible = False
                ListViewListadoOfertas.Visible = False
                TextBox1.Visible = True
                TextBox2.Visible = True
                TextBox3.Visible = False

            Case "Invitaciones"
                ListViewListadoCandidato.Visible = False
                ListViewListadoCurriculum.Visible = False
                ListViewListadoEmpresa.Visible = False
                ListViewListadoGestor.Visible = False
                ListViewListadoInvitacion.Visible = True
                ListViewListadoOfertas.Visible = False
                TextBox1.Visible = True
                TextBox2.Visible = False
                TextBox3.Visible = False

            Case "Oferta"
                ListViewListadoCandidato.Visible = False
                ListViewListadoCurriculum.Visible = False
                ListViewListadoEmpresa.Visible = False
                ListViewListadoGestor.Visible = False
                ListViewListadoInvitacion.Visible = False
                ListViewListadoOfertas.Visible = True
                TextBox1.Visible = True
                TextBox2.Visible = False
                TextBox3.Visible = False


        End Select

        Select Case (ComboBoxTipoElemento.SelectedItem.ToString)

            Case "Candidato"
                Funciones1.Listar(6, ComboBoxTipoElemento, ListViewListadoGestor, "SELECT * FROM candidato")

            Case "Curriculum"
                Funciones1.Listar(9, ComboBoxTipoElemento, ListViewListadoCurriculum, "SELECT * FROM curriculum")

            Case "Empresa"
                Funciones1.Listar(6, ComboBoxTipoElemento, ListViewListadoEmpresa, "SELECT * FROM empresa")

            Case "GestorEmpresa"
                Funciones1.Listar(2, ComboBoxTipoElemento, ListViewListadoGestor, "SELECT * FROM gestorempresa")

            Case "Invitaciones"
                Funciones1.Listar(5, ComboBoxTipoElemento, ListViewListadoInvitacion, "SELECT * FROM invitaciones")

            Case "Ofertas"
                Funciones1.Listar(8, ComboBoxTipoElemento, ListViewListadoOfertas, "SELECT * FROM oferta")
                'buscar solucion para cuando no se selecciona el combo box
                ' Case ""
                '    LabelError.Text = "Porfabor seleccione una Opcion antes de Listar"

        End Select


    End Sub

    Private Sub ButtonEliminar_Click(sender As Object, e As EventArgs) Handles ButtonEliminar.Click

        Select Case (ComboBoxTipoElemento.SelectedItem.ToString)

            Case "Candidato"
                Funciones1.Eliminar(ComboBoxTipoElemento, "DELETE FROM candidato where mail = @valorid1", LabelError, TextBox1)

            Case "Curriculum"
                Funciones1.Eliminar(ComboBoxTipoElemento, "DELETE FROM curriculum where idCurriculum = @valorid1 and ci = @valorid3 and mail = @valorid2", LabelError, TextBox1, TextBox2, TextBox3)

            Case "Empresa"
                Funciones1.Eliminar(ComboBoxTipoElemento, "DELETE FROM empresa where idEmpresa = @valorid1", LabelError, TextBox1)

            Case "GestorEmpresa"
                Funciones1.Eliminar(ComboBoxTipoElemento, "DELETE FROM gestorempresa where mail = @valorid1 and idEmpresa = @valorid2", LabelError, TextBox1, TextBox2)

            Case "Invitaciones"
                Funciones1.Eliminar(ComboBoxTipoElemento, "DELETE FROM invitaciones where codigo = @valorid1", LabelError, TextBox1)

            Case "Ofertas"
                Funciones1.Eliminar(ComboBoxTipoElemento, "ALTER TABLE ofertas where NumSerie = @valorid1", LabelError, TextBox1)
                'buscar solucion para cuando no se selecciona el combo box
                ' Case ""
                '    LabelError.Text = "Porfabor seleccione una Opcion antes de Listar"

        End Select


    End Sub
End Class