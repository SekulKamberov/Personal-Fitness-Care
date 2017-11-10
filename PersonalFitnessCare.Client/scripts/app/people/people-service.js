(function () {
    'use strict';

    function peopleService(data) {

        var PERSON_API_URL = 'api/people';

        function add(person) {
            return data.post(PERSON_API_URL, person);
        }

        function search(request) {
            return data.get(PERSON_API_URL, request);
        }

        return {
            add: add,
            search: search
        }
    }

    angular.module('fitnessApp.services')
        .factory('people', ['data', peopleService])
}());