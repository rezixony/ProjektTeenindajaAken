Public Class ClassTeisendaja
    Implements ITeisendaja
    Const KM2MI = 1.609344

    Private millid As Double = 0
    'ridade poolitamiseks kasutatakse allkriipsu
    'func tagastavad alati
    Public Function teisendaKilomeetridMiilideks(km As Double) As Double Implements ITeisendaja.teisendaKilomeetridMiilideks(Of)

        teisendaKmMi(km)
        Return millid



    End Function

    'protseduur ei tagasta
    Private Sub teisendaKmMi(ByVal km As Double)
        millid = km / KM2MI
    End Sub
End Class
