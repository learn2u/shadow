Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Imports System.Globalization
Imports System.ComponentModel
Imports System.Xml
Public Class launcher

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

        Dim conexionmy As New MySqlConnection("server=" + vServidor + "; User ID=" + vUsuario + "; database=" + vBasedatos)
        conexionmy.Open()
        Dim cmd As New MySqlCommand

        Dim rdr As MySqlDataReader

        cmd = New MySqlCommand("SELECT recargo FROM configuracion", conexionmy)

        cmd.CommandType = CommandType.Text
        cmd.Connection = conexionmy
        rdr = cmd.ExecuteReader


        rdr.Read()

        vRecargo = rdr("recargo")

        conexionmy.Close()

    End Sub

    Private Sub ConfiguraciónEmpresaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConfiguraciónEmpresaToolStripMenuItem.Click
        'frEmpresa.Show()
        Dim newMdiEmpresa As New frEmpresa
        newMdiEmpresa.MdiParent = Me
        newMdiEmpresa.Dock = DockStyle.Fill
        newMdiEmpresa.Show()

    End Sub

    Private Sub ConfiguraciónMySQLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConfiguraciónMySQLToolStripMenuItem.Click
        'frConfiguracion.Show()
        Dim newMdiConfiguración As New frConfiguracion
        newMdiConfiguración.MdiParent = Me
        newMdiConfiguración.Dock = DockStyle.Fill
        newMdiConfiguración.Show()
    End Sub

    Private Sub PresupuestosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PresupuestosToolStripMenuItem.Click
        frPresupuestos.Show()
    End Sub

    Private Sub PedidosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PedidosToolStripMenuItem.Click
        frPedido.Show()
    End Sub

    Private Sub AlbaranesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlbaranesToolStripMenuItem.Click
        frAlbaran.Show()
    End Sub

    Private Sub FacturaciónManualToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FacturaciónManualToolStripMenuItem.Click
        frFacturaManual.Show()
    End Sub

    Private Sub FacturarAlbaranesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FacturarAlbaranesToolStripMenuItem.Click
        frFacturaAlbaran.Show()
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        frCliente.Show()
    End Sub

    Private Sub PedidosAProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PedidosAProveedoresToolStripMenuItem.Click
        frPedidoProv.Show()
    End Sub

    Private Sub EntradasToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProveedoresToolStripMenuItem.Click
        frProveedor.Show()
    End Sub

    Private Sub ArtículosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArtículosToolStripMenuItem.Click
        frArticulos.Show()
    End Sub

    Private Sub GastosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GastosToolStripMenuItem.Click
        frGastos.Show()
    End Sub
End Class