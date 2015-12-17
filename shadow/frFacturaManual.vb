Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Imports System.Globalization
Imports System.ComponentModel
Imports System.Xml
Public Class frFacturaManual
    Public Shared lineas As Int16
    Public Shared pos As Integer
    Public Shared flagEdit As String = "N"
    Public Shared lineasEdit As New List(Of lineasEditadas)
    Public Shared artiEdit As String
    Public Shared cantIni As Decimal
    Public Shared cantFin As Decimal
    Public Shared serieIni As String
    Private Sub frFacturaManual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        deshabilitarBotones()

        lineas = 0

        If flagEdit = "N" Then
            dgLineasPres1.Visible = True
            dgLineasPres2.Visible = False
        Else
            dgLineasPres1.Visible = False
            dgLineasPres2.Visible = True
        End If

        cargoTodasFacturas()
    End Sub
    Public Sub deshabilitarBotones()
        cmdGuardar.Enabled = False
        cmdCancelar.Enabled = False
        cmdImprimir.Enabled = False
        cmdPDF.Enabled = False
        cmdMail.Enabled = False
        cmdPedido.Enabled = False
        cmdAlbaran.Enabled = False
        cmdToldos.Enabled = False
        cmdCliente.Enabled = False
        cmdRentabilidad.Enabled = False
        cmdLineas.Enabled = False
    End Sub
    Public Sub cargoTodasFacturas()
        Dim conexionmy As New MySqlConnection("server=" + vServidor + "; User ID=" + vUsuario + "; database=" + vBasedatos + "; Convert Zero Datetime=True")
        conexionmy.Open()
        Dim consultamy As New MySqlCommand("SELECT factura_cab.num_factura, 
                                                    factura_cab.referencia,
                                                    factura_cab.fecha, 
                                                    clientes.nombre, 
                                                    factura_cab.totalbruto, 
                                                    factura_cab.totalfactura, 
                                                    factura_cab.clienteID, 
                                                    clientes.clienteID,
                                                    clientes.codigo 
                                            FROM factura_cab INNER JOIN clientes ON factura_cab.clienteID=clientes.codigo ORDER BY factura_cab.num_factura DESC", conexionmy)

        Dim readermy As MySqlDataReader
        Dim dtable As New DataTable
        Dim bind As New BindingSource()


        readermy = consultamy.ExecuteReader
        dtable.Load(readermy, LoadOption.OverwriteChanges)

        bind.DataSource = dtable

        dgFacturas.DataSource = bind
        dgFacturas.EnableHeadersVisualStyles = False
        Dim styCabeceras As DataGridViewCellStyle = New DataGridViewCellStyle()
        styCabeceras.BackColor = Color.Beige
        styCabeceras.ForeColor = Color.Black
        styCabeceras.Font = New Font("Verdana", 9, FontStyle.Bold)
        dgFacturas.ColumnHeadersDefaultCellStyle = styCabeceras

        dgFacturas.Columns(0).HeaderText = "NUMERO"
        dgFacturas.Columns(0).Name = "Column1"
        dgFacturas.Columns(0).FillWeight = 90
        dgFacturas.Columns(0).MinimumWidth = 90
        dgFacturas.Columns(1).HeaderText = "REFERENCIA"
        dgFacturas.Columns(1).Name = "Column2"
        dgFacturas.Columns(1).FillWeight = 190
        dgFacturas.Columns(1).MinimumWidth = 190
        dgFacturas.Columns(2).HeaderText = "FECHA"
        dgFacturas.Columns(2).Name = "Column3"
        dgFacturas.Columns(2).FillWeight = 90
        dgFacturas.Columns(2).MinimumWidth = 90
        dgFacturas.Columns(3).HeaderText = "CLIENTE"
        dgFacturas.Columns(3).Name = "Column4"
        dgFacturas.Columns(3).FillWeight = 300
        dgFacturas.Columns(3).MinimumWidth = 300
        dgFacturas.Columns(4).HeaderText = "IMPORTE"
        dgFacturas.Columns(4).Name = "Column5"
        dgFacturas.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgFacturas.Columns(4).FillWeight = 90
        dgFacturas.Columns(4).MinimumWidth = 90
        dgFacturas.Columns(5).HeaderText = "TOTAL"
        dgFacturas.Columns(5).Name = "Column6"
        dgFacturas.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgFacturas.Columns(5).FillWeight = 90
        dgFacturas.Columns(5).MinimumWidth = 90
        dgFacturas.Columns(6).Visible = False
        dgFacturas.Columns(7).Visible = False
        dgFacturas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgFacturas.Visible = True

        conexionmy.Close()
    End Sub
End Class