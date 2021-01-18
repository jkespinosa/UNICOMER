Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports Unicomer

Namespace Controllers
    Public Class ProductController
        Inherits System.Web.Mvc.Controller

        Private db As New UNICOMEREntities

        ' GET: Product
        Function Index() As ActionResult
            Dim pRODUCT = db.PRODUCT.Include(Function(p) p.COLOR).Include(Function(p) p.MATERIAL).Include(Function(p) p.MODEL).Include(Function(p) p.POLICY).Include(Function(p) p.STORE).Include(Function(p) p.STORE1).Include(Function(p) p.TRANSACTION_TYPE).Include(Function(p) p.UPC)
            Return View(pRODUCT.ToList())
        End Function

        ' GET: Product/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim pRODUCT As PRODUCT = db.PRODUCT.Find(id)
            If IsNothing(pRODUCT) Then
                Return HttpNotFound()
            End If
            Return View(pRODUCT)
        End Function

        ' GET: Product/Create
        Function Create() As ActionResult
            ViewBag.IdColor = New SelectList(db.COLOR, "IdColor", "Name")
            ViewBag.IdMaterial = New SelectList(db.MATERIAL, "IdMaterial", "Name")
            ViewBag.IdModel = New SelectList(db.MODEL, "IdModel", "Description")
            ViewBag.IdPolicy = New SelectList(db.POLICY, "IdPolicy", "Name")
            ViewBag.IdStoreDownLoadProduct = New SelectList(db.STORE, "IdStore", "Name")
            ViewBag.IdStoreLoadProduct = New SelectList(db.STORE, "IdStore", "Name")
            ViewBag.IdTransactionType = New SelectList(db.TRANSACTION_TYPE, "IdTransactionType", "Description")
            ViewBag.IdUpc = New SelectList(db.UPC, "IdUpc", "UPC1")
            Return View()
        End Function

        ' POST: Product/Create
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="ProductId,IdStoreLoadProduct,IdStoreDownLoadProduct,IdColor,IdMaterial,IdPolicy,IdTransactionType,IdUpc,IdModel,InsertDate,UserInsert")> ByVal pRODUCT As PRODUCT) As ActionResult
            If ModelState.IsValid Then
                db.PRODUCT.Add(pRODUCT)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.IdColor = New SelectList(db.COLOR, "IdColor", "Name", pRODUCT.IdColor)
            ViewBag.IdMaterial = New SelectList(db.MATERIAL, "IdMaterial", "Name", pRODUCT.IdMaterial)
            ViewBag.IdModel = New SelectList(db.MODEL, "IdModel", "Description", pRODUCT.IdModel)
            ViewBag.IdPolicy = New SelectList(db.POLICY, "IdPolicy", "Name", pRODUCT.IdPolicy)
            ViewBag.IdStoreDownLoadProduct = New SelectList(db.STORE, "IdStore", "Name", pRODUCT.IdStoreDownLoadProduct)
            ViewBag.IdStoreLoadProduct = New SelectList(db.STORE, "IdStore", "Name", pRODUCT.IdStoreLoadProduct)
            ViewBag.IdTransactionType = New SelectList(db.TRANSACTION_TYPE, "IdTransactionType", "Description", pRODUCT.IdTransactionType)
            ViewBag.IdUpc = New SelectList(db.UPC, "IdUpc", "UPC1", pRODUCT.IdUpc)
            Return View(pRODUCT)
        End Function

        ' GET: Product/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim pRODUCT As PRODUCT = db.PRODUCT.Find(id)
            If IsNothing(pRODUCT) Then
                Return HttpNotFound()
            End If
            ViewBag.IdColor = New SelectList(db.COLOR, "IdColor", "Name", pRODUCT.IdColor)
            ViewBag.IdMaterial = New SelectList(db.MATERIAL, "IdMaterial", "Name", pRODUCT.IdMaterial)
            ViewBag.IdModel = New SelectList(db.MODEL, "IdModel", "Description", pRODUCT.IdModel)
            ViewBag.IdPolicy = New SelectList(db.POLICY, "IdPolicy", "Name", pRODUCT.IdPolicy)
            ViewBag.IdStoreDownLoadProduct = New SelectList(db.STORE, "IdStore", "Name", pRODUCT.IdStoreDownLoadProduct)
            ViewBag.IdStoreLoadProduct = New SelectList(db.STORE, "IdStore", "Name", pRODUCT.IdStoreLoadProduct)
            ViewBag.IdTransactionType = New SelectList(db.TRANSACTION_TYPE, "IdTransactionType", "Description", pRODUCT.IdTransactionType)
            ViewBag.IdUpc = New SelectList(db.UPC, "IdUpc", "UPC1", pRODUCT.IdUpc)
            Return View(pRODUCT)
        End Function

        ' POST: Product/Edit/5
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="ProductId,IdStoreLoadProduct,IdStoreDownLoadProduct,IdColor,IdMaterial,IdPolicy,IdTransactionType,IdUpc,IdModel,InsertDate,UserInsert")> ByVal pRODUCT As PRODUCT) As ActionResult
            If ModelState.IsValid Then
                db.Entry(pRODUCT).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.IdColor = New SelectList(db.COLOR, "IdColor", "Name", pRODUCT.IdColor)
            ViewBag.IdMaterial = New SelectList(db.MATERIAL, "IdMaterial", "Name", pRODUCT.IdMaterial)
            ViewBag.IdModel = New SelectList(db.MODEL, "IdModel", "Description", pRODUCT.IdModel)
            ViewBag.IdPolicy = New SelectList(db.POLICY, "IdPolicy", "Name", pRODUCT.IdPolicy)
            ViewBag.IdStoreDownLoadProduct = New SelectList(db.STORE, "IdStore", "Name", pRODUCT.IdStoreDownLoadProduct)
            ViewBag.IdStoreLoadProduct = New SelectList(db.STORE, "IdStore", "Name", pRODUCT.IdStoreLoadProduct)
            ViewBag.IdTransactionType = New SelectList(db.TRANSACTION_TYPE, "IdTransactionType", "Description", pRODUCT.IdTransactionType)
            ViewBag.IdUpc = New SelectList(db.UPC, "IdUpc", "UPC1", pRODUCT.IdUpc)
            Return View(pRODUCT)
        End Function

        ' GET: Product/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim pRODUCT As PRODUCT = db.PRODUCT.Find(id)
            If IsNothing(pRODUCT) Then
                Return HttpNotFound()
            End If
            Return View(pRODUCT)
        End Function

        ' POST: Product/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim pRODUCT As PRODUCT = db.PRODUCT.Find(id)
            db.PRODUCT.Remove(pRODUCT)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
