<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBlocDeNotas
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbrirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarComoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EdiciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeshacerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.CortarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopiarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PegarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.BuscarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormatoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NegritaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CursivaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubrayadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.TamannoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.size12 = New System.Windows.Forms.ToolStripMenuItem()
        Me.size14 = New System.Windows.Forms.ToolStripMenuItem()
        Me.size18 = New System.Windows.Forms.ToolStripMenuItem()
        Me.size24 = New System.Windows.Forms.ToolStripMenuItem()
        Me.size36 = New System.Windows.Forms.ToolStripMenuItem()
        Me.size48 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.FuenteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RichTbNotas = New System.Windows.Forms.RichTextBox()
        Me.OFDAbrir = New System.Windows.Forms.OpenFileDialog()
        Me.SFDGuardar = New System.Windows.Forms.SaveFileDialog()
        Me.FDElegirFuente = New System.Windows.Forms.FontDialog()
        Me.CDCambiarcolor = New System.Windows.Forms.ColorDialog()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.EdiciónToolStripMenuItem, Me.FormatoToolStripMenuItem, Me.AcercaDeToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1098, 36)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.AbrirToolStripMenuItem, Me.GuardarToolStripMenuItem, Me.GuardarComoToolStripMenuItem, Me.ToolStripSeparator1, Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(88, 32)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(357, 34)
        Me.NuevoToolStripMenuItem.Text = "Nuevo"
        '
        'AbrirToolStripMenuItem
        '
        Me.AbrirToolStripMenuItem.Name = "AbrirToolStripMenuItem"
        Me.AbrirToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.AbrirToolStripMenuItem.Size = New System.Drawing.Size(357, 34)
        Me.AbrirToolStripMenuItem.Text = "Abrir"
        '
        'GuardarToolStripMenuItem
        '
        Me.GuardarToolStripMenuItem.Name = "GuardarToolStripMenuItem"
        Me.GuardarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.GuardarToolStripMenuItem.Size = New System.Drawing.Size(357, 34)
        Me.GuardarToolStripMenuItem.Text = "Guardar"
        '
        'GuardarComoToolStripMenuItem
        '
        Me.GuardarComoToolStripMenuItem.Name = "GuardarComoToolStripMenuItem"
        Me.GuardarComoToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.GuardarComoToolStripMenuItem.Size = New System.Drawing.Size(357, 34)
        Me.GuardarComoToolStripMenuItem.Text = "Guardar como"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(354, 6)
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(357, 34)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'EdiciónToolStripMenuItem
        '
        Me.EdiciónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeshacerToolStripMenuItem, Me.ToolStripSeparator2, Me.ToolStripSeparator3, Me.CortarToolStripMenuItem, Me.CopiarToolStripMenuItem, Me.PegarToolStripMenuItem, Me.ToolStripSeparator4, Me.BuscarToolStripMenuItem})
        Me.EdiciónToolStripMenuItem.Name = "EdiciónToolStripMenuItem"
        Me.EdiciónToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.EdiciónToolStripMenuItem.Size = New System.Drawing.Size(85, 32)
        Me.EdiciónToolStripMenuItem.Text = "Edición"
        '
        'DeshacerToolStripMenuItem
        '
        Me.DeshacerToolStripMenuItem.Name = "DeshacerToolStripMenuItem"
        Me.DeshacerToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.DeshacerToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.DeshacerToolStripMenuItem.Text = "Deshacer"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(267, 6)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(267, 6)
        '
        'CortarToolStripMenuItem
        '
        Me.CortarToolStripMenuItem.Name = "CortarToolStripMenuItem"
        Me.CortarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.CortarToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.CortarToolStripMenuItem.Text = "Cortar"
        '
        'CopiarToolStripMenuItem
        '
        Me.CopiarToolStripMenuItem.Name = "CopiarToolStripMenuItem"
        Me.CopiarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CopiarToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.CopiarToolStripMenuItem.Text = "Copiar"
        '
        'PegarToolStripMenuItem
        '
        Me.PegarToolStripMenuItem.Name = "PegarToolStripMenuItem"
        Me.PegarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.PegarToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.PegarToolStripMenuItem.Text = "Pegar"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(267, 6)
        '
        'BuscarToolStripMenuItem
        '
        Me.BuscarToolStripMenuItem.Name = "BuscarToolStripMenuItem"
        Me.BuscarToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.BuscarToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.BuscarToolStripMenuItem.Text = "Buscar..."
        '
        'FormatoToolStripMenuItem
        '
        Me.FormatoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NegritaToolStripMenuItem, Me.CursivaToolStripMenuItem, Me.SubrayadoToolStripMenuItem, Me.ToolStripSeparator5, Me.TamannoToolStripMenuItem, Me.ColorToolStripMenuItem, Me.ToolStripSeparator6, Me.FuenteToolStripMenuItem})
        Me.FormatoToolStripMenuItem.Name = "FormatoToolStripMenuItem"
        Me.FormatoToolStripMenuItem.Size = New System.Drawing.Size(96, 32)
        Me.FormatoToolStripMenuItem.Text = "Formato"
        '
        'NegritaToolStripMenuItem
        '
        Me.NegritaToolStripMenuItem.CheckOnClick = True
        Me.NegritaToolStripMenuItem.Name = "NegritaToolStripMenuItem"
        Me.NegritaToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.NegritaToolStripMenuItem.Size = New System.Drawing.Size(263, 34)
        Me.NegritaToolStripMenuItem.Text = "Negrita"
        '
        'CursivaToolStripMenuItem
        '
        Me.CursivaToolStripMenuItem.CheckOnClick = True
        Me.CursivaToolStripMenuItem.Name = "CursivaToolStripMenuItem"
        Me.CursivaToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.K), System.Windows.Forms.Keys)
        Me.CursivaToolStripMenuItem.Size = New System.Drawing.Size(263, 34)
        Me.CursivaToolStripMenuItem.Text = "Cursiva"
        '
        'SubrayadoToolStripMenuItem
        '
        Me.SubrayadoToolStripMenuItem.CheckOnClick = True
        Me.SubrayadoToolStripMenuItem.Name = "SubrayadoToolStripMenuItem"
        Me.SubrayadoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.SubrayadoToolStripMenuItem.Size = New System.Drawing.Size(263, 34)
        Me.SubrayadoToolStripMenuItem.Text = "Subrayado"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(260, 6)
        '
        'TamannoToolStripMenuItem
        '
        Me.TamannoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.size12, Me.size14, Me.size18, Me.size24, Me.size36, Me.size48})
        Me.TamannoToolStripMenuItem.Name = "TamannoToolStripMenuItem"
        Me.TamannoToolStripMenuItem.Size = New System.Drawing.Size(263, 34)
        Me.TamannoToolStripMenuItem.Text = "Tamaño"
        '
        'size12
        '
        Me.size12.CheckOnClick = True
        Me.size12.Name = "size12"
        Me.size12.Size = New System.Drawing.Size(134, 34)
        Me.size12.Text = "12"
        '
        'size14
        '
        Me.size14.CheckOnClick = True
        Me.size14.Name = "size14"
        Me.size14.Size = New System.Drawing.Size(134, 34)
        Me.size14.Text = "14"
        '
        'size18
        '
        Me.size18.CheckOnClick = True
        Me.size18.Name = "size18"
        Me.size18.Size = New System.Drawing.Size(134, 34)
        Me.size18.Text = "18"
        '
        'size24
        '
        Me.size24.CheckOnClick = True
        Me.size24.Name = "size24"
        Me.size24.Size = New System.Drawing.Size(134, 34)
        Me.size24.Text = "24"
        '
        'size36
        '
        Me.size36.CheckOnClick = True
        Me.size36.Name = "size36"
        Me.size36.Size = New System.Drawing.Size(134, 34)
        Me.size36.Text = "36"
        '
        'size48
        '
        Me.size48.CheckOnClick = True
        Me.size48.Name = "size48"
        Me.size48.Size = New System.Drawing.Size(134, 34)
        Me.size48.Text = "48"
        '
        'ColorToolStripMenuItem
        '
        Me.ColorToolStripMenuItem.Name = "ColorToolStripMenuItem"
        Me.ColorToolStripMenuItem.Size = New System.Drawing.Size(263, 34)
        Me.ColorToolStripMenuItem.Text = "Color"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(260, 6)
        '
        'FuenteToolStripMenuItem
        '
        Me.FuenteToolStripMenuItem.Name = "FuenteToolStripMenuItem"
        Me.FuenteToolStripMenuItem.Size = New System.Drawing.Size(263, 34)
        Me.FuenteToolStripMenuItem.Text = "Fuente..."
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AcercaDeToolStripMenuItem1})
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(117, 32)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca de..."
        '
        'AcercaDeToolStripMenuItem1
        '
        Me.AcercaDeToolStripMenuItem1.Name = "AcercaDeToolStripMenuItem1"
        Me.AcercaDeToolStripMenuItem1.Size = New System.Drawing.Size(303, 34)
        Me.AcercaDeToolStripMenuItem1.Text = "Acerca de Bloc de notas"
        '
        'RichTbNotas
        '
        Me.RichTbNotas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTbNotas.Location = New System.Drawing.Point(0, 36)
        Me.RichTbNotas.Name = "RichTbNotas"
        Me.RichTbNotas.Size = New System.Drawing.Size(1098, 674)
        Me.RichTbNotas.TabIndex = 1
        Me.RichTbNotas.Text = ""
        '
        'OFDAbrir
        '
        Me.OFDAbrir.DefaultExt = "rtf"
        Me.OFDAbrir.Filter = "Documentos RTF (.rtf)|*.rtf"
        '
        'SFDGuardar
        '
        Me.SFDGuardar.DefaultExt = "rtf"
        Me.SFDGuardar.Filter = "Documentos RTF (.rtf)|*.rtf"
        '
        'frmBlocDeNotas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1098, 710)
        Me.Controls.Add(Me.RichTbNotas)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmBlocDeNotas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bloc de notas"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AbrirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GuardarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GuardarComoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EdiciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeshacerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents CortarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopiarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PegarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents BuscarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FormatoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NegritaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CursivaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SubrayadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents TamannoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents size12 As ToolStripMenuItem
    Friend WithEvents size14 As ToolStripMenuItem
    Friend WithEvents size18 As ToolStripMenuItem
    Friend WithEvents size24 As ToolStripMenuItem
    Friend WithEvents size36 As ToolStripMenuItem
    Friend WithEvents size48 As ToolStripMenuItem
    Friend WithEvents ColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents FuenteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents RichTbNotas As RichTextBox
    Friend WithEvents OFDAbrir As OpenFileDialog
    Friend WithEvents SFDGuardar As SaveFileDialog
    Friend WithEvents FDElegirFuente As FontDialog
    Friend WithEvents CDCambiarcolor As ColorDialog
End Class
