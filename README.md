bootstraprazorextensions
========================

Extension Methods to generate razor views for bootstrap 3 elements

example usage:

<!--<div class="form-group">
    @Html.ControlLabelWithColFor(model => model.Property1, "5")
    <div class="col-sm-7">
        <div>
            @Html.FormControlTextBoxFor(model => model.Property2, new {autocomplete = "off"})
            @Html.ValidationMessageFor(model => model.Property2)
        </div>
    </div>
</div>-->

Makes your razor views much more clean, by generating bootstrap3-compatible markup that is rendered to your browser for all created elements.
