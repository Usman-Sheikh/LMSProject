(function () {
    "use strict";

    angular
        .module("common.services")
        .factory("bookResource",
                ["$resource",
                 "appSettings",
                    bookResource])

    function bookResource($resource, appSettings) {
        return $resource(appSettings.serverPath + "/api/Books/");
               
    }
}()); 