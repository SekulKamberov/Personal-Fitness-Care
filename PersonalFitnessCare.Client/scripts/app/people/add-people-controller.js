(function () {
    'use strict';

    function AddPeopleController($location, people) {
        var vm = this;

        vm.addPerson = function (person, personForm) {
            if (peopleForm.$valid) {
                people.add(person)
                    .then(function (Id) {
                        $location.path('/people/details/' + Id);
                    });
            }
        }
    }

    angular.module('fitnessApp.controllers')
        .controller('AddPeopleController', ['$location', 'people', AddPeopleController])
}());