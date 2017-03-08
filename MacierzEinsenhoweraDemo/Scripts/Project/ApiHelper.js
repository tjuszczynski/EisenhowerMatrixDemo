(function ($) {

    var ApiHelper = function () {
    };

    ApiHelper.prototype = {

        post: function (apiUrl, postData, successCallback, timeout) {
            
            $.ajax({
                url: apiUrl,
                type: 'POST',
                data: JSON.stringify(postData),
                timeout: timeout != null ? timeout : 0,
                contentType: 'application/json',
                success: function (data) {
                    if (typeof successCallback == "function") {
                        successCallback(data);
                    }
                },
            });
        },

        get: function (apiUrl, successCallback) {

            $.ajax({
                dataType: "json",
                url: apiUrl,
                success: function (data) {
                    if (typeof successCallback == "function") {
                        successCallback(data);
                    }
                },
            });
        }

    }

    einsenhower.helpers.ApiHelper = new ApiHelper();

})(jQuery);