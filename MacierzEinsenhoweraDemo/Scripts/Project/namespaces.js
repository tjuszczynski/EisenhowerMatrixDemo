(function ($) {
    if (!window.einsenhower) {
        window.einsenhower = {};
    }

    var declareNamespace = function (namespaceName) {
        var parts = namespaceName.split(".");
        var prevEl = window;

        for (var i = 0; i < parts.length; i++) {
            var name = parts[i];
            if (typeof prevEl[name] == 'undefined') {
                prevEl[name] = {};
            }

            prevEl = prevEl[name];
        }
    }

    // MVC
    declareNamespace('einsenhower.models');
    declareNamespace('einsenhower.models.matrices');
    declareNamespace('einsenhower.views');
    declareNamespace('einsenhower.controllers');

    declareNamespace('einsenhower.events');

    declareNamespace('einsenhower.controls');

    declareNamespace('einsenhower.helpers');

})(jQuery);
