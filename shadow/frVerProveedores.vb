Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Imports System.Globalization
Imports System.ComponentModel
Imports System.Xml
Public Class frVerProveedores
    Private Sub frVerProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conexionmy As New MySqlConnection("server=" + vServidor + "; User ID=" + vUsuario + "; database=" + vBasedatos)

        conexionmy.Open()
        Dim consultamy As New MySqlCommand("SELECT nombre, descuento, proveedorID, cif FROM proveedores", conexionmy)

        Dim readermy As MySqlDataReader
        Dim dtable As New DataTable
        Dim bind As New BindingSource()


        readermy = consultamy.ExecuteReader
        dtable.Load(readermy, LoadOption.OverwriteChanges)

        bind.DataSource = dtable


        dgProvedores.DataSource = bind
        dgProvedores.AutoGenerateColumns = False
        dgProvedores.Columns(0).HeaderText = "NOMBRE"
        dgProvedores.Columns(0).Name = "cliente"
        dgProvedores.Columns(1).HeaderText = "DESCUENTO"
        dgProvedores.Columns(1).Name = "dto"
        dgProvedores.Columns(1).Visible = False
        dgProvedores.Columns(2).HeaderText = "CODIGO"
        dgProvedores.Columns(2).Name = "cod"
        dgProvedores.Columns(2).Visible = False
        dgProvedores.Columns(3).HeaderText = "CIF"
        dgProvedores.Columns(3).Name = "cif"
        dgProvedores.Columns(3).Visible = False
        dgProvedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        conexionmy.Close()
    End Sub

    Private Sub txProveedor_TextChanged(sender As Object, e As EventArgs) Handles txProveedor.TextChanged
        Dim conexionmy As New MySqlConnection("server=" + vServidor + "; User ID=" + vUsuario + "; database=" + vBasedatos)

        conexionmy.Open()
        Dim consultamy As New MySqlCommand("SELECT nombre, descuento, proveedorID, cif FROM proveedores WHERE nombre LIKE'" & txProveedor.Text & "%'", conexionmy)

        Dim readermy As MySqlDataReader
        Dim dtable As New DataTable
        Dim bind As New BindingSource()


        readermy = consultamy.ExecuteReader
        dtable.Load(readermy, LoadOption.OverwriteChanges)

        bind.DataSource = dtable

        dgProvedores.DataSource = bind
        dgProvedores.AutoGenerateColumns = False
        dgProvedores.Columns(0).HeaderText = "NOMBRE"
        dgProvedores.Columns(0).Name = "cliente"
        dgProvedores.Columns(1).HeaderText = "DESCUENTO"
        dgProvedores.Columns(1).Name = "dto"
        dgProvedores.Columns(1).Visible = False
        dgProvedores.Columns(2).HeaderText = "CODIGO"
        dgProvedores.Columns(2).Name = "cod"
        dgProvedores.Columns(2).Visible = False
        dgProvedores.Columns(3).HeaderText = "CIF"
        dgProvedores.Columns(3).Name = "cif"
        dgProvedores.Columns(3).Visible = False
        dgProvedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        conexionmy.Close()
    End Sub

    Private Sub dgProvedores_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgProvedores.CellClick

        If formCli = "G" Then
            frGastos.txNumcli.Text = dgProvedores.CurrentRow.Cells("cod").Value
            frGastos.txClientepres.Text = dgProvedores.CurrentRow.Cells("cliente").Value
            frGastos.txDni.Text = dgProvedores.CurrentRow.Cells("cif").Value
            frGastos.txDtocli.Text = dgProvedores.CurrentRow.Cells("dto").Value
            Me.Hide()
        End If
        frPedidoProv.txNumcli.Text = dgProvedores.CurrentRow.Cells("cod").Value
        frPedidoProv.txClientepres.Text = dgProvedores.CurrentRow.Cells("cliente").Value
        'frPedidoProv.txAgente.Text = dgProvedores.CurrentRow.Cells("agent").Value
        frPedidoProv.txDtocli.Text = dgProvedores.CurrentRow.Cells("dto").Value
        Me.Hide()
        frPedidoProv.recalcularDescuentos()

    End Sub
End Class