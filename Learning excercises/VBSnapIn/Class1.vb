Imports System.Windows.Forms
Imports CommonSnappableTypes

<CompanyInfo(CompanyName:="Chucky bear", CompanyUrl:="google.com")>
Public Class VBSnapIn
    Implements IPublicFuncionality

    Public Sub DoIt() Implements IPublicFuncionality.DoIt
        MessageBox.Show("Snap from Visual basic")
    End Sub
End Class
