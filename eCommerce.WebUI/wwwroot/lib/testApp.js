(function () {

    var app = angular.module('testApp', []);
    app.controller('HomeController', ['$scope', function ($scope) {
        $scope.Message = "Default message ";
        $scope.Task1 = "Task One";
        $scope.Task2 = "Task Two";
        $scope.Task3 = "Task Three";
        $scope.Task4 = "Task Four";
        $scope.Task5 = "Task Five";

    }]);
})();

