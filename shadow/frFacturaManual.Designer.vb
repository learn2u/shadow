﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frFacturaManual
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frFacturaManual))
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle29 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle30 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cbSerie = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txObserva = New System.Windows.Forms.TextBox()
        Me.txUsuario = New System.Windows.Forms.TextBox()
        Me.txEmpresa = New System.Windows.Forms.TextBox()
        Me.txIva = New System.Windows.Forms.TextBox()
        Me.txDtocli = New System.Windows.Forms.TextBox()
        Me.txAgente = New System.Windows.Forms.TextBox()
        Me.txTotalAlbaran = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txImpRecargo = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txImpIva = New System.Windows.Forms.TextBox()
        Me.txImponible = New System.Windows.Forms.TextBox()
        Me.txImpDto = New System.Windows.Forms.TextBox()
        Me.txImpBruto = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbEnvio = New System.Windows.Forms.ComboBox()
        Me.cmdCancelar = New System.Windows.Forms.ToolStripButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.btBuscar = New System.Windows.Forms.Button()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.txGeneral = New System.Windows.Forms.TextBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.txNumero = New System.Windows.Forms.TextBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.txReferencia = New System.Windows.Forms.TextBox()
        Me.txHasta = New System.Windows.Forms.MaskedTextBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.txCliente = New System.Windows.Forms.TextBox()
        Me.txDesde = New System.Windows.Forms.MaskedTextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.rbPendientes = New System.Windows.Forms.RadioButton()
        Me.rbTodos = New System.Windows.Forms.RadioButton()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.grPlazos = New System.Windows.Forms.GroupBox()
        Me.dgPlazos = New System.Windows.Forms.DataGridView()
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.concepto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.importe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txDiapago = New System.Windows.Forms.TextBox()
        Me.cmdMostrarAgente = New System.Windows.Forms.Button()
        Me.txRecargo = New System.Windows.Forms.TextBox()
        Me.btRecalcular = New System.Windows.Forms.Button()
        Me.cbFormapago = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txNumcli = New System.Windows.Forms.TextBox()
        Me.tsBotones = New System.Windows.Forms.ToolStrip()
        Me.cmdNuevo = New System.Windows.Forms.ToolStripButton()
        Me.cmdGuardar = New System.Windows.Forms.ToolStripButton()
        Me.cmdDelete = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdImprimir = New System.Windows.Forms.ToolStripButton()
        Me.cmdPDF = New System.Windows.Forms.ToolStripButton()
        Me.cmdMail = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdPedido = New System.Windows.Forms.ToolStripButton()
        Me.cmdAlbaran = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdToldos = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdCliente = New System.Windows.Forms.ToolStripSplitButton()
        Me.cmdNuevoCliente = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdEditarCliente = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdRentabilidad = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdLineas = New System.Windows.Forms.ToolStripSplitButton()
        Me.INSERTARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ELIMINARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.dgLineasPres1 = New System.Windows.Forms.DataGridView()
        Me.linea = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btArticulo = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txFecha = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txReferenciapres = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txClientepres = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNumpres = New System.Windows.Forms.TextBox()
        Me.dgLineasPres2 = New System.Windows.Forms.DataGridView()
        Me.linedit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btArtiEdit = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Columna1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Columna2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Columna3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Columna4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Columna5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Columna6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Columna7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Columna8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Columna9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgFacturas = New System.Windows.Forms.DataGridView()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.tabPresupuestos = New System.Windows.Forms.TabControl()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ckPagado = New System.Windows.Forms.CheckBox()
        Me.Panel4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.grPlazos.SuspendLayout()
        CType(Me.dgPlazos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsBotones.SuspendLayout()
        CType(Me.dgLineasPres1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgLineasPres2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.tabPresupuestos.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbSerie
        '
        Me.cbSerie.FormattingEnabled = True
        Me.cbSerie.Items.AddRange(New Object() {"S1", "S2"})
        Me.cbSerie.Location = New System.Drawing.Point(102, 59)
        Me.cbSerie.Name = "cbSerie"
        Me.cbSerie.Size = New System.Drawing.Size(37, 21)
        Me.cbSerie.TabIndex = 108
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(38, 373)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(101, 13)
        Me.Label13.TabIndex = 107
        Me.Label13.Text = "OBSERVACIONES:"
        '
        'txObserva
        '
        Me.txObserva.Location = New System.Drawing.Point(20, 389)
        Me.txObserva.Multiline = True
        Me.txObserva.Name = "txObserva"
        Me.txObserva.Size = New System.Drawing.Size(715, 109)
        Me.txObserva.TabIndex = 3
        '
        'txUsuario
        '
        Me.txUsuario.Location = New System.Drawing.Point(528, 122)
        Me.txUsuario.Name = "txUsuario"
        Me.txUsuario.Size = New System.Drawing.Size(59, 20)
        Me.txUsuario.TabIndex = 105
        Me.txUsuario.Text = "1"
        Me.txUsuario.Visible = False
        '
        'txEmpresa
        '
        Me.txEmpresa.Location = New System.Drawing.Point(463, 122)
        Me.txEmpresa.Name = "txEmpresa"
        Me.txEmpresa.Size = New System.Drawing.Size(59, 20)
        Me.txEmpresa.TabIndex = 104
        Me.txEmpresa.Text = "1"
        Me.txEmpresa.Visible = False
        '
        'txIva
        '
        Me.txIva.Location = New System.Drawing.Point(388, 122)
        Me.txIva.Name = "txIva"
        Me.txIva.Size = New System.Drawing.Size(68, 20)
        Me.txIva.TabIndex = 76
        Me.txIva.Text = "21.00"
        Me.txIva.Visible = False
        '
        'txDtocli
        '
        Me.txDtocli.Location = New System.Drawing.Point(314, 122)
        Me.txDtocli.Name = "txDtocli"
        Me.txDtocli.Size = New System.Drawing.Size(68, 20)
        Me.txDtocli.TabIndex = 75
        Me.txDtocli.Visible = False
        '
        'txAgente
        '
        Me.txAgente.Location = New System.Drawing.Point(240, 122)
        Me.txAgente.Name = "txAgente"
        Me.txAgente.Size = New System.Drawing.Size(68, 20)
        Me.txAgente.TabIndex = 74
        Me.txAgente.Visible = False
        '
        'txTotalAlbaran
        '
        Me.txTotalAlbaran.Location = New System.Drawing.Point(1061, 507)
        Me.txTotalAlbaran.Name = "txTotalAlbaran"
        Me.txTotalAlbaran.ReadOnly = True
        Me.txTotalAlbaran.Size = New System.Drawing.Size(132, 20)
        Me.txTotalAlbaran.TabIndex = 73
        Me.txTotalAlbaran.Text = "0"
        Me.txTotalAlbaran.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(943, 514)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(112, 13)
        Me.Label12.TabIndex = 72
        Me.Label12.Text = "TOTAL FACTURA:"
        '
        'txImpRecargo
        '
        Me.txImpRecargo.Location = New System.Drawing.Point(923, 478)
        Me.txImpRecargo.Name = "txImpRecargo"
        Me.txImpRecargo.ReadOnly = True
        Me.txImpRecargo.Size = New System.Drawing.Size(132, 20)
        Me.txImpRecargo.TabIndex = 71
        Me.txImpRecargo.Text = "0"
        Me.txImpRecargo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(818, 485)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(76, 13)
        Me.Label11.TabIndex = 70
        Me.Label11.Text = "RECARGO E.:"
        '
        'txImpIva
        '
        Me.txImpIva.Location = New System.Drawing.Point(923, 451)
        Me.txImpIva.Name = "txImpIva"
        Me.txImpIva.ReadOnly = True
        Me.txImpIva.Size = New System.Drawing.Size(132, 20)
        Me.txImpIva.TabIndex = 69
        Me.txImpIva.Text = "0"
        Me.txImpIva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txImponible
        '
        Me.txImponible.Location = New System.Drawing.Point(923, 424)
        Me.txImponible.Name = "txImponible"
        Me.txImponible.ReadOnly = True
        Me.txImponible.Size = New System.Drawing.Size(132, 20)
        Me.txImponible.TabIndex = 68
        Me.txImponible.Text = "0"
        Me.txImponible.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txImpDto
        '
        Me.txImpDto.Location = New System.Drawing.Point(923, 396)
        Me.txImpDto.Name = "txImpDto"
        Me.txImpDto.ReadOnly = True
        Me.txImpDto.Size = New System.Drawing.Size(132, 20)
        Me.txImpDto.TabIndex = 67
        Me.txImpDto.Text = "0"
        Me.txImpDto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txImpBruto
        '
        Me.txImpBruto.Location = New System.Drawing.Point(923, 368)
        Me.txImpBruto.Name = "txImpBruto"
        Me.txImpBruto.ReadOnly = True
        Me.txImpBruto.Size = New System.Drawing.Size(132, 20)
        Me.txImpBruto.TabIndex = 66
        Me.txImpBruto.Text = "0"
        Me.txImpBruto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(818, 458)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(27, 13)
        Me.Label10.TabIndex = 65
        Me.Label10.Text = "IVA:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(818, 431)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(99, 13)
        Me.Label9.TabIndex = 64
        Me.Label9.Text = "BASE IMPONIBLE:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(817, 403)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 13)
        Me.Label8.TabIndex = 63
        Me.Label8.Text = "IMPORTE DTO:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(817, 375)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 13)
        Me.Label7.TabIndex = 62
        Me.Label7.Text = "IMPORTE BRUTO:"
        '
        'cbEnvio
        '
        Me.cbEnvio.FormattingEnabled = True
        Me.cbEnvio.Location = New System.Drawing.Point(790, 94)
        Me.cbEnvio.Name = "cbEnvio"
        Me.cbEnvio.Size = New System.Drawing.Size(403, 21)
        Me.cbEnvio.TabIndex = 2
        '
        'cmdCancelar
        '
        Me.cmdCancelar.AutoSize = False
        Me.cmdCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdCancelar.Image = CType(resources.GetObject("cmdCancelar.Image"), System.Drawing.Image)
        Me.cmdCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(33, 30)
        Me.cmdCancelar.Text = "ToolStripButton1"
        Me.cmdCancelar.ToolTipText = "Cancelar Factura"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(729, 102)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 58
        Me.Label5.Text = "ENVÍO:"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.GroupBox5)
        Me.Panel4.Controls.Add(Me.GroupBox4)
        Me.Panel4.Location = New System.Drawing.Point(6, 6)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(288, 527)
        Me.Panel4.TabIndex = 12
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.btBuscar)
        Me.GroupBox5.Controls.Add(Me.Label40)
        Me.GroupBox5.Controls.Add(Me.txGeneral)
        Me.GroupBox5.Controls.Add(Me.Label39)
        Me.GroupBox5.Controls.Add(Me.txNumero)
        Me.GroupBox5.Controls.Add(Me.Label38)
        Me.GroupBox5.Controls.Add(Me.txReferencia)
        Me.GroupBox5.Controls.Add(Me.txHasta)
        Me.GroupBox5.Controls.Add(Me.Label37)
        Me.GroupBox5.Controls.Add(Me.Label36)
        Me.GroupBox5.Controls.Add(Me.txCliente)
        Me.GroupBox5.Controls.Add(Me.txDesde)
        Me.GroupBox5.Controls.Add(Me.Label35)
        Me.GroupBox5.Location = New System.Drawing.Point(3, 137)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(280, 316)
        Me.GroupBox5.TabIndex = 3
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "BUSQUEDA"
        '
        'btBuscar
        '
        Me.btBuscar.BackColor = System.Drawing.Color.Transparent
        Me.btBuscar.FlatAppearance.BorderSize = 0
        Me.btBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btBuscar.Image = CType(resources.GetObject("btBuscar.Image"), System.Drawing.Image)
        Me.btBuscar.Location = New System.Drawing.Point(241, 280)
        Me.btBuscar.Name = "btBuscar"
        Me.btBuscar.Size = New System.Drawing.Size(33, 30)
        Me.btBuscar.TabIndex = 21
        Me.btBuscar.UseVisualStyleBackColor = False
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(7, 221)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(124, 13)
        Me.Label40.TabIndex = 20
        Me.Label40.Text = "BUSQUEDA GENERAL:"
        '
        'txGeneral
        '
        Me.txGeneral.Location = New System.Drawing.Point(10, 237)
        Me.txGeneral.Name = "txGeneral"
        Me.txGeneral.Size = New System.Drawing.Size(265, 20)
        Me.txGeneral.TabIndex = 19
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(7, 74)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(58, 13)
        Me.Label39.TabIndex = 18
        Me.Label39.Text = "NUMERO:"
        '
        'txNumero
        '
        Me.txNumero.Location = New System.Drawing.Point(10, 90)
        Me.txNumero.Name = "txNumero"
        Me.txNumero.Size = New System.Drawing.Size(265, 20)
        Me.txNumero.TabIndex = 17
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(7, 125)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(78, 13)
        Me.Label38.TabIndex = 16
        Me.Label38.Text = "REFERENCIA:"
        '
        'txReferencia
        '
        Me.txReferencia.Location = New System.Drawing.Point(10, 141)
        Me.txReferencia.Name = "txReferencia"
        Me.txReferencia.Size = New System.Drawing.Size(265, 20)
        Me.txReferencia.TabIndex = 15
        '
        'txHasta
        '
        Me.txHasta.BackColor = System.Drawing.Color.White
        Me.txHasta.Location = New System.Drawing.Point(185, 185)
        Me.txHasta.Mask = "00/00/00"
        Me.txHasta.Name = "txHasta"
        Me.txHasta.Size = New System.Drawing.Size(72, 20)
        Me.txHasta.TabIndex = 14
        Me.txHasta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txHasta.ValidatingType = GetType(Date)
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(133, 192)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(46, 13)
        Me.Label37.TabIndex = 13
        Me.Label37.Text = "HASTA:"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(6, 25)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(55, 13)
        Me.Label36.TabIndex = 12
        Me.Label36.Text = "CLIENTE:"
        '
        'txCliente
        '
        Me.txCliente.Location = New System.Drawing.Point(9, 41)
        Me.txCliente.Name = "txCliente"
        Me.txCliente.Size = New System.Drawing.Size(265, 20)
        Me.txCliente.TabIndex = 11
        '
        'txDesde
        '
        Me.txDesde.BackColor = System.Drawing.Color.White
        Me.txDesde.Location = New System.Drawing.Point(58, 185)
        Me.txDesde.Mask = "00/00/00"
        Me.txDesde.Name = "txDesde"
        Me.txDesde.Size = New System.Drawing.Size(72, 20)
        Me.txDesde.TabIndex = 10
        Me.txDesde.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txDesde.ValidatingType = GetType(Date)
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(7, 192)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(47, 13)
        Me.Label35.TabIndex = 9
        Me.Label35.Text = "DESDE:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.rbPendientes)
        Me.GroupBox4.Controls.Add(Me.rbTodos)
        Me.GroupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox4.Location = New System.Drawing.Point(3, 17)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(280, 104)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "ESTADO"
        '
        'rbPendientes
        '
        Me.rbPendientes.AutoSize = True
        Me.rbPendientes.Location = New System.Drawing.Point(6, 51)
        Me.rbPendientes.Name = "rbPendientes"
        Me.rbPendientes.Size = New System.Drawing.Size(70, 17)
        Me.rbPendientes.TabIndex = 1
        Me.rbPendientes.Text = "ABONOS"
        Me.rbPendientes.UseVisualStyleBackColor = True
        '
        'rbTodos
        '
        Me.rbTodos.AutoSize = True
        Me.rbTodos.Checked = True
        Me.rbTodos.Location = New System.Drawing.Point(6, 28)
        Me.rbTodos.Name = "rbTodos"
        Me.rbTodos.Size = New System.Drawing.Size(62, 17)
        Me.rbTodos.TabIndex = 0
        Me.rbTodos.TabStop = True
        Me.rbTodos.Text = "TODAS"
        Me.rbTodos.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.White
        Me.TabPage2.Controls.Add(Me.grPlazos)
        Me.TabPage2.Controls.Add(Me.ckPagado)
        Me.TabPage2.Controls.Add(Me.txDiapago)
        Me.TabPage2.Controls.Add(Me.cmdMostrarAgente)
        Me.TabPage2.Controls.Add(Me.txRecargo)
        Me.TabPage2.Controls.Add(Me.btRecalcular)
        Me.TabPage2.Controls.Add(Me.cbFormapago)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.cbSerie)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.txObserva)
        Me.TabPage2.Controls.Add(Me.txUsuario)
        Me.TabPage2.Controls.Add(Me.txEmpresa)
        Me.TabPage2.Controls.Add(Me.txIva)
        Me.TabPage2.Controls.Add(Me.txDtocli)
        Me.TabPage2.Controls.Add(Me.txAgente)
        Me.TabPage2.Controls.Add(Me.txTotalAlbaran)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.txImpRecargo)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.txImpIva)
        Me.TabPage2.Controls.Add(Me.txImponible)
        Me.TabPage2.Controls.Add(Me.txImpDto)
        Me.TabPage2.Controls.Add(Me.txImpBruto)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.cbEnvio)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.txNumcli)
        Me.TabPage2.Controls.Add(Me.tsBotones)
        Me.TabPage2.Controls.Add(Me.dgLineasPres1)
        Me.TabPage2.Controls.Add(Me.txFecha)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.txReferenciapres)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.txClientepres)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.txtNumpres)
        Me.TabPage2.Controls.Add(Me.dgLineasPres2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1213, 539)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "FACTURA"
        '
        'grPlazos
        '
        Me.grPlazos.BackColor = System.Drawing.Color.White
        Me.grPlazos.Controls.Add(Me.Button1)
        Me.grPlazos.Controls.Add(Me.dgPlazos)
        Me.grPlazos.Location = New System.Drawing.Point(648, 94)
        Me.grPlazos.Name = "grPlazos"
        Me.grPlazos.Size = New System.Drawing.Size(510, 164)
        Me.grPlazos.TabIndex = 115
        Me.grPlazos.TabStop = False
        Me.grPlazos.Text = "VENCIMIENTOS Y PLAZOS"
        Me.grPlazos.Visible = False
        '
        'dgPlazos
        '
        Me.dgPlazos.AllowUserToAddRows = False
        Me.dgPlazos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPlazos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.fecha, Me.concepto, Me.importe})
        Me.dgPlazos.Location = New System.Drawing.Point(10, 41)
        Me.dgPlazos.Name = "dgPlazos"
        Me.dgPlazos.Size = New System.Drawing.Size(493, 117)
        Me.dgPlazos.TabIndex = 121
        '
        'fecha
        '
        Me.fecha.HeaderText = "FECHA"
        Me.fecha.Name = "fecha"
        Me.fecha.Width = 75
        '
        'concepto
        '
        Me.concepto.HeaderText = "CONCEPTO"
        Me.concepto.Name = "concepto"
        Me.concepto.Width = 280
        '
        'importe
        '
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.importe.DefaultCellStyle = DataGridViewCellStyle16
        Me.importe.HeaderText = "IMPORTE"
        Me.importe.Name = "importe"
        Me.importe.Width = 70
        '
        'txDiapago
        '
        Me.txDiapago.Location = New System.Drawing.Point(658, 122)
        Me.txDiapago.Name = "txDiapago"
        Me.txDiapago.Size = New System.Drawing.Size(54, 20)
        Me.txDiapago.TabIndex = 114
        Me.txDiapago.Visible = False
        '
        'cmdMostrarAgente
        '
        Me.cmdMostrarAgente.BackColor = System.Drawing.Color.White
        Me.cmdMostrarAgente.FlatAppearance.BorderSize = 0
        Me.cmdMostrarAgente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdMostrarAgente.Image = CType(resources.GetObject("cmdMostrarAgente.Image"), System.Drawing.Image)
        Me.cmdMostrarAgente.Location = New System.Drawing.Point(1172, 59)
        Me.cmdMostrarAgente.Name = "cmdMostrarAgente"
        Me.cmdMostrarAgente.Size = New System.Drawing.Size(21, 19)
        Me.cmdMostrarAgente.TabIndex = 113
        Me.cmdMostrarAgente.UseVisualStyleBackColor = False
        '
        'txRecargo
        '
        Me.txRecargo.Location = New System.Drawing.Point(593, 122)
        Me.txRecargo.Name = "txRecargo"
        Me.txRecargo.Size = New System.Drawing.Size(59, 20)
        Me.txRecargo.TabIndex = 112
        Me.txRecargo.Text = "1"
        Me.txRecargo.Visible = False
        '
        'btRecalcular
        '
        Me.btRecalcular.Location = New System.Drawing.Point(1026, 58)
        Me.btRecalcular.Name = "btRecalcular"
        Me.btRecalcular.Size = New System.Drawing.Size(132, 23)
        Me.btRecalcular.TabIndex = 111
        Me.btRecalcular.Text = "RECALCULAR PLAZOS"
        Me.btRecalcular.UseVisualStyleBackColor = True
        '
        'cbFormapago
        '
        Me.cbFormapago.FormattingEnabled = True
        Me.cbFormapago.Location = New System.Drawing.Point(834, 59)
        Me.cbFormapago.Name = "cbFormapago"
        Me.cbFormapago.Size = New System.Drawing.Size(179, 21)
        Me.cbFormapago.TabIndex = 110
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(729, 66)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 13)
        Me.Label6.TabIndex = 109
        Me.Label6.Text = "FORMA DE PAGO:"
        '
        'txNumcli
        '
        Me.txNumcli.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txNumcli.Location = New System.Drawing.Point(102, 95)
        Me.txNumcli.Name = "txNumcli"
        Me.txNumcli.ReadOnly = True
        Me.txNumcli.Size = New System.Drawing.Size(114, 20)
        Me.txNumcli.TabIndex = 102
        '
        'tsBotones
        '
        Me.tsBotones.AutoSize = False
        Me.tsBotones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdNuevo, Me.cmdGuardar, Me.cmdCancelar, Me.cmdDelete, Me.ToolStripButton2, Me.cmdImprimir, Me.cmdPDF, Me.cmdMail, Me.ToolStripButton7, Me.cmdPedido, Me.cmdAlbaran, Me.ToolStripSeparator2, Me.cmdToldos, Me.ToolStripButton4, Me.cmdCliente, Me.ToolStripSeparator1, Me.cmdRentabilidad, Me.ToolStripSeparator3, Me.cmdLineas})
        Me.tsBotones.Location = New System.Drawing.Point(3, 3)
        Me.tsBotones.Name = "tsBotones"
        Me.tsBotones.Size = New System.Drawing.Size(1207, 38)
        Me.tsBotones.TabIndex = 55
        Me.tsBotones.Text = "ToolStrip1"
        '
        'cmdNuevo
        '
        Me.cmdNuevo.AutoSize = False
        Me.cmdNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdNuevo.Image = CType(resources.GetObject("cmdNuevo.Image"), System.Drawing.Image)
        Me.cmdNuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(33, 30)
        Me.cmdNuevo.Text = "ToolStripButton1"
        Me.cmdNuevo.ToolTipText = "Nueva Factura"
        '
        'cmdGuardar
        '
        Me.cmdGuardar.AutoSize = False
        Me.cmdGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdGuardar.Image = CType(resources.GetObject("cmdGuardar.Image"), System.Drawing.Image)
        Me.cmdGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(33, 30)
        Me.cmdGuardar.Text = "ToolStripButton1"
        Me.cmdGuardar.ToolTipText = "Guardar Factura"
        '
        'cmdDelete
        '
        Me.cmdDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdDelete.Image = CType(resources.GetObject("cmdDelete.Image"), System.Drawing.Image)
        Me.cmdDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(28, 35)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.AutoSize = False
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(33, 30)
        '
        'cmdImprimir
        '
        Me.cmdImprimir.AutoSize = False
        Me.cmdImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdImprimir.Image = CType(resources.GetObject("cmdImprimir.Image"), System.Drawing.Image)
        Me.cmdImprimir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(33, 30)
        Me.cmdImprimir.Text = "ToolStripButton1"
        Me.cmdImprimir.ToolTipText = "Imprimir"
        '
        'cmdPDF
        '
        Me.cmdPDF.AutoSize = False
        Me.cmdPDF.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdPDF.Image = CType(resources.GetObject("cmdPDF.Image"), System.Drawing.Image)
        Me.cmdPDF.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdPDF.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdPDF.Name = "cmdPDF"
        Me.cmdPDF.Size = New System.Drawing.Size(33, 30)
        Me.cmdPDF.Text = "ToolStripButton1"
        Me.cmdPDF.ToolTipText = "Convertir a PDF"
        '
        'cmdMail
        '
        Me.cmdMail.AutoSize = False
        Me.cmdMail.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdMail.Image = CType(resources.GetObject("cmdMail.Image"), System.Drawing.Image)
        Me.cmdMail.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdMail.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdMail.Name = "cmdMail"
        Me.cmdMail.Size = New System.Drawing.Size(33, 30)
        Me.cmdMail.Text = "ToolStripButton1"
        Me.cmdMail.ToolTipText = "Enviar por Email"
        '
        'ToolStripButton7
        '
        Me.ToolStripButton7.AutoSize = False
        Me.ToolStripButton7.Name = "ToolStripButton7"
        Me.ToolStripButton7.Size = New System.Drawing.Size(33, 30)
        '
        'cmdPedido
        '
        Me.cmdPedido.AutoSize = False
        Me.cmdPedido.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdPedido.Image = CType(resources.GetObject("cmdPedido.Image"), System.Drawing.Image)
        Me.cmdPedido.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdPedido.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdPedido.Name = "cmdPedido"
        Me.cmdPedido.Size = New System.Drawing.Size(33, 30)
        Me.cmdPedido.Text = "ToolStripButton1"
        Me.cmdPedido.ToolTipText = "Realizar Pedido"
        '
        'cmdAlbaran
        '
        Me.cmdAlbaran.AutoSize = False
        Me.cmdAlbaran.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdAlbaran.Image = CType(resources.GetObject("cmdAlbaran.Image"), System.Drawing.Image)
        Me.cmdAlbaran.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdAlbaran.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdAlbaran.Name = "cmdAlbaran"
        Me.cmdAlbaran.Size = New System.Drawing.Size(33, 30)
        Me.cmdAlbaran.Text = "ToolStripButton1"
        Me.cmdAlbaran.ToolTipText = "Convertir a Factura"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.AutoSize = False
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(33, 30)
        '
        'cmdToldos
        '
        Me.cmdToldos.AutoSize = False
        Me.cmdToldos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdToldos.Image = CType(resources.GetObject("cmdToldos.Image"), System.Drawing.Image)
        Me.cmdToldos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdToldos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdToldos.Name = "cmdToldos"
        Me.cmdToldos.Size = New System.Drawing.Size(33, 30)
        Me.cmdToldos.Text = "ToolStripButton1"
        Me.cmdToldos.ToolTipText = "Toldos"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.AutoSize = False
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(33, 30)
        '
        'cmdCliente
        '
        Me.cmdCliente.AutoSize = False
        Me.cmdCliente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdCliente.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdNuevoCliente, Me.cmdEditarCliente})
        Me.cmdCliente.Image = CType(resources.GetObject("cmdCliente.Image"), System.Drawing.Image)
        Me.cmdCliente.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdCliente.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdCliente.Name = "cmdCliente"
        Me.cmdCliente.Size = New System.Drawing.Size(40, 30)
        Me.cmdCliente.Text = "ToolStripButton1"
        Me.cmdCliente.ToolTipText = "Cargar Clientes"
        '
        'cmdNuevoCliente
        '
        Me.cmdNuevoCliente.Name = "cmdNuevoCliente"
        Me.cmdNuevoCliente.Size = New System.Drawing.Size(113, 22)
        Me.cmdNuevoCliente.Text = "NUEVO"
        '
        'cmdEditarCliente
        '
        Me.cmdEditarCliente.Name = "cmdEditarCliente"
        Me.cmdEditarCliente.Size = New System.Drawing.Size(113, 22)
        Me.cmdEditarCliente.Text = "EDITAR"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.AutoSize = False
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(33, 30)
        '
        'cmdRentabilidad
        '
        Me.cmdRentabilidad.AutoSize = False
        Me.cmdRentabilidad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdRentabilidad.Image = CType(resources.GetObject("cmdRentabilidad.Image"), System.Drawing.Image)
        Me.cmdRentabilidad.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdRentabilidad.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdRentabilidad.Name = "cmdRentabilidad"
        Me.cmdRentabilidad.Size = New System.Drawing.Size(33, 30)
        Me.cmdRentabilidad.Text = "ToolStripButton1"
        Me.cmdRentabilidad.ToolTipText = "Rentabilidad"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.AutoSize = False
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(33, 30)
        '
        'cmdLineas
        '
        Me.cmdLineas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdLineas.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.INSERTARToolStripMenuItem, Me.ELIMINARToolStripMenuItem})
        Me.cmdLineas.Image = CType(resources.GetObject("cmdLineas.Image"), System.Drawing.Image)
        Me.cmdLineas.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdLineas.Name = "cmdLineas"
        Me.cmdLineas.Size = New System.Drawing.Size(32, 35)
        Me.cmdLineas.Text = "ToolStripSplitButton1"
        Me.cmdLineas.ToolTipText = "Añadir Líneas"
        '
        'INSERTARToolStripMenuItem
        '
        Me.INSERTARToolStripMenuItem.Name = "INSERTARToolStripMenuItem"
        Me.INSERTARToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.INSERTARToolStripMenuItem.Text = "INSERTAR"
        '
        'ELIMINARToolStripMenuItem
        '
        Me.ELIMINARToolStripMenuItem.Name = "ELIMINARToolStripMenuItem"
        Me.ELIMINARToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.ELIMINARToolStripMenuItem.Text = "ELIMINAR"
        '
        'dgLineasPres1
        '
        Me.dgLineasPres1.AllowUserToAddRows = False
        Me.dgLineasPres1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgLineasPres1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.linea, Me.btArticulo, Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10})
        Me.dgLineasPres1.Location = New System.Drawing.Point(20, 156)
        Me.dgLineasPres1.Name = "dgLineasPres1"
        Me.dgLineasPres1.Size = New System.Drawing.Size(1173, 200)
        Me.dgLineasPres1.TabIndex = 10
        '
        'linea
        '
        Me.linea.HeaderText = "L"
        Me.linea.Name = "linea"
        Me.linea.ReadOnly = True
        Me.linea.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.linea.Width = 25
        '
        'btArticulo
        '
        Me.btArticulo.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btArticulo.HeaderText = "A"
        Me.btArticulo.Name = "btArticulo"
        Me.btArticulo.ReadOnly = True
        Me.btArticulo.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.btArticulo.Width = 25
        '
        'Column1
        '
        Me.Column1.HeaderText = "CODIGO"
        Me.Column1.Name = "Column1"
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column1.Width = 120
        '
        'Column2
        '
        Me.Column2.HeaderText = "DESCRIPCION"
        Me.Column2.Name = "Column2"
        Me.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column2.Width = 370
        '
        'Column3
        '
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle17.Format = "N2"
        DataGridViewCellStyle17.NullValue = "0"
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle17
        Me.Column3.HeaderText = "CANTIDAD"
        Me.Column3.Name = "Column3"
        Me.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column3.Width = 85
        '
        'Column4
        '
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle18.Format = "N2"
        DataGridViewCellStyle18.NullValue = "0"
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle18
        Me.Column4.HeaderText = "ANC/LAR"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column4.Width = 70
        '
        'Column5
        '
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle19.Format = "N2"
        DataGridViewCellStyle19.NullValue = "0"
        Me.Column5.DefaultCellStyle = DataGridViewCellStyle19
        Me.Column5.HeaderText = "M2/ML"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column5.Width = 75
        '
        'Column6
        '
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle20.Format = "N2"
        DataGridViewCellStyle20.NullValue = "0"
        Me.Column6.DefaultCellStyle = DataGridViewCellStyle20
        Me.Column6.HeaderText = "PRECIO"
        Me.Column6.Name = "Column6"
        Me.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column6.Width = 90
        '
        'Column7
        '
        DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle21.Format = "N2"
        DataGridViewCellStyle21.NullValue = "0"
        Me.Column7.DefaultCellStyle = DataGridViewCellStyle21
        Me.Column7.HeaderText = "DTO"
        Me.Column7.Name = "Column7"
        Me.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column7.Width = 70
        '
        'Column8
        '
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle22.Format = "N2"
        DataGridViewCellStyle22.NullValue = "0"
        Me.Column8.DefaultCellStyle = DataGridViewCellStyle22
        Me.Column8.HeaderText = "IMPORTE"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Column9
        '
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle23.Format = "N2"
        DataGridViewCellStyle23.NullValue = "0"
        Me.Column9.DefaultCellStyle = DataGridViewCellStyle23
        Me.Column9.HeaderText = "TOTAL"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Column10
        '
        Me.Column10.HeaderText = "LOTE"
        Me.Column10.Name = "Column10"
        Me.Column10.Visible = False
        Me.Column10.Width = 25
        '
        'txFecha
        '
        Me.txFecha.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txFecha.Location = New System.Drawing.Point(288, 59)
        Me.txFecha.Mask = "00/00/0000"
        Me.txFecha.Name = "txFecha"
        Me.txFecha.Size = New System.Drawing.Size(81, 20)
        Me.txFecha.TabIndex = 101
        Me.txFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txFecha.ValidatingType = GetType(Date)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(397, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "REFERENCIA:"
        '
        'txReferenciapres
        '
        Me.txReferenciapres.Location = New System.Drawing.Point(481, 59)
        Me.txReferenciapres.Name = "txReferenciapres"
        Me.txReferenciapres.Size = New System.Drawing.Size(231, 20)
        Me.txReferenciapres.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(41, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "CLIENTE:"
        '
        'txClientepres
        '
        Me.txClientepres.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txClientepres.Location = New System.Drawing.Point(240, 95)
        Me.txClientepres.Name = "txClientepres"
        Me.txClientepres.ReadOnly = True
        Me.txClientepres.Size = New System.Drawing.Size(472, 20)
        Me.txClientepres.TabIndex = 103
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(237, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "FECHA:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "NUMERO:"
        '
        'txtNumpres
        '
        Me.txtNumpres.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtNumpres.Location = New System.Drawing.Point(142, 59)
        Me.txtNumpres.Name = "txtNumpres"
        Me.txtNumpres.ReadOnly = True
        Me.txtNumpres.Size = New System.Drawing.Size(74, 20)
        Me.txtNumpres.TabIndex = 100
        '
        'dgLineasPres2
        '
        Me.dgLineasPres2.AllowUserToAddRows = False
        Me.dgLineasPres2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgLineasPres2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.linedit, Me.btArtiEdit, Me.Columna1, Me.Columna2, Me.Columna3, Me.Columna4, Me.Columna5, Me.Columna6, Me.Columna7, Me.Columna8, Me.Columna9, Me.Column11})
        Me.dgLineasPres2.Location = New System.Drawing.Point(20, 156)
        Me.dgLineasPres2.Name = "dgLineasPres2"
        Me.dgLineasPres2.Size = New System.Drawing.Size(1173, 199)
        Me.dgLineasPres2.TabIndex = 57
        Me.dgLineasPres2.Visible = False
        '
        'linedit
        '
        Me.linedit.HeaderText = "L"
        Me.linedit.Name = "linedit"
        Me.linedit.Width = 25
        '
        'btArtiEdit
        '
        Me.btArtiEdit.HeaderText = "A"
        Me.btArtiEdit.Name = "btArtiEdit"
        Me.btArtiEdit.Width = 25
        '
        'Columna1
        '
        Me.Columna1.HeaderText = "CODIGO"
        Me.Columna1.Name = "Columna1"
        Me.Columna1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Columna1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Columna1.Width = 120
        '
        'Columna2
        '
        Me.Columna2.HeaderText = "DESCRIPCION"
        Me.Columna2.Name = "Columna2"
        Me.Columna2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Columna2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Columna2.Width = 370
        '
        'Columna3
        '
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle24.Format = "N2"
        DataGridViewCellStyle24.NullValue = "0"
        Me.Columna3.DefaultCellStyle = DataGridViewCellStyle24
        Me.Columna3.HeaderText = "CANTIDAD"
        Me.Columna3.Name = "Columna3"
        Me.Columna3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Columna3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Columna3.Width = 85
        '
        'Columna4
        '
        DataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle25.Format = "N2"
        DataGridViewCellStyle25.NullValue = "0"
        Me.Columna4.DefaultCellStyle = DataGridViewCellStyle25
        Me.Columna4.HeaderText = "ANC/LAR"
        Me.Columna4.Name = "Columna4"
        Me.Columna4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Columna4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Columna4.Width = 70
        '
        'Columna5
        '
        DataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle26.Format = "N2"
        DataGridViewCellStyle26.NullValue = "0"
        Me.Columna5.DefaultCellStyle = DataGridViewCellStyle26
        Me.Columna5.HeaderText = "M2/ML"
        Me.Columna5.Name = "Columna5"
        Me.Columna5.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Columna5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Columna5.Width = 75
        '
        'Columna6
        '
        DataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle27.Format = "N2"
        DataGridViewCellStyle27.NullValue = "0"
        Me.Columna6.DefaultCellStyle = DataGridViewCellStyle27
        Me.Columna6.HeaderText = "PRECIO"
        Me.Columna6.Name = "Columna6"
        Me.Columna6.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Columna6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Columna6.Width = 90
        '
        'Columna7
        '
        DataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle28.Format = "N2"
        DataGridViewCellStyle28.NullValue = "0"
        Me.Columna7.DefaultCellStyle = DataGridViewCellStyle28
        Me.Columna7.HeaderText = "DTO"
        Me.Columna7.Name = "Columna7"
        Me.Columna7.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Columna7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Columna7.Width = 70
        '
        'Columna8
        '
        DataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle29.Format = "N2"
        DataGridViewCellStyle29.NullValue = "0"
        Me.Columna8.DefaultCellStyle = DataGridViewCellStyle29
        Me.Columna8.HeaderText = "IMPORTE"
        Me.Columna8.Name = "Columna8"
        Me.Columna8.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Columna8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Columna9
        '
        DataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle30.Format = "N2"
        DataGridViewCellStyle30.NullValue = "0"
        Me.Columna9.DefaultCellStyle = DataGridViewCellStyle30
        Me.Columna9.HeaderText = "TOTAL"
        Me.Columna9.Name = "Columna9"
        Me.Columna9.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Columna9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column11
        '
        Me.Column11.HeaderText = "LOTE"
        Me.Column11.Name = "Column11"
        Me.Column11.Visible = False
        Me.Column11.Width = 25
        '
        'dgFacturas
        '
        Me.dgFacturas.AllowUserToAddRows = False
        Me.dgFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgFacturas.Location = New System.Drawing.Point(300, 6)
        Me.dgFacturas.Name = "dgFacturas"
        Me.dgFacturas.Size = New System.Drawing.Size(897, 527)
        Me.dgFacturas.TabIndex = 11
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Panel4)
        Me.TabPage1.Controls.Add(Me.dgFacturas)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1213, 539)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "LISTADO FACTURAS"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'tabPresupuestos
        '
        Me.tabPresupuestos.Controls.Add(Me.TabPage1)
        Me.tabPresupuestos.Controls.Add(Me.TabPage2)
        Me.tabPresupuestos.Location = New System.Drawing.Point(12, 12)
        Me.tabPresupuestos.Name = "tabPresupuestos"
        Me.tabPresupuestos.SelectedIndex = 0
        Me.tabPresupuestos.Size = New System.Drawing.Size(1221, 565)
        Me.tabPresupuestos.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
        Me.tabPresupuestos.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(428, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 122
        Me.Button1.Text = "Cerrar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ckPagado
        '
        Me.ckPagado.AutoSize = True
        Me.ckPagado.Location = New System.Drawing.Point(790, 124)
        Me.ckPagado.Name = "ckPagado"
        Me.ckPagado.Size = New System.Drawing.Size(70, 17)
        Me.ckPagado.TabIndex = 116
        Me.ckPagado.Text = "PAGADA"
        Me.ckPagado.UseVisualStyleBackColor = True
        '
        'frFacturaManual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1245, 589)
        Me.Controls.Add(Me.tabPresupuestos)
        Me.Name = "frFacturaManual"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FACTURACION MANUAL"
        Me.Panel4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.grPlazos.ResumeLayout(False)
        CType(Me.dgPlazos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsBotones.ResumeLayout(False)
        Me.tsBotones.PerformLayout()
        CType(Me.dgLineasPres1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgLineasPres2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.tabPresupuestos.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cbSerie As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txObserva As TextBox
    Friend WithEvents txUsuario As TextBox
    Friend WithEvents txEmpresa As TextBox
    Friend WithEvents txIva As TextBox
    Friend WithEvents txDtocli As TextBox
    Friend WithEvents txAgente As TextBox
    Friend WithEvents txTotalAlbaran As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txImpRecargo As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txImpIva As TextBox
    Friend WithEvents txImponible As TextBox
    Friend WithEvents txImpDto As TextBox
    Friend WithEvents txImpBruto As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cbEnvio As ComboBox
    Friend WithEvents cmdCancelar As ToolStripButton
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents btBuscar As Button
    Friend WithEvents Label40 As Label
    Friend WithEvents txGeneral As TextBox
    Friend WithEvents Label39 As Label
    Friend WithEvents txNumero As TextBox
    Friend WithEvents Label38 As Label
    Friend WithEvents txReferencia As TextBox
    Friend WithEvents txHasta As MaskedTextBox
    Friend WithEvents Label37 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents txCliente As TextBox
    Friend WithEvents txDesde As MaskedTextBox
    Friend WithEvents Label35 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents rbPendientes As RadioButton
    Friend WithEvents rbTodos As RadioButton
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents txNumcli As TextBox
    Friend WithEvents tsBotones As ToolStrip
    Friend WithEvents cmdNuevo As ToolStripButton
    Friend WithEvents cmdGuardar As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripSeparator
    Friend WithEvents cmdImprimir As ToolStripButton
    Friend WithEvents cmdPDF As ToolStripButton
    Friend WithEvents cmdMail As ToolStripButton
    Friend WithEvents ToolStripButton7 As ToolStripSeparator
    Friend WithEvents cmdPedido As ToolStripButton
    Friend WithEvents cmdAlbaran As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents cmdToldos As ToolStripButton
    Friend WithEvents ToolStripButton4 As ToolStripSeparator
    Friend WithEvents cmdCliente As ToolStripSplitButton
    Friend WithEvents cmdNuevoCliente As ToolStripMenuItem
    Friend WithEvents cmdEditarCliente As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents cmdRentabilidad As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents cmdLineas As ToolStripSplitButton
    Friend WithEvents INSERTARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ELIMINARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents dgLineasPres1 As DataGridView
    Friend WithEvents txFecha As MaskedTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txReferenciapres As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txClientepres As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNumpres As TextBox
    Friend WithEvents dgLineasPres2 As DataGridView
    Friend WithEvents dgFacturas As DataGridView
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents tabPresupuestos As TabControl
    Friend WithEvents cmdDelete As ToolStripButton
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents btArticulo As DataGridViewButtonColumn
    Friend WithEvents linea As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Columna9 As DataGridViewTextBoxColumn
    Friend WithEvents Columna8 As DataGridViewTextBoxColumn
    Friend WithEvents Columna7 As DataGridViewTextBoxColumn
    Friend WithEvents Columna6 As DataGridViewTextBoxColumn
    Friend WithEvents Columna5 As DataGridViewTextBoxColumn
    Friend WithEvents Columna4 As DataGridViewTextBoxColumn
    Friend WithEvents Columna3 As DataGridViewTextBoxColumn
    Friend WithEvents Columna2 As DataGridViewTextBoxColumn
    Friend WithEvents Columna1 As DataGridViewTextBoxColumn
    Friend WithEvents btArtiEdit As DataGridViewButtonColumn
    Friend WithEvents linedit As DataGridViewTextBoxColumn
    Friend WithEvents btRecalcular As Button
    Friend WithEvents cbFormapago As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txRecargo As TextBox
    Friend WithEvents cmdMostrarAgente As Button
    Friend WithEvents txDiapago As TextBox
    Friend WithEvents grPlazos As GroupBox
    Friend WithEvents dgPlazos As DataGridView
    Friend WithEvents fecha As DataGridViewTextBoxColumn
    Friend WithEvents concepto As DataGridViewTextBoxColumn
    Friend WithEvents importe As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents ckPagado As CheckBox
End Class
