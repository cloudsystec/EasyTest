(function () {
    'use strict';

    var app = angular.module('app', [
        // Angular modules
        'ngAnimate',
        'ngRoute',
        'oitozero.ngSweetAlert',
        'ngMaterial', 'ngMessages',
        //'material.svgAssetsCache'

        // Custom modules

        // 3rd Party Modules
        
    ]);

    app.config(function($routeProvider, $locationProvider) {
        
        $routeProvider
            .when("/",
            {
                templateUrl: "steps.html"
            })
            .when("/persons",
            {
                templateUrl: "persons.html"
            })
            .otherwise({
                redirect: "/"
            });

        $locationProvider.html5Mode(true);
    });
})();
