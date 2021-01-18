@ModelType Unicomer.PRODUCT
@Code
    ViewData("Title") = "Details"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Details</h2>

<div>
    <h4>PRODUCT</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.InsertDate)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.InsertDate)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.UserInsert)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.UserInsert)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.COLOR.Name)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.COLOR.Name)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.MATERIAL.Name)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.MATERIAL.Name)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.MODEL.Description)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.MODEL.Description)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.POLICY.Name)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.POLICY.Name)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.STORE.Name)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.STORE.Name)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.STORE1.Name)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.STORE1.Name)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.TRANSACTION_TYPE.Description)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.TRANSACTION_TYPE.Description)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.UPC.UPC1)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.UPC.UPC1)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.ProductId }) |
    @Html.ActionLink("Back to List", "Index")
</p>
