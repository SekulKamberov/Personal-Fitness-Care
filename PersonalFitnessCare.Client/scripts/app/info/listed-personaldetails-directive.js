(function () {
    'use strict';

    function listedPersonaldetailsDirective() {
        return {
            restrict: 'A',
            templateUrl: 'partials/info/listed-personaldetails-directive.html'
        }
    }

    angular.module('fitnessApp.directives')
        .directive('listedPersonaldetailsDirective', [listedPersonaldetailsDirective])
}());