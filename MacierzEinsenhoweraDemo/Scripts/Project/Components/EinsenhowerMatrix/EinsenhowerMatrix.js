(function ($) {
    var EinsenhowerMatrix = function (containerEl, options) {

        if (typeof containerEl == 'undefined') {
            return;
        }

        if (typeof options == 'undefined') {
            options = {};
        }

        this._containerEl = containerEl;
    };

    EinsenhowerMatrix.prototype = {

        _containerEl: null,

        renderTemplate: function (tasks) {

            // render JS template
            var template = tmpl("ein_matrix", {
                tasks: tasks
            });

            $(this._containerEl).html(template);
        },

        _onRemoveTask: function (event) {

            event.preventDefault();

            var taskID = $(event.target).data("id");
            $(event.target).parent().remove();

            $(document).trigger(einsenhower.events.einsenhowerMatrixComponent.TASK_REMOVED, { taskID: taskID });
        },

        setDragAndDropLists: function () {

            $("#WP, #WN, #NP, #NN").sortable({
                receive: function (event, ui) {
                    var from = ui.sender.attr("id");

                    if (this.id != from) {
                        data = {
                            taskID: ui.item.data("id"),
                            Priority: this.id
                        }

                        $(document).trigger(einsenhower.events.einsenhowerMatrixComponent.TASK_DROPPED, { data: data });
                    }
                },
                dropOnEmpty: true,
                cursor: "move",
                connectWith: ".lista",
            }).disableSelection();
        },

        init: function () {

            $(document).on("click", "span.delete_tsk", $.proxy(this._onRemoveTask, this));
        }

    }

    einsenhower.controls.EinsenhowerMatrix = EinsenhowerMatrix;

})(jQuery)