(function ($) {

    var EinsenhowerMatrixBaseControl = function (containerEl, model) {

        this._model = model;
        this._containerEl = containerEl;
        this._matrix = new einsenhower.controls.EinsenhowerMatrix(this._containerEl);
    };


    EinsenhowerMatrixBaseControl.prototype = {
        _model: null,
        _containerEl: null,
        _matrix: null,

        onDataLoaded: function () {
            // should be overridden
            return null;
        },

        onTaskRemoved: function () {
            // should be overridden
            return null;
        },

        onTaskDropped: function () {
            // should be overridden
            return null;
        },

        init: function () {

            this._matrix.init();

            this._model.bind(einsenhower.events.einsenhowerMatrixComponent.DATA_LOADING_FINISHED, $.proxy(this.onDataLoaded, this));
            $(document).bind(einsenhower.events.einsenhowerMatrixComponent.TASK_REMOVED, $.proxy(this.onTaskRemoved, this));
            $(document).bind(einsenhower.events.einsenhowerMatrixComponent.TASK_DROPPED, $.proxy(this.onTaskDropped, this));

            this._model.load();
        },
        
    }

    einsenhower.controls.EinsenhowerMatrixBaseControl = EinsenhowerMatrixBaseControl;
})(jQuery)