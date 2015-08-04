(function () {
    "use strict";

    angular
        .module("common.services")
        .factory("orderResource",
                ["$resource",
                 "appSettings",
                    orderResource])

    function orderResource($resource, appSettings) {
        return $resource(appSettings.serverPath + "/api/Order", null,
                {
                    'update': { method: 'PUT' }
                });
    }
}());

