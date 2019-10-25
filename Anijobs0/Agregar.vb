Public Class Agregar
    Private Sub ComboBoxTipoElemento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxTipoElemento.SelectedIndexChanged


        Select Case (ComboBoxTipoElemento.SelectedItem.ToString)

            Case "Candidato"
                GrpBxCandidato.Visible = True
                GrpBxCurriculums.Visible = False
                GrpBxEmpresa.Visible = False
                GrpBxGestor.Visible = False
                GrpBxInvitaciones.Visible = False
                GrpBxOferta.Visible = False



            Case "Curriculum"
                GrpBxCandidato.Visible = False
                GrpBxCurriculums.Visible = True
                GrpBxEmpresa.Visible = False
                GrpBxGestor.Visible = False
                GrpBxInvitaciones.Visible = False
                GrpBxOferta.Visible = False

            Case "Empresa"
                GrpBxCandidato.Visible = False
                GrpBxCurriculums.Visible = False
                GrpBxEmpresa.Visible = True
                GrpBxGestor.Visible = False
                GrpBxInvitaciones.Visible = False
                GrpBxOferta.Visible = False

            Case "GestorEmpresa"
                GrpBxCandidato.Visible = False
                GrpBxCurriculums.Visible = False
                GrpBxEmpresa.Visible = False
                GrpBxGestor.Visible = True
                GrpBxInvitaciones.Visible = False
                GrpBxOferta.Visible = False

            Case "Invitaciones"
                GrpBxCandidato.Visible = False
                GrpBxCurriculums.Visible = False
                GrpBxEmpresa.Visible = False
                GrpBxGestor.Visible = False
                GrpBxInvitaciones.Visible = True
                GrpBxOferta.Visible = False

            Case "Oferta"
                GrpBxCandidato.Visible = False
                GrpBxCurriculums.Visible = False
                GrpBxEmpresa.Visible = False
                GrpBxGestor.Visible = False
                GrpBxInvitaciones.Visible = False
                GrpBxOferta.Visible = True


        End Select
    End Sub


End Class