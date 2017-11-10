(function () {
    'use strict';

    var userProfileController = function userProfileController(userProfileData, identity, user, profile) {
        var vm = this;
    };

    angular
        .module('fitnessApp.controllers')
        .controller('UserProfileController', ['userProfileData', 'identity', 'user', 'profile', userProfileController]);
}());