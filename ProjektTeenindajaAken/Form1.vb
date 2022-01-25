Public Class Form1

    Private Const KM2MI = 1.609344
    Private Sub btnTeisenda_Click(sender As Object, e As EventArgs) Handles btnTeisenda.Click
        Try
            'proovime teisendada
            txtMiilid.Text = teisenda(txtKilomeetrid.Text)

        Catch ex As Exception
            'vea korral toome ette hoiatuskasti
            MsgBox("Viga sisendis!")

        End Try
    End Sub

    Function teisenda(ByVal km As Double) As Double
        Return km / KM2MI
    End Function

End Class
