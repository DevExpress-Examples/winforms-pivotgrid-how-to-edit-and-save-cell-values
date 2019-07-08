Imports System
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.Linq

Namespace HowToEditAndSavePivotCellValues
	Public NotInheritable Class DatabaseHelper

		Private Sub New()
		End Sub
		#Region "Fields"

		Private Shared ReadOnly random As New Random()
		Private Shared ReadOnly FirstNames() As String = { "Julia", "Stephanie", "Alex", "John", "Curtis", "Keith", "Timothy", "Jack", "Miranda", "Alice" }
		Private Shared ReadOnly LastNames() As String = { "Black", "White", "Brown", "Smith", "Cooper", "Parker", "Walker", "Hunter", "Burton", "Douglas", "Fox", "Simpson" }
		Private Shared ReadOnly Adjectives() As String = { "Ancient", "Modern", "Mysterious", "Elegant", "Red", "Green", "Blue", "Amazing", "Wonderful", "Astonishing", "Lovely", "Beautiful", "Inexpensive", "Famous", "Magnificent", "Fancy" }
		Private Shared ReadOnly ProductNames() As String = { "Ice Cubes", "Bicycle", "Desk", "Hamburger", "Notebook", "Tea", "Cellphone", "Butter", "Frying Pan", "Napkin", "Armchair", "Chocolate", "Yoghurt", "Statuette", "Keychain" }
		Private Shared ReadOnly CategoryNames() As String = { "Business", "Presents", "Accessories", "Home", "Hobby" }

		Private Shared ReadOnly CustomerNames() As String
		Private Shared ReadOnly SalesPersonNames() As String
		Private Shared ReadOnly Products() As ProductDataRecord

		#End Region

		Shared Sub New()
			CustomerNames = GenerateUniqueValues(random.Next(40, 50), AddressOf GeneratePersonName).ToArray()
			SalesPersonNames = GenerateUniqueValues(random.Next(40, 50), AddressOf GeneratePersonName).ToArray()
			Products = GenerateProducts()
		End Sub

		#Region "Public"
		Public Shared Function CreateData() As Collection(Of MyOrderRow)
			Dim orderList As New Collection(Of MyOrderRow)()
			For i As Integer = 0 To 1499
				Dim row As New MyOrderRow()
				row.ID = i
				Dim product = DatabaseHelper.GetProduct()
				row.OrderDate = DatabaseHelper.GetOrderDate()
				row.Quantity = DatabaseHelper.GetQuantity()
				row.UnitPrice = DatabaseHelper.GetProductPrice(product)
				row.ExtendedPrice = row.Quantity * row.UnitPrice
				row.CustomerName = DatabaseHelper.GetCustomerName()
				row.ProductName = product.ProductName
				row.CategoryName = product.CategoryName
				row.SalesPersonName = DatabaseHelper.GetSalesPersonName()
				row.NeedVerification = True
				orderList.Add(row)
			Next i
			Return orderList
		End Function
		Public Shared Function GetOrderDate() As Date
			Return New Date(random.Next(2017, 2019), random.Next(1, 13), random.Next(1, 28))
		End Function
		Public Shared Function GetQuantity() As Integer
			Return random.Next(1, 100)
		End Function
		Public Shared Function GetProductPrice(ByVal product As ProductDataRecord) As Decimal
			Dim price = product.UnitPrice * CDec(0.5 + random.NextDouble())
			Return Math.Round(price, 2)
		End Function
		Public Shared Function GetProduct() As ProductDataRecord
			Return Products(random.Next(Products.Length))
		End Function
		Public Shared Function GetCustomerName() As String
			Return CustomerNames(random.Next(CustomerNames.Length))
		End Function
		Public Shared Function GetSalesPersonName() As String
			Return SalesPersonNames(random.Next(SalesPersonNames.Length))
		End Function

		#End Region
		#Region "Private"

		Private Shared Function GenerateUniqueValues(Of T)(ByVal count As Integer, ByVal generateValue As Func(Of T)) As List(Of T)
			Dim values = New HashSet(Of T)()
			Do While values.Count < count
				Dim value = generateValue()
				If Not values.Contains(value) Then
					values.Add(value)
				End If
			Loop
			Return values.ToList()
		End Function

		Private Shared Function GenerateProducts() As ProductDataRecord()
			Return GenerateUniqueValues(random.Next(80, 100), AddressOf GenerateProductName).Select(Function(productName) New ProductDataRecord With {.ProductName = productName, .UnitPrice = random.Next(10, 500), .CategoryName = GenerateCategoryName()}).ToArray()
		End Function
		Private Shared Function GenerateCategoryName() As String
			Return CategoryNames(random.Next(CategoryNames.Length))
		End Function
		Private Shared Function GeneratePersonName() As String
			Return FirstNames(random.Next(FirstNames.Length)) & " " & LastNames(random.Next(LastNames.Length))
		End Function
		Private Shared Function GenerateProductName() As String
			Return Adjectives(random.Next(Adjectives.Length)) & " " & ProductNames(random.Next(ProductNames.Length))
		End Function
		#End Region
	End Class

	Public Class ProductDataRecord
		Public Property ProductName() As String
		Public Property CategoryName() As String
		Public Property UnitPrice() As Decimal
	End Class
End Namespace

