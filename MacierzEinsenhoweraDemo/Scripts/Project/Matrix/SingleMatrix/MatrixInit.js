(function ($) {

    $(document).bind('app_start', function () {

        var view = new einsenhower.views.MatrixView('SingleMatrix');
        var controller = new einsenhower.controllers.MatrixController(view);

        controller.init();
        view.init();
    });
})(jQuery);