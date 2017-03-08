(function ($) {

    var SingleMatrixControl = function (containerEl) {

        this._model = new einsenhower.models.matrices.SingleMatrixModel();
        einsenhower.controls.EinsenhowerMatrixBaseControl.call(this, containerEl, this._model);
    }

    SingleMatrixControl.prototype = new einsenhower.controls.EinsenhowerMatrixBaseControl();

    SingleMatrixControl.prototype = {

        _model: null,

        init: function () {
            einsenhower.controls.EinsenhowerMatrixBaseControl.prototype.init.call(this);
        },

        onDataLoaded: function () {

            var tasks = this._model.getData();
            this._matrix.renderTemplate(tasks);
            this._matrix.setDragAndDropLists();
        },

        onTaskRemoved: function (e, data) {
            this._model.removeTask(data);
        },

        onTaskDropped: function (e, data) {
            this._model.changeQuarter(data);
        },
    }

    einsenhower.controls.SingleMatrixControl = SingleMatrixControl;
})(jQuery);