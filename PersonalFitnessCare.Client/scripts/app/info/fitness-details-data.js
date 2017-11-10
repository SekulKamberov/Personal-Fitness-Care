(function () {
    'use strict';

    var fitnessDetailsData = function fitnessDetailsData(data, $window) {

        function addFitnessDay(choice) {  
            console.log(choice);
            return data.post('api/info/AddTrainingDay', choice);
        }

        function getWorkouts(id) {   
            return data.get('api/info/workoutDetails/' + id);  
        }

        function strategyDetails(id) {  
            return data.get('api/info/sportDetails/' + id);
        }

        function editProject(project) {
            return data.post('projects/edit', project, true);
        }

        function hideProject(id) {
            return data.post('projects/hide/' + id, null, true);
        }

        function unhideProject(id) {
            return data.post('projects/unhide/' + id, null, true);
        }

        return {
            addFitnessDay: addFitnessDay,
            getWorkouts: getWorkouts,
            strategyDetails: strategyDetails,
            editProject: editProject,
            hideProject: hideProject,
            unhideProject: unhideProject
        };
    };

    angular.module('fitnessApp')
        .factory('fitnessDetailsData', ['data', '$window', fitnessDetailsData]);
}());