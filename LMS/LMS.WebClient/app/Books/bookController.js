(function () {
    "use strict";
    angular
        .module("LMS")
        .controller("bookController",
                ["bookResource",
                     bookController]);

    function bookController(bookResource) {
        var vm = this;


        bookResource.query(function (data) {
            vm.books = data;
        });
    }
}());