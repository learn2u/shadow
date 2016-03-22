Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Imports System.Globalization
Imports System.ComponentModel
Imports System.Xml
Public Class frVerLotes
    Public Shared vReferencia As String
    Public Shared vPrecio As Decimal
    Public Shared vIva As Decimal
    Public Shared vLote As String

    Private Sub frVerLotes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conexionmy As New MySqlConnection("server=" + vServidor + "; User ID=" + vUsuario + "; database=" + vBasedatos)

        conexionmy.Open()
        Dim consultamy As New MySqlCommand("SELECT referencia,descripcion,lote,stock FROM lotes WHERE referencia = '" + vReferencia + "'", conexionmy)

        Dim readermy As MySqlDataReader
        Dim dtable As New DataTable
        Dim bind As New BindingSource()


        readermy = consultamy.ExecuteReader
        dtable.Load(readermy, LoadOption.OverwriteChanges)

        bind.DataSource = dtable


        dgLotes.DataSource = bind
        dgLotes.AutoGenerateColumns = False
        dgLotes.Columns(0).HeaderText = "REFERENCIA"
        dgLotes.Columns(0).Name = "referen"
        dgLotes.Columns(0).FillWeight = 80
        dgLotes.Columns(0).MinimumWidth = 80
        dgLotes.Columns(1).HeaderText = "DESCRIPCION"
        dgLotes.Columns(1).Name = "descrip"
        dgLotes.Columns(1).FillWeight = 245
        dgLotes.Columns(1).MinimumWidth = 245
        dgLotes.Columns(2).HeaderText = "LOTE"
        dgLotes.Columns(2).Name = "lote"
        dgLotes.Columns(2).FillWeight = 50
        dgLotes.Columns(2).MinimumWidth = 50
        dgLotes.Columns(3).HeaderText = "STOCK"
        dgLotes.Columns(3).Name = "stock"
        dgLotes.Columns(3).FillWeight = 50
        dgLotes.Columns(3).MinimumWidth = 50


        dgLotes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        conexionmy.Close()
    End Sub

    Private Sub dgLotes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgLotes.CellClick
        vLote = dgLotes.CurrentRow.Cells("lote").Value
        If formArti = "P" Then
            If frPresupuestos.flagEdit = "N" Then
                frPresupuestos.dgLineasPres1.CurrentRow.Cells(2).Value = dgLotes.CurrentRow.Cells("referen").Value
                frPresupuestos.dgLineasPres1.CurrentRow.Cells(3).Value = dgLotes.CurrentRow.Cells("descrip").Value
                'frPresupuestos.dgLineasPres1.CurrentRow.Cells(5).Value = dgLotes.CurrentRow.Cells("longitud").Value
                frPresupuestos.dgLineasPres1.CurrentRow.Cells(7).Value = vPrecio
                frPresupuestos.dgLineasPres1.CurrentRow.Cells(11).Value = vLote
                frPresupuestos.txIva.Text = vIva
                frPresupuestos.dgLineasPres1.CurrentCell = frPresupuestos.dgLineasPres1.CurrentRow.Cells(4)
                frPresupuestos.dgLineasPres1.BeginEdit(True)

                Me.Hide()
            Else
                frPresupuestos.dgLineasPres2.CurrentRow.Cells(2).Value = dgLotes.CurrentRow.Cells("referen").Value
                frPresupuestos.dgLineasPres2.CurrentRow.Cells(3).Value = dgLotes.CurrentRow.Cells("descrip").Value
                'frPresupuestos.dgLineasPres2.CurrentRow.Cells(5).Value = dgLotes.CurrentRow.Cells("longitud").Value
                frPresupuestos.dgLineasPres2.CurrentRow.Cells(7).Value = vPrecio
                frPresupuestos.dgLineasPres2.CurrentRow.Cells(11).Value = vLote
                frPresupuestos.txIva.Text = vIva
                frPresupuestos.dgLineasPres2.CurrentCell = frPresupuestos.dgLineasPres2.CurrentRow.Cells(4)
                frPresupuestos.dgLineasPres2.BeginEdit(True)
                frPresupuestos.actualizarLinea()
                frPresupuestos.recalcularTotales()

                Me.Hide()
            End If
        End If
        If formArti = "A" Then
            If frAlbaran.flagEdit = "N" Then
                frAlbaran.dgLineasPres1.CurrentRow.Cells(2).Value = dgLotes.CurrentRow.Cells("referen").Value
                frAlbaran.dgLineasPres1.CurrentRow.Cells(3).Value = dgLotes.CurrentRow.Cells("descrip").Value
                'frAlbaran.dgLineasPres1.CurrentRow.Cells(5).Value = dgLotes.CurrentRow.Cells("longitud").Value
                frAlbaran.dgLineasPres1.CurrentRow.Cells(7).Value = vPrecio
                frAlbaran.dgLineasPres1.CurrentRow.Cells(11).Value = vLote
                frAlbaran.txIva.Text = vIva
                frAlbaran.dgLineasPres1.CurrentCell = frAlbaran.dgLineasPres1.CurrentRow.Cells(4)
                frAlbaran.dgLineasPres1.BeginEdit(True)

                Me.Hide()
            Else
                frAlbaran.dgLineasPres2.CurrentRow.Cells(2).Value = dgLotes.CurrentRow.Cells("referen").Value
                frAlbaran.dgLineasPres2.CurrentRow.Cells(3).Value = dgLotes.CurrentRow.Cells("descrip").Value
                'frAlbaran.dgLineasPres2.CurrentRow.Cells(5).Value = dgLotes.CurrentRow.Cells("longitud").Value
                frAlbaran.dgLineasPres2.CurrentRow.Cells(7).Value = vPrecio
                frAlbaran.dgLineasPres2.CurrentRow.Cells(11).Value = vLote
                frAlbaran.txIva.Text = vIva
                frAlbaran.dgLineasPres2.CurrentCell = frAlbaran.dgLineasPres2.CurrentRow.Cells(4)
                frAlbaran.dgLineasPres2.BeginEdit(True)
                frAlbaran.actualizarLinea()
                frAlbaran.recalcularTotales()

                Me.Hide()
            End If
        End If

        If formArti = "D" Then
            If frPedido.flagEdit = "N" Then
                frPedido.dgLineasPres1.CurrentRow.Cells(2).Value = dgLotes.CurrentRow.Cells("referen").Value
                frPedido.dgLineasPres1.CurrentRow.Cells(3).Value = dgLotes.CurrentRow.Cells("descrip").Value
                'frPedido.dgLineasPres1.CurrentRow.Cells(5).Value = dgLotes.CurrentRow.Cells("longitud").Value
                frPedido.dgLineasPres1.CurrentRow.Cells(7).Value = vPrecio
                frPedido.dgLineasPres1.CurrentRow.Cells(11).Value = vLote
                frPedido.txIva.Text = vIva
                frPedido.dgLineasPres1.CurrentCell = frPedido.dgLineasPres1.CurrentRow.Cells(4)
                frPedido.dgLineasPres1.BeginEdit(True)

                Me.Hide()
            Else
                frPedido.dgLineasPres2.CurrentRow.Cells(2).Value = dgLotes.CurrentRow.Cells("referen").Value
                frPedido.dgLineasPres2.CurrentRow.Cells(3).Value = dgLotes.CurrentRow.Cells("descrip").Value
                'frPedido.dgLineasPres2.CurrentRow.Cells(5).Value = dgLotes.CurrentRow.Cells("longitud").Value
                frPedido.dgLineasPres2.CurrentRow.Cells(7).Value = vPrecio
                frPedido.dgLineasPres2.CurrentRow.Cells(11).Value = vLote
                frPedido.txIva.Text = vIva
                frPedido.dgLineasPres2.CurrentCell = frPedido.dgLineasPres2.CurrentRow.Cells(4)
                frPedido.dgLineasPres2.BeginEdit(True)
                frPedido.actualizarLinea()
                frPedido.recalcularTotales()

                Me.Hide()
            End If
        End If
    End Sub

    Private Sub txLote_TextChanged(sender As Object, e As EventArgs) Handles txLote.TextChanged
        Dim conexionmy As New MySqlConnection("server=" + vServidor + "; User ID=" + vUsuario + "; database=" + vBasedatos)

        conexionmy.Open()
        Dim consultamy As New MySqlCommand("SELECT referencia,descripcion,lote,stock FROM lotes WHERE referencia = '" + vReferencia + "' AND lote LIKE '%" & txLote.Text & "%'", conexionmy)

        Dim readermy As MySqlDataReader
        Dim dtable As New DataTable
        Dim bind As New BindingSource()


        readermy = consultamy.ExecuteReader
        dtable.Load(readermy, LoadOption.OverwriteChanges)

        bind.DataSource = dtable


        dgLotes.DataSource = bind
        dgLotes.AutoGenerateColumns = False
        dgLotes.Columns(0).HeaderText = "REFERENCIA"
        dgLotes.Columns(0).Name = "referen"
        dgLotes.Columns(0).FillWeight = 80
        dgLotes.Columns(0).MinimumWidth = 80
        dgLotes.Columns(1).HeaderText = "DESCRIPCION"
        dgLotes.Columns(1).Name = "descrip"
        dgLotes.Columns(1).FillWeight = 245
        dgLotes.Columns(1).MinimumWidth = 245
        dgLotes.Columns(2).HeaderText = "LOTE"
        dgLotes.Columns(2).Name = "lote"
        dgLotes.Columns(2).FillWeight = 50
        dgLotes.Columns(2).MinimumWidth = 50
        dgLotes.Columns(3).HeaderText = "STOCK"
        dgLotes.Columns(3).Name = "stock"
        dgLotes.Columns(3).FillWeight = 50
        dgLotes.Columns(3).MinimumWidth = 50


        dgLotes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        conexionmy.Close()
    End Sub

    Private Sub txLote_KeyDown(sender As Object, e As KeyEventArgs) Handles txLote.KeyDown
        Dim address As Point = Me.dgLotes.CurrentCellAddress
        If e.KeyCode = Keys.Down Then
            If address.Y < Me.dgLotes.RowCount - 1 Then
                address.Y += 1
            End If

            Me.dgLotes.CurrentCell = Me.dgLotes(address.X, address.Y)
        End If
        If e.KeyCode = Keys.Up Then
            If address.Y <> 0 Then
                address.Y -= 1
            End If

            Me.dgLotes.CurrentCell = Me.dgLotes(address.X, address.Y)
        End If

        If e.KeyCode = Keys.Enter Then
            vLote = dgLotes.CurrentRow.Cells("lote").Value
            If formArti = "P" Then
                If frPresupuestos.flagEdit = "N" Then
                    frPresupuestos.dgLineasPres1.CurrentRow.Cells(2).Value = dgLotes.CurrentRow.Cells("referen").Value
                    frPresupuestos.dgLineasPres1.CurrentRow.Cells(3).Value = dgLotes.CurrentRow.Cells("descrip").Value
                    'frPresupuestos.dgLineasPres1.CurrentRow.Cells(5).Value = dgLotes.CurrentRow.Cells("longitud").Value
                    frPresupuestos.dgLineasPres1.CurrentRow.Cells(7).Value = vPrecio
                    frPresupuestos.dgLineasPres1.CurrentRow.Cells(11).Value = vLote
                    frPresupuestos.txIva.Text = vIva
                    frPresupuestos.dgLineasPres1.CurrentCell = frPresupuestos.dgLineasPres1.CurrentRow.Cells(4)
                    frPresupuestos.dgLineasPres1.BeginEdit(True)

                    Me.Hide()
                Else
                    frPresupuestos.dgLineasPres2.CurrentRow.Cells(2).Value = dgLotes.CurrentRow.Cells("referen").Value
                    frPresupuestos.dgLineasPres2.CurrentRow.Cells(3).Value = dgLotes.CurrentRow.Cells("descrip").Value
                    'frPresupuestos.dgLineasPres2.CurrentRow.Cells(5).Value = dgLotes.CurrentRow.Cells("longitud").Value
                    frPresupuestos.dgLineasPres2.CurrentRow.Cells(7).Value = vPrecio
                    frPresupuestos.dgLineasPres2.CurrentRow.Cells(11).Value = vLote
                    frPresupuestos.txIva.Text = vIva
                    frPresupuestos.dgLineasPres2.CurrentCell = frPresupuestos.dgLineasPres2.CurrentRow.Cells(4)
                    frPresupuestos.dgLineasPres2.BeginEdit(True)
                    frPresupuestos.actualizarLinea()
                    frPresupuestos.recalcularTotales()

                    Me.Hide()
                End If
            End If
            If formArti = "A" Then
                If frAlbaran.flagEdit = "N" Then
                    frAlbaran.dgLineasPres1.CurrentRow.Cells(2).Value = dgLotes.CurrentRow.Cells("referen").Value
                    frAlbaran.dgLineasPres1.CurrentRow.Cells(3).Value = dgLotes.CurrentRow.Cells("descrip").Value
                    'frAlbaran.dgLineasPres1.CurrentRow.Cells(5).Value = dgLotes.CurrentRow.Cells("longitud").Value
                    frAlbaran.dgLineasPres1.CurrentRow.Cells(7).Value = vPrecio
                    frAlbaran.dgLineasPres1.CurrentRow.Cells(11).Value = vLote
                    frAlbaran.txIva.Text = vIva
                    frAlbaran.dgLineasPres1.CurrentCell = frAlbaran.dgLineasPres1.CurrentRow.Cells(4)
                    frAlbaran.dgLineasPres1.BeginEdit(True)

                    Me.Hide()
                Else
                    frAlbaran.dgLineasPres2.CurrentRow.Cells(2).Value = dgLotes.CurrentRow.Cells("referen").Value
                    frAlbaran.dgLineasPres2.CurrentRow.Cells(3).Value = dgLotes.CurrentRow.Cells("descrip").Value
                    'frAlbaran.dgLineasPres2.CurrentRow.Cells(5).Value = dgLotes.CurrentRow.Cells("longitud").Value
                    frAlbaran.dgLineasPres2.CurrentRow.Cells(7).Value = vPrecio
                    frAlbaran.dgLineasPres2.CurrentRow.Cells(11).Value = vLote
                    frAlbaran.txIva.Text = vIva
                    frAlbaran.dgLineasPres2.CurrentCell = frAlbaran.dgLineasPres2.CurrentRow.Cells(4)
                    frAlbaran.dgLineasPres2.BeginEdit(True)
                    frAlbaran.actualizarLinea()
                    frAlbaran.recalcularTotales()

                    Me.Hide()
                End If
            End If

            If formArti = "D" Then
                If frPedido.flagEdit = "N" Then
                    frPedido.dgLineasPres1.CurrentRow.Cells(2).Value = dgLotes.CurrentRow.Cells("referen").Value
                    frPedido.dgLineasPres1.CurrentRow.Cells(3).Value = dgLotes.CurrentRow.Cells("descrip").Value
                    'frPedido.dgLineasPres1.CurrentRow.Cells(5).Value = dgLotes.CurrentRow.Cells("longitud").Value
                    frPedido.dgLineasPres1.CurrentRow.Cells(7).Value = vPrecio
                    frPedido.dgLineasPres1.CurrentRow.Cells(11).Value = vLote
                    frPedido.txIva.Text = vIva
                    frPedido.dgLineasPres1.CurrentCell = frPedido.dgLineasPres1.CurrentRow.Cells(4)
                    frPedido.dgLineasPres1.BeginEdit(True)

                    Me.Hide()
                Else
                    frPedido.dgLineasPres2.CurrentRow.Cells(2).Value = dgLotes.CurrentRow.Cells("referen").Value
                    frPedido.dgLineasPres2.CurrentRow.Cells(3).Value = dgLotes.CurrentRow.Cells("descrip").Value
                    'frPedido.dgLineasPres2.CurrentRow.Cells(5).Value = dgLotes.CurrentRow.Cells("longitud").Value
                    frPedido.dgLineasPres2.CurrentRow.Cells(7).Value = vPrecio
                    frPedido.dgLineasPres2.CurrentRow.Cells(11).Value = vLote
                    frPedido.txIva.Text = vIva
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