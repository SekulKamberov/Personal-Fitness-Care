(function () {
    'use strict';

    var programsDirective = function programsDirective(fitnessDetailsData) {
        return {
            restrict: 'A',
            templateUrl: 'partials/info/programs-directive.html',
            scope: {
                basedetails: '='
            },
            link: function (scope, element) {

                scope.basedetails = [{}];

                scope.addNewChoice = function () {
                    var newItemNo = scope.basedetails.length + 1;
                    scope.basedetails.push({});
                };
               
                scope.removeChoice = function () {
                    var lastItem = scope.basedetails.length - 1;
                    scope.basedetails.splice(lastItem);
                };

                scope.submitMuscleSplit = function (basedetails) {
                    fitnessDetailsData.addFitnessDay(basedetails)
                        .then(function (id) {
                            $location.path('api/info/program/' + id);
                        }, function () {
                            scope.disabledSubmit = false;
                        });
                }
            }  
        }
    }

    angular.module('fitnessApp.directives')
        .directive('programsDirective', ['fitnessDetailsData', programsDirective])
}());