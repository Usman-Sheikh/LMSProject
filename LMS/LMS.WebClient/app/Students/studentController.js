


    (function(){

        var CustomerController=function($scope){
    
            $scope.sortBy = 'name';
            $scope.reverse = false;
            $scope.Customers = [{ name: 'Bilal', city: 'Lahore', joined: '20-03-2013', TotalOrder: '12' }, { name: 'Baber', city: 'Lala Musa', joined: '4-12-2013', TotalOrder: '13' }, { name: 'Asad', city: 'Pindi', joined: '24-06-2013', TotalOrder: '14' }, { name: 'Ali', city: 'Multan', joined: '10-07-2015', TotalOrder: '15' }]
            $scope.dosort = function (propname) {
                $scope.sortBy = propname;
                $scope.reverse = !$scope.reverse;
            };
        };
        CustomerController.$inject = ['$scope'];

        angular.module('LMS')
        .controller('CustomerController', CustomerController);
}());