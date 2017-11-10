(function () {
    'use strict';

    function listedPeopleDirective() {
        return {
            restrict: 'A',
            templateUrl: 'partials/people/listed-people-directive.html'
        }
    }

    angular.module('fitnessApp.directives')
        .directive('listedPeopleDirective', [listedPeopleDirective])
}());