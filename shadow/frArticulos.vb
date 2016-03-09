Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Imports System.Globalization
Imports System.ComponentModel
Imports System.Xml
Public Class frArticulos
    Public flagEditArti As Boolean
    Public flagLona As Boolean

    Public Sub cargoArticulos()
        Dim conexionmy As New MySqlConnection("server=" + vServidor + "; User ID=" + vUsuario + "; database=" + vBasedatos)

        conexionmy.Open()

        Dim consultfamilia As New MySqlCommand("SELECT * FROM familias ORDER BY nombrefamilia", conexionmy)
        Dim consultMedidas As New MySqlCommand("SELECT * FROM unidades ORDER BY unidades", conexionmy)
        Dim consultMedidasNum As New MySqlCommand("SELECT * FROM medidas ORDER BY medida", conexionmy)
        Dim consultColores As New MySqlCommand("SELECT * FROM colores ORDER BY colores", conexionmy)
        Dim consultacli As New MySqlCommand("SELECT ref_proveedor, grupoID, descripcion, color, pvp FROM articulos2 ORDER BY ref_proveedor", conexionmy)

        Dim readermy As MySqlDataReader
        Dim readerMedida As MySqlDataReader
        Dim readerMedidaNum As MySqlDataReader
        Dim readerColores As MySqlDataReader
        Dim dtable As New DataTable
        Dim dtableMedida As New DataTable
        Dim dtableMedidaNum As New DataTable
        Dim dtableColores As New DataTable
        Dim readercli As MySqlDataReader
        Dim dtablecli As New DataTable
        Dim bind As New BindingSource()
        Dim bind2 As New BindingSource()
        Dim bind3 As New BindingSource()
        Dim bind4 As New BindingSource()
        Dim bind5 As New BindingSource()

        readermy = consultfamilia.ExecuteReader
        dtable.Load(readermy, LoadOption.OverwriteChanges)

        readerMedida = consultMedidas.ExecuteReader
        dtableMedida.Load(readerMedida, LoadOption.OverwriteChanges)

        readerMedidaNum = consultMedidasNum.ExecuteReader
        dtableMedidaNum.Load(readerMedidaNum, LoadOption.OverwriteChanges)

        readerColores = consultColores.ExecuteReader
        dtableColores.Load(readerColores, LoadOption.OverwriteChanges)

        readercli = consultacli.ExecuteReader
        dtablecli.Load(readercli, LoadOption.OverwriteChanges)

        bind.DataSource = dtable
        bind2.DataSource = dtableMedida
        bind3.DataSource = dtablecli
        bind4.DataSource = dtableMedidaNum
        bind5.DataSource = dtableColores

        dgArticulos.DataSource = bind3
        dgArticulos.EnableHeadersVisualStyles = False
        Dim styCabeceras As DataGridViewCellStyle = New DataGridViewCellStyle()
        styCabeceras.BackColor = Color.Beige
        styCabeceras.ForeColor = Color.Black
        styCabeceras.Font = New Font("Verdana", 9, FontStyle.Bold)
        dgArticulos.ColumnHeadersDefaultCellStyle = styCabeceras

        dgArticulos.Columns(0).HeaderText = "REF PROVEEDOR"
        dgArticulos.Columns(0).Name = "Column1"
        dgArticulos.Columns(0).FillWeight = 125
        dgArticulos.Columns(0).MinimumWidth = 125
        dgArticulos.Columns(1).HeaderText = "GRUPO"
        dgArticulos.Columns(1).Name = "Column2"
        dgArticulos.Columns(1).FillWeight = 75
        dgArticulos.Columns(1).MinimumWidth = 75
        dgArticulos.Columns(2).HeaderText = "DESCRIPCION"
        dgArticulos.Columns(2).Name = "Column3"
        dgArticulos.Columns(2).FillWeight = 350
        dgArticulos.Columns(2).MinimumWidth = 350
        dgArticulos.Columns(3).HeaderText = "COLOR"
        dgArticulos.Columns(3).Name = "Column4"
        dgArticulos.Columns(3).FillWeight = 175
        dgArticulos.Columns(3).MinimumWidth = 175
        dgArticulos.Columns(4).HeaderText = "PVP"
        dgArticulos.Columns(4).Name = "Column5"
        dgArticulos.Columns(4).FillWeight = 75
        dgArticulos.Columns(4).MinimumWidth = 75
        'gridcliente.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        'gridcliente.Columns(4).Visible = False
        'gridcliente.Columns(5).Visible = False
        'gridcliente.Columns(6).Visible = False
        dgArticulos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgArticulos.Visible = True


        cbFamilias.DataSource = bind
        cbFamilias.DisplayMember = "nombrefamilia"
        cbFamilias.ValueMember = "familiaID"

        cbUnidad.DataSource = bind2
        cbUnidad.DisplayMember = "unidades"
        cbUnidad.ValueMember = "unidadID"

        cbMedidas.DataSource = bind4
        cbMedidas.DisplayMember = "medida"
        cbMedidas.ValueMember = "medidaID"

        cbColores.DataSource = bind5
        cbColores.DisplayMember = "colores"
        cbColores.ValueMember = "colorID"

        conexionmy.Close()
    End Sub

    Private Sub frArticulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        deshabilitarBotones()
        pnModelo.Visible = False
        pnTejidos.Visible = False

        TabControl1.SelectTab(1)
        cmdNuevo.Enabled = True
        cmdGuardar.Enabled = False
        cmdCancelar.Enabled = True


        txRefProv.Focus()

        cargoArticulos()

        flagEditArti = False
        flagLona = False


    End Sub

    Private Sub cmdLonas_Click(sender As Object, e As EventArgs) Handles cmdLonas.Click
        If GroupBox2.Enabled = False Then
            GroupBox2.Enabled = True
            btModelo.Enabled = True
            btTejidos.Enabled = True
        Else
            GroupBox2.Enabled = False
            btModelo.Enabled = False
            btTejidos.Enabled = False
        End If

    End Sub
    Public Sub deshabilitarBotones()
        cmdGuardar.Enabled = False
        cmdCancelar.Enabled = False
        cmdFlechas.Enabled = False
        cmdLonas.Enabled = False
        cmdLotes.Enabled = False
        btProveedor.Enabled = False
        btModelo.Enabled = False
        btTejidos.Enabled = False

    End Sub
    Public Sub limpiarFormulario()
        txRefProv.Text = ""
        txCodigo.Text = ""
        txGrupo.Text = ""
        txProveedor.Text = ""
        txNumPro.Text = ""
        txDescripcion.Text = ""
        txModelo.Text = ""
        txModeloID.Text = ""
        txTejido.Text = ""
        txUbicacion.Text = ""
        ckControlStock.Enabled = False
        txIva.Text = ""
        txCompra.Text = 0
        txDto.Text = 0
        txMargenPor.Text = 0
        txMargenEuro.Text = 0
        txPrecio.Text = 0
        txStock.Text = 0
        txMinimo.Text = 0
        txInicial.Text = 0
        tsBotones.Focus()
        cmdNuevo.Select()
    End Sub

    Private Sub cmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click
        Dim conexionmy As New MySqlConnection("server=" + vServidor + "; User ID=" + vUsuario + "; database=" + vBasedatos)
        conexionmy.Open()

        Dim equiv As String

        If flagEditArti = False Then
            Dim cmd As New MySqlCommand
            Dim cmdLastId As New MySqlCommand("SELECT LAST_INSERT_ID()  ", conexionmy)
            Dim numid As Int32


            Dim descuento As String = txDto.Text
            Dim guardo_descuento As String = Replace(descuento, ",", ".")
            Dim iva As String = txIva.Text
            Dim guardo_iva As String = Replace(iva, ",", ".")
            Dim compra As String = txCompra.Text
            Dim guardo_compra As String = Replace(compra, ",", ".")
            Dim dto As String = txDto.Text
            Dim guardo_dto As String = Replace(dto, ",", ".")
            Dim margenpor As String = txMargenPor.Text
            Dim guardo_margenpor As String = Replace(margenpor, ",", ".")
            Dim margeneur As String = txMargenEuro.Text
            Dim guardo_margeneur As String = Replace(margeneur, ",", ".")
            Dim precio As String = txPrecio.Text
            Dim guardo_precio As String = Replace(precio, ",", ".")
            Dim stock As String = txStock.Text
            Dim guardo_stock As String = Replace(stock, ",", ".")

            Dim stockmin As String = txMinimo.Text
            Dim guardo_stockmin As String = Replace(stockmin, ",", ".")
            Dim stockini As String = txInicial.Text
            Dim guardo_stockini As String = Replace(stockini, ",", ".")



            If ckControlStock.Checked = True Then
                equiv = "S"
            Else
                equiv = "N"
            End If

            cmd.CommandType = System.Data.CommandType.Text
            cmd.CommandText = "INSERT INTO articulos2 (ref_proveedor, referencia, grupoID, proveedorID, descripcion, modelo, tejido, familia, color, colorID, ubicacion, medida, unidad, control_stock, iva, precio_compra, dto_prov, porc_margen, euro_margen, pvp, stock, stock_min, stock_ini) VALUES ('" + txRefProv.Text + "' , '" + txCodigo.Text + "' , '" + txGrupo.Text + "' , '" + txNumPro.Text + "' , '" + txDescripcion.Text + "' , '" + txModelo.Text + "' , '" + txTejido.Text + "' , '" + cbFamilias.SelectedValue.ToString + "' , '" + cbColores.Text + "' , '" + cbColores.SelectedValue.ToString + "' , '" + txUbicacion.Text + "' , '" + cbMedidas.SelectedValue.ToString + "' , '" + cbUnidad.SelectedValue.ToString + "' , '" + equiv + "' , '" + guardo_iva + "' , '" + guardo_compra + "' , '" + guardo_dto + "' , '" + guardo_margenpor + "' , '" + guardo_margeneur + "' , '" + guardo_precio + "' , '" + guardo_stock + "' , '" + guardo_stockmin + "' , '" + guardo_stockini + "')"

            cmd.Connection = conexionmy

            cmd.ExecuteNonQuery()

            numid = cmdLastId.ExecuteScalar()

            'Guardo lotes
            Dim cmdLinea As New MySqlCommand
            Dim row As New DataGridViewRow
            Dim lincant As String
            Dim guardo_lincant As String


            For Each row In dgLotes.Rows

                lincant = Decimal.Parse(row.Cells(3).Value).ToString("0.00")
                guardo_lincant = Replace(lincant, ",", ".")

                cmdLinea.Connection = conexionmy
                cmdLinea.CommandText = "INSERT INTO lotes (referencia, descripcion, lote, stock_inicial, ubicacion) VALUES ('" + row.Cells(0).Value + "', " + row.Cells(1).Value + ", '" + row.Cells(2).Value + "', '" + guardo_lincant + "', '" + row.Cells(4).Value + "')"

                cmdLinea.ExecuteNonQuery()

            Next

            conexionmy.Close()
            Me.Hide()
        Else

            Dim descuento As String = txDto.Text
            Dim guardo_descuento As String = Replace(descuento, ",", ".")
            Dim iva As String = txIva.Text
            Dim guardo_iva As String = Replace(iva, ",", ".")
            Dim compra As String = txCompra.Text
            Dim guardo_compra As String = Replace(compra, ",", ".")
            Dim dto As String = txDto.Text
            Dim guardo_dto As String = Replace(dto, ",", ".")
            Dim margenpor As String = txMargenPor.Text
            Dim guardo_margenpor As String = Replace(margenpor, ",", ".")
            Dim margeneur As String = txMargenEuro.Text
            Dim guardo_margeneur As String = Replace(margeneur, ",", ".")
            Dim precio As String = txPrecio.Text
            Dim guardo_precio As String = Replace(precio, ",", ".")
            Dim stock As String = txStock.Text
            Dim guardo_stock As String = Replace(stock, ",", ".")

            Dim stockmin As String = txMinimo.Text
            Dim guardo_stockmin As String = Replace(stockmin, ",", ".")
            Dim stockini As String = txInicial.Text
            Dim guardo_stockini As String = Replace(stockini, ",", ".")

            If ckControlStock.Checked = True Then
                equiv = "S"
            Else
                equiv = "N"
            End If

            Dim cmdActualizar As New MySqlCommand("UPDATE articulos2 SET descripcion = '" + txDescripcion.Text + "', 
                                                referencia = '" + txCodigo.Text + "',
                                                grupoID = '" + txGrupo.Text + "', 
                                                proveedorID = '" + txNumPro.Text + "',
                                                medida= '" + cbMedidas.SelectedValue.ToString + "',
                                                tejido = '" + txTejido.Text + "',
                                                modelo = '" + txModelo.Text + "',
                                                familia = '" + cbFamilias.SelectedValue.ToString + "',
                                                color = '" + cbColores.Text + "',
                                                colorID = '" + cbColores.SelectedValue.ToString + "',
                                                ubicacion = '" + txUbicacion.Text + "',
                                                medida = '" + cbMedidas.SelectedValue.ToString + "',
                                                unidad = '" + cbUnidad.SelectedValue.ToString + "',
                                                control_stock = '" + equiv + "',
                                                iva = '" + guardo_iva + "',
                                                compra = '" + guardo_compra + "',
                                                dto_prov = '" + guardo_dto + "',
                                                porc_margen = '" + guardo_margenpor + "',
                                                euro_margen = '" + guardo_margeneur + "',
                                                pvp = '" + guardo_precio + "',
                                                stock = '" + guardo_stock + "',
                                                stock_min = '" + guardo_stockmin + "',
                                                stock_ini = '" + guardo_stockini + "' WHERE ref_proveedor = '" + txRefProv.Text + "'", conexionmy)
            cmdActualizar.ExecuteNonQuery()

            MsgBox("Los datos del artículo se han actualizado correctamente")
            flagEditArti = False
            Me.Close()
        End If
        TabControl2.SelectTab(0)
        TabControl1.SelectTab(0)
        cargoArticulos()

    End Sub

    Private Sub btProveedor_Click(sender As Object, e As EventArgs) Handles btProveedor.Click
        formCli = "A"
        frVerProveedores.Show()

    End Sub
    Public Sub cargarModelos()
        Dim conexionmy As New MySqlConnection("server=" + vServidor + "; User ID=" + vUsuario + "; database=" + vBasedatos)

        conexionmy.Open()

        Dim consultamod As New MySqlCommand("SELECT modeloID, modelos FROM modelos_lona ORDER BY modelos", conexionmy)
        Dim readermod As MySqlDataReader
        Dim dtablemod As New DataTable
        Dim bind4 As New BindingSource()

        readermod = consultamod.ExecuteReader
        dtablemod.Load(readermod, LoadOption.OverwriteChanges)
        bind4.DataSource = dtablemod

        dgMods.DataSource = bind4
        dgMods.EnableHeadersVisualStyles = False
        Dim styCabeceras As DataGridViewCellStyle = New DataGridViewCellStyle()
        styCabeceras.BackColor = Color.Beige
        styCabeceras.ForeColor = Color.Black
        styCabeceras.Font = New Font("Verdana", 9, FontStyle.Bold)
        dgMods.ColumnHeadersDefaultCellStyle = styCabeceras

        dgMods.Columns(0).HeaderText = "ID"
        dgMods.Columns(0).Name = "Column11"
        dgMods.Columns(0).FillWeight = 30
        dgMods.Columns(0).MinimumWidth = 30
        dgMods.Columns(1).HeaderText = "MODELOS"
        dgMods.Columns(1).Name = "Column12"
        dgMods.Columns(1).FillWeight = 260
        dgMods.Columns(1).MinimumWidth = 260

        dgMods.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgMods.Visible = True

        conexionmy.Close()

    End Sub


    Private Sub btModelo_Click(sender As Object, e As EventArgs) Handles btModelo.Click

        pnModelo.Visible = True
        cargarModelos()

    End Sub

    Private Sub btCloseMod_Click(sender As Object, e As EventArgs) Handles btCloseMod.Click
        pnModelo.Visible = False

    End Sub

    Private Sub dgMods_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgMods.CellClick
        txModeloID.Text = dgMods.CurrentRow.Cells(0).Value
        txModelo.Text = dgMods.CurrentRow.Cells(1).Value
        pnModelo.Visible = False

    End Sub



    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click
        limpiarFormulario()
        cmdNuevo.Enabled = False
        cmdGuardar.Enabled = True
        cmdCancelar.Enabled = True
        cmdFlechas.Enabled = False
        cmdLotes.Enabled = True
        cmdLonas.Enabled = True
        btProveedor.Enabled = True
        btModelo.Enabled = False
        btTejidos.Enabled = False
        GroupBox2.Enabled = False

        txRefProv.Focus()

    End Sub

    Private Sub cmdLotes_Click(sender As Object, e As EventArgs) Handles cmdLotes.Click
        pnLotes.Visible = True

    End Sub

    Private Sub btTejidos_Click(sender As Object, e As EventArgs) Handles btTejidos.Click
        pnTejidos.Visible = True
        cargarTejidos()
    End Sub
    Public Sub cargarTejidos()
        Dim conexionmy As New MySqlConnection("server=" + vServidor + "; User ID=" + vUsuario + "; database=" + vBasedatos)

        conexionmy.Open()

        Dim consultacolor As New MySqlCommand("SELECT colorID, coloreslona FROM colores_lona", conexionmy)
        Dim readercolor As MySqlDataReader
        Dim dtablecolor As New DataTable
        Dim bind5 As New BindingSource()

        readercolor = consultacolor.ExecuteReader
        dtablecolor.Load(readercolor, LoadOption.OverwriteChanges)
        bind5.DataSource = dtablecolor

        dgTejidos.DataSource = bind5
        dgTejidos.EnableHeadersVisualStyles = False
        Dim styCabeceras As DataGridViewCellStyle = New DataGridViewCellStyle()
        styCabeceras.BackColor = Color.Beige
        styCabeceras.ForeColor = Color.Black
        styCabeceras.Font = New Font("Verdana", 9, FontStyle.Bold)
        dgTejidos.ColumnHeadersDefaultCellStyle = styCabeceras

        dgTejidos.Columns(0).HeaderText = "ID"
        dgTejidos.Columns(0).Name = "Column21"
        dgTejidos.Columns(0).FillWeight = 30
        dgTejidos.Columns(0).MinimumWidth = 30
        dgTejidos.Columns(1).HeaderText = "COLORES"
        dgTejidos.Columns(1).Name = "Column22"
        dgTejidos.Columns(1).FillWeight = 260
        dgTejidos.Columns(1).MinimumWidth = 260

        dgTejidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgTejidos.Visible = True

        conexionmy.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        pnTejidos.Visible = False

    End Sub

    Private Sub dgTejidos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgTejidos.CellClick
        txTejidoID.Text = dgTejidos.CurrentRow.Cells(0).Value
        txTejido.Text = dgTejidos.CurrentRow.Cells(1).Value
        pnTejidos.Visible = False
    End Sub
    Public Sub montoDescripcion()
        txDescripcion.Text = txModelo.Text + " " + txTejido.Text + " " + txCodigo.Text
    End Sub

    Private Sub txModelo_TextChanged(sender As Object, e As EventArgs) Handles txModelo.TextChanged
        montoDescripcion()
    End Sub

    Private Sub txTejido_TextChanged(sender As Object, e As EventArgs) Handles txTejido.TextChanged
        montoDescripcion()
    End Sub

    Private Sub btCloseLotes_Click(sender As Object, e As EventArgs) Handles btCloseLotes.Click
        pnLotes.Visible = False

    End Sub

    Private Sub btNuevaLinea_Click(sender As Object, e As EventArgs) Handles btNuevaLinea.Click
        dgLotes.Rows.Add()
        dgLotes.Rows(dgLotes.Rows.Count - 1).Cells(0).Value = txRefProv.Text
        dgLotes.Rows(dgLotes.Rows.Count - 1).Cells(1).Value = txDescripcion.Text
        dgLotes.Rows(dgLotes.Rows.Count - 1).Cells(2).Value = ""
        dgLotes.Rows(dgLotes.Rows.Count - 1).Cells(3).Value = 0
        dgLotes.Rows(dgLotes.Rows.Count - 1).Cells(4).Value = ""

        dgLotes.Focus()
        dgLotes.CurrentCell = dgLotes.Rows(dgLotes.Rows.Count - 1).Cells(2)
        dgLotes.Rows(dgLotes.Rows.Count - 1).Cells(2).Selected = True
    End Sub

    Private Sub btEliminarLinea_Click(sender As Object, e As EventArgs) Handles btEliminarLinea.Click
        dgLotes.Rows.RemoveAt(dgLotes.CurrentRow.Index)
    End Sub

    Private Sub dgArticulos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgArticulos.CellDoubleClick

    End Sub

    Private Sub txCodigo1_TextChanged(sender As Object, e As EventArgs) Handles txCodigo1.TextChanged
        Dim conexionmy As New MySqlConnection("server=" + vServidor + "; User ID=" + vUsuario + "; database=" + vBasedatos)


        conexionmy.Open()
        Dim consultacli As New MySqlCommand("SELECT ref_proveedor, grupoID, descripcion, color, pvp FROM articulos2 WHERE ref_proveedor LIKE'" & txCodigo1.Text & "%'  ORDER BY ref_proveedor", conexionmy)

        Dim readermy As MySqlDataReader
        Dim dtable As New DataTable
        Dim bind As New BindingSource()


        readermy = consultacli.ExecuteReader
        dtable.Load(readermy, LoadOption.OverwriteChanges)

        bind.DataSource = dtable


        bind.DataSource = dtable
        dgArticulos.DataSource = bind
        dgArticulos.EnableHeadersVisualStyles = False
        Dim styCabeceras As DataGridViewCellStyle = New DataGridViewCellStyle()
        styCabeceras.BackColor = Color.Beige
        styCabeceras.ForeColor = Color.Black
        styCabeceras.Font = New Font("Verdana", 9, FontStyle.Bold)
        dgArticulos.ColumnHeadersDefaultCellStyle = styCabeceras

        dgArticulos.Columns(0).HeaderText = "REF PROVEEDOR"
        dgArticulos.Columns(0).Name = "Column1"
        dgArticulos.Columns(0).FillWeight = 125
        dgArticulos.Columns(0).MinimumWidth = 125
        dgArticulos.Columns(1).HeaderText = "GRUPO"
        dgArticulos.Columns(1).Name = "Column2"
        dgArticulos.Columns(1).FillWeight = 75
        dgArticulos.Columns(1).MinimumWidth = 75
        dgArticulos.Columns(2).HeaderText = "DESCRIPCION"
        dgArticulos.Columns(2).Name = "Column3"
        dgArticulos.Columns(2).FillWeight = 350
        dgArticulos.Columns(2).MinimumWidth = 350
        dgArticulos.Columns(3).HeaderText = "COLOR"
        dgArticulos.Columns(3).Name = "Column4"
        dgArticulos.Columns(3).FillWeight = 175
        dgArticulos.Columns(3).MinimumWidth = 175
        dgArticulos.Columns(4).HeaderText = "PVP"
        dgArticulos.Columns(4).Name = "Column5"
        dgArticulos.Columns(4).FillWeight = 75
        dgArticulos.Columns(4).MinimumWidth = 75
        'gridcliente.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        'gridcliente.Columns(4).Visible = False
        'gridcliente.Columns(5).Visible = False
        'gridcliente.Columns(6).Visible = False
        dgArticulos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgArticulos.Visible = True

        conexionmy.Close()
    End Sub

    Private Sub txArticulo_TextChanged(sender As Object, e As EventArgs) Handles txArticulo.TextChanged
        Dim conexionmy As New MySqlConnection("server=" + vServidor + "; User ID=" + vUsuario + "; database=" + vBasedatos)


        conexionmy.Open()
        Dim consultacli As New MySqlCommand("SELECT ref_proveedor, grupoID, descripcion, color, pvp FROM articulos2 WHERE descripcion LIKE'" & txArticulo.Text & "%'  ORDER BY ref_proveedor", conexionmy)

        Dim readermy As MySqlDataReader
        Dim dtable As New DataTable
        Dim bind As New BindingSource()


        readermy = consultacli.ExecuteReader
        dtable.Load(readermy, LoadOption.OverwriteChanges)

        bind.DataSource = dtable


        bind.DataSource = dtable
        dgArticulos.DataSource = bind
        dgArticulos.EnableHeadersVisualStyles = False
        Dim styCabeceras As DataGridViewCellStyle = New DataGridViewCellStyle()
        styCabeceras.BackColor = Color.Beige
        styCabeceras.ForeColor = Color.Black
        styCabeceras.Font = New Font("Verdana", 9, FontStyle.Bold)
        dgArticulos.ColumnHeadersDefaultCellStyle = styCabeceras

        dgArticulos.Columns(0).HeaderText = "REF PROVEEDOR"
        dgArticulos.Columns(0).Name = "Column1"
        dgArticulos.Columns(0).FillWeight = 125
        dgArticulos.Columns(0).MinimumWidth = 125
        dgArticulos.Columns(1).HeaderText = "GRUPO"
        dgArticulos.Columns(1).Name = "Column2"
        dgArticulos.Columns(1).FillWeight = 75
        dgArticulos.Columns(1).MinimumWidth = 75
        dgArticulos.Columns(2).HeaderText = "DESCRIPCION"
        dgArticulos.Columns(2).Name = "Column3"
        dgArticulos.Columns(2).FillWeight = 350
        dgArticulos.Columns(2).MinimumWidth = 350
        dgArticulos.Columns(3).HeaderText = "COLOR"
        dgArticulos.Columns(3).Name = "Column4"
        dgArticulos.Columns(3).FillWeight = 175
        dgArticulos.Columns(3).MinimumWidth = 175
        dgArticulos.Columns(4).HeaderText = "PVP"
        dgArticulos.Columns(4).Name = "Column5"
        dgArticulos.Columns(4).FillWeight = 75
        dgArticulos.Columns(4).MinimumWidth = 75
        'gridcliente.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        'gridcliente.Columns(4).Visible = False
        'gridcliente.Columns(5).Visible = False
        'gridcliente.Columns(6).Visible = False
        dgArticulos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgArticulos.Visible = True

        conexionmy.Close()
    End Sub
End Class