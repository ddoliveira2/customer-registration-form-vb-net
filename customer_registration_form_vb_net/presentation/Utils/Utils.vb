Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Public Module Utils

    <System.Runtime.CompilerServices.Extension>
    Public Sub AdjustMainScreen(form As Form)

        form.Top = 0
        form.Left = 0
        form.Width = Screen.PrimaryScreen.Bounds.Width - 2
        form.Height = Screen.PrimaryScreen.Bounds.Height - 45

    End Sub

End Module
