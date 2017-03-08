(function ($) {
    var EinsenhowerMatrixBaseModel = function () {

    };

    EinsenhowerMatrixBaseModel.prototype = {

        _itemsData: null,

        getData: function () {
            return this._itemsData;
        },

        bind: function (eventName, callback) {
            $(this).bind(eventName, callback);
        },

        trigger: function (eventName, data) {
            $(this).trigger(eventName, data);
        },
        
        load: function () {
            // should be overridden
            return null;
        },
    }

    einsenhower.models.EinsenhowerMatrixBaseModel = EinsenhowerMatrixBaseModel;

})(jQuery)
