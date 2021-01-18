Imports CrystalDecisions.CrystalReports.Engine
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.IO
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Mvc
Imports System.Xml.Linq

Namespace Controllers
    Public Class rptProductController
        Inherits Controller

        ' GET: rptProduct
        Function Index() As ActionResult
            Return View()
        End Function

        Function Download_PDF() As ActionResult
            Dim context As UNICOMEREntities = New UNICOMEREntities()
            Dim rd As ReportDocument = New ReportDocument()
            rd.Load(Path.Combine(Server.MapPath("~/Reports"), "rptProduct.rpt"))
            rd.SetDataSource(context.vwProduct.[Select](Function(c) New With {
                c.ESTADOTRANSACCION,
                c.TIENDA_CARGOPRODINICIALMENTE,
                c.TIENDA_MOVIOPRODUCTO,
                c.UPC
            }).ToList())
            Response.Buffer = False
            Response.ClearContent()
            Response.ClearHeaders()
            rd.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape
            rd.PrintOptions.ApplyPageMargins(New CrystalDecisions.[Shared].PageMargins(5, 5, 5, 5))
            rd.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.PaperA5
            Dim stream As Stream = rd.ExportToStream(CrystalDecisions.[Shared].ExportFormatType.PortableDocFormat)
            stream.Seek(0, SeekOrigin.Begin)
            Return File(stream, "application/pdf", "ProductList.pdf")
        End Function
    End Class
End Namespace