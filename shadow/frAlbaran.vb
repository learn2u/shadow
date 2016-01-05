Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Imports System.Globalization
Imports System.ComponentModel
Imports System.Xml
Public Class frAlbaran
    Public Shared lineas As Int16
    Public Shared pos As Integer
    Public Shared flagEdit As String = "N"
    Public Shared lineasEdit As New List(Of lineasEditadas)
    Public Shared artiEdit As String
    Public Shared cantIni As Decimal
    Public Shared cantFin As Decimal
    Public Shared serieIni As String
    Public Shared posicion As Integer

    Private Sub frAlbaran_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        deshabilitarBotones()

        lineas = 0

        If flagEdit = "N" Then
            dgLineasPres1.Visible = True
            dgLineasPres2.Visible = False
        Else
            dgLineasPres1.Visible = False
            dgLineasPres2.Visible = True
        End If

        cargoTodosAlbaranes()
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
    Public Sub cargoTodosAlbaranes()
        Dim conexionmy As New MySqlConnection("server=" + vServidor + "; User ID=" + vUsuario + "; database=" + vBasedatos + "; Convert Zero Datetime=True")
        conexionmy.Open()
        Dim consultamy As New MySqlCommand("SELECT albaran_cab.num_albaran, 
                                                    albaran_cab.referencia,
                                                    albaran_cab.fecha, 
                                                    clientes.nombre, 
                                                    albaran_cab.totalbruto, 
                                                    albaran_cab.totalalbaran, 
                                                    albaran_cab.clienteID, 
                                                    clientes.clienteID
                                            FROM albaran_cab INNER JOIN clientes ON albaran_cab.clienteID=clientes.clienteID ORDER BY albaran_cab.num_albaran DESC", conexionmy)

        Dim readermy As MySqlDataReader
        Dim dtable As New DataTable
        Dim bind As New BindingSource()


        readermy = consultamy.ExecuteReader
        dtable.Load(readermy, LoadOption.OverwriteChanges)

        bind.DataSource = dtable

        dgAlbaranes.DataSource = bind
        dgAlbaranes.EnableHeadersVisualStyles = False
        Dim styCabeceras As DataGridViewCellStyle = New DataGridViewCellStyle()
        styCabeceras.BackColor = Color.Beige
        styCabeceras.ForeColor = Color.Black
        styCabeceras.Font = New Font("Verdana", 9, FontStyle.Bold)
        dgAlbaranes.ColumnHeadersDefaultCellStyle = styCabeceras

        dgAlbaranes.Columns(0).HeaderText = "NUMERO"
        dgAlbaranes.Columns(0).Name = "Column1"
        dgAlbaranes.Columns(0).FillWeight = 90
        dgAlbaranes.Columns(0).MinimumWidth = 90
        dgAlbaranes.Columns(1).HeaderText = "REFERENCIA"
        dgAlbaranes.Columns(1).Name = "Column2"
        dgAlbaranes.Columns(1).FillWeight = 190
        dgAlbaranes.Columns(1).MinimumWidth = 190
        dgAlbaranes.Columns(2).HeaderText = "FECHA"
        dgAlbaranes.Columns(2).Name = "Column3"
        dgAlbaranes.Columns(2).FillWeight = 90
        dgAlbaranes.Columns(2).MinimumWidth = 90
        dgAlbaranes.Columns(3).HeaderText = "CLIENTE"
        dgAlbaranes.Columns(3).Name = "Column4"
        dgAlbaranes.Columns(3).FillWeight = 300
        dgAlbaranes.Columns(3).MinimumWidth = 300
        dgAlbaranes.Columns(4).HeaderText = "IMPORTE"
        dgAlbaranes.Columns(4).Name = "Column5"
        dgAlbaranes.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgAlbaranes.Columns(4).FillWeight = 90
        dgAlbaranes.Columns(4).MinimumWidth = 90
        dgAlbaranes.Columns(5).HeaderText = "TOTAL"
        dgAlbaranes.Columns(5).Name = "Column6"
        dgAlbaranes.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgAlbaranes.Columns(5).FillWeight = 90
        dgAlbaranes.Columns(5).MinimumWidth = 90
        dgAlbaranes.Columns(6).Visible = False
        dgAlbaranes.Columns(7).Visible = False
        dgAlbaranes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgAlbaranes.Visible = True

        conexionmy.Close()
    End Sub
    Public Sub limpiarFormulario()
        txtNumpres.Text = ""
        txFecha.Text = ""
        txReferenciapres.Text = ""
        txBultos.Text = 0
        txNumcli.Text = ""
        txClientepres.Text = ""
        txAgente.Text = ""
        txDtocli.Text = ""
        txIva.Text = ""
        cbEstado.Text = ""
        cbEnvio.Text = ""
        txObserva.Text = ""
        txImpBruto.Text = 0
        txImpDto.Text = 0
        txImponible.Text = 0
        txImpIva.Text = 0
        txImpRecargo.Text = 0
        txTotalAlbaran.Text = 0
        tsBotones.Focus()
        cmdNuevo.Select()
        dgLineasPres1.Rows.Clear()
    End Sub

    Private Sub cmdLineas_ButtonClick(sender As Object, e As EventArgs) Handles cmdLineas.ButtonClick
        If txNumcli.Text = "" Then
            MsgBox("Antes de añadir líneas al albarán es necesario seleccionar un cliente")
            formCli = "A"
            frVerClientes.Show()
        Else
            If flagEdit = "N" Then
                lineas = lineas + 1
                dgLineasPres1.Rows.Add()
                dgLineasPres1.Rows(dgLineasPres1.Rows.Count - 1).Cells(0).Value = lineas
                dgLineasPres1.Rows(dgLineasPres1.Rows.Count - 1).Cells(4).Value = 0
                dgLineasPres1.Rows(dgLineasPres1.Rows.Count - 1).Cells(5).Value = 0
                dgLineasPres1.Rows(dgLineasPres1.Rows.Count - 1).Cells(6).Value = 0
                dgLineasPres1.Rows(dgLineasPres1.Rows.Count - 1).Cells(7).Value = 0
                dgLineasPres1.Rows(dgLineasPres1.Rows.Count - 1).Cells(8).Value = txDtocli.Text
                dgLineasPres1.Rows(dgLineasPres1.Rows.Count - 1).Cells(9).Value = 0
                dgLineasPres1.Rows(dgLineasPres1.Rows.Count - 1).Cells(10).Value = 0
                dgLineasPres1.Rows(dgLineasPres1.Rows.Count - 1).Cells(11).Value = ""
                dgLineasPres1.Focus()
                dgLineasPres1.CurrentCell = dgLineasPres1.Rows(dgLineasPres1.Rows.Count - 1).Cells(2)
                dgLineasPres1.Rows(dgLineasPres1.Rows.Count - 1).Cells(2).Selected = True
            Else
                lineas = lineas + 1
                dgLineasPres2.Rows.Add()
                dgLineasPres2.Rows(dgLineasPres2.Rows.Count - 1).Cells(0).Value = lineas
                dgLineasPres2.Rows(dgLineasPres2.Rows.Count - 1).Cells(4).Value = 0
                dgLineasPres2.Rows(dgLineasPres2.Rows.Count - 1).Cells(5).Value = 0
                dgLineasPres2.Rows(dgLineasPres2.Rows.Count - 1).Cells(6).Value = 0
                dgLineasPres2.Rows(dgLineasPres2.Rows.Count - 1).Cells(7).Value = 0
                dgLineasPres2.Rows(dgLineasPres2.Rows.Count - 1).Cells(8).Value = txDtocli.Text
                dgLineasPres2.Rows(dgLineasPres2.Rows.Count - 1).Cells(9).Value = 0
                dgLineasPres2.Rows(dgLineasPres2.Rows.Count - 1).Cells(10).Value = 0
                dgLineasPres2.Rows(dgLineasPres2.Rows.Count - 1).Cells(11).Value = ""
                dgLineasPres2.Focus()
                dgLineasPres2.CurrentCell = dgLineasPres2.Rows(dgLineasPres2.Rows.Count - 1).Cells(2)
                dgLineasPres2.Rows(dgLineasPres2.Rows.Count - 1).Cells(2).Selected = True
            End If

        End If
    End Sub

    Private Sub INSERTARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles INSERTARToolStripMenuItem.Click
        If flagEdit = "N" Then
            dgLineasPres1.Rows.Insert(dgLineasPres1.CurrentRow.Index)
            renumerar()
            dgLineasPres1.CurrentCell = dgLineasPres1.Rows(dgLineasPres1.CurrentRow.Index - 1).Cells(4)

            pos = dgLineasPres1.CurrentRow.Index

            dgLineasPres1.CurrentRow.Cells(4).Value = 0
            dgLineasPres1.CurrentRow.Cells(5).Value = 0
            dgLineasPres1.CurrentRow.Cells(6).Value = 0
            dgLineasPres1.CurrentRow.Cells(7).Value = 0
            dgLineasPres1.CurrentRow.Cells(8).Value = txDtocli.Text
            dgLineasPres1.CurrentRow.Cells(9).Value = 0
            dgLineasPres1.CurrentRow.Cells(10).Value = 0
            dgLineasPres1.CurrentRow.Cells(11).Value = ""
        Else
            dgLineasPres2.Rows.Insert(dgLineasPres2.CurrentRow.Index)
            renumerar()
            dgLineasPres2.CurrentCell = dgLineasPres2.Rows(dgLineasPres2.CurrentRow.Index - 1).Cells(4)

            pos = dgLineasPres2.CurrentRow.Index

            dgLineasPres2.CurrentRow.Cells(4).Value = 0
            dgLineasPres2.CurrentRow.Cells(5).Value = 0
            dgLineasPres2.CurrentRow.Cells(6).Value = 0
            dgLineasPres2.CurrentRow.Cells(7).Value = 0
            dgLineasPres2.CurrentRow.Cells(8).Value = txDtocli.Text
            dgLineasPres2.CurrentRow.Cells(9).Value = 0
            dgLineasPres2.CurrentRow.Cells(10).Value = 0
            dgLineasPres2.CurrentRow.Cells(11).Value = ""
        End If
    End Sub
    Public Sub renumerar()
        lineas = 1
        If flagEdit = "N" Then
            For Each row As DataGridViewRow In dgLineasPres1.Rows
                row.Cells(0).Value = lineas
                lineas = lineas + 1
            Next
        Else
            For Each row As DataGridViewRow In dgLineasPres2.Rows
                row.Cells(0).Value = lineas
                lineas = lineas + 1
            Next
        End If


    End Sub
    Public Sub recalcularTotales()
        Dim totalLinea As Decimal = 0
        Dim dtoLinea As Decimal = 0
        Dim ivaLinea As Decimal = 0

        If flagEdit = "N" Then
            For Each row2 As DataGridViewRow In dgLineasPres1.Rows
                totalLinea = totalLinea + Decimal.Parse(row2.Cells(9).Value)
                dtoLinea = dtoLinea + (Decimal.Parse(row2.Cells(9).Value) * Decimal.Parse(row2.Cells(8).Value)) / 100
            Next
        Else
            For Each row2 As DataGridViewRow In dgLineasPres2.Rows
                totalLinea = totalLinea + Decimal.Parse(row2.Cells(9).Value)
                dtoLinea = dtoLinea + (Decimal.Parse(row2.Cells(9).Value) * Decimal.Parse(row2.Cells(8).Value)) / 100
            Next
        End If

        txImpBruto.Text = totalLinea.ToString("0.00")
        txImpDto.Text = dtoLinea.ToString("0.00")
        txImponible.Text = (totalLinea - dtoLinea).ToString("0.00")
        'ivaLinea = (Decimal.Parse(txImponible.Text) * Decimal.Parse(txIva.Text)) / 100
        ivaLinea = (Decimal.Parse(txImponible.Text) * 21) / 100
        txImpIva.Text = ivaLinea.ToString("0.00")
        txTotalAlbaran.Text = (Decimal.Parse(txImponible.Text) + ivaLinea).ToString("0.00")

    End Sub
    Public Sub actualizarLinea()
        If flagEdit = "N" Then
            If dgLineasPres1.CurrentRow IsNot Nothing Then
                Dim total2 As Decimal
                Dim dto2 As Decimal
                Dim totaldef As Decimal
                Dim medida As Decimal

                If dgLineasPres1.CurrentRow.Cells(5).Value = 0 Then
                    total2 = Decimal.Parse(dgLineasPres1.CurrentRow.Cells(4).Value) * Decimal.Parse(dgLineasPres1.CurrentRow.Cells(7).Value)
                Else
                    medida = Decimal.Parse(dgLineasPres1.CurrentRow.Cells(4).Value) * Decimal.Parse(dgLineasPres1.CurrentRow.Cells(5).Value)
                    dgLineasPres1.CurrentRow.Cells(6).Value = medida
                    total2 = Decimal.Parse(dgLineasPres1.CurrentRow.Cells(6).Value) * Decimal.Parse(dgLineasPres1.CurrentRow.Cells(7).Value)
                End If

                dto2 = (total2 * Decimal.Parse(dgLineasPres1.CurrentRow.Cells(8).Value)) / 100


                totaldef = (total2 - dto2).ToString("0.00")

                dgLineasPres1.CurrentRow.Cells(9).Value = total2
                dgLineasPres1.CurrentRow.Cells(10).Value = totaldef
            End If
        Else
            If dgLineasPres2.CurrentRow IsNot Nothing Then
                Dim total2 As Decimal
                Dim dto2 As Decimal
                Dim totaldef As Decimal
                Dim medida As Decimal

                If dgLineasPres2.CurrentRow.Cells(5).Value = 0 Then
                    total2 = Decimal.Parse(dgLineasPres2.CurrentRow.Cells(4).Value) * Decimal.Parse(dgLineasPres2.CurrentRow.Cells(7).Value)
                Else
                    medida = Decimal.Parse(dgLineasPres2.CurrentRow.Cells(4).Value) * Decimal.Parse(dgLineasPres2.CurrentRow.Cells(5).Value)
                    dgLineasPres2.CurrentRow.Cells(6).Value = medida
                    total2 = Decimal.Parse(dgLineasPres2.CurrentRow.Cells(6).Value) * Decimal.Parse(dgLineasPres2.CurrentRow.Cells(7).Value)
                End If

                dto2 = (total2 * Decimal.Parse(dgLineasPres2.CurrentRow.Cells(8).Value)) / 100


                totaldef = (total2 - dto2).ToString("0.00")

                dgLineasPres2.CurrentRow.Cells(9).Value = total2
                dgLineasPres2.CurrentRow.Cells(10).Value = totaldef
            End If
        End If


    End Sub

    Private Sub dgLineasPres1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgLineasPres1.CellEndEdit
        If (e.ColumnIndex = 4 Or e.ColumnIndex = 7 Or e.ColumnIndex = 8) Then
            actualizarLinea()
            recalcularTotales()

        End If
        If (e.ColumnIndex = 2) Then
            Dim vRef As String = dgLineasPres1.CurrentCell.Value
            cargarArticulos(vRef)
        End If
    End Sub

    Private Sub cmdCliente_ButtonClick(sender As Object, e As EventArgs) Handles cmdCliente.ButtonClick
        formCli = "A"
        frVerClientes.Show()
    End Sub

    Private Sub dgLineasPres1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgLineasPres1.CellClick
        If (e.ColumnIndex = 1) Then
            formArti = "A"
            frVerArticulos.Show()
        End If
        pos = dgLineasPres1.CurrentRow.Index
    End Sub

    Private Sub ELIMINARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ELIMINARToolStripMenuItem.Click
        If flagEdit = "N" Then
            dgLineasPres1.Rows.RemoveAt(dgLineasPres1.CurrentRow.Index)
            renumerar()
            recalcularTotales()
        Else
            'Cargo los datos de la linea para el control de stocks
            artiEdit = dgLineasPres2.CurrentRow.Cells(2).Value
            cantIni = Decimal.Parse(dgLineasPres2.CurrentRow.Cells(4).Value)
            cantFin = 0
            lineasEdit.Add(New lineasEditadas() With {.codigoArt = artiEdit, .cantAntes = cantIni, .cantDespues = cantFin})

            dgLineasPres2.Rows.RemoveAt(dgLineasPres2.CurrentRow.Index)
            renumerar()
            recalcularTotales()
        End If
    End Sub

    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click
        cmdNuevo.Enabled = False
        cmdGuardar.Enabled = True
        cmdCancelar.Enabled = True
        cmdLineas.Enabled = True
        cmdCliente.Enabled = True
        limpiarFormulario()
        flagEdit = "N"
        dgLineasPres2.Visible = False
        dgLineasPres1.Visible = True
        cbSerie.Text = "S1"
        cbEstado.Text = "NO FACTURADO"
        txFecha.Text = Format(Today, "ddMMyyyy")
        txReferenciapres.Focus()
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        cmdNuevo.Enabled = True
        deshabilitarBotones()
        limpiarFormulario()
        If flagEdit = "S" Then
            flagEdit = "N"
        End If
        tabPresupuestos.SelectTab(0)
    End Sub

    Private Sub cmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click
        Dim vSerie As String
        If cbSerie.Text = "S1" Then
            vSerie = "1"
        Else
            vSerie = "2"
        End If
        If flagEdit = "N" Then
            cargoNumero()

            Dim impbru As String = txImpBruto.Text
            Dim guardo_impbru As String = Replace(impbru, ",", ".")
            Dim impdto As String = txImpDto.Text
            Dim guardo_impdto As String = Replace(impdto, ",", ".")
            Dim impiva As String = txImpIva.Text
            Dim guardo_impiva As String = Replace(impiva, ",", ".")
            Dim imptot As String = txTotalAlbaran.Text
            Dim guardo_imptot As String = Replace(imptot, ",", ".")

            Dim fecha As Date = txFecha.Text

            'Guardo cabecera y actualizo número de presupuesto
            Dim conexionmy As New MySqlConnection("server=" + vServidor + "; User ID=" + vUsuario + "; database=" + vBasedatos)
            conexionmy.Open()
            Dim cmd As New MySqlCommand("INSERT INTO albaran_cab (num_albaran, serie, clienteID, envioID, empresaID, agenteID, usuarioID, fecha, referencia, bultos, observaciones, totalbruto, totaldto, totaliva, totalalbaran, facturado) VALUES (" + txtNumpres.Text + ", '" + vSerie + "'," + txNumcli.Text + ", " + cbEnvio.SelectedValue.ToString + ", " + txEmpresa.Text + ", " + txAgente.Text + ", " + txUsuario.Text + ", '" + fecha.ToString("yyyy-MM-dd") + "',  '" + txReferenciapres.Text + "', '" + txBultos.Text + "', '" + txObserva.Text + "', '" + guardo_impbru + "', '" + guardo_impdto + "',  '" + guardo_impiva + "', '" + guardo_imptot + "', 'N')", conexionmy)
            cmd.ExecuteNonQuery()
            If cbSerie.Text = "S1" Then
                Dim cmdActualizar As New MySqlCommand("UPDATE configuracion SET num_albaran = '" + txtNumpres.Text + "'", conexionmy)
                cmdActualizar.ExecuteNonQuery()
            Else
                Dim cmdActualizar As New MySqlCommand("UPDATE configuracion SET num_albaran_2 = '" + txtNumpres.Text + "'", conexionmy)
                cmdActualizar.ExecuteNonQuery()
            End If


            'Guardo líneas del presupuesto

            Dim cmdLinea As New MySqlCommand
            Dim row As New DataGridViewRow

            Dim lincant As String
            Dim guardo_lincant As String
            Dim linancho As String
            Dim guardo_linancho As String
            Dim linmetros As String
            Dim guardo_linmetros As String
            Dim linprec As String
            Dim guardo_linprec As String
            Dim lindto As String
            Dim guardo_lindto As String
            Dim liniva As String
            Dim guardo_liniva As String
            Dim linimporte As String
            Dim guardo_linimporte As String
            Dim lintotal As String
            Dim guardo_lintotal As String
            Dim arti As String

            For Each row In dgLineasPres1.Rows


                lincant = Decimal.Parse(row.Cells(4).Value).ToString("0.00")
                guardo_lincant = Replace(lincant, ",", ".")

                linancho = row.Cells(5).Value.ToString
                guardo_linancho = Replace(linancho, ",", ".")

                linmetros = row.Cells(6).Value.ToString
                guardo_linmetros = Replace(linmetros, ",", ".")

                linprec = row.Cells(7).Value.ToString
                guardo_linprec = Replace(linprec, ",", ".")

                lindto = row.Cells(8).Value.ToString
                guardo_lindto = Replace(lindto, ",", ".")

                liniva = txIva.Text
                guardo_liniva = Replace(liniva, ",", ".")

                linimporte = row.Cells(9).Value.ToString
                guardo_linimporte = Replace(linimporte, ",", ".")

                lintotal = row.Cells(10).Value.ToString
                guardo_lintotal = Replace(lintotal, ",", ".")

                arti = row.Cells(2).Value

                cmdLinea.Connection = conexionmy
                cmdLinea.CommandText = "INSERT INTO albaran_linea (num_albaran, linea, codigo, descripcion, cantidad, ancho_largo, m2_ml, precio, descuento, ivalinea, importe, totalinea, lote) VALUES ('" + txtNumpres.Text + "', " + row.Cells(0).Value.ToString + ", '" + row.Cells(2).Value + "', '" + row.Cells(3).Value + "', '" + guardo_lincant + "', '" + guardo_linancho + "', '" + guardo_linmetros + "', '" + guardo_linprec + "', '" + guardo_lindto + "', '" + guardo_liniva + "', '" + guardo_linimporte + "', '" + guardo_lintotal + "', '" + row.Cells(11).Value + "')"

                cmdLinea.ExecuteNonQuery()
                If row.Cells(11).Value = "" Then
                    'descontarStock(arti, lincant)
                    'MsgBox("no hay lote")
                Else
                    'MsgBox(row.Cells(11).Value)
                End If

            Next

            conexionmy.Close()

            deshabilitarBotones()
            limpiarFormulario()
            cmdNuevo.Enabled = True
            cargoTodosAlbaranes()
            tabPresupuestos.SelectTab(0)
        Else

            Dim conexionmy As New MySqlConnection("server=" + vServidor + "; User ID=" + vUsuario + "; database=" + vBasedatos)
            conexionmy.Open()

            Dim impbru As String = txImpBruto.Text
            Dim guardo_impbru As String = Replace(impbru, ",", ".")
            Dim impdto As String = txImpDto.Text
            Dim guardo_impdto As String = Replace(impdto, ",", ".")
            Dim impiva As String = txImpIva.Text
            Dim guardo_impiva As String = Replace(impiva, ",", ".")
            Dim imptot As String = txTotalAlbaran.Text
            Dim guardo_imptot As String = Replace(imptot, ",", ".")

            Dim fecha As Date = txFecha.Text

            'Guardo cabecera y actualizo número de presupuesto

            If vSerie = serieIni Then
                Dim cmd As New MySqlCommand("UPDATE albaran_cab SET fecha = '" + fecha.ToString("yyyy-MM-dd") + "', clienteID = " + txNumcli.Text + ", agenteID = " + txAgente.Text + ", referencia = '" + txReferenciapres.Text + "', bultos = '" + txBultos.Text + "', observaciones = '" + txObserva.Text + "', totalbruto = '" + guardo_impbru + "', totaldto = '" + guardo_impdto + "', totaliva = '" + guardo_impiva + "', totalalbaran = '" + guardo_imptot + "', serie = '" + vSerie + "' WHERE num_albaran = " + txtNumpres.Text + "", conexionmy)
                cmd.ExecuteNonQuery()

            Else
                Dim cmdEliminarLin As New MySqlCommand("DELETE FROM albaran_linea WHERE num_albaran = '" + txtNumpres.Text + "'", conexionmy)
                cmdEliminarLin.ExecuteNonQuery()
                Dim cmdEliminarCab As New MySqlCommand("DELETE FROM albaran_cab WHERE num_albaran = '" + txtNumpres.Text + "'", conexionmy)
                cmdEliminarCab.ExecuteNonQuery()
                cargoNumero()
                Dim cmd As New MySqlCommand("INSERT INTO albaran_cab (num_albaran, serie, clienteID, envioID, empresaID, agenteID, usuarioID, fecha, referencia, bultos, observaciones, totalbruto, totaldto, totaliva, totalalbaran, facturado) VALUES (" + txtNumpres.Text + ", '" + vSerie + "'," + txNumcli.Text + ", " + cbEnvio.SelectedValue.ToString + ", " + txEmpresa.Text + ", " + txAgente.Text + ", " + txUsuario.Text + ", '" + fecha.ToString("yyyy-MM-dd") + "',  '" + txReferenciapres.Text + "', '" + txBultos.Text + "','" + txObserva.Text + "', '" + guardo_impbru + "', '" + guardo_impdto + "',  '" + guardo_impiva + "', '" + guardo_imptot + "', 'N')", conexionmy)
                cmd.ExecuteNonQuery()
                If cbSerie.Text = "S1" Then
                    Dim cmdActualizar As New MySqlCommand("UPDATE configuracion SET num_albaran = '" + txtNumpres.Text + "'", conexionmy)
                    cmdActualizar.ExecuteNonQuery()
                Else
                    Dim cmdActualizar As New MySqlCommand("UPDATE configuracion SET num_albaran_2 = '" + txtNumpres.Text + "'", conexionmy)
                    cmdActualizar.ExecuteNonQuery()
                End If

            End If

            Dim cmdEliminar As New MySqlCommand("DELETE FROM albaran_linea WHERE num_albaran = '" + txtNumpres.Text + "'", conexionmy)
            cmdEliminar.ExecuteNonQuery()

            'Guardo líneas del presupuesto

            Dim cmdLinea As New MySqlCommand
            Dim row As New DataGridViewRow

            Dim lincant As String
            Dim guardo_lincant As String
            Dim linancho As String
            Dim guardo_linancho As String
            Dim linmetros As String
            Dim guardo_linmetros As String
            Dim linprec As String
            Dim guardo_linprec As String
            Dim lindto As String
            Dim guardo_lindto As String
            Dim liniva As String
            Dim guardo_liniva As String
            Dim linimporte As String
            Dim guardo_linimporte As String
            Dim lintotal As String
            Dim guardo_lintotal As String

            For Each row In dgLineasPres2.Rows


                lincant = Decimal.Parse(row.Cells(4).Value).ToString("0.00")
                guardo_lincant = Replace(lincant, ",", ".")

                linancho = row.Cells(5).Value.ToString
                guardo_linancho = Replace(linancho, ",", ".")

                linmetros = row.Cells(6).Value.ToString
                guardo_linmetros = Replace(linmetros, ",", ".")

                linprec = row.Cells(7).Value.ToString
                guardo_linprec = Replace(linprec, ",", ".")

                lindto = row.Cells(8).Value.ToString
                guardo_lindto = Replace(lindto, ",", ".")

                liniva = txIva.Text
                guardo_liniva = Replace(liniva, ",", ".")

                linimporte = row.Cells(9).Value.ToString
                guardo_linimporte = Replace(linimporte, ",", ".")

                lintotal = row.Cells(10).Value.ToString
                guardo_lintotal = Replace(lintotal, ",", ".")

                cmdLinea.Connection = conexionmy
                cmdLinea.CommandText = "INSERT INTO albaran_linea (num_albaran, linea, codigo, descripcion, cantidad, ancho_largo, m2_ml, precio, descuento, ivalinea, importe, totalinea, lote) VALUES ('" + txtNumpres.Text + "', " + row.Cells(0).Value.ToString + ", '" + row.Cells(2).Value + "', '" + row.Cells(3).Value + "', '" + guardo_lincant + "', '" + guardo_linancho + "', '" + guardo_linmetros + "', '" + guardo_linprec + "', '" + guardo_lindto + "', '" + guardo_liniva + "', '" + guardo_linimporte + "', '" + guardo_lintotal + "', '" + row.Cells(11).Value + "')"

                cmdLinea.ExecuteNonQuery()


            Next

            conexionmy.Close()

            If lineasEdit.Count > 0 Then
                For Each itemlineas As lineasEditadas In lineasEdit
                    aumentarStock(itemlineas.codigoArt, itemlineas.cantAntes)
                    descontarStock(itemlineas.codigoArt, itemlineas.cantDespues)
                Next
            End If
            lineasEdit.Clear()


            deshabilitarBotones()
                limpiarFormulario()
                cmdNuevo.Enabled = True
                cargoTodosAlbaranes()
                tabPresupuestos.SelectTab(0)
                flagEdit = "N"
            End If
    End Sub
    Public Sub cargoNumero()
        Dim conexionmy As New MySqlConnection("server=" + vServidor + "; User ID=" + vUsuario + "; database=" + vBasedatos)
        conexionmy.Open()

        Dim numid As Int32

        If cbSerie.Text = "S1" Then
            Dim cmdLastId As New MySqlCommand("SELECT num_albaran FROM configuracion  ", conexionmy)
            numid = cmdLastId.ExecuteScalar()
        Else
            Dim cmdLastId As New MySqlCommand("SELECT num_albaran_2 FROM configuracion  ", conexionmy)
            numid = cmdLastId.ExecuteScalar()
        End If

        txtNumpres.Text = numid + 1

        conexionmy.Close()

    End Sub

    Private Sub dgAlbaranes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgAlbaranes.CellClick
        limpiarFormulario()
        cmdLineas.Enabled = True
        cmdGuardar.Enabled = True
        cmdCancelar.Enabled = True
        cmdCliente.Enabled = True

        txtNumpres.Text = dgAlbaranes.CurrentRow.Cells("Column1").Value.ToString
        tabPresupuestos.SelectTab(1)
        flagEdit = "S"
        dgLineasPres1.Visible = False
        dgLineasPres2.Visible = True
        dgLineasPres2.Rows.Clear()


        cargoAlbaran()
        cargoLineas()
        recalcularTotales()
    End Sub
    Public Sub cargoAlbaran()
        Dim conexionmy As New MySqlConnection("server=" + vServidor + "; User ID=" + vUsuario + "; database=" + vBasedatos)
        conexionmy.Open()
        Dim cmdCab As New MySqlCommand

        Dim cmdCli As New MySqlCommand

        Dim rdrCab As MySqlDataReader

        Dim rdrCli As MySqlDataReader


        cmdCab = New MySqlCommand("SELECT * FROM albaran_cab WHERE num_albaran = '" + txtNumpres.Text + "'", conexionmy)

        cmdCab.CommandType = CommandType.Text
        cmdCab.Connection = conexionmy
        rdrCab = cmdCab.ExecuteReader
        rdrCab.Read()
        txFecha.Text = rdrCab("fecha")
        txNumcli.Text = rdrCab("clienteID")
        txAgente.Text = rdrCab("agenteID")
        txReferenciapres.Text = rdrCab("referencia")
        txBultos.Text = rdrCab("bultos")
        txObserva.Text = rdrCab("observaciones")
        If rdrCab("serie") = "1" Then
            cbSerie.Text = "S1"
            serieIni = "1"
        Else
            cbSerie.Text = "S2"
            serieIni = "2"
        End If
        If rdrCab("facturado") = "N" Then
            cbEstado.Text = "NO FACTURADO"
        Else
            cbEstado.Text = "FACTURADO"
        End If
        cbEstado.Enabled = False


        rdrCab.Close()


        cmdCli = New MySqlCommand("SELECT * FROM clientes WHERE clienteID = '" + txNumcli.Text + "'", conexionmy)

        cmdCli.CommandType = CommandType.Text
        cmdCli.Connection = conexionmy
        rdrCli = cmdCli.ExecuteReader
        rdrCli.Read()

        txNumcli.Text = rdrCli("clienteID")
        txClientepres.Text = rdrCli("nombre")
        txDtocli.Text = rdrCli("descuento")

        rdrCli.Close()

        conexionmy.Close()
        cargoEnvios()

    End Sub
    Public Sub cargoLineas()
        Dim conexionmy As New MySqlConnection("server=" + vServidor + "; User ID=" + vUsuario + "; database=" + vBasedatos)
        conexionmy.Open()
        Dim cmdLinea As New MySqlCommand

        cmdLinea = New MySqlCommand("SELECT albaran_linea.linea,
                                            albaran_linea.codigo,
                                            albaran_linea.descripcion,
                                            albaran_linea.cantidad,
                                            albaran_linea.ancho_largo,
                                            albaran_linea.m2_ml,
                                            albaran_linea.precio,
                                            albaran_linea.descuento,
                                            albaran_linea.ivalinea,
                                            albaran_linea.importe,
                                            albaran_linea.totalinea,
                                            albaran_linea.lote,
                                            albaran_linea.num_albaran
                                            FROM albaran_linea WHERE num_albaran = '" + txtNumpres.Text + "' ORDER BY albaran_linea.linea", conexionmy)

        cmdLinea.CommandType = CommandType.Text
        cmdLinea.Connection = conexionmy

        Dim rdrLin As MySqlDataReader
        rdrLin = cmdLinea.ExecuteReader
        If rdrLin.HasRows Then
            Do While rdrLin.Read()
                lineas = lineas + 1
                dgLineasPres2.Rows.Add()
                dgLineasPres2.Rows(dgLineasPres2.Rows.Count - 1).Cells(0).Value = rdrLin("linea")
                dgLineasPres2.Rows(dgLineasPres2.Rows.Count - 1).Cells(2).Value = rdrLin("codigo")
                dgLineasPres2.Rows(dgLineasPres2.Rows.Count - 1).Cells(3).Value = rdrLin("descripcion")
                dgLineasPres2.Rows(dgLineasPres2.Rows.Count - 1).Cells(4).Value = rdrLin("cantidad")
                dgLineasPres2.Rows(dgLineasPres2.Rows.Count - 1).Cells(5).Value = rdrLin("ancho_largo")
                dgLineasPres2.Rows(dgLineasPres2.Rows.Count - 1).Cells(6).Value = rdrLin("m2_ml")
                dgLineasPres2.Rows(dgLineasPres2.Rows.Count - 1).Cells(7).Value = rdrLin("precio")
                dgLineasPres2.Rows(dgLineasPres2.Rows.Count - 1).Cells(8).Value = rdrLin("descuento")
                'dgLineasPres2.Rows(dgLineasPres2.Rows.Count - 1).Cells(9).Value = rdrLin("ivalinea")
                dgLineasPres2.Rows(dgLineasPres2.Rows.Count - 1).Cells(9).Value = rdrLin("importe")
                dgLineasPres2.Rows(dgLineasPres2.Rows.Count - 1).Cells(10).Value = rdrLin("totalinea")
                dgLineasPres2.Rows(dgLineasPres2.Rows.Count - 1).Cells(11).Value = rdrLin("lote")
            Loop
        Else

        End If

        rdrLin.Close()
        conexionmy.Close()

        recalcularTotales()
    End Sub

    Private Sub dgLineasPres2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgLineasPres2.CellClick
        If (e.ColumnIndex = 1) Then
            formArti = "A"
            frVerArticulos.Show()
        End If
        pos = dgLineasPres2.CurrentRow.Index
    End Sub

    Private Sub dgLineasPres2_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgLineasPres2.CellEndEdit
        If (e.ColumnIndex = 4 Or e.ColumnIndex = 7 Or e.ColumnIndex = 8) Then
            actualizarLinea()
            recalcularTotales()
        End If
        If (e.ColumnIndex = 4) Then
            cantFin = Decimal.Parse(dgLineasPres2.CurrentRow.Cells(4).Value)
            lineasEdit.Add(New lineasEditadas() With {.codigoArt = artiEdit, .cantAntes = cantIni, .cantDespues = cantFin})
            'MsgBox(artiEdit)
            'MsgBox(cantIni)
            'MsgBox(cantFin)
        End If
        If (e.ColumnIndex = 2) Then
            Dim vRef As String = dgLineasPres2.CurrentCell.Value
            cargarArticulos(vRef)
        End If
    End Sub
    Public Sub recalcularDescuentos()
        For Each row2 As DataGridViewRow In dgLineasPres2.Rows
            row2.Cells(8).Value = Decimal.Parse(txDtocli.Text).ToString("0.00")
            actualizarLinea()
        Next
        recalcularTotales()

    End Sub
    Public Sub descontarStock(codArti As String, unidades As Decimal)
        Dim conexionmy As New MySqlConnection("server=" + vServidor + "; User ID=" + vUsuario + "; database=" + vBasedatos)
        conexionmy.Open()

        Dim cmdLastId As New MySqlCommand("SELECT referencia, stock FROM articulos WHERE referencia = '" + codArti + "'", conexionmy)
        Dim reader As MySqlDataReader = cmdLastId.ExecuteReader()
        reader.Read()

        Dim stock As String = (reader.GetString(1) - unidades).ToString
        reader.Close()

        Dim cmdActualizo As New MySqlCommand("UPDATE articulos SET stock = '" + stock + "' WHERE referencia = '" + codArti + "'", conexionmy)
        cmdActualizo.ExecuteNonQuery()

        conexionmy.Close()

    End Sub
    Public Sub aumentarStock(codArti As String, unidades As Decimal)
        Dim conexionmy As New MySqlConnection("server=" + vServidor + "; User ID=" + vUsuario + "; database=" + vBasedatos)
        conexionmy.Open()

        Dim cmdLastId As New MySqlCommand("SELECT referencia, stock FROM articulos WHERE referencia = '" + codArti + "'", conexionmy)
        Dim reader As MySqlDataReader = cmdLastId.ExecuteReader()
        reader.Read()

        Dim stock As String = (reader.GetString(1) + unidades).ToString
        reader.Close()

        Dim cmdActualizo As New MySqlCommand("UPDATE articulos SET stock = '" + stock + "' WHERE referencia = '" + codArti + "'", conexionmy)
        cmdActualizo.ExecuteNonQuery()

        conexionmy.Close()

    End Sub
    Private Sub dgLineasPres2_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgLineasPres2.CellEnter
        If (e.ColumnIndex = 4) Then
            artiEdit = dgLineasPres2.CurrentRow.Cells(2).Value
            cantIni = Decimal.Parse(dgLineasPres2.CurrentRow.Cells(4).Value)
        End If
    End Sub

    Private Sub dgLineasPres1_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgLineasPres1.CellValueChanged
        If dgLineasPres1.CurrentCell Is Nothing Then
            Exit Sub
        Else

            If Me.dgLineasPres1.Columns("Column3").Index = e.ColumnIndex Then
                Dim value As String = dgLineasPres1.CurrentCell.EditedFormattedValue.ToString
                value = value.Replace(".", ",")

                Dim cellValue As Decimal = CType(value, Decimal)
                dgLineasPres1.CurrentCell.Value = cellValue

            End If
        End If

    End Sub

    Private Sub dgLineasPres1_CellLeave(sender As Object, e As DataGridViewCellEventArgs) Handles dgLineasPres1.CellLeave
        If (e.ColumnIndex = 8) Then
            tsBotones.Focus()
            cmdLineas.Select()
        End If

    End Sub

    Private Sub dgLineasPres2_CellLeave(sender As Object, e As DataGridViewCellEventArgs) Handles dgLineasPres2.CellLeave
        If (e.ColumnIndex = 8) Then
            tsBotones.Focus()
            cmdLineas.Select()
        End If
        If (e.ColumnIndex = 2) Then
            Dim vRef As String = dgLineasPres2.CurrentRow.Cells(2).Value
            cargarArticulos(vRef)
        End If
    End Sub

    Private Sub dgLineasPres2_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgLineasPres2.CellValueChanged
        If dgLineasPres2.CurrentCell Is Nothing Then
            Exit Sub
        Else

            If Me.dgLineasPres2.Columns("Columna3").Index = e.ColumnIndex Then
                Dim value As String = dgLineasPres2.CurrentCell.EditedFormattedValue.ToString
                value = value.Replace(".", ",")

                Dim cellValue As Decimal = CType(value, Decimal)
                dgLineasPres2.CurrentCell.Value = cellValue

            End If
        End If
    End Sub
    Public Sub cargoEnvios()
        cbEnvio.ResetText()

        Dim cn As MySqlConnection
        Dim cm As MySqlCommand

        Dim da As MySqlDataAdapter
        Dim ds As DataSet
        cn = New MySqlConnection("server=" + vServidor + "; User ID=" + vUsuario + "; database=" + vBasedatos)

        cn.Open()
        cm = New MySqlCommand("SELECT envioID, clienteID, localidad, provincia, concat_ws(' - ',cpostal, domicilio) AS direccion FROM envios WHERE clienteID = '" & txNumcli.Text & "'", cn)


        cm.CommandType = CommandType.Text
        cm.Connection = cn

        da = New MySqlDataAdapter(cm)
        ds = New DataSet()
        da.Fill(ds)


        cbEnvio.DataSource = ds.Tables(0)
        cbEnvio.DisplayMember = ds.Tables(0).Columns("direccion").ToString
        cbEnvio.ValueMember = "envioID"

        cn.Close()
    End Sub
    Public Sub cargarArticulos(refer As String)
        Dim conexionmy As New MySqlConnection("server=" + vServidor + "; User ID=" + vUsuario + "; database=" + vBasedatos)
        conexionmy.Open()
        Dim cmdCli As New MySqlCommand
        Dim rdrArt As MySqlDataReader
        cmdCli = New MySqlCommand("SELECT ref_proveedor,referencia,descripcion,pvp,iva,medidaID,familia FROM articulos2 WHERE ref_proveedor = '" & refer & "'", conexionmy)


        cmdCli.CommandType = CommandType.Text
        cmdCli.Connection = conexionmy
        rdrArt = cmdCli.ExecuteReader
        rdrArt.Read()

        If rdrArt.HasRows = True Then
            dgLineasPres1.CurrentRow.Cells(3).Value = rdrArt("descripcion")
            dgLineasPres1.CurrentRow.Cells(5).Value = rdrArt("medidaID")
            dgLineasPres1.CurrentRow.Cells(7).Value = rdrArt("pvp")
            txIva.Text = rdrArt("iva")
        Else

        End If



        rdrArt.Close()

        conexionmy.Close()
    End Sub
End Class