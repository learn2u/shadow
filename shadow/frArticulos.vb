Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Imports System.Globalization
Imports System.ComponentModel
Imports System.Xml
Public Class frArticulos
    Public flagEditArti As Boolean

    Public Sub cargoArticulos()
        Dim conexionmy As New MySqlConnection("server=" + vServidor + "; User ID=" + vUsuario + "; database=" + vBasedatos)

        conexionmy.Open()

        Dim consultfamilia As New MySqlCommand("SELECT * FROM familias ORDER BY nombrefamilia", conexionmy)
        Dim consultMedidas As New MySqlCommand("SELECT * FROM medidas ORDER BY medida", conexionmy)
        Dim consultacli As New MySqlCommand("SELECT ref_proveedor, grupoID, descripcion, color, pvp FROM articulos2 ORDER BY ref_proveedor", conexionmy)

        Dim readermy As MySqlDataReader
        Dim readerMedida As MySqlDataReader
        Dim dtable As New DataTable
        Dim dtableMedida As New DataTable
        Dim readercli As MySqlDataReader
        Dim dtablecli As New DataTable
        Dim bind As New BindingSource()
        Dim bind2 As New BindingSource()
        Dim bind3 As New BindingSource()

        readermy = consultfamilia.ExecuteReader
        dtable.Load(readermy, LoadOption.OverwriteChanges)

        readerMedida = consultMedidas.ExecuteReader
        dtableMedida.Load(readerMedida, LoadOption.OverwriteChanges)

        readercli = consultacli.ExecuteReader
        dtablecli.Load(readercli, LoadOption.OverwriteChanges)

        bind.DataSource = dtable
        bind2.DataSource = dtableMedida
        bind3.DataSource = dtablecli

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
        cbUnidad.DisplayMember = "medida"
        cbUnidad.ValueMember = "medidaID"

        conexionmy.Close()
    End Sub

    Private Sub frArticulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        deshabilitarBotones()
        TabControl1.SelectTab(1)
        cmdNuevo.Enabled = True
        cmdGuardar.Enabled = False
        cmdCancelar.Enabled = True


        txRefProv.Focus()

        cargoArticulos()

        flagEditArti = False
    End Sub

    Private Sub cmdLonas_Click(sender As Object, e As EventArgs) Handles cmdLonas.Click
        If GroupBox2.Enabled = False Then
            GroupBox2.Enabled = True

        Else
            GroupBox2.Enabled = False
        End If

    End Sub
    Public Sub deshabilitarBotones()
        cmdGuardar.Enabled = False
        cmdCancelar.Enabled = False
        cmdFlechas.Enabled = False
        cmdLonas.Enabled = False
        cmdLotes.Enabled = False
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
        txColor.Text = ""
        txColorID.Text = ""
        txUbicacion.Text = ""
        txMedida.Text = ""
        ckControlStock.Enabled = False
        txIva.Text = ""
        txCompra.Text = 0
        txDto.Text = 0
        txMargenPor.Text = 0
        txMargenEuro.Text = 0
        txPrecio.Text = 0
        txStock.Text = 0
        txDisponible.Text = 0
        txMinimo.Text = 0
        txInicial.Text = 0
        tsBotones.Focus()
        cmdNuevo.Select()
    End Sub

    Private Sub cmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click
        Dim conexionmy As New MySqlConnection("server=" + vServidor + "; User ID=" + vUsuario + "; database=" + vBasedatos)
        conexionmy.Open()

        Dim equiv As String
        Dim exento As String


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
            Dim stockdisp As String = txDisponible.Text
            Dim guardo_stockdisp As String = Replace(stockdisp, ",", ".")
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
            cmd.CommandText = "INSERT INTO clientes (ref_proveedor, referencia, grupoID, proveedorID, descripcion, modelo, tejido, familia, color, colorID, ubicacion, medida, unidad, control_stock, iva, precio_compra, dto_prov, porc_margen, euro_margen, pvp, stock, stock_disp, stock_min, stock_ini) VALUES ('" + txRefProv.Text + "' , '" + txCodigo.Text + "' , '" + txGrupo.Text + "' , '" + txNumPro.Text + "' , '" + txDescripcion.Text + "' , '" + txModelo.Text + "' , '" + txTejido.Text + "' , '" + cbFamilias.SelectedValue.ToString + "' , '" + txColor.Text + "' , '" + txColorID.Text + "' , '" + txUbicacion.Text + "' , '" + txMedida.Text + "' , '" + cbUnidad.SelectedValue.ToString + "' , '" + equiv + "' , '" + guardo_iva + "' , '" + guardo_compra + "' , '" + guardo_dto + "' , '" + guardo_margenpor + "' , '" + guardo_margeneur + "' , '" + guardo_precio + "' , '" + guardo_stock + "' , '" + guardo_stockdisp + "' , '" + guardo_stockmin + "' , '" + guardo_stockini + "')"

            cmd.Connection = conexionmy

            cmd.ExecuteNonQuery()

            numid = cmdLastId.ExecuteScalar()

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
            Dim stockdisp As String = txDisponible.Text
            Dim guardo_stockdisp As String = Replace(stockdisp, ",", ".")
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
                                                medida= '" + txMedida.Text + "',
                                                tejido = '" + txTejido.Text + "',
                                                modelo = '" + txModelo.Text + "',
                                                familia = '" + cbFamilias.SelectedValue.ToString + "',
                                                color = '" + txColor.Text + "',
                                                colorID = '" + txColorID.Text + "',
                                                ubicacion = '" + txUbicacion.Text + "',
                                                medida = '" + txMedida.Text + "',
                                                unidad = '" + cbUnidad.SelectedValue.ToString + "',
                                                control_stock = '" + equiv + "',
                                                iva = '" + guardo_iva + "',
                                                compra = '" + guardo_compra + "',
                                                dto_prov = '" + guardo_dto + "',
                                                porc_margen = '" + guardo_margenpor + "',
                                                euro_margen = '" + guardo_margeneur + "',
                                                pvp = '" + guardo_precio + "',
                                                stock = '" + guardo_stock + "',
                                                stock_disp = '" + guardo_stockdisp + "',
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
End Class