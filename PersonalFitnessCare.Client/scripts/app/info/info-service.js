(function () {
    'use strict';

    var infoService = function infoService($scope, $q, data){

        var PEOPLE_API_URL = 'api/info';

        var user = $scope.user;

        var trainingDetails = function trainingDetails(id) {   
            return data.get(PEOPLE_API_URL, id);
        }


        return {
            infoService: infoService
        }
    }

    angular.module('fitnessApp.services')
        .factory('info', ['data', infoService])
}());