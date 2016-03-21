Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Imports System.Globalization
Imports System.ComponentModel
Imports System.Xml
Public Class frVerProveedores
    Private Sub frVerProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargoTodosProveedores()

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

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        If CheckBox1.Checked = True Then
            Dim conexionmy As New MySqlConnection("server=" + vServidor + "; User ID=" + vUsuario + "; database=" + vBasedatos)

            conexionmy.Open()
            Dim consultamy As New MySqlCommand("SELECT nombre, descuento, proveedorID, cif FROM proveedores WHERE tipo = 'T'", conexionmy)

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
        Else
            cargoTodosProveedores()
        End If

    End Sub
    Public Sub cargoTodosProveedores()
        Dim conexionmy As New MySqlConnection("server=" + vServidor + "; User ID=" + vUsuario + "; database=" + vBasedatos)

        conexionmy.Open()
        Dim consultamy As New MySqlCommand("SELECT nombre, descuento, proveedorID, cif, diapago, formatexto FROM proveedores WHERE tipo = 'P'", conexionmy)

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
        dgProvedores.Columns(4).HeaderText = "DIA"
        dgProvedores.Columns(4).Name = "diap"
        dgProvedores.Columns(4).Visible = False
        dgProvedores.Columns(5).HeaderText = "PAGO"
        dgProvedores.Columns(5).Name = "formap"
        dgProvedores.Columns(5).Visible = False
        dgProvedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        conexionmy.Close()
    End Sub

    Private Sub dgProvedores_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgProvedores.CellDoubleClick
        If formCli = "G" Then
            frGastos.txNumcli.Text = dgProvedores.CurrentRow.Cells("cod").Value
            frGastos.txClientepres.Text = dgProvedores.CurrentRow.Cells("cliente").Value
            frGastos.txDni.Text = dgProvedores.CurrentRow.Cells("cif").Value
            frGastos.txDtocli.Text = dgProvedores.CurrentRow.Cells("dto").Value
            frGastos.txDiaspago.Text = dgProvedores.CurrentRow.Cells("diap").Value
            frGastos.cbFormapago.Text = dgProvedores.CurrentRow.Cells("formap").Value
            Me.Hide()
        End If
        If formCli = "D" Then
            frPedidoProv.txNumcli.Text = dgProvedores.CurrentRow.Cells("cod").Value
            frPedidoProv.txClientepres.Text = dgProvedores.CurrentRow.Cells("cliente").Value
            frPedidoProv.txDtocli.Text = dgProvedores.CurrentRow.Cells("dto").Value
            Me.Hide()
            frPedidoProv.recalcularDescuentos()
        End If
        If formCli = "A" Then
            frArticulos.txNumPro.Text = dgProvedores.CurrentRow.Cells("cod").Value
            frArticulos.txProveedor.Text = dgProvedores.CurrentRow.Cells("cliente").Value
            frArticulos.txDto.Text = dgProvedores.CurrentRow.Cells("dto").Value
            Me.Hide()
        End If
    End Sub

    Private Sub txProveedor_KeyDown(sender As Object, e As KeyEventArgs) Handles txProveedor.KeyDown
        Dim address As Point = Me.dgProvedores.CurrentCellAddress
        If e.KeyCode = Keys.Down Then
            If address.Y < Me.dgProvedores.RowCount - 1 Then
                address.Y += 1
            End If

            Me.dgProvedores.CurrentCell = Me.dgProvedores(address.X, address.Y)
        End If
        If e.KeyCode = Keys.Up Then
            If address.Y <> 0 Then
                address.Y -= 1
            End If

            Me.dgProvedores.CurrentCell = Me.dgProvedores(address.X, address.Y)
        End If

        If e.KeyCode = Keys.Enter Then
            If formCli = "G" Then
                frGastos.txNumcli.Text = dgProvedores.CurrentRow.Cells("cod").Value
                frGastos.txClientepres.Text = dgProvedores.CurrentRow.Cells("cliente").Value
                frGastos.txDni.Text = dgProvedores.CurrentRow.Cells("cif").Value
                frGastos.txDtocli.Text = dgProvedores.CurrentRow.Cells("dto").Value
                frGastos.txDiaspago.Text = dgProvedores.CurrentRow.Cells("diap").Value
                frGastos.cbFormapago.Text = dgProvedores.CurrentRow.Cells("formap").Value
                Me.Hide()
            End If
            If formCli = "D" Then
                frPedidoProv.txNumcli.Text = dgProvedores.CurrentRow.Cells("cod").Value
                frPedidoProv.txClientepres.Text = dgProvedores.CurrentRow.Cells("cliente").Value
                frPedidoProv.txDtocli.Text = dgProvedores.CurrentRow.Cells("dto").Value
                Me.Hide()
                frPedidoProv.recalcularDescuentos()
            End If
            If formCli = "A" Then
                frArticulos.txNumPro.Text = dgProvedores.CurrentRow.Cells("cod").Value
                frArticulos.txProveedor.Text = dgProvedores.CurrentRow.Cells("cliente").Value
                frArticulos.txDto.Text = dgProvedores.CurrentRow.Cells("dto").Value
                Me.Hide()
            End If
        End If
    End Sub
End Class