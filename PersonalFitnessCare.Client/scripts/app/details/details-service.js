﻿(function () {
    'use strict';

    var detailsService = function detailsService($http, $q, $cookies, identity, baseUrl) {
        var TOKEN_KEY = 'authentication'; // cookie key

        var addBasic = function addBasic(data) {
            var defered = $q.defer();

            $http.post(baseUrl + 'api/profile/register', user)
                .then(function () {
                    defered.resolve(true);
                }, function (err) {
                    defered.reject(err);
                });

            return defered.promise;
        }

        var login = function login(user) {
            var deferred = $q.defer();

            // process data with url encoded format because API expects it this way
            var data = "grant_type=password&username=" + (user.username || '') + '&password=' + (user.password || '');

            // set header in order to prevent Angular making data to JSON
            $http.post(baseUrl + 'Token', data, { headers: { 'Content-Type': 'application/x-www-form-urlencoded' } })
                .success(function (response) {
                    //console.log(response);
                    var tokenValue = response.access_token; // token for authorized access

                    // cookie expiration date (set it to whatever you want)
                    var theBigDay = new Date();
                    theBigDay.setHours(theBigDay.getHours() + 72);

                    // save cookie for refresh scenarios
                    $cookies.put(TOKEN_KEY, tokenValue, { expires: theBigDay });

                    // set default Authorization header so that we do not need to provide the header with every request
                    $http.defaults.headers.common.Authorization = 'Bearer ' + tokenValue;

                    getIdentity().then(function () {
                        deferred.resolve(response);
                    });
                })
                .error(function (err) {
                    deferred.reject(err);
                });

            return deferred.promise;
        };

        //var getuserDetails = function () {
        //    var deferred = $q.defer();

        //    $http.get(baseUrl + '/api/account/identity')
        //        .success(function (userDetails) {
        //            if (!userDetails == 0)
        //            {
        //                deferred.resolve(identityResponse);
        //            }

        //        });

        //    return deferred.promise;
        //}; 

        var detailsCheck = function () {
            var deferred = $q.defer();

            $http.get(baseUrl + '/api/account/identity')
                .success(function (identityResponse) {
                    identity.setUser(identityResponse);
                    deferred.resolve(identityResponse);
                });

            return deferred.promise;
        };

        var getIdentity = function () {
            var deferred = $q.defer();
            //console.log("before ajax to .../api/account/identity");
            $http.get(baseUrl + '/api/account/identity')
                .success(function (identityResponse) {
                    console.log(identityResponse);
                    identity.setUser(identityResponse);
                    deferred.resolve(identityResponse);
                });

            return deferred.promise;
        };

        return {
            addBasic: addBasic,
            login: login,
            getIdentity: getIdentity,
            isAuthenticated: function () {
                return !!$cookies.get(TOKEN_KEY);
            },
            logout: function () {
                $cookies.remove(TOKEN_KEY);
                $http.defaults.headers.common.Authorization = null;
                identity.removeUser();
            },
        };
    };

    angular
        .module('fitnessApp.services')
        .factory('auth', ['$http', '$q', '$cookies', 'identity', 'baseUrl', detailsService]);
}());