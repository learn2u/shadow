Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Imports System.Globalization
Imports System.ComponentModel
Imports System.Xml
Public Class frVerClientes
    Private Sub frVerClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conexionmy As New MySqlConnection("server=" + vServidor + "; User ID=" + vUsuario + "; database=" + vBasedatos)

        conexionmy.Open()
        Dim consultamy As New MySqlCommand("SELECT nombre, agenteID, descuento, codigo FROM clientes", conexionmy)

        Dim readermy As MySqlDataReader
        Dim dtable As New DataTable
        Dim bind As New BindingSource()


        readermy = consultamy.ExecuteReader
        dtable.Load(readermy, LoadOption.OverwriteChanges)

        bind.DataSource = dtable


        dgClientes.DataSource = bind
        dgClientes.AutoGenerateColumns = False
        dgClientes.Columns(0).HeaderText = "NOMBRE"
        dgClientes.Columns(0).Name = "cliente"
        dgClientes.Columns(1).HeaderText = "AGENTE"
        dgClientes.Columns(1).Name = "agent"
        dgClientes.Columns(1).Visible = False
        dgClientes.Columns(2).HeaderText = "DESCUENTO"
        dgClientes.Columns(2).Name = "dto"
        dgClientes.Columns(2).Visible = False
        dgClientes.Columns(3).HeaderText = "CODIGO"
        dgClientes.Columns(3).Name = "cod"
        dgClientes.Columns(3).Visible = False
        dgClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        conexionmy.Close()

    End Sub

    Private Sub txCliente_TextChanged(sender As Object, e As EventArgs) Handles txCliente.TextChanged
        Dim conexionmy As New MySqlConnection("server=" + vServidor + "; User ID=" + vUsuario + "; database=" + vBasedatos)

        conexionmy.Open()
        Dim consultamy As New MySqlCommand("SELECT nombre, agenteID, descuento, codigo FROM clientes WHERE nombre LIKE'" & txCliente.Text & "%'", conexionmy)

        Dim readermy As MySqlDataReader
        Dim dtable As New DataTable
        Dim bind As New BindingSource()


        readermy = consultamy.ExecuteReader
        dtable.Load(readermy, LoadOption.OverwriteChanges)

        bind.DataSource = dtable

        dgClientes.DataSource = bind
        dgClientes.AutoGenerateColumns = False
        dgClientes.Columns(0).HeaderText = "NOMBRE"
        dgClientes.Columns(0).Name = "cliente"
        dgClientes.Columns(1).HeaderText = "AGENTE"
        dgClientes.Columns(1).Name = "agent"
        dgClientes.Columns(1).Visible = False
        dgClientes.Columns(2).HeaderText = "DESCUENTO"
        dgClientes.Columns(2).Name = "dto"
        dgClientes.Columns(2).Visible = False
        dgClientes.Columns(3).HeaderText = "CODIGO"
        dgClientes.Columns(3).Name = "cod"
        dgClientes.Columns(3).Visible = False
        dgClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        conexionmy.Close()

    End Sub

    Private Sub dgClientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgClientes.CellClick
        If formCli = "P" Then
            frPresupuestos.txNumcli.Text = dgClientes.CurrentRow.Cells("cod").Value
            frPresupuestos.txClientepres.Text = dgClientes.CurrentRow.Cells("cliente").Value
            frPresupuestos.txAgente.Text = dgClientes.CurrentRow.Cells("agent").Value
            frPresupuestos.txDtocli.Text = dgClientes.CurrentRow.Cells("dto").Value
            Me.Hide()
            frPresupuestos.recalcularDescuentos()
        End If
        If formCli = "A" Then
            frAlbaran.txNumcli.Text = dgClientes.CurrentRow.Cells("cod").Value
            frAlbaran.txClientepres.Text = dgClientes.CurrentRow.Cells("cliente").Value
            frAlbaran.txAgente.Text = dgClientes.CurrentRow.Cells("agent").Value
            frAlbaran.txDtocli.Text = dgClientes.CurrentRow.Cells("dto").Value
            Me.Hide()
            frAlbaran.recalcularDescuentos()
        End If

        If formCli = "D" Then
            frPedido.txNumcli.Text = dgClientes.CurrentRow.Cells("cod").Value
            frPedido.txClientepres.Text = dgClientes.CurrentRow.Cells("cliente").Value
            frPedido.txAgente.Text = dgClientes.CurrentRow.Cells("agent").Value
            frPedido.txDtocli.Text = dgClientes.CurrentRow.Cells("dto").Value
            Me.Hide()
            frPedido.recalcularDescuentos()
        End If

    End Sub
End Class