app = angular.module('pymesApp', ['ngRoute']);

app.controller('myController', ['$scope', '$http', function ($scope, $http) {

    $scope.articulos = [];

    $scope.cargarArticulos = function () {
        $http.get('api/Articulos').then(function (res) {
            $scope.articulos = res.data;
        });

    } 

    $scope.cargarArticulos();
}]);