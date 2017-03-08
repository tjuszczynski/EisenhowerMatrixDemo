(function ($) {
    var MatrixController = function (view) {

        this.view = view;
        this.matrixControl = new einsenhower.controls.SingleMatrixControl($("#einsenhower-matrix"));
    };
    
    MatrixController.prototype = {

        view: null,
        matrixControl: null,

        init: function () {
            this.matrixControl.init();
        }
    };

    einsenhower.controllers.MatrixController = MatrixController;
})(jQuery);