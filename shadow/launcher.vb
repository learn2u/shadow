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
End Class