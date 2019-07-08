Imports System
Imports System.Collections.ObjectModel

Namespace HowToEditAndSavePivotCellValues
	Public Class MyOrderRow
		Private privateID As Integer
		Public Property ID() As Integer
			Get
				Return privateID
			End Get
			Friend Set(ByVal value As Integer)
				privateID = value
			End Set
		End Property
		Private privateOrderDate As Date
		Public Property OrderDate() As Date
			Get
				Return privateOrderDate
			End Get
			Friend Set(ByVal value As Date)
				privateOrderDate = value
			End Set
		End Property
		Private privateQuantity As Integer
		Public Property Quantity() As Integer
			Get
				Return privateQuantity
			End Get
			Friend Set(ByVal value As Integer)
				privateQuantity = value
			End Set
		End Property
		Private privateUnitPrice As Decimal
		Public Property UnitPrice() As Decimal
			Get
				Return privateUnitPrice
			End Get
			Friend Set(ByVal value As Decimal)
				privateUnitPrice = value
			End Set
		End Property
		Private privateCustomerName As String
		Public Property CustomerName() As String
			Get
				Return privateCustomerName
			End Get
			Friend Set(ByVal value As String)
				privateCustomerName = value
			End Set
		End Property
		Private privateProductName As String
		Public Property ProductName() As String
			Get
				Return privateProductName
			End Get
			Friend Set(ByVal value As String)
				privateProductName = value
			End Set
		End Property
		Private privateCategoryName As String
		Public Property CategoryName() As String
			Get
				Return privateCategoryName
			End Get
			Friend Set(ByVal value As String)
				privateCategoryName = value
			End Set
		End Property
		Private privateSalesPersonName As String
		Public Property SalesPersonName() As String
			Get
				Return privateSalesPersonName
			End Get
			Friend Set(ByVal value As String)
				privateSalesPersonName = value
			End Set
		End Property
		Private privateExtendedPrice As Decimal
		Public Property ExtendedPrice() As Decimal
			Get
				Return privateExtendedPrice
			End Get
			Friend Set(ByVal value As Decimal)
				privateExtendedPrice = value
			End Set
		End Property
		Public Property NeedVerification() As Boolean
	End Class
End Namespace
