$(function () {
    window.root = {};
    window.root.EditorModule = function (settings) {
        var module = {
            init: function () {
                var self = this;
                self.settings = settings;
                self.initClick();
            },
            initEditor: function () {
                var self = this;
                $(self.settings.Selectors.Editor).redactor();
            },
            initClick: function () {
                var self = this;
                $(self.settings.Selectors.ButtonRedact).click(function () {
                    self.initEditor(self.settings.Selectors.Editor);
                    $(self.settings.Selectors.ButtonRedact).hide();
                    $(self.settings.Selectors.ButtonSave).show();
                });
                $(self.settings.Selectors.ButtonSave).click(function () {
                    var data = { data: $(self.settings.Selectors.Editor).html(), path: self.settings.Path };
                    var xhr = $.ajax({
                        type: 'POST',
                        url: self.settings.UrlPostData,
                        data: JSON.stringify(data),
                        dataType: "json",
                        contentType: 'application/json; charset=UTF-8'
                    });
                    xhr.done(function () {
                        window.location.reload();
                    });
                });
            }
        };
        module.init();
        return module;
    };
});

