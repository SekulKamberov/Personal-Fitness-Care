﻿(function () {
    'use strict';

    function MainController($location, auth, identity) {
        var vm = this;
        // this is for initial load of the page
        waitForLogin();

        vm.logout = function () {
            vm.globallySetCurrentUser = undefined;
            auth.logout();
            waitForLogin(); // this is for second login
            $location.path('/identity/login');
        };

        function waitForLogin() {
            identity.getUser()
                .then(function (user) {
                    vm.globallySetCurrentUser = user;
                });
        }
    }

    angular.module('fitnessApp')
        .controller('MainController', ['$location', 'auth', 'identity', MainController]);
}());