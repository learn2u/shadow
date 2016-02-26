﻿Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Imports System.Globalization
Imports System.ComponentModel
Imports System.Xml

Public Class frPresupuestos
    Public Shared lineas As Int16
    Public Shared pos As Integer
    Public Shared flagEdit As String = "N"

    Private Sub frPresupuestos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        deshabilitarBotones()

        lineas = 0

        If flagEdit = "N" Then
            dgLineasPres1.Visible = True
            dgLineasPres2.Visible = False
        Else
            dgLineasPres1.Visible = False
            dgLineasPres2.Visible = True
        End If

        cargoTodosPresupuestos()

    End Sub

    Private Sub ToolStripSplitButton1_ButtonClick(sender As Object, e As EventArgs) Handles cmdLineas.ButtonClick


        If txNumcli.Text = "" Then
            MsgBox("Antes de añadir líneas al presupuesto es necesario seleccionar un cliente")
            formCli = "P"
            frVerClientes.Show()
        Else
            If flagEdit = "N" Then
                If dgLineasPres1.RowCount = 0 Then
                    lineas = 0
                End If
                For Each row As DataGridViewRow In dgLineasPres1.Rows
                    If row.Cells(2).Value = "" Then
                        MsgBox("No se pueden añadir líneas nuevas hasta completar las lineas anteriores")
                        Exit Sub
                    End If
                Next
                lineas = lineas + 1
                dgLineasPres1.Rows.Add()
                dgLineasPres1.Rows(dgLineasPres1.Rows.Count - 1).Cells(0).Value = lineas
                dgLineasPres1.Rows(dgLineasPres1.Rows.Count - 1).Cells(4).Value = 1
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
                If dgLineasPres2.RowCount = 0 Then
                    lineas = 0
                End If
                For Each row As DataGridViewRow In dgLineasPres2.Rows
                    If row.Cells(2).Value = "" Then
                        MsgBox("No se pueden añadir líneas nuevas hasta completar las lineas anteriores")
                        Exit Sub
                    End If
                Next
                lineas = lineas + 1
                dgLineasPres2.Rows.Add()
                dgLineasPres2.Rows(dgLineasPres2.Rows.Count - 1).Cells(0).Value = lineas
                dgLineasPres2.Rows(dgLineasPres2.Rows.Count - 1).Cells(4).Value = 1
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
            For Each row As DataGridViewRow In dgLineasPres1.Rows
                If row.Cells(2).Value = "" Then
                    MsgBox("No se pueden añadir líneas nuevas hasta completar las lineas anteriores")
                    Exit Sub
                End If
            Next
            dgLineasPres1.Rows.Insert(dgLineasPres1.CurrentRow.Index)
            renumerar()
            dgLineasPres1.CurrentCell = dgLineasPres1.Rows(dgLineasPres1.CurrentRow.Index - 1).Cells(2)

            pos = dgLineasPres1.CurrentRow.Index

            dgLineasPres1.CurrentRow.Cells(4).Value = 1
            dgLineasPres1.CurrentRow.Cells(5).Value = 0
            dgLineasPres1.CurrentRow.Cells(6).Value = 0
            dgLineasPres1.CurrentRow.Cells(7).Value = 0
            dgLineasPres1.CurrentRow.Cells(8).Value = txDtocli.Text
            dgLineasPres1.CurrentRow.Cells(9).Value = 0
            dgLineasPres1.CurrentRow.Cells(10).Value = 0
            dgLineasPres1.CurrentRow.Cells(11).Value = ""
        Else
            For Each row As DataGridViewRow In dgLineasPres2.Rows
                If row.Cells(2).Value = "" Then
                    MsgBox("No se pueden añadir líneas nuevas hasta completar las lineas anteriores")
                    Exit Sub
                End If
            Next
            dgLineasPres2.Rows.Insert(dgLineasPres2.CurrentRow.Index)
            renumerar()
            dgLineasPres2.CurrentCell = dgLineasPres2.Rows(dgLineasPres2.CurrentRow.Index - 1).Cells(2)

            pos = dgLineasPres2.CurrentRow.Index

            dgLineasPres2.CurrentRow.Cells(4).Value = 1
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
        Dim reclinea As Decimal = 0


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
        If txRecargo.Text = "S" Then
            reclinea = (Decimal.Parse(txImponible.Text) * vRecargo) / 100
            txImpRecargo.Text = reclinea.ToString("0.00")
        End If

        txImpIva.Text = ivaLinea.ToString("0.00")
        txTotalAlbaran.Text = (Decimal.Parse(txImponible.Text) + ivaLinea + reclinea).ToString("0.00")

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

    Private Sub cmdCliente_Click(sender As Object, e As EventArgs) Handles cmdCliente.Click
        formCli = "P"
        frVerClientes.Show()
    End Sub

    Private Sub dgLineasPres1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgLineasPres1.CellClick
        If (e.ColumnIndex = 1) Then
            formArti = "P"
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
            dgLineasPres2.Rows.RemoveAt(dgLineasPres2.CurrentRow.Index)
            renumerar()
            recalcularTotales()
        End If
        If dgLineasPres1.RowCount = 0 Then
            lineas = 0
        End If
        If dgLineasPres2.RowCount = 0 Then
            lineas = 0
        End If
    End Sub
    Public Sub deshabilitarBotones()
        cmdGuardar.Enabled = False
        cmdCancelar.Enabled = False
        cmdDelete.Enabled = False
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
        cbEstado.Text = "PENDIENTE"
        txFecha.Text = Format(Today, "ddMMyyyy")
        txReferenciapres.Focus()


    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        cmdNuevo.Enabled = True
        deshabilitarBotones()
        limpiarFormulario()

        If flagEdit = "S" Then
            dgLineasPres2.Rows.Clear()
            flagEdit = "N"
        Else
            dgLineasPres1.Rows.Clear()
        End If
        lineas = 0
        tabPresupuestos.SelectTab(0)
    End Sub
    Public Sub limpiarFormulario()
        txtNumpres.Text = ""
        txNumpresBk.Text = ""
        txFecha.Text = ""
        txReferenciapres.Text = ""
        txNumcli.Text = ""
        txClientepres.Text = ""
        txAgente.Text = ""
        txRecargo.Text = ""
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

    Private Sub cmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click
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
            Dim imprec As String = txImpRecargo.Text
            Dim guardo_imprec As String = Replace(imprec, ",", ".")

            Dim fecha As Date = txFecha.Text
            Dim vEstado As String
            If cbEstado.Text = "PENDIENTE" Then
                vEstado = "P"
            ElseIf cbEstado.Text = "ACEPTADO" Then
                vEstado = "A"
            Else
                vEstado = "R"
            End If

            'Guardo cabecera y actualizo número de presupuesto
            Dim conexionmy As New MySqlConnection("server=" + vServidor + "; User ID=" + vUsuario + "; database=" + vBasedatos)
            conexionmy.Open()
            Dim cmd As New MySqlCommand("INSERT INTO presupuesto_cab (num_presupuesto, clienteID, envioID, empresaID, agenteID, usuarioID, fecha, referencia, observaciones, totalbruto, totaldto, totaliva, totalrecargo, totalpresupuesto, estado) VALUES (" + txtNumpres.Text + ", " + txNumcli.Text + ", " + cbEnvio.SelectedValue.ToString + ", " + txEmpresa.Text + ", " + txAgente.Text + ", " + txUsuario.Text + ", '" + fecha.ToString("yyyy-MM-dd") + "',  '" + txReferenciapres.Text + "', '" + txObserva.Text + "', '" + guardo_impbru + "', '" + guardo_impdto + "',  '" + guardo_impiva + "', '" + guardo_imprec + "', '" + guardo_imptot + "', '" + vEstado + "')", conexionmy)
            cmd.ExecuteNonQuery()
            Dim cmdActualizar As New MySqlCommand("UPDATE configuracion SET num_presupuesto = '" + txtNumpres.Text + "'", conexionmy)
            cmdActualizar.ExecuteNonQuery()

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

                If row.Cells(2).Value = "" Then

                Else

                    cmdLinea.Connection = conexionmy
                    cmdLinea.CommandText = "INSERT INTO presupuesto_linea (num_presupuesto, linea, codigo, descripcion, cantidad, ancho_largo, m2_ml, precio, descuento, ivalinea, importe, totalinea, lote) VALUES ('" + txtNumpres.Text + "', " + row.Cells(0).Value.ToString + ", '" + row.Cells(2).Value + "', '" + row.Cells(3).Value + "', '" + guardo_lincant + "', '" + guardo_linancho + "', '" + guardo_linmetros + "', '" + guardo_linprec + "', '" + guardo_lindto + "', '" + guardo_liniva + "', '" + guardo_linimporte + "', '" + guardo_lintotal + "', '" + row.Cells(11).Value + "')"

                    cmdLinea.ExecuteNonQuery()
                End If


            Next

            conexionmy.Close()

            deshabilitarBotones()
            limpiarFormulario()
            cmdNuevo.Enabled = True
            cargoTodosPresupuestos()
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
            Dim imprec As String = txImpRecargo.Text
            Dim guardo_imprec As String = Replace(imprec, ",", ".")

            Dim fecha As Date = txFecha.Text
            Dim vEstado As String
            If cbEstado.Text = "PENDIENTE" Then
                vEstado = "P"
            ElseIf cbEstado.Text = "ACEPTADO" Then
                vEstado = "A"
            Else
                vEstado = "R"
            End If

            'Guardo cabecera y actualizo número de presupuesto

            Dim cmd As New MySqlCommand("UPDATE presupuesto_cab SET fecha = '" + fecha.ToString("yyyy-MM-dd") + "', clienteID = " + txNumcli.Text + ", agenteID = " + txAgente.Text + ", referencia = '" + txReferenciapres.Text + "', observaciones = '" + txObserva.Text + "', totalbruto = '" + guardo_impbru + "', totaldto = '" + guardo_impdto + "', totaliva = '" + guardo_impiva + "', totalrecargo = '" + guardo_imprec + "', totalpresupuesto = '" + guardo_imptot + "', estado = '" + vEstado + "' WHERE num_presupuesto = '" + txtNumpres.Text + "'", conexionmy)
            cmd.ExecuteNonQuery()


            'Guardo líneas del presupuesto

            Dim cmdEliminar As New MySqlCommand("DELETE FROM presupuesto_linea WHERE num_presupuesto = '" + txtNumpres.Text + "'", conexionmy)
            cmdEliminar.ExecuteNonQuery()

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

                If row.Cells(2).Value = "" Then

                Else
                    cmdLinea.Connection = conexionmy
                    cmdLinea.CommandText = "INSERT INTO presupuesto_linea (num_presupuesto, linea, codigo, descripcion, cantidad, ancho_largo, m2_ml, precio, descuento, ivalinea, importe, totalinea, lote) VALUES ('" + txtNumpres.Text + "', " + row.Cells(0).Value.ToString + ", '" + row.Cells(2).Value + "', '" + row.Cells(3).Value + "', '" + guardo_lincant + "', '" + guardo_linancho + "', '" + guardo_linmetros + "', '" + guardo_linprec + "', '" + guardo_lindto + "', '" + guardo_liniva + "', '" + guardo_linimporte + "', '" + guardo_lintotal + "', '" + row.Cells(11).Value + "')"

                    cmdLinea.ExecuteNonQuery()
                End If



            Next

            conexionmy.Close()

            deshabilitarBotones()
            limpiarFormulario()
            cmdNuevo.Enabled = True
            cargoTodosPresupuestos()
            tabPresupuestos.SelectTab(0)
            flagEdit = "N"

        End If
        lineas = 0


    End Sub
    Public Sub cargoNumero()
        Dim conexionmy As New MySqlConnection("server=" + vServidor + "; User ID=" + vUsuario + "; database=" + vBasedatos)
        conexionmy.Open()

        Dim cmdLastId As New MySqlCommand("SELECT num_presupuesto FROM configuracion  ", conexionmy)
        Dim numid As Int32

        numid = cmdLastId.ExecuteScalar()

        txtNumpres.Text = numid + 1

        conexionmy.Close()

    End Sub
    Public Sub cargoTodosPresupuestos()

        Dim conexionmy As New MySqlConnection("server=" + vServidor + "; User ID=" + vUsuario + "; database=" + vBasedatos + "; Convert Zero Datetime=True")
        conexionmy.Open()
        Dim consultamy As New MySqlCommand("SELECT presupuesto_cab.num_presupuesto, 
                                                    presupuesto_cab.referencia,
                                                    presupuesto_cab.fecha, 
                                                    clientes.nombre, 
                                                    presupuesto_cab.totalbruto, 
                                                    presupuesto_cab.totalpresupuesto, 
                                                    presupuesto_cab.clienteID,
                                                    presupuesto_cab.eliminado, 
                                                    clientes.clienteID 
                                            FROM presupuesto_cab INNER JOIN clientes ON presupuesto_cab.clienteID=clientes.clienteID WHERE eliminado = 'N' ORDER BY presupuesto_cab.num_presupuesto DESC", conexionmy)

        Dim readermy As MySqlDataReader
        Dim dtable As New DataTable
        Dim bind As New BindingSource()


        readermy = consultamy.ExecuteReader
        dtable.Load(readermy, LoadOption.OverwriteChanges)

        bind.DataSource = dtable

        dgPresupuestos.DataSource = bind
        dgPresupuestos.EnableHeadersVisualStyles = False
        Dim styCabeceras As DataGridViewCellStyle = New DataGridViewCellStyle()
        styCabeceras.BackColor = Color.Beige
        styCabeceras.ForeColor = Color.Black
        styCabeceras.Font = New Font("Verdana", 9, FontStyle.Bold)
        dgPresupuestos.ColumnHeadersDefaultCellStyle = styCabeceras

        dgPresupuestos.Columns(0).HeaderText = "NUMERO"
        dgPresupuestos.Columns(0).Name = "Column1"
        dgPresupuestos.Columns(0).FillWeight = 90
        dgPresupuestos.Columns(0).MinimumWidth = 90
        dgPresupuestos.Columns(1).HeaderText = "REFERENCIA"
        dgPresupuestos.Columns(1).Name = "Column2"
        dgPresupuestos.Columns(1).FillWeight = 190
        dgPresupuestos.Columns(1).MinimumWidth = 190
        dgPresupuestos.Columns(2).HeaderText = "FECHA"
        dgPresupuestos.Columns(2).Name = "Column3"
        dgPresupuestos.Columns(2).FillWeight = 90
        dgPresupuestos.Columns(2).MinimumWidth = 90
        dgPresupuestos.Columns(3).HeaderText = "CLIENTE"
        dgPresupuestos.Columns(3).Name = "Column4"
        dgPresupuestos.Columns(3).FillWeight = 300
        dgPresupuestos.Columns(3).MinimumWidth = 300
        dgPresupuestos.Columns(4).HeaderText = "IMPORTE"
        dgPresupuestos.Columns(4).Name = "Column5"
        dgPresupuestos.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgPresupuestos.Columns(4).FillWeight = 90
        dgPresupuestos.Columns(4).MinimumWidth = 90
        dgPresupuestos.Columns(5).HeaderText = "TOTAL"
        dgPresupuestos.Columns(5).Name = "Column6"
        dgPresupuestos.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgPresupuestos.Columns(5).FillWeight = 90
        dgPresupuestos.Columns(5).MinimumWidth = 90
        dgPresupuestos.Columns(6).Visible = False
        dgPresupuestos.Columns(7).Visible = False
        dgPresupuestos.Columns(8).Visible = False
        dgPresupuestos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgPresupuestos.Visible = True

        conexionmy.Close()
    End Sub
    Public Sub cargoPresupuesto()
        Dim conexionmy As New MySqlConnection("server=" + vServidor + "; User ID=" + vUsuario + "; database=" + vBasedatos)
        conexionmy.Open()
        Dim cmdCab As New MySqlCommand

        Dim cmdCli As New MySqlCommand

        Dim rdrCab As MySqlDataReader

        Dim rdrCli As MySqlDataReader


        cmdCab = New MySqlCommand("SELECT * FROM presupuesto_cab WHERE num_presupuesto = '" + txtNumpres.Text + "'", conexionmy)

        cmdCab.CommandType = CommandType.Text
        cmdCab.Connection = conexionmy
        rdrCab = cmdCab.ExecuteReader
        rdrCab.Read()
        txFecha.Text = rdrCab("fecha")
        txNumcli.Text = rdrCab("clienteID")
        txAgente.Text = rdrCab("agenteID")
        txReferenciapres.Text = rdrCab("referencia")
        txObserva.Text = rdrCab("observaciones")
        If rdrCab("estado") = "P" Then
            cbEstado.Text = "PENDIENTE"
        ElseIf rdrCab("estado") = "A" Then
            cbEstado.Text = "ACEPTADO"
        Else
            cbEstado.Text = "RECHAZADO"
        End If

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

        cmdLinea = New MySqlCommand("SELECT presupuesto_linea.linea,
                                            presupuesto_linea.codigo,
                                            presupuesto_linea.descripcion,
                                            presupuesto_linea.cantidad,
                                            presupuesto_linea.ancho_largo,
                                            presupuesto_linea.m2_ml,
                                            presupuesto_linea.precio,
                                            presupuesto_linea.descuento,
                                            presupuesto_linea.ivalinea,
                                            presupuesto_linea.importe,
                                            presupuesto_linea.totalinea,
                                            presupuesto_linea.lote,
                                            presupuesto_linea.num_presupuesto
                                            FROM presupuesto_linea WHERE num_presupuesto = '" + txtNumpres.Text + "' ORDER BY presupuesto_linea.linea", conexionmy)

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
            formArti = "P"
            frVerArticulos.Show()
        End If
        pos = dgLineasPres2.CurrentRow.Index
    End Sub

    Private Sub dgLineasPres2_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgLineasPres2.CellEndEdit
        If (e.ColumnIndex = 4 Or e.ColumnIndex = 7 Or e.ColumnIndex = 8) Then
            actualizarLinea()
            recalcularTotales()

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
            If flagEdit = "N" Then
                dgLineasPres1.CurrentRow.Cells(3).Value = rdrArt("descripcion")
                dgLineasPres1.CurrentRow.Cells(4).Value = 1
                dgLineasPres1.CurrentRow.Cells(5).Value = rdrArt("medidaID") / 100
                dgLineasPres1.CurrentRow.Cells(6).Value = dgLineasPres1.CurrentRow.Cells(4).Value * dgLineasPres1.CurrentRow.Cells(5).Value
                dgLineasPres1.CurrentRow.Cells(7).Value = rdrArt("pvp")
                dgLineasPres1.CurrentRow.Cells(8).Value = txDtocli.Text
                dgLineasPres1.CurrentRow.Cells(9).Value = 0
                dgLineasPres1.CurrentRow.Cells(10).Value = 0
                dgLineasPres1.CurrentRow.Cells(11).Value = ""
                txIva.Text = rdrArt("iva")
                'dgLineasPres1.CurrentCell = dgLineasPres1.CurrentRow.Cells(4)
                'dgLineasPres1.BeginEdit(True)
            Else
                dgLineasPres2.CurrentRow.Cells(3).Value = rdrArt("descripcion")
                dgLineasPres2.CurrentRow.Cells(4).Value = 1
                dgLineasPres2.CurrentRow.Cells(5).Value = rdrArt("medidaID") / 100
                dgLineasPres1.CurrentRow.Cells(6).Value = dgLineasPres1.CurrentRow.Cells(4).Value * dgLineasPres1.CurrentRow.Cells(5).Value
                dgLineasPres2.CurrentRow.Cells(7).Value = rdrArt("pvp")
                dgLineasPres2.CurrentRow.Cells(8).Value = txDtocli.Text
                dgLineasPres2.CurrentRow.Cells(9).Value = 0
                dgLineasPres2.CurrentRow.Cells(10).Value = 0
                dgLineasPres2.CurrentRow.Cells(11).Value = ""
                txIva.Text = rdrArt("iva")
                'dgLineasPres2.CurrentCell = dgLineasPres2.CurrentRow.Cells(4)
                'dgLineasPres2.BeginEdit(True)
            End If

        Else

        End If

        rdrArt.Close()

        conexionmy.Close()
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

    Private Sub dgLineasPres1_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgLineasPres1.CellValueChanged
        If dgLineasPres1.CurrentCell Is Nothing Then
            Exit Sub
        Else

            If (e.ColumnIndex = 4) Then
                Dim value As String = dgLineasPres1.CurrentCell.EditedFormattedValue.ToString
                value = value.Replace(".", ",")

                Dim cellValue As Decimal = CType(value, Decimal)
                dgLineasPres1.CurrentCell.Value = cellValue

            End If
            If (e.ColumnIndex = 8) Then
                Dim value As String = dgLineasPres1.CurrentCell.EditedFormattedValue.ToString
                value = value.Replace(".", ",")

                Dim cellValue As Decimal = CType(value, Decimal)
                dgLineasPres1.CurrentCell.Value = cellValue

            End If
            If (e.ColumnIndex = 9) Then
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
    End Sub

    Private Sub dgLineasPres2_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgLineasPres2.CellValueChanged
        If dgLineasPres2.CurrentCell Is Nothing Then
            Exit Sub
        Else

            If (e.ColumnIndex = 4) Then
                Dim value As String = dgLineasPres2.CurrentCell.EditedFormattedValue.ToString
                value = value.Replace(".", ",")

                Dim cellValue As Decimal = CType(value, Decimal)
                dgLineasPres2.CurrentCell.Value = cellValue

            End If
            If (e.ColumnIndex = 8) Then
                Dim value As String = dgLineasPres2.CurrentCell.EditedFormattedValue.ToString
                value = value.Replace(".", ",")

                Dim cellValue As Decimal = CType(value, Decimal)
                dgLineasPres2.CurrentCell.Value = cellValue

            End If
            If (e.ColumnIndex = 9) Then
                Dim value As String = dgLineasPres2.CurrentCell.EditedFormattedValue.ToString
                value = value.Replace(".", ",")

                Dim cellValue As Decimal = CType(value, Decimal)
                dgLineasPres2.CurrentCell.Value = cellValue

            End If
        End If
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click

        Dim respuesta As String
        respuesta = MsgBox("El borrado de presupuestos es una acción no recuperable. ¿Está seguro?", vbYesNo)
        If respuesta = vbYes Then
            Dim conexionmy As New MySqlConnection("server=" + vServidor + "; User ID=" + vUsuario + "; database=" + vBasedatos)
            conexionmy.Open()

            Dim cmdEliminar As New MySqlCommand("DELETE FROM presupuesto_cab WHERE num_presupuesto = '" + txtNumpres.Text + "'", conexionmy)
            cmdEliminar.ExecuteNonQuery()

            Dim cmdEliminarLineas As New MySqlCommand("DELETE FROM presupuesto_linea WHERE num_presupuesto = '" + txtNumpres.Text + "'", conexionmy)
            cmdEliminarLineas.ExecuteNonQuery()

            conexionmy.Close()
            deshabilitarBotones()
            limpiarFormulario()
            dgLineasPres2.Rows.Clear()
            cmdNuevo.Enabled = True
            cargoTodosPresupuestos()
            tabPresupuestos.SelectTab(0)
            flagEdit = "N"

        End If

    End Sub

    Private Sub cmdPedido_Click(sender As Object, e As EventArgs) Handles cmdPedido.Click
        'Conversion Presupuesto a Pedido

        Dim respuesta As String
        respuesta = MsgBox("La conversión a Pedido no es reversible. Una vez convertido, el presupuesto será eliminado. ¿Está seguro?", vbYesNo)
        If respuesta = vbYes Then
            txNumpresBk.Text = txtNumpres.Text

            Dim conexionmy As New MySqlConnection("server=" + vServidor + "; User ID=" + vUsuario + "; database=" + vBasedatos)
            conexionmy.Open()
            Dim cmd As New MySqlCommand
            cmd.CommandType = System.Data.CommandType.Text


            cargoNumeroConversion("P")
            Dim vFecha As Date = txFecha.Text
            Dim vBruto As String = Replace(txImpBruto.Text.ToString, ",", ".")
            Dim vDto As String = Replace(txImpDto.Text.ToString, ",", ".")
            Dim vIva As String = Replace(txImpIva.Text.ToString, ",", ".")
            Dim vRec As String = Replace(txImpRecargo.Text.ToString, ",", ".")
            Dim vTotal As String = Replace(txTotalAlbaran.Text.ToString, ",", ".")

            cmd.CommandText = "INSERT INTO pedido_cab (num_pedido, clienteID, envioID, empresaID, agenteID, usuarioID, fecha, referencia, observaciones, totalbruto, totaldto, totaliva, totalrecargo, totalpedido, estado, eliminado) VALUES (" + txtNumpres.Text + " , " + txNumcli.Text + ", " + cbEnvio.SelectedValue.ToString + ", " + txEmpresa.Text + ", " + txAgente.Text + ", " + txUsuario.Text + ", '" + vFecha.ToString("yyyy-MM-dd") + "', '" + txReferenciapres.Text + "', '" + txObserva.Text + "', '" + vBruto + "', '" + vDto + "', '" + vIva + "', '" + vRec + "', '" + vTotal + "', 'P', 'N')"
            cmd.Connection = conexionmy
            cmd.ExecuteNonQuery()

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
                cmdLinea.CommandText = "INSERT INTO pedido_linea (num_pedido, linea, codigo, descripcion, cantidad, ancho_largo, m2_ml, precio, descuento, ivalinea, importe, totalinea, lote) VALUES ('" + txtNumpres.Text + "', " + row.Cells(0).Value.ToString + ", '" + row.Cells(2).Value + "', '" + row.Cells(3).Value + "', '" + guardo_lincant + "', '" + guardo_linancho + "', '" + guardo_linmetros + "', '" + guardo_linprec + "', '" + guardo_lindto + "', '" + guardo_liniva + "', '" + guardo_linimporte + "', '" + guardo_lintotal + "', '" + row.Cells(11).Value + "')"

                cmdLinea.ExecuteNonQuery()

                conexionmy.Close()

            Next

            Dim cmdActualizar As New MySqlCommand("UPDATE configuracion SET num_pedido = '" + txtNumpres.Text + "'  ", conexionmy)
            cmdActualizar.ExecuteNonQuery()

            'Borro la cabecera y las lineas del presupuesto

            'Dim cmdEliminar As New MySqlCommand("DELETE FROM presupuesto_cab WHERE num_presupuesto = '" + txNumpresBk.Text + "'", conexionmy)
            'cmdEliminar.ExecuteNonQuery()

            'Dim cmdEliminarLineas As New MySqlCommand("DELETE FROM presupuesto_linea WHERE num_presupuesto = '" + txNumpresBk.Text + "'", conexionmy)
            'cmdEliminarLineas.ExecuteNonQuery()

            conexionmy.Close()
            deshabilitarBotones()
            limpiarFormulario()
            dgLineasPres2.Rows.Clear()
            cmdNuevo.Enabled = True
            cargoTodosPresupuestos()
            tabPresupuestos.SelectTab(0)
            flagEdit = "N"
        Else
            cargoTodosPresupuestos()
            tabPresupuestos.SelectTab(0)
            flagEdit = "N"
        End If

    End Sub

    Private Sub cmdAlbaran_Click(sender As Object, e As EventArgs) Handles cmdAlbaran.Click
        'conversion presupuesto a albaran
        Dim respuesta As String
        respuesta = MsgBox("La conversión a Albarán no es reversible. Una vez convertido, el presupuesto será eliminado. ¿Está seguro?", vbYesNo)
        If respuesta = vbYes Then
            txNumpresBk.Text = txtNumpres.Text

            Dim conexionmy As New MySqlConnection("server=" + vServidor + "; User ID=" + vUsuario + "; database=" + vBasedatos)
            conexionmy.Open()
            Dim cmd As New MySqlCommand
            cmd.CommandType = System.Data.CommandType.Text


            cargoNumeroConversion("A")
            Dim vFecha As Date = txFecha.Text
            Dim vBruto As String = Replace(txImpBruto.Text.ToString, ",", ".")
            Dim vDto As String = Replace(txImpDto.Text.ToString, ",", ".")
            Dim vIva As String = Replace(txImpIva.Text.ToString, ",", ".")
            Dim vRec As String = Replace(txImpRecargo.Text.ToString, ",", ".")
            Dim vTotal As String = Replace(txTotalAlbaran.Text.ToString, ",", ".")

            cmd.CommandText = "INSERT INTO albaran_cab (num_albaran, serie, clienteID, envioID, empresaID, agenteID, usuarioID, fecha, referencia, observaciones, totalbruto, totaldto, totaliva, totalrecargo, totalalbaran, facturado, bultos, eliminado) VALUES (" + txtNumpres.Text + " , '1', " + txNumcli.Text + ", " + cbEnvio.SelectedValue.ToString + ", " + txEmpresa.Text + ", " + txAgente.Text + ", " + txUsuario.Text + ", '" + vFecha.ToString("yyyy-MM-dd") + "', '" + txReferenciapres.Text + "', '" + txObserva.Text + "', '" + vBruto + "', '" + vDto + "', '" + vIva + "', '" + vRec + "', '" + vTotal + "', 'N', 0, 'N')"
            cmd.Connection = conexionmy
            cmd.ExecuteNonQuery()

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

            Dim cmdActualizar As New MySqlCommand("UPDATE configuracion SET num_albaran = '" + txtNumpres.Text + "'  ", conexionmy)
            cmdActualizar.ExecuteNonQuery()

            'Borro la cabecera y las lineas del presupuesto

            'Dim cmdEliminar As New MySqlCommand("DELETE FROM presupuesto_cab WHERE num_presupuesto = '" + txNumpresBk.Text + "'", conexionmy)
            'cmdEliminar.ExecuteNonQuery()

            'Dim cmdEliminarLineas As New MySqlCommand("DELETE FROM presupuesto_linea WHERE num_presupuesto = '" + txNumpresBk.Text + "'", conexionmy)
            'cmdEliminarLineas.ExecuteNonQuery()

            conexionmy.Close()
            deshabilitarBotones()
            limpiarFormulario()
            dgLineasPres2.Rows.Clear()
            cmdNuevo.Enabled = True
            cargoTodosPresupuestos()
            tabPresupuestos.SelectTab(0)
            flagEdit = "N"
        Else
            cargoTodosPresupuestos()
            tabPresupuestos.SelectTab(0)
            flagEdit = "N"
        End If
    End Sub
    Public Sub cargoNumeroConversion(tipoDoc As String)
        If tipoDoc = "P" Then
            Dim conexionmy As New MySqlConnection("server=" + vServidor + "; User ID=" + vUsuario + "; database=" + vBasedatos)
            conexionmy.Open()

            Dim cmdLastId As New MySqlCommand("SELECT num_pedido FROM configuracion  ", conexionmy)
            Dim numid As Int32

            numid = cmdLastId.ExecuteScalar()

            txtNumpres.Text = numid + 1

            conexionmy.Close()
        Else
            Dim conexionmy As New MySqlConnection("server=" + vServidor + "; User ID=" + vUsuario + "; database=" + vBasedatos)
            conexionmy.Open()

            Dim cmdLastId As New MySqlCommand("SELECT num_albaran FROM configuracion  ", conexionmy)
            Dim numid As Int32

            numid = cmdLastId.ExecuteScalar()

            txtNumpres.Text = numid + 1

            conexionmy.Close()

        End If

    End Sub

    Private Sub dgPresupuestos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgPresupuestos.CellDoubleClick
        limpiarFormulario()
        cmdLineas.Enabled = True
        cmdGuardar.Enabled = True
        cmdCancelar.Enabled = True
        cmdCliente.Enabled = True
        cmdAlbaran.Enabled = True
        cmdPedido.Enabled = True


        txtNumpres.Text = dgPresupuestos.CurrentRow.Cells("Column1").Value.ToString
        tabPresupuestos.SelectTab(1)
        flagEdit = "S"
        dgLineasPres1.Visible = False
        dgLineasPres2.Visible = True
        dgLineasPres2.Rows.Clear()


        cargoPresupuesto()
        cargoLineas()
        cmdDelete.Enabled = True
        recalcularTotales()
    End Sub
End Class
