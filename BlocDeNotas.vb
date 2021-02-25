Imports System.IO
Public Class frmBlocDeNotas
    'variables
    Dim cambios As Boolean = False
    Dim archivo As String 'para guardar la ruta del archivo que queremos abrir o guardar
    Dim respuesta As DialogResult
    Dim nombreArchivo As DirectoryInfo 'para sacar el nombre del archivo de la ruta
    Dim nomArchSinExt As String 'para guardar el nombre del archivo sin la extensión
    Dim fuente As Font
    Dim guardado As Boolean = False

    'LOAD DEL FORMULARIO
    Private Sub frmBlocDeNotas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DeshabilitarGuardar()
        DeshabilitarDeshacerBuscar()
        DeshabilitarCortarCopiar()
        DeshabilitarPegar()
    End Sub

    'SALIR
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Salir()
    End Sub

    'ACERCA DE...
    Private Sub AcercaDeToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem1.Click
        'formulario modal
        frmAcercaDe.ShowDialog()
    End Sub

    'BUSCAR
    Private Sub BuscarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarToolStripMenuItem.Click
        'formulario no modal
        frmBuscar.Show()
    End Sub

    'NUEVO 
    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        Nuevo()
    End Sub

    'ABRIR ARCHIVO
    Private Sub AbrirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrirToolStripMenuItem.Click
        Abrir()
    End Sub

    'GUARDAR
    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        Guardar()
    End Sub

    'GUARDAR COMO...
    Private Sub GuardarComoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarComoToolStripMenuItem.Click
        GuardarComo()
    End Sub

    'DESHACER
    Private Sub DeshacerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeshacerToolStripMenuItem.Click
        RichTbNotas.Undo()
    End Sub

    'CORTAR
    Private Sub CortarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CortarToolStripMenuItem.Click
        RichTbNotas.Cut()
    End Sub

    'COPIAR
    Private Sub CopiarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopiarToolStripMenuItem.Click
        RichTbNotas.Copy()
    End Sub

    'PEGAR
    Private Sub PegarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PegarToolStripMenuItem.Click
        RichTbNotas.Paste()
    End Sub

    'FUENTE
    Private Sub FuenteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FuenteToolStripMenuItem.Click
        ElegirFuente()
    End Sub

    'COLOR
    Private Sub ColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColorToolStripMenuItem.Click
        ElegirColor()
    End Sub

    'NEGRITA
    Private Sub NegritaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NegritaToolStripMenuItem.Click
        RichTbNotas.SelectionFont = ElegirEstilo()
    End Sub

    'CURSIVA
    Private Sub CursivaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CursivaToolStripMenuItem.Click
        RichTbNotas.SelectionFont = ElegirEstilo()
    End Sub

    'SUBRAYADO
    Private Sub SubrayadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SubrayadoToolStripMenuItem.Click
        RichTbNotas.SelectionFont = ElegirEstilo()
    End Sub

    'TAMAÑO 12
    Private Sub size12_Click(sender As Object, e As EventArgs) Handles size12.Click
        ChangeSize(12)
    End Sub

    'TAMAÑO 14
    Private Sub size14_Click(sender As Object, e As EventArgs) Handles size14.Click
        ChangeSize(14)
    End Sub

    'TAMAÑO 18
    Private Sub size18_Click(sender As Object, e As EventArgs) Handles size18.Click
        ChangeSize(18)
    End Sub

    'TAMAÑO 24
    Private Sub size24_Click(sender As Object, e As EventArgs) Handles size24.Click
        ChangeSize(24)
    End Sub

    'TAMAÑO 36
    Private Sub size36_Click(sender As Object, e As EventArgs) Handles size36.Click
        ChangeSize(36)
    End Sub

    'TAMAÑO 48
    Private Sub size48_Click(sender As Object, e As EventArgs) Handles size48.Click
        ChangeSize(48)
    End Sub

    'para comprobar si ha habido cambios en el texto
    Private Sub RichTbNotas_TextChanged(sender As Object, e As EventArgs) Handles RichTbNotas.TextChanged
        cambios = True
        'Habilitar 
        HabilitarGuardar()
    End Sub

    'Habilitar y deshabilitar botones copiar, cortar, pegar, deshacer y buscar
    Private Sub RichTbNotas_SelectionChanged(sender As Object, e As EventArgs) Handles RichTbNotas.SelectionChanged
        If RichTbNotas.Text = "" Then
            DeshabilitarDeshacerBuscar()
        Else
            HabilitarDeshacerBuscar()
            fuente = RichTbNotas.SelectionFont
            CheckFuenteEstilo(fuente)
            SizeNoMultiselect(fuente)
        End If

        If RichTbNotas.SelectedText = "" Then
            DeshabilitarCortarCopiar()
        Else
            HabilitarCortarCopiar()
        End If
        'comprobar si el portapapeles tiene texto en formato rtf 
        'para habilitar el botón de pegar
        If Clipboard.ContainsText(TextDataFormat.Rtf) Then
            HabilitarPegar()
        Else
            DeshabilitarPegar()
        End If
    End Sub
