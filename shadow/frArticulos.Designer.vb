﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frArticulos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frArticulos))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dgArticulos = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.tsBotones = New System.Windows.Forms.ToolStrip()
        Me.cmdNuevo = New System.Windows.Forms.ToolStripButton()
        Me.cmdGuardar = New System.Windows.Forms.ToolStripButton()
        Me.cmdCancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdLotes = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdFlechas = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdLonas = New System.Windows.Forms.ToolStripButton()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.pnLotes = New System.Windows.Forms.Panel()
        Me.btGuardarLote = New System.Windows.Forms.Button()
        Me.btCloseLotes = New System.Windows.Forms.Button()
        Me.dgLotes = New System.Windows.Forms.DataGridView()
        Me.pnTejidos = New System.Windows.Forms.Panel()
        Me.grTejidos = New System.Windows.Forms.GroupBox()
        Me.dgTejidos = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.pnColores = New System.Windows.Forms.Panel()
        Me.grColor = New System.Windows.Forms.GroupBox()
        Me.btCloseCol = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.pnModelo = New System.Windows.Forms.Panel()
        Me.grModelo = New System.Windows.Forms.GroupBox()
        Me.dgMods = New System.Windows.Forms.DataGridView()
        Me.btCloseMod = New System.Windows.Forms.Button()
        Me.txTejidoID = New System.Windows.Forms.TextBox()
        Me.btTejidos = New System.Windows.Forms.Button()
        Me.btColor = New System.Windows.Forms.Button()
        Me.btModelo = New System.Windows.Forms.Button()
        Me.btProveedor = New System.Windows.Forms.Button()
        Me.cbFamilias = New System.Windows.Forms.ComboBox()
        Me.txMedida = New System.Windows.Forms.TextBox()
        Me.txColor = New System.Windows.Forms.TextBox()
        Me.txModeloID = New System.Windows.Forms.TextBox()
        Me.txNumPro = New System.Windows.Forms.TextBox()
        Me.txProveedor = New System.Windows.Forms.TextBox()
        Me.txColorID = New System.Windows.Forms.TextBox()
        Me.txUbicacion = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.cbTipoArti = New System.Windows.Forms.ComboBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.ckControlStock = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txModelo = New System.Windows.Forms.TextBox()
        Me.cbTejido = New System.Windows.Forms.ComboBox()
        Me.txTejido = New System.Windows.Forms.TextBox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txInicial = New System.Windows.Forms.TextBox()
        Me.txMinimo = New System.Windows.Forms.TextBox()
        Me.txStock = New System.Windows.Forms.TextBox()
        Me.txMargenEuro = New System.Windows.Forms.TextBox()
        Me.txDto = New System.Windows.Forms.TextBox()
        Me.txIva = New System.Windows.Forms.TextBox()
        Me.txGrupo = New System.Windows.Forms.TextBox()
        Me.txCompra = New System.Windows.Forms.TextBox()
        Me.txCodigo = New System.Windows.Forms.TextBox()
        Me.txDescripcion = New System.Windows.Forms.TextBox()
        Me.txPrecio = New System.Windows.Forms.TextBox()
        Me.txMargenPor = New System.Windows.Forms.TextBox()
        Me.txRefProv = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbUnidad = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbInfluye = New System.Windows.Forms.ComboBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.referencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lote = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ubicacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btNuevaLinea = New System.Windows.Forms.Button()
        Me.btEliminarLinea = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.tsBotones.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.pnLotes.SuspendLayout()
        CType(Me.dgLotes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnTejidos.SuspendLayout()
        Me.grTejidos.SuspendLayout()
        CType(Me.dgTejidos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnColores.SuspendLayout()
        Me.grColor.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnModelo.SuspendLayout()
        Me.grModelo.SuspendLayout()
        CType(Me.dgMods, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(936, 589)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dgArticulos)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(928, 563)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "ARTICULOS"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dgArticulos
        '
        Me.dgArticulos.AllowUserToAddRows = False
        Me.dgArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgArticulos.Location = New System.Drawing.Point(6, 18)
        Me.dgArticulos.Name = "dgArticulos"
        Me.dgArticulos.Size = New System.Drawing.Size(907, 527)
        Me.dgArticulos.TabIndex = 12
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.tsBotones)
        Me.TabPage2.Controls.Add(Me.TabControl2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(928, 563)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "DATOS ARTICULO"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'tsBotones
        '
        Me.tsBotones.AutoSize = False
        Me.tsBotones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdNuevo, Me.cmdGuardar, Me.cmdCancelar, Me.ToolStripSeparator1, Me.cmdLotes, Me.ToolStripSeparator2, Me.cmdFlechas, Me.ToolStripButton2, Me.cmdLonas})
        Me.tsBotones.Location = New System.Drawing.Point(3, 3)
        Me.tsBotones.Name = "tsBotones"
        Me.tsBotones.Size = New System.Drawing.Size(922, 38)
        Me.tsBotones.TabIndex = 56
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
        Me.cmdNuevo.ToolTipText = "Nuevo Artículo"
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
        Me.cmdGuardar.ToolTipText = "Guardar Artículo"
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
        Me.cmdCancelar.ToolTipText = "Cancelar Artículo"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.AutoSize = False
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(33, 30)
        '
        'cmdLotes
        '
        Me.cmdLotes.AutoSize = False
        Me.cmdLotes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdLotes.Image = CType(resources.GetObject("cmdLotes.Image"), System.Drawing.Image)
        Me.cmdLotes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdLotes.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdLotes.Name = "cmdLotes"
        Me.cmdLotes.Size = New System.Drawing.Size(33, 30)
        Me.cmdLotes.Text = "ToolStripButton1"
        Me.cmdLotes.ToolTipText = "Creación de lotes"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.AutoSize = False
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(33, 30)
        '
        'cmdFlechas
        '
        Me.cmdFlechas.AutoSize = False
        Me.cmdFlechas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdFlechas.Image = CType(resources.GetObject("cmdFlechas.Image"), System.Drawing.Image)
        Me.cmdFlechas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdFlechas.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdFlechas.Name = "cmdFlechas"
        Me.cmdFlechas.Size = New System.Drawing.Size(33, 30)
        Me.cmdFlechas.Text = "ToolStripButton1"
        Me.cmdFlechas.ToolTipText = "Imprimir"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.AutoSize = False
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(33, 30)
        '
        'cmdLonas
        '
        Me.cmdLonas.AutoSize = False
        Me.cmdLonas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdLonas.Image = CType(resources.GetObject("cmdLonas.Image"), System.Drawing.Image)
        Me.cmdLonas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdLonas.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdLonas.Name = "cmdLonas"
        Me.cmdLonas.Size = New System.Drawing.Size(33, 30)
        Me.cmdLonas.Text = "ToolStripButton1"
        Me.cmdLonas.ToolTipText = "Activar Lonas"
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage4)
        Me.TabControl2.Location = New System.Drawing.Point(21, 52)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(901, 505)
        Me.TabControl2.TabIndex = 0
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.pnLotes)
        Me.TabPage4.Controls.Add(Me.pnTejidos)
        Me.TabPage4.Controls.Add(Me.pnColores)
        Me.TabPage4.Controls.Add(Me.pnModelo)
        Me.TabPage4.Controls.Add(Me.txTejidoID)
        Me.TabPage4.Controls.Add(Me.btTejidos)
        Me.TabPage4.Controls.Add(Me.btColor)
        Me.TabPage4.Controls.Add(Me.btModelo)
        Me.TabPage4.Controls.Add(Me.btProveedor)
        Me.TabPage4.Controls.Add(Me.cbFamilias)
        Me.TabPage4.Controls.Add(Me.txMedida)
        Me.TabPage4.Controls.Add(Me.txColor)
        Me.TabPage4.Controls.Add(Me.txModeloID)
        Me.TabPage4.Controls.Add(Me.txNumPro)
        Me.TabPage4.Controls.Add(Me.txProveedor)
        Me.TabPage4.Controls.Add(Me.txColorID)
        Me.TabPage4.Controls.Add(Me.txUbicacion)
        Me.TabPage4.Controls.Add(Me.Label23)
        Me.TabPage4.Controls.Add(Me.cbTipoArti)
        Me.TabPage4.Controls.Add(Me.Label24)
        Me.TabPage4.Controls.Add(Me.ckControlStock)
        Me.TabPage4.Controls.Add(Me.GroupBox2)
        Me.TabPage4.Controls.Add(Me.Label16)
        Me.TabPage4.Controls.Add(Me.txInicial)
        Me.TabPage4.Controls.Add(Me.txMinimo)
        Me.TabPage4.Controls.Add(Me.txStock)
        Me.TabPage4.Controls.Add(Me.txMargenEuro)
        Me.TabPage4.Controls.Add(Me.txDto)
        Me.TabPage4.Controls.Add(Me.txIva)
        Me.TabPage4.Controls.Add(Me.txGrupo)
        Me.TabPage4.Controls.Add(Me.txCompra)
        Me.TabPage4.Controls.Add(Me.txCodigo)
        Me.TabPage4.Controls.Add(Me.txDescripcion)
        Me.TabPage4.Controls.Add(Me.txPrecio)
        Me.TabPage4.Controls.Add(Me.txMargenPor)
        Me.TabPage4.Controls.Add(Me.txRefProv)
        Me.TabPage4.Controls.Add(Me.Label15)
        Me.TabPage4.Controls.Add(Me.Label43)
        Me.TabPage4.Controls.Add(Me.Label14)
        Me.TabPage4.Controls.Add(Me.Label8)
        Me.TabPage4.Controls.Add(Me.cbUnidad)
        Me.TabPage4.Controls.Add(Me.Label7)
        Me.TabPage4.Controls.Add(Me.Label4)
        Me.TabPage4.Controls.Add(Me.Label6)
        Me.TabPage4.Controls.Add(Me.cbInfluye)
        Me.TabPage4.Controls.Add(Me.Label42)
        Me.TabPage4.Controls.Add(Me.Label39)
        Me.TabPage4.Controls.Add(Me.Label30)
        Me.TabPage4.Controls.Add(Me.Label29)
        Me.TabPage4.Controls.Add(Me.Label12)
        Me.TabPage4.Controls.Add(Me.Label11)
        Me.TabPage4.Controls.Add(Me.Label10)
        Me.TabPage4.Controls.Add(Me.Label9)
        Me.TabPage4.Controls.Add(Me.Label3)
        Me.TabPage4.Controls.Add(Me.Label2)
        Me.TabPage4.Controls.Add(Me.Label1)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(893, 479)
        Me.TabPage4.TabIndex = 0
        Me.TabPage4.Text = "GENERAL"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'pnLotes
        '
        Me.pnLotes.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnLotes.Controls.Add(Me.btEliminarLinea)
        Me.pnLotes.Controls.Add(Me.btNuevaLinea)
        Me.pnLotes.Controls.Add(Me.btGuardarLote)
        Me.pnLotes.Controls.Add(Me.btCloseLotes)
        Me.pnLotes.Controls.Add(Me.dgLotes)
        Me.pnLotes.Location = New System.Drawing.Point(42, 10)
        Me.pnLotes.Name = "pnLotes"
        Me.pnLotes.Size = New System.Drawing.Size(830, 320)
        Me.pnLotes.TabIndex = 147
        Me.pnLotes.Visible = False
        '
        'btGuardarLote
        '
        Me.btGuardarLote.BackgroundImage = CType(resources.GetObject("btGuardarLote.BackgroundImage"), System.Drawing.Image)
        Me.btGuardarLote.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btGuardarLote.Location = New System.Drawing.Point(10, 14)
        Me.btGuardarLote.Name = "btGuardarLote"
        Me.btGuardarLote.Size = New System.Drawing.Size(26, 23)
        Me.btGuardarLote.TabIndex = 124
        Me.btGuardarLote.UseVisualStyleBackColor = True
        '
        'btCloseLotes
        '
        Me.btCloseLotes.BackgroundImage = CType(resources.GetObject("btCloseLotes.BackgroundImage"), System.Drawing.Image)
        Me.btCloseLotes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btCloseLotes.Location = New System.Drawing.Point(795, 14)
        Me.btCloseLotes.Name = "btCloseLotes"
        Me.btCloseLotes.Size = New System.Drawing.Size(24, 23)
        Me.btCloseLotes.TabIndex = 123
        Me.btCloseLotes.UseVisualStyleBackColor = True
        '
        'dgLotes
        '
        Me.dgLotes.AllowUserToAddRows = False
        Me.dgLotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgLotes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.referencia, Me.descripcion, Me.lote, Me.stock, Me.ubicacion})
        Me.dgLotes.Location = New System.Drawing.Point(10, 59)
        Me.dgLotes.Name = "dgLotes"
        Me.dgLotes.Size = New System.Drawing.Size(809, 251)
        Me.dgLotes.TabIndex = 0
        '
        'pnTejidos
        '
        Me.pnTejidos.Controls.Add(Me.grTejidos)
        Me.pnTejidos.Location = New System.Drawing.Point(198, 195)
        Me.pnTejidos.Name = "pnTejidos"
        Me.pnTejidos.Size = New System.Drawing.Size(401, 186)
        Me.pnTejidos.TabIndex = 146
        Me.pnTejidos.Visible = False
        '
        'grTejidos
        '
        Me.grTejidos.BackColor = System.Drawing.Color.White
        Me.grTejidos.Controls.Add(Me.dgTejidos)
        Me.grTejidos.Controls.Add(Me.Button1)
        Me.grTejidos.Location = New System.Drawing.Point(17, 11)
        Me.grTejidos.Name = "grTejidos"
        Me.grTejidos.Size = New System.Drawing.Size(369, 164)
        Me.grTejidos.TabIndex = 141
        Me.grTejidos.TabStop = False
        Me.grTejidos.Text = "TEJIDOS"
        '
        'dgTejidos
        '
        Me.dgTejidos.AllowUserToAddRows = False
        Me.dgTejidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgTejidos.Location = New System.Drawing.Point(6, 42)
        Me.dgTejidos.Name = "dgTejidos"
        Me.dgTejidos.Size = New System.Drawing.Size(354, 112)
        Me.dgTejidos.TabIndex = 123
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(336, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(24, 23)
        Me.Button1.TabIndex = 122
        Me.Button1.UseVisualStyleBackColor = True
        '
        'pnColores
        '
        Me.pnColores.Controls.Add(Me.grColor)
        Me.pnColores.Location = New System.Drawing.Point(150, 283)
        Me.pnColores.Name = "pnColores"
        Me.pnColores.Size = New System.Drawing.Size(401, 175)
        Me.pnColores.TabIndex = 145
        Me.pnColores.Visible = False
        '
        'grColor
        '
        Me.grColor.BackColor = System.Drawing.Color.White
        Me.grColor.Controls.Add(Me.btCloseCol)
        Me.grColor.Controls.Add(Me.DataGridView1)
        Me.grColor.Location = New System.Drawing.Point(17, 5)
        Me.grColor.Name = "grColor"
        Me.grColor.Size = New System.Drawing.Size(369, 164)
        Me.grColor.TabIndex = 141
        Me.grColor.TabStop = False
        Me.grColor.Text = "COLOR"
        '
        'btCloseCol
        '
        Me.btCloseCol.BackgroundImage = CType(resources.GetObject("btCloseCol.BackgroundImage"), System.Drawing.Image)
        Me.btCloseCol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btCloseCol.Location = New System.Drawing.Point(336, 12)
        Me.btCloseCol.Name = "btCloseCol"
        Me.btCloseCol.Size = New System.Drawing.Size(23, 23)
        Me.btCloseCol.TabIndex = 122
        Me.btCloseCol.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(10, 41)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(350, 117)
        Me.DataGridView1.TabIndex = 121
        '
        'pnModelo
        '
        Me.pnModelo.Controls.Add(Me.grModelo)
        Me.pnModelo.Location = New System.Drawing.Point(475, 11)
        Me.pnModelo.Name = "pnModelo"
        Me.pnModelo.Size = New System.Drawing.Size(401, 187)
        Me.pnModelo.TabIndex = 144
        Me.pnModelo.Visible = False
        '
        'grModelo
        '
        Me.grModelo.BackColor = System.Drawing.Color.White
        Me.grModelo.Controls.Add(Me.dgMods)
        Me.grModelo.Controls.Add(Me.btCloseMod)
        Me.grModelo.Location = New System.Drawing.Point(17, 8)
        Me.grModelo.Name = "grModelo"
        Me.grModelo.Size = New System.Drawing.Size(369, 164)
        Me.grModelo.TabIndex = 140
        Me.grModelo.TabStop = False
        Me.grModelo.Text = "MODELO"
        '
        'dgMods
        '
        Me.dgMods.AllowUserToAddRows = False
        Me.dgMods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgMods.Location = New System.Drawing.Point(6, 42)
        Me.dgMods.Name = "dgMods"
        Me.dgMods.Size = New System.Drawing.Size(354, 112)
        Me.dgMods.TabIndex = 123
        '
        'btCloseMod
        '
        Me.btCloseMod.BackgroundImage = CType(resources.GetObject("btCloseMod.BackgroundImage"), System.Drawing.Image)
        Me.btCloseMod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btCloseMod.Location = New System.Drawing.Point(336, 12)
        Me.btCloseMod.Name = "btCloseMod"
        Me.btCloseMod.Size = New System.Drawing.Size(24, 23)
        Me.btCloseMod.TabIndex = 122
        Me.btCloseMod.UseVisualStyleBackColor = True
        '
        'txTejidoID
        '
        Me.txTejidoID.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txTejidoID.Location = New System.Drawing.Point(642, 154)
        Me.txTejidoID.Name = "txTejidoID"
        Me.txTejidoID.Size = New System.Drawing.Size(72, 20)
        Me.txTejidoID.TabIndex = 143
        '
        'btTejidos
        '
        Me.btTejidos.BackColor = System.Drawing.Color.Gainsboro
        Me.btTejidos.BackgroundImage = CType(resources.GetObject("btTejidos.BackgroundImage"), System.Drawing.Image)
        Me.btTejidos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btTejidos.Location = New System.Drawing.Point(606, 151)
        Me.btTejidos.Name = "btTejidos"
        Me.btTejidos.Size = New System.Drawing.Size(26, 23)
        Me.btTejidos.TabIndex = 142
        Me.btTejidos.UseVisualStyleBackColor = False
        '
        'btColor
        '
        Me.btColor.BackColor = System.Drawing.Color.Gainsboro
        Me.btColor.BackgroundImage = CType(resources.GetObject("btColor.BackgroundImage"), System.Drawing.Image)
        Me.btColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btColor.Location = New System.Drawing.Point(292, 255)
        Me.btColor.Name = "btColor"
        Me.btColor.Size = New System.Drawing.Size(26, 23)
        Me.btColor.TabIndex = 139
        Me.btColor.UseVisualStyleBackColor = False
        '
        'btModelo
        '
        Me.btModelo.BackColor = System.Drawing.Color.Gainsboro
        Me.btModelo.BackgroundImage = CType(resources.GetObject("btModelo.BackgroundImage"), System.Drawing.Image)
        Me.btModelo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btModelo.Location = New System.Drawing.Point(606, 123)
        Me.btModelo.Name = "btModelo"
        Me.btModelo.Size = New System.Drawing.Size(26, 23)
        Me.btModelo.TabIndex = 138
        Me.btModelo.UseVisualStyleBackColor = False
        '
        'btProveedor
        '
        Me.btProveedor.BackColor = System.Drawing.Color.Gainsboro
        Me.btProveedor.BackgroundImage = CType(resources.GetObject("btProveedor.BackgroundImage"), System.Drawing.Image)
        Me.btProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btProveedor.Location = New System.Drawing.Point(606, 42)
        Me.btProveedor.Name = "btProveedor"
        Me.btProveedor.Size = New System.Drawing.Size(26, 23)
        Me.btProveedor.TabIndex = 137
        Me.btProveedor.UseVisualStyleBackColor = False
        '
        'cbFamilias
        '
        Me.cbFamilias.FormattingEnabled = True
        Me.cbFamilias.Location = New System.Drawing.Point(150, 226)
        Me.cbFamilias.Name = "cbFamilias"
        Me.cbFamilias.Size = New System.Drawing.Size(368, 21)
        Me.cbFamilias.TabIndex = 136
        '
        'txMedida
        '
        Me.txMedida.Location = New System.Drawing.Point(150, 283)
        Me.txMedida.Name = "txMedida"
        Me.txMedida.Size = New System.Drawing.Size(82, 20)
        Me.txMedida.TabIndex = 135
        '
        'txColor
        '
        Me.txColor.Location = New System.Drawing.Point(150, 255)
        Me.txColor.Name = "txColor"
        Me.txColor.Size = New System.Drawing.Size(132, 20)
        Me.txColor.TabIndex = 134
        '
        'txModeloID
        '
        Me.txModeloID.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txModeloID.Location = New System.Drawing.Point(642, 125)
        Me.txModeloID.Name = "txModeloID"
        Me.txModeloID.Size = New System.Drawing.Size(72, 20)
        Me.txModeloID.TabIndex = 131
        Me.txModeloID.Visible = False
        '
        'txNumPro
        '
        Me.txNumPro.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txNumPro.Location = New System.Drawing.Point(657, 44)
        Me.txNumPro.Name = "txNumPro"
        Me.txNumPro.Size = New System.Drawing.Size(100, 20)
        Me.txNumPro.TabIndex = 130
        Me.txNumPro.Visible = False
        '
        'txProveedor
        '
        Me.txProveedor.Location = New System.Drawing.Point(150, 45)
        Me.txProveedor.Name = "txProveedor"
        Me.txProveedor.Size = New System.Drawing.Size(449, 20)
        Me.txProveedor.TabIndex = 129
        '
        'txColorID
        '
        Me.txColorID.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txColorID.Location = New System.Drawing.Point(342, 257)
        Me.txColorID.Name = "txColorID"
        Me.txColorID.Size = New System.Drawing.Size(83, 20)
        Me.txColorID.TabIndex = 128
        Me.txColorID.Visible = False
        '
        'txUbicacion
        '
        Me.txUbicacion.Location = New System.Drawing.Point(683, 248)
        Me.txUbicacion.Name = "txUbicacion"
        Me.txUbicacion.Size = New System.Drawing.Size(172, 20)
        Me.txUbicacion.TabIndex = 126
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(609, 255)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(68, 13)
        Me.Label23.TabIndex = 127
        Me.Label23.Text = "UBICACION:"
        '
        'cbTipoArti
        '
        Me.cbTipoArti.FormattingEnabled = True
        Me.cbTipoArti.Location = New System.Drawing.Point(150, 343)
        Me.cbTipoArti.Name = "cbTipoArti"
        Me.cbTipoArti.Size = New System.Drawing.Size(171, 21)
        Me.cbTipoArti.TabIndex = 125
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(41, 351)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(103, 13)
        Me.Label24.TabIndex = 124
        Me.Label24.Text = "TIPO ART. TOLDO:"
        '
        'ckControlStock
        '
        Me.ckControlStock.AutoSize = True
        Me.ckControlStock.Location = New System.Drawing.Point(684, 285)
        Me.ckControlStock.Name = "ckControlStock"
        Me.ckControlStock.Size = New System.Drawing.Size(188, 17)
        Me.ckControlStock.TabIndex = 122
        Me.ckControlStock.Text = "DESACTIVAR CONTROL STOCK"
        Me.ckControlStock.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txModelo)
        Me.GroupBox2.Controls.Add(Me.cbTejido)
        Me.GroupBox2.Controls.Add(Me.txTejido)
        Me.GroupBox2.Controls.Add(Me.Label44)
        Me.GroupBox2.Controls.Add(Me.Label45)
        Me.GroupBox2.Controls.Add(Me.Label46)
        Me.GroupBox2.Location = New System.Drawing.Point(150, 71)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(449, 118)
        Me.GroupBox2.TabIndex = 121
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "LONAS"
        '
        'txModelo
        '
        Me.txModelo.Location = New System.Drawing.Point(81, 54)
        Me.txModelo.Name = "txModelo"
        Me.txModelo.Size = New System.Drawing.Size(352, 20)
        Me.txModelo.TabIndex = 98
        '
        'cbTejido
        '
        Me.cbTejido.FormattingEnabled = True
        Me.cbTejido.Items.AddRange(New Object() {"ACRILICO", "MICROPERFORADO", "PVC"})
        Me.cbTejido.Location = New System.Drawing.Point(81, 27)
        Me.cbTejido.Name = "cbTejido"
        Me.cbTejido.Size = New System.Drawing.Size(352, 21)
        Me.cbTejido.TabIndex = 97
        '
        'txTejido
        '
        Me.txTejido.Location = New System.Drawing.Point(81, 83)
        Me.txTejido.Name = "txTejido"
        Me.txTejido.Size = New System.Drawing.Size(194, 20)
        Me.txTejido.TabIndex = 95
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(27, 88)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(48, 13)
        Me.Label44.TabIndex = 94
        Me.Label44.Text = "TEJIDO:"
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(6, 33)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(76, 13)
        Me.Label45.TabIndex = 93
        Me.Label45.Text = "TIPO TEJIDO:"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Location = New System.Drawing.Point(22, 60)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(56, 13)
        Me.Label46.TabIndex = 92
        Me.Label46.Text = "MODELO:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(591, 395)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(86, 13)
        Me.Label16.TabIndex = 120
        Me.Label16.Text = "STOCK INICIAL:"
        '
        'txInicial
        '
        Me.txInicial.Location = New System.Drawing.Point(684, 388)
        Me.txInicial.Name = "txInicial"
        Me.txInicial.Size = New System.Drawing.Size(73, 20)
        Me.txInicial.TabIndex = 119
        Me.txInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txMinimo
        '
        Me.txMinimo.Location = New System.Drawing.Point(684, 362)
        Me.txMinimo.Name = "txMinimo"
        Me.txMinimo.Size = New System.Drawing.Size(73, 20)
        Me.txMinimo.TabIndex = 115
        Me.txMinimo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txStock
        '
        Me.txStock.Location = New System.Drawing.Point(684, 336)
        Me.txStock.Name = "txStock"
        Me.txStock.Size = New System.Drawing.Size(73, 20)
        Me.txStock.TabIndex = 105
        Me.txStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txMargenEuro
        '
        Me.txMargenEuro.Location = New System.Drawing.Point(298, 425)
        Me.txMargenEuro.Name = "txMargenEuro"
        Me.txMargenEuro.Size = New System.Drawing.Size(73, 20)
        Me.txMargenEuro.TabIndex = 103
        Me.txMargenEuro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txDto
        '
        Me.txDto.Location = New System.Drawing.Point(413, 399)
        Me.txDto.Name = "txDto"
        Me.txDto.Size = New System.Drawing.Size(104, 20)
        Me.txDto.TabIndex = 101
        '
        'txIva
        '
        Me.txIva.Location = New System.Drawing.Point(150, 370)
        Me.txIva.Name = "txIva"
        Me.txIva.Size = New System.Drawing.Size(43, 20)
        Me.txIva.TabIndex = 98
        Me.txIva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txGrupo
        '
        Me.txGrupo.Location = New System.Drawing.Point(629, 18)
        Me.txGrupo.Name = "txGrupo"
        Me.txGrupo.Size = New System.Drawing.Size(85, 20)
        Me.txGrupo.TabIndex = 85
        '
        'txCompra
        '
        Me.txCompra.Location = New System.Drawing.Point(150, 399)
        Me.txCompra.Name = "txCompra"
        Me.txCompra.Size = New System.Drawing.Size(104, 20)
        Me.txCompra.TabIndex = 7
        Me.txCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txCodigo
        '
        Me.txCodigo.BackColor = System.Drawing.Color.White
        Me.txCodigo.Location = New System.Drawing.Point(400, 18)
        Me.txCodigo.Name = "txCodigo"
        Me.txCodigo.Size = New System.Drawing.Size(144, 20)
        Me.txCodigo.TabIndex = 65
        '
        'txDescripcion
        '
        Me.txDescripcion.Location = New System.Drawing.Point(150, 200)
        Me.txDescripcion.Name = "txDescripcion"
        Me.txDescripcion.Size = New System.Drawing.Size(449, 20)
        Me.txDescripcion.TabIndex = 1
        '
        'txPrecio
        '
        Me.txPrecio.Location = New System.Drawing.Point(425, 425)
        Me.txPrecio.Name = "txPrecio"
        Me.txPrecio.Size = New System.Drawing.Size(93, 20)
        Me.txPrecio.TabIndex = 16
        Me.txPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txMargenPor
        '
        Me.txMargenPor.Location = New System.Drawing.Point(150, 425)
        Me.txMargenPor.Name = "txMargenPor"
        Me.txMargenPor.Size = New System.Drawing.Size(73, 20)
        Me.txMargenPor.TabIndex = 15
        Me.txMargenPor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txRefProv
        '
        Me.txRefProv.Location = New System.Drawing.Point(150, 18)
        Me.txRefProv.Name = "txRefProv"
        Me.txRefProv.Size = New System.Drawing.Size(144, 20)
        Me.txRefProv.TabIndex = 0
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(588, 369)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(89, 13)
        Me.Label15.TabIndex = 116
        Me.Label15.Text = "STOCK MINIMO:"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(631, 343)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(46, 13)
        Me.Label43.TabIndex = 108
        Me.Label43.Text = "STOCK:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(229, 432)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(66, 13)
        Me.Label14.TabIndex = 104
        Me.Label14.Text = "MARGEN €:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(259, 406)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(148, 13)
        Me.Label8.TabIndex = 102
        Me.Label8.Text = "DESCUENTO PROVEEDOR:"
        '
        'cbUnidad
        '
        Me.cbUnidad.FormattingEnabled = True
        Me.cbUnidad.Location = New System.Drawing.Point(319, 283)
        Me.cbUnidad.Name = "cbUnidad"
        Me.cbUnidad.Size = New System.Drawing.Size(73, 21)
        Me.cbUnidad.TabIndex = 100
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(236, 291)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 13)
        Me.Label7.TabIndex = 99
        Me.Label7.Text = "UND. MEDIDA:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(106, 377)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 97
        Me.Label4.Text = "% IVA:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(66, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 13)
        Me.Label6.TabIndex = 96
        Me.Label6.Text = "PROVEEDOR:"
        '
        'cbInfluye
        '
        Me.cbInfluye.FormattingEnabled = True
        Me.cbInfluye.Location = New System.Drawing.Point(150, 316)
        Me.cbInfluye.Name = "cbInfluye"
        Me.cbInfluye.Size = New System.Drawing.Size(171, 21)
        Me.cbInfluye.TabIndex = 94
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(93, 235)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(51, 13)
        Me.Label42.TabIndex = 93
        Me.Label42.Text = "FAMILIA:"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(560, 25)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(63, 13)
        Me.Label39.TabIndex = 84
        Me.Label39.Text = "ID GRUPO:"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(75, 406)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(69, 13)
        Me.Label30.TabIndex = 72
        Me.Label30.Text = "P. COMPRA:"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(97, 262)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(47, 13)
        Me.Label29.TabIndex = 70
        Me.Label29.Text = "COLOR:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(316, 25)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(78, 13)
        Me.Label12.TabIndex = 66
        Me.Label12.Text = "REFERENCIA:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(39, 25)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(105, 13)
        Me.Label11.TabIndex = 64
        Me.Label11.Text = "REF. PROVEEDOR:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(384, 432)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(31, 13)
        Me.Label10.TabIndex = 63
        Me.Label10.Text = "PVP:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(76, 432)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 13)
        Me.Label9.TabIndex = 62
        Me.Label9.Text = "MARGEN %:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(49, 323)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 13)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "INFLUYE TOLDO:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(92, 289)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "MEDIDA:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(61, 207)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "DESCRIPCION:"
        '
        'referencia
        '
        Me.referencia.HeaderText = "REFERENCIA"
        Me.referencia.Name = "referencia"
        Me.referencia.ReadOnly = True
        Me.referencia.Width = 110
        '
        'descripcion
        '
        Me.descripcion.HeaderText = "DESCRIPCION"
        Me.descripcion.Name = "descripcion"
        Me.descripcion.Width = 330
        '
        'lote
        '
        Me.lote.HeaderText = "LOTE"
        Me.lote.Name = "lote"
        '
        'stock
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.stock.DefaultCellStyle = DataGridViewCellStyle2
        Me.stock.HeaderText = "STOCK"
        Me.stock.Name = "stock"
        Me.stock.Width = 75
        '
        'ubicacion
        '
        Me.ubicacion.HeaderText = "UBICACION"
        Me.ubicacion.Name = "ubicacion"
        Me.ubicacion.Width = 150
        '
        'btNuevaLinea
        '
        Me.btNuevaLinea.BackgroundImage = CType(resources.GetObject("btNuevaLinea.BackgroundImage"), System.Drawing.Image)
        Me.btNuevaLinea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btNuevaLinea.Location = New System.Drawing.Point(53, 15)
        Me.btNuevaLinea.Name = "btNuevaLinea"
        Me.btNuevaLinea.Size = New System.Drawing.Size(24, 23)
        Me.btNuevaLinea.TabIndex = 125
        Me.btNuevaLinea.UseVisualStyleBackColor = True
        '
        'btEliminarLinea
        '
        Me.btEliminarLinea.BackgroundImage = CType(resources.GetObject("btEliminarLinea.BackgroundImage"), System.Drawing.Image)
        Me.btEliminarLinea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btEliminarLinea.Location = New System.Drawing.Point(83, 15)
        Me.btEliminarLinea.Name = "btEliminarLinea"
        Me.btEliminarLinea.Size = New System.Drawing.Size(24, 23)
        Me.btEliminarLinea.TabIndex = 126
        Me.btEliminarLinea.UseVisualStyleBackColor = True
        '
        'frArticulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1012, 606)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frArticulos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ARTICULOS"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.tsBotones.ResumeLayout(False)
        Me.tsBotones.PerformLayout()
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.pnLotes.ResumeLayout(False)
        CType(Me.dgLotes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnTejidos.ResumeLayout(False)
        Me.grTejidos.ResumeLayout(False)
        CType(Me.dgTejidos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnColores.ResumeLayout(False)
        Me.grColor.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnModelo.ResumeLayout(False)
        Me.grModelo.ResumeLayout(False)
        CType(Me.dgMods, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents dgArticulos As DataGridView
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents tsBotones As ToolStrip
    Friend WithEvents cmdNuevo As ToolStripButton
    Friend WithEvents cmdGuardar As ToolStripButton
    Friend WithEvents cmdCancelar As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripSeparator
    Friend WithEvents cmdLonas As ToolStripButton
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cbTejido As ComboBox
    Friend WithEvents txTejido As TextBox
    Friend WithEvents Label44 As Label
    Friend WithEvents Label45 As Label
    Friend WithEvents Label46 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents txInicial As TextBox
    Friend WithEvents txMinimo As TextBox
    Friend WithEvents txStock As TextBox
    Friend WithEvents txMargenEuro As TextBox
    Friend WithEvents txDto As TextBox
    Friend WithEvents txIva As TextBox
    Friend WithEvents txGrupo As TextBox
    Friend WithEvents txCompra As TextBox
    Friend WithEvents txCodigo As TextBox
    Friend WithEvents txDescripcion As TextBox
    Friend WithEvents txPrecio As TextBox
    Friend WithEvents txMargenPor As TextBox
    Friend WithEvents txRefProv As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label43 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cbUnidad As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cbInfluye As ComboBox
    Friend WithEvents Label42 As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ckControlStock As CheckBox
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents cmdLotes As ToolStripButton
    Friend WithEvents cbTipoArti As ComboBox
    Friend WithEvents Label24 As Label
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents cmdFlechas As ToolStripButton
    Friend WithEvents Label23 As Label
    Friend WithEvents txUbicacion As TextBox
    Friend WithEvents txColorID As TextBox
    Friend WithEvents txNumPro As TextBox
    Friend WithEvents txProveedor As TextBox
    Friend WithEvents txModeloID As TextBox
    Friend WithEvents txModelo As TextBox
    Friend WithEvents txColor As TextBox
    Friend WithEvents txMedida As TextBox
    Friend WithEvents cbFamilias As ComboBox
    Friend WithEvents btColor As Button
    Friend WithEvents btModelo As Button
    Friend WithEvents btProveedor As Button
    Friend WithEvents grModelo As GroupBox
    Friend WithEvents btCloseMod As Button
    Friend WithEvents grColor As GroupBox
    Friend WithEvents btCloseCol As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents dgMods As DataGridView
    Friend WithEvents txTejidoID As TextBox
    Friend WithEvents btTejidos As Button
    Friend WithEvents grTejidos As GroupBox
    Friend WithEvents dgTejidos As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents pnTejidos As Panel
    Friend WithEvents pnColores As Panel
    Friend WithEvents pnModelo As Panel
    Friend WithEvents pnLotes As Panel
    Friend WithEvents dgLotes As DataGridView
    Friend WithEvents btCloseLotes As Button
    Friend WithEvents btGuardarLote As Button
    Friend WithEvents referencia As DataGridViewTextBoxColumn
    Friend WithEvents descripcion As DataGridViewTextBoxColumn
    Friend WithEvents lote As DataGridViewTextBoxColumn
    Friend WithEvents stock As DataGridViewTextBoxColumn
    Friend WithEvents ubicacion As DataGridViewTextBoxColumn
    Friend WithEvents btEliminarLinea As Button
    Friend WithEvents btNuevaLinea As Button
End Class
