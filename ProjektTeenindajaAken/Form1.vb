Public Class Form1

    Private Const KM2MI = 1.609344
    Private Sub btnTeisenda_Click(sender As Object, e As EventArgs) Handles btnTeisenda.Click
        Dim teisendaja As PrjTeisendajaKonteiner.ITeisendaja
        teisendaja = New PrjTeisendajaKonteiner.ClassTeisendaja

        Try
            'proovime teisendada
            txtMiilid.Text = teisenda(txtKilomeetrid.Text)

        Catch ex As Exception
            'vea korral toome ette hoiatuskasti
            'MsgBox("Viga sisendis!")
            txtMiilid.Text = teisendaja.teisendaKilomeetridMiilideks(txtKilomeetrid.Text)

        End Try
    End Sub

    Function teisenda(ByVal km As Double) As Double
        Return km / KM2MI
    End Function

    Private Sub timerKell_Tick(sender As Object, e As EventArgs) Handles timerKell.Tick
        lblKell.Text = DateTime.Now()
    End Sub

    Private Sub KasutajaAken_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        timerKell.Interval = 2000
        timerKell.Enabled = True

    End Sub


    Private Sub SulgeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SulgeToolStripMenuItem.Click
        Me.Close()

    End Sub
End Class
