'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class TRANSACTION_TYPE
    Public Property IdTransactionType As Integer
    Public Property Description As String
    Public Property InsertDate As Date

    Public Overridable Property PRODUCT As ICollection(Of PRODUCT) = New HashSet(Of PRODUCT)

End Class
