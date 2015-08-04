(function () {
    "use strict";
    angular
        .module("LMS")
        .controller("bookController",
                     bookController);

    function bookController() {
        var vm = this;

        vm.books = [{ "$id": "1", "id": 1, "name": "War and Peace", "author": "Tolstoy", "price": 19.95 }, { "$id": "2", "id": 2, "name": "As I Lay Dying", "author": "Faulkner", "price": 9.95 }, { "$id": "3", "id": 3, "name": "Harry Potter 1", "author": "J.K. Rowling", "price": 29.95 }, { "$id": "4", "id": 4, "name": "Pro Win 8", "author": "Liberty", "price": 49.95 }, { "$id": "5", "id": 5, "name": "Book one", "author": "Author1", "price": 10.95 }, { "$id": "6", "id": 6, "name": "Book two", "author": "Authro2", "price": 20.95 }, { "$id": "7", "id": 7, "name": "Book three", "author": "Author3", "price": 30.95 }];
    }
}());