Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.XtraEditors

Namespace WindowsApplication1
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub
	End Class

	Public Class MyListBoxViewInfo
		Inherits BaseListBoxViewInfo
		Public Sub New(ByVal c As BaseListBoxControl)
			MyBase.New(c)
		End Sub
		Protected Overrides Function CalcVScrollVisibility(ByVal bounds As Rectangle) As Boolean
			Return True
		End Function
	End Class
	Public Class MyListBoxControl
		Inherits ListBoxControl
		Public Sub New()
			MyBase.New()
		End Sub
		Protected Overrides Function CreateViewInfo() As BaseStyleControlViewInfo
			Return New MyListBoxViewInfo(Me)
		End Function

	End Class
End Namespace