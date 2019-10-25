Module Funciones1

    Public Sub Listar(cantidad As Integer, ComboBox As ComboBox, listView As ListView, query As String)

        Dim tipoElemento As String = ComboBox.SelectedItem.ToString
        Dim clasecnn = New ConnectionPostgreSQL
        Dim conexion As New Npgsql.NpgsqlConnection()
        conexion = clasecnn.AbrirConexion()

        Dim cmd = New Npgsql.NpgsqlCommand()
        cmd.Connection = conexion

        cmd.Parameters.Add(("@tipoElemento"), NpgsqlTypes.NpgsqlDbType.Varchar).Value = tipoElemento
        Dim cadenaComando = query
        cmd.CommandText = cadenaComando


        Dim lector As Npgsql.NpgsqlDataReader
        lector = cmd.ExecuteReader()
        If lector.HasRows Then
            Dim I As Integer = 0
            While lector.Read()
                listView.Items.Add(lector(0).ToString)
                For rep As Integer = 1 To cantidad - 1
                    listView.Items(I).SubItems.Add(lector(1).ToString)
                Next
                I += 1
            End While
            lector.Close()

        End If
    End Sub




    Public Sub Eliminar(combobox As ComboBox, query As String, label As Label, ParamArray textBoxes() As TextBox)

        Dim clasecnn = New ConnectionPostgreSQL
        Dim conexion As New Npgsql.NpgsqlConnection()
        conexion = clasecnn.AbrirConexion()

        Dim cmd = New Npgsql.NpgsqlCommand()
        cmd.Connection = conexion

        Dim i As Integer
        For Each TextBox In textBoxes
            Dim tipoElemento As String = combobox.SelectedItem.ToString
            Try



                cmd.CommandText = query


                Dim valor = TextBox.Text
                Dim valorParseado
                If Int32.TryParse(TextBox.Text, valorParseado) Then
                    cmd.Parameters.Add(("@valorid" + (i + 1).ToString), NpgsqlTypes.NpgsqlDbType.Integer).Value = valorParseado
                Else
                    cmd.Parameters.Add(("@valorid" + (i + 1).ToString), NpgsqlTypes.NpgsqlDbType.Varchar).Value = valor
                End If

            Catch ex As Exception

                label.Text = ex.ToString

            End Try

            i += 1
        Next
        cmd.ExecuteNonQuery()

    End Sub

End Module
