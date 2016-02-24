Public Class frCrearLotes
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btCancelar.Click
        LimpiarFormulario()
        dgLotes.Rows.Clear()
        Me.Close()

    End Sub

    Private Sub frCrearLotes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Inicialización formulario

    End Sub

    Private Sub btNuevo_Click(sender As Object, e As EventArgs) Handles btNuevo.Click
        dgLotes.Rows.Add()
        dgLotes.Rows(dgLotes.Rows.Count - 1).Cells(0).Value = txReferencia.Text
        dgLotes.Rows(dgLotes.Rows.Count - 1).Cells(1).Value = txDescripcion.Text
        dgLotes.Rows(dgLotes.Rows.Count - 1).Cells(2).Value = txLote.Text
        dgLotes.Rows(dgLotes.Rows.Count - 1).Cells(3).Value = txStock.Text
        dgLotes.Rows(dgLotes.Rows.Count - 1).Cells(4).Value = txFecha.Text
        dgLotes.Rows(dgLotes.Rows.Count - 1).Cells(5).Value = txUbicacion.Text
        LimpiarFormulario()
        txLote.Focus()

    End Sub
    Public Sub LimpiarFormulario()
        txLote.Text = ""
        txStock.Text = 0
        txFecha.Text = Format(Today, "ddMMyyyy")
        txUbicacion.Text = ""

    End Sub

    Private Sub btEliminar_Click(sender As Object, e As EventArgs) Handles btEliminar.Click
        dgLotes.Rows.RemoveAt(dgLotes.CurrentRow.Index)
        LimpiarFormulario()
        txLote.Focus()
    End Sub
End Class