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
        Dim consultamy As New MySqlCommand("SELECT nombre, agenteID, descuento, clienteID FROM clientes", conexionmy)

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
        Dim consultamy As New MySqlCommand("SELECT nombre, agenteID, descuento, clienteID FROM clientes WHERE nombre LIKE'" & txCliente.Text & "%'", conexionmy)

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
        mostrarEmergente(dgClientes.CurrentRow.Cells("cod").Value)
        If formCli = "P" Then
            frPresupuestos.txNumcli.Text = dgClientes.CurrentRow.Cells("cod").Value
            frPresupuestos.txClientepres.Text = dgClientes.CurrentRow.Cells("cliente").Value
            frPresupuestos.txAgente.Text = dgClientes.CurrentRow.Cells("agent").Value
            frPresupuestos.txDtocli.Text = dgClientes.CurrentRow.Cells("dto").Value
            Me.Hide()
            frPresupuestos.recalcularDescuentos()
            cargoEnvios()
        End If
        If formCli = "A" Then
            frAlbaran.txNumcli.Text = dgClientes.CurrentRow.Cells("cod").Value
            frAlbaran.txClientepres.Text = dgClientes.CurrentRow.Cells("cliente").Value
            frAlbaran.txAgente.Text = dgClientes.CurrentRow.Cells("agent").Value
            frAlbaran.txDtocli.Text = dgClientes.CurrentRow.Cells("dto").Value
            Me.Hide()
            frAlbaran.recalcularDescuentos()
            cargoEnvios()
        End If

        If formCli = "D" Then
            frPedido.txNumcli.Text = dgClientes.CurrentRow.Cells("cod").Value
            frPedido.txClientepres.Text = dgClientes.CurrentRow.Cells("cliente").Value
            frPedido.txAgente.Text = dgClientes.CurrentRow.Cells("agent").Value
            frPedido.txDtocli.Text = dgClientes.CurrentRow.Cells("dto").Value
            Me.Hide()
            frPedido.recalcularDescuentos()
            cargoEnvios()
        End If

        If formCli = "F" Then
            frFacturaManual.txNumcli.Text = dgClientes.CurrentRow.Cells("cod").Value
            frFacturaManual.txClientepres.Text = dgClientes.CurrentRow.Cells("cliente").Value
            frFacturaManual.txAgente.Text = dgClientes.CurrentRow.Cells("agent").Value
            frFacturaManual.txDtocli.Text = dgClientes.CurrentRow.Cells("dto").Value
            Me.Hide()
            frFacturaManual.recalcularDescuentos()
            cargoEnvios()
            cargoFormapagoCliente()
        End If

    End Sub
    Public Sub mostrarEmergente(vCodcli As String)
        Dim conexionmy As New MySqlConnection("server=" + vServidor + "; User ID=" + vUsuario + "; database=" + vBasedatos)

        conexionmy.Open()
        Dim cmdCli As New MySqlCommand
        Dim rdrCli As MySqlDataReader
        cmdCli = New MySqlCommand("SELECT clienteID, mensaje FROM clientes WHERE clienteID = '" + vCodcli + "'", conexionmy)

        cmdCli.CommandType = CommandType.Text
        cmdCli.Connection = conexionmy
        rdrCli = cmdCli.ExecuteReader
        rdrCli.Read()

        If rdrCli("mensaje") = "" Then
            'Si el mensaje esta en blanco
        Else
            MsgBox(rdrCli("mensaje"))
        End If



        rdrCli.Close()

        conexionmy.Close()
    End Sub
    Public Sub cargoEnvios()
        If formCli = "P" Then
            frPresupuestos.cbEnvio.ResetText()

            Dim cn As MySqlConnection
            Dim cm As MySqlCommand

            Dim da As MySqlDataAdapter
            Dim ds As DataSet
            cn = New MySqlConnection("server=" + vServidor + "; User ID=" + vUsuario + "; database=" + vBasedatos)

            cn.Open()
            cm = New MySqlCommand("SELECT envioID, clienteID, localidad, provincia, concat_ws(' - ',cpostal, domicilio) AS direccion FROM envios WHERE clienteID = '" & frPresupuestos.txNumcli.Text & "'", cn)


            cm.CommandType = CommandType.Text
            cm.Connection = cn

            da = New MySqlDataAdapter(cm)
            ds = New DataSet()
            da.Fill(ds)


            frPresupuestos.cbEnvio.DataSource = ds.Tables(0)
            frPresupuestos.cbEnvio.DisplayMember = ds.Tables(0).Columns("direccion").ToString
            frPresupuestos.cbEnvio.ValueMember = "envioID"

            cn.Close()
        End If
        If formCli = "A" Then
            frAlbaran.cbEnvio.ResetText()

            Dim cn As MySqlConnection
            Dim cm As MySqlCommand

            Dim da As MySqlDataAdapter
            Dim ds As DataSet
            cn = New MySqlConnection("server=" + vServidor + "; User ID=" + vUsuario + "; database=" + vBasedatos)

            cn.Open()
            cm = New MySqlCommand("SELECT envioID, clienteID, localidad, provincia, concat_ws(' - ',cpostal, domicilio) AS direccion FROM envios WHERE clienteID = '" & frAlbaran.txNumcli.Text & "'", cn)


            cm.CommandType = CommandType.Text
            cm.Connection = cn

            da = New MySqlDataAdapter(cm)
            ds = New DataSet()
            da.Fill(ds)


            frAlbaran.cbEnvio.DataSource = ds.Tables(0)
            frAlbaran.cbEnvio.DisplayMember = ds.Tables(0).Columns("direccion").ToString
            frAlbaran.cbEnvio.ValueMember = "envioID"

            cn.Close()
        End If
        If formCli = "D" Then
            frPedido.cbEnvio.ResetText()

            Dim cn As MySqlConnection
            Dim cm As MySqlCommand

            Dim da As MySqlDataAdapter
            Dim ds As DataSet
            cn = New MySqlConnection("server=" + vServidor + "; User ID=" + vUsuario + "; database=" + vBasedatos)

            cn.Open()
            cm = New MySqlCommand("SELECT envioID, clienteID, localidad, provincia, concat_ws(' - ',cpostal, domicilio) AS direccion FROM envios WHERE clienteID = '" & frPedido.txNumcli.Text & "'", cn)


            cm.CommandType = CommandType.Text
            cm.Connection = cn

            da = New MySqlDataAdapter(cm)
            ds = New DataSet()
            da.Fill(ds)


            frPedido.cbEnvio.DataSource = ds.Tables(0)
            frPedido.cbEnvio.DisplayMember = ds.Tables(0).Columns("direccion").ToString
            frPedido.cbEnvio.ValueMember = "envioID"

            cn.Close()
        End If

        If formCli = "F" Then
            frFacturaManual.cbEnvio.ResetText()

            Dim cn As MySqlConnection
            Dim cm As MySqlCommand

            Dim da As MySqlDataAdapter
            Dim ds As DataSet
            cn = New MySqlConnection("server=" + vServidor + "; User ID=" + vUsuario + "; database=" + vBasedatos)

            cn.Open()
            cm = New MySqlCommand("SELECT envioID, clienteID, localidad, provincia, concat_ws(' - ',cpostal, domicilio) AS direccion FROM envios WHERE clienteID = '" & frFacturaManual.txNumcli.Text & "'", cn)


            cm.CommandType = CommandType.Text
            cm.Connection = cn

            da = New MySqlDataAdapter(cm)
            ds = New DataSet()
            da.Fill(ds)


            frFacturaManual.cbEnvio.DataSource = ds.Tables(0)
            frFacturaManual.cbEnvio.DisplayMember = ds.Tables(0).Columns("direccion").ToString
            frFacturaManual.cbEnvio.ValueMember = "envioID"

            cn.Close()
        End If

    End Sub
    Public Sub cargoFormapagoCliente()
        Dim conexionmy As New MySqlConnection("server=" + vServidor + "; User ID=" + vUsuario + "; database=" + vBasedatos)
        conexionmy.Open()
        Dim cmd As New MySqlCommand

        Dim rdr As MySqlDataReader

        cmd = New MySqlCommand("SELECT * FROM clientes WHERE clienteID = '" + frFacturaManual.txNumcli.Text + "'", conexionmy)

        cmd.CommandType = CommandType.Text
        cmd.Connection = conexionmy
        rdr = cmd.ExecuteReader


        rdr.Read()

        frFacturaManual.txDiapago.Text = rdr("diapago")
        cargoFormaPago()

        Dim vForma As Integer = 0
        vForma = rdr("formapago")
        Select Case vForma
            Case 1
                frFacturaManual.cbFormapago.SelectedIndex = 0
            Case 2
                frFacturaManual.cbFormapago.SelectedIndex = 1
            Case 3
                frFacturaManual.cbFormapago.SelectedIndex = 2
            Case 4
                frFacturaManual.cbFormapago.SelectedIndex = 3
            Case 5
                frFacturaManual.cbFormapago.SelectedIndex = 4
            Case 6
                frFacturaManual.cbFormapago.SelectedIndex = 5
            Case 7
                frFacturaManual.cbFormapago.SelectedIndex = 6
            Case 8
                frFacturaManual.cbFormapago.SelectedIndex = 7
            Case 9
                frFacturaManual.cbFormapago.SelectedIndex = 8
        End Select
    End Sub
    Public Sub cargoFormaPago()
        frFacturaManual.cbFormapago.ResetText()

        Dim cn As MySqlConnection
        Dim cm As MySqlCommand

        Dim da As MySqlDataAdapter
        Dim ds As DataSet
        cn = New MySqlConnection("server=" + vServidor + "; User ID=" + vUsuario + "; database=" + vBasedatos)

        cn.Open()
        cm = New MySqlCommand("SELECT formaID, formapago FROM formapago", cn)


        cm.CommandType = CommandType.Text
        cm.Connection = cn

        da = New MySqlDataAdapter(cm)
        ds = New DataSet()
        da.Fill(ds)


        frFacturaManual.cbFormapago.DataSource = ds.Tables(0)
        frFacturaManual.cbFormapago.DisplayMember = ds.Tables(0).Columns("formapago").ToString
        frFacturaManual.cbFormapago.ValueMember = "formaID"

        cn.Close()
    End Sub
End Class