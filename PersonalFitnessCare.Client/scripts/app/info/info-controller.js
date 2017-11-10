(function () {
    'use strict';

    function InfoController($location, $routeParams, user, userProfileData, fitnessDetailsData) {
        var vm = this;
        vm.user = user;
    }

    angular.module('fitnessApp.controllers')
        .controller('InfoController', ['$location', '$routeParams', 'user', 'userProfileData', 'fitnessDetailsData', InfoController]);
}());