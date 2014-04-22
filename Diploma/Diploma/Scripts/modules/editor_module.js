$(function () {
    window.root = {};
    window.root.editorModule = (function($, root) {
        var module = {
            init: function(settings) {
                var self = this;
                self.settings = settings;
                self.initClick();
            },
            initEditor: function () {
                var self = this;
                $(self.settings.Selectors.Editor).redactor();
            },
            initClick: function (selector) {
                var self = this;
                $(self.settings.Selectors.ButtonRedact).click(function () {
                    self.initEditor(self.settings.Selectors.Editor);
                });
            }
        };
        return module;
    }(jQuery, window.root || {}));
});

