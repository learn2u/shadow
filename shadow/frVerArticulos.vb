﻿Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Imports System.Globalization
Imports System.ComponentModel
Imports System.Xml
Public Class frVerArticulos
    Private Sub frVerArticulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conexionmy As New MySqlConnection("server=" + vServidor + "; User ID=" + vUsuario + "; database=" + vBasedatos)

        conexionmy.Open()
        Dim consultamy As New MySqlCommand("SELECT referencia,descripcion,pvp,iva,medidaID,familia FROM articulos2", conexionmy)

        Dim readermy As MySqlDataReader
        Dim dtable As New DataTable
        Dim bind As New BindingSource()


        readermy = consultamy.ExecuteReader
        dtable.Load(readermy, LoadOption.OverwriteChanges)

        bind.DataSource = dtable


        dgArticulos.DataSource = bind
        dgArticulos.AutoGenerateColumns = False
        dgArticulos.Columns(0).HeaderText = "REFERENCIA"
        dgArticulos.Columns(0).Name = "referen"
        dgArticulos.Columns(0).FillWeight = 80
        dgArticulos.Columns(0).MinimumWidth = 80
        dgArticulos.Columns(1).HeaderText = "DESCRIPCION"
        dgArticulos.Columns(1).Name = "descrip"
        dgArticulos.Columns(1).FillWeight = 245
        dgArticulos.Columns(1).MinimumWidth = 245
        dgArticulos.Columns(2).HeaderText = "PRECIO"
        dgArticulos.Columns(2).Name = "prec"
        dgArticulos.Columns(2).FillWeight = 50
        dgArticulos.Columns(2).MinimumWidth = 50
        dgArticulos.Columns(3).HeaderText = "IVA"
        dgArticulos.Columns(3).Name = "porciva"
        dgArticulos.Columns(3).Visible = False
        dgArticulos.Columns(4).HeaderText = "MEDIDA"
        dgArticulos.Columns(4).Name = "longitud"
        dgArticulos.Columns(4).Visible = False
        dgArticulos.Columns(5).HeaderText = "FAMILIA"
        dgArticulos.Columns(5).Name = "fam"
        dgArticulos.Columns(5).Visible = False


        dgArticulos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        conexionmy.Close()

    End Sub

    Private Sub txCodigo_TextChanged(sender As Object, e As EventArgs) Handles txCodigo.TextChanged
        Dim conexionmy As New MySqlConnection("server=" + vServidor + "; User ID=" + vUsuario + "; database=" + vBasedatos)

        conexionmy.Open()
        Dim consultamy As New MySqlCommand("SELECT referencia,descripcion,pvp,iva,medidaID,familia FROM articulos2 WHERE referencia LIKE'" & txCodigo.Text & "%'", conexionmy)

        Dim readermy As MySqlDataReader
        Dim dtable As New DataTable
        Dim bind As New BindingSource()


        readermy = consultamy.ExecuteReader
        dtable.Load(readermy, LoadOption.OverwriteChanges)

        bind.DataSource = dtable


        bind.DataSource = dtable
        dgArticulos.DataSource = bind
        dgArticulos.AutoGenerateColumns = False
        dgArticulos.Columns(0).HeaderText = "REFERENCIA"
        dgArticulos.Columns(0).Name = "referen"
        dgArticulos.Columns(0).FillWeight = 80
        dgArticulos.Columns(0).MinimumWidth = 80
        dgArticulos.Columns(1).HeaderText = "DESCRIPCION"
        dgArticulos.Columns(1).Name = "descrip"
        dgArticulos.Columns(1).FillWeight = 245
        dgArticulos.Columns(1).MinimumWidth = 245
        dgArticulos.Columns(2).HeaderText = "PRECIO"
        dgArticulos.Columns(2).Name = "prec"
        dgArticulos.Columns(2).FillWeight = 50
        dgArticulos.Columns(2).MinimumWidth = 50
        dgArticulos.Columns(3).HeaderText = "IVA"
        dgArticulos.Columns(3).Name = "porciva"
        dgArticulos.Columns(3).Visible = False
        dgArticulos.Columns(4).HeaderText = "MEDIDA"
        dgArticulos.Columns(4).Name = "longitud"
        dgArticulos.Columns(4).Visible = False
        dgArticulos.Columns(5).HeaderText = "FAMILIA"
        dgArticulos.Columns(5).Name = "fam"
        dgArticulos.Columns(5).Visible = False
        dgArticulos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        conexionmy.Close()

    End Sub

    Private Sub txArticulo_TextChanged(sender As Object, e As EventArgs) Handles txArticulo.TextChanged
        Dim conexionmy As New MySqlConnection("server=" + vServidor + "; User ID=" + vUsuario + "; database=" + vBasedatos)

        conexionmy.Open()
        Dim consultamy As New MySqlCommand("SELECT referencia,descripcion,pvp,iva,medidaID,familia FROM articulos2 WHERE descripcion LIKE'" & txArticulo.Text & "%'", conexionmy)

        Dim readermy As MySqlDataReader
        Dim dtable As New DataTable
        Dim bind As New BindingSource()


        readermy = consultamy.ExecuteReader
        dtable.Load(readermy, LoadOption.OverwriteChanges)

        bind.DataSource = dtable


        bind.DataSource = dtable
        dgArticulos.DataSource = bind
        dgArticulos.AutoGenerateColumns = False
        dgArticulos.Columns(0).HeaderText = "REFERENCIA"
        dgArticulos.Columns(0).Name = "referen"
        dgArticulos.Columns(0).FillWeight = 80
        dgArticulos.Columns(0).MinimumWidth = 80
        dgArticulos.Columns(1).HeaderText = "DESCRIPCION"
        dgArticulos.Columns(1).Name = "descrip"
        dgArticulos.Columns(1).FillWeight = 245
        dgArticulos.Columns(1).MinimumWidth = 245
        dgArticulos.Columns(2).HeaderText = "PRECIO"
        dgArticulos.Columns(2).Name = "prec"
        dgArticulos.Columns(2).FillWeight = 50
        dgArticulos.Columns(2).MinimumWidth = 50
        dgArticulos.Columns(3).HeaderText = "IVA"
        dgArticulos.Columns(3).Name = "porciva"
        dgArticulos.Columns(3).Visible = False
        dgArticulos.Columns(4).HeaderText = "MEDIDA"
        dgArticulos.Columns(4).Name = "longitud"
        dgArticulos.Columns(4).Visible = False
        dgArticulos.Columns(5).HeaderText = "FAMILIA"
        dgArticulos.Columns(5).Name = "fam"
        dgArticulos.Columns(5).Visible = False
        dgArticulos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        conexionmy.Close()

    End Sub

    Private Sub dgArticulos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgArticulos.CellClick

        If dgArticulos.CurrentRow.Cells("fam").Value = 7 Then
            frVerLotes.vReferencia = dgArticulos.CurrentRow.Cells("referen").Value
            frVerLotes.vPrecio = dgArticulos.CurrentRow.Cells("prec").Value
            frVerLotes.vIva = dgArticulos.CurrentRow.Cells("porciva").Value
            frVerLotes.Show()
        Else
            If formArti = "P" Then
                If frPresupuestos.flagEdit = "N" Then
                    frPresupuestos.dgLineasPres1.CurrentRow.Cells(2).Value = dgArticulos.CurrentRow.Cells("referen").Value
                    frPresupuestos.dgLineasPres1.CurrentRow.Cells(3).Value = dgArticulos.CurrentRow.Cells("descrip").Value
                    frPresupuestos.dgLineasPres1.CurrentRow.Cells(5).Value = dgArticulos.CurrentRow.Cells("longitud").Value
                    frPresupuestos.dgLineasPres1.CurrentRow.Cells(7).Value = dgArticulos.CurrentRow.Cells("prec").Value
                    frPresupuestos.txIva.Text = dgArticulos.CurrentRow.Cells("porciva").Value
                    frPresupuestos.dgLineasPres1.CurrentCell = frPresupuestos.dgLineasPres1.CurrentRow.Cells(4)
                    frPresupuestos.dgLineasPres1.BeginEdit(True)

                    Me.Hide()
                Else
                    frPresupuestos.dgLineasPres2.CurrentRow.Cells(2).Value = dgArticulos.CurrentRow.Cells("referen").Value
                    frPresupuestos.dgLineasPres2.CurrentRow.Cells(3).Value = dgArticulos.CurrentRow.Cells("descrip").Value
                    frPresupuestos.dgLineasPres2.CurrentRow.Cells(5).Value = dgArticulos.CurrentRow.Cells("longitud").Value
                    frPresupuestos.dgLineasPres2.CurrentRow.Cells(7).Value = dgArticulos.CurrentRow.Cells("prec").Value
                    frPresupuestos.txIva.Text = dgArticulos.CurrentRow.Cells("porciva").Value
                    frPresupuestos.dgLineasPres2.CurrentCell = frPresupuestos.dgLineasPres2.CurrentRow.Cells(4)
                    frPresupuestos.dgLineasPres2.BeginEdit(True)
                    frPresupuestos.actualizarLinea()
                    frPresupuestos.recalcularTotales()

                    Me.Hide()
                End If
            End If
            If formArti = "A" Then
                If frAlbaran.flagEdit = "N" Then
                    frAlbaran.dgLineasPres1.CurrentRow.Cells(2).Value = dgArticulos.CurrentRow.Cells("referen").Value
                    frAlbaran.dgLineasPres1.CurrentRow.Cells(3).Value = dgArticulos.CurrentRow.Cells("descrip").Value
                    frAlbaran.dgLineasPres1.CurrentRow.Cells(5).Value = dgArticulos.CurrentRow.Cells("longitud").Value
                    frAlbaran.dgLineasPres1.CurrentRow.Cells(7).Value = dgArticulos.CurrentRow.Cells("prec").Value
                    frAlbaran.txIva.Text = dgArticulos.CurrentRow.Cells("porciva").Value
                    frAlbaran.dgLineasPres1.CurrentCell = frAlbaran.dgLineasPres1.CurrentRow.Cells(4)
                    frAlbaran.dgLineasPres1.BeginEdit(True)

                    Me.Hide()
                Else
                    frAlbaran.dgLineasPres2.CurrentRow.Cells(2).Value = dgArticulos.CurrentRow.Cells("referen").Value
                    frAlbaran.dgLineasPres2.CurrentRow.Cells(3).Value = dgArticulos.CurrentRow.Cells("descrip").Value
                    frAlbaran.dgLineasPres2.CurrentRow.Cells(5).Value = dgArticulos.CurrentRow.Cells("longitud").Value
                    frAlbaran.dgLineasPres2.CurrentRow.Cells(7).Value = dgArticulos.CurrentRow.Cells("prec").Value
                    frAlbaran.txIva.Text = dgArticulos.CurrentRow.Cells("porciva").Value
                    frAlbaran.dgLineasPres2.CurrentCell = frAlbaran.dgLineasPres2.CurrentRow.Cells(4)
                    frAlbaran.dgLineasPres2.BeginEdit(True)
                    frAlbaran.actualizarLinea()
                    frAlbaran.recalcularTotales()

                    Me.Hide()
                End If
            End If

            If formArti = "D" Then
                If frAlbaran.flagEdit = "N" Then
                    frPedido.dgLineasPres1.CurrentRow.Cells(2).Value = dgArticulos.CurrentRow.Cells("referen").Value
                    frPedido.dgLineasPres1.CurrentRow.Cells(3).Value = dgArticulos.CurrentRow.Cells("descrip").Value
                    frPedido.dgLineasPres1.CurrentRow.Cells(5).Value = dgArticulos.CurrentRow.Cells("longitud").Value
                    frPedido.dgLineasPres1.CurrentRow.Cells(7).Value = dgArticulos.CurrentRow.Cells("prec").Value
                    frPedido.txIva.Text = dgArticulos.CurrentRow.Cells("porciva").Value
                    frPedido.dgLineasPres1.CurrentCell = frPedido.dgLineasPres1.CurrentRow.Cells(4)
                    frPedido.dgLineasPres1.BeginEdit(True)

                    Me.Hide()
                Else
                    frPedido.dgLineasPres2.CurrentRow.Cells(2).Value = dgArticulos.CurrentRow.Cells("referen").Value
                    frPedido.dgLineasPres2.CurrentRow.Cells(3).Value = dgArticulos.CurrentRow.Cells("descrip").Value
                    frPedido.dgLineasPres2.CurrentRow.Cells(5).Value = dgArticulos.CurrentRow.Cells("longitud").Value
                    frPedido.dgLineasPres2.CurrentRow.Cells(7).Value = dgArticulos.CurrentRow.Cells("prec").Value
                    frPedido.txIva.Text = dgArticulos.CurrentRow.Cells("porciva").Value
                    frPedido.dgLineasPres2.CurrentCell = frPedido.dgLineasPres2.CurrentRow.Cells(4)
                    frPedido.dgLineasPres2.BeginEdit(True)
                    frPedido.actualizarLinea()
                    frPedido.recalcularTotales()

                    Me.Hide()
                End If
            End If
        End If



    End Sub
End Class