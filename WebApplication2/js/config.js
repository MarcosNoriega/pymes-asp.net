app.config(function ($routeProvider) {
    $routeProvider
        .when('/', {
            templateUrl: 'partials/tablaArticulos.html',
            controller: 'myController'
        })
        .when('/articulo', {
            templateUrl: 'partials/formArticulo.html',
            controller: 'myController'
        })
        .otherwise({
            redirectTo: '/'
        })
});