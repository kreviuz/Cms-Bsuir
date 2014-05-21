$(function () {
    window.root = {};
    window.root.EditorModule = function (settings) {
        var module = {
            settings: {
            },
            init: function () {
                var self = this;
                self.settingsInstance = $.extend({}, self.settings, settings);
                self.initClick();
            },
            initEditor: function () {
                var self = this;
                var editor = $(self.settingsInstance.Selectors.Editor);
                var content = editor.html();
                editor.html("<textarea />");
                var ckEditor = editor.find("textarea:first").ckeditor({ language: 'ru' }).editor;
                ckEditor.setData(content);
                self.settingsInstance.ckEditor = ckEditor;
            },
            initClick: function () {
                var self = this;
                var buttonRedact = $(self.settingsInstance.Selectors.ButtonRedact);
                var buttonSave = $(self.settingsInstance.Selectors.ButtonSave);
                buttonRedact.click(function () {
                    self.initEditor(self.settingsInstance.Selectors.Editor);
                    buttonRedact.hide();
                    buttonSave.show();
                });
                buttonSave.click(function () {
                    var data = { data: self.settingsInstance.ckEditor.getData(), path: self.settingsInstance.Path };
                    var xhr = $.ajax({
                        type: 'POST',
                        url: self.settingsInstance.UrlPostData,
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

