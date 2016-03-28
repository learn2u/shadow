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
        'Dim newMdiEmpresa As New frEmpresa
        newMdiEmpresa.MdiParent = Me
        newMdiEmpresa.Dock = DockStyle.Fill
        newMdiEmpresa.Show()

    End Sub

    Private Sub ConfiguraciónMySQLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConfiguraciónMySQLToolStripMenuItem.Click
        'frConfiguracion.Show()
        'Dim newMdiConfiguración As New frConfiguracion
        newMdiConfiguracion.MdiParent = Me
        newMdiConfiguracion.Dock = DockStyle.Fill
        newMdiConfiguracion.Show()
    End Sub

    Private Sub PresupuestosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PresupuestosToolStripMenuItem.Click
        'frPresupuestos.Show()
        'Dim newMdiPresupuestos As New frPresupuestos
        newMdiPresupuesto.MdiParent = Me
        newMdiPresupuesto.Dock = DockStyle.Fill
        newMdiPresupuesto.Show()

    End Sub

    Private Sub PedidosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PedidosToolStripMenuItem.Click
        'frPedido.Show()
        'Dim newMdiPedidos As New frPedido
        newMdiPedido.MdiParent = Me
        newMdiPedido.Dock = DockStyle.Fill
        newMdiPedido.Show()

    End Sub

    Private Sub AlbaranesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlbaranesToolStripMenuItem.Click
        'frAlbaran.Show()
        'Dim newMdiAlbaran As New frAlbaran
        newMdiAlbaran.MdiParent = Me
        newMdiAlbaran.Dock = DockStyle.Fill
        newMdiAlbaran.Show()

    End Sub

    Private Sub FacturaciónManualToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FacturaciónManualToolStripMenuItem.Click
        'frFacturaManual.Show()
        'Dim newMdiFacturaManual As New frFacturaManual
        newMdiFacturaManual.MdiParent = Me
        newMdiFacturaManual.Dock = DockStyle.Fill
        newMdiFacturaManual.Show()

    End Sub

    Private Sub FacturarAlbaranesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FacturarAlbaranesToolStripMenuItem.Click
        'frFacturaAlbaran.Show()
        'Dim newMdiFacturaAlbaran As New frFacturaAlbaran
        newMdiFacturaAlbaran.MdiParent = Me
        newMdiFacturaAlbaran.Dock = DockStyle.Fill
        newMdiFacturaAlbaran.Show()

    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        'frCliente.Show()
        'Dim newMdiClientes As New frCliente
        newMdiCliente.MdiParent = Me
        newMdiCliente.Dock = DockStyle.Fill
        newMdiCliente.Show()

    End Sub

    Private Sub PedidosAProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PedidosAProveedoresToolStripMenuItem.Click
        'frPedidoProv.Show()
        'Dim newMdiPedidoProv As New frPedidoProv
        newMdiPedidoProv.MdiParent = Me
        newMdiPedidoProv.Dock = DockStyle.Fill
        newMdiPedidoProv.Show()

    End Sub

    Private Sub EntradasToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProveedoresToolStripMenuItem.Click
        'frProveedor.Show()
        'Dim newMdiProveedor As New frProveedor
        newMdiProveedor.MdiParent = Me
        newMdiProveedor.Dock = DockStyle.Fill
        newMdiProveedor.Show()

    End Sub

    Private Sub ArtículosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArtículosToolStripMenuItem.Click
        'frArticulos.Show()
        'Dim newMdiArticulos As New frArticulos
        newMdiArticulos.MdiParent = Me
        newMdiArticulos.Dock = DockStyle.Fill
        newMdiArticulos.Show()

    End Sub

    Private Sub GastosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GastosToolStripMenuItem.Click
        'frGastos.Show()
        'Dim newMdiGastos As New frGastos
        newMdiGasto.MdiParent = Me
        newMdiGasto.Dock = DockStyle.Fill
        newMdiGasto.Show()

    End Sub
End Class