#Region "procedimientos"
    Sub Salir()
        If cambios Then
            respuesta = MessageBox.Show("¿Quiere guardar el archivo antes de salir?", "Guardar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If respuesta = DialogResult.Cancel Then
                RichTbNotas.Show()
            ElseIf respuesta = DialogResult.No Then
                Application.Exit()
            ElseIf respuesta = DialogResult.Yes Then
                Guardar()
                guardado = True
                Application.Exit()
            End If
        Else
            Application.Exit()
        End If
    End Sub
    Sub Nuevo()
        If cambios Then
            respuesta = MessageBox.Show("¿Quiere guardar el archivo?", "Guardar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If respuesta = DialogResult.Cancel Then
                RichTbNotas.Show()
            ElseIf respuesta = DialogResult.No Then
                RichTbNotas.Clear()
                cambios = False
            ElseIf respuesta = DialogResult.Yes Then
                Guardar()
                guardado = True
                RichTbNotas.Clear()
            End If
        Else
            RichTbNotas.Clear()
        End If
    End Sub

    Sub Abrir()
        If cambios Then
            'comprobar si hay cambios que guardar
            'si hay cambios preguntar si quiere guardarlos
            'si no hay cambios abrir directamente
            respuesta = MessageBox.Show("¿Quiere guardar el archivo?", "Guardar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If respuesta = DialogResult.Cancel Then
                RichTbNotas.Show()
            ElseIf respuesta = DialogResult.No Then
                CargarArchivo()
            ElseIf respuesta = DialogResult.Yes Then
                Guardar()
                guardado = True
            End If
        Else
            CargarArchivo()
        End If

    End Sub

    Sub CargarArchivo()
        Try
            If OFDAbrir.ShowDialog() = DialogResult.OK Then
                archivo = OFDAbrir.FileName ' para coger la ruta del archivo
                nombreArchivo = New DirectoryInfo(archivo)
                nomArchSinExt = nombreArchivo.Name.Remove(nombreArchivo.Name.LastIndexOf("."), 4)
                RichTbNotas.LoadFile(archivo)  'abrir el archivo

                'cambiar el nombre al formulario añadiendo el nombre del archivo
                Me.Text = Me.Text & ": " & nomArchSinExt

                'Fuente y estilos
                fuente = RichTbNotas.SelectionFont
                CheckFuenteEstilo(fuente)
                SizeNoMultiselect(fuente)
                'Habilitar el buscar cuando se abre un archivo nuevo
                BuscarToolStripMenuItem.Enabled = True
                cambios = False
                guardado = True
            End If
        Catch ex As Exception
            MessageBox.Show("No se ha podido leer el archivo", "Error")
        End Try


    End Sub

    Sub Guardar()
        If guardado Then
            Try
                RichTbNotas.SaveFile(archivo)
                cambios = False
                MessageBox.Show("El archivo se ha guardado correctamente")
            Catch ex As Exception
                MessageBox.Show("No se ha podido guardar el archivo")
            End Try
        Else
            GuardarComo()
        End If
    End Sub

    Sub GuardarComo()
        ' para mostrar el cuadro para elegir dónde guardar el archivo
        ' archivo = SFDGuardar.FileName()'ruta del archivo
        If SFDGuardar.ShowDialog() = DialogResult.OK Then
            archivo = SFDGuardar.FileName() 'ruta del archivo
            RichTbNotas.SaveFile(archivo)
            cambios = False
            guardado = True
        End If
    End Sub

    Sub ElegirFuente()
        FDElegirFuente.ShowDialog()
        fuente = FDElegirFuente.Font
        If DialogResult.OK Then
            RichTbNotas.SelectionFont = fuente

            'marcar las opciones elegidas en el cuadro de diálogo del formato de texto
            CheckFuenteEstilo(fuente)
            SizeNoMultiselect(fuente)
        End If
    End Sub

    Sub ElegirColor()
        Dim colorElegido As Color
        CDCambiarcolor.ShowDialog()
        colorElegido = CDCambiarcolor.Color
        If DialogResult.OK Then
            RichTbNotas.SelectionColor = colorElegido
        End If
    End Sub

    Function ElegirEstilo()
        fuente = RichTbNotas.SelectionFont
        'negrita, cursiva y subrayado
        If NegritaToolStripMenuItem.Checked And
                CursivaToolStripMenuItem.Checked And
                SubrayadoToolStripMenuItem.Checked Then
            fuente = New Font(fuente, CType(7, FontStyle))
            'negrita y cursiva
        ElseIf NegritaToolStripMenuItem.Checked And
            CursivaToolStripMenuItem.Checked Then
            fuente = New Font(fuente, CType(3, FontStyle))
            'negrita y subrayado
        ElseIf NegritaToolStripMenuItem.Checked And
                SubrayadoToolStripMenuItem.Checked Then
            fuente = New Font(fuente, CType(5, FontStyle))
            'cursiva y subrayado
        ElseIf CursivaToolStripMenuItem.Checked And
                SubrayadoToolStripMenuItem.Checked Then
            fuente = New Font(fuente, CType(6, FontStyle))
            'negrita
        ElseIf NegritaToolStripMenuItem.Checked Then
            fuente = New Font(fuente, CType(1, FontStyle))
            'cursiva
        ElseIf CursivaToolStripMenuItem.Checked Then
            fuente = New Font(fuente, CType(2, FontStyle))
            'subrayado
        ElseIf SubrayadoToolStripMenuItem.Checked Then
            fuente = New Font(fuente, CType(4, FontStyle))
            'regular
        Else
            fuente = New Font(fuente, CType(0, FontStyle))
        End If
        'marcar las opciones elegidas en el cuadro de diálogo del formato de texto
        FDElegirFuente.Font = fuente

        Return fuente
    End Function

    Sub ChangeSize(num As Integer)
        fuente = RichTbNotas.SelectionFont
        fuente = New Font(fuente.FontFamily, num, fuente.Style)
        'marcar las opciones elegidas en el cuadro de diálogo del formato de texto
        FDElegirFuente.Font = fuente
        RichTbNotas.SelectionFont = fuente
        SizeNoMultiselect(fuente)
    End Sub

    Sub SizeNoMultiselect(fuente)
        If fuente.Size = 12 Then
            size12.Checked = True
        Else
            size12.Checked = False
        End If
        If fuente.Size = 14 Then
            size14.Checked = True
        Else
            size14.Checked = False
        End If

        If fuente.Size = 18 Then
            size18.Checked = True
        Else
            size18.Checked = False
        End If

        If fuente.Size = 24 Then
            size24.Checked = True
        Else
            size24.Checked = False
        End If

        If fuente.Size = 36 Then
            size36.Checked = True
        Else
            size36.Checked = False
        End If

        If fuente.Size = 48 Then
            size48.Checked = True
        Else
            size48.Checked = False
        End If
    End Sub

    Sub CheckFuenteEstilo(fuente)
        If fuente.Bold Then
            NegritaToolStripMenuItem.Checked = True
        Else
            NegritaToolStripMenuItem.Checked = False
        End If
        If fuente.Italic Then
            CursivaToolStripMenuItem.Checked = True
        Else
            CursivaToolStripMenuItem.Checked = False
        End If
        If fuente.Underline Then
            SubrayadoToolStripMenuItem.Checked = True
        Else
            SubrayadoToolStripMenuItem.Checked = False
        End If
    End Sub
#End Region

#Region "Deshabilitar botones"
    Sub DeshabilitarGuardar()
        GuardarComoToolStripMenuItem.Enabled = False
        GuardarToolStripMenuItem.Enabled = False
    End Sub
    Sub DeshabilitarCortarCopiar()
        CortarToolStripMenuItem.Enabled = False
        CopiarToolStripMenuItem.Enabled = False
    End Sub
    Sub DeshabilitarDeshacerBuscar()
        DeshacerToolStripMenuItem.Enabled = False
        BuscarToolStripMenuItem.Enabled = False
    End Sub
    Sub DeshabilitarPegar()
        PegarToolStripMenuItem.Enabled = False
    End Sub
#End Region
#Region "Habilitar botones"
    Sub HabilitarGuardar()
        GuardarComoToolStripMenuItem.Enabled = True
        GuardarToolStripMenuItem.Enabled = True
    End Sub
    Sub HabilitarCortarCopiar()
        CortarToolStripMenuItem.Enabled = True
        CopiarToolStripMenuItem.Enabled = True
    End Sub
    Sub HabilitarDeshacerBuscar()
        DeshacerToolStripMenuItem.Enabled = True
        BuscarToolStripMenuItem.Enabled = True
    End Sub
    Sub HabilitarPegar()
        PegarToolStripMenuItem.Enabled = True
    End Sub
#End Region

End Class
