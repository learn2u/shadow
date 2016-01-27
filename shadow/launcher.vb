Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Imports System.Globalization
Imports System.ComponentModel
Imports System.Xml
Public Class launcher
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frPresupuestos.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frAlbaran.Show()

    End Sub

    Private Sub launcher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim documento As XmlDocument
        Dim nodelist As XmlNodeList
        Dim nodo As XmlNode
        documento = New XmlDocument
        documento.Load("conexion.xml")
        nodelist = documento.SelectNodes("conexion")
        For Each nodo In nodelist
            vServidor = nodo.ChildNodes(0).InnerText
            vUsuario = nodo.ChildNodes(1).InnerText
            vPassword = nodo.ChildNodes(2).InnerText
            vBasedatos = nodo.ChildNodes(3).InnerText
        Next
        formArti = "N"
        formCli = "N"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        frConfiguracion.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        frPedido.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        frFacturaManual.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        frEmpresa.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        frCliente.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        frArticulos.Show()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        frPedidoProv.Show()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        frFacturaAlbaran.Show()

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        frGastos.Show()

    End Sub
End Class