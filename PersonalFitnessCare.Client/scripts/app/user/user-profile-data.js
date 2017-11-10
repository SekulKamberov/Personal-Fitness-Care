(function () {
    'use strict';

    var userProfileData = function userProfileData(data) {
        function getUser() {
            return data.get('api/account/identity');
        }
 
        function getLikedProjects(username) {
            return data.get('projects/likedProjects/' + username + '/');
        }
        
        function getProfile(username) {
            return data.get('users/remoteProfile/' + username + '/');
        }

        return {
            getUser: getUser,
            getLikedProjects: getLikedProjects,
            getProfile: getProfile
        };
    };

    angular
        .module('fitnessApp.data')
        .factory('userProfileData', ['data', userProfileData]);
}());