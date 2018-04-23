Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes
Imports System.ComponentModel
Imports DevExpress.Xpf.Editors.Settings

Namespace WpfApplication5
	''' <summary>
	''' Interaction logic for Window1.xaml
	''' </summary>
	Partial Public Class Window1
		Inherits Window
		Private coll As BindingList(Of ContactItem)
		Public Sub New()
			InitializeComponent()
			coll = New BindingList(Of ContactItem)()
			Dim f1 As New ContactItem()
			f1.Name = OneTwo.One
			f1.Salary = 13
			f1.SalaryLimitation = 30
			f1.IsFired = False
			coll.Add(f1)
			f1 = New ContactItem()
			'f1.Name = OneTwo.One;
			f1.Salary = 23
			f1.SalaryLimitation = 50

			coll.Add(f1)
			f1 = New ContactItem()
			f1.Name = OneTwo.One
			f1.Salary = 23
			f1.SalaryLimitation = 50

			coll.Add(f1)
			f1 = New ContactItem()
			f1.Name = OneTwo.Two
			f1.Salary = 23
			f1.SalaryLimitation = 50

			coll.Add(f1)
			f1 = New ContactItem()
			f1.Name = OneTwo.Two
			f1.Salary = 23
			f1.SalaryLimitation = 50

			coll.Add(f1)
			f1 = New ContactItem()
			f1.Name = OneTwo.Two
			f1.Salary = 23
			f1.SalaryLimitation = 50

			coll.Add(f1)

			f1 = New ContactItem()
			f1.Name = OneTwo.One
			f1.Salary = 23
			f1.SalaryLimitation = 50

			coll.Add(f1)
			f1 = New ContactItem()
			f1.Name = OneTwo.Two
			f1.Salary = 23
			f1.SalaryLimitation = 50

			coll.Add(f1)
			f1 = New ContactItem()
			f1.Name = OneTwo.One
			f1.Salary = 23
			f1.SalaryLimitation = 50

			coll.Add(f1)

			f1 = New ContactItem()
			f1.Name = OneTwo.One
			f1.Salary = 23
			f1.SalaryLimitation = 50

			coll.Add(f1)


			grid.ItemsSource = coll

		End Sub
	End Class

	Public Class ContactItem
		Private privateName As OneTwo
		Public Property Name() As OneTwo
			Get
				Return privateName
			End Get
			Set(ByVal value As OneTwo)
				privateName = value
			End Set
		End Property
		Private privateSalary As Integer
		Public Property Salary() As Integer
			Get
				Return privateSalary
			End Get
			Set(ByVal value As Integer)
				privateSalary = value
			End Set
		End Property
		Private privateSalaryLimitation As Integer
		Public Property SalaryLimitation() As Integer
			Get
				Return privateSalaryLimitation
			End Get
			Set(ByVal value As Integer)
				privateSalaryLimitation = value
			End Set
		End Property
        Private privateIsFired As Boolean
		Public Property IsFired() As Boolean
			Get
				Return privateIsFired
			End Get
			Set(ByVal value As Boolean)
				privateIsFired = value
			End Set
		End Property
	End Class

	Public Enum OneTwo
	   One
	   Two
	End Enum
End Namespace
