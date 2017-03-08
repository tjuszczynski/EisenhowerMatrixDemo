(function ($) {

    var SingleMatrixModel = function () {

    }

    SingleMatrixModel.prototype = new einsenhower.models.EinsenhowerMatrixBaseModel();

    SingleMatrixModel.prototype.onAllDataLoaded = function (data) {
        
        this._itemsData = data;
        this.trigger(einsenhower.events.einsenhowerMatrixComponent.DATA_LOADING_FINISHED);
    },
    
    SingleMatrixModel.prototype.load = function () {
        debugger;
        einsenhower.helpers.ApiHelper.get("/api/SingleMatrixApi/GetTasks",
            $.proxy(function (data) {
                this.onAllDataLoaded(data);
            }, this));
    };

    SingleMatrixModel.prototype.removeTask = function (data) {
        
        einsenhower.helpers.ApiHelper.post("/api/SingleMatrixApi/RemoveTask", data.taskID);
    };
    
    SingleMatrixModel.prototype.changeQuarter = function (data) {
        
        einsenhower.helpers.ApiHelper.post("/api/SingleMatrixApi/ChangeQuarter", data.data);
    }

    einsenhower.models.matrices.SingleMatrixModel = SingleMatrixModel;
})(jQuery);
