console.debug('loaded');
$(function () {
    $("#CompetitionEntry_School_NAME").autocomplete({
        source: "/Soma/AutocompleteSuggestions",
        minLength: 1,
        select: function (event, ui) {
            if (ui.item) {
                $("#CompetitionEntry_School_NAME").val(ui.item.value);
                $("form").submit();
            }
        }
    });
});
