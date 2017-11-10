(function () {
    'use strict';

    function HomeController(people) {
        var vm = this;

        people.search({ page: 1 })
            .then(function (initialCats) {
                vm.people = initialCats;
            });
    }

    angular.module('fitnessApp.controllers')
        .controller('HomeController', ['people', HomeController]);
}());