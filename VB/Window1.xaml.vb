Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports System.Windows

Namespace WpfApplication5
    Partial Public Class Window1
        Inherits Window

        Public Sub New()
            InitializeComponent()
        End Sub
    End Class
    Public Class ViewModel
        Public Property Items() As ObservableCollection(Of Item)
        Public Sub New()
            Items = New ObservableCollection(Of Item)()
            For i As Integer = 0 To 99
                Items.Add(New Item With {.ValueType = If(i Mod 3 = 0, ValueType.Decimal, ValueType.Number), .Value = i})
            Next i
        End Sub
    End Class
    Public Class Item
        Implements INotifyPropertyChanged

        Private _valueType As ValueType
        Public Property ValueType() As ValueType
            Get
                Return _valueType
            End Get
            Set(ByVal value As ValueType)
                _valueType = value
                RaisePropertyChanged("ValueType")
            End Set
        End Property
        Private _value As Double
        Public Property Value() As Double
            Get
                Return _value
            End Get
            Set(ByVal value As Double)
                _value = value
                RaisePropertyChanged("Value")
            End Set
        End Property

        Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
        Protected Sub RaisePropertyChanged(ByVal name As String)
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(name))
        End Sub
    End Class
    Public Enum ValueType
        [Decimal]
        Number
    End Enum
End Namespace