@ModelType IEnumerable(Of Unicomer.PRODUCT)
@Code
ViewData("Title") = "Index"
Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>




<table id="example" class="display" style="width:100%">
    <thead>

        <tr>
   
            <th>
                <label>
                    COLOR
                </label>
            </th>
            <th>
                <label>
                    MATERIAL
                </label>
            </th>
            <th>
                <label>
                    MODELO
                </label>
            </th>
            <th>
                <label>
                   POLIZA
                </label>
            </th>
            <th>
                <label>
                    TIENDA_CARGOPRODINICIALMENTE

                </label>
            </th>
            <th>
                <label>
                    TIENDA_MOVIOPRODUCTO
                </label>
            </th>
            <th>
                <label>
                    ESTADO
                </label>
            </th>
            <th>
                <label>
                    TRANSACCION
                </label>
            </th>
            <th></th>
        </tr>
    </thead>

    <tbody>
        @For Each item In Model
            @<tr>
               
                <td>
                    @Html.DisplayFor(Function(modelItem) item.COLOR.Name)
                </td>
                <td>
                    @Html.DisplayFor(Function(modelItem) item.MATERIAL.Name)
                </td>
                <td>
                    @Html.DisplayFor(Function(modelItem) item.MODEL.Description)
                </td>
                <td>
                    @Html.DisplayFor(Function(modelItem) item.POLICY.Name)
                </td>
                <td>
                    @Html.DisplayFor(Function(modelItem) item.STORE.Name)
                </td>
                <td>
                    @Html.DisplayFor(Function(modelItem) item.STORE1.Name)
                </td>
                <td>
                    @Html.DisplayFor(Function(modelItem) item.TRANSACTION_TYPE.Description)
                </td>
                <td>
                    @Html.DisplayFor(Function(modelItem) item.UPC.UPC1)
                </td>
                <td>
                    @Html.ActionLink("Edit", "Edit", New With {.id = item.ProductId}) |
                    @Html.ActionLink("Details", "Details", New With {.id = item.ProductId}) |
                    @Html.ActionLink("Delete", "Delete", New With {.id = item.ProductId})
                </td>
            </tr>
        Next
    </tbody>
</table>
