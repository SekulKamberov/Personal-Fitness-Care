(function () {
    'use strict';

    var routeResolversProvider = function routeResolversProvider() {
        var routeResolvers = {

            user: ['$route', 'userProfileData', function ($route, userProfileData) {
                var routeParams = $route.current.params;
                return userProfileData.getUser();
            }]

        };

        var routeResolveChecks = {

            user: {
                user: routeResolvers.user
            }
        };

        return {
            $get: function () {
                return routeResolveChecks;
            }
        };
    };

    angular
        .module('fitnessApp')
        .provider('routeResolvers', routeResolversProvider);
}());