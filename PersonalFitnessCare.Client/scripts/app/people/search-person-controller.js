(function () {
    'use strict';

    function SearchPersonController($scope, people) {
        var vm = this;
        vm.currentPage = 1;

        people.search()
            .then(function (initialPeople) {
                vm.people = initialPeople;
            });

        $scope.$watch('request.name', function (newVal, oldVal) {
            people.search($scope.request)
                .then(function (filtered) {
                    vm.people = filtered;
                });
        });

        vm.search = function (request, page) {
            request = request || {};
            request.page = page;

            vm.currentPage = page;

            people.search(request)
                .then(function (filteredCats) {
                    vm.people = filteredCats;
                });
        }
    }

    angular.module('fitnessApp.controllers')
        .controller('SearchPersonController', ['$scope', 'people', SearchPersonController]);
}());