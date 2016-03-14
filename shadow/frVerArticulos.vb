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
        Dim consultamy As New MySqlCommand("SELECT articulos2.ref_proveedor,articulos2.descripcion,proveedores.nombre, articulos2.stock, articulos2.pvp, proveedores.proveedorID, articulos2.stock_disp, articulos2.iva, articulos2.medidaID, articulos2.familia FROM articulos2 INNER JOIN proveedores ON articulos2.proveedorID=proveedores.proveedorID", conexionmy)

        Dim readermy As MySqlDataReader
        Dim dtable As New DataTable
        Dim bind As New BindingSource()


        readermy = consultamy.ExecuteReader
        dtable.Load(readermy, LoadOption.OverwriteChanges)

        bind.DataSource = dtable


        dgArticulos.DataSource = bind
        dgArticulos.AutoGenerateColumns = False
        dgArticulos.Columns(0).HeaderText = "REF PROV"
        dgArticulos.Columns(0).Name = "refpro"
        dgArticulos.Columns(0).FillWeight = 80
        dgArticulos.Columns(0).MinimumWidth = 80
        dgArticulos.Columns(1).HeaderText = "DESCRIPCION"
        dgArticulos.Columns(1).Name = "descrip"
        dgArticulos.Columns(1).FillWeight = 200
        dgArticulos.Columns(1).MinimumWidth = 200
        dgArticulos.Columns(2).HeaderText = "PROVEEDOR"
        dgArticulos.Columns(2).Name = "prov"
        dgArticulos.Columns(2).FillWeight = 180
        dgArticulos.Columns(2).MinimumWidth = 180
        dgArticulos.Columns(3).HeaderText = "STOCK"
        dgArticulos.Columns(3).Name = "stock"
        dgArticulos.Columns(3).FillWeight = 50
        dgArticulos.Columns(3).MinimumWidth = 50
        dgArticulos.Columns(4).HeaderText = "PVP"
        dgArticulos.Columns(4).Name = "prec"
        dgArticulos.Columns(4).FillWeight = 50
        dgArticulos.Columns(4).MinimumWidth = 50
        dgArticulos.Columns(5).HeaderText = "ID"
        dgArticulos.Columns(5).Name = "provID"
        dgArticulos.Columns(5).Visible = False
        dgArticulos.Columns(6).HeaderText = "DISP"
        dgArticulos.Columns(6).Name = "disponible"
        dgArticulos.Columns(6).Visible = False
        dgArticulos.Columns(7).HeaderText = "IVA"
        dgArticulos.Columns(7).Name = "porciva"
        dgArticulos.Columns(7).Visible = False
        dgArticulos.Columns(8).HeaderText = "MEDIDA"
        dgArticulos.Columns(8).Name = "longitud"
        dgArticulos.Columns(8).Visible = False
        dgArticulos.Columns(9).HeaderText = "FAMILIA"
        dgArticulos.Columns(9).Name = "fam"
        dgArticulos.Columns(9).Visible = False


        dgArticulos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        conexionmy.Close()

    End Sub

    Private Sub txCodigo_TextChanged(sender As Object, e As EventArgs) Handles txCodigo.TextChanged
        Dim conexionmy As New MySqlConnection("server=" + vServidor + "; User ID=" + vUsuario + "; database=" + vBasedatos)


        conexionmy.Open()
        Dim consultamy As New MySqlCommand("SELECT articulos2.ref_proveedor,articulos2.descripcion,proveedores.nombre, articulos2.stock, articulos2.pvp, proveedores.proveedorID, articulos2.stock_disp, articulos2.iva, articulos2.medidaID, articulos2.familia FROM articulos2 INNER JOIN proveedores ON articulos2.proveedorID=proveedores.proveedorID WHERE ref_proveedor LIKE'" & txCodigo.Text & "%'", conexionmy)

        Dim readermy As MySqlDataReader
        Dim dtable As New DataTable
        Dim bind As New BindingSource()


        readermy = consultamy.ExecuteReader
        dtable.Load(readermy, LoadOption.OverwriteChanges)

        bind.DataSource = dtable


        dgArticulos.DataSource = bind
        dgArticulos.AutoGenerateColumns = False
        dgArticulos.Columns(0).HeaderText = "REF PROV"
        dgArticulos.Columns(0).Name = "refpro"
        dgArticulos.Columns(0).FillWeight = 80
        dgArticulos.Columns(0).MinimumWidth = 80
        dgArticulos.Columns(1).HeaderText = "DESCRIPCION"
        dgArticulos.Columns(1).Name = "descrip"
        dgArticulos.Columns(1).FillWeight = 200
        dgArticulos.Columns(1).MinimumWidth = 200
        dgArticulos.Columns(2).HeaderText = "PROVEEDOR"
        dgArticulos.Columns(2).Name = "prov"
        dgArticulos.Columns(2).FillWeight = 180
        dgArticulos.Columns(2).MinimumWidth = 180
        dgArticulos.Columns(3).HeaderText = "STOCK"
        dgArticulos.Columns(3).Name = "stock"
        dgArticulos.Columns(3).FillWeight = 50
        dgArticulos.Columns(3).MinimumWidth = 50
        dgArticulos.Columns(4).HeaderText = "PVP"
        dgArticulos.Columns(4).Name = "prec"
        dgArticulos.Columns(4).FillWeight = 50
        dgArticulos.Columns(4).MinimumWidth = 50
        dgArticulos.Columns(5).HeaderText = "ID"
        dgArticulos.Columns(5).Name = "provID"
        dgArticulos.Columns(5).Visible = False
        dgArticulos.Columns(6).HeaderText = "DISP"
        dgArticulos.Columns(6).Name = "disponible"
        dgArticulos.Columns(6).Visible = False
        dgArticulos.Columns(7).HeaderText = "IVA"
        dgArticulos.Columns(7).Name = "porciva"
        dgArticulos.Columns(7).Visible = False
        dgArticulos.Columns(8).HeaderText = "MEDIDA"
        dgArticulos.Columns(8).Name = "longitud"
        dgArticulos.Columns(8).Visible = False
        dgArticulos.Columns(9).HeaderText = "FAMILIA"
        dgArticulos.Columns(9).Name = "fam"
        dgArticulos.Columns(9).Visible = False
        dgArticulos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        conexionmy.Close()

    End Sub

    Private Sub txArticulo_TextChanged(sender As Object, e As EventArgs) Handles txArticulo.TextChanged
        If txArticulo.Text <> "" Then
            Dim conexionmy As New MySqlConnection("server=" + vServidor + "; User ID=" + vUsuario + "; database=" + vBasedatos)
            Dim vFiltro As String
            vFiltro = txArticulo.Text
            conexionmy.Open()
            Dim consultamy As New MySqlCommand("SELECT articulos2.ref_proveedor,articulos2.descripcion,proveedores.nombre, articulos2.stock, articulos2.pvp, proveedores.proveedorID, articulos2.stock_disp, articulos2.iva, articulos2.medidaID, articulos2.familia FROM articulos2 INNER JOIN proveedores ON articulos2.proveedorID=proveedores.proveedorID WHERE descripcion LIKE'" & vFiltro & "%'", conexionmy)

            Dim readermy As MySqlDataReader
            Dim dtable As New DataTable
            Dim bind As New BindingSource()


            readermy = consultamy.ExecuteReader
            dtable.Load(readermy, LoadOption.OverwriteChanges)

            bind.DataSource = dtable


            dgArticulos.DataSource = bind
            dgArticulos.AutoGenerateColumns = False
            dgArticulos.Columns(0).HeaderText = "REF PROV"
            dgArticulos.Columns(0).Name = "refpro"
            dgArticulos.Columns(0).FillWeight = 80
            dgArticulos.Columns(0).MinimumWidth = 80
            dgArticulos.Columns(1).HeaderText = "DESCRIPCION"
            dgArticulos.Columns(1).Name = "descrip"
            dgArticulos.Columns(1).FillWeight = 200
            dgArticulos.Columns(1).MinimumWidth = 200
            dgArticulos.Columns(2).HeaderText = "PROVEEDOR"
            dgArticulos.Columns(2).Name = "prov"
            dgArticulos.Columns(2).FillWeight = 180
            dgArticulos.Columns(2).MinimumWidth = 180
            dgArticulos.Columns(3).HeaderText = "STOCK"
            dgArticulos.Columns(3).Name = "stock"
            dgArticulos.Columns(3).FillWeight = 50
            dgArticulos.Columns(3).MinimumWidth = 50
            dgArticulos.Columns(4).HeaderText = "PVP"
            dgArticulos.Columns(4).Name = "prec"
            dgArticulos.Columns(4).FillWeight = 50
            dgArticulos.Columns(4).MinimumWidth = 50
            dgArticulos.Columns(5).HeaderText = "ID"
            dgArticulos.Columns(5).Name = "provID"
            dgArticulos.Columns(5).Visible = False
            dgArticulos.Columns(6).HeaderText = "DISP"
            dgArticulos.Columns(6).Name = "disponible"
            dgArticulos.Columns(6).Visible = False
            dgArticulos.Columns(7).HeaderText = "IVA"
            dgArticulos.Columns(7).Name = "porciva"
            dgArticulos.Columns(7).Visible = False
            dgArticulos.Columns(8).HeaderText = "MEDIDA"
            dgArticulos.Columns(8).Name = "longitud"
            dgArticulos.Columns(8).Visible = False
            dgArticulos.Columns(9).HeaderText = "FAMILIA"
            dgArticulos.Columns(9).Name = "fam"
            dgArticulos.Columns(9).Visible = False

            dgArticulos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            conexionmy.Close()
        Else

        End If


    End Sub

    Private Sub dgArticulos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgArticulos.CellDoubleClick
        If dgArticulos.CurrentRow.Cells("fam").Value = 7 And formArti <> "P" Then
            frVerLotes.vReferencia = dgArticulos.CurrentRow.Cells("referen").Value
            frVerLotes.vPrecio = dgArticulos.CurrentRow.Cells("prec").Value
            frVerLotes.vIva = dgArticulos.CurrentRow.Cells("porciva").Value
            frVerLotes.Show()
        Else
            If formArti = "P" Then
                If frPresupuestos.flagEdit = "N" Then
                    frPresupuestos.dgLineasPres1.CurrentRow.Cells(2).Value = dgArticulos.CurrentRow.Cells("refpro").Value
                    frPresupuestos.dgLineasPres1.CurrentRow.Cells(3).Value = dgArticulos.CurrentRow.Cells("descrip").Value
                    frPresupuestos.dgLineasPres1.CurrentRow.Cells(4).Value = 1
                    frPresupuestos.dgLineasPres1.CurrentRow.Cells(5).Value = dgArticulos.CurrentRow.Cells("longitud").Value / 100
                    frPresupuestos.dgLineasPres1.CurrentRow.Cells(6).Value = frPresupuestos.dgLineasPres1.CurrentRow.Cells(4).Value * frPresupuestos.dgLineasPres1.CurrentRow.Cells(5).Value
                    frPresupuestos.dgLineasPres1.CurrentRow.Cells(7).Value = dgArticulos.CurrentRow.Cells("prec").Value
                    frPresupuestos.txIva.Text = dgArticulos.CurrentRow.Cells("porciva").Value
                    frPresupuestos.dgLineasPres1.CurrentCell = frPresupuestos.dgLineasPres1.CurrentRow.Cells(4)
                    frPresupuestos.dgLineasPres1.BeginEdit(True)
                    txArticulo.Text = ""
                    Me.txArticulo.Focus()
                    Me.Hide()
                Else
                    frPresupuestos.dgLineasPres2.CurrentRow.Cells(2).Value = dgArticulos.CurrentRow.Cells("refpro").Value
                    frPresupuestos.dgLineasPres2.CurrentRow.Cells(3).Value = dgArticulos.CurrentRow.Cells("descrip").Value
                    frPresupuestos.dgLineasPres2.CurrentRow.Cells(4).Value = 1
                    frPresupuestos.dgLineasPres2.CurrentRow.Cells(5).Value = dgArticulos.CurrentRow.Cells("longitud").Value / 100
                    frPresupuestos.dgLineasPres2.CurrentRow.Cells(6).Value = frPresupuestos.dgLineasPres2.CurrentRow.Cells(4).Value * frPresupuestos.dgLineasPres2.CurrentRow.Cells(5).Value
                    frPresupuestos.dgLineasPres2.CurrentRow.Cells(7).Value = dgArticulos.CurrentRow.Cells("prec").Value
                    frPresupuestos.txIva.Text = dgArticulos.CurrentRow.Cells("porciva").Value
                    frPresupuestos.dgLineasPres2.CurrentCell = frPresupuestos.dgLineasPres2.CurrentRow.Cells(4)
                    frPresupuestos.dgLineasPres2.BeginEdit(True)
                    frPresupuestos.actualizarLinea()
                    frPresupuestos.recalcularTotales()
                    txArticulo.Text = ""
                    Me.txArticulo.Focus()
                    Me.Hide()
                End If
            End If
            If formArti = "A" Then
                If frAlbaran.flagEdit = "N" Then
                    frAlbaran.dgLineasPres1.CurrentRow.Cells(2).Value = dgArticulos.CurrentRow.Cells("refpro").Value
                    frAlbaran.dgLineasPres1.CurrentRow.Cells(3).Value = dgArticulos.CurrentRow.Cells("descrip").Value
                    frAlbaran.dgLineasPres1.CurrentRow.Cells(4).Value = 1
                    frAlbaran.dgLineasPres1.CurrentRow.Cells(5).Value = dgArticulos.CurrentRow.Cells("longitud").Value / 100
                    frAlbaran.dgLineasPres1.CurrentRow.Cells(6).Value = frAlbaran.dgLineasPres1.CurrentRow.Cells(4).Value * frAlbaran.dgLineasPres1.CurrentRow.Cells(5).Value
                    frAlbaran.dgLineasPres1.CurrentRow.Cells(7).Value = dgArticulos.CurrentRow.Cells("prec").Value
                    frAlbaran.txIva.Text = dgArticulos.CurrentRow.Cells("porciva").Value
                    frAlbaran.dgLineasPres1.CurrentCell = frAlbaran.dgLineasPres1.CurrentRow.Cells(4)
                    frAlbaran.dgLineasPres1.BeginEdit(True)
                    txArticulo.Text = ""
                    Me.txArticulo.Focus()
                    Me.Hide()
                Else
                    frAlbaran.dgLineasPres2.CurrentRow.Cells(2).Value = dgArticulos.CurrentRow.Cells("refpro").Value
                    frAlbaran.dgLineasPres2.CurrentRow.Cells(3).Value = dgArticulos.CurrentRow.Cells("descrip").Value
                    frAlbaran.dgLineasPres2.CurrentRow.Cells(4).Value = 1
                    frAlbaran.dgLineasPres2.CurrentRow.Cells(5).Value = dgArticulos.CurrentRow.Cells("longitud").Value / 100
                    frAlbaran.dgLineasPres2.CurrentRow.Cells(6).Value = frAlbaran.dgLineasPres2.CurrentRow.Cells(4).Value * frAlbaran.dgLineasPres2.CurrentRow.Cells(5).Value
                    frAlbaran.dgLineasPres2.CurrentRow.Cells(7).Value = dgArticulos.CurrentRow.Cells("prec").Value
                    frAlbaran.txIva.Text = dgArticulos.CurrentRow.Cells("porciva").Value
                    frAlbaran.dgLineasPres2.CurrentCell = frAlbaran.dgLineasPres2.CurrentRow.Cells(4)
                    frAlbaran.dgLineasPres2.BeginEdit(True)
                    frAlbaran.actualizarLinea()
                    frAlbaran.recalcularTotales()
                    txArticulo.Text = ""
                    Me.txArticulo.Focus()
                    Me.Hide()
                End If
            End If

            If formArti = "D" Then
                If frPedido.flagEdit = "N" Then
                    frPedido.dgLineasPres1.CurrentRow.Cells(2).Value = dgArticulos.CurrentRow.Cells("refpro").Value
                    frPedido.dgLineasPres1.CurrentRow.Cells(3).Value = dgArticulos.CurrentRow.Cells("descrip").Value
                    frPedido.dgLineasPres1.CurrentRow.Cells(4).Value = 1
                    frPedido.dgLineasPres1.CurrentRow.Cells(5).Value = dgArticulos.CurrentRow.Cells("longitud").Value / 100
                    frPedido.dgLineasPres1.CurrentRow.Cells(6).Value = frPedido.dgLineasPres1.CurrentRow.Cells(4).Value * frPedido.dgLineasPres1.CurrentRow.Cells(5).Value
                    frPedido.dgLineasPres1.CurrentRow.Cells(7).Value = dgArticulos.CurrentRow.Cells("prec").Value
                    frPedido.txIva.Text = dgArticulos.CurrentRow.Cells("porciva").Value
                    frPedido.dgLineasPres1.CurrentCell = frPedido.dgLineasPres1.CurrentRow.Cells(4)
                    frPedido.dgLineasPres1.BeginEdit(True)
                    txArticulo.Text = ""
                    Me.txArticulo.Focus()
                    Me.Hide()
                Else
                    frPedido.dgLineasPres2.CurrentRow.Cells(2).Value = dgArticulos.CurrentRow.Cells("refpro").Value
                    frPedido.dgLineasPres2.CurrentRow.Cells(3).Value = dgArticulos.CurrentRow.Cells("descrip").Value
                    frPedido.dgLineasPres2.CurrentRow.Cells(4).Value = 1
                    frPedido.dgLineasPres2.CurrentRow.Cells(5).Value = dgArticulos.CurrentRow.Cells("longitud").Value / 100
                    frPedido.dgLineasPres2.CurrentRow.Cells(6).Value = frPedido.dgLineasPres2.CurrentRow.Cells(4).Value * frPedido.dgLineasPres2.CurrentRow.Cells(5).Value
                    frPedido.dgLineasPres2.CurrentRow.Cells(7).Value = dgArticulos.CurrentRow.Cells("prec").Value
                    frPedido.txIva.Text = dgArticulos.CurrentRow.Cells("porciva").Value
                    frPedido.dgLineasPres2.CurrentCell = frPedido.dgLineasPres2.CurrentRow.Cells(4)
                    frPedido.dgLineasPres2.BeginEdit(True)
                    frPedido.actualizarLinea()
                    frPedido.recalcularTotales()
                    txArticulo.Text = ""
                    Me.txArticulo.Focus()
                    Me.Hide()
                End If
            End If

            If formArti = "F" Then
                If frFacturaManual.flagEdit = "N" Then
                    frFacturaManual.dgLineasPres1.CurrentRow.Cells(2).Value = dgArticulos.CurrentRow.Cells("refpro").Value
                    frFacturaManual.dgLineasPres1.CurrentRow.Cells(3).Value = dgArticulos.CurrentRow.Cells("descrip").Value
                    frFacturaManual.dgLineasPres1.CurrentRow.Cells(4).Value = 1
                    frFacturaManual.dgLineasPres1.CurrentRow.Cells(5).Value = dgArticulos.CurrentRow.Cells("longitud").Value / 100
                    frFacturaManual.dgLineasPres1.CurrentRow.Cells(6).Value = frFacturaManual.dgLineasPres1.CurrentRow.Cells(4).Value * frFacturaManual.dgLineasPres1.CurrentRow.Cells(5).Value
                    frFacturaManual.dgLineasPres1.CurrentRow.Cells(7).Value = dgArticulos.CurrentRow.Cells("prec").Value
                    frFacturaManual.txIva.Text = dgArticulos.CurrentRow.Cells("porciva").Value
                    frFacturaManual.dgLineasPres1.CurrentCell = frFacturaManual.dgLineasPres1.CurrentRow.Cells(4)
                    frFacturaManual.dgLineasPres1.BeginEdit(True)
                    txArticulo.Text = ""
                    Me.txArticulo.Focus()
                    Me.Hide()
                Else
                    frFacturaManual.dgLineasPres2.CurrentRow.Cells(2).Value = dgArticulos.CurrentRow.Cells("refpro").Value
                    frFacturaManual.dgLineasPres2.CurrentRow.Cells(3).Value = dgArticulos.CurrentRow.Cells("descrip").Value
                    frFacturaManual.dgLineasPres2.CurrentRow.Cells(4).Value = 1
                    frFacturaManual.dgLineasPres2.CurrentRow.Cells(5).Value = dgArticulos.CurrentRow.Cells("longitud").Value / 100
                    frFacturaManual.dgLineasPres2.CurrentRow.Cells(6).Value = frFacturaManual.dgLineasPres2.CurrentRow.Cells(4).Value * frFacturaManual.dgLineasPres2.CurrentRow.Cells(5).Value
                    frFacturaManual.dgLineasPres2.CurrentRow.Cells(7).Value = dgArticulos.CurrentRow.Cells("prec").Value
                    frFacturaManual.txIva.Text = dgArticulos.CurrentRow.Cells("porciva").Value
                    frFacturaManual.dgLineasPres2.CurrentCell = frFacturaManual.dgLineasPres2.CurrentRow.Cells(4)
                    frFacturaManual.dgLineasPres2.BeginEdit(True)
                    frFacturaManual.actualizarLinea()
                    frFacturaManual.recalcularTotales()
                    txArticulo.Text = ""
                    Me.txArticulo.Focus()
                    Me.Hide()
                End If
            End If
            If formArti = "R" Then
                If frPedidoProv.flagEdit = "N" Then
                    frPedidoProv.dgLineasPres1.CurrentRow.Cells(2).Value = dgArticulos.CurrentRow.Cells("refpro").Value
                    frPedidoProv.dgLineasPres1.CurrentRow.Cells(3).Value = dgArticulos.CurrentRow.Cells("descrip").Value
                    frPedidoProv.dgLineasPres1.CurrentRow.Cells(4).Value = 1
                    frPedidoProv.dgLineasPres1.CurrentRow.Cells(5).Value = dgArticulos.CurrentRow.Cells("longitud").Value / 100
                    frPedidoProv.dgLineasPres1.CurrentRow.Cells(6).Value = frPedidoProv.dgLineasPres1.CurrentRow.Cells(4).Value * frPedidoProv.dgLineasPres1.CurrentRow.Cells(5).Value
                    frPedidoProv.dgLineasPres1.CurrentRow.Cells(7).Value = dgArticulos.CurrentRow.Cells("prec").Value
                    frPedidoProv.txIva.Text = dgArticulos.CurrentRow.Cells("porciva").Value
                    frPedidoProv.dgLineasPres1.CurrentCell = frPedidoProv.dgLineasPres1.CurrentRow.Cells(4)
                    frPedidoProv.dgLineasPres1.BeginEdit(True)
                    txArticulo.Text = ""
                    Me.txArticulo.Focus()
                    Me.Hide()
                Else
                    frPedidoProv.dgLineasPres2.CurrentRow.Cells(2).Value = dgArticulos.CurrentRow.Cells("refpro").Value
                    frPedidoProv.dgLineasPres2.CurrentRow.Cells(3).Value = dgArticulos.CurrentRow.Cells("descrip").Value
                    frPedidoProv.dgLineasPres2.CurrentRow.Cells(4).Value = 1
                    frPedidoProv.dgLineasPres2.CurrentRow.Cells(5).Value = dgArticulos.CurrentRow.Cells("longitud").Value / 100
                    frPedidoProv.dgLineasPres2.CurrentRow.Cells(6).Value = frPedidoProv.dgLineasPres2.CurrentRow.Cells(4).Value * frPedidoProv.dgLineasPres2.CurrentRow.Cells(5).Value
                    frPedidoProv.dgLineasPres2.CurrentRow.Cells(7).Value = dgArticulos.CurrentRow.Cells("prec").Value
                    frPedidoProv.txIva.Text = dgArticulos.CurrentRow.Cells("porciva").Value
                    frPedidoProv.dgLineasPres2.CurrentCell = frPedidoProv.dgLineasPres2.CurrentRow.Cells(4)
                    frPedidoProv.dgLineasPres2.BeginEdit(True)
                    frPedidoProv.actualizarLinea()
                    frPedidoProv.recalcularTotales()
                    txArticulo.Text = ""
                    Me.txArticulo.Focus()
                    Me.Hide()
                End If
            End If
        End If



    End Sub
End Class