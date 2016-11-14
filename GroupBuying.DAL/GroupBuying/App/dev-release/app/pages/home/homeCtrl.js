/**
 * @author v.lugovksy
 * created on 16.12.2015
 */
(function () {
    'use strict';

    angular.module('CollectiveP.pages.home')
        .controller('HomeCtrl', HomeCtrl);

    /** @ngInject */
    function HomeCtrl($scope, baConfig,$http) {
        $http.get("Home/Index").success(function (data, status) {
            $scope.name = data.firstname;
        });
    }
})();