Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Imports System.Globalization

Public Class frEmpresa
    Public Shared editEmpresa As Boolean
    Private Sub frEmpresa_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        editEmpresa = False

        Dim conexionmy As New MySqlConnection("server=" + vServidor + "; User ID=" + vUsuario + "; database=" + vBasedatos)
        conexionmy.Open()
        Dim cmd As New MySqlCommand

        Dim rdr As MySqlDataReader

        cmd = New MySqlCommand("SELECT * FROM configuracion", conexionmy)

        cmd.CommandType = CommandType.Text
        cmd.Connection = conexionmy
        rdr = cmd.ExecuteReader


        rdr.Read()

        txRazon.Text = rdr("razon")
        txDescripcion.Text = rdr("descripcion")
        txCif.Text = rdr("cif")
        txDomicilio.Text = rdr("domicilio")
        txCpostal.Text = rdr("cpostal")
        txPoblacion.Text = rdr("poblacion")
        txProvincia.Text = rdr("provincia")
        txTel1.Text = rdr("telefono")
        txTel2.Text = rdr("telefono2")
        txMovil.Text = rdr("telefono3")
        txFax.Text = rdr("num_factura")
        txPorciva.Text = rdr("iva")
        txPorcrec.Text = rdr("recargo")
        'txNAlbaran.Text = rdr("num_albaran")
        'txNEntrada.Text = rdr("num_entrada")
        'txNPresupuesto.Text = rdr("num_presupuesto")
        'txAvion.Text = rdr("avion")
        'txBarco.Text = rdr("barco")


        conexionmy.Close()

    End Sub

    Private Sub btGuardar_Click(sender As Object, e As EventArgs) Handles btGuardar.Click

        If editEmpresa = False Then

        Else
            Dim conexionmy As New MySqlConnection("server=" + vServidor + "; User ID=" + vUsuario + "; database=" + vBasedatos)
            conexionmy.Open()

            Dim cmdActualizar As New MySqlCommand("UPDATE configuracion SET razon = '" + txRazon.Text + "', 
                                                descripcion = '" + txDescripcion.Text + "', 
                                                cif = '" + txCif.Text + "',
                                                domicilio = '" + txDomicilio.Text + "',
                                                cpostal = '" + txCpostal.Text + "',
                                                poblacion = '" + txPoblacion.Text + "',
                                                provincia = '" + txProvincia.Text + "',
                                                telefono = '" + txTel1.Text + "',
                                                iva = '" + txPorciva.Text + "',
                                                recargo = '" + txPorcrec.Text + "',
                                                telefono2 = '" + txTel2.Text + "'", conexionmy)
            cmdActualizar.ExecuteNonQuery()
            MsgBox("Los datos de configuración se han actualizado correctamente")
            Me.Close()
        End If


    End Sub

    Private Sub btCancelar_Click(sender As Object, e As EventArgs) Handles btCancelar.Click
        limpiarFormulario()
        Me.Close()

    End Sub
    Public Sub limpiarFormulario()

    End Sub

    Private Sub btNueva_Click(sender As Object, e As EventArgs) Handles btNueva.Click
        limpiarFormulario()
        txRazon.Focus()

    End Sub
    Public Sub cargoDatos()

    End Sub
End Class