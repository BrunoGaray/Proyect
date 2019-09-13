Public Class Listar
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


            Case "Curriculum"
                ListViewListadoCandidato.Visible = False
                ListViewListadoCurriculum.Visible = True
                ListViewListadoEmpresa.Visible = False
                ListViewListadoGestor.Visible = False
                ListViewListadoInvitacion.Visible = False
                ListViewListadoOfertas.Visible = False

            Case "Empresa"
                ListViewListadoCandidato.Visible = False
                ListViewListadoCurriculum.Visible = False
                ListViewListadoEmpresa.Visible = True
                ListViewListadoGestor.Visible = False
                ListViewListadoInvitacion.Visible = False
                ListViewListadoOfertas.Visible = False

            Case "GestorEmpresa"
                ListViewListadoCandidato.Visible = False
                ListViewListadoCurriculum.Visible = False
                ListViewListadoEmpresa.Visible = False
                ListViewListadoGestor.Visible = True
                ListViewListadoInvitacion.Visible = False
                ListViewListadoOfertas.Visible = False

            Case "Invitaciones"
                ListViewListadoCandidato.Visible = False
                ListViewListadoCurriculum.Visible = False
                ListViewListadoEmpresa.Visible = False
                ListViewListadoGestor.Visible = False
                ListViewListadoInvitacion.Visible = True
                ListViewListadoOfertas.Visible = False

            Case "Oferta"
                ListViewListadoCandidato.Visible = False
                ListViewListadoCurriculum.Visible = False
                ListViewListadoEmpresa.Visible = False
                ListViewListadoGestor.Visible = False
                ListViewListadoInvitacion.Visible = False
                ListViewListadoOfertas.Visible = True

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


End Class