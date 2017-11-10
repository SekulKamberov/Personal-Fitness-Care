(function () {
    'use strict';

    function DetailsController($location, auth) {
        var vm = this;
        if (user.details) {
            vm.addDetails = function (data, personalDetais) {
                if (personalDetais.$valid) {
                    console.log('...Adding user details...');
                    details.addBasic(data)
                        .then(function () {
                            console.log('...Details added...');
                            $location.path('/identity/login');
                        });
                }
            }
        }
    }

    angular.module('fitnessApp.controllers')
        .controller('DetailsController', ['$location', 'auth', DetailsController]);
}());