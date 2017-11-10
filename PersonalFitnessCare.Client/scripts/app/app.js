(function () {
    'use strict';

    function config($routeProvider, $locationProvider, $httpProvider, routeResolversProvider) {

        var CONTROLLER_VIEW_MODEL_NAME = 'vm';

        $locationProvider.html5Mode(true);

        var routeResolveChecks = routeResolversProvider.$get();

        var routeResolvers = {
            authenticationRequired: {
                authenticate: ['$q', 'auth', function ($q, auth) {
                    if (auth.isAuthenticated()) {
                        return true;
                    }

                    return $q.reject('not authorized');
                }]
            }
        }

        $routeProvider
            .when('/personal', {
                templateUrl: 'partials/details/personal.html',
                controller: 'DetailsController',
                controllerAs: CONTROLLER_VIEW_MODEL_NAME
            })
            .when('/', {
                templateUrl: 'partials/home/home.html',
                controller: 'HomeController',
                controllerAs: CONTROLLER_VIEW_MODEL_NAME
            })
            .when('/info/build', {
                templateUrl: 'partials/info/info.html',
                controller: 'InfoController',
                controllerAs: CONTROLLER_VIEW_MODEL_NAME,
                resolve: routeResolveChecks.fitnessDetails             
            })
            .when('/info', {
                templateUrl: 'partials/info/info.html',
                controller: 'InfoController',
                controllerAs: CONTROLLER_VIEW_MODEL_NAME,
                resolve: routeResolveChecks.user
            })
            .when('/identity/register', {
                templateUrl: 'partials/identity/register.html',
                controller: 'RegisterController',
                controllerAs: CONTROLLER_VIEW_MODEL_NAME
            })
            .when('/identity/login', {
                templateUrl: 'partials/identity/login.html',
                controller: 'LoginController',
                controllerAs: CONTROLLER_VIEW_MODEL_NAME
            })
            .when('/people/add', {
                templateUrl: 'partials/people/add-person.html',
                controller: 'AddPeopleController',
                controllerAs: CONTROLLER_VIEW_MODEL_NAME
            })
            .when('/people', {
                templateUrl: 'partials/people/search-person.html',
                controller: 'SearchPersonController',
                controllerAs: CONTROLLER_VIEW_MODEL_NAME
            })
            .otherwise({ redirectTo: '/' });
    }

    function run($http, $cookies, $rootScope, $location, auth) {
        $rootScope.$on('$routeChangeError', function (ev, current, previous, rejection) {
            if (rejection === 'not authorized') {
                $location.path('/');
            }
        });

        if (auth.isAuthenticated()) {
            $http.defaults.headers.common.Authorization = 'Bearer ' + $cookies.get('authentication');
            auth.getIdentity();
        }
    };

    angular.module('fitnessApp.services', []);
    angular.module('fitnessApp.data', []);
    angular.module('fitnessApp.directives', []);
    angular.module('fitnessApp.controllers', ['fitnessApp.services', 'fitnessApp.data']);

    angular.module('fitnessApp', ['ngRoute', 'ngCookies', 'fitnessApp.controllers', 'fitnessApp.directives'])
        .config(['$routeProvider', '$locationProvider', '$httpProvider', 'routeResolversProvider', config])
        .run(['$http', '$cookies', '$rootScope', '$location', 'auth', run])
        .constant('baseUrl', 'http://localhost:9048/');
}